namespace ODWai2.Misc
{
    partial class NewInputSetView
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
            this.pnl_right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete_field = new System.Windows.Forms.Button();
            this.btn_new_field = new System.Windows.Forms.Button();
            this.txt_numberField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.pnl_down = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.txt_errorInput_1 = new System.Windows.Forms.TextBox();
            this.txt_sampleInput_1 = new System.Windows.Forms.TextBox();
            this.lb_error = new System.Windows.Forms.Label();
            this.txt_associated_1 = new System.Windows.Forms.TextBox();
            this.txt_field_1 = new System.Windows.Forms.TextBox();
            this.lb_field1 = new System.Windows.Forms.Label();
            this.lb_input1 = new System.Windows.Forms.Label();
            this.lb_associal1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.pnl_right.SuspendLayout();
            this.pnl_down.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_right.Controls.Add(this.label2);
            this.pnl_right.Controls.Add(this.btn_delete_field);
            this.pnl_right.Controls.Add(this.btn_new_field);
            this.pnl_right.Controls.Add(this.txt_numberField);
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(701, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(99, 441);
            this.pnl_right.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of \r\nthe Fields :";
            // 
            // btn_delete_field
            // 
            this.btn_delete_field.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete_field.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_field.Location = new System.Drawing.Point(12, 223);
            this.btn_delete_field.Name = "btn_delete_field";
            this.btn_delete_field.Size = new System.Drawing.Size(75, 59);
            this.btn_delete_field.TabIndex = 2;
            this.btn_delete_field.Text = "Delete Field";
            this.btn_delete_field.UseVisualStyleBackColor = false;
            // 
            // btn_new_field
            // 
            this.btn_new_field.BackColor = System.Drawing.Color.LightGreen;
            this.btn_new_field.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_field.Location = new System.Drawing.Point(12, 124);
            this.btn_new_field.Name = "btn_new_field";
            this.btn_new_field.Size = new System.Drawing.Size(75, 59);
            this.btn_new_field.TabIndex = 1;
            this.btn_new_field.Text = "New Field";
            this.btn_new_field.UseVisualStyleBackColor = false;
            this.btn_new_field.Click += new System.EventHandler(this.btn_new_field_Click);
            // 
            // txt_numberField
            // 
            this.txt_numberField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberField.Location = new System.Drawing.Point(12, 57);
            this.txt_numberField.Name = "txt_numberField";
            this.txt_numberField.Size = new System.Drawing.Size(73, 26);
            this.txt_numberField.TabIndex = 1;
            this.txt_numberField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "Path :";
            // 
            // txt_Path
            // 
            this.txt_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Path.Location = new System.Drawing.Point(153, 53);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(370, 26);
            this.txt_Path.TabIndex = 105;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(670, 47);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 34);
            this.btn_save.TabIndex = 104;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(550, 47);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(91, 34);
            this.btn_browse.TabIndex = 103;
            this.btn_browse.Text = "BROWSE";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // pnl_down
            // 
            this.pnl_down.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_down.Controls.Add(this.txt_fileName);
            this.pnl_down.Controls.Add(this.label3);
            this.pnl_down.Controls.Add(this.label1);
            this.pnl_down.Controls.Add(this.txt_Path);
            this.pnl_down.Controls.Add(this.btn_save);
            this.pnl_down.Controls.Add(this.btn_browse);
            this.pnl_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_down.Location = new System.Drawing.Point(0, 441);
            this.pnl_down.Name = "pnl_down";
            this.pnl_down.Size = new System.Drawing.Size(800, 93);
            this.pnl_down.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnl_1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(701, 441);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pnl_1
            // 
            this.pnl_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_1.BackColor = System.Drawing.Color.Azure;
            this.pnl_1.Controls.Add(this.txt_errorInput_1);
            this.pnl_1.Controls.Add(this.txt_sampleInput_1);
            this.pnl_1.Controls.Add(this.lb_error);
            this.pnl_1.Controls.Add(this.txt_associated_1);
            this.pnl_1.Controls.Add(this.txt_field_1);
            this.pnl_1.Controls.Add(this.lb_field1);
            this.pnl_1.Controls.Add(this.lb_input1);
            this.pnl_1.Controls.Add(this.lb_associal1);
            this.pnl_1.Location = new System.Drawing.Point(3, 3);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(698, 160);
            this.pnl_1.TabIndex = 0;
            // 
            // txt_errorInput_1
            // 
            this.txt_errorInput_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_errorInput_1.Location = new System.Drawing.Point(177, 121);
            this.txt_errorInput_1.Name = "txt_errorInput_1";
            this.txt_errorInput_1.Size = new System.Drawing.Size(497, 26);
            this.txt_errorInput_1.TabIndex = 91;
            // 
            // txt_sampleInput_1
            // 
            this.txt_sampleInput_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sampleInput_1.Location = new System.Drawing.Point(177, 82);
            this.txt_sampleInput_1.Name = "txt_sampleInput_1";
            this.txt_sampleInput_1.Size = new System.Drawing.Size(497, 26);
            this.txt_sampleInput_1.TabIndex = 90;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.Location = new System.Drawing.Point(40, 125);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(95, 19);
            this.lb_error.TabIndex = 89;
            this.lb_error.Text = "Error input : ";
            // 
            // txt_associated_1
            // 
            this.txt_associated_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_associated_1.Location = new System.Drawing.Point(177, 43);
            this.txt_associated_1.Name = "txt_associated_1";
            this.txt_associated_1.Size = new System.Drawing.Size(497, 26);
            this.txt_associated_1.TabIndex = 83;
            // 
            // txt_field_1
            // 
            this.txt_field_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_field_1.Location = new System.Drawing.Point(95, 9);
            this.txt_field_1.Name = "txt_field_1";
            this.txt_field_1.Size = new System.Drawing.Size(156, 26);
            this.txt_field_1.TabIndex = 82;
            // 
            // lb_field1
            // 
            this.lb_field1.BackColor = System.Drawing.Color.Azure;
            this.lb_field1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_field1.Location = new System.Drawing.Point(20, 16);
            this.lb_field1.Name = "lb_field1";
            this.lb_field1.Size = new System.Drawing.Size(69, 19);
            this.lb_field1.TabIndex = 81;
            this.lb_field1.Text = "Field :";
            // 
            // lb_input1
            // 
            this.lb_input1.AutoSize = true;
            this.lb_input1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input1.Location = new System.Drawing.Point(40, 86);
            this.lb_input1.Name = "lb_input1";
            this.lb_input1.Size = new System.Drawing.Size(108, 19);
            this.lb_input1.TabIndex = 80;
            this.lb_input1.Text = "Sample input : ";
            // 
            // lb_associal1
            // 
            this.lb_associal1.AutoSize = true;
            this.lb_associal1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_associal1.Location = new System.Drawing.Point(40, 50);
            this.lb_associal1.Name = "lb_associal1";
            this.lb_associal1.Size = new System.Drawing.Size(128, 19);
            this.lb_associal1.TabIndex = 79;
            this.lb_associal1.Text = "Associated texts :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "File Name :";
            // 
            // txt_fileName
            // 
            this.txt_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fileName.Location = new System.Drawing.Point(153, 12);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(203, 26);
            this.txt_fileName.TabIndex = 108;
            // 
            // NewInputSetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_down);
            this.Name = "NewInputSetView";
            this.Text = "NewInputSetView";
            this.pnl_right.ResumeLayout(false);
            this.pnl_right.PerformLayout();
            this.pnl_down.ResumeLayout(false);
            this.pnl_down.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnl_1;
        public System.Windows.Forms.Panel pnl_right;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Path;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_browse;
        public System.Windows.Forms.Panel pnl_down;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_delete_field;
        public System.Windows.Forms.Button btn_new_field;
        public System.Windows.Forms.TextBox txt_numberField;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TextBox txt_errorInput_1;
        public System.Windows.Forms.TextBox txt_sampleInput_1;
        public System.Windows.Forms.Label lb_error;
        public System.Windows.Forms.TextBox txt_associated_1;
        public System.Windows.Forms.TextBox txt_field_1;
        public System.Windows.Forms.Label lb_field1;
        public System.Windows.Forms.Label lb_input1;
        public System.Windows.Forms.Label lb_associal1;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Label label3;
    }
}