namespace BartoszEgrowskiLab1
{
    partial class FormNewWindow
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxDraw = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(21, 21);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(85, 35);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Wyświetl";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(156, 30);
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(100, 26);
            this.textBoxShow.TabIndex = 1;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(21, 105);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(82, 35);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Rysuj";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxDraw
            // 
            this.textBoxDraw.Location = new System.Drawing.Point(156, 105);
            this.textBoxDraw.Multiline = true;
            this.textBoxDraw.Name = "textBoxDraw";
            this.textBoxDraw.Size = new System.Drawing.Size(418, 250);
            this.textBoxDraw.TabIndex = 3;
            this.textBoxDraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(632, 358);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(99, 32);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormNewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 402);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxDraw);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.buttonShow);
            this.Name = "FormNewWindow";
            this.Text = "Nowe okno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxDraw;
        private System.Windows.Forms.Button buttonClose;
    }
}