namespace ODWai2.Misc
{
    partial class ImageItemView
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
            this.pbox_image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_image = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_xml = new System.Windows.Forms.TextBox();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_image
            // 
            this.pbox_image.Location = new System.Drawing.Point(0, 0);
            this.pbox_image.Name = "pbox_image";
            this.pbox_image.Size = new System.Drawing.Size(168, 162);
            this.pbox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_image.TabIndex = 0;
            this.pbox_image.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbox_image);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 193);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // tb_image
            // 
            this.tb_image.Enabled = false;
            this.tb_image.Location = new System.Drawing.Point(12, 236);
            this.tb_image.Name = "tb_image";
            this.tb_image.Size = new System.Drawing.Size(195, 20);
            this.tb_image.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "XML";
            // 
            // tb_xml
            // 
            this.tb_xml.Enabled = false;
            this.tb_xml.Location = new System.Drawing.Point(216, 236);
            this.tb_xml.Name = "tb_xml";
            this.tb_xml.Size = new System.Drawing.Size(195, 20);
            this.tb_xml.TabIndex = 3;
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(12, 274);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.ReadOnly = true;
            this.dgv_info.Size = new System.Drawing.Size(399, 132);
            this.dgv_info.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(167, 414);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ImageItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 446);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.tb_xml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ImageItemView";
            this.Text = "ImageItemView";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_xml;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Button btn_ok;
    }
}