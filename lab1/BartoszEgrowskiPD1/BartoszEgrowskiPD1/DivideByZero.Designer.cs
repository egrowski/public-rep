namespace BartoszEgrowskiPD1
{
    partial class DivideByZero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivideByZero));
            this.pictureBoxDivideByZeroError = new System.Windows.Forms.PictureBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonWhy = new System.Windows.Forms.Button();
            this.labelDivideByZeroInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivideByZeroError)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDivideByZeroError
            // 
            this.pictureBoxDivideByZeroError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDivideByZeroError.Image")));
            this.pictureBoxDivideByZeroError.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDivideByZeroError.InitialImage")));
            this.pictureBoxDivideByZeroError.Location = new System.Drawing.Point(0, 9);
            this.pictureBoxDivideByZeroError.Name = "pictureBoxDivideByZeroError";
            this.pictureBoxDivideByZeroError.Size = new System.Drawing.Size(805, 554);
            this.pictureBoxDivideByZeroError.TabIndex = 0;
            this.pictureBoxDivideByZeroError.TabStop = false;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(226, 569);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(210, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Rozumiem, to się więcej nie powtórzy!";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonWhy
            // 
            this.buttonWhy.Location = new System.Drawing.Point(442, 569);
            this.buttonWhy.Name = "buttonWhy";
            this.buttonWhy.Size = new System.Drawing.Size(150, 23);
            this.buttonWhy.TabIndex = 2;
            this.buttonWhy.Text = "O co chodzi z tym zerem?";
            this.buttonWhy.UseVisualStyleBackColor = true;
            this.buttonWhy.Click += new System.EventHandler(this.buttonWhy_Click);
            // 
            // labelDivideByZeroInfo
            // 
            this.labelDivideByZeroInfo.AutoSize = true;
            this.labelDivideByZeroInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivideByZeroInfo.Location = new System.Drawing.Point(247, 9);
            this.labelDivideByZeroInfo.Name = "labelDivideByZeroInfo";
            this.labelDivideByZeroInfo.Size = new System.Drawing.Size(303, 24);
            this.labelDivideByZeroInfo.TabIndex = 3;
            this.labelDivideByZeroInfo.Text = "Właśnie podzieliłeś przez 0!!!";
            // 
            // DivideByZero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 598);
            this.Controls.Add(this.labelDivideByZeroInfo);
            this.Controls.Add(this.buttonWhy);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.pictureBoxDivideByZeroError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DivideByZero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Błąd!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivideByZeroError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDivideByZeroError;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonWhy;
        private System.Windows.Forms.Label labelDivideByZeroInfo;
    }
}