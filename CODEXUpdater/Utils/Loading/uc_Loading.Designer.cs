namespace CODEX.Utils.Loading
{
    partial class uc_Loading
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
            this.components = new System.ComponentModel.Container();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_titleLoading = new Guna.UI.WinForms.GunaLabel();
            this.pbar_loading = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.timer_circleAnimation = new System.Windows.Forms.Timer(this.components);
            this.timer_textAnimation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(18, 33);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(104, 10);
            this.gunaSeparator2.TabIndex = 19;
            // 
            // lbl_titleLoading
            // 
            this.lbl_titleLoading.AutoSize = true;
            this.lbl_titleLoading.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_titleLoading.ForeColor = System.Drawing.Color.White;
            this.lbl_titleLoading.Location = new System.Drawing.Point(15, 9);
            this.lbl_titleLoading.Name = "lbl_titleLoading";
            this.lbl_titleLoading.Size = new System.Drawing.Size(74, 21);
            this.lbl_titleLoading.TabIndex = 18;
            this.lbl_titleLoading.Text = "Updating";
            // 
            // pbar_loading
            // 
            this.pbar_loading.Animated = true;
            this.pbar_loading.AnimationSpeed = 1F;
            this.pbar_loading.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pbar_loading.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pbar_loading.IdleOffset = 20;
            this.pbar_loading.Image = null;
            this.pbar_loading.ImageSize = new System.Drawing.Size(52, 52);
            this.pbar_loading.Location = new System.Drawing.Point(198, 20);
            this.pbar_loading.Name = "pbar_loading";
            this.pbar_loading.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.pbar_loading.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.pbar_loading.ProgressOffset = 20;
            this.pbar_loading.Size = new System.Drawing.Size(150, 150);
            this.pbar_loading.TabIndex = 20;
            this.pbar_loading.Value = 1;
            // 
            // timer_circleAnimation
            // 
            this.timer_circleAnimation.Enabled = true;
            this.timer_circleAnimation.Interval = 50;
            this.timer_circleAnimation.Tick += new System.EventHandler(this.timer_circleAnimation_Tick);
            // 
            // timer_textAnimation
            // 
            this.timer_textAnimation.Enabled = true;
            this.timer_textAnimation.Interval = 500;
            this.timer_textAnimation.Tick += new System.EventHandler(this.timer_textAnimation_Tick);
            // 
            // uc_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pbar_loading);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.lbl_titleLoading);
            this.Name = "uc_Loading";
            this.Size = new System.Drawing.Size(547, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel lbl_titleLoading;
        private Guna.UI.WinForms.GunaCircleProgressBar pbar_loading;
        private System.Windows.Forms.Timer timer_circleAnimation;
        private System.Windows.Forms.Timer timer_textAnimation;
    }
}
