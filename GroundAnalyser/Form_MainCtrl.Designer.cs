namespace GroundAnalyser
{
    partial class Form_MainCtrl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainCtrl));
            this.group_BottomL = new CCWin.SkinControl.SkinGroupBox();
            this.btn_DataTrans = new DMSkin.Controls.DMButton();
            this.btn_Decompress = new DMSkin.Controls.DMButton();
            this.btn_Analyse = new DMSkin.Controls.DMButton();
            this.group_BottomR = new CCWin.SkinControl.SkinGroupBox();
            this.panel_Decompress = new System.Windows.Forms.Panel();
            this.group_DecR = new CCWin.SkinControl.SkinGroupBox();
            this.btn_CompDecomp = new DMSkin.Metro.Controls.MetroButton();
            this.group_DecM = new CCWin.SkinControl.SkinGroupBox();
            this.prog_CompSplit = new CCWin.SkinControl.SkinProgressBar();
            this.list_CompSplit = new CCWin.SkinControl.SkinListBox();
            this.btn_CompSplit = new DMSkin.Metro.Controls.MetroButton();
            this.group_DecL = new CCWin.SkinControl.SkinGroupBox();
            this.prog_OrigResolve = new CCWin.SkinControl.SkinProgressBar();
            this.list_OrigResolve = new CCWin.SkinControl.SkinListBox();
            this.btn_OrigResolve = new DMSkin.Metro.Controls.MetroButton();
            this.lbl_DecText = new System.Windows.Forms.Label();
            this.lbl_DecIco = new DMSkin.Controls.DMLabel();
            this.panel_Analyse = new System.Windows.Forms.Panel();
            this.btn_OrigShow = new DMSkin.Metro.Controls.MetroButton();
            this.lbl_AnaText = new System.Windows.Forms.Label();
            this.lbl_AnaIco = new DMSkin.Controls.DMLabel();
            this.panel_DataTrans = new System.Windows.Forms.Panel();
            this.lbl_DataText = new System.Windows.Forms.Label();
            this.lbl_DataIco = new DMSkin.Controls.DMLabel();
            this.tip_List = new System.Windows.Forms.ToolTip(this.components);
            this.timer_ListOrig = new System.Windows.Forms.Timer(this.components);
            this.timer_ListComp = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.group_BottomL.SuspendLayout();
            this.group_BottomR.SuspendLayout();
            this.panel_Decompress.SuspendLayout();
            this.group_DecR.SuspendLayout();
            this.group_DecM.SuspendLayout();
            this.group_DecL.SuspendLayout();
            this.panel_Analyse.SuspendLayout();
            this.panel_DataTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_BottomL
            // 
            this.group_BottomL.BackColor = System.Drawing.Color.Transparent;
            this.group_BottomL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.group_BottomL.Controls.Add(this.btn_DataTrans);
            this.group_BottomL.Controls.Add(this.btn_Decompress);
            this.group_BottomL.Controls.Add(this.btn_Analyse);
            this.group_BottomL.ForeColor = System.Drawing.Color.Black;
            this.group_BottomL.Location = new System.Drawing.Point(9, 40);
            this.group_BottomL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_BottomL.Name = "group_BottomL";
            this.group_BottomL.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_BottomL.RectBackColor = System.Drawing.Color.White;
            this.group_BottomL.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.group_BottomL.Size = new System.Drawing.Size(333, 908);
            this.group_BottomL.TabIndex = 0;
            this.group_BottomL.TabStop = false;
            this.group_BottomL.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.group_BottomL.TitleRectBackColor = System.Drawing.Color.White;
            this.group_BottomL.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btn_DataTrans
            // 
            this.btn_DataTrans.BackColor = System.Drawing.Color.Transparent;
            this.btn_DataTrans.DM_DisabledColor = System.Drawing.Color.Silver;
            this.btn_DataTrans.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btn_DataTrans.DM_MoveColor = System.Drawing.Color.SkyBlue;
            this.btn_DataTrans.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btn_DataTrans.DM_Radius = 6;
            this.btn_DataTrans.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DataTrans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DataTrans.Image = null;
            this.btn_DataTrans.Location = new System.Drawing.Point(76, 288);
            this.btn_DataTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DataTrans.Name = "btn_DataTrans";
            this.btn_DataTrans.Size = new System.Drawing.Size(180, 68);
            this.btn_DataTrans.TabIndex = 0;
            this.btn_DataTrans.TabStop = false;
            this.btn_DataTrans.Text = "数据传输";
            this.btn_DataTrans.UseVisualStyleBackColor = true;
            this.btn_DataTrans.Click += new System.EventHandler(this.btn_DataTrans_Click);
            // 
            // btn_Decompress
            // 
            this.btn_Decompress.BackColor = System.Drawing.Color.Transparent;
            this.btn_Decompress.DM_DisabledColor = System.Drawing.Color.Silver;
            this.btn_Decompress.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btn_Decompress.DM_MoveColor = System.Drawing.Color.SkyBlue;
            this.btn_Decompress.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btn_Decompress.DM_Radius = 6;
            this.btn_Decompress.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Decompress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Decompress.Image = null;
            this.btn_Decompress.Location = new System.Drawing.Point(76, 177);
            this.btn_Decompress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Decompress.Name = "btn_Decompress";
            this.btn_Decompress.Size = new System.Drawing.Size(180, 68);
            this.btn_Decompress.TabIndex = 0;
            this.btn_Decompress.TabStop = false;
            this.btn_Decompress.Text = "图像解压";
            this.btn_Decompress.UseVisualStyleBackColor = true;
            this.btn_Decompress.Click += new System.EventHandler(this.btn_Decompress_Click);
            // 
            // btn_Analyse
            // 
            this.btn_Analyse.BackColor = System.Drawing.Color.Transparent;
            this.btn_Analyse.DM_DisabledColor = System.Drawing.Color.Silver;
            this.btn_Analyse.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btn_Analyse.DM_MoveColor = System.Drawing.Color.SkyBlue;
            this.btn_Analyse.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btn_Analyse.DM_Radius = 6;
            this.btn_Analyse.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Analyse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Analyse.Image = null;
            this.btn_Analyse.Location = new System.Drawing.Point(76, 63);
            this.btn_Analyse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Analyse.Name = "btn_Analyse";
            this.btn_Analyse.Size = new System.Drawing.Size(180, 68);
            this.btn_Analyse.TabIndex = 0;
            this.btn_Analyse.TabStop = false;
            this.btn_Analyse.Text = "光谱分析";
            this.btn_Analyse.UseVisualStyleBackColor = true;
            this.btn_Analyse.Click += new System.EventHandler(this.btn_Analyse_Click);
            // 
            // group_BottomR
            // 
            this.group_BottomR.BackColor = System.Drawing.Color.Transparent;
            this.group_BottomR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.group_BottomR.Controls.Add(this.panel_Decompress);
            this.group_BottomR.Controls.Add(this.panel_Analyse);
            this.group_BottomR.Controls.Add(this.panel_DataTrans);
            this.group_BottomR.ForeColor = System.Drawing.Color.Black;
            this.group_BottomR.Location = new System.Drawing.Point(350, 40);
            this.group_BottomR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_BottomR.Name = "group_BottomR";
            this.group_BottomR.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_BottomR.RectBackColor = System.Drawing.Color.White;
            this.group_BottomR.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.group_BottomR.Size = new System.Drawing.Size(864, 908);
            this.group_BottomR.TabIndex = 0;
            this.group_BottomR.TabStop = false;
            this.group_BottomR.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.group_BottomR.TitleRectBackColor = System.Drawing.Color.White;
            this.group_BottomR.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // panel_Decompress
            // 
            this.panel_Decompress.Controls.Add(this.group_DecR);
            this.panel_Decompress.Controls.Add(this.group_DecM);
            this.panel_Decompress.Controls.Add(this.group_DecL);
            this.panel_Decompress.Controls.Add(this.lbl_DecText);
            this.panel_Decompress.Controls.Add(this.lbl_DecIco);
            this.panel_Decompress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Decompress.Location = new System.Drawing.Point(4, 21);
            this.panel_Decompress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_Decompress.Name = "panel_Decompress";
            this.panel_Decompress.Size = new System.Drawing.Size(856, 884);
            this.panel_Decompress.TabIndex = 0;
            // 
            // group_DecR
            // 
            this.group_DecR.BackColor = System.Drawing.Color.Transparent;
            this.group_DecR.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.group_DecR.Controls.Add(this.btn_CompDecomp);
            this.group_DecR.ForeColor = System.Drawing.Color.Black;
            this.group_DecR.Location = new System.Drawing.Point(4, 602);
            this.group_DecR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_DecR.Name = "group_DecR";
            this.group_DecR.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_DecR.RectBackColor = System.Drawing.Color.White;
            this.group_DecR.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.group_DecR.Size = new System.Drawing.Size(849, 267);
            this.group_DecR.TabIndex = 0;
            this.group_DecR.TabStop = false;
            this.group_DecR.TitleBorderColor = System.Drawing.Color.Red;
            this.group_DecR.TitleRectBackColor = System.Drawing.Color.White;
            this.group_DecR.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btn_CompDecomp
            // 
            this.btn_CompDecomp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CompDecomp.DM_FontSize = DMSkin.Metro.MetroButtonSize.Medium;
            this.btn_CompDecomp.DM_Highlight = true;
            this.btn_CompDecomp.DM_UseSelectable = true;
            this.btn_CompDecomp.Location = new System.Drawing.Point(23, 69);
            this.btn_CompDecomp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CompDecomp.Name = "btn_CompDecomp";
            this.btn_CompDecomp.Size = new System.Drawing.Size(216, 42);
            this.btn_CompDecomp.TabIndex = 2;
            this.btn_CompDecomp.TabStop = false;
            this.btn_CompDecomp.Text = "压缩数据→解压";
            this.btn_CompDecomp.Click += new System.EventHandler(this.btn_CompDecomp_Click);
            // 
            // group_DecM
            // 
            this.group_DecM.BackColor = System.Drawing.Color.Transparent;
            this.group_DecM.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.group_DecM.Controls.Add(this.prog_CompSplit);
            this.group_DecM.Controls.Add(this.list_CompSplit);
            this.group_DecM.Controls.Add(this.btn_CompSplit);
            this.group_DecM.ForeColor = System.Drawing.Color.Black;
            this.group_DecM.Location = new System.Drawing.Point(4, 331);
            this.group_DecM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_DecM.Name = "group_DecM";
            this.group_DecM.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_DecM.RectBackColor = System.Drawing.Color.White;
            this.group_DecM.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.group_DecM.Size = new System.Drawing.Size(849, 267);
            this.group_DecM.TabIndex = 0;
            this.group_DecM.TabStop = false;
            this.group_DecM.TitleBorderColor = System.Drawing.Color.Red;
            this.group_DecM.TitleRectBackColor = System.Drawing.Color.White;
            this.group_DecM.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // prog_CompSplit
            // 
            this.prog_CompSplit.Back = null;
            this.prog_CompSplit.BackColor = System.Drawing.Color.Transparent;
            this.prog_CompSplit.BarBack = null;
            this.prog_CompSplit.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.prog_CompSplit.Border = System.Drawing.Color.DodgerBlue;
            this.prog_CompSplit.ForeColor = System.Drawing.Color.Tomato;
            this.prog_CompSplit.Location = new System.Drawing.Point(7, 177);
            this.prog_CompSplit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prog_CompSplit.MarqueeAnimationSpeed = 10;
            this.prog_CompSplit.Maximum = 1000;
            this.prog_CompSplit.Name = "prog_CompSplit";
            this.prog_CompSplit.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.prog_CompSplit.Size = new System.Drawing.Size(268, 28);
            this.prog_CompSplit.TabIndex = 0;
            this.prog_CompSplit.TrackBack = System.Drawing.Color.White;
            this.prog_CompSplit.TrackFore = System.Drawing.Color.DeepSkyBlue;
            // 
            // list_CompSplit
            // 
            this.list_CompSplit.Back = null;
            this.list_CompSplit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.list_CompSplit.FormattingEnabled = true;
            this.list_CompSplit.IntegralHeight = false;
            this.list_CompSplit.ItemGlassVisble = false;
            this.list_CompSplit.Location = new System.Drawing.Point(283, 22);
            this.list_CompSplit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.list_CompSplit.MouseColor = System.Drawing.Color.LightGray;
            this.list_CompSplit.Name = "list_CompSplit";
            this.list_CompSplit.RowBackColor1 = System.Drawing.Color.Transparent;
            this.list_CompSplit.RowBackColor2 = System.Drawing.Color.Transparent;
            this.list_CompSplit.SelectedColor = System.Drawing.Color.LightGoldenrodYellow;
            this.list_CompSplit.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_CompSplit.Size = new System.Drawing.Size(559, 231);
            this.list_CompSplit.TabIndex = 0;
            this.list_CompSplit.TabStop = false;
            this.list_CompSplit.Click += new System.EventHandler(this.list_CompSplit_Click);
            // 
            // btn_CompSplit
            // 
            this.btn_CompSplit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CompSplit.DM_FontSize = DMSkin.Metro.MetroButtonSize.Medium;
            this.btn_CompSplit.DM_Highlight = true;
            this.btn_CompSplit.DM_UseSelectable = true;
            this.btn_CompSplit.Location = new System.Drawing.Point(31, 69);
            this.btn_CompSplit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CompSplit.Name = "btn_CompSplit";
            this.btn_CompSplit.Size = new System.Drawing.Size(216, 42);
            this.btn_CompSplit.TabIndex = 2;
            this.btn_CompSplit.TabStop = false;
            this.btn_CompSplit.Text = "压缩数据→分包";
            this.btn_CompSplit.Click += new System.EventHandler(this.btn_CompSplit_Click);
            // 
            // group_DecL
            // 
            this.group_DecL.BackColor = System.Drawing.Color.Transparent;
            this.group_DecL.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.group_DecL.Controls.Add(this.prog_OrigResolve);
            this.group_DecL.Controls.Add(this.list_OrigResolve);
            this.group_DecL.Controls.Add(this.btn_OrigResolve);
            this.group_DecL.ForeColor = System.Drawing.Color.Black;
            this.group_DecL.Location = new System.Drawing.Point(4, 59);
            this.group_DecL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_DecL.Name = "group_DecL";
            this.group_DecL.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_DecL.RectBackColor = System.Drawing.Color.White;
            this.group_DecL.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.group_DecL.Size = new System.Drawing.Size(849, 267);
            this.group_DecL.TabIndex = 0;
            this.group_DecL.TabStop = false;
            this.group_DecL.TitleBorderColor = System.Drawing.Color.Red;
            this.group_DecL.TitleRectBackColor = System.Drawing.Color.White;
            this.group_DecL.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // prog_OrigResolve
            // 
            this.prog_OrigResolve.Back = null;
            this.prog_OrigResolve.BackColor = System.Drawing.Color.Transparent;
            this.prog_OrigResolve.BarBack = null;
            this.prog_OrigResolve.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.prog_OrigResolve.Border = System.Drawing.Color.DodgerBlue;
            this.prog_OrigResolve.ForeColor = System.Drawing.Color.Tomato;
            this.prog_OrigResolve.Location = new System.Drawing.Point(8, 179);
            this.prog_OrigResolve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prog_OrigResolve.MarqueeAnimationSpeed = 10;
            this.prog_OrigResolve.Maximum = 1000;
            this.prog_OrigResolve.Name = "prog_OrigResolve";
            this.prog_OrigResolve.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.prog_OrigResolve.Size = new System.Drawing.Size(268, 28);
            this.prog_OrigResolve.TabIndex = 0;
            this.prog_OrigResolve.TrackBack = System.Drawing.Color.White;
            this.prog_OrigResolve.TrackFore = System.Drawing.Color.DeepSkyBlue;
            // 
            // list_OrigResolve
            // 
            this.list_OrigResolve.Back = null;
            this.list_OrigResolve.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.list_OrigResolve.FormattingEnabled = true;
            this.list_OrigResolve.IntegralHeight = false;
            this.list_OrigResolve.ItemGlassVisble = false;
            this.list_OrigResolve.Location = new System.Drawing.Point(284, 24);
            this.list_OrigResolve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.list_OrigResolve.MouseColor = System.Drawing.Color.LightGray;
            this.list_OrigResolve.Name = "list_OrigResolve";
            this.list_OrigResolve.RowBackColor1 = System.Drawing.Color.Transparent;
            this.list_OrigResolve.RowBackColor2 = System.Drawing.Color.Transparent;
            this.list_OrigResolve.SelectedColor = System.Drawing.Color.LightGoldenrodYellow;
            this.list_OrigResolve.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_OrigResolve.Size = new System.Drawing.Size(559, 231);
            this.list_OrigResolve.TabIndex = 0;
            this.list_OrigResolve.TabStop = false;
            this.list_OrigResolve.Click += new System.EventHandler(this.list_OrigResolve_Click);
            // 
            // btn_OrigResolve
            // 
            this.btn_OrigResolve.BackColor = System.Drawing.Color.Transparent;
            this.btn_OrigResolve.DM_DM_DisplayFocus = true;
            this.btn_OrigResolve.DM_FontSize = DMSkin.Metro.MetroButtonSize.Medium;
            this.btn_OrigResolve.DM_Highlight = true;
            this.btn_OrigResolve.DM_UseSelectable = true;
            this.btn_OrigResolve.ForeColor = System.Drawing.Color.Transparent;
            this.btn_OrigResolve.Location = new System.Drawing.Point(32, 75);
            this.btn_OrigResolve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_OrigResolve.Name = "btn_OrigResolve";
            this.btn_OrigResolve.Size = new System.Drawing.Size(216, 42);
            this.btn_OrigResolve.TabIndex = 1;
            this.btn_OrigResolve.TabStop = false;
            this.btn_OrigResolve.Text = "原始数据→解包";
            this.btn_OrigResolve.Click += new System.EventHandler(this.btn_OrigResolve_Click);
            // 
            // lbl_DecText
            // 
            this.lbl_DecText.AutoSize = true;
            this.lbl_DecText.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_DecText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_DecText.Location = new System.Drawing.Point(60, 10);
            this.lbl_DecText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DecText.Name = "lbl_DecText";
            this.lbl_DecText.Size = new System.Drawing.Size(101, 30);
            this.lbl_DecText.TabIndex = 14;
            this.lbl_DecText.Text = "图像解压";
            // 
            // lbl_DecIco
            // 
            this.lbl_DecIco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DecIco.DM_Color = System.Drawing.Color.DeepSkyBlue;
            this.lbl_DecIco.DM_Font_Size = 18F;
            this.lbl_DecIco.DM_Key = DMSkin.Controls.DMLabelKey.主页;
            this.lbl_DecIco.DM_Text = "";
            this.lbl_DecIco.ForeColor = System.Drawing.Color.Black;
            this.lbl_DecIco.Location = new System.Drawing.Point(27, 8);
            this.lbl_DecIco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbl_DecIco.Name = "lbl_DecIco";
            this.lbl_DecIco.Size = new System.Drawing.Size(40, 37);
            this.lbl_DecIco.TabIndex = 13;
            // 
            // panel_Analyse
            // 
            this.panel_Analyse.Controls.Add(this.btn_OrigShow);
            this.panel_Analyse.Controls.Add(this.lbl_AnaText);
            this.panel_Analyse.Controls.Add(this.lbl_AnaIco);
            this.panel_Analyse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Analyse.Location = new System.Drawing.Point(4, 21);
            this.panel_Analyse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_Analyse.Name = "panel_Analyse";
            this.panel_Analyse.Size = new System.Drawing.Size(856, 884);
            this.panel_Analyse.TabIndex = 0;
            // 
            // btn_OrigShow
            // 
            this.btn_OrigShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_OrigShow.DM_FontSize = DMSkin.Metro.MetroButtonSize.Medium;
            this.btn_OrigShow.DM_Highlight = true;
            this.btn_OrigShow.DM_UseSelectable = true;
            this.btn_OrigShow.Location = new System.Drawing.Point(27, 96);
            this.btn_OrigShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_OrigShow.Name = "btn_OrigShow";
            this.btn_OrigShow.Size = new System.Drawing.Size(216, 42);
            this.btn_OrigShow.TabIndex = 11;
            this.btn_OrigShow.TabStop = false;
            this.btn_OrigShow.Text = "原始图像显示";
            this.btn_OrigShow.Click += new System.EventHandler(this.btn_OrigShow_Click);
            // 
            // lbl_AnaText
            // 
            this.lbl_AnaText.AutoSize = true;
            this.lbl_AnaText.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_AnaText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_AnaText.Location = new System.Drawing.Point(60, 10);
            this.lbl_AnaText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AnaText.Name = "lbl_AnaText";
            this.lbl_AnaText.Size = new System.Drawing.Size(101, 30);
            this.lbl_AnaText.TabIndex = 10;
            this.lbl_AnaText.Text = "光谱分析";
            // 
            // lbl_AnaIco
            // 
            this.lbl_AnaIco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AnaIco.DM_Color = System.Drawing.Color.DeepSkyBlue;
            this.lbl_AnaIco.DM_Font_Size = 18F;
            this.lbl_AnaIco.DM_Key = DMSkin.Controls.DMLabelKey.主页;
            this.lbl_AnaIco.DM_Text = "";
            this.lbl_AnaIco.ForeColor = System.Drawing.Color.Black;
            this.lbl_AnaIco.Location = new System.Drawing.Point(27, 8);
            this.lbl_AnaIco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbl_AnaIco.Name = "lbl_AnaIco";
            this.lbl_AnaIco.Size = new System.Drawing.Size(40, 37);
            this.lbl_AnaIco.TabIndex = 9;
            // 
            // panel_DataTrans
            // 
            this.panel_DataTrans.Controls.Add(this.lbl_DataText);
            this.panel_DataTrans.Controls.Add(this.lbl_DataIco);
            this.panel_DataTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DataTrans.Location = new System.Drawing.Point(4, 21);
            this.panel_DataTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_DataTrans.Name = "panel_DataTrans";
            this.panel_DataTrans.Size = new System.Drawing.Size(856, 884);
            this.panel_DataTrans.TabIndex = 2;
            // 
            // lbl_DataText
            // 
            this.lbl_DataText.AutoSize = true;
            this.lbl_DataText.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_DataText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_DataText.Location = new System.Drawing.Point(60, 10);
            this.lbl_DataText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DataText.Name = "lbl_DataText";
            this.lbl_DataText.Size = new System.Drawing.Size(101, 30);
            this.lbl_DataText.TabIndex = 12;
            this.lbl_DataText.Text = "数据传输";
            // 
            // lbl_DataIco
            // 
            this.lbl_DataIco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DataIco.DM_Color = System.Drawing.Color.DeepSkyBlue;
            this.lbl_DataIco.DM_Font_Size = 18F;
            this.lbl_DataIco.DM_Key = DMSkin.Controls.DMLabelKey.主页;
            this.lbl_DataIco.DM_Text = "";
            this.lbl_DataIco.ForeColor = System.Drawing.Color.Black;
            this.lbl_DataIco.Location = new System.Drawing.Point(27, 8);
            this.lbl_DataIco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbl_DataIco.Name = "lbl_DataIco";
            this.lbl_DataIco.Size = new System.Drawing.Size(40, 37);
            this.lbl_DataIco.TabIndex = 11;
            // 
            // timer_ListOrig
            // 
            this.timer_ListOrig.Interval = 10;
            this.timer_ListOrig.Tick += new System.EventHandler(this.timerListOrig_Tick);
            // 
            // timer_ListComp
            // 
            this.timer_ListComp.Interval = 10;
            this.timer_ListComp.Tick += new System.EventHandler(this.timer_ListComp_Tick);
            // 
            // Form_MainCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1224, 857);
            this.Controls.Add(this.group_BottomR);
            this.Controls.Add(this.group_BottomL);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form_MainCtrl";
            this.Opacity = 0.2D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地面光谱分析器";
            this.TitleCenter = false;
            this.TitleSuitColor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MainCtrl_FormClosing);
            this.group_BottomL.ResumeLayout(false);
            this.group_BottomR.ResumeLayout(false);
            this.panel_Decompress.ResumeLayout(false);
            this.panel_Decompress.PerformLayout();
            this.group_DecR.ResumeLayout(false);
            this.group_DecM.ResumeLayout(false);
            this.group_DecL.ResumeLayout(false);
            this.panel_Analyse.ResumeLayout(false);
            this.panel_Analyse.PerformLayout();
            this.panel_DataTrans.ResumeLayout(false);
            this.panel_DataTrans.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox group_BottomL;
        private DMSkin.Controls.DMButton btn_Analyse;
        private CCWin.SkinControl.SkinGroupBox group_BottomR;
        private DMSkin.Controls.DMButton btn_DataTrans;
        private DMSkin.Controls.DMButton btn_Decompress;
        private System.Windows.Forms.Panel panel_DataTrans;
        private System.Windows.Forms.Panel panel_Decompress;
        private System.Windows.Forms.Panel panel_Analyse;
        private DMSkin.Controls.DMLabel lbl_AnaIco;
        private System.Windows.Forms.Label lbl_AnaText;
        private System.Windows.Forms.Label lbl_DecText;
        private DMSkin.Controls.DMLabel lbl_DecIco;
        private System.Windows.Forms.Label lbl_DataText;
        private DMSkin.Controls.DMLabel lbl_DataIco;
        private CCWin.SkinControl.SkinGroupBox group_DecL;
        private CCWin.SkinControl.SkinGroupBox group_DecR;
        private CCWin.SkinControl.SkinGroupBox group_DecM;
        private DMSkin.Metro.Controls.MetroButton btn_OrigResolve;
        public CCWin.SkinControl.SkinListBox list_OrigResolve;
        public CCWin.SkinControl.SkinProgressBar prog_OrigResolve;
        private System.Windows.Forms.ToolTip tip_List;
        private System.Windows.Forms.Timer timer_ListOrig;
        public CCWin.SkinControl.SkinProgressBar prog_CompSplit;
        public CCWin.SkinControl.SkinListBox list_CompSplit;
        private DMSkin.Metro.Controls.MetroButton btn_CompSplit;
        private System.Windows.Forms.Timer timer_ListComp;
        private DMSkin.Metro.Controls.MetroButton btn_CompDecomp;
        private DMSkin.Metro.Controls.MetroButton btn_OrigShow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

