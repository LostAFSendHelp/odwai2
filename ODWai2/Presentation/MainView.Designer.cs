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
            this.dgv_detection_result = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_image_result = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_region_capture = new System.Windows.Forms.Button();
            this.tb_root_x = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_data_set_config = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_graph_name = new System.Windows.Forms.TextBox();
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
            this.chbox_all = new System.Windows.Forms.CheckBox();
            this.chbox_valid = new System.Windows.Forms.CheckBox();
            this.chbox_randomize = new System.Windows.Forms.CheckBox();
            this.chbox_edge = new System.Windows.Forms.CheckBox();
            this.chbox_custom = new System.Windows.Forms.CheckBox();
            this.chbox_error = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_input_set_dir = new System.Windows.Forms.Button();
            this.delete_input_set_btn = new System.Windows.Forms.Button();
            this.new_input_set_btn = new System.Windows.Forms.Button();
            this.input_set_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_input_set = new System.Windows.Forms.ComboBox();
            this.btn_detect = new System.Windows.Forms.Button();
            this.btn_simulate = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.skip_result_checkbox = new System.Windows.Forms.CheckBox();
            this.btn_python_path = new System.Windows.Forms.Button();
            this.btn_error_log = new System.Windows.Forms.Button();
            this.tab_control.SuspendLayout();
            this.testing_tab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detection_result)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_result)).BeginInit();
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
            this.groupBox4.Controls.Add(this.dgv_detection_result);
            this.groupBox4.Location = new System.Drawing.Point(579, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 289);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detection result";
            // 
            // dgv_detection_result
            // 
            this.dgv_detection_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detection_result.Location = new System.Drawing.Point(6, 19);
            this.dgv_detection_result.Name = "dgv_detection_result";
            this.dgv_detection_result.Size = new System.Drawing.Size(203, 264);
            this.dgv_detection_result.TabIndex = 0;
            this.dgv_detection_result.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detection_result_CellClick);
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
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pb_image_result);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 264);
            this.panel1.TabIndex = 0;
            // 
            // pb_image_result
            // 
            this.pb_image_result.Location = new System.Drawing.Point(3, 3);
            this.pb_image_result.Name = "pb_image_result";
            this.pb_image_result.Size = new System.Drawing.Size(268, 221);
            this.pb_image_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_image_result.TabIndex = 0;
            this.pb_image_result.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_region_capture);
            this.groupBox1.Controls.Add(this.tb_root_x);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_data_set_config);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_graph_name);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Graph";
            // 
            // btn_data_set_config
            // 
            this.btn_data_set_config.Location = new System.Drawing.Point(6, 231);
            this.btn_data_set_config.Name = "btn_data_set_config";
            this.btn_data_set_config.Size = new System.Drawing.Size(200, 23);
            this.btn_data_set_config.TabIndex = 1;
            this.btn_data_set_config.Text = "Configure Data sets";
            this.btn_data_set_config.UseVisualStyleBackColor = true;
            this.btn_data_set_config.Click += new System.EventHandler(this.btn_data_set_config_Click);
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
            // tb_graph_name
            // 
            this.tb_graph_name.Enabled = false;
            this.tb_graph_name.Location = new System.Drawing.Point(63, 166);
            this.tb_graph_name.Name = "tb_graph_name";
            this.tb_graph_name.Size = new System.Drawing.Size(135, 20);
            this.tb_graph_name.TabIndex = 1;
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
            this.groupBox5.Controls.Add(this.chbox_all);
            this.groupBox5.Controls.Add(this.chbox_valid);
            this.groupBox5.Controls.Add(this.chbox_randomize);
            this.groupBox5.Controls.Add(this.chbox_edge);
            this.groupBox5.Controls.Add(this.chbox_custom);
            this.groupBox5.Controls.Add(this.chbox_error);
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
            // chbox_all
            // 
            this.chbox_all.AutoSize = true;
            this.chbox_all.Location = new System.Drawing.Point(21, 197);
            this.chbox_all.Name = "chbox_all";
            this.chbox_all.Size = new System.Drawing.Size(68, 17);
            this.chbox_all.TabIndex = 0;
            this.chbox_all.Text = "All inputs";
            this.chbox_all.UseVisualStyleBackColor = true;
            // 
            // chbox_valid
            // 
            this.chbox_valid.AutoSize = true;
            this.chbox_valid.Location = new System.Drawing.Point(21, 100);
            this.chbox_valid.Name = "chbox_valid";
            this.chbox_valid.Size = new System.Drawing.Size(80, 17);
            this.chbox_valid.TabIndex = 0;
            this.chbox_valid.Text = "Valid inputs";
            this.chbox_valid.UseVisualStyleBackColor = true;
            // 
            // chbox_randomize
            // 
            this.chbox_randomize.AutoSize = true;
            this.chbox_randomize.Location = new System.Drawing.Point(21, 165);
            this.chbox_randomize.Name = "chbox_randomize";
            this.chbox_randomize.Size = new System.Drawing.Size(144, 17);
            this.chbox_randomize.TabIndex = 0;
            this.chbox_randomize.Text = "Auto-fill unidentified fields";
            this.chbox_randomize.UseVisualStyleBackColor = true;
            // 
            // chbox_edge
            // 
            this.chbox_edge.AutoSize = true;
            this.chbox_edge.Location = new System.Drawing.Point(21, 66);
            this.chbox_edge.Name = "chbox_edge";
            this.chbox_edge.Size = new System.Drawing.Size(112, 17);
            this.chbox_edge.TabIndex = 0;
            this.chbox_edge.Text = "Edge inputs (WIP)";
            this.chbox_edge.UseVisualStyleBackColor = true;
            // 
            // chbox_custom
            // 
            this.chbox_custom.AutoSize = true;
            this.chbox_custom.Location = new System.Drawing.Point(21, 133);
            this.chbox_custom.Name = "chbox_custom";
            this.chbox_custom.Size = new System.Drawing.Size(122, 17);
            this.chbox_custom.TabIndex = 0;
            this.chbox_custom.Text = "Custom inputs (WIP)";
            this.chbox_custom.UseVisualStyleBackColor = true;
            // 
            // chbox_error
            // 
            this.chbox_error.AutoSize = true;
            this.chbox_error.Location = new System.Drawing.Point(21, 33);
            this.chbox_error.Name = "chbox_error";
            this.chbox_error.Size = new System.Drawing.Size(74, 17);
            this.chbox_error.TabIndex = 0;
            this.chbox_error.Text = "Error input";
            this.chbox_error.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Controls.Add(this.btn_input_set_dir);
            this.groupBox2.Controls.Add(this.delete_input_set_btn);
            this.groupBox2.Controls.Add(this.new_input_set_btn);
            this.groupBox2.Controls.Add(this.input_set_dgv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbox_input_set);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 286);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input set";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Image = global::ODWai2.Properties.Resources.rsz_images;
            this.btn_refresh.Location = new System.Drawing.Point(287, 15);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 23);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            // delete_input_set_btn
            // 
            this.delete_input_set_btn.Location = new System.Drawing.Point(65, 257);
            this.delete_input_set_btn.Name = "delete_input_set_btn";
            this.delete_input_set_btn.Size = new System.Drawing.Size(50, 23);
            this.delete_input_set_btn.TabIndex = 3;
            this.delete_input_set_btn.Text = "Delete";
            this.delete_input_set_btn.UseVisualStyleBackColor = true;
            this.delete_input_set_btn.Click += new System.EventHandler(this.delete_input_set_btn_Click);
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
            // cbox_input_set
            // 
            this.cbox_input_set.FormattingEnabled = true;
            this.cbox_input_set.Location = new System.Drawing.Point(60, 16);
            this.cbox_input_set.Name = "cbox_input_set";
            this.cbox_input_set.Size = new System.Drawing.Size(220, 21);
            this.cbox_input_set.TabIndex = 0;
            this.cbox_input_set.SelectedValueChanged += new System.EventHandler(this.cbox_input_set_SelectedValueChanged);
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
            // btn_error_log
            // 
            this.btn_error_log.Location = new System.Drawing.Point(373, 367);
            this.btn_error_log.Name = "btn_error_log";
            this.btn_error_log.Size = new System.Drawing.Size(178, 23);
            this.btn_error_log.TabIndex = 4;
            this.btn_error_log.Text = "Open error logs";
            this.btn_error_log.UseVisualStyleBackColor = true;
            this.btn_error_log.Click += new System.EventHandler(this.btn_error_log_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 402);
            this.Controls.Add(this.btn_error_log);
            this.Controls.Add(this.btn_python_path);
            this.Controls.Add(this.skip_result_checkbox);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_simulate);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.tab_control);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODWai 2.0";
            this.tab_control.ResumeLayout(false);
            this.testing_tab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detection_result)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_result)).EndInit();
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
        private System.Windows.Forms.ComboBox cbox_input_set;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_detection_result;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbox_all;
        private System.Windows.Forms.CheckBox chbox_valid;
        private System.Windows.Forms.CheckBox chbox_randomize;
        private System.Windows.Forms.CheckBox chbox_edge;
        private System.Windows.Forms.CheckBox chbox_custom;
        private System.Windows.Forms.CheckBox chbox_error;
        private System.Windows.Forms.Button btn_input_set_dir;
        private System.Windows.Forms.Button btn_python_path;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_graph_name;
        private System.Windows.Forms.PictureBox pb_image_result;
        private System.Windows.Forms.Button btn_error_log;
        private System.Windows.Forms.Button btn_refresh;
    }
}

