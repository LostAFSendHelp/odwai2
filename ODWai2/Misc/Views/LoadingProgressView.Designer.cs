namespace ODWai2.Misc.Views
{
    partial class LoadingProgressView
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
            this.lbl_progress = new System.Windows.Forms.Label();
            this.lbl_caption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_progress
            // 
            this.lbl_progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_progress.Location = new System.Drawing.Point(0, 49);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(460, 37);
            this.lbl_progress.TabIndex = 0;
            this.lbl_progress.Text = "[work in progress]";
            this.lbl_progress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_caption
            // 
            this.lbl_caption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_caption.Location = new System.Drawing.Point(0, 0);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(460, 34);
            this.lbl_caption.TabIndex = 1;
            this.lbl_caption.Text = "Please wait while the following action is being processed";
            this.lbl_caption.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LoadingProgressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 86);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_caption);
            this.Controls.Add(this.lbl_progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingProgressView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.Label lbl_caption;
    }
}