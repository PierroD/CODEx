namespace CODEX.Views.Home.MacroModel
{
    partial class uc_Macro
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lbl_config = new Guna.UI.WinForms.GunaLabel();
            this.lbl_key = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lbl_key);
            this.gunaLinePanel1.Controls.Add(this.lbl_config);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(240, 40);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // lbl_config
            // 
            this.lbl_config.AutoSize = true;
            this.lbl_config.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_config.ForeColor = System.Drawing.Color.White;
            this.lbl_config.Location = new System.Drawing.Point(34, 13);
            this.lbl_config.Name = "lbl_config";
            this.lbl_config.Size = new System.Drawing.Size(43, 15);
            this.lbl_config.TabIndex = 0;
            this.lbl_config.Text = "Config";
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_key.ForeColor = System.Drawing.Color.White;
            this.lbl_key.Location = new System.Drawing.Point(171, 13);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(26, 15);
            this.lbl_key.TabIndex = 1;
            this.lbl_key.Text = "Key";
            // 
            // uc_Macro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "uc_Macro";
            this.Size = new System.Drawing.Size(240, 40);
            this.Load += new System.EventHandler(this.uc_Macro_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel lbl_key;
        private Guna.UI.WinForms.GunaLabel lbl_config;
    }
}
