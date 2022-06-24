namespace Photo_Browser
{
    partial class frmBrowser
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
            this.picArea = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.comView = new System.Windows.Forms.ComboBox();
            this.lblView = new System.Windows.Forms.Label();
            this.opfDialbrowse = new System.Windows.Forms.OpenFileDialog();
            this.lblCopyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // picArea
            // 
            this.picArea.Location = new System.Drawing.Point(87, 68);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(528, 297);
            this.picArea.TabIndex = 0;
            this.picArea.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(265, 371);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(172, 34);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // comView
            // 
            this.comView.FormattingEnabled = true;
            this.comView.Items.AddRange(new object[] {
            "Normal",
            "StretchImage",
            "CenterImage",
            "Zoom"});
            this.comView.Location = new System.Drawing.Point(167, 24);
            this.comView.Name = "comView";
            this.comView.Size = new System.Drawing.Size(270, 24);
            this.comView.TabIndex = 2;
            this.comView.Text = "Normal";
            this.comView.SelectedIndexChanged += new System.EventHandler(this.comView_SelectedIndexChanged);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(84, 27);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(77, 16);
            this.lblView.TabIndex = 3;
            this.lblView.Text = "Switch View";
            // 
            // opfDialbrowse
            // 
            this.opfDialbrowse.FileName = "Select";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(12, 408);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(213, 16);
            this.lblCopyRight.TabIndex = 4;
            this.lblCopyRight.Text = "Made with ❤️ by yarzardhiyit © 2022";
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.comView);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picArea);
            this.Name = "frmBrowser";
            this.Text = "Photo Browser";
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArea;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox comView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.OpenFileDialog opfDialbrowse;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

