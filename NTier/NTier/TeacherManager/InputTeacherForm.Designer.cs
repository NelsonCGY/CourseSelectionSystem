namespace NTier.TeacherManager
{
    partial class InputTeacherForm
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
            this.lvNewTeacher = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNewDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNewSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewWorkerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewWorkerNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNewTeacher
            // 
            this.lvNewTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvNewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvNewTeacher.FullRowSelect = true;
            this.lvNewTeacher.GridLines = true;
            this.lvNewTeacher.Location = new System.Drawing.Point(12, 175);
            this.lvNewTeacher.MultiSelect = false;
            this.lvNewTeacher.Name = "lvNewTeacher";
            this.lvNewTeacher.Size = new System.Drawing.Size(508, 177);
            this.lvNewTeacher.TabIndex = 14;
            this.lvNewTeacher.UseCompatibleStateImageBehavior = false;
            this.lvNewTeacher.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "工号";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "姓名";
            this.columnHeader6.Width = 119;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "性别";
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "院系";
            this.columnHeader8.Width = 202;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "新增教师信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbNewDepartment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbNewSex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNewWorkerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNewWorkerNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新教师";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNewDepartment
            // 
            this.cbNewDepartment.FormattingEnabled = true;
            this.cbNewDepartment.Items.AddRange(new object[] {
            "理学部",
            "外语国学院",
            "土木学院",
            "经管学院",
            "电信学院",
            "生命科学"});
            this.cbNewDepartment.Location = new System.Drawing.Point(249, 79);
            this.cbNewDepartment.Name = "cbNewDepartment";
            this.cbNewDepartment.Size = new System.Drawing.Size(122, 20);
            this.cbNewDepartment.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "院系";
            // 
            // cbNewSex
            // 
            this.cbNewSex.FormattingEnabled = true;
            this.cbNewSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbNewSex.Location = new System.Drawing.Point(72, 76);
            this.cbNewSex.Name = "cbNewSex";
            this.cbNewSex.Size = new System.Drawing.Size(100, 20);
            this.cbNewSex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别 ";
            // 
            // tbNewWorkerName
            // 
            this.tbNewWorkerName.Location = new System.Drawing.Point(249, 33);
            this.tbNewWorkerName.Name = "tbNewWorkerName";
            this.tbNewWorkerName.Size = new System.Drawing.Size(122, 21);
            this.tbNewWorkerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // tbNewWorkerNo
            // 
            this.tbNewWorkerNo.Location = new System.Drawing.Point(72, 33);
            this.tbNewWorkerNo.Name = "tbNewWorkerNo";
            this.tbNewWorkerNo.Size = new System.Drawing.Size(100, 21);
            this.tbNewWorkerNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            // 
            // InputTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 370);
            this.Controls.Add(this.lvNewTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputTeacherForm";
            this.Text = "添加教师";
            this.Load += new System.EventHandler(this.InputTeacherForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNewTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbNewDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNewSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewWorkerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewWorkerNo;
        private System.Windows.Forms.Label label1;
    }
}