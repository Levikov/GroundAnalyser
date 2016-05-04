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
            ((System.ComponentModel.ISupportInitialize)(this.picture_ImgOrig)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_ImgOrig
            // 
            this.picture_ImgOrig.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture_ImgOrig.Location = new System.Drawing.Point(4, 34);
            this.picture_ImgOrig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picture_ImgOrig.Name = "picture_ImgOrig";
            this.picture_ImgOrig.Size = new System.Drawing.Size(1272, 452);
            this.picture_ImgOrig.TabIndex = 1;
            this.picture_ImgOrig.TabStop = false;
            // 
            // Form_ImgOrigShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorTop = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1280, 492);
            this.Controls.Add(this.picture_ImgOrig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_ImgOrigShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "显示原始图像";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.Form_ImgOrigShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ImgOrig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_ImgOrig;
    }
}