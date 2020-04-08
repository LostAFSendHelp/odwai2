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
            this.config_tab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.tab_control.SuspendLayout();
            this.config_tab.SuspendLayout();
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
            this.testing_tab.Location = new System.Drawing.Point(4, 22);
            this.testing_tab.Name = "testing_tab";
            this.testing_tab.Padding = new System.Windows.Forms.Padding(3);
            this.testing_tab.Size = new System.Drawing.Size(800, 301);
            this.testing_tab.TabIndex = 0;
            this.testing_tab.Text = "Testing";
            this.testing_tab.UseVisualStyleBackColor = true;
            // 
            // config_tab
            // 
            this.config_tab.Controls.Add(this.groupBox2);
            this.config_tab.Location = new System.Drawing.Point(4, 22);
            this.config_tab.Name = "config_tab";
            this.config_tab.Padding = new System.Windows.Forms.Padding(3);
            this.config_tab.Size = new System.Drawing.Size(800, 301);
            this.config_tab.TabIndex = 1;
            this.config_tab.Text = "Configs";
            this.config_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edit_input_set_btn);
            this.groupBox2.Controls.Add(this.delete_input_set_btn);
            this.groupBox2.Controls.Add(this.new_input_set_btn);
            this.groupBox2.Controls.Add(this.input_set_dgv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.input_set_cbox);
            this.groupBox2.Location = new System.Drawing.Point(550, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 286);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input set";
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
            // 
            // input_set_dgv
            // 
            this.input_set_dgv.AllowUserToAddRows = false;
            this.input_set_dgv.AllowUserToDeleteRows = false;
            this.input_set_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input_set_dgv.Location = new System.Drawing.Point(9, 74);
            this.input_set_dgv.Name = "input_set_dgv";
            this.input_set_dgv.ReadOnly = true;
            this.input_set_dgv.Size = new System.Drawing.Size(229, 177);
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
            this.input_set_cbox.Location = new System.Drawing.Point(117, 16);
            this.input_set_cbox.Name = "input_set_cbox";
            this.input_set_cbox.Size = new System.Drawing.Size(121, 21);
            this.input_set_cbox.TabIndex = 0;
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
            this.btn_data_set_config.Location = new System.Drawing.Point(271, 367);
            this.btn_data_set_config.Name = "btn_data_set_config";
            this.btn_data_set_config.Size = new System.Drawing.Size(149, 23);
            this.btn_data_set_config.TabIndex = 1;
            this.btn_data_set_config.Text = "Configure Data sets";
            this.btn_data_set_config.UseVisualStyleBackColor = true;
            this.btn_data_set_config.Click += new System.EventHandler(this.btn_data_set_config_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 402);
            this.Controls.Add(this.skip_result_checkbox);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_data_set_config);
            this.Controls.Add(this.btn_simulate);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.tab_control);
            this.Name = "MainView";
            this.Text = "ODWai 2.0";
            this.tab_control.ResumeLayout(false);
            this.config_tab.ResumeLayout(false);
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
    }
}

