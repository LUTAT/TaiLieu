namespace QuanLyCafe
{
    partial class UserCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSua = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnInfo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.lbName.Location = new System.Drawing.Point(126, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(128, 22);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Trần Quang Thiện";
            // 
            // lbChucVu
            // 
            this.lbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lbChucVu.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.lbChucVu.Location = new System.Drawing.Point(126, 44);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(97, 17);
            this.lbChucVu.TabIndex = 2;
            this.lbChucVu.Text = "Trần Quang Thiện";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyCafe.Properties.Resources.user1;
            this.btnSua.ImageRotate = 0F;
            this.btnSua.Location = new System.Drawing.Point(156, 67);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(24, 24);
            this.btnSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSua.TabIndex = 5;
            this.btnSua.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyCafe.Properties.Resources.delete;
            this.btnXoa.ImageRotate = 0F;
            this.btnXoa.Location = new System.Drawing.Point(186, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(24, 24);
            this.btnXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnXoa.TabIndex = 4;
            this.btnXoa.TabStop = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::QuanLyCafe.Properties.Resources.info__1_1;
            this.btnInfo.ImageRotate = 0F;
            this.btnInfo.Location = new System.Drawing.Point(126, 67);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(24, 24);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnInfo.TabIndex = 3;
            this.btnInfo.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.BorderRadius = 45;
            this.picAvatar.Image = global::QuanLyCafe.Properties.Resources._60d73b71372bf375aa3a1;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(12, 16);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(90, 90);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(10, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 3);
            this.panel1.TabIndex = 6;
            // 
            // UserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picAvatar);
            this.Name = "UserCtrl";
            this.Size = new System.Drawing.Size(340, 122);
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbChucVu;
        private Guna.UI2.WinForms.Guna2PictureBox btnInfo;
        private Guna.UI2.WinForms.Guna2PictureBox btnXoa;
        private Guna.UI2.WinForms.Guna2PictureBox btnSua;
        private System.Windows.Forms.Panel panel1;
    }
}
