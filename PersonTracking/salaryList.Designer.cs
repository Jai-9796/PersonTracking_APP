namespace PersonTracking
{
    partial class salaryList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.TextBox();
            this.UserNo = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.Label();
            this.IsApproved = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.Button();
            this.More = new System.Windows.Forms.RadioButton();
            this.Less = new System.Windows.Forms.RadioButton();
            this.Equals = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Equals);
            this.panel1.Controls.Add(this.Less);
            this.panel1.Controls.Add(this.More);
            this.panel1.Controls.Add(this.month);
            this.panel1.Controls.Add(this.txtmonth);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.txtyear);
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.txtsalary);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 188);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IsApproved);
            this.panel2.Controls.Add(this.txtClose);
            this.panel2.Controls.Add(this.txtDelete);
            this.panel2.Controls.Add(this.txtUpdate);
            this.panel2.Controls.Add(this.txtAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 87);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 175);
            this.dataGridView1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Department);
            this.flowLayoutPanel1.Controls.Add(this.Name);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.UserNo);
            this.flowLayoutPanel1.Controls.Add(this.txtName);
            this.flowLayoutPanel1.Controls.Add(this.Surname);
            this.flowLayoutPanel1.Controls.Add(this.comboBox2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox3);
            this.flowLayoutPanel1.Controls.Add(this.Position);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 188);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(143, 117);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(218, 24);
            this.comboBox3.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 24);
            this.comboBox2.TabIndex = 17;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(82, 114);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(55, 16);
            this.Position.TabIndex = 18;
            this.Position.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dep";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 15;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(79, 56);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(73, 16);
            this.Surname.TabIndex = 14;
            this.Surname.Text = "txtSurname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 13;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(108, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 12;
            this.Name.Text = "Name";
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(158, 3);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(203, 22);
            this.Department.TabIndex = 11;
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Location = new System.Drawing.Point(112, 28);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(54, 16);
            this.UserNo.TabIndex = 10;
            this.UserNo.Text = "UserNo";
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(477, 78);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(189, 22);
            this.month.TabIndex = 53;
            // 
            // txtmonth
            // 
            this.txtmonth.AutoSize = true;
            this.txtmonth.Location = new System.Drawing.Point(398, 78);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(55, 16);
            this.txtmonth.TabIndex = 52;
            this.txtmonth.Text = "txtmonth";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(477, 40);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(189, 22);
            this.year.TabIndex = 51;
            // 
            // txtyear
            // 
            this.txtyear.AutoSize = true;
            this.txtyear.Location = new System.Drawing.Point(395, 46);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(34, 16);
            this.txtyear.TabIndex = 50;
            this.txtyear.Text = "year";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(477, 12);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(189, 22);
            this.salary.TabIndex = 49;
            // 
            // txtsalary
            // 
            this.txtsalary.AutoSize = true;
            this.txtsalary.Location = new System.Drawing.Point(395, 18);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(44, 16);
            this.txtsalary.TabIndex = 48;
            this.txtsalary.Text = "salary";
            // 
            // IsApproved
            // 
            this.IsApproved.Location = new System.Drawing.Point(70, 14);
            this.IsApproved.Name = "IsApproved";
            this.IsApproved.Size = new System.Drawing.Size(185, 61);
            this.IsApproved.TabIndex = 5;
            this.IsApproved.Text = "Approved";
            this.IsApproved.UseVisualStyleBackColor = true;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(900, 14);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(185, 61);
            this.txtClose.TabIndex = 9;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(710, 14);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(185, 61);
            this.txtDelete.TabIndex = 8;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(509, 14);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(185, 61);
            this.txtUpdate.TabIndex = 7;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(306, 14);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(185, 61);
            this.txtAdd.TabIndex = 6;
            this.txtAdd.Text = "Add";
            this.txtAdd.UseVisualStyleBackColor = true;
            // 
            // More
            // 
            this.More.AutoSize = true;
            this.More.Location = new System.Drawing.Point(732, 33);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(59, 20);
            this.More.TabIndex = 54;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = true;
            // 
            // Less
            // 
            this.Less.AutoSize = true;
            this.Less.Location = new System.Drawing.Point(732, 74);
            this.Less.Name = "Less";
            this.Less.Size = new System.Drawing.Size(57, 20);
            this.Less.TabIndex = 55;
            this.Less.Text = "Less";
            this.Less.UseVisualStyleBackColor = true;
            // 
            // Equals
            // 
            this.Equals.AutoSize = true;
            this.Equals.Location = new System.Drawing.Point(732, 112);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(70, 20);
            this.Equals.TabIndex = 56;
            this.Equals.Text = "Equals";
            this.Equals.UseVisualStyleBackColor = true;
            // 
            // salaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
           
            this.Text = "salaryList";
            this.Load += new System.EventHandler(this.salaryList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label txtmonth;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label txtyear;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label txtsalary;
        private System.Windows.Forms.RadioButton Equals;
        private System.Windows.Forms.RadioButton Less;
        private System.Windows.Forms.RadioButton More;
        private System.Windows.Forms.Button IsApproved;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button txtAdd;
    }
}