﻿using CCWin;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace GroundAnalyser
{
    public partial class Form_ImgOrigShow : Skin_DevExpress
    {
        private Graphics graphicImgOrig;					    //图像控件对象
        private FileStream fileImgOrigShow;						//原始图像文件
        private Byte[] bufImgOrig; //一帧缓存-图像
        private Byte[] bufShowOrig; //一帧缓存-显示
        private Bitmap bmpImgOrigShow;						    //bmp对象
        private BitmapData dataImgOrig;                         //bmp数据
        private short startPicNum;                                //起始图像编号
        private short endPicNum;                                  //终止图像编号
        private short specNum;                                  //谱线编号

        public Form_ImgOrigShow()
        {
            InitializeComponent();

        }

        public void Form_ImgOrigShow_Load(object sender, System.EventArgs e)
        {
          
        }

        //读取原始图像
        private Int16 readImgOrig(UInt16 frm)
        {
            UInt32 len = 0;
            while (len == 0)
            {
                if (File.Exists(GlobalVariable.pathImgPathShow + frm.ToString() + ".raw"))
                {
                    try
                    {
                        fileImgOrigShow = new FileStream(GlobalVariable.pathImgPathShow + frm.ToString() + ".raw", FileMode.Open, FileAccess.Read, FileShare.Read);  //显示原始图
                    }
                    catch
                    {
                        len = 0;
                        continue;
                    }
                    len = (UInt32)fileImgOrigShow.Length;				//文件长度
                    
                    //fullFile.Seek(256, SeekOrigin.Begin);		        //定位读取文件的起始位置
                    fileImgOrigShow.Read(bufImgOrig, 0, (int)len);      //读文件
                    fileImgOrigShow.Close();                            //关闭文件
                }
                else
                    return -1;  //文件不存在
            }
            return 1;
        }

        //转为灰度图
        private static void convRGB(Byte[] inI, Byte[] outI)
        {
            UInt32 i = 0;
            for (i = 0; i < GlobalVariable.IMG_FULL_WID * GlobalVariable.IMG_FULL_HEI; i++)
            {
                outI[i * 3] = (Byte)(inI[i * 2 + 1] << GlobalVariable.moveLeftHigh | inI[i * 2] >> GlobalVariable.moveRightLow);
                outI[i * 3 + 1] = outI[i * 3];
                outI[i * 3 + 2] = outI[i * 3];
            }
        }

        //显示图像
        private void showImgOrig(Byte[] buf)
        {
            dataImgOrig = bmpImgOrigShow.LockBits(new Rectangle(0, 0, bmpImgOrigShow.Width, bmpImgOrigShow.Height), ImageLockMode.WriteOnly, bmpImgOrigShow.PixelFormat);	//bmp数据
            System.Runtime.InteropServices.Marshal.Copy(buf, 0, dataImgOrig.Scan0, buf.Length);
            bmpImgOrigShow.UnlockBits(dataImgOrig);
            graphicImgOrig.DrawImage(bmpImgOrigShow, 0, 0);
        }

        //显示FULL
        private void _threadImgOrigShow()
        {
            UInt16 curFullShowID = 0,errCnt = 0;
            while (errCnt<100)
            {
                if (readImgOrig(curFullShowID) < 0)
                {
                    errCnt++;
                    continue;
                }
                convRGB(bufImgOrig, bufShowOrig);
                showImgOrig(bufShowOrig);
                curFullShowID++;
                Thread.Sleep(500);
            }
        }

        private void _threadImgJoint()
        {
            bufShowOrig = new Byte[2048*(endPicNum-startPicNum+1)*3];

            for (int i = startPicNum; i <= endPicNum; i++)
            {
                Byte[] row = new Byte[4096];
                fileImgOrigShow = new FileStream(GlobalVariable.pathImgPathShow + i.ToString() + ".raw", FileMode.Open, FileAccess.Read, FileShare.Read);  //显示原始图

                for (int t = 0; t < specNum * 4096; t++) fileImgOrigShow.ReadByte();
                
                fileImgOrigShow.Read(row,0, 4096);      //读文件
                fileImgOrigShow.Close();

                for (int j = 0; j < 2048; j++)
                {
                    bufShowOrig[3 * (i-startPicNum) * 2048 + 3 * j] = row[2 * j];
                    bufShowOrig[3 * (i - startPicNum)* 2048 + 3 * j+1] = bufShowOrig[3 * (i - startPicNum) * 2048 + 3 * j];
                    bufShowOrig[3 * (i - startPicNum) * 2048 + 3 * j +2]= bufShowOrig[3 * (i - startPicNum) * 2048 + 3 * j];
                }



            }

        }


        #region 左侧控制面板
        private void textBox_startPicNum_textChanged(object sender,EventArgs e)
        {
            this.startPicNum =(short) UInt16.Parse(this.textBox_startPicNum.Text);


        }
        private void textBox_endPicNum_textChanged(object sender, EventArgs e)
        {
            this.endPicNum = (short)UInt16.Parse(this.textBox_endPicNum.Text);
        }

        private void numericUpDown_specNum_ValueChanged(object sender, EventArgs e)
        {
            this.specNum = (short)this.numericUpDown_specNum.Value;
        }

        private void button_joint_Click(object sender, EventArgs e)
        {
           
            graphicImgOrig = picture_ImgOrig.CreateGraphics();								//图像控件对象
            bmpImgOrigShow = new Bitmap(2048, this.endPicNum-this.startPicNum+1, PixelFormat.Format24bppRgb);  //bmp对象
                                                                                                                                // Thread threadImgOrigShow = new Thread(new ThreadStart(_threadImgOrigShow));
                                                                                                                                // threadImgOrigShow.Start();
            //Thread threadImgJoint = new Thread(new ThreadStart(_threadImgJoint));
            //threadImgJoint.Start();
            _threadImgJoint();
            showImgOrig(bufShowOrig);
            this.picture_ImgOrig.Image = bmpImgOrigShow;
        }
        #endregion
    }
}
