namespace BartoszEgrowskiPD2
{
    partial class AddData
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDraftsman = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelDescritpion = new System.Windows.Forms.Label();
            this.textBoxDraftsman = new System.Windows.Forms.TextBox();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelAdditionalInformation = new System.Windows.Forms.Label();
            this.buttonAddCover = new System.Windows.Forms.Button();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(317, 207);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "OK";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(399, 207);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(91, 15);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(173, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(91, 41);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(173, 20);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(91, 123);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(383, 78);
            this.textBoxDescription.TabIndex = 4;
            // 
            // labelDraftsman
            // 
            this.labelDraftsman.AutoSize = true;
            this.labelDraftsman.Location = new System.Drawing.Point(272, 17);
            this.labelDraftsman.Name = "labelDraftsman";
            this.labelDraftsman.Size = new System.Drawing.Size(57, 13);
            this.labelDraftsman.TabIndex = 7;
            this.labelDraftsman.Text = "*Rysownik";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 44);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(32, 13);
            this.labelAuthor.TabIndex = 8;
            this.labelAuthor.Text = "Autor";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(32, 13);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Tytuł";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(12, 71);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(39, 13);
            this.labelRating.TabIndex = 11;
            this.labelRating.Text = "Ocena";
            // 
            // labelDescritpion
            // 
            this.labelDescritpion.AutoSize = true;
            this.labelDescritpion.Location = new System.Drawing.Point(12, 123);
            this.labelDescritpion.Name = "labelDescritpion";
            this.labelDescritpion.Size = new System.Drawing.Size(28, 13);
            this.labelDescritpion.TabIndex = 12;
            this.labelDescritpion.Text = "Opis";
            // 
            // textBoxDraftsman
            // 
            this.textBoxDraftsman.Location = new System.Drawing.Point(352, 15);
            this.textBoxDraftsman.Name = "textBoxDraftsman";
            this.textBoxDraftsman.Size = new System.Drawing.Size(100, 20);
            this.textBoxDraftsman.TabIndex = 13;
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Items.AddRange(new object[] {
            "Marvel",
            "DC",
            "Dark Horse",
            "Image",
            "Valiant"});
            this.comboBoxPublisher.Location = new System.Drawing.Point(352, 40);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPublisher.TabIndex = 14;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Czarno biały",
            "Kolorowy"});
            this.comboBoxColor.Location = new System.Drawing.Point(352, 67);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 15;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(272, 43);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(78, 13);
            this.labelPublisher.TabIndex = 16;
            this.labelPublisher.Text = "*Wydawnictwo";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(272, 69);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(35, 13);
            this.labelColor.TabIndex = 17;
            this.labelColor.Text = "*Kolor";
            // 
            // labelAdditionalInformation
            // 
            this.labelAdditionalInformation.AutoSize = true;
            this.labelAdditionalInformation.Location = new System.Drawing.Point(12, 212);
            this.labelAdditionalInformation.Name = "labelAdditionalInformation";
            this.labelAdditionalInformation.Size = new System.Drawing.Size(134, 13);
            this.labelAdditionalInformation.TabIndex = 18;
            this.labelAdditionalInformation.Text = "* - dotyczy tylko komiksów!";
            // 
            // buttonAddCover
            // 
            this.buttonAddCover.Location = new System.Drawing.Point(91, 94);
            this.buttonAddCover.Name = "buttonAddCover";
            this.buttonAddCover.Size = new System.Drawing.Size(121, 23);
            this.buttonAddCover.TabIndex = 19;
            this.buttonAddCover.Text = "Dodaj okładkę";
            this.buttonAddCover.UseVisualStyleBackColor = true;
            this.buttonAddCover.Click += new System.EventHandler(this.buttonAddCover_Click);
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0",
            "6.5",
            "7.0",
            "7.5",
            "8.0",
            "8.5",
            "9.0",
            "9.5",
            "10"});
            this.comboBoxRating.Location = new System.Drawing.Point(91, 67);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(55, 21);
            this.comboBoxRating.TabIndex = 21;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 235);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.buttonAddCover);
            this.Controls.Add(this.labelAdditionalInformation);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxPublisher);
            this.Controls.Add(this.textBoxDraftsman);
            this.Controls.Add(this.labelDescritpion);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelDraftsman);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Name = "AddData";
            this.Text = "Dodaj książkę lub komiks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDraftsman;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelDescritpion;
        private System.Windows.Forms.TextBox textBoxDraftsman;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelAdditionalInformation;
        private System.Windows.Forms.Button buttonAddCover;
        private System.Windows.Forms.ComboBox comboBoxRating;
    }
}