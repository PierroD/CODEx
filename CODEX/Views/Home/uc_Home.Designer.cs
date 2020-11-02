namespace CODEX.Views.Home
{
    partial class uc_Home
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_console = new System.Windows.Forms.TextBox();
            this.btn_saveConfigFile = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_loadConfig = new Guna.UI.WinForms.GunaGradientButton();
            this.tbox_configName = new Guna.UI.WinForms.GunaTextBox();
            this.cbox_config = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_configAddToogles = new Guna.UI.WinForms.GunaLabel();
            this.pnl_toogles = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sendConsole = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_gamefound = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_addToogles = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // tbox_console
            // 
            this.tbox_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbox_console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_console.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_console.ForeColor = System.Drawing.Color.White;
            this.tbox_console.Location = new System.Drawing.Point(13, 21);
            this.tbox_console.Multiline = true;
            this.tbox_console.Name = "tbox_console";
            this.tbox_console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_console.Size = new System.Drawing.Size(437, 428);
            this.tbox_console.TabIndex = 5;
            // 
            // btn_saveConfigFile
            // 
            this.btn_saveConfigFile.AnimationHoverSpeed = 0.07F;
            this.btn_saveConfigFile.AnimationSpeed = 0.03F;
            this.btn_saveConfigFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveConfigFile.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_saveConfigFile.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_saveConfigFile.BorderColor = System.Drawing.Color.Black;
            this.btn_saveConfigFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_saveConfigFile.FocusedColor = System.Drawing.Color.Empty;
            this.btn_saveConfigFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_saveConfigFile.ForeColor = System.Drawing.Color.White;
            this.btn_saveConfigFile.Image = null;
            this.btn_saveConfigFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_saveConfigFile.Location = new System.Drawing.Point(646, 65);
            this.btn_saveConfigFile.Name = "btn_saveConfigFile";
            this.btn_saveConfigFile.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_saveConfigFile.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_saveConfigFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_saveConfigFile.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_saveConfigFile.OnHoverImage = null;
            this.btn_saveConfigFile.OnPressedColor = System.Drawing.Color.Black;
            this.btn_saveConfigFile.OnPressedDepth = 10;
            this.btn_saveConfigFile.Radius = 20;
            this.btn_saveConfigFile.Size = new System.Drawing.Size(94, 40);
            this.btn_saveConfigFile.TabIndex = 6;
            this.btn_saveConfigFile.Text = "SAVE";
            this.btn_saveConfigFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_loadConfig
            // 
            this.btn_loadConfig.AnimationHoverSpeed = 0.07F;
            this.btn_loadConfig.AnimationSpeed = 0.03F;
            this.btn_loadConfig.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadConfig.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_loadConfig.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_loadConfig.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_loadConfig.BorderSize = 1;
            this.btn_loadConfig.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_loadConfig.FocusedColor = System.Drawing.Color.Empty;
            this.btn_loadConfig.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_loadConfig.ForeColor = System.Drawing.Color.White;
            this.btn_loadConfig.Image = null;
            this.btn_loadConfig.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_loadConfig.Location = new System.Drawing.Point(646, 19);
            this.btn_loadConfig.Name = "btn_loadConfig";
            this.btn_loadConfig.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_loadConfig.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_loadConfig.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_loadConfig.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_loadConfig.OnHoverImage = null;
            this.btn_loadConfig.OnPressedColor = System.Drawing.Color.White;
            this.btn_loadConfig.OnPressedDepth = 5;
            this.btn_loadConfig.Radius = 20;
            this.btn_loadConfig.Size = new System.Drawing.Size(94, 40);
            this.btn_loadConfig.TabIndex = 7;
            this.btn_loadConfig.Text = "LOAD";
            this.btn_loadConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_configName
            // 
            this.tbox_configName.BackColor = System.Drawing.Color.Transparent;
            this.tbox_configName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbox_configName.BorderColor = System.Drawing.Color.Silver;
            this.tbox_configName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_configName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbox_configName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tbox_configName.FocusedForeColor = System.Drawing.Color.White;
            this.tbox_configName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_configName.ForeColor = System.Drawing.Color.White;
            this.tbox_configName.Location = new System.Drawing.Point(465, 65);
            this.tbox_configName.Name = "tbox_configName";
            this.tbox_configName.PasswordChar = '\0';
            this.tbox_configName.Radius = 10;
            this.tbox_configName.SelectedText = "";
            this.tbox_configName.Size = new System.Drawing.Size(175, 40);
            this.tbox_configName.TabIndex = 8;
            this.tbox_configName.Text = "FileName";
            // 
            // cbox_config
            // 
            this.cbox_config.BackColor = System.Drawing.Color.Transparent;
            this.cbox_config.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cbox_config.BorderColor = System.Drawing.Color.Silver;
            this.cbox_config.BorderSize = 1;
            this.cbox_config.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_config.FocusedColor = System.Drawing.Color.Empty;
            this.cbox_config.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_config.ForeColor = System.Drawing.Color.White;
            this.cbox_config.FormattingEnabled = true;
            this.cbox_config.Location = new System.Drawing.Point(462, 141);
            this.cbox_config.Name = "cbox_config";
            this.cbox_config.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cbox_config.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbox_config.Size = new System.Drawing.Size(194, 26);
            this.cbox_config.TabIndex = 11;
            // 
            // lbl_configAddToogles
            // 
            this.lbl_configAddToogles.AutoSize = true;
            this.lbl_configAddToogles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_configAddToogles.ForeColor = System.Drawing.Color.White;
            this.lbl_configAddToogles.Location = new System.Drawing.Point(462, 123);
            this.lbl_configAddToogles.Name = "lbl_configAddToogles";
            this.lbl_configAddToogles.Size = new System.Drawing.Size(151, 15);
            this.lbl_configAddToogles.TabIndex = 13;
            this.lbl_configAddToogles.Text = "Add a config to the toogles";
            // 
            // pnl_toogles
            // 
            this.pnl_toogles.Location = new System.Drawing.Point(465, 180);
            this.pnl_toogles.Name = "pnl_toogles";
            this.pnl_toogles.Size = new System.Drawing.Size(280, 230);
            this.pnl_toogles.TabIndex = 14;
            // 
            // btn_sendConsole
            // 
            this.btn_sendConsole.AnimationHoverSpeed = 0.07F;
            this.btn_sendConsole.AnimationSpeed = 0.03F;
            this.btn_sendConsole.BackColor = System.Drawing.Color.Transparent;
            this.btn_sendConsole.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_sendConsole.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_sendConsole.BorderColor = System.Drawing.Color.Black;
            this.btn_sendConsole.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sendConsole.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sendConsole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_sendConsole.ForeColor = System.Drawing.Color.White;
            this.btn_sendConsole.Image = null;
            this.btn_sendConsole.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_sendConsole.Location = new System.Drawing.Point(13, 455);
            this.btn_sendConsole.Name = "btn_sendConsole";
            this.btn_sendConsole.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_sendConsole.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_sendConsole.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sendConsole.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_sendConsole.OnHoverImage = null;
            this.btn_sendConsole.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sendConsole.OnPressedDepth = 10;
            this.btn_sendConsole.Radius = 20;
            this.btn_sendConsole.Size = new System.Drawing.Size(94, 40);
            this.btn_sendConsole.TabIndex = 15;
            this.btn_sendConsole.Text = "SEND";
            this.btn_sendConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(456, 111);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(292, 10);
            this.gunaSeparator1.TabIndex = 16;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(456, 416);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(292, 10);
            this.gunaSeparator2.TabIndex = 17;
            // 
            // lbl_gamefound
            // 
            this.lbl_gamefound.AutoSize = true;
            this.lbl_gamefound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_gamefound.ForeColor = System.Drawing.Color.White;
            this.lbl_gamefound.Location = new System.Drawing.Point(459, 434);
            this.lbl_gamefound.Name = "lbl_gamefound";
            this.lbl_gamefound.Size = new System.Drawing.Size(143, 15);
            this.lbl_gamefound.TabIndex = 18;
            this.lbl_gamefound.Text = "Game detected by CODEx";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.gunaLabel1.Location = new System.Drawing.Point(470, 455);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(167, 15);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Call of Duty Modern Warfare 3";
            // 
            // btn_addToogles
            // 
            this.btn_addToogles.AnimationHoverSpeed = 0.07F;
            this.btn_addToogles.AnimationSpeed = 0.03F;
            this.btn_addToogles.BackColor = System.Drawing.Color.Transparent;
            this.btn_addToogles.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_addToogles.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_addToogles.BorderColor = System.Drawing.Color.Black;
            this.btn_addToogles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_addToogles.FocusedColor = System.Drawing.Color.Empty;
            this.btn_addToogles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_addToogles.ForeColor = System.Drawing.Color.White;
            this.btn_addToogles.Image = global::CODEX.Properties.Resources.add;
            this.btn_addToogles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_addToogles.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_addToogles.Location = new System.Drawing.Point(662, 134);
            this.btn_addToogles.Name = "btn_addToogles";
            this.btn_addToogles.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_addToogles.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_addToogles.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_addToogles.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_addToogles.OnHoverImage = null;
            this.btn_addToogles.OnPressedColor = System.Drawing.Color.Black;
            this.btn_addToogles.OnPressedDepth = 10;
            this.btn_addToogles.Radius = 20;
            this.btn_addToogles.Size = new System.Drawing.Size(83, 40);
            this.btn_addToogles.TabIndex = 12;
            this.btn_addToogles.Text = "ADD";
            // 
            // uc_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lbl_gamefound);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btn_sendConsole);
            this.Controls.Add(this.pnl_toogles);
            this.Controls.Add(this.lbl_configAddToogles);
            this.Controls.Add(this.btn_addToogles);
            this.Controls.Add(this.cbox_config);
            this.Controls.Add(this.tbox_configName);
            this.Controls.Add(this.btn_loadConfig);
            this.Controls.Add(this.btn_saveConfigFile);
            this.Controls.Add(this.tbox_console);
            this.Name = "uc_Home";
            this.Size = new System.Drawing.Size(751, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_console;
        private Guna.UI.WinForms.GunaGradientButton btn_saveConfigFile;
        private Guna.UI.WinForms.GunaGradientButton btn_loadConfig;
        private Guna.UI.WinForms.GunaTextBox tbox_configName;
        private Guna.UI.WinForms.GunaComboBox cbox_config;
        private Guna.UI.WinForms.GunaGradientButton btn_addToogles;
        private Guna.UI.WinForms.GunaLabel lbl_configAddToogles;
        private System.Windows.Forms.FlowLayoutPanel pnl_toogles;
        private Guna.UI.WinForms.GunaGradientButton btn_sendConsole;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel lbl_gamefound;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
