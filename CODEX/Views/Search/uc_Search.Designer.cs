﻿namespace CODEX.Views.Search
{
    partial class uc_Search
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
            this.tbox_searchBar = new Guna.UI.WinForms.GunaLineTextBox();
            this.cbox_SelectedDvarList = new Guna.UI.WinForms.GunaComboBox();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_titleSelectedDvarList = new Guna.UI.WinForms.GunaLabel();
            this.pnl_toogles = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.SuspendLayout();
            // 
            // tbox_searchBar
            // 
            this.tbox_searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbox_searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_searchBar.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.tbox_searchBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_searchBar.ForeColor = System.Drawing.Color.White;
            this.tbox_searchBar.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_searchBar.Location = new System.Drawing.Point(114, 41);
            this.tbox_searchBar.Name = "tbox_searchBar";
            this.tbox_searchBar.PasswordChar = '\0';
            this.tbox_searchBar.SelectedText = "";
            this.tbox_searchBar.Size = new System.Drawing.Size(386, 30);
            this.tbox_searchBar.TabIndex = 0;
            this.tbox_searchBar.Text = "Search . . .";
            this.tbox_searchBar.Enter += new System.EventHandler(this.tbox_searchBar_Enter);
            this.tbox_searchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_searchBar_KeyPress);
            this.tbox_searchBar.Leave += new System.EventHandler(this.tbox_searchBar_Leave);
            // 
            // cbox_SelectedDvarList
            // 
            this.cbox_SelectedDvarList.BackColor = System.Drawing.Color.Transparent;
            this.cbox_SelectedDvarList.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cbox_SelectedDvarList.BorderColor = System.Drawing.Color.Silver;
            this.cbox_SelectedDvarList.BorderSize = 1;
            this.cbox_SelectedDvarList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_SelectedDvarList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_SelectedDvarList.FocusedColor = System.Drawing.Color.Empty;
            this.cbox_SelectedDvarList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_SelectedDvarList.ForeColor = System.Drawing.Color.White;
            this.cbox_SelectedDvarList.FormattingEnabled = true;
            this.cbox_SelectedDvarList.Location = new System.Drawing.Point(536, 45);
            this.cbox_SelectedDvarList.Name = "cbox_SelectedDvarList";
            this.cbox_SelectedDvarList.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cbox_SelectedDvarList.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbox_SelectedDvarList.Size = new System.Drawing.Size(127, 26);
            this.cbox_SelectedDvarList.TabIndex = 12;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(523, 30);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator2.TabIndex = 17;
            // 
            // lbl_titleSelectedDvarList
            // 
            this.lbl_titleSelectedDvarList.AutoSize = true;
            this.lbl_titleSelectedDvarList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_titleSelectedDvarList.ForeColor = System.Drawing.Color.White;
            this.lbl_titleSelectedDvarList.Location = new System.Drawing.Point(520, 6);
            this.lbl_titleSelectedDvarList.Name = "lbl_titleSelectedDvarList";
            this.lbl_titleSelectedDvarList.Size = new System.Drawing.Size(136, 21);
            this.lbl_titleSelectedDvarList.TabIndex = 16;
            this.lbl_titleSelectedDvarList.Text = "Selected DVAR list";
            // 
            // pnl_toogles
            // 
            this.pnl_toogles.Location = new System.Drawing.Point(13, 82);
            this.pnl_toogles.Name = "pnl_toogles";
            this.pnl_toogles.Size = new System.Drawing.Size(722, 415);
            this.pnl_toogles.TabIndex = 18;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::CODEX.Properties.Resources.search_off;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaCircleButton1.Location = new System.Drawing.Point(71, 41);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnPressedDepth = 10;
            this.gunaCircleButton1.Size = new System.Drawing.Size(35, 35);
            this.gunaCircleButton1.TabIndex = 1;
            // 
            // uc_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pnl_toogles);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.lbl_titleSelectedDvarList);
            this.Controls.Add(this.cbox_SelectedDvarList);
            this.Controls.Add(this.gunaCircleButton1);
            this.Controls.Add(this.tbox_searchBar);
            this.Name = "uc_Search";
            this.Size = new System.Drawing.Size(751, 512);
            this.Load += new System.EventHandler(this.uc_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox tbox_searchBar;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaComboBox cbox_SelectedDvarList;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel lbl_titleSelectedDvarList;
        private System.Windows.Forms.FlowLayoutPanel pnl_toogles;
    }
}
