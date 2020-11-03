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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Home));
            this.tbox_console = new System.Windows.Forms.TextBox();
            this.btn_saveConfigFile = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_loadConfig = new Guna.UI.WinForms.GunaGradientButton();
            this.tbox_configName = new Guna.UI.WinForms.GunaTextBox();
            this.cbox_config = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_configAddMacro = new Guna.UI.WinForms.GunaLabel();
            this.pnl_macros = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sendConsole = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_gamefound = new Guna.UI.WinForms.GunaLabel();
            this.lbl_gameName = new Guna.UI.WinForms.GunaLabel();
            this.ni_home = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbox_keys = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_keys = new Guna.UI.WinForms.GunaLabel();
            this.lbl_configName = new Guna.UI.WinForms.GunaLabel();
            this.ofd_home = new System.Windows.Forms.OpenFileDialog();
            this.btn_clear = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_addMacro = new Guna.UI.WinForms.GunaGradientButton();
            this.timer_macro = new System.Windows.Forms.Timer(this.components);
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
            this.btn_saveConfigFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveConfigFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_saveConfigFile.FocusedColor = System.Drawing.Color.Empty;
            this.btn_saveConfigFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_saveConfigFile.OnPressedDepth = 25;
            this.btn_saveConfigFile.Radius = 20;
            this.btn_saveConfigFile.Size = new System.Drawing.Size(94, 40);
            this.btn_saveConfigFile.TabIndex = 6;
            this.btn_saveConfigFile.Text = "SAVE";
            this.btn_saveConfigFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_saveConfigFile.Click += new System.EventHandler(this.btn_saveConfigFile_Click);
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
            this.btn_loadConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadConfig.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_loadConfig.FocusedColor = System.Drawing.Color.Empty;
            this.btn_loadConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_loadConfig.Click += new System.EventHandler(this.btn_loadConfig_Click);
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
            this.tbox_configName.Text = "Config name";
            this.tbox_configName.Enter += new System.EventHandler(this.tbox_configName_Enter);
            this.tbox_configName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_configName_KeyPress);
            this.tbox_configName.Leave += new System.EventHandler(this.tbox_configName_Leave);
            // 
            // cbox_config
            // 
            this.cbox_config.BackColor = System.Drawing.Color.Transparent;
            this.cbox_config.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cbox_config.BorderColor = System.Drawing.Color.Silver;
            this.cbox_config.BorderSize = 1;
            this.cbox_config.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cbox_config.Size = new System.Drawing.Size(178, 26);
            this.cbox_config.TabIndex = 11;
            this.cbox_config.Click += new System.EventHandler(this.cbox_config_Click);
            // 
            // lbl_configAddMacro
            // 
            this.lbl_configAddMacro.AutoSize = true;
            this.lbl_configAddMacro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_configAddMacro.ForeColor = System.Drawing.Color.White;
            this.lbl_configAddMacro.Location = new System.Drawing.Point(462, 123);
            this.lbl_configAddMacro.Name = "lbl_configAddMacro";
            this.lbl_configAddMacro.Size = new System.Drawing.Size(135, 15);
            this.lbl_configAddMacro.TabIndex = 13;
            this.lbl_configAddMacro.Text = "Add a Macro to a config";
            // 
            // pnl_macros
            // 
            this.pnl_macros.AutoScroll = true;
            this.pnl_macros.Location = new System.Drawing.Point(465, 200);
            this.pnl_macros.Name = "pnl_macros";
            this.pnl_macros.Size = new System.Drawing.Size(280, 295);
            this.pnl_macros.TabIndex = 14;
            // 
            // btn_sendConsole
            // 
            this.btn_sendConsole.AnimationHoverSpeed = 0.07F;
            this.btn_sendConsole.AnimationSpeed = 0.03F;
            this.btn_sendConsole.BackColor = System.Drawing.Color.Transparent;
            this.btn_sendConsole.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_sendConsole.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_sendConsole.BorderColor = System.Drawing.Color.Black;
            this.btn_sendConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sendConsole.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sendConsole.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sendConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_sendConsole.OnPressedDepth = 25;
            this.btn_sendConsole.Radius = 20;
            this.btn_sendConsole.Size = new System.Drawing.Size(94, 40);
            this.btn_sendConsole.TabIndex = 15;
            this.btn_sendConsole.Text = "SEND";
            this.btn_sendConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sendConsole.Click += new System.EventHandler(this.btn_sendConsole_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(456, 111);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(292, 10);
            this.gunaSeparator1.TabIndex = 16;
            // 
            // lbl_gamefound
            // 
            this.lbl_gamefound.AutoSize = true;
            this.lbl_gamefound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_gamefound.ForeColor = System.Drawing.Color.White;
            this.lbl_gamefound.Location = new System.Drawing.Point(263, 455);
            this.lbl_gamefound.Name = "lbl_gamefound";
            this.lbl_gamefound.Size = new System.Drawing.Size(143, 15);
            this.lbl_gamefound.TabIndex = 18;
            this.lbl_gamefound.Text = "Game detected by CODEx";
            // 
            // lbl_gameName
            // 
            this.lbl_gameName.AutoSize = true;
            this.lbl_gameName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_gameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.lbl_gameName.Location = new System.Drawing.Point(274, 476);
            this.lbl_gameName.Name = "lbl_gameName";
            this.lbl_gameName.Size = new System.Drawing.Size(167, 15);
            this.lbl_gameName.TabIndex = 19;
            this.lbl_gameName.Text = "Call of Duty Modern Warfare 3";
            // 
            // ni_home
            // 
            this.ni_home.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni_home.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_home.Icon")));
            this.ni_home.Text = "CODEx";
            this.ni_home.Visible = true;
            // 
            // cbox_keys
            // 
            this.cbox_keys.BackColor = System.Drawing.Color.Transparent;
            this.cbox_keys.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cbox_keys.BorderColor = System.Drawing.Color.Silver;
            this.cbox_keys.BorderSize = 1;
            this.cbox_keys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_keys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_keys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_keys.FocusedColor = System.Drawing.Color.Empty;
            this.cbox_keys.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_keys.ForeColor = System.Drawing.Color.White;
            this.cbox_keys.FormattingEnabled = true;
            this.cbox_keys.Location = new System.Drawing.Point(499, 168);
            this.cbox_keys.Name = "cbox_keys";
            this.cbox_keys.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cbox_keys.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbox_keys.Size = new System.Drawing.Size(141, 26);
            this.cbox_keys.TabIndex = 20;
            this.cbox_keys.Click += new System.EventHandler(this.cbox_keys_Click);
            // 
            // lbl_keys
            // 
            this.lbl_keys.AutoSize = true;
            this.lbl_keys.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_keys.ForeColor = System.Drawing.Color.White;
            this.lbl_keys.Location = new System.Drawing.Point(462, 173);
            this.lbl_keys.Name = "lbl_keys";
            this.lbl_keys.Size = new System.Drawing.Size(31, 15);
            this.lbl_keys.TabIndex = 21;
            this.lbl_keys.Text = "Keys";
            // 
            // lbl_configName
            // 
            this.lbl_configName.AutoSize = true;
            this.lbl_configName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_configName.ForeColor = System.Drawing.Color.White;
            this.lbl_configName.Location = new System.Drawing.Point(19, 3);
            this.lbl_configName.Name = "lbl_configName";
            this.lbl_configName.Size = new System.Drawing.Size(52, 15);
            this.lbl_configName.TabIndex = 22;
            this.lbl_configName.Text = "Config : ";
            // 
            // ofd_home
            // 
            this.ofd_home.DefaultExt = "json";
            this.ofd_home.FileName = "openFileDialog1";
            this.ofd_home.Filter = "json files (*.json)|*.json";
            this.ofd_home.Multiselect = true;
            this.ofd_home.Title = "CODEx open config files";
            // 
            // btn_clear
            // 
            this.btn_clear.AnimationHoverSpeed = 0.07F;
            this.btn_clear.AnimationSpeed = 0.03F;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_clear.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_clear.BorderSize = 1;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_clear.FocusedColor = System.Drawing.Color.Empty;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Image = global::CODEX.Properties.Resources.eraser;
            this.btn_clear.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_clear.Location = new System.Drawing.Point(465, 19);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_clear.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_clear.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btn_clear.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_clear.OnHoverImage = null;
            this.btn_clear.OnPressedColor = System.Drawing.Color.White;
            this.btn_clear.OnPressedDepth = 5;
            this.btn_clear.Radius = 20;
            this.btn_clear.Size = new System.Drawing.Size(94, 40);
            this.btn_clear.TabIndex = 23;
            this.btn_clear.Text = " Clear";
            this.btn_clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_addMacro
            // 
            this.btn_addMacro.AnimationHoverSpeed = 0.07F;
            this.btn_addMacro.AnimationSpeed = 0.03F;
            this.btn_addMacro.BackColor = System.Drawing.Color.Transparent;
            this.btn_addMacro.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_addMacro.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_addMacro.BorderColor = System.Drawing.Color.Black;
            this.btn_addMacro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addMacro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_addMacro.FocusedColor = System.Drawing.Color.Empty;
            this.btn_addMacro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMacro.ForeColor = System.Drawing.Color.White;
            this.btn_addMacro.Image = global::CODEX.Properties.Resources.add;
            this.btn_addMacro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_addMacro.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_addMacro.Location = new System.Drawing.Point(646, 134);
            this.btn_addMacro.Name = "btn_addMacro";
            this.btn_addMacro.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.btn_addMacro.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btn_addMacro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_addMacro.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_addMacro.OnHoverImage = null;
            this.btn_addMacro.OnPressedColor = System.Drawing.Color.Black;
            this.btn_addMacro.OnPressedDepth = 25;
            this.btn_addMacro.Radius = 20;
            this.btn_addMacro.Size = new System.Drawing.Size(94, 40);
            this.btn_addMacro.TabIndex = 12;
            this.btn_addMacro.Text = "ADD";
            this.btn_addMacro.TextOffsetX = 5;
            this.btn_addMacro.Click += new System.EventHandler(this.btn_addMacro_Click);
            // 
            // timer_macro
            // 
            this.timer_macro.Enabled = true;
            this.timer_macro.Tick += new System.EventHandler(this.timer_macro_Tick);
            // 
            // uc_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_configName);
            this.Controls.Add(this.lbl_keys);
            this.Controls.Add(this.cbox_keys);
            this.Controls.Add(this.lbl_gameName);
            this.Controls.Add(this.lbl_gamefound);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btn_sendConsole);
            this.Controls.Add(this.pnl_macros);
            this.Controls.Add(this.lbl_configAddMacro);
            this.Controls.Add(this.btn_addMacro);
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
        private Guna.UI.WinForms.GunaGradientButton btn_addMacro;
        private Guna.UI.WinForms.GunaLabel lbl_configAddMacro;
        private System.Windows.Forms.FlowLayoutPanel pnl_macros;
        private Guna.UI.WinForms.GunaGradientButton btn_sendConsole;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel lbl_gamefound;
        private Guna.UI.WinForms.GunaLabel lbl_gameName;
        public System.Windows.Forms.NotifyIcon ni_home;
        private Guna.UI.WinForms.GunaComboBox cbox_keys;
        private Guna.UI.WinForms.GunaLabel lbl_keys;
        private Guna.UI.WinForms.GunaLabel lbl_configName;
        private System.Windows.Forms.OpenFileDialog ofd_home;
        private Guna.UI.WinForms.GunaGradientButton btn_clear;
        private System.Windows.Forms.Timer timer_macro;
    }
}
