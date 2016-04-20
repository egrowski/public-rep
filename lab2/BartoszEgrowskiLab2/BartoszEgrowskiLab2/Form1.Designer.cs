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
            this.labelListOfPeople = new System.Windows.Forms.Label();
            this.labelGrades = new System.Windows.Forms.Label();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.textBoxGradeValue = new System.Windows.Forms.TextBox();
            this.textBoxGradeName = new System.Windows.Forms.TextBox();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelGradeName = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameSurname.Location = new System.Drawing.Point(229, 9);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(153, 24);
            this.labelNameSurname.TabIndex = 0;
            this.labelNameSurname.Text = "Bartosz Egrowski";
            // 
            // dataGridViewListOfPeople
            // 
            this.dataGridViewListOfPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfPeople.Location = new System.Drawing.Point(199, 67);
            this.dataGridViewListOfPeople.Name = "dataGridViewListOfPeople";
            this.dataGridViewListOfPeople.Size = new System.Drawing.Size(235, 202);
            this.dataGridViewListOfPeople.TabIndex = 1;
            // 
            // labelListOfPeople
            // 
            this.labelListOfPeople.AutoSize = true;
            this.labelListOfPeople.Location = new System.Drawing.Point(287, 51);
            this.labelListOfPeople.Name = "labelListOfPeople";
            this.labelListOfPeople.Size = new System.Drawing.Size(55, 13);
            this.labelListOfPeople.TabIndex = 7;
            this.labelListOfPeople.Text = "Lista osób";
            // 
            // labelGrades
            // 
            this.labelGrades.AutoSize = true;
            this.labelGrades.Location = new System.Drawing.Point(510, 51);
            this.labelGrades.Name = "labelGrades";
            this.labelGrades.Size = new System.Drawing.Size(38, 13);
            this.labelGrades.TabIndex = 8;
            this.labelGrades.Text = "Oceny";
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(440, 67);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.Size = new System.Drawing.Size(179, 202);
            this.dataGridViewGrades.TabIndex = 9;
            // 
            // textBoxGradeValue
            // 
            this.textBoxGradeValue.Location = new System.Drawing.Point(80, 161);
            this.textBoxGradeValue.Name = "textBoxGradeValue";
            this.textBoxGradeValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxGradeValue.TabIndex = 10;
            // 
            // textBoxGradeName
            // 
            this.textBoxGradeName.Location = new System.Drawing.Point(80, 187);
            this.textBoxGradeName.Name = "textBoxGradeName";
            this.textBoxGradeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGradeName.TabIndex = 11;
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(12, 213);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(168, 56);
            this.buttonAddGrade.TabIndex = 12;
            this.buttonAddGrade.Text = "Dodaj Ocenę";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(12, 164);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(39, 13);
            this.labelGrade.TabIndex = 17;
            this.labelGrade.Text = "Ocena";
            // 
            // labelGradeName
            // 
            this.labelGradeName.AutoSize = true;
            this.labelGradeName.Location = new System.Drawing.Point(12, 190);
            this.labelGradeName.Name = "labelGradeName";
            this.labelGradeName.Size = new System.Drawing.Size(60, 13);
            this.labelGradeName.TabIndex = 18;
            this.labelGradeName.Text = "Ocena (sł.)";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(12, 67);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(168, 56);
            this.buttonAddPerson.TabIndex = 19;
            this.buttonAddPerson.Text = "Dodaj osobę";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave,
            this.toolStripMenuItemLoad});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItemFile.Text = "Plik";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemSave.Text = "Zapisz";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemLoad.Text = "Wczytaj";
            this.toolStripMenuItemLoad.Click += new System.EventHandler(this.toolStripMenuItemLoad_Click);
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.Location = new System.Drawing.Point(12, 126);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(132, 29);
            this.labelAdditionalInfo.TabIndex = 21;
            this.labelAdditionalInfo.Text = "Wybierz osobę której chcesz przypisać ocenę!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 276);
            this.Controls.Add(this.labelAdditionalInfo);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.labelGradeName);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.textBoxGradeName);
            this.Controls.Add(this.textBoxGradeValue);
            this.Controls.Add(this.dataGridViewGrades);
            this.Controls.Add(this.labelGrades);
            this.Controls.Add(this.labelListOfPeople);
            this.Controls.Add(this.dataGridViewListOfPeople);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Label labelListOfPeople;
        private System.Windows.Forms.Label labelGrades;
        private System.Windows.Forms.TextBox textBoxGradeValue;
        private System.Windows.Forms.TextBox textBoxGradeName;
        private System.Windows.Forms.Button buttonAddGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelGradeName;
        private System.Windows.Forms.Button buttonAddPerson;
        public System.Windows.Forms.DataGridView dataGridViewListOfPeople;
        public System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoad;
        private System.Windows.Forms.Label labelAdditionalInfo;
    }
}

