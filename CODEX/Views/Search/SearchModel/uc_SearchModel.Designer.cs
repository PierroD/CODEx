namespace CODEX.Views.Search.SearchModel
{
    partial class uc_SearchModel
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
            this.pnl_background = new Guna.UI.WinForms.GunaLinePanel();
            this.pbox_copyDvar = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_dvarDescription = new Guna.UI.WinForms.GunaLabel();
            this.lbl_dvarName = new Guna.UI.WinForms.GunaLabel();
            this.pnl_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_copyDvar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_background
            // 
            this.pnl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnl_background.Controls.Add(this.pbox_copyDvar);
            this.pnl_background.Controls.Add(this.lbl_dvarDescription);
            this.pnl_background.Controls.Add(this.lbl_dvarName);
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_background.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_background.ForeColor = System.Drawing.Color.White;
            this.pnl_background.LineBottom = 1;
            this.pnl_background.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.pnl_background.LineLeft = 1;
            this.pnl_background.LineRight = 1;
            this.pnl_background.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_background.LineTop = 1;
            this.pnl_background.Location = new System.Drawing.Point(0, 0);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(690, 60);
            this.pnl_background.TabIndex = 0;
            // 
            // pbox_copyDvar
            // 
            this.pbox_copyDvar.BaseColor = System.Drawing.Color.White;
            this.pbox_copyDvar.Image = global::CODEX.Properties.Resources.copy;
            this.pbox_copyDvar.Location = new System.Drawing.Point(644, 15);
            this.pbox_copyDvar.Name = "pbox_copyDvar";
            this.pbox_copyDvar.Size = new System.Drawing.Size(30, 30);
            this.pbox_copyDvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_copyDvar.TabIndex = 2;
            this.pbox_copyDvar.TabStop = false;
            // 
            // lbl_dvarDescription
            // 
            this.lbl_dvarDescription.AutoSize = true;
            this.lbl_dvarDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_dvarDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lbl_dvarDescription.Location = new System.Drawing.Point(13, 36);
            this.lbl_dvarDescription.Name = "lbl_dvarDescription";
            this.lbl_dvarDescription.Size = new System.Drawing.Size(67, 15);
            this.lbl_dvarDescription.TabIndex = 1;
            this.lbl_dvarDescription.Text = "Description";
            // 
            // lbl_dvarName
            // 
            this.lbl_dvarName.AutoSize = true;
            this.lbl_dvarName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dvarName.Location = new System.Drawing.Point(12, 9);
            this.lbl_dvarName.Name = "lbl_dvarName";
            this.lbl_dvarName.Size = new System.Drawing.Size(50, 20);
            this.lbl_dvarName.TabIndex = 0;
            this.lbl_dvarName.Text = "Name";
            // 
            // uc_SearchModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_background);
            this.Name = "uc_SearchModel";
            this.Size = new System.Drawing.Size(690, 60);
            this.Load += new System.EventHandler(this.uc_SearchModel_Load);
            this.pnl_background.ResumeLayout(false);
            this.pnl_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_copyDvar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel pnl_background;
        private Guna.UI.WinForms.GunaPictureBox pbox_copyDvar;
        private Guna.UI.WinForms.GunaLabel lbl_dvarDescription;
        private Guna.UI.WinForms.GunaLabel lbl_dvarName;
    }
}
