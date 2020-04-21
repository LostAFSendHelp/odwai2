namespace ODWai2.Misc.Views
{
    partial class LoadJson
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
            this.txt_associated = new System.Windows.Forms.TextBox();
            this.txt_eror = new System.Windows.Forms.TextBox();
            this.txt_sample = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_associated
            // 
            this.txt_associated.Location = new System.Drawing.Point(39, 41);
            this.txt_associated.Name = "txt_associated";
            this.txt_associated.Size = new System.Drawing.Size(534, 20);
            this.txt_associated.TabIndex = 0;
            // 
            // txt_eror
            // 
            this.txt_eror.Location = new System.Drawing.Point(39, 125);
            this.txt_eror.Name = "txt_eror";
            this.txt_eror.Size = new System.Drawing.Size(534, 20);
            this.txt_eror.TabIndex = 1;
            // 
            // txt_sample
            // 
            this.txt_sample.Location = new System.Drawing.Point(39, 80);
            this.txt_sample.Name = "txt_sample";
            this.txt_sample.Size = new System.Drawing.Size(534, 20);
            this.txt_sample.TabIndex = 2;
            // 
            // LoadJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_sample);
            this.Controls.Add(this.txt_eror);
            this.Controls.Add(this.txt_associated);
            this.Name = "LoadJson";
            this.Text = "LoadJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_associated;
        private System.Windows.Forms.TextBox txt_eror;
        private System.Windows.Forms.TextBox txt_sample;
    }
}