﻿namespace 酒店信息管理系统
{
    partial class Form_home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入住登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退房登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房态管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维修检修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.强制命令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账目查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入住记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.往期账目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客房设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 416);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "员工登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(12, 21);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.入住登记ToolStripMenuItem,
            this.退房登记ToolStripMenuItem,
            this.房态管理ToolStripMenuItem,
            this.账目查询ToolStripMenuItem,
            this.客房设置ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.首页ToolStripMenuItem.Text = "首页";
            this.首页ToolStripMenuItem.Click += new System.EventHandler(this.首页ToolStripMenuItem_Click);
            // 
            // 入住登记ToolStripMenuItem
            // 
            this.入住登记ToolStripMenuItem.Name = "入住登记ToolStripMenuItem";
            this.入住登记ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.入住登记ToolStripMenuItem.Text = "入住登记";
            this.入住登记ToolStripMenuItem.Click += new System.EventHandler(this.入住登记ToolStripMenuItem_Click);
            // 
            // 退房登记ToolStripMenuItem
            // 
            this.退房登记ToolStripMenuItem.Name = "退房登记ToolStripMenuItem";
            this.退房登记ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退房登记ToolStripMenuItem.Text = "退房登记";
            this.退房登记ToolStripMenuItem.Click += new System.EventHandler(this.退房登记ToolStripMenuItem_Click);
            // 
            // 房态管理ToolStripMenuItem
            // 
            this.房态管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维修检修ToolStripMenuItem,
            this.强制命令ToolStripMenuItem});
            this.房态管理ToolStripMenuItem.Name = "房态管理ToolStripMenuItem";
            this.房态管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.房态管理ToolStripMenuItem.Text = "房态管理";
            this.房态管理ToolStripMenuItem.Click += new System.EventHandler(this.房态管理ToolStripMenuItem_Click);
            // 
            // 维修检修ToolStripMenuItem
            // 
            this.维修检修ToolStripMenuItem.Name = "维修检修ToolStripMenuItem";
            this.维修检修ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.维修检修ToolStripMenuItem.Text = "房态还原";
            this.维修检修ToolStripMenuItem.Click += new System.EventHandler(this.维修检修ToolStripMenuItem_Click);
            // 
            // 强制命令ToolStripMenuItem
            // 
            this.强制命令ToolStripMenuItem.Name = "强制命令ToolStripMenuItem";
            this.强制命令ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.强制命令ToolStripMenuItem.Text = "状态更改";
            this.强制命令ToolStripMenuItem.Click += new System.EventHandler(this.强制命令ToolStripMenuItem_Click);
            // 
            // 账目查询ToolStripMenuItem
            // 
            this.账目查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入住记录ToolStripMenuItem,
            this.往期账目ToolStripMenuItem});
            this.账目查询ToolStripMenuItem.Name = "账目查询ToolStripMenuItem";
            this.账目查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.账目查询ToolStripMenuItem.Text = "信息查询";
            // 
            // 入住记录ToolStripMenuItem
            // 
            this.入住记录ToolStripMenuItem.Name = "入住记录ToolStripMenuItem";
            this.入住记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.入住记录ToolStripMenuItem.Text = "入住记录";
            this.入住记录ToolStripMenuItem.Click += new System.EventHandler(this.入住记录ToolStripMenuItem_Click);
            // 
            // 往期账目ToolStripMenuItem
            // 
            this.往期账目ToolStripMenuItem.Name = "往期账目ToolStripMenuItem";
            this.往期账目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.往期账目ToolStripMenuItem.Text = "往期账目";
            this.往期账目ToolStripMenuItem.Click += new System.EventHandler(this.往期账目ToolStripMenuItem_Click);
            // 
            // 客房设置ToolStripMenuItem
            // 
            this.客房设置ToolStripMenuItem.Name = "客房设置ToolStripMenuItem";
            this.客房设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客房设置ToolStripMenuItem.Text = "客房设置";
            this.客房设置ToolStripMenuItem.Click += new System.EventHandler(this.客房设置ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(542, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "您当前未登录";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "退出登录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_home";
            this.Text = "酒店信息管理系统";
            this.Load += new System.EventHandler(this.Form_home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入住登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退房登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房态管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账目查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入住记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 往期账目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客房设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维修检修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 强制命令ToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

