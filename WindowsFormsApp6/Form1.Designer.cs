namespace WinFormsApp6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // ─── Элементы формы ───
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.NumericUpDown numExperience;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.ListBox lstTeachers;
        private System.Windows.Forms.Button btnRemoveFromList;

        private System.Windows.Forms.GroupBox grpHash;
        private System.Windows.Forms.ListBox lstHash;
        private System.Windows.Forms.Button btnRemoveFromHash;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.numExperience = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.lstTeachers = new System.Windows.Forms.ListBox();
            this.btnRemoveFromList = new System.Windows.Forms.Button();
            this.grpHash = new System.Windows.Forms.GroupBox();
            this.lstHash = new System.Windows.Forms.ListBox();
            this.btnRemoveFromHash = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).BeginInit();
            this.grpList.SuspendLayout();
            this.grpHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.lblName);
            this.grpAdd.Controls.Add(this.txtName);
            this.grpAdd.Controls.Add(this.lblDept);
            this.grpAdd.Controls.Add(this.txtDepartment);
            this.grpAdd.Controls.Add(this.lblSubject);
            this.grpAdd.Controls.Add(this.txtSubject);
            this.grpAdd.Controls.Add(this.lblExp);
            this.grpAdd.Controls.Add(this.numExperience);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Location = new System.Drawing.Point(10, 10);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(290, 160);
            this.grpAdd.TabIndex = 0;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Добавление";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ФИО:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(10, 53);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(69, 16);
            this.lblDept.TabIndex = 2;
            this.lblDept.Text = "Кафедра:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(75, 50);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(200, 22);
            this.txtDepartment.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(10, 81);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 16);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Предмет:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(75, 78);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 22);
            this.txtSubject.TabIndex = 5;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(10, 109);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(43, 16);
            this.lblExp.TabIndex = 6;
            this.lblExp.Text = "Стаж:";
            // 
            // numExperience
            // 
            this.numExperience.Location = new System.Drawing.Point(75, 106);
            this.numExperience.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numExperience.Name = "numExperience";
            this.numExperience.Size = new System.Drawing.Size(60, 22);
            this.numExperience.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lstTeachers);
            this.grpList.Controls.Add(this.btnRemoveFromList);
            this.grpList.Location = new System.Drawing.Point(10, 180);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(314, 230);
            this.grpList.TabIndex = 1;
            this.grpList.TabStop = false;
            this.grpList.Text = "List<Teacher>";
            // 
            // lstTeachers
            // 
            this.lstTeachers.ItemHeight = 16;
            this.lstTeachers.Location = new System.Drawing.Point(10, 20);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(300, 164);
            this.lstTeachers.TabIndex = 0;
            // 
            // btnRemoveFromList
            // 
            this.btnRemoveFromList.Location = new System.Drawing.Point(10, 190);
            this.btnRemoveFromList.Name = "btnRemoveFromList";
            this.btnRemoveFromList.Size = new System.Drawing.Size(290, 28);
            this.btnRemoveFromList.TabIndex = 1;
            this.btnRemoveFromList.Text = "Удалить из List";
            this.btnRemoveFromList.Click += new System.EventHandler(this.btnRemoveFromList_Click);
            // 
            // grpHash
            // 
            this.grpHash.Controls.Add(this.lstHash);
            this.grpHash.Controls.Add(this.btnRemoveFromHash);
            this.grpHash.Location = new System.Drawing.Point(330, 10);
            this.grpHash.Name = "grpHash";
            this.grpHash.Size = new System.Drawing.Size(320, 400);
            this.grpHash.TabIndex = 2;
            this.grpHash.TabStop = false;
            this.grpHash.Text = "Hashtable";
            // 
            // lstHash
            // 
            this.lstHash.ItemHeight = 16;
            this.lstHash.Location = new System.Drawing.Point(10, 20);
            this.lstHash.Name = "lstHash";
            this.lstHash.Size = new System.Drawing.Size(300, 340);
            this.lstHash.TabIndex = 0;
            // 
            // btnRemoveFromHash
            // 
            this.btnRemoveFromHash.Location = new System.Drawing.Point(10, 365);
            this.btnRemoveFromHash.Name = "btnRemoveFromHash";
            this.btnRemoveFromHash.Size = new System.Drawing.Size(300, 28);
            this.btnRemoveFromHash.TabIndex = 1;
            this.btnRemoveFromHash.Text = "Удалить из Hashtable";
            this.btnRemoveFromHash.Click += new System.EventHandler(this.btnRemoveFromHash_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(684, 430);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpHash);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №6 — Вариант 3";
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).EndInit();
            this.grpList.ResumeLayout(false);
            this.grpHash.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}