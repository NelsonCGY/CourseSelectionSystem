namespace NTier.TeacherManager
{
    partial class SearchTeacherForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lvSearchTeacher = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearchWorkerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchWorkerNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.lvSelectCourse = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(12, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "该教师课程列表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "查询结果列表";
            // 
            // lvSearchTeacher
            // 
            this.lvSearchTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvSearchTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSearchTeacher.FullRowSelect = true;
            this.lvSearchTeacher.GridLines = true;
            this.lvSearchTeacher.Location = new System.Drawing.Point(12, 102);
            this.lvSearchTeacher.MultiSelect = false;
            this.lvSearchTeacher.Name = "lvSearchTeacher";
            this.lvSearchTeacher.Size = new System.Drawing.Size(480, 141);
            this.lvSearchTeacher.TabIndex = 14;
            this.lvSearchTeacher.UseCompatibleStateImageBehavior = false;
            this.lvSearchTeacher.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "工号";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "院系";
            this.columnHeader4.Width = 202;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbSearchWorkerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSearchWorkerNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSearchWorkerName
            // 
            this.tbSearchWorkerName.Location = new System.Drawing.Point(222, 23);
            this.tbSearchWorkerName.Name = "tbSearchWorkerName";
            this.tbSearchWorkerName.Size = new System.Drawing.Size(100, 21);
            this.tbSearchWorkerName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名";
            // 
            // tbSearchWorkerNo
            // 
            this.tbSearchWorkerNo.Location = new System.Drawing.Point(60, 23);
            this.tbSearchWorkerNo.Name = "tbSearchWorkerNo";
            this.tbSearchWorkerNo.Size = new System.Drawing.Size(100, 21);
            this.tbSearchWorkerNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "工号";
            // 
            // tbTeacher
            // 
            this.tbTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTeacher.Location = new System.Drawing.Point(12, 297);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.ReadOnly = true;
            this.tbTeacher.Size = new System.Drawing.Size(139, 21);
            this.tbTeacher.TabIndex = 18;
            // 
            // lvSelectCourse
            // 
            this.lvSelectCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvSelectCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvSelectCourse.FullRowSelect = true;
            this.lvSelectCourse.GridLines = true;
            this.lvSelectCourse.Location = new System.Drawing.Point(12, 324);
            this.lvSelectCourse.MultiSelect = false;
            this.lvSelectCourse.Name = "lvSelectCourse";
            this.lvSelectCourse.Size = new System.Drawing.Size(480, 91);
            this.lvSelectCourse.TabIndex = 17;
            this.lvSelectCourse.UseCompatibleStateImageBehavior = false;
            this.lvSelectCourse.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "班号";
            this.columnHeader12.Width = 118;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "课程名称";
            this.columnHeader13.Width = 212;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "选课人数";
            this.columnHeader14.Width = 144;
            // 
            // SearchTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 285);
            this.Controls.Add(this.tbTeacher);
            this.Controls.Add(this.lvSelectCourse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvSearchTeacher);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchTeacherForm";
            this.Text = "查询教师";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvSearchTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearchWorkerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchWorkerNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.ListView lvSelectCourse;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}