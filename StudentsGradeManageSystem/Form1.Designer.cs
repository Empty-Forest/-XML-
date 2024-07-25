namespace StudentsGradeManageSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StudentList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            numText = new TextBox();
            nameText = new TextBox();
            label2 = new Label();
            sexText = new TextBox();
            label3 = new Label();
            chineseText = new TextBox();
            label4 = new Label();
            mathText = new TextBox();
            label5 = new Label();
            englishText = new TextBox();
            label6 = new Label();
            FindBt = new Button();
            AddBt = new Button();
            EditBt = new Button();
            DeleteBt = new Button();
            RefreshBt = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentList).BeginInit();
            SuspendLayout();
            // 
            // StudentList
            // 
            StudentList.AllowUserToDeleteRows = false;
            StudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            StudentList.Location = new Point(3, 3);
            StudentList.MultiSelect = false;
            StudentList.Name = "StudentList";
            StudentList.ReadOnly = true;
            StudentList.RowHeadersVisible = false;
            StudentList.RowHeadersWidth = 51;
            StudentList.RowTemplate.Height = 29;
            StudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentList.Size = new Size(790, 224);
            StudentList.TabIndex = 0;
            StudentList.CellContentClick += StudentList_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "学号";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "姓名";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "性别";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "语文成绩";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "数学成绩";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "英语成绩";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 252);
            label1.Name = "label1";
            label1.Size = new Size(52, 27);
            label1.TabIndex = 1;
            label1.Text = "学号";
            // 
            // numText
            // 
            numText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numText.Location = new Point(12, 284);
            numText.Name = "numText";
            numText.Size = new Size(125, 30);
            numText.TabIndex = 2;
            // 
            // nameText
            // 
            nameText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.Location = new Point(147, 284);
            nameText.Name = "nameText";
            nameText.Size = new Size(125, 30);
            nameText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(147, 252);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 3;
            label2.Text = "姓名";
            // 
            // sexText
            // 
            sexText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sexText.Location = new Point(283, 284);
            sexText.Name = "sexText";
            sexText.Size = new Size(73, 30);
            sexText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(283, 252);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 5;
            label3.Text = "性别";
            // 
            // chineseText
            // 
            chineseText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chineseText.Location = new Point(371, 284);
            chineseText.Name = "chineseText";
            chineseText.Size = new Size(125, 30);
            chineseText.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(371, 252);
            label4.Name = "label4";
            label4.Size = new Size(92, 27);
            label4.TabIndex = 7;
            label4.Text = "语文成绩";
            // 
            // mathText
            // 
            mathText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mathText.Location = new Point(502, 284);
            mathText.Name = "mathText";
            mathText.Size = new Size(125, 30);
            mathText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(502, 252);
            label5.Name = "label5";
            label5.Size = new Size(92, 27);
            label5.TabIndex = 9;
            label5.Text = "数学成绩";
            // 
            // englishText
            // 
            englishText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            englishText.Location = new Point(633, 284);
            englishText.Name = "englishText";
            englishText.Size = new Size(125, 30);
            englishText.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(633, 252);
            label6.Name = "label6";
            label6.Size = new Size(92, 27);
            label6.TabIndex = 11;
            label6.Text = "英语成绩";
            // 
            // FindBt
            // 
            FindBt.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FindBt.Location = new Point(197, 329);
            FindBt.Name = "FindBt";
            FindBt.Size = new Size(110, 42);
            FindBt.TabIndex = 13;
            FindBt.Text = "查询";
            FindBt.UseVisualStyleBackColor = true;
            FindBt.Click += FindBt_Click;
            // 
            // AddBt
            // 
            AddBt.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddBt.Location = new Point(78, 386);
            AddBt.Name = "AddBt";
            AddBt.Size = new Size(110, 42);
            AddBt.TabIndex = 14;
            AddBt.Text = "增加";
            AddBt.UseVisualStyleBackColor = true;
            AddBt.Click += AddBt_Click;
            // 
            // EditBt
            // 
            EditBt.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EditBt.Location = new Point(320, 386);
            EditBt.Name = "EditBt";
            EditBt.Size = new Size(110, 42);
            EditBt.TabIndex = 15;
            EditBt.Text = "修改";
            EditBt.UseVisualStyleBackColor = true;
            EditBt.Click += EditBt_Click;
            // 
            // DeleteBt
            // 
            DeleteBt.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBt.Location = new Point(573, 386);
            DeleteBt.Name = "DeleteBt";
            DeleteBt.Size = new Size(110, 42);
            DeleteBt.TabIndex = 16;
            DeleteBt.Text = "删除";
            DeleteBt.UseVisualStyleBackColor = true;
            DeleteBt.Click += DeleteBt_Click;
            // 
            // RefreshBt
            // 
            RefreshBt.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshBt.Location = new Point(451, 329);
            RefreshBt.Name = "RefreshBt";
            RefreshBt.Size = new Size(110, 42);
            RefreshBt.TabIndex = 17;
            RefreshBt.Text = "清空";
            RefreshBt.UseVisualStyleBackColor = true;
            RefreshBt.Click += RefreshBt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RefreshBt);
            Controls.Add(DeleteBt);
            Controls.Add(EditBt);
            Controls.Add(AddBt);
            Controls.Add(FindBt);
            Controls.Add(englishText);
            Controls.Add(label6);
            Controls.Add(mathText);
            Controls.Add(label5);
            Controls.Add(chineseText);
            Controls.Add(label4);
            Controls.Add(sexText);
            Controls.Add(label3);
            Controls.Add(nameText);
            Controls.Add(label2);
            Controls.Add(numText);
            Controls.Add(label1);
            Controls.Add(StudentList);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学生成绩管理系统";
            ((System.ComponentModel.ISupportInitialize)StudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label1;
        private TextBox numText;
        private TextBox nameText;
        private Label label2;
        private TextBox sexText;
        private Label label3;
        private TextBox chineseText;
        private Label label4;
        private TextBox mathText;
        private Label label5;
        private TextBox englishText;
        private Label label6;
        private Button FindBt;
        private Button AddBt;
        private Button EditBt;
        private Button DeleteBt;
        private Button RefreshBt;
    }
}
