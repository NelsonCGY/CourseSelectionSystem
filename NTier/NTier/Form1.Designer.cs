﻿namespace NTier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.角色权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限分配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新教师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.已开设课程查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.角色权限管理ToolStripMenuItem,
            this.学生管理ToolStripMenuItem,
            this.教师管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(705, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 角色权限管理ToolStripMenuItem
            // 
            this.角色权限管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.角色管理ToolStripMenuItem,
            this.权限管理ToolStripMenuItem,
            this.权限分配ToolStripMenuItem});
            this.角色权限管理ToolStripMenuItem.Name = "角色权限管理ToolStripMenuItem";
            this.角色权限管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.角色权限管理ToolStripMenuItem.Text = "角色权限管理";
            // 
            // 角色管理ToolStripMenuItem
            // 
            this.角色管理ToolStripMenuItem.Name = "角色管理ToolStripMenuItem";
            this.角色管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.角色管理ToolStripMenuItem.Text = "角色管理";
            this.角色管理ToolStripMenuItem.Click += new System.EventHandler(this.角色管理ToolStripMenuItem_Click);
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            // 
            // 权限分配ToolStripMenuItem
            // 
            this.权限分配ToolStripMenuItem.Name = "权限分配ToolStripMenuItem";
            this.权限分配ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.权限分配ToolStripMenuItem.Text = "权限分配";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新学生ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.查询ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 添加新学生ToolStripMenuItem
            // 
            this.添加新学生ToolStripMenuItem.Name = "添加新学生ToolStripMenuItem";
            this.添加新学生ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加新学生ToolStripMenuItem.Text = "添加新学生";
            this.添加新学生ToolStripMenuItem.Click += new System.EventHandler(this.添加新学生ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 教师管理ToolStripMenuItem
            // 
            this.教师管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新教师ToolStripMenuItem,
            this.修改ToolStripMenuItem1,
            this.查询ToolStripMenuItem1});
            this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
            this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.教师管理ToolStripMenuItem.Text = "教师管理";
            // 
            // 添加新教师ToolStripMenuItem
            // 
            this.添加新教师ToolStripMenuItem.Name = "添加新教师ToolStripMenuItem";
            this.添加新教师ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加新教师ToolStripMenuItem.Text = "添加新教师";
            this.添加新教师ToolStripMenuItem.Click += new System.EventHandler(this.添加新教师ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem1
            // 
            this.修改ToolStripMenuItem1.Name = "修改ToolStripMenuItem1";
            this.修改ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.修改ToolStripMenuItem1.Text = "修改";
            this.修改ToolStripMenuItem1.Click += new System.EventHandler(this.修改ToolStripMenuItem1_Click);
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.查询ToolStripMenuItem1.Text = "查询";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.查询ToolStripMenuItem1_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新课程ToolStripMenuItem,
            this.修改ToolStripMenuItem2,
            this.查询ToolStripMenuItem2,
            this.已开设课程查询ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 添加新课程ToolStripMenuItem
            // 
            this.添加新课程ToolStripMenuItem.Name = "添加新课程ToolStripMenuItem";
            this.添加新课程ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加新课程ToolStripMenuItem.Text = "创建课程";
            this.添加新课程ToolStripMenuItem.Click += new System.EventHandler(this.添加新课程ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem2
            // 
            this.修改ToolStripMenuItem2.Name = "修改ToolStripMenuItem2";
            this.修改ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.修改ToolStripMenuItem2.Text = "修改";
            this.修改ToolStripMenuItem2.Click += new System.EventHandler(this.修改ToolStripMenuItem2_Click);
            // 
            // 查询ToolStripMenuItem2
            // 
            this.查询ToolStripMenuItem2.Name = "查询ToolStripMenuItem2";
            this.查询ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.查询ToolStripMenuItem2.Text = "开课查询";
            this.查询ToolStripMenuItem2.Click += new System.EventHandler(this.查询ToolStripMenuItem2_Click);
            // 
            // 已开设课程查询ToolStripMenuItem
            // 
            this.已开设课程查询ToolStripMenuItem.Name = "已开设课程查询ToolStripMenuItem";
            this.已开设课程查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.已开设课程查询ToolStripMenuItem.Text = "已开课程查询";
            this.已开设课程查询ToolStripMenuItem.Click += new System.EventHandler(this.已开设课程查询ToolStripMenuItem_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新成绩ToolStripMenuItem,
            this.修改ToolStripMenuItem3,
            this.查询ToolStripMenuItem3,
            this.统计ToolStripMenuItem});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 添加新成绩ToolStripMenuItem
            // 
            this.添加新成绩ToolStripMenuItem.Name = "添加新成绩ToolStripMenuItem";
            this.添加新成绩ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加新成绩ToolStripMenuItem.Text = "添加新成绩";
            this.添加新成绩ToolStripMenuItem.Click += new System.EventHandler(this.添加新成绩ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem3
            // 
            this.修改ToolStripMenuItem3.Name = "修改ToolStripMenuItem3";
            this.修改ToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.修改ToolStripMenuItem3.Text = "修改";
            this.修改ToolStripMenuItem3.Click += new System.EventHandler(this.修改ToolStripMenuItem3_Click);
            // 
            // 查询ToolStripMenuItem3
            // 
            this.查询ToolStripMenuItem3.Name = "查询ToolStripMenuItem3";
            this.查询ToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.查询ToolStripMenuItem3.Text = "查询";
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=NELSONC-PC;Integrated Security=SSPI;Initial Catalo" +
    "g=Ntier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 554);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NTier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 角色权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限分配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新教师ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已开设课程查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
    }
}

