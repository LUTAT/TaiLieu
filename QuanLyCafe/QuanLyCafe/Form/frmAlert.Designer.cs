namespace QuanLyCafe
{
    partial class frmAlert
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
            this.components = new System.ComponentModel.Container();
            this.txtTitleArlert = new System.Windows.Forms.Label();
            this.txtTextArlert = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.LinArler = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitleArlert
            // 
            this.txtTitleArlert.AutoSize = true;
            this.txtTitleArlert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTitleArlert.Location = new System.Drawing.Point(99, 14);
            this.txtTitleArlert.Name = "txtTitleArlert";
            this.txtTitleArlert.Size = new System.Drawing.Size(163, 30);
            this.txtTitleArlert.TabIndex = 0;
            this.txtTitleArlert.Text = "Title Arlert Box";
            // 
            // txtTextArlert
            // 
            this.txtTextArlert.AutoSize = true;
            this.txtTextArlert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTextArlert.Location = new System.Drawing.Point(100, 48);
            this.txtTextArlert.Name = "txtTextArlert";
            this.txtTextArlert.Size = new System.Drawing.Size(106, 20);
            this.txtTextArlert.TabIndex = 1;
            this.txtTextArlert.Text = "Text Arlert Box";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::QuanLyCafe.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(482, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::QuanLyCafe.Properties.Resources._checked;
            this.picIcon.Location = new System.Drawing.Point(45, 27);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(32, 32);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            // 
            // LinArler
            // 
            this.LinArler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.LinArler.Location = new System.Drawing.Point(0, 78);
            this.LinArler.Name = "LinArler";
            this.LinArler.Size = new System.Drawing.Size(0, 5);
            this.LinArler.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 83);
            this.Controls.Add(this.LinArler);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.txtTextArlert);
            this.Controls.Add(this.txtTitleArlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlert";
            this.Text = "frmAlert";
            this.Load += new System.EventHandler(this.frmAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitleArlert;
        private System.Windows.Forms.Label txtTextArlert;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel LinArler;
        private System.Windows.Forms.Timer timer1;
    }
}