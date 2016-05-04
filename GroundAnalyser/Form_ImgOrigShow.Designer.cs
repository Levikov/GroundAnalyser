namespace GroundAnalyser
{
    partial class Form_ImgOrigShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ImgOrigShow));
            this.picture_ImgOrig = new System.Windows.Forms.PictureBox();
            this.textBox_startPicNum = new System.Windows.Forms.TextBox();
            this.textBox_endPicNum = new System.Windows.Forms.TextBox();
            this.label_endPicNum = new System.Windows.Forms.Label();
            this.numericUpDown_specNum = new System.Windows.Forms.NumericUpDown();
            this.label_specNum = new System.Windows.Forms.Label();
            this.button_joint = new System.Windows.Forms.Button();
            this.label_startPicNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ImgOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_specNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_ImgOrig
            // 
            this.picture_ImgOrig.Dock = System.Windows.Forms.DockStyle.Right;
            this.picture_ImgOrig.Location = new System.Drawing.Point(229, 34);
            this.picture_ImgOrig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_ImgOrig.MaximumSize = new System.Drawing.Size(2048, 0);
            this.picture_ImgOrig.Name = "picture_ImgOrig";
            this.picture_ImgOrig.Size = new System.Drawing.Size(1474, 577);
            this.picture_ImgOrig.TabIndex = 1;
            this.picture_ImgOrig.TabStop = false;
            // 
            // textBox_startPicNum
            // 
            this.textBox_startPicNum.Location = new System.Drawing.Point(108, 32);
            this.textBox_startPicNum.Name = "textBox_startPicNum";
            this.textBox_startPicNum.Size = new System.Drawing.Size(73, 25);
            this.textBox_startPicNum.TabIndex = 2;
            this.textBox_startPicNum.TextChanged += new System.EventHandler(this.textBox_startPicNum_textChanged);
            // 
            // textBox_endPicNum
            // 
            this.textBox_endPicNum.Location = new System.Drawing.Point(108, 80);
            this.textBox_endPicNum.Name = "textBox_endPicNum";
            this.textBox_endPicNum.Size = new System.Drawing.Size(73, 25);
            this.textBox_endPicNum.TabIndex = 3;
            this.textBox_endPicNum.TextChanged += new System.EventHandler(this.textBox_endPicNum_textChanged);
            // 
            // label_endPicNum
            // 
            this.label_endPicNum.AutoSize = true;
            this.label_endPicNum.Location = new System.Drawing.Point(4, 83);
            this.label_endPicNum.Name = "label_endPicNum";
            this.label_endPicNum.Size = new System.Drawing.Size(67, 15);
            this.label_endPicNum.TabIndex = 5;
            this.label_endPicNum.Text = "结束编号";
            // 
            // numericUpDown_specNum
            // 
            this.numericUpDown_specNum.Location = new System.Drawing.Point(108, 127);
            this.numericUpDown_specNum.Maximum = new decimal(new int[] {
            159,
            0,
            0,
            0});
            this.numericUpDown_specNum.Name = "numericUpDown_specNum";
            this.numericUpDown_specNum.Size = new System.Drawing.Size(70, 25);
            this.numericUpDown_specNum.TabIndex = 6;
            // 
            // label_specNum
            // 
            this.label_specNum.AutoSize = true;
            this.label_specNum.Location = new System.Drawing.Point(4, 129);
            this.label_specNum.Name = "label_specNum";
            this.label_specNum.Size = new System.Drawing.Size(67, 15);
            this.label_specNum.TabIndex = 7;
            this.label_specNum.Text = "谱线编号";
            // 
            // button_joint
            // 
            this.button_joint.Location = new System.Drawing.Point(10, 206);
            this.button_joint.Name = "button_joint";
            this.button_joint.Size = new System.Drawing.Size(171, 50);
            this.button_joint.TabIndex = 8;
            this.button_joint.Text = "拼接图像";
            this.button_joint.UseVisualStyleBackColor = true;
            // 
            // label_startPicNum
            // 
            this.label_startPicNum.AutoSize = true;
            this.label_startPicNum.Location = new System.Drawing.Point(4, 35);
            this.label_startPicNum.Name = "label_startPicNum";
            this.label_startPicNum.Size = new System.Drawing.Size(67, 15);
            this.label_startPicNum.TabIndex = 4;
            this.label_startPicNum.Text = "起始编号";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_joint);
            this.panel1.Controls.Add(this.textBox_startPicNum);
            this.panel1.Controls.Add(this.label_specNum);
            this.panel1.Controls.Add(this.textBox_endPicNum);
            this.panel1.Controls.Add(this.numericUpDown_specNum);
            this.panel1.Controls.Add(this.label_startPicNum);
            this.panel1.Controls.Add(this.label_endPicNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 577);
            this.panel1.TabIndex = 9;
            // 
            // Form_ImgOrigShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorTop = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1707, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture_ImgOrig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_ImgOrigShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "显示原始图像";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.Form_ImgOrigShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ImgOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_specNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_ImgOrig;
        private System.Windows.Forms.TextBox textBox_startPicNum;
        private System.Windows.Forms.TextBox textBox_endPicNum;
        private System.Windows.Forms.Label label_endPicNum;
        private System.Windows.Forms.NumericUpDown numericUpDown_specNum;
        private System.Windows.Forms.Label label_specNum;
        private System.Windows.Forms.Button button_joint;
        private System.Windows.Forms.Label label_startPicNum;
        private System.Windows.Forms.Panel panel1;
    }
}