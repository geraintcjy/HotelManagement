﻿using System.Data.SqlClient;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomInfo));
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(421, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按房型查找ToolStripMenuItem,
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 25);
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
            this.按房型查找ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.按房型查找ToolStripMenuItem.Text = "按房型查找";
            // 
            // 单人间ToolStripMenuItem
            // 
            this.单人间ToolStripMenuItem.Name = "单人间ToolStripMenuItem";
            this.单人间ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.单人间ToolStripMenuItem.Text = "单人间";
            this.单人间ToolStripMenuItem.Click += new System.EventHandler(this.单人间ToolStripMenuItem_Click);
            // 
            // 双人间ToolStripMenuItem
            // 
            this.双人间ToolStripMenuItem.Name = "双人间ToolStripMenuItem";
            this.双人间ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.双人间ToolStripMenuItem.Text = "双人间";
            this.双人间ToolStripMenuItem.Click += new System.EventHandler(this.双人间ToolStripMenuItem_Click);
            // 
            // 大床房ToolStripMenuItem
            // 
            this.大床房ToolStripMenuItem.Name = "大床房ToolStripMenuItem";
            this.大床房ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.大床房ToolStripMenuItem.Text = "大床房";
            this.大床房ToolStripMenuItem.Click += new System.EventHandler(this.大床房ToolStripMenuItem_Click);
            // 
            // 亲子房ToolStripMenuItem
            // 
            this.亲子房ToolStripMenuItem.Name = "亲子房ToolStripMenuItem";
            this.亲子房ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.亲子房ToolStripMenuItem.Text = "亲子房";
            this.亲子房ToolStripMenuItem.Click += new System.EventHandler(this.亲子房ToolStripMenuItem_Click);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // roomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "roomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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