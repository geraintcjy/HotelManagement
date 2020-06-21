using System.Data.SqlClient;
namespace 酒店信息管理系统
{
    partial class roomInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.按房型查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单人间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.双人间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大床房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亲子房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按房型查找ToolStripMenuItem,
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(681, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 按房型查找ToolStripMenuItem
            // 
            this.按房型查找ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单人间ToolStripMenuItem,
            this.双人间ToolStripMenuItem,
            this.大床房ToolStripMenuItem,
            this.亲子房ToolStripMenuItem});
            this.按房型查找ToolStripMenuItem.Name = "按房型查找ToolStripMenuItem";
            this.按房型查找ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.按房型查找ToolStripMenuItem.Text = "按房型查找";
            this.按房型查找ToolStripMenuItem.Click += new System.EventHandler(this.按房型查找ToolStripMenuItem_Click);
            // 
            // 单人间ToolStripMenuItem
            // 
            this.单人间ToolStripMenuItem.Name = "单人间ToolStripMenuItem";
            this.单人间ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.单人间ToolStripMenuItem.Text = "单人间";
            this.单人间ToolStripMenuItem.Click += new System.EventHandler(this.单人间ToolStripMenuItem_Click);
            // 
            // 双人间ToolStripMenuItem
            // 
            this.双人间ToolStripMenuItem.Name = "双人间ToolStripMenuItem";
            this.双人间ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.双人间ToolStripMenuItem.Text = "双人间";
            this.双人间ToolStripMenuItem.Click += new System.EventHandler(this.双人间ToolStripMenuItem_Click);
            // 
            // 大床房ToolStripMenuItem
            // 
            this.大床房ToolStripMenuItem.Name = "大床房ToolStripMenuItem";
            this.大床房ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.大床房ToolStripMenuItem.Text = "大床房";
            this.大床房ToolStripMenuItem.Click += new System.EventHandler(this.大床房ToolStripMenuItem_Click);
            // 
            // 亲子房ToolStripMenuItem
            // 
            this.亲子房ToolStripMenuItem.Name = "亲子房ToolStripMenuItem";
            this.亲子房ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.亲子房ToolStripMenuItem.Text = "亲子房";
            this.亲子房ToolStripMenuItem.Click += new System.EventHandler(this.亲子房ToolStripMenuItem_Click);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // roomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "roomInfo";
            this.Text = "房间信息";
            this.Load += new System.EventHandler(this.roomInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 按房型查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单人间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 双人间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大床房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亲子房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
    }
}