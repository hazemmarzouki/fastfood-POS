namespace FastFoodPOS.Components
{
    partial class UserCardComponent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelNameRole = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.PictureImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ButtonActivityLogs = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 1);
            this.panel1.TabIndex = 1;
            // 
            // LabelNameRole
            // 
            this.LabelNameRole.AutoSize = true;
            this.LabelNameRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameRole.Location = new System.Drawing.Point(65, 12);
            this.LabelNameRole.Name = "LabelNameRole";
            this.LabelNameRole.Size = new System.Drawing.Size(237, 21);
            this.LabelNameRole.TabIndex = 2;
            this.LabelNameRole.Text = "Hazem Marzouki (Administrator)";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.ForeColor = System.Drawing.Color.Gray;
            this.LabelEmail.Location = new System.Drawing.Point(66, 33);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(166, 13);
            this.LabelEmail.TabIndex = 3;
            this.LabelEmail.Text = "Hazem.marzouki11@gmail.com";
            // 
            // PictureImage
            // 
            this.PictureImage.FillColor = System.Drawing.Color.Silver;
            this.PictureImage.Location = new System.Drawing.Point(10, 10);
            this.PictureImage.Name = "PictureImage";
            this.PictureImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureImage.ShadowDecoration.Parent = this.PictureImage;
            this.PictureImage.Size = new System.Drawing.Size(40, 40);
            this.PictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureImage.TabIndex = 6;
            this.PictureImage.TabStop = false;
            // 
            // ButtonActivityLogs
            // 
            this.ButtonActivityLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonActivityLogs.CheckedState.Parent = this.ButtonActivityLogs;
            this.ButtonActivityLogs.CustomImages.Parent = this.ButtonActivityLogs;
            this.ButtonActivityLogs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonActivityLogs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonActivityLogs.ForeColor = System.Drawing.Color.White;
            this.ButtonActivityLogs.HoverState.Parent = this.ButtonActivityLogs;
            this.ButtonActivityLogs.Image = global::FastFoodPOS.Properties.Resources.print_file_48px;
            this.ButtonActivityLogs.ImageSize = new System.Drawing.Size(21, 21);
            this.ButtonActivityLogs.Location = new System.Drawing.Point(508, 12);
            this.ButtonActivityLogs.Name = "ButtonActivityLogs";
            this.ButtonActivityLogs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonActivityLogs.ShadowDecoration.Parent = this.ButtonActivityLogs;
            this.ButtonActivityLogs.Size = new System.Drawing.Size(35, 35);
            this.ButtonActivityLogs.TabIndex = 5;
            this.ButtonActivityLogs.Visible = false;
            this.ButtonActivityLogs.Click += new System.EventHandler(this.ButtonActivityLogs_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdate.CheckedState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.CustomImages.Parent = this.ButtonUpdate;
            this.ButtonUpdate.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.HoverState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Image = global::FastFoodPOS.Properties.Resources.edit_48px;
            this.ButtonUpdate.ImageSize = new System.Drawing.Size(21, 21);
            this.ButtonUpdate.Location = new System.Drawing.Point(549, 12);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonUpdate.ShadowDecoration.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Size = new System.Drawing.Size(35, 35);
            this.ButtonUpdate.TabIndex = 5;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonRemove.Animated = true;
            this.ButtonRemove.AutoRoundedCorners = true;
            this.ButtonRemove.BorderRadius = 16;
            this.ButtonRemove.CheckedState.Parent = this.ButtonRemove;
            this.ButtonRemove.CustomImages.Parent = this.ButtonRemove;
            this.ButtonRemove.FillColor = System.Drawing.Color.Crimson;
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.HoverState.Parent = this.ButtonRemove;
            this.ButtonRemove.Image = global::FastFoodPOS.Properties.Resources.Delete_48px;
            this.ButtonRemove.ImageSize = new System.Drawing.Size(21, 21);
            this.ButtonRemove.Location = new System.Drawing.Point(590, 12);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Parent = this.ButtonRemove;
            this.ButtonRemove.Size = new System.Drawing.Size(35, 35);
            this.ButtonRemove.TabIndex = 4;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // UserCardComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictureImage);
            this.Controls.Add(this.ButtonActivityLogs);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelNameRole);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserCardComponent";
            this.Size = new System.Drawing.Size(637, 61);
            this.MouseEnter += new System.EventHandler(this.UserCardComponent_MouseHover);
            this.MouseLeave += new System.EventHandler(this.UserCardComponent_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelNameRole;
        private System.Windows.Forms.Label LabelEmail;
        private Guna.UI2.WinForms.Guna2Button ButtonRemove;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureImage;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonActivityLogs;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonUpdate;
    }
}
