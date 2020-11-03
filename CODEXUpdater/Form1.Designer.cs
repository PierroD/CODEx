namespace CODEXUpdater
{
    partial class frm_updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_updater));
            this.btn_minimize = new Guna.UI.WinForms.GunaControlBox();
            this.btn_close = new Guna.UI.WinForms.GunaControlBox();
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.btn_end = new Guna.UI.WinForms.GunaGradientButton();
            this.pnl_loading = new System.Windows.Forms.Panel();
            this.lbl_action = new Guna.UI.WinForms.GunaLabel();
            this.drag_form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drag_pnl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.AnimationHoverSpeed = 0.07F;
            this.btn_minimize.AnimationSpeed = 0.03F;
            this.btn_minimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btn_minimize.IconColor = System.Drawing.Color.White;
            this.btn_minimize.IconSize = 15F;
            this.btn_minimize.Location = new System.Drawing.Point(484, 7);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_minimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_minimize.OnPressedColor = System.Drawing.Color.Black;
            this.btn_minimize.Size = new System.Drawing.Size(60, 29);
            this.btn_minimize.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.IconSize = 15F;
            this.btn_close.Location = new System.Drawing.Point(560, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.btn_close.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(60, 29);
            this.btn_close.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(146, 23);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "CODEX Updater";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_end
            // 
            this.btn_end.AnimationHoverSpeed = 0.07F;
            this.btn_end.AnimationSpeed = 0.03F;
            this.btn_end.BackColor = System.Drawing.Color.Transparent;
            this.btn_end.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_end.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_end.BorderColor = System.Drawing.Color.Black;
            this.btn_end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_end.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_end.FocusedColor = System.Drawing.Color.Empty;
            this.btn_end.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.ForeColor = System.Drawing.Color.White;
            this.btn_end.Image = ((System.Drawing.Image)(resources.GetObject("btn_end.Image")));
            this.btn_end.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_end.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_end.Location = new System.Drawing.Point(526, 248);
            this.btn_end.Name = "btn_end";
            this.btn_end.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_end.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_end.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_end.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_end.OnHoverImage = null;
            this.btn_end.OnPressedColor = System.Drawing.Color.Black;
            this.btn_end.OnPressedDepth = 25;
            this.btn_end.Radius = 20;
            this.btn_end.Size = new System.Drawing.Size(94, 40);
            this.btn_end.TabIndex = 13;
            this.btn_end.Text = "DONE";
            this.btn_end.TextOffsetX = 5;
            this.btn_end.Visible = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // pnl_loading
            // 
            this.pnl_loading.Location = new System.Drawing.Point(36, 40);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(547, 191);
            this.pnl_loading.TabIndex = 14;
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.ForeColor = System.Drawing.Color.White;
            this.lbl_action.Location = new System.Drawing.Point(32, 257);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(0, 20);
            this.lbl_action.TabIndex = 15;
            // 
            // drag_form
            // 
            this.drag_form.TargetControl = this;
            // 
            // drag_pnl
            // 
            this.drag_pnl.TargetControl = this.pnl_loading;
            // 
            // frm_updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(632, 300);
            this.Controls.Add(this.lbl_action);
            this.Controls.Add(this.pnl_loading);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODEX Updater";
            this.Load += new System.EventHandler(this.frm_updater_Load);
            this.Shown += new System.EventHandler(this.frm_updater_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox btn_minimize;
        private Guna.UI.WinForms.GunaControlBox btn_close;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaGradientButton btn_end;
        private System.Windows.Forms.Panel pnl_loading;
        private Guna.UI.WinForms.GunaLabel lbl_action;
        private Guna.UI.WinForms.GunaDragControl drag_form;
        private Guna.UI.WinForms.GunaDragControl drag_pnl;
    }
}

