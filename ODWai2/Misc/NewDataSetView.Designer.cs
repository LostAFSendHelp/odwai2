namespace ODWai2.Misc
{
    partial class NewDataSetView
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_data_set_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_train_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_test_path = new System.Windows.Forms.TextBox();
            this.btn_browse_train = new System.Windows.Forms.Button();
            this.btn_browse_test = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dataset name";
            // 
            // tb_data_set_name
            // 
            this.tb_data_set_name.Location = new System.Drawing.Point(116, 24);
            this.tb_data_set_name.Name = "tb_data_set_name";
            this.tb_data_set_name.Size = new System.Drawing.Size(100, 20);
            this.tb_data_set_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Train image path";
            // 
            // tb_train_path
            // 
            this.tb_train_path.Location = new System.Drawing.Point(116, 62);
            this.tb_train_path.Name = "tb_train_path";
            this.tb_train_path.Size = new System.Drawing.Size(305, 20);
            this.tb_train_path.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Test image path";
            // 
            // tb_test_path
            // 
            this.tb_test_path.Location = new System.Drawing.Point(116, 98);
            this.tb_test_path.Name = "tb_test_path";
            this.tb_test_path.Size = new System.Drawing.Size(305, 20);
            this.tb_test_path.TabIndex = 1;
            // 
            // btn_browse_train
            // 
            this.btn_browse_train.Location = new System.Drawing.Point(427, 60);
            this.btn_browse_train.Name = "btn_browse_train";
            this.btn_browse_train.Size = new System.Drawing.Size(75, 23);
            this.btn_browse_train.TabIndex = 2;
            this.btn_browse_train.Text = "Browse";
            this.btn_browse_train.UseVisualStyleBackColor = true;
            this.btn_browse_train.Click += new System.EventHandler(this.btn_browse_train_Click);
            // 
            // btn_browse_test
            // 
            this.btn_browse_test.Location = new System.Drawing.Point(427, 96);
            this.btn_browse_test.Name = "btn_browse_test";
            this.btn_browse_test.Size = new System.Drawing.Size(75, 23);
            this.btn_browse_test.TabIndex = 2;
            this.btn_browse_test.Text = "Browse";
            this.btn_browse_test.UseVisualStyleBackColor = true;
            this.btn_browse_test.Click += new System.EventHandler(this.btn_browse_test_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(346, 138);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(427, 138);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // NewDataSetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 171);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_browse_test);
            this.Controls.Add(this.btn_browse_train);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_test_path);
            this.Controls.Add(this.tb_train_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_data_set_name);
            this.Controls.Add(this.label1);
            this.Name = "NewDataSetView";
            this.Text = "NewDataSetView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_data_set_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_train_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_test_path;
        private System.Windows.Forms.Button btn_browse_train;
        private System.Windows.Forms.Button btn_browse_test;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
    }
}