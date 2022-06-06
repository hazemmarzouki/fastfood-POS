﻿namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormUsersArchive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LinkProductArchive = new System.Windows.Forms.LinkLabel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridViewUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkProductArchive
            // 
            this.LinkProductArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkProductArchive.AutoSize = true;
            this.LinkProductArchive.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkProductArchive.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinkProductArchive.Location = new System.Drawing.Point(612, 37);
            this.LinkProductArchive.Name = "LinkProductArchive";
            this.LinkProductArchive.Size = new System.Drawing.Size(182, 24);
            this.LinkProductArchive.TabIndex = 0;
            this.LinkProductArchive.TabStop = true;
            this.LinkProductArchive.Text = "Products Archive";
            this.LinkProductArchive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkProductArchive_LinkClicked);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(597, 31);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 30);
            this.guna2VSeparator1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(83, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users Archive";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.DataGridViewUsers);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 82);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(760, 413);
            this.guna2Panel1.TabIndex = 8;
            // 
            // DataGridViewUsers
            // 
            this.DataGridViewUsers.AllowUserToAddRows = false;
            this.DataGridViewUsers.AllowUserToDeleteRows = false;
            this.DataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewUsers.ColumnHeadersHeight = 40;
            this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Cashier,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewUsers.EnableHeadersVisualStyles = false;
            this.DataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewUsers.Location = new System.Drawing.Point(1, 1);
            this.DataGridViewUsers.MultiSelect = false;
            this.DataGridViewUsers.Name = "DataGridViewUsers";
            this.DataGridViewUsers.ReadOnly = true;
            this.DataGridViewUsers.RowHeadersVisible = false;
            this.DataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewUsers.RowTemplate.Height = 40;
            this.DataGridViewUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUsers.Size = new System.Drawing.Size(758, 411);
            this.DataGridViewUsers.TabIndex = 5;
            this.DataGridViewUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(89)))));
            this.DataGridViewUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewUsers.ThemeStyle.ReadOnly = true;
            this.DataGridViewUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewUsers.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridViewUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Name";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cashier
            // 
            this.Cashier.HeaderText = "Email";
            this.Cashier.Name = "Cashier";
            this.Cashier.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Role";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::FastFoodPOS.Properties.Resources.user_archive;
            this.guna2PictureBox1.Location = new System.Drawing.Point(37, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormUsersArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.LinkProductArchive);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUsersArchive";
            this.Size = new System.Drawing.Size(833, 528);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkProductArchive;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal Guna.UI2.WinForms.Guna2DataGridView DataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
