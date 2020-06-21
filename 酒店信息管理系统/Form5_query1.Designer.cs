namespace 酒店信息管理系统
{
    partial class Form5_query1
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
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.radioButton_date = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ok = new System.Windows.Forms.Button();
            this.radioButton_id = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_dnum = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_name.Location = new System.Drawing.Point(50, 63);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(86, 21);
            this.radioButton_name.TabIndex = 0;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.Text = "按姓名查询";
            this.radioButton_name.UseVisualStyleBackColor = true;
            // 
            // radioButton_date
            // 
            this.radioButton_date.AutoSize = true;
            this.radioButton_date.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_date.Location = new System.Drawing.Point(353, 42);
            this.radioButton_date.Name = "radioButton_date";
            this.radioButton_date.Size = new System.Drawing.Size(110, 21);
            this.radioButton_date.TabIndex = 1;
            this.radioButton_date.TabStop = true;
            this.radioButton_date.Text = "按入住日期查询";
            this.radioButton_date.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(142, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(553, 207);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.Transparent;
            this.button_ok.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.Location = new System.Drawing.Point(515, 42);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(72, 50);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "查询";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_id
            // 
            this.radioButton_id.AutoSize = true;
            this.radioButton_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_id.Location = new System.Drawing.Point(50, 36);
            this.radioButton_id.Name = "radioButton_id";
            this.radioButton_id.Size = new System.Drawing.Size(98, 21);
            this.radioButton_id.TabIndex = 6;
            this.radioButton_id.TabStop = true;
            this.radioButton_id.Text = "身份证号查询";
            this.radioButton_id.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton_dnum);
            this.groupBox1.Controls.Add(this.radioButton_id);
            this.groupBox1.Controls.Add(this.radioButton_name);
            this.groupBox1.Controls.Add(this.radioButton_date);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, -3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(633, 364);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_dnum
            // 
            this.radioButton_dnum.AutoSize = true;
            this.radioButton_dnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_dnum.Location = new System.Drawing.Point(50, 90);
            this.radioButton_dnum.Name = "radioButton_dnum";
            this.radioButton_dnum.Size = new System.Drawing.Size(86, 21);
            this.radioButton_dnum.TabIndex = 7;
            this.radioButton_dnum.TabStop = true;
            this.radioButton_dnum.Text = "订单号查询";
            this.radioButton_dnum.UseVisualStyleBackColor = true;
            // 
            // Form5_query1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::酒店信息管理系统.Properties.Resources.small4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5_query1";
            this.Text = "入住记录";
            this.Load += new System.EventHandler(this.Form5_query1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.RadioButton radioButton_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.RadioButton radioButton_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_dnum;
    }
}