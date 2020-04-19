namespace ODWai2.Presentation
{
    partial class DataSetView
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
            this.cbox_data_set = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_graph = new System.Windows.Forms.ComboBox();
            this.tb_data_set_path = new System.Windows.Forms.TextBox();
            this.path_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_graph_path = new System.Windows.Forms.TextBox();
            this.btn_data_set_dir = new System.Windows.Forms.Button();
            this.btn_graph_dir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_generate_training_resources = new System.Windows.Forms.Button();
            this.btn_delete_data_set = new System.Windows.Forms.Button();
            this.btn_new_data_set = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_data_set_testing = new System.Windows.Forms.DataGridView();
            this.dgv_data_set_training = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_import_graph = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_set_testing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_set_training)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data set name";
            // 
            // cbox_data_set
            // 
            this.cbox_data_set.FormattingEnabled = true;
            this.cbox_data_set.Location = new System.Drawing.Point(124, 12);
            this.cbox_data_set.Name = "cbox_data_set";
            this.cbox_data_set.Size = new System.Drawing.Size(146, 21);
            this.cbox_data_set.TabIndex = 1;
            this.cbox_data_set.SelectedValueChanged += new System.EventHandler(this.cbox_data_set_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inference graph";
            // 
            // cbox_graph
            // 
            this.cbox_graph.FormattingEnabled = true;
            this.cbox_graph.Location = new System.Drawing.Point(124, 73);
            this.cbox_graph.Name = "cbox_graph";
            this.cbox_graph.Size = new System.Drawing.Size(146, 21);
            this.cbox_graph.TabIndex = 1;
            this.cbox_graph.SelectedValueChanged += new System.EventHandler(this.cbox_graph_SelectedValueChanged);
            // 
            // tb_data_set_path
            // 
            this.tb_data_set_path.Enabled = false;
            this.tb_data_set_path.Location = new System.Drawing.Point(124, 39);
            this.tb_data_set_path.Name = "tb_data_set_path";
            this.tb_data_set_path.Size = new System.Drawing.Size(336, 20);
            this.tb_data_set_path.TabIndex = 2;
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Location = new System.Drawing.Point(19, 42);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(29, 13);
            this.path_label.TabIndex = 0;
            this.path_label.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path";
            // 
            // tb_graph_path
            // 
            this.tb_graph_path.Enabled = false;
            this.tb_graph_path.Location = new System.Drawing.Point(124, 100);
            this.tb_graph_path.Name = "tb_graph_path";
            this.tb_graph_path.Size = new System.Drawing.Size(336, 20);
            this.tb_graph_path.TabIndex = 2;
            // 
            // btn_data_set_dir
            // 
            this.btn_data_set_dir.Location = new System.Drawing.Point(466, 37);
            this.btn_data_set_dir.Name = "btn_data_set_dir";
            this.btn_data_set_dir.Size = new System.Drawing.Size(111, 23);
            this.btn_data_set_dir.TabIndex = 3;
            this.btn_data_set_dir.Text = "Open in Explorer";
            this.btn_data_set_dir.UseVisualStyleBackColor = true;
            this.btn_data_set_dir.Click += new System.EventHandler(this.btn_data_set_dir_Click);
            // 
            // btn_graph_dir
            // 
            this.btn_graph_dir.Location = new System.Drawing.Point(466, 98);
            this.btn_graph_dir.Name = "btn_graph_dir";
            this.btn_graph_dir.Size = new System.Drawing.Size(111, 23);
            this.btn_graph_dir.TabIndex = 3;
            this.btn_graph_dir.Text = "Open in Explorer";
            this.btn_graph_dir.UseVisualStyleBackColor = true;
            this.btn_graph_dir.Click += new System.EventHandler(this.btn_graph_dir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_generate_training_resources);
            this.groupBox1.Controls.Add(this.btn_delete_data_set);
            this.groupBox1.Controls.Add(this.btn_new_data_set);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgv_data_set_testing);
            this.groupBox1.Controls.Add(this.dgv_data_set_training);
            this.groupBox1.Location = new System.Drawing.Point(22, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data items";
            // 
            // btn_generate_training_resources
            // 
            this.btn_generate_training_resources.Location = new System.Drawing.Point(549, 270);
            this.btn_generate_training_resources.Name = "btn_generate_training_resources";
            this.btn_generate_training_resources.Size = new System.Drawing.Size(175, 23);
            this.btn_generate_training_resources.TabIndex = 2;
            this.btn_generate_training_resources.Text = "Generate training resources";
            this.btn_generate_training_resources.UseVisualStyleBackColor = true;
            this.btn_generate_training_resources.Click += new System.EventHandler(this.btn_generate_training_resources_Click);
            // 
            // btn_delete_data_set
            // 
            this.btn_delete_data_set.Location = new System.Drawing.Point(97, 270);
            this.btn_delete_data_set.Name = "btn_delete_data_set";
            this.btn_delete_data_set.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_data_set.TabIndex = 2;
            this.btn_delete_data_set.Text = "Delete";
            this.btn_delete_data_set.UseVisualStyleBackColor = true;
            this.btn_delete_data_set.Click += new System.EventHandler(this.btn_delete_data_set_Click);
            // 
            // btn_new_data_set
            // 
            this.btn_new_data_set.Location = new System.Drawing.Point(16, 270);
            this.btn_new_data_set.Name = "btn_new_data_set";
            this.btn_new_data_set.Size = new System.Drawing.Size(75, 23);
            this.btn_new_data_set.TabIndex = 2;
            this.btn_new_data_set.Text = "New Set";
            this.btn_new_data_set.UseVisualStyleBackColor = true;
            this.btn_new_data_set.Click += new System.EventHandler(this.btn_new_data_set_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Testing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Training";
            // 
            // dgv_data_set_testing
            // 
            this.dgv_data_set_testing.AllowUserToAddRows = false;
            this.dgv_data_set_testing.AllowUserToDeleteRows = false;
            this.dgv_data_set_testing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_set_testing.Location = new System.Drawing.Point(385, 44);
            this.dgv_data_set_testing.Name = "dgv_data_set_testing";
            this.dgv_data_set_testing.ReadOnly = true;
            this.dgv_data_set_testing.Size = new System.Drawing.Size(339, 211);
            this.dgv_data_set_testing.TabIndex = 0;
            this.dgv_data_set_testing.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_set_testing_CellDoubleClick);
            // 
            // dgv_data_set_training
            // 
            this.dgv_data_set_training.AllowUserToAddRows = false;
            this.dgv_data_set_training.AllowUserToDeleteRows = false;
            this.dgv_data_set_training.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_set_training.Location = new System.Drawing.Point(16, 44);
            this.dgv_data_set_training.Name = "dgv_data_set_training";
            this.dgv_data_set_training.ReadOnly = true;
            this.dgv_data_set_training.Size = new System.Drawing.Size(339, 211);
            this.dgv_data_set_training.TabIndex = 0;
            this.dgv_data_set_training.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_set_training_CellDoubleClick);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(694, 15);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_import_graph
            // 
            this.btn_import_graph.Location = new System.Drawing.Point(276, 72);
            this.btn_import_graph.Name = "btn_import_graph";
            this.btn_import_graph.Size = new System.Drawing.Size(75, 23);
            this.btn_import_graph.TabIndex = 5;
            this.btn_import_graph.Text = "Import";
            this.btn_import_graph.UseVisualStyleBackColor = true;
            this.btn_import_graph.Click += new System.EventHandler(this.btn_import_graph_Click);
            // 
            // DataSetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 455);
            this.ControlBox = false;
            this.Controls.Add(this.btn_import_graph);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_graph_dir);
            this.Controls.Add(this.btn_data_set_dir);
            this.Controls.Add(this.tb_graph_path);
            this.Controls.Add(this.tb_data_set_path);
            this.Controls.Add(this.cbox_graph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_data_set);
            this.Controls.Add(this.path_label);
            this.Controls.Add(this.label1);
            this.Name = "DataSetView";
            this.Text = "Data set configurations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_set_testing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_set_training)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_data_set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_graph;
        private System.Windows.Forms.TextBox tb_data_set_path;
        private System.Windows.Forms.Label path_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_graph_path;
        private System.Windows.Forms.Button btn_data_set_dir;
        private System.Windows.Forms.Button btn_graph_dir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_data_set_training;
        private System.Windows.Forms.Button btn_generate_training_resources;
        private System.Windows.Forms.Button btn_delete_data_set;
        private System.Windows.Forms.Button btn_new_data_set;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_data_set_testing;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_import_graph;
    }
}