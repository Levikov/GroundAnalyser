using CCWin.SkinControl;
using GroundAnalyser;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GroundAnalyser
{
    public class GlobalFunction
    {
        public GlobalFunction()
        {
        }

        public static void listAddItem(SkinListBox list, String str)
        {
            SkinListBoxItem item = new SkinListBoxItem();
            item.Text = "[" + DateTime.Now.ToLongTimeString() + "] " + str;
            list.Items.Insert(0, item);
        }

        #region 原图解包
        //ref用于传递实参
        public static Int16 fileResolve(SkinListBox list, ref GlobalVariable.OperaFile fileIn, ref GlobalVariable.OperaFile fileOut)
        {
            if (File.Exists(fileIn.fileAllName))
            {
                listAddItem(list, "输入文件：" + fileIn.fileAllName);
                fileOut.fileOnlyName = fileIn.fileOnlyName.Substring(0, fileIn.fileOnlyName.IndexOf('.')) + "_comp.raw";
                fileOut.fileAllName = "..\\data\\" + fileOut.fileOnlyName;
                try
                {
                    fileOut.file = new FileStream(fileOut.fileAllName, FileMode.Create, FileAccess.Write, FileShare.Read);
                    fileIn.file = new FileStream(fileIn.fileAllName, FileMode.Open, FileAccess.Read, FileShare.Read);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString(), "文件打开失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listAddItem(list, e.Message.ToString());
                    return -2;
                }
                fileIn.fileLength = fileIn.file.Length;
                listAddItem(list, "输入文件长度：" + fileIn.fileLength.ToString() + "B");
                if (fileIn.fileLength > (long)4 * 1024 * 1024 * 1024)
                {
                    MessageBox.Show("输入文件大于4G，请分包后重新操作！", "文件过大", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listAddItem(list, "输入文件大于4G，请分包后重新操作！");
                    fileIn.file.Close();
                    fileOut.file.Close();
                    return -3;
                }
                fileIn.filePath = fileIn.fileAllName.Substring(0, fileIn.fileAllName.LastIndexOf('\\') + 1);
                fileOut.filePath = fileOut.fileAllName.Substring(0, fileOut.fileAllName.LastIndexOf('\\') + 1);
                fileOut.fileLength = 0;
                fileOut.fileAllName = fileOut.file.Name;
                listAddItem(list, "输出文件：" + fileOut.fileAllName);
                listAddItem(list, "开始解包...");
                GlobalVariable.threadOrigResolve = new Thread(new ThreadStart(_threadFileResolve));
                GlobalVariable.threadOrigResolve.Start();
            }
            else
            {
                MessageBox.Show("文件不存在！", "文件打开失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return 1;
        }

        //解包线程
        public static void _threadFileResolve()
        {
            Boolean stateJump = false;
            GlobalVariable.curOrigPosiCnt = 0;
            GlobalVariable.fileOrig.fileBuf = new Byte[GlobalVariable.LEN_ORIG];
            while (GlobalVariable.curOrigPosiCnt < GlobalVariable.fileOrig.fileLength)
            {
                GlobalVariable.fileOrig.file.Read(GlobalVariable.fileOrig.fileBuf, 0, GlobalVariable.LEN_ORIG);
                if (stateJump == false)
                {
                    if ((UInt32)(GlobalVariable.fileOrig.fileBuf[12] << 24 | GlobalVariable.fileOrig.fileBuf[13] << 16 | GlobalVariable.fileOrig.fileBuf[14] << 8 | GlobalVariable.fileOrig.fileBuf[15]) == 0xEB905716)
                    {
                        stateJump = true;
                        GlobalVariable.fileComp.file.Write(GlobalVariable.fileOrig.fileBuf, 12, 884);
                    }
                }
                else
                    GlobalVariable.fileComp.file.Write(GlobalVariable.fileOrig.fileBuf, 12, 884);
                GlobalVariable.curOrigPosiCnt += GlobalVariable.LEN_ORIG;
            }
            GlobalVariable.fileOrig.file.Close();
            GlobalVariable.fileComp.file.Close();
            GlobalVariable.global_FrmMain.SetList(GlobalVariable.global_FrmMain.list_OrigResolve, "解包完成!");
        }
        #endregion
        
        #region 压缩图分包
        public static Int16 fileSplit(SkinListBox list, ref GlobalVariable.OperaFile fileIn, ref GlobalVariable.OperaFile[] fileOut)
        {
            if (File.Exists(fileIn.fileAllName))
            {
                listAddItem(list, "输入文件：" + fileIn.fileAllName);
                try
                {
                    fileIn.file = new FileStream(fileIn.fileAllName, FileMode.Open, FileAccess.Read, FileShare.Read);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString(), "文件打开失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listAddItem(list, e.Message.ToString());
                    return -2;
                }
                fileIn.fileLength = fileIn.file.Length;
                listAddItem(list, "输入文件长度：" + fileIn.fileLength.ToString() + "B");
                if (fileIn.fileLength > (long)4 * 1024 * 1024 * 1024)
                {
                    MessageBox.Show("输入文件大于4G，请分包后重新操作！", "文件过大", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listAddItem(list, "输入文件大于4G，请分包后重新操作！");
                    fileIn.file.Close();
                    return -3;
                }
                fileIn.filePath = fileIn.fileAllName.Substring(0, fileIn.fileAllName.LastIndexOf('\\') + 1);
                //文件输出的路径
                for (Int16 i = 0; i < 4; i++)
                {
                    fileOut[i].filePath = "..\\data\\" + fileIn.fileOnlyName.Substring(0, fileIn.fileOnlyName.IndexOf('.')) + "_" + (i + 1).ToString() + "\\";
                    if (!Directory.Exists(fileOut[i].filePath))
                        Directory.CreateDirectory(fileOut[i].filePath);
                }
                listAddItem(list, "输出文件：..\\data");
                listAddItem(list, "开始分包...");
                GlobalVariable.threadCompSplit = new Thread(new ThreadStart(_threadFileSplit));
                GlobalVariable.threadCompSplit.Start();
            }
            else
            {
                MessageBox.Show("文件不存在！", "文件打开失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return 1;
        }

        //分包线程
        public static void _threadFileSplit()
        {
            GlobalVariable.curCompPosiCnt = 0;
            GlobalVariable.fileComp.fileBuf = new Byte[GlobalVariable.LEN_COMP];
            while (GlobalVariable.curCompPosiCnt < GlobalVariable.fileComp.fileLength)
            {
                GlobalVariable.fileComp.file.Read(GlobalVariable.fileComp.fileBuf, 0, GlobalVariable.LEN_COMP);
                if (checkData(GlobalVariable.fileComp.fileBuf, GlobalVariable.curCompPosiCnt) == 1)
                {
                    if (GlobalVariable.fileComp.fileBuf[4] == 0x08)
                    {
                        if (GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].file != null)  //若文件存在
                            GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].file.Close();  //则关闭
                        GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].fileAllName = GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].filePath + ((UInt16)(GlobalVariable.fileComp.fileBuf[6] << 8 | GlobalVariable.fileComp.fileBuf[7])).ToString() + ".raw";  //以帧号命名
                        GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].file = new FileStream(GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].fileAllName, FileMode.Create, FileAccess.Write, FileShare.Read);   //创建文件
                        GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].file.Write(GlobalVariable.fileComp.fileBuf, 0, GlobalVariable.LEN_COMP);   //写数据
                    }
                    else
                    {
                        GlobalVariable.fileCompSplit[GlobalVariable.fileComp.fileBuf[5] - 1].file.Write(GlobalVariable.fileComp.fileBuf, 0, GlobalVariable.LEN_COMP);   //写数据
                    }
                }
                GlobalVariable.curCompPosiCnt += GlobalVariable.LEN_COMP;
            }
            for (Int16 i = 0; i < 4; i++)
            {
                if(GlobalVariable.fileCompSplit[i].file != null)
                    GlobalVariable.fileCompSplit[i].file.Close();   //关闭文件
            }
            GlobalVariable.fileComp.file.Close();               //关闭文件
            GlobalVariable.global_FrmMain.SetList(GlobalVariable.global_FrmMain.list_CompSplit, "分包完成!");
            if (GlobalVariable.cntErrHead == 0 && GlobalVariable.cntErrTail == 0 && GlobalVariable.cntErrSum == 0)
            {
                GlobalVariable.global_FrmMain.SetList(GlobalVariable.global_FrmMain.list_CompSplit, "数据无错误!");
                GlobalVariable.global_FrmMain.ShowReport();
            }
            else
            {
                GlobalVariable.global_FrmMain.ShowReport();
            }
        }

        //校验数据
        public static Int16 checkData(Byte[] bufIn, long curPosi)
        {
            if ((UInt32)(bufIn[0] << 24 | bufIn[1] << 16 | bufIn[2] << 8 | bufIn[3]) != 0xEB905716)
            {
                GlobalVariable.cntErrHead++;
                addRowToErrDetail(curPosi / GlobalVariable.LEN_COMP, "帧头错误");
                return -1;
            }
            if ((UInt32)(bufIn[GlobalVariable.LEN_COMP - 4] << 24 | bufIn[GlobalVariable.LEN_COMP - 3] << 16 | bufIn[GlobalVariable.LEN_COMP - 2] << 8 | bufIn[GlobalVariable.LEN_COMP - 1]) != 0x13AB13AB)
            {
                GlobalVariable.cntErrTail++;
                addRowToErrDetail(curPosi / GlobalVariable.LEN_COMP, "帧尾错误");
                return -2;
            }
            UInt32 i = 0, sum = 0;
            //计算校验和
            for (i = 0; i < GlobalVariable.LEN_COMP - 8; )
            {
                sum += (UInt32)(bufIn[i + 0] << 24 | bufIn[i + 1] << 16 | bufIn[i + 2] << 8 | bufIn[i + 3]);
                i += 4;
            }
            //判断校验和
            if (sum != (UInt32)(bufIn[i + 0] << 24 | bufIn[i + 1] << 16 | bufIn[i + 2] << 8 | bufIn[i + 3]))
            {
                GlobalVariable.cntErrSum++;
                addRowToErrDetail(curPosi / GlobalVariable.LEN_COMP, "校验和错误");
                return -3;
            }
            return 1;
        }
        #endregion

        #region 数据库
        //初始化数据库
        public static void initDataSet()
        {
            //错误汇总
            GlobalVariable.dataErrSum.Columns.Add("编号", typeof(UInt16));
            GlobalVariable.dataErrSum.Columns.Add("错误类型", typeof(String));
            GlobalVariable.dataErrSum.Columns.Add("错误总数", typeof(long));
            //错误细则
            GlobalVariable.dataErrDetail.Columns.Add("编号", typeof(long));
            GlobalVariable.dataErrDetail.Columns.Add("错误包号", typeof(long));
            GlobalVariable.dataErrDetail.Columns.Add("错误类型", typeof(String));
        }

        //错误汇总表添加行
        public static void addRowToErrCnt(String str,long cnt)
        {
            DataRow row = GlobalVariable.dataErrSum.NewRow();
            row[0] = GlobalVariable.dataErrSum.Rows.Count + 1;
            row[1] = str;
            row[2] = cnt;
            GlobalVariable.dataErrSum.Rows.Add(row);
        }

        //错误细则表添加行
        public static void addRowToErrDetail(long cnt, String str)
        {
            DataRow row = GlobalVariable.dataErrDetail.NewRow();
            row[0] = GlobalVariable.dataErrDetail.Rows.Count + 1;
            row[1] = cnt;
            row[2] = str;
            //row[3] = "";
            //for (UInt16 i = 0; i < GlobalVariable.LEN_COMP; i++)
            //    row[3] += Convert.ToString(bufIn[i], 16);
            GlobalVariable.dataErrDetail.Rows.Add(row);
        }
        #endregion

        //转换288格式为280
        public static void C288To280()
        {
            FileStream F288 = new FileStream("E:\\数据源\\第二次该完程序_正确.raw", FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream F280 = new FileStream("E:\\数据源\\第二次该完程序_正确_280.raw", FileMode.Create, FileAccess.Write, FileShare.Read);
            long Flenth = F288.Length;
            long FcurPosi = 0;
            Byte[] buf = new Byte[288];
            while (FcurPosi < Flenth)
            {
                F288.Read(buf, 0, 288);
                F280.Write(buf, 0, 280);
                FcurPosi += 288;
            }
            F288.Close();
            F280.Close();
            MessageBox.Show("OK");
        }
    }
}