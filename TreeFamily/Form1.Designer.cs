namespace TreeFamily
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnAncestors = new System.Windows.Forms.Button();
            this.btnDescendants = new System.Windows.Forms.Button();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.cmbChild = new System.Windows.Forms.ComboBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lavel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(0, 77);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 82);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Додати Персону";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(81, 77);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(75, 82);
            this.btnLink.TabIndex = 1;
            this.btnLink.Text = "Прив\'язати батьків";
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // btnAncestors
            // 
            this.btnAncestors.Location = new System.Drawing.Point(162, 77);
            this.btnAncestors.Name = "btnAncestors";
            this.btnAncestors.Size = new System.Drawing.Size(75, 82);
            this.btnAncestors.TabIndex = 2;
            this.btnAncestors.Text = "Предки";
            this.btnAncestors.UseVisualStyleBackColor = true;
            // 
            // btnDescendants
            // 
            this.btnDescendants.Location = new System.Drawing.Point(243, 77);
            this.btnDescendants.Name = "btnDescendants";
            this.btnDescendants.Size = new System.Drawing.Size(75, 82);
            this.btnDescendants.TabIndex = 3;
            this.btnDescendants.Text = "Нащадки";
            this.btnDescendants.UseVisualStyleBackColor = true;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(627, 21);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(170, 20);
            this.txtPassport.TabIndex = 5;
            this.txtPassport.TextChanged += new System.EventHandler(this.txtPassport_TextChanged);
            // 
            // cmbParent
            // 
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Location = new System.Drawing.Point(454, 77);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(167, 21);
            this.cmbParent.TabIndex = 6;
            // 
            // cmbChild
            // 
            this.cmbChild.FormattingEnabled = true;
            this.cmbChild.Location = new System.Drawing.Point(627, 77);
            this.cmbChild.Name = "cmbChild";
            this.cmbChild.Size = new System.Drawing.Size(170, 21);
            this.cmbChild.TabIndex = 7;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(627, 155);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(161, 21);
            this.cmbSearch.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(306, 179);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(315, 264);
            this.treeView1.TabIndex = 9;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(0, 179);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(300, 264);
            this.lstResults.TabIndex = 10;
            // 
            // lavel1
            // 
            this.lavel1.AutoSize = true;
            this.lavel1.Location = new System.Drawing.Point(624, 61);
            this.lavel1.Name = "lavel1";
            this.lavel1.Size = new System.Drawing.Size(45, 13);
            this.lavel1.TabIndex = 11;
            this.lavel1.Text = "Дитина";
            this.lavel1.Click += new System.EventHandler(this.lavel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Батьки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Паспортні дані";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ім\'я";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Перегляд дерева";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Результат";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(146, 23);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(122, 20);
            this.txtLastName.TabIndex = 17;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(274, 23);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(124, 20);
            this.txtMiddleName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Прізвище";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "По Батькові";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(28, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Пошук";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lavel1);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.cmbChild);
            this.Controls.Add(this.cmbParent);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnDescendants);
            this.Controls.Add(this.btnAncestors);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnAddPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnAncestors;
        private System.Windows.Forms.Button btnDescendants;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.ComboBox cmbParent;
        private System.Windows.Forms.ComboBox cmbChild;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lavel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
    }
}

