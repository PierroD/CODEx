namespace CODEX
{
    partial class frm_CODEX
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CodexElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnl_left = new Guna.UI.WinForms.GunaLinePanel();
            this.pbox_heart = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_byLINDRA = new Guna.UI.WinForms.GunaLabel();
            this.lbl_madeWith = new Guna.UI.WinForms.GunaLabel();
            this.btn_Search = new Guna.UI.WinForms.GunaButton();
            this.btn_Settings = new Guna.UI.WinForms.GunaButton();
            this.btn_Home = new Guna.UI.WinForms.GunaButton();
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.pnl_sidebar = new Guna.UI.WinForms.GunaGradient2Panel();
            this.pnl_topRight = new Guna.UI.WinForms.GunaElipsePanel();
            this.btn_minimize = new Guna.UI.WinForms.GunaControlBox();
            this.btn_close = new Guna.UI.WinForms.GunaControlBox();
            this.pnl_topMiddle = new Guna.UI.WinForms.GunaPanel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.pbox_top = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_top = new Guna.UI.WinForms.GunaLabel();
            this.drag_topMiddle = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drag_topRight = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drag_left = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnl_main = new Guna.UI.WinForms.GunaPanel();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_heart)).BeginInit();
            this.pnl_topRight.SuspendLayout();
            this.pnl_topMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_top)).BeginInit();
            this.SuspendLayout();
            // 
            // CodexElipse
            // 
            this.CodexElipse.Radius = 12;
            this.CodexElipse.TargetControl = this;
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnl_left.Controls.Add(this.pbox_heart);
            this.pnl_left.Controls.Add(this.lbl_byLINDRA);
            this.pnl_left.Controls.Add(this.lbl_madeWith);
            this.pnl_left.Controls.Add(this.btn_Search);
            this.pnl_left.Controls.Add(this.btn_Settings);
            this.pnl_left.Controls.Add(this.btn_Home);
            this.pnl_left.Controls.Add(this.lbl_title);
            this.pnl_left.Controls.Add(this.pnl_sidebar);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnl_left.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(220, 570);
            this.pnl_left.TabIndex = 1;
            // 
            // pbox_heart
            // 
            this.pbox_heart.BaseColor = System.Drawing.Color.White;
            this.pbox_heart.Image = global::CODEX.Properties.Resources.heart;
            this.pbox_heart.Location = new System.Drawing.Point(95, 535);
            this.pbox_heart.Name = "pbox_heart";
            this.pbox_heart.Size = new System.Drawing.Size(20, 20);
            this.pbox_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_heart.TabIndex = 19;
            this.pbox_heart.TabStop = false;
            // 
            // lbl_byLINDRA
            // 
            this.lbl_byLINDRA.AutoSize = true;
            this.lbl_byLINDRA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_byLINDRA.ForeColor = System.Drawing.Color.White;
            this.lbl_byLINDRA.Location = new System.Drawing.Point(120, 535);
            this.lbl_byLINDRA.Name = "lbl_byLINDRA";
            this.lbl_byLINDRA.Size = new System.Drawing.Size(75, 17);
            this.lbl_byLINDRA.TabIndex = 18;
            this.lbl_byLINDRA.Text = "by LINDRA";
            // 
            // lbl_madeWith
            // 
            this.lbl_madeWith.AutoSize = true;
            this.lbl_madeWith.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_madeWith.ForeColor = System.Drawing.Color.White;
            this.lbl_madeWith.Location = new System.Drawing.Point(23, 535);
            this.lbl_madeWith.Name = "lbl_madeWith";
            this.lbl_madeWith.Size = new System.Drawing.Size(73, 17);
            this.lbl_madeWith.TabIndex = 17;
            this.lbl_madeWith.Text = "Made with";
            // 
            // btn_Search
            // 
            this.btn_Search.AnimationHoverSpeed = 0.07F;
            this.btn_Search.AnimationSpeed = 0.03F;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Search.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_Search.Image = global::CODEX.Properties.Resources.search_off;
            this.btn_Search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Search.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Search.Location = new System.Drawing.Point(16, 260);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Search.OnHoverImage = global::CODEX.Properties.Resources.search_on;
            this.btn_Search.OnPressedColor = System.Drawing.Color.White;
            this.btn_Search.OnPressedDepth = 5;
            this.btn_Search.Radius = 13;
            this.btn_Search.Size = new System.Drawing.Size(188, 50);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Search.TextOffsetX = 14;
            this.btn_Search.Click += new System.EventHandler(this.btns_SideBar_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.AnimationHoverSpeed = 0.07F;
            this.btn_Settings.AnimationSpeed = 0.03F;
            this.btn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_Settings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Settings.BorderColor = System.Drawing.Color.Black;
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Settings.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_Settings.Image = global::CODEX.Properties.Resources.settings_off;
            this.btn_Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Settings.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Settings.Location = new System.Drawing.Point(16, 320);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Settings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Settings.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Settings.OnHoverImage = global::CODEX.Properties.Resources.settings_on;
            this.btn_Settings.OnPressedColor = System.Drawing.Color.White;
            this.btn_Settings.OnPressedDepth = 5;
            this.btn_Settings.Radius = 13;
            this.btn_Settings.Size = new System.Drawing.Size(188, 50);
            this.btn_Settings.TabIndex = 14;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Settings.TextOffsetX = 14;
            this.btn_Settings.Click += new System.EventHandler(this.btns_SideBar_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.AnimationHoverSpeed = 0.07F;
            this.btn_Home.AnimationSpeed = 0.03F;
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Home.BorderColor = System.Drawing.Color.Black;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Home.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_Home.Image = global::CODEX.Properties.Resources.home_off;
            this.btn_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Home.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Home.Location = new System.Drawing.Point(16, 200);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Home.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Home.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Home.OnHoverImage = global::CODEX.Properties.Resources.home_on;
            this.btn_Home.OnPressedColor = System.Drawing.Color.White;
            this.btn_Home.OnPressedDepth = 5;
            this.btn_Home.Radius = 13;
            this.btn_Home.Size = new System.Drawing.Size(188, 50);
            this.btn_Home.TabIndex = 13;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Home.TextOffsetX = 14;
            this.btn_Home.Click += new System.EventHandler(this.btns_SideBar_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(12, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(199, 23);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "CODEX";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sidebar.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.pnl_sidebar.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.pnl_sidebar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnl_sidebar.Location = new System.Drawing.Point(11, 200);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Radius = 13;
            this.pnl_sidebar.Size = new System.Drawing.Size(50, 50);
            this.pnl_sidebar.TabIndex = 16;
            // 
            // pnl_topRight
            // 
            this.pnl_topRight.BackColor = System.Drawing.Color.Transparent;
            this.pnl_topRight.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnl_topRight.Controls.Add(this.btn_minimize);
            this.pnl_topRight.Controls.Add(this.btn_close);
            this.pnl_topRight.Location = new System.Drawing.Point(692, -44);
            this.pnl_topRight.Name = "pnl_topRight";
            this.pnl_topRight.Radius = 50;
            this.pnl_topRight.Size = new System.Drawing.Size(304, 100);
            this.pnl_topRight.TabIndex = 2;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.AnimationHoverSpeed = 0.07F;
            this.btn_minimize.AnimationSpeed = 0.03F;
            this.btn_minimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btn_minimize.IconColor = System.Drawing.Color.White;
            this.btn_minimize.IconSize = 15F;
            this.btn_minimize.Location = new System.Drawing.Point(130, 56);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btn_minimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_minimize.OnPressedColor = System.Drawing.Color.Black;
            this.btn_minimize.Size = new System.Drawing.Size(60, 29);
            this.btn_minimize.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.IconSize = 15F;
            this.btn_close.Location = new System.Drawing.Point(206, 56);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.btn_close.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(60, 29);
            this.btn_close.TabIndex = 0;
            // 
            // pnl_topMiddle
            // 
            this.pnl_topMiddle.Controls.Add(this.gunaGradient2Panel1);
            this.pnl_topMiddle.Controls.Add(this.pbox_top);
            this.pnl_topMiddle.Controls.Add(this.lbl_top);
            this.pnl_topMiddle.Location = new System.Drawing.Point(220, 0);
            this.pnl_topMiddle.Name = "pnl_topMiddle";
            this.pnl_topMiddle.Size = new System.Drawing.Size(485, 56);
            this.pnl_topMiddle.TabIndex = 3;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(21, 44);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 2;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(120, 4);
            this.gunaGradient2Panel1.TabIndex = 17;
            // 
            // pbox_top
            // 
            this.pbox_top.BaseColor = System.Drawing.Color.White;
            this.pbox_top.Image = global::CODEX.Properties.Resources.home_off;
            this.pbox_top.Location = new System.Drawing.Point(18, 11);
            this.pbox_top.Name = "pbox_top";
            this.pbox_top.Size = new System.Drawing.Size(30, 30);
            this.pbox_top.TabIndex = 6;
            this.pbox_top.TabStop = false;
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lbl_top.Location = new System.Drawing.Point(62, 16);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(51, 20);
            this.lbl_top.TabIndex = 7;
            this.lbl_top.Text = "Home";
            // 
            // drag_topMiddle
            // 
            this.drag_topMiddle.TargetControl = this.pnl_topMiddle;
            // 
            // drag_topRight
            // 
            this.drag_topRight.TargetControl = this.pnl_topRight;
            // 
            // drag_left
            // 
            this.drag_left.TargetControl = this.pnl_left;
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(220, 58);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(751, 512);
            this.pnl_main.TabIndex = 4;
            // 
            // frm_CODEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(970, 570);
            this.Controls.Add(this.pnl_topRight);
            this.Controls.Add(this.pnl_topMiddle);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CODEX";
            this.Text = "CODEX";
            this.Load += new System.EventHandler(this.CODEX_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_heart)).EndInit();
            this.pnl_topRight.ResumeLayout(false);
            this.pnl_topMiddle.ResumeLayout(false);
            this.pnl_topMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse CodexElipse;
        private Guna.UI.WinForms.GunaLinePanel pnl_left;
        private Guna.UI.WinForms.GunaElipsePanel pnl_topRight;
        private Guna.UI.WinForms.GunaControlBox btn_minimize;
        private Guna.UI.WinForms.GunaControlBox btn_close;
        private Guna.UI.WinForms.GunaPanel pnl_topMiddle;
        private Guna.UI.WinForms.GunaDragControl drag_topMiddle;
        private Guna.UI.WinForms.GunaDragControl drag_topRight;
        private Guna.UI.WinForms.GunaDragControl drag_left;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaPanel pnl_main;
        private Guna.UI.WinForms.GunaButton btn_Home;
        private Guna.UI.WinForms.GunaButton btn_Settings;
        private Guna.UI.WinForms.GunaButton btn_Search;
        private Guna.UI.WinForms.GunaPictureBox pbox_top;
        private Guna.UI.WinForms.GunaLabel lbl_top;
        private Guna.UI.WinForms.GunaGradient2Panel pnl_sidebar;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaPictureBox pbox_heart;
        private Guna.UI.WinForms.GunaLabel lbl_byLINDRA;
        private Guna.UI.WinForms.GunaLabel lbl_madeWith;
    }
}

