namespace BartoszEgrowskiPD3
{
    partial class FormMain
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
            this.dataGridViewSchools = new System.Windows.Forms.DataGridView();
            this.buttonShowAllGrades = new System.Windows.Forms.Button();
            this.buttonShowAllTeachers = new System.Windows.Forms.Button();
            this.buttonShowParents = new System.Windows.Forms.Button();
            this.buttonShowAllStudents = new System.Windows.Forms.Button();
            this.buttonShowStudentsWithPositiveGrades = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelStudentNameInfo = new System.Windows.Forms.Label();
            this.buttonShowStudentsAtSelectedSchool = new System.Windows.Forms.Button();
            this.labelSchoolNameInfo = new System.Windows.Forms.Label();
            this.textBoxSchoolName = new System.Windows.Forms.TextBox();
            this.buttonShowTeachersWorkingAtSelectedSchool = new System.Windows.Forms.Button();
            this.buttonShowStudentsAttendingChosenSubject = new System.Windows.Forms.Button();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.labelSubjectNameInfo = new System.Windows.Forms.Label();
            this.buttonShowSelectedStudentGrades = new System.Windows.Forms.Button();
            this.textBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.labelStudentSurnameInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchools)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchools
            // 
            this.dataGridViewSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchools.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSchools.Name = "dataGridViewSchools";
            this.dataGridViewSchools.Size = new System.Drawing.Size(701, 303);
            this.dataGridViewSchools.TabIndex = 0;
            // 
            // buttonShowAllGrades
            // 
            this.buttonShowAllGrades.Location = new System.Drawing.Point(719, 12);
            this.buttonShowAllGrades.Name = "buttonShowAllGrades";
            this.buttonShowAllGrades.Size = new System.Drawing.Size(141, 23);
            this.buttonShowAllGrades.TabIndex = 1;
            this.buttonShowAllGrades.Text = "Pokaż wszystkie oceny";
            this.buttonShowAllGrades.UseVisualStyleBackColor = true;
            this.buttonShowAllGrades.Click += new System.EventHandler(this.buttonShowAllGrades_Click);
            // 
            // buttonShowAllTeachers
            // 
            this.buttonShowAllTeachers.Location = new System.Drawing.Point(719, 205);
            this.buttonShowAllTeachers.Name = "buttonShowAllTeachers";
            this.buttonShowAllTeachers.Size = new System.Drawing.Size(141, 38);
            this.buttonShowAllTeachers.TabIndex = 2;
            this.buttonShowAllTeachers.Text = "Pokaż wszystkich nauczycieli";
            this.buttonShowAllTeachers.UseVisualStyleBackColor = true;
            this.buttonShowAllTeachers.Click += new System.EventHandler(this.buttonShowAllTeachers_Click);
            // 
            // buttonShowParents
            // 
            this.buttonShowParents.Location = new System.Drawing.Point(718, 155);
            this.buttonShowParents.Name = "buttonShowParents";
            this.buttonShowParents.Size = new System.Drawing.Size(141, 44);
            this.buttonShowParents.TabIndex = 3;
            this.buttonShowParents.Text = "Wyświetl dane rodziców wybranego ucznia";
            this.buttonShowParents.UseVisualStyleBackColor = true;
            this.buttonShowParents.Click += new System.EventHandler(this.buttonShowParents_Click);
            // 
            // buttonShowAllStudents
            // 
            this.buttonShowAllStudents.Location = new System.Drawing.Point(719, 126);
            this.buttonShowAllStudents.Name = "buttonShowAllStudents";
            this.buttonShowAllStudents.Size = new System.Drawing.Size(141, 23);
            this.buttonShowAllStudents.TabIndex = 4;
            this.buttonShowAllStudents.Text = "Pokaż wszystkich uczniów";
            this.buttonShowAllStudents.UseVisualStyleBackColor = true;
            this.buttonShowAllStudents.Click += new System.EventHandler(this.buttonShowAllStudents_Click);
            // 
            // buttonShowStudentsWithPositiveGrades
            // 
            this.buttonShowStudentsWithPositiveGrades.Location = new System.Drawing.Point(719, 81);
            this.buttonShowStudentsWithPositiveGrades.Name = "buttonShowStudentsWithPositiveGrades";
            this.buttonShowStudentsWithPositiveGrades.Size = new System.Drawing.Size(141, 39);
            this.buttonShowStudentsWithPositiveGrades.TabIndex = 5;
            this.buttonShowStudentsWithPositiveGrades.Text = "Pokaż uczniów z pozytywną oceną";
            this.buttonShowStudentsWithPositiveGrades.UseVisualStyleBackColor = true;
            this.buttonShowStudentsWithPositiveGrades.Click += new System.EventHandler(this.buttonShowStudentsWithPositiveGrades_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(174, 321);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(141, 20);
            this.textBoxStudentName.TabIndex = 6;
            // 
            // labelStudentNameInfo
            // 
            this.labelStudentNameInfo.AutoSize = true;
            this.labelStudentNameInfo.Location = new System.Drawing.Point(12, 324);
            this.labelStudentNameInfo.Name = "labelStudentNameInfo";
            this.labelStudentNameInfo.Size = new System.Drawing.Size(60, 13);
            this.labelStudentNameInfo.TabIndex = 7;
            this.labelStudentNameInfo.Text = "Wpisz imię:";
            // 
            // buttonShowStudentsAtSelectedSchool
            // 
            this.buttonShowStudentsAtSelectedSchool.Location = new System.Drawing.Point(718, 249);
            this.buttonShowStudentsAtSelectedSchool.Name = "buttonShowStudentsAtSelectedSchool";
            this.buttonShowStudentsAtSelectedSchool.Size = new System.Drawing.Size(141, 47);
            this.buttonShowStudentsAtSelectedSchool.TabIndex = 8;
            this.buttonShowStudentsAtSelectedSchool.Text = "Pokaż uczniów uczęszczających do wybranej szkoły";
            this.buttonShowStudentsAtSelectedSchool.UseVisualStyleBackColor = true;
            this.buttonShowStudentsAtSelectedSchool.Click += new System.EventHandler(this.buttonShowStudentsAtSelectedSchool_Click);
            // 
            // labelSchoolNameInfo
            // 
            this.labelSchoolNameInfo.AutoSize = true;
            this.labelSchoolNameInfo.Location = new System.Drawing.Point(12, 350);
            this.labelSchoolNameInfo.Name = "labelSchoolNameInfo";
            this.labelSchoolNameInfo.Size = new System.Drawing.Size(107, 13);
            this.labelSchoolNameInfo.TabIndex = 9;
            this.labelSchoolNameInfo.Text = "Wpisz nazwę szkoły:";
            // 
            // textBoxSchoolName
            // 
            this.textBoxSchoolName.Location = new System.Drawing.Point(174, 347);
            this.textBoxSchoolName.Name = "textBoxSchoolName";
            this.textBoxSchoolName.Size = new System.Drawing.Size(141, 20);
            this.textBoxSchoolName.TabIndex = 10;
            // 
            // buttonShowTeachersWorkingAtSelectedSchool
            // 
            this.buttonShowTeachersWorkingAtSelectedSchool.Location = new System.Drawing.Point(719, 302);
            this.buttonShowTeachersWorkingAtSelectedSchool.Name = "buttonShowTeachersWorkingAtSelectedSchool";
            this.buttonShowTeachersWorkingAtSelectedSchool.Size = new System.Drawing.Size(141, 56);
            this.buttonShowTeachersWorkingAtSelectedSchool.TabIndex = 11;
            this.buttonShowTeachersWorkingAtSelectedSchool.Text = "Pokaż nauczycieli uczących w wybranej szkole";
            this.buttonShowTeachersWorkingAtSelectedSchool.UseVisualStyleBackColor = true;
            this.buttonShowTeachersWorkingAtSelectedSchool.Click += new System.EventHandler(this.buttonShowTeachersWorkingAtSelectedSchool_Click);
            // 
            // buttonShowStudentsAttendingChosenSubject
            // 
            this.buttonShowStudentsAttendingChosenSubject.Location = new System.Drawing.Point(719, 364);
            this.buttonShowStudentsAttendingChosenSubject.Name = "buttonShowStudentsAttendingChosenSubject";
            this.buttonShowStudentsAttendingChosenSubject.Size = new System.Drawing.Size(141, 47);
            this.buttonShowStudentsAttendingChosenSubject.TabIndex = 12;
            this.buttonShowStudentsAttendingChosenSubject.Text = "Pokaż uczniów uczęszczających na wybrany przedmiot";
            this.buttonShowStudentsAttendingChosenSubject.UseVisualStyleBackColor = true;
            this.buttonShowStudentsAttendingChosenSubject.Click += new System.EventHandler(this.buttonShowStudentsAttendingChosenSubject_Click);
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(174, 374);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(141, 20);
            this.textBoxSubjectName.TabIndex = 14;
            // 
            // labelSubjectNameInfo
            // 
            this.labelSubjectNameInfo.AutoSize = true;
            this.labelSubjectNameInfo.Location = new System.Drawing.Point(12, 377);
            this.labelSubjectNameInfo.Name = "labelSubjectNameInfo";
            this.labelSubjectNameInfo.Size = new System.Drawing.Size(87, 13);
            this.labelSubjectNameInfo.TabIndex = 13;
            this.labelSubjectNameInfo.Text = "Wpisz przedmiot:";
            // 
            // buttonShowSelectedStudentGrades
            // 
            this.buttonShowSelectedStudentGrades.Location = new System.Drawing.Point(719, 41);
            this.buttonShowSelectedStudentGrades.Name = "buttonShowSelectedStudentGrades";
            this.buttonShowSelectedStudentGrades.Size = new System.Drawing.Size(141, 34);
            this.buttonShowSelectedStudentGrades.TabIndex = 15;
            this.buttonShowSelectedStudentGrades.Text = "Pokaż oceny wybranego ucznia";
            this.buttonShowSelectedStudentGrades.UseVisualStyleBackColor = true;
            this.buttonShowSelectedStudentGrades.Click += new System.EventHandler(this.buttonShowSelectedStudentGrades_Click);
            // 
            // textBoxStudentSurname
            // 
            this.textBoxStudentSurname.Location = new System.Drawing.Point(427, 321);
            this.textBoxStudentSurname.Name = "textBoxStudentSurname";
            this.textBoxStudentSurname.Size = new System.Drawing.Size(141, 20);
            this.textBoxStudentSurname.TabIndex = 16;
            // 
            // labelStudentSurnameInfo
            // 
            this.labelStudentSurnameInfo.AutoSize = true;
            this.labelStudentSurnameInfo.Location = new System.Drawing.Point(328, 324);
            this.labelStudentSurnameInfo.Name = "labelStudentSurnameInfo";
            this.labelStudentSurnameInfo.Size = new System.Drawing.Size(93, 13);
            this.labelStudentSurnameInfo.TabIndex = 17;
            this.labelStudentSurnameInfo.Text = "i nazwisko ucznia:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 420);
            this.Controls.Add(this.labelStudentSurnameInfo);
            this.Controls.Add(this.textBoxStudentSurname);
            this.Controls.Add(this.buttonShowSelectedStudentGrades);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.labelSubjectNameInfo);
            this.Controls.Add(this.buttonShowStudentsAttendingChosenSubject);
            this.Controls.Add(this.buttonShowTeachersWorkingAtSelectedSchool);
            this.Controls.Add(this.textBoxSchoolName);
            this.Controls.Add(this.labelSchoolNameInfo);
            this.Controls.Add(this.buttonShowStudentsAtSelectedSchool);
            this.Controls.Add(this.labelStudentNameInfo);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.buttonShowStudentsWithPositiveGrades);
            this.Controls.Add(this.buttonShowAllStudents);
            this.Controls.Add(this.buttonShowParents);
            this.Controls.Add(this.buttonShowAllTeachers);
            this.Controls.Add(this.buttonShowAllGrades);
            this.Controls.Add(this.dataGridViewSchools);
            this.Name = "FormMain";
            this.Text = "Schools Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchools;
        private System.Windows.Forms.Button buttonShowAllGrades;
        private System.Windows.Forms.Button buttonShowAllTeachers;
        private System.Windows.Forms.Button buttonShowParents;
        private System.Windows.Forms.Button buttonShowAllStudents;
        private System.Windows.Forms.Button buttonShowStudentsWithPositiveGrades;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelStudentNameInfo;
        private System.Windows.Forms.Button buttonShowStudentsAtSelectedSchool;
        private System.Windows.Forms.Label labelSchoolNameInfo;
        private System.Windows.Forms.TextBox textBoxSchoolName;
        private System.Windows.Forms.Button buttonShowTeachersWorkingAtSelectedSchool;
        private System.Windows.Forms.Button buttonShowStudentsAttendingChosenSubject;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label labelSubjectNameInfo;
        private System.Windows.Forms.Button buttonShowSelectedStudentGrades;
        private System.Windows.Forms.TextBox textBoxStudentSurname;
        private System.Windows.Forms.Label labelStudentSurnameInfo;
    }
}

