namespace EIMS_22318017
{
    partial class Employee_Department_Management
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hire_date_picker = new System.Windows.Forms.DateTimePicker();
            this.leave_date_picker = new System.Windows.Forms.DateTimePicker();
            this.rbtn_belong = new System.Windows.Forms.RadioButton();
            this.rbtn_leave = new System.Windows.Forms.RadioButton();
            this.lv_Employee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_department = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_em_dept = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudown_eid = new System.Windows.Forms.NumericUpDown();
            this.nudown_did = new System.Windows.Forms.NumericUpDown();
            this.btn_return = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_eid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_did)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_Employee);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_department);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(534, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "部门信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(1063, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "员工号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(1063, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "部门号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(1039, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "入职时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(1039, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "离职时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(1087, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "状态：";
            // 
            // hire_date_picker
            // 
            this.hire_date_picker.Font = new System.Drawing.Font("宋体", 12F);
            this.hire_date_picker.Location = new System.Drawing.Point(1165, 261);
            this.hire_date_picker.Name = "hire_date_picker";
            this.hire_date_picker.Size = new System.Drawing.Size(218, 35);
            this.hire_date_picker.TabIndex = 9;
            // 
            // leave_date_picker
            // 
            this.leave_date_picker.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.leave_date_picker.Font = new System.Drawing.Font("宋体", 12F);
            this.leave_date_picker.Location = new System.Drawing.Point(1165, 340);
            this.leave_date_picker.Name = "leave_date_picker";
            this.leave_date_picker.Size = new System.Drawing.Size(218, 35);
            this.leave_date_picker.TabIndex = 10;
            // 
            // rbtn_belong
            // 
            this.rbtn_belong.AutoSize = true;
            this.rbtn_belong.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtn_belong.Location = new System.Drawing.Point(1175, 420);
            this.rbtn_belong.Name = "rbtn_belong";
            this.rbtn_belong.Size = new System.Drawing.Size(83, 28);
            this.rbtn_belong.TabIndex = 11;
            this.rbtn_belong.TabStop = true;
            this.rbtn_belong.Text = "隶属";
            this.rbtn_belong.UseVisualStyleBackColor = true;
            // 
            // rbtn_leave
            // 
            this.rbtn_leave.AutoSize = true;
            this.rbtn_leave.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtn_leave.Location = new System.Drawing.Point(1277, 420);
            this.rbtn_leave.Name = "rbtn_leave";
            this.rbtn_leave.Size = new System.Drawing.Size(83, 28);
            this.rbtn_leave.TabIndex = 12;
            this.rbtn_leave.TabStop = true;
            this.rbtn_leave.Text = "离开";
            this.rbtn_leave.UseVisualStyleBackColor = true;
            // 
            // lv_Employee
            // 
            this.lv_Employee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader13,
            this.columnHeader14});
            this.lv_Employee.FullRowSelect = true;
            this.lv_Employee.GridLines = true;
            this.lv_Employee.Location = new System.Drawing.Point(6, 34);
            this.lv_Employee.MultiSelect = false;
            this.lv_Employee.Name = "lv_Employee";
            this.lv_Employee.Size = new System.Drawing.Size(477, 348);
            this.lv_Employee.TabIndex = 0;
            this.lv_Employee.UseCompatibleStateImageBehavior = false;
            this.lv_Employee.View = System.Windows.Forms.View.Details;
            this.lv_Employee.SelectedIndexChanged += new System.EventHandler(this.lv_Employee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "员工编号";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓";
            // 
            // lv_department
            // 
            this.lv_department.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_department.FullRowSelect = true;
            this.lv_department.GridLines = true;
            this.lv_department.Location = new System.Drawing.Point(6, 34);
            this.lv_department.MultiSelect = false;
            this.lv_department.Name = "lv_department";
            this.lv_department.Size = new System.Drawing.Size(481, 348);
            this.lv_department.TabIndex = 0;
            this.lv_department.UseCompatibleStateImageBehavior = false;
            this.lv_department.View = System.Windows.Forms.View.Details;
            this.lv_department.SelectedIndexChanged += new System.EventHandler(this.lv_department_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "部门编号";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "部门名";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "部门人数";
            this.columnHeader6.Width = 120;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_Save.Location = new System.Drawing.Point(1043, 484);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(132, 52);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_Cancel.Location = new System.Drawing.Point(1228, 484);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(132, 52);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_em_dept);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox3.Location = new System.Drawing.Point(13, 552);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1347, 354);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "员工部门隶属信息";
            // 
            // lv_em_dept
            // 
            this.lv_em_dept.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lv_em_dept.FullRowSelect = true;
            this.lv_em_dept.GridLines = true;
            this.lv_em_dept.Location = new System.Drawing.Point(6, 34);
            this.lv_em_dept.MultiSelect = false;
            this.lv_em_dept.Name = "lv_em_dept";
            this.lv_em_dept.Size = new System.Drawing.Size(1335, 314);
            this.lv_em_dept.TabIndex = 0;
            this.lv_em_dept.UseCompatibleStateImageBehavior = false;
            this.lv_em_dept.View = System.Windows.Forms.View.Details;
            this.lv_em_dept.SelectedIndexChanged += new System.EventHandler(this.lv_em_dept_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "编号";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "员工编号";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "部门编号";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "入职时间";
            this.columnHeader10.Width = 180;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "离职时间";
            this.columnHeader11.Width = 180;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "当前状态";
            this.columnHeader12.Width = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(567, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "当前状态：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_Status.Location = new System.Drawing.Point(703, 22);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(58, 24);
            this.lbl_Status.TabIndex = 17;
            this.lbl_Status.Text = "添加";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_Note.Location = new System.Drawing.Point(489, 500);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 18;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "名";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "入职时间";
            this.columnHeader14.Width = 180;
            // 
            // nudown_eid
            // 
            this.nudown_eid.Font = new System.Drawing.Font("宋体", 12F);
            this.nudown_eid.Location = new System.Drawing.Point(1165, 89);
            this.nudown_eid.Name = "nudown_eid";
            this.nudown_eid.Size = new System.Drawing.Size(218, 35);
            this.nudown_eid.TabIndex = 19;
            // 
            // nudown_did
            // 
            this.nudown_did.Font = new System.Drawing.Font("宋体", 12F);
            this.nudown_did.Location = new System.Drawing.Point(1165, 178);
            this.nudown_did.Name = "nudown_did";
            this.nudown_did.Size = new System.Drawing.Size(218, 35);
            this.nudown_did.TabIndex = 20;
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_return.Location = new System.Drawing.Point(1175, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(125, 47);
            this.btn_return.TabIndex = 21;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Employee_Department_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 918);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.nudown_did);
            this.Controls.Add(this.nudown_eid);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.rbtn_leave);
            this.Controls.Add(this.rbtn_belong);
            this.Controls.Add(this.leave_date_picker);
            this.Controls.Add(this.hire_date_picker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee_Department_Management";
            this.Text = "员工部门隶属管理页面";
            this.Load += new System.EventHandler(this.Employee_Department_Management_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudown_eid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_did)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_Employee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_department;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker hire_date_picker;
        private System.Windows.Forms.DateTimePicker leave_date_picker;
        private System.Windows.Forms.RadioButton rbtn_belong;
        private System.Windows.Forms.RadioButton rbtn_leave;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_em_dept;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.NumericUpDown nudown_eid;
        private System.Windows.Forms.NumericUpDown nudown_did;
        private System.Windows.Forms.Button btn_return;
    }
}