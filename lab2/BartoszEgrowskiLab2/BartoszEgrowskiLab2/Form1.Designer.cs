namespace BartoszEgrowskiLab2
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
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.dataGridViewListOfPeople = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelListOfPeople = new System.Windows.Forms.Label();
            this.labelGrades = new System.Windows.Forms.Label();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.textBoxGradeValue = new System.Windows.Forms.TextBox();
            this.textBoxGradeName = new System.Windows.Forms.TextBox();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.buttonShowGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameSurname.Location = new System.Drawing.Point(182, 9);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(153, 24);
            this.labelNameSurname.TabIndex = 0;
            this.labelNameSurname.Text = "Bartosz Egrowski";
            // 
            // dataGridViewListOfPeople
            // 
            this.dataGridViewListOfPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfPeople.Location = new System.Drawing.Point(186, 67);
            this.dataGridViewListOfPeople.Name = "dataGridViewListOfPeople";
            this.dataGridViewListOfPeople.Size = new System.Drawing.Size(235, 273);
            this.dataGridViewListOfPeople.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 93);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(12, 119);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 4;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 258);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Wyświetl";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 287);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelListOfPeople
            // 
            this.labelListOfPeople.AutoSize = true;
            this.labelListOfPeople.Location = new System.Drawing.Point(282, 37);
            this.labelListOfPeople.Name = "labelListOfPeople";
            this.labelListOfPeople.Size = new System.Drawing.Size(53, 13);
            this.labelListOfPeople.TabIndex = 7;
            this.labelListOfPeople.Text = "Lista ludzi";
            // 
            // labelGrades
            // 
            this.labelGrades.AutoSize = true;
            this.labelGrades.Location = new System.Drawing.Point(553, 37);
            this.labelGrades.Name = "labelGrades";
            this.labelGrades.Size = new System.Drawing.Size(38, 13);
            this.labelGrades.TabIndex = 8;
            this.labelGrades.Text = "Oceny";
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(466, 67);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.Size = new System.Drawing.Size(206, 273);
            this.dataGridViewGrades.TabIndex = 9;
            // 
            // textBoxGradeValue
            // 
            this.textBoxGradeValue.Location = new System.Drawing.Point(12, 146);
            this.textBoxGradeValue.Name = "textBoxGradeValue";
            this.textBoxGradeValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxGradeValue.TabIndex = 10;
            // 
            // textBoxGradeName
            // 
            this.textBoxGradeName.Location = new System.Drawing.Point(12, 173);
            this.textBoxGradeName.Name = "textBoxGradeName";
            this.textBoxGradeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGradeName.TabIndex = 11;
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(12, 200);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(100, 23);
            this.buttonAddGrade.TabIndex = 12;
            this.buttonAddGrade.Text = "Dodaj Ocenę";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // buttonShowGrade
            // 
            this.buttonShowGrade.Location = new System.Drawing.Point(12, 229);
            this.buttonShowGrade.Name = "buttonShowGrade";
            this.buttonShowGrade.Size = new System.Drawing.Size(100, 23);
            this.buttonShowGrade.TabIndex = 13;
            this.buttonShowGrade.Text = "Wyświetl ocenę";
            this.buttonShowGrade.UseVisualStyleBackColor = true;
            this.buttonShowGrade.Click += new System.EventHandler(this.buttonShowGrade_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.buttonShowGrade);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.textBoxGradeName);
            this.Controls.Add(this.textBoxGradeValue);
            this.Controls.Add(this.dataGridViewGrades);
            this.Controls.Add(this.labelGrades);
            this.Controls.Add(this.labelListOfPeople);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewListOfPeople);
            this.Controls.Add(this.labelNameSurname);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.DataGridView dataGridViewListOfPeople;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelListOfPeople;
        private System.Windows.Forms.Label labelGrades;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.TextBox textBoxGradeValue;
        private System.Windows.Forms.TextBox textBoxGradeName;
        private System.Windows.Forms.Button buttonAddGrade;
        private System.Windows.Forms.Button buttonShowGrade;
    }
}

