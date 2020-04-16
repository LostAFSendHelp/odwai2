namespace ODWai2.Presentation
{
    partial class MainView
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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.testing_tab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_region_capture = new System.Windows.Forms.Button();
            this.tb_root_x = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_root_y = new System.Windows.Forms.TextBox();
            this.config_tab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_input_set_dir = new System.Windows.Forms.Button();
            this.edit_input_set_btn = new System.Windows.Forms.Button();
            this.delete_input_set_btn = new System.Windows.Forms.Button();
            this.new_input_set_btn = new System.Windows.Forms.Button();
            this.input_set_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.input_set_cbox = new System.Windows.Forms.ComboBox();
            this.btn_detect = new System.Windows.Forms.Button();
            this.btn_simulate = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.skip_result_checkbox = new System.Windows.Forms.CheckBox();
            this.btn_data_set_config = new System.Windows.Forms.Button();
            this.btn_python_path = new System.Windows.Forms.Button();
            this.tab_control.SuspendLayout();
            this.testing_tab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.config_tab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_set_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.testing_tab);
            this.tab_control.Controls.Add(this.config_tab);
            this.tab_control.Location = new System.Drawing.Point(12, 12);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(808, 327);
            this.tab_control.TabIndex = 0;
            // 
            // testing_tab
            // 
            this.testing_tab.Controls.Add(this.groupBox4);
            this.testing_tab.Controls.Add(this.groupBox3);
            this.testing_tab.Controls.Add(this.groupBox1);
            this.testing_tab.Location = new System.Drawing.Point(4, 22);
            this.testing_tab.Name = "testing_tab";
            this.testing_tab.Padding = new System.Windows.Forms.Padding(3);
            this.testing_tab.Size = new System.Drawing.Size(800, 301);
            this.testing_tab.TabIndex = 0;
            this.testing_tab.Text = "Testing";
            this.testing_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(579, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 289);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detection result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(203, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(224, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 289);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 264);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_region_capture);
            this.groupBox1.Controls.Add(this.tb_root_x);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_height);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_width);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_root_y);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture region";
            // 
            // btn_region_capture
            // 
            this.btn_region_capture.Location = new System.Drawing.Point(6, 260);
            this.btn_region_capture.Name = "btn_region_capture";
            this.btn_region_capture.Size = new System.Drawing.Size(200, 23);
            this.btn_region_capture.TabIndex = 3;
            this.btn_region_capture.Text = "Re-capture region";
            this.btn_region_capture.UseVisualStyleBackColor = true;
            this.btn_region_capture.Click += new System.EventHandler(this.btn_region_capture_Click);
            // 
            // tb_root_x
            // 
            this.tb_root_x.Enabled = false;
            this.tb_root_x.Location = new System.Drawing.Point(63, 22);
            this.tb_root_x.Name = "tb_root_x";
            this.tb_root_x.Size = new System.Drawing.Size(135, 20);
            this.tb_root_x.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Height";
            // 
            // tb_height
            // 
            this.tb_height.Enabled = false;
            this.tb_height.Location = new System.Drawing.Point(63, 120);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(135, 20);
            this.tb_height.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Width";
            // 
            // tb_width
            // 
            this.tb_width.Enabled = false;
            this.tb_width.Location = new System.Drawing.Point(63, 94);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(135, 20);
            this.tb_width.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Root Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Root X";
            // 
            // tb_root_y
            // 
            this.tb_root_y.Enabled = false;
            this.tb_root_y.Location = new System.Drawing.Point(63, 48);
            this.tb_root_y.Name = "tb_root_y";
            this.tb_root_y.Size = new System.Drawing.Size(135, 20);
            this.tb_root_y.TabIndex = 1;
            // 
            // config_tab
            // 
            this.config_tab.Controls.Add(this.groupBox5);
            this.config_tab.Controls.Add(this.groupBox2);
            this.config_tab.Location = new System.Drawing.Point(4, 22);
            this.config_tab.Name = "config_tab";
            this.config_tab.Padding = new System.Windows.Forms.Padding(3);
            this.config_tab.Size = new System.Drawing.Size(800, 301);
            this.config_tab.TabIndex = 1;
            this.config_tab.Text = "Configs";
            this.config_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.checkBox6);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(437, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 286);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Simulation settings";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 20);
            this.textBox5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input rate (per second)";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(21, 197);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(68, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "All inputs";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(21, 100);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Valid inputs";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(21, 165);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(116, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Randomized inputs";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Edge inputs";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 133);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Custom inputs";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Error input";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_input_set_dir);
            this.groupBox2.Controls.Add(this.edit_input_set_btn);
            this.groupBox2.Controls.Add(this.delete_input_set_btn);
            this.groupBox2.Controls.Add(this.new_input_set_btn);
            this.groupBox2.Controls.Add(this.input_set_dgv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.input_set_cbox);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 286);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input set";
            // 
            // btn_input_set_dir
            // 
            this.btn_input_set_dir.Location = new System.Drawing.Point(323, 15);
            this.btn_input_set_dir.Name = "btn_input_set_dir";
            this.btn_input_set_dir.Size = new System.Drawing.Size(96, 23);
            this.btn_input_set_dir.TabIndex = 4;
            this.btn_input_set_dir.Text = "Open in Explorer";
            this.btn_input_set_dir.UseVisualStyleBackColor = true;
            // 
            // edit_input_set_btn
            // 
            this.edit_input_set_btn.Location = new System.Drawing.Point(121, 257);
            this.edit_input_set_btn.Name = "edit_input_set_btn";
            this.edit_input_set_btn.Size = new System.Drawing.Size(50, 23);
            this.edit_input_set_btn.TabIndex = 3;
            this.edit_input_set_btn.Text = "Edit";
            this.edit_input_set_btn.UseVisualStyleBackColor = true;
            // 
            // delete_input_set_btn
            // 
            this.delete_input_set_btn.Location = new System.Drawing.Point(65, 257);
            this.delete_input_set_btn.Name = "delete_input_set_btn";
            this.delete_input_set_btn.Size = new System.Drawing.Size(50, 23);
            this.delete_input_set_btn.TabIndex = 3;
            this.delete_input_set_btn.Text = "Delete";
            this.delete_input_set_btn.UseVisualStyleBackColor = true;
            // 
            // new_input_set_btn
            // 
            this.new_input_set_btn.Location = new System.Drawing.Point(9, 257);
            this.new_input_set_btn.Name = "new_input_set_btn";
            this.new_input_set_btn.Size = new System.Drawing.Size(50, 23);
            this.new_input_set_btn.TabIndex = 3;
            this.new_input_set_btn.Text = "New";
            this.new_input_set_btn.UseVisualStyleBackColor = true;
            this.new_input_set_btn.Click += new System.EventHandler(this.new_input_set_btn_Click);
            // 
            // input_set_dgv
            // 
            this.input_set_dgv.AllowUserToAddRows = false;
            this.input_set_dgv.AllowUserToDeleteRows = false;
            this.input_set_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input_set_dgv.Location = new System.Drawing.Point(9, 43);
            this.input_set_dgv.Name = "input_set_dgv";
            this.input_set_dgv.ReadOnly = true;
            this.input_set_dgv.Size = new System.Drawing.Size(410, 208);
            this.input_set_dgv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input set";
            // 
            // input_set_cbox
            // 
            this.input_set_cbox.FormattingEnabled = true;
            this.input_set_cbox.Location = new System.Drawing.Point(60, 16);
            this.input_set_cbox.Name = "input_set_cbox";
            this.input_set_cbox.Size = new System.Drawing.Size(255, 21);
            this.input_set_cbox.TabIndex = 0;
            this.input_set_cbox.SelectedIndexChanged += new System.EventHandler(this.input_set_cbox_SelectedIndexChanged);
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(16, 367);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(100, 23);
            this.btn_detect.TabIndex = 1;
            this.btn_detect.Text = "Start detection";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // btn_simulate
            // 
            this.btn_simulate.Location = new System.Drawing.Point(120, 367);
            this.btn_simulate.Name = "btn_simulate";
            this.btn_simulate.Size = new System.Drawing.Size(100, 23);
            this.btn_simulate.TabIndex = 1;
            this.btn_simulate.Text = "Simulate input";
            this.btn_simulate.UseVisualStyleBackColor = true;
            this.btn_simulate.Click += new System.EventHandler(this.simulate_btn_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(741, 367);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // skip_result_checkbox
            // 
            this.skip_result_checkbox.AutoSize = true;
            this.skip_result_checkbox.Location = new System.Drawing.Point(16, 345);
            this.skip_result_checkbox.Name = "skip_result_checkbox";
            this.skip_result_checkbox.Size = new System.Drawing.Size(218, 17);
            this.skip_result_checkbox.TabIndex = 2;
            this.skip_result_checkbox.Text = "Simulate without detection result preview";
            this.skip_result_checkbox.UseVisualStyleBackColor = true;
            // 
            // btn_data_set_config
            // 
            this.btn_data_set_config.Location = new System.Drawing.Point(226, 367);
            this.btn_data_set_config.Name = "btn_data_set_config";
            this.btn_data_set_config.Size = new System.Drawing.Size(149, 23);
            this.btn_data_set_config.TabIndex = 1;
            this.btn_data_set_config.Text = "Configure Data sets";
            this.btn_data_set_config.UseVisualStyleBackColor = true;
            this.btn_data_set_config.Click += new System.EventHandler(this.btn_data_set_config_Click);
            // 
            // btn_python_path
            // 
            this.btn_python_path.Location = new System.Drawing.Point(557, 367);
            this.btn_python_path.Name = "btn_python_path";
            this.btn_python_path.Size = new System.Drawing.Size(178, 23);
            this.btn_python_path.TabIndex = 3;
            this.btn_python_path.Text = "Setup Python environment";
            this.btn_python_path.UseVisualStyleBackColor = true;
            this.btn_python_path.Click += new System.EventHandler(this.btn_python_path_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 402);
            this.Controls.Add(this.btn_python_path);
            this.Controls.Add(this.skip_result_checkbox);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_data_set_config);
            this.Controls.Add(this.btn_simulate);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.tab_control);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODWai 2.0";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tab_control.ResumeLayout(false);
            this.testing_tab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.config_tab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_set_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage testing_tab;
        private System.Windows.Forms.TabPage config_tab;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.Button btn_simulate;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.CheckBox skip_result_checkbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox input_set_cbox;
        private System.Windows.Forms.Button edit_input_set_btn;
        private System.Windows.Forms.Button delete_input_set_btn;
        private System.Windows.Forms.Button new_input_set_btn;
        private System.Windows.Forms.DataGridView input_set_dgv;
        private System.Windows.Forms.Button btn_data_set_config;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_region_capture;
        private System.Windows.Forms.TextBox tb_root_x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_root_y;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_input_set_dir;
        private System.Windows.Forms.Button btn_python_path;
    }
}

