namespace CODEX.Views.Settings
{
    partial class uc_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Settings));
            this.tbox_configFolderPath = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_titleConfigFolder = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_titleDesktopShortcut = new Guna.UI.WinForms.GunaLabel();
            this.lbl_DesktopShortcut = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator3 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_titleUpdates = new Guna.UI.WinForms.GunaLabel();
            this.lbl_titleCurrentVerison = new Guna.UI.WinForms.GunaLabel();
            this.lbl_currentVerison = new Guna.UI.WinForms.GunaLabel();
            this.lbl_lastestVersion = new Guna.UI.WinForms.GunaLabel();
            this.lbl_titleLastestVersion = new Guna.UI.WinForms.GunaLabel();
            this.lbl_updatesChanges = new Guna.UI.WinForms.GunaLabel();
            this.btn_update = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_selectConfigFolder = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_createShortcut = new Guna.UI.WinForms.GunaGradientButton();
            this.web_updates = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // tbox_configFolderPath
            // 
            this.tbox_configFolderPath.BackColor = System.Drawing.Color.Transparent;
            this.tbox_configFolderPath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbox_configFolderPath.BorderColor = System.Drawing.Color.Silver;
            this.tbox_configFolderPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_configFolderPath.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbox_configFolderPath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tbox_configFolderPath.FocusedForeColor = System.Drawing.Color.White;
            this.tbox_configFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_configFolderPath.ForeColor = System.Drawing.Color.White;
            this.tbox_configFolderPath.Location = new System.Drawing.Point(71, 68);
            this.tbox_configFolderPath.Name = "tbox_configFolderPath";
            this.tbox_configFolderPath.PasswordChar = '\0';
            this.tbox_configFolderPath.Radius = 10;
            this.tbox_configFolderPath.SelectedText = "";
            this.tbox_configFolderPath.Size = new System.Drawing.Size(222, 40);
            this.tbox_configFolderPath.TabIndex = 11;
            this.tbox_configFolderPath.Text = "cofigFolderPath";
            // 
            // lbl_titleConfigFolder
            // 
            this.lbl_titleConfigFolder.AutoSize = true;
            this.lbl_titleConfigFolder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_titleConfigFolder.ForeColor = System.Drawing.Color.White;
            this.lbl_titleConfigFolder.Location = new System.Drawing.Point(22, 24);
            this.lbl_titleConfigFolder.Name = "lbl_titleConfigFolder";
            this.lbl_titleConfigFolder.Size = new System.Drawing.Size(101, 21);
            this.lbl_titleConfigFolder.TabIndex = 12;
            this.lbl_titleConfigFolder.Text = "Config folder";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(26, 48);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator1.TabIndex = 13;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(422, 48);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator2.TabIndex = 15;
            // 
            // lbl_titleDesktopShortcut
            // 
            this.lbl_titleDesktopShortcut.AutoSize = true;
            this.lbl_titleDesktopShortcut.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_titleDesktopShortcut.ForeColor = System.Drawing.Color.White;
            this.lbl_titleDesktopShortcut.Location = new System.Drawing.Point(418, 24);
            this.lbl_titleDesktopShortcut.Name = "lbl_titleDesktopShortcut";
            this.lbl_titleDesktopShortcut.Size = new System.Drawing.Size(130, 21);
            this.lbl_titleDesktopShortcut.TabIndex = 14;
            this.lbl_titleDesktopShortcut.Text = "Desktop Shortcut";
            // 
            // lbl_DesktopShortcut
            // 
            this.lbl_DesktopShortcut.AutoSize = true;
            this.lbl_DesktopShortcut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DesktopShortcut.ForeColor = System.Drawing.Color.White;
            this.lbl_DesktopShortcut.Location = new System.Drawing.Point(426, 77);
            this.lbl_DesktopShortcut.Name = "lbl_DesktopShortcut";
            this.lbl_DesktopShortcut.Size = new System.Drawing.Size(159, 17);
            this.lbl_DesktopShortcut.TabIndex = 16;
            this.lbl_DesktopShortcut.Text = "Create a desktop shortcut";
            // 
            // gunaSeparator3
            // 
            this.gunaSeparator3.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator3.Location = new System.Drawing.Point(26, 267);
            this.gunaSeparator3.Name = "gunaSeparator3";
            this.gunaSeparator3.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator3.TabIndex = 19;
            // 
            // lbl_titleUpdates
            // 
            this.lbl_titleUpdates.AutoSize = true;
            this.lbl_titleUpdates.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_titleUpdates.ForeColor = System.Drawing.Color.White;
            this.lbl_titleUpdates.Location = new System.Drawing.Point(22, 243);
            this.lbl_titleUpdates.Name = "lbl_titleUpdates";
            this.lbl_titleUpdates.Size = new System.Drawing.Size(67, 21);
            this.lbl_titleUpdates.TabIndex = 18;
            this.lbl_titleUpdates.Text = "Updates";
            // 
            // lbl_titleCurrentVerison
            // 
            this.lbl_titleCurrentVerison.AutoSize = true;
            this.lbl_titleCurrentVerison.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleCurrentVerison.ForeColor = System.Drawing.Color.White;
            this.lbl_titleCurrentVerison.Location = new System.Drawing.Point(32, 306);
            this.lbl_titleCurrentVerison.Name = "lbl_titleCurrentVerison";
            this.lbl_titleCurrentVerison.Size = new System.Drawing.Size(97, 17);
            this.lbl_titleCurrentVerison.TabIndex = 21;
            this.lbl_titleCurrentVerison.Text = "Current verison";
            // 
            // lbl_currentVerison
            // 
            this.lbl_currentVerison.AutoSize = true;
            this.lbl_currentVerison.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentVerison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.lbl_currentVerison.Location = new System.Drawing.Point(136, 306);
            this.lbl_currentVerison.Name = "lbl_currentVerison";
            this.lbl_currentVerison.Size = new System.Drawing.Size(31, 17);
            this.lbl_currentVerison.TabIndex = 22;
            this.lbl_currentVerison.Text = "v1.0";
            // 
            // lbl_lastestVersion
            // 
            this.lbl_lastestVersion.AutoSize = true;
            this.lbl_lastestVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastestVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.lbl_lastestVersion.Location = new System.Drawing.Point(136, 342);
            this.lbl_lastestVersion.Name = "lbl_lastestVersion";
            this.lbl_lastestVersion.Size = new System.Drawing.Size(31, 17);
            this.lbl_lastestVersion.TabIndex = 24;
            this.lbl_lastestVersion.Text = "v1.0";
            // 
            // lbl_titleLastestVersion
            // 
            this.lbl_titleLastestVersion.AutoSize = true;
            this.lbl_titleLastestVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleLastestVersion.ForeColor = System.Drawing.Color.White;
            this.lbl_titleLastestVersion.Location = new System.Drawing.Point(32, 342);
            this.lbl_titleLastestVersion.Name = "lbl_titleLastestVersion";
            this.lbl_titleLastestVersion.Size = new System.Drawing.Size(94, 17);
            this.lbl_titleLastestVersion.TabIndex = 23;
            this.lbl_titleLastestVersion.Text = "Lastest verison";
            // 
            // lbl_updatesChanges
            // 
            this.lbl_updatesChanges.AutoSize = true;
            this.lbl_updatesChanges.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updatesChanges.ForeColor = System.Drawing.Color.White;
            this.lbl_updatesChanges.Location = new System.Drawing.Point(332, 260);
            this.lbl_updatesChanges.Name = "lbl_updatesChanges";
            this.lbl_updatesChanges.Size = new System.Drawing.Size(109, 17);
            this.lbl_updatesChanges.TabIndex = 25;
            this.lbl_updatesChanges.Text = "Updates changes";
            // 
            // btn_update
            // 
            this.btn_update.AnimationHoverSpeed = 0.07F;
            this.btn_update.AnimationSpeed = 0.03F;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_update.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_update.BorderColor = System.Drawing.Color.Black;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_update.FocusedColor = System.Drawing.Color.Empty;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Image = global::CODEX.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_update.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_update.Location = new System.Drawing.Point(35, 389);
            this.btn_update.Name = "btn_update";
            this.btn_update.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_update.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_update.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_update.OnHoverImage = null;
            this.btn_update.OnPressedColor = System.Drawing.Color.Black;
            this.btn_update.OnPressedDepth = 10;
            this.btn_update.Radius = 20;
            this.btn_update.Size = new System.Drawing.Size(111, 40);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "UPDATE";
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_selectConfigFolder
            // 
            this.btn_selectConfigFolder.AnimationHoverSpeed = 0.07F;
            this.btn_selectConfigFolder.AnimationSpeed = 0.03F;
            this.btn_selectConfigFolder.BackColor = System.Drawing.Color.Transparent;
            this.btn_selectConfigFolder.BaseColor = System.Drawing.Color.Empty;
            this.btn_selectConfigFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_selectConfigFolder.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_selectConfigFolder.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_selectConfigFolder.CheckedForeColor = System.Drawing.Color.White;
            this.btn_selectConfigFolder.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_selectConfigFolder.CheckedImage")));
            this.btn_selectConfigFolder.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_selectConfigFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selectConfigFolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_selectConfigFolder.FocusedColor = System.Drawing.Color.Empty;
            this.btn_selectConfigFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_selectConfigFolder.ForeColor = System.Drawing.Color.White;
            this.btn_selectConfigFolder.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectConfigFolder.Image")));
            this.btn_selectConfigFolder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_selectConfigFolder.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_selectConfigFolder.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_selectConfigFolder.Location = new System.Drawing.Point(23, 68);
            this.btn_selectConfigFolder.Name = "btn_selectConfigFolder";
            this.btn_selectConfigFolder.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btn_selectConfigFolder.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btn_selectConfigFolder.OnHoverForeColor = System.Drawing.Color.Empty;
            this.btn_selectConfigFolder.OnHoverImage = null;
            this.btn_selectConfigFolder.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_selectConfigFolder.OnPressedColor = System.Drawing.Color.White;
            this.btn_selectConfigFolder.OnPressedDepth = 5;
            this.btn_selectConfigFolder.Radius = 10;
            this.btn_selectConfigFolder.Size = new System.Drawing.Size(42, 40);
            this.btn_selectConfigFolder.TabIndex = 10;
            this.btn_selectConfigFolder.Click += new System.EventHandler(this.btn_selectConfigFolder_Click);
            // 
            // btn_createShortcut
            // 
            this.btn_createShortcut.AnimationHoverSpeed = 0.07F;
            this.btn_createShortcut.AnimationSpeed = 0.03F;
            this.btn_createShortcut.BackColor = System.Drawing.Color.Transparent;
            this.btn_createShortcut.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_createShortcut.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_createShortcut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_createShortcut.BorderSize = 1;
            this.btn_createShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createShortcut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_createShortcut.FocusedColor = System.Drawing.Color.Empty;
            this.btn_createShortcut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createShortcut.ForeColor = System.Drawing.Color.White;
            this.btn_createShortcut.Image = null;
            this.btn_createShortcut.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_createShortcut.Location = new System.Drawing.Point(591, 64);
            this.btn_createShortcut.Name = "btn_createShortcut";
            this.btn_createShortcut.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_createShortcut.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_createShortcut.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_createShortcut.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_createShortcut.OnHoverImage = null;
            this.btn_createShortcut.OnPressedColor = System.Drawing.Color.White;
            this.btn_createShortcut.OnPressedDepth = 5;
            this.btn_createShortcut.Radius = 20;
            this.btn_createShortcut.Size = new System.Drawing.Size(94, 40);
            this.btn_createShortcut.TabIndex = 27;
            this.btn_createShortcut.Text = "CREATE";
            this.btn_createShortcut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_createShortcut.Click += new System.EventHandler(this.btn_createShortcut_Click);
            // 
            // web_updates
            // 
            this.web_updates.Location = new System.Drawing.Point(335, 296);
            this.web_updates.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_updates.Name = "web_updates";
            this.web_updates.Size = new System.Drawing.Size(400, 202);
            this.web_updates.TabIndex = 28;
            this.web_updates.Url = new System.Uri("http://s", System.UriKind.Absolute);
            // 
            // uc_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.web_updates);
            this.Controls.Add(this.btn_createShortcut);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_updatesChanges);
            this.Controls.Add(this.lbl_lastestVersion);
            this.Controls.Add(this.lbl_titleLastestVersion);
            this.Controls.Add(this.lbl_currentVerison);
            this.Controls.Add(this.lbl_titleCurrentVerison);
            this.Controls.Add(this.gunaSeparator3);
            this.Controls.Add(this.lbl_titleUpdates);
            this.Controls.Add(this.lbl_DesktopShortcut);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.lbl_titleDesktopShortcut);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.lbl_titleConfigFolder);
            this.Controls.Add(this.btn_selectConfigFolder);
            this.Controls.Add(this.tbox_configFolderPath);
            this.Name = "uc_Settings";
            this.Size = new System.Drawing.Size(751, 512);
            this.Load += new System.EventHandler(this.uc_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btn_selectConfigFolder;
        private Guna.UI.WinForms.GunaTextBox tbox_configFolderPath;
        private Guna.UI.WinForms.GunaLabel lbl_titleConfigFolder;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel lbl_titleDesktopShortcut;
        private Guna.UI.WinForms.GunaLabel lbl_DesktopShortcut;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator3;
        private Guna.UI.WinForms.GunaLabel lbl_titleUpdates;
        private Guna.UI.WinForms.GunaLabel lbl_titleCurrentVerison;
        private Guna.UI.WinForms.GunaLabel lbl_currentVerison;
        private Guna.UI.WinForms.GunaLabel lbl_lastestVersion;
        private Guna.UI.WinForms.GunaLabel lbl_titleLastestVersion;
        private Guna.UI.WinForms.GunaLabel lbl_updatesChanges;
        private Guna.UI.WinForms.GunaGradientButton btn_update;
        private Guna.UI.WinForms.GunaGradientButton btn_createShortcut;
        private System.Windows.Forms.WebBrowser web_updates;
    }
}
