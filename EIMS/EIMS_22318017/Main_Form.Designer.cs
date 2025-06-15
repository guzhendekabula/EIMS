namespace EIMS_22318017
{
    partial class Main_Form
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
            this.btn_customer_management = new System.Windows.Forms.Button();
            this.btn_employee_management = new System.Windows.Forms.Button();
            this.btn_dept_management = new System.Windows.Forms.Button();
            this.btn_emp_dept_management = new System.Windows.Forms.Button();
            this.btn_employee_search = new System.Windows.Forms.Button();
            this.btn_main_cancel = new System.Windows.Forms.Button();
            this.main_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_customer_management
            // 
            this.btn_customer_management.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_customer_management.Location = new System.Drawing.Point(63, 87);
            this.btn_customer_management.Name = "btn_customer_management";
            this.btn_customer_management.Size = new System.Drawing.Size(266, 71);
            this.btn_customer_management.TabIndex = 0;
            this.btn_customer_management.Text = "客户信息管理";
            this.btn_customer_management.UseVisualStyleBackColor = true;
            this.btn_customer_management.Click += new System.EventHandler(this.btn_customer_management_Click);
            // 
            // btn_employee_management
            // 
            this.btn_employee_management.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_employee_management.Location = new System.Drawing.Point(375, 87);
            this.btn_employee_management.Name = "btn_employee_management";
            this.btn_employee_management.Size = new System.Drawing.Size(266, 71);
            this.btn_employee_management.TabIndex = 1;
            this.btn_employee_management.Text = "员工信息管理";
            this.btn_employee_management.UseVisualStyleBackColor = true;
            this.btn_employee_management.Click += new System.EventHandler(this.btn_employee_management_Click);
            // 
            // btn_dept_management
            // 
            this.btn_dept_management.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_dept_management.Location = new System.Drawing.Point(63, 209);
            this.btn_dept_management.Name = "btn_dept_management";
            this.btn_dept_management.Size = new System.Drawing.Size(266, 71);
            this.btn_dept_management.TabIndex = 2;
            this.btn_dept_management.Text = "部门信息管理";
            this.btn_dept_management.UseVisualStyleBackColor = true;
            this.btn_dept_management.Click += new System.EventHandler(this.btn_dept_management_Click);
            // 
            // btn_emp_dept_management
            // 
            this.btn_emp_dept_management.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_emp_dept_management.Location = new System.Drawing.Point(63, 339);
            this.btn_emp_dept_management.Name = "btn_emp_dept_management";
            this.btn_emp_dept_management.Size = new System.Drawing.Size(266, 71);
            this.btn_emp_dept_management.TabIndex = 3;
            this.btn_emp_dept_management.Text = "员工部门隶属管理";
            this.btn_emp_dept_management.UseVisualStyleBackColor = true;
            this.btn_emp_dept_management.Click += new System.EventHandler(this.btn_emp_dept_management_Click);
            // 
            // btn_employee_search
            // 
            this.btn_employee_search.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_employee_search.Location = new System.Drawing.Point(375, 209);
            this.btn_employee_search.Name = "btn_employee_search";
            this.btn_employee_search.Size = new System.Drawing.Size(266, 71);
            this.btn_employee_search.TabIndex = 4;
            this.btn_employee_search.Text = "员工信息查询";
            this.btn_employee_search.UseVisualStyleBackColor = true;
            this.btn_employee_search.Click += new System.EventHandler(this.btn_employee_search_Click);
            // 
            // btn_main_cancel
            // 
            this.btn_main_cancel.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_main_cancel.Location = new System.Drawing.Point(375, 339);
            this.btn_main_cancel.Name = "btn_main_cancel";
            this.btn_main_cancel.Size = new System.Drawing.Size(266, 71);
            this.btn_main_cancel.TabIndex = 5;
            this.btn_main_cancel.Text = "退出登录";
            this.btn_main_cancel.UseVisualStyleBackColor = true;
            this.btn_main_cancel.Click += new System.EventHandler(this.btn_main_cancel_Click);
            // 
            // main_name_label
            // 
            this.main_name_label.AutoSize = true;
            this.main_name_label.Font = new System.Drawing.Font("宋体", 15F);
            this.main_name_label.Location = new System.Drawing.Point(182, 25);
            this.main_name_label.Name = "main_name_label";
            this.main_name_label.Size = new System.Drawing.Size(73, 30);
            this.main_name_label.TabIndex = 6;
            this.main_name_label.Text = "欢迎";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 478);
            this.Controls.Add(this.main_name_label);
            this.Controls.Add(this.btn_main_cancel);
            this.Controls.Add(this.btn_employee_search);
            this.Controls.Add(this.btn_emp_dept_management);
            this.Controls.Add(this.btn_dept_management);
            this.Controls.Add(this.btn_employee_management);
            this.Controls.Add(this.btn_customer_management);
            this.Name = "Main_Form";
            this.Text = "企业信息管理系统——主页面";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_customer_management;
        private System.Windows.Forms.Button btn_employee_management;
        private System.Windows.Forms.Button btn_dept_management;
        private System.Windows.Forms.Button btn_emp_dept_management;
        private System.Windows.Forms.Button btn_employee_search;
        private System.Windows.Forms.Button btn_main_cancel;
        private System.Windows.Forms.Label main_name_label;
    }
}