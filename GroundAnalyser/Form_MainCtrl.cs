using System;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using System.IO;

namespace GroundAnalyser
{
    public partial class Form_MainCtrl : Skin_DevExpress
    {
        #region 主窗体
        public Form_MainCtrl()
        {
            InitializeComponent();
            GlobalVariable.global_FrmMain = this;
            if (!Directory.Exists("..\\data"))
                Directory.CreateDirectory("..\\data");
            GlobalFunction.initDataSet();
        }

        private void Form_MainCtrl_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);		//退出所有窗体相关（包括所有线程）
        }
        #endregion

        #region 面板1
        private void btn_Analyse_Click(object sender, EventArgs e)
        {
            panel_Analyse.Visible = true;
            panel_Decompress.Visible = false;
            panel_DataTrans.Visible = false;
        }

        private void btn_OrigShow_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Raw Files(*.raw)|*.raw|Data Files(*.dat)|*.dat|All Files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                GlobalVariable.pathImgPathShow = openFile.FileName.Substring(0, openFile.FileName.LastIndexOf('\\') + 1);
                if (GlobalVariable.global_FrmImgOrigShow.IsDisposed == true)
                    GlobalVariable.global_FrmImgOrigShow = new Form_ImgOrigShow();
                GlobalVariable.global_FrmImgOrigShow.Show();
            }
        }
        #endregion

        #region 面板2
        private void btn_Decompress_Click(object sender, EventArgs e)
        {
            panel_Analyse.Visible = false;
            panel_Decompress.Visible = true;
            panel_DataTrans.Visible = false;
        }

        #region 原始数据解包
        private void btn_OrigResolve_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt|Raw Files(*.raw)|*.raw|Data Files(*.dat)|*.dat|All Files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                GlobalVariable.fileOrig.fileOnlyName = openFile.SafeFileName;
                GlobalVariable.fileOrig.fileAllName = openFile.FileName;
                if (GlobalFunction.fileResolve(list_OrigResolve, ref GlobalVariable.fileOrig, ref GlobalVariable.fileComp) == 1)
                    timer_ListOrig.Start();
            }
        }

        //点击List显示气泡
        private void list_OrigResolve_Click(object sender, EventArgs e)
        {
            if(list_OrigResolve.SelectedIndex >= 0)
            {
                tip_List.SetToolTip(list_OrigResolve, list_OrigResolve.Items[list_OrigResolve.SelectedIndex].ToString());
            }
        }

        //定时器刷新进度条
        public void timerListOrig_Tick(object sender, EventArgs e)
        {
            prog_OrigResolve.Value = (Int16)((float)GlobalVariable.curOrigPosiCnt / GlobalVariable.fileOrig.fileLength * 1000);
            if (prog_OrigResolve.Value == prog_OrigResolve.Maximum)
                timer_ListOrig.Stop();
        }
        #endregion

        #region 压缩数据分包
        private void btn_CompSplit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Raw Files(*.raw)|*.raw|Data Files(*.dat)|*.dat|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                GlobalVariable.fileComp.fileOnlyName = openFile.SafeFileName;
                GlobalVariable.fileComp.fileAllName = openFile.FileName;
                if (GlobalFunction.fileSplit(list_CompSplit, ref GlobalVariable.fileComp,ref GlobalVariable.fileCompSplit) == 1)
                    timer_ListComp.Start();
            }
        }

        //点击List显示气泡
        private void list_CompSplit_Click(object sender, EventArgs e)
        {
            if (list_CompSplit.SelectedIndex >= 0)
            {
                tip_List.SetToolTip(list_CompSplit, list_CompSplit.Items[list_CompSplit.SelectedIndex].ToString());
            }
        }

        //定时器刷新进度条
        private void timer_ListComp_Tick(object sender, EventArgs e)
        {
            prog_CompSplit.Value = (Int16)((float)GlobalVariable.curCompPosiCnt / GlobalVariable.fileComp.fileLength * 1000);
            if (prog_CompSplit.Value == prog_CompSplit.Maximum)
                timer_ListComp.Stop();
        }
        #endregion

        #region 压缩数据解压
        private void btn_CompDecomp_Click(object sender, EventArgs e)
        {
            if (GlobalVariable.global_FrmReport.IsDisposed == true)
                GlobalVariable.global_FrmReport = new Form_Report();
            GlobalVariable.global_FrmReport.Show();
            //GlobalFunction.C288To280();
        }
        #endregion

        #region 委托
        //更改列表的委托
        delegate void SetListCallback(SkinListBox list, String str);

        public void SetList(SkinListBox list, String str)
        {
            if (list_OrigResolve.InvokeRequired)
            {
                SetListCallback d = new SetListCallback(SetList);
                this.Invoke(d, new object[] { list, str });
            }
            else
            {
                GlobalFunction.listAddItem(list, str);
            }
        }

        //显示报表的委托
        delegate void ShowReportCallback();

        public void ShowReport()
        {
            if (list_OrigResolve.InvokeRequired)
            {
                ShowReportCallback d = new ShowReportCallback(ShowReport);
                this.Invoke(d, new object[] { });
            }
            else
            {
                GlobalFunction.addRowToErrCnt("帧头错误", GlobalVariable.cntErrHead);
                GlobalFunction.addRowToErrCnt("帧尾错误", GlobalVariable.cntErrTail);
                GlobalFunction.addRowToErrCnt("校验和错误", GlobalVariable.cntErrSum);
                if (GlobalVariable.global_FrmReport.IsDisposed == true)
                    GlobalVariable.global_FrmReport = new Form_Report();
                GlobalVariable.global_FrmReport.Show();
            }
        }
        #endregion
        #endregion

        #region 面板3
        private void btn_DataTrans_Click(object sender, EventArgs e)
        {
            panel_Analyse.Visible = false;
            panel_Decompress.Visible = false;
            panel_DataTrans.Visible = true;
        }
        #endregion
    }
}
