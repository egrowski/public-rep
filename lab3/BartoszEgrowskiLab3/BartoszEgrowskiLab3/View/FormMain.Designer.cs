namespace BartoszEgrowskiLab3
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
            this.dataGridViewComputerService = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonGetAllEmployees = new System.Windows.Forms.Button();
            this.buttonGetAllComputers = new System.Windows.Forms.Button();
            this.buttonGetAllServices = new System.Windows.Forms.Button();
            this.buttonGetAllClients = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonGetHighCostServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputerService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComputerService
            // 
            this.dataGridViewComputerService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComputerService.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewComputerService.Name = "dataGridViewComputerService";
            this.dataGridViewComputerService.Size = new System.Drawing.Size(466, 274);
            this.dataGridViewComputerService.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(118, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(246, 32);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Bartosz Egrowski";
            // 
            // buttonGetAllEmployees
            // 
            this.buttonGetAllEmployees.Location = new System.Drawing.Point(354, 337);
            this.buttonGetAllEmployees.Name = "buttonGetAllEmployees";
            this.buttonGetAllEmployees.Size = new System.Drawing.Size(124, 23);
            this.buttonGetAllEmployees.TabIndex = 2;
            this.buttonGetAllEmployees.Text = "Wyświetl pracowników";
            this.buttonGetAllEmployees.UseVisualStyleBackColor = true;
            this.buttonGetAllEmployees.Click += new System.EventHandler(this.buttonGetAllEmployees_Click);
            // 
            // buttonGetAllComputers
            // 
            this.buttonGetAllComputers.Location = new System.Drawing.Point(239, 337);
            this.buttonGetAllComputers.Name = "buttonGetAllComputers";
            this.buttonGetAllComputers.Size = new System.Drawing.Size(109, 23);
            this.buttonGetAllComputers.TabIndex = 3;
            this.buttonGetAllComputers.Text = "Wyświetl komputery";
            this.buttonGetAllComputers.UseVisualStyleBackColor = true;
            this.buttonGetAllComputers.Click += new System.EventHandler(this.buttonGetAllComputers_Click);
            // 
            // buttonGetAllServices
            // 
            this.buttonGetAllServices.Location = new System.Drawing.Point(12, 337);
            this.buttonGetAllServices.Name = "buttonGetAllServices";
            this.buttonGetAllServices.Size = new System.Drawing.Size(112, 23);
            this.buttonGetAllServices.TabIndex = 4;
            this.buttonGetAllServices.Text = "Wyświetl naprawy";
            this.buttonGetAllServices.UseVisualStyleBackColor = true;
            this.buttonGetAllServices.Click += new System.EventHandler(this.buttonGetAllServices_Click);
            // 
            // buttonGetAllClients
            // 
            this.buttonGetAllClients.Location = new System.Drawing.Point(124, 337);
            this.buttonGetAllClients.Name = "buttonGetAllClients";
            this.buttonGetAllClients.Size = new System.Drawing.Size(109, 23);
            this.buttonGetAllClients.TabIndex = 5;
            this.buttonGetAllClients.Text = "Wyświetl klientów";
            this.buttonGetAllClients.UseVisualStyleBackColor = true;
            this.buttonGetAllClients.Click += new System.EventHandler(this.buttonGetAllClients_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(203, 368);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(145, 20);
            this.textBoxPrice.TabIndex = 6;
            // 
            // buttonGetHighCostServices
            // 
            this.buttonGetHighCostServices.Location = new System.Drawing.Point(12, 366);
            this.buttonGetHighCostServices.Name = "buttonGetHighCostServices";
            this.buttonGetHighCostServices.Size = new System.Drawing.Size(185, 23);
            this.buttonGetHighCostServices.TabIndex = 7;
            this.buttonGetHighCostServices.Text = "Wyświetl naprawy droższe niż:";
            this.buttonGetHighCostServices.UseVisualStyleBackColor = true;
            this.buttonGetHighCostServices.Click += new System.EventHandler(this.buttonGetHighCostServices_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 394);
            this.Controls.Add(this.buttonGetHighCostServices);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonGetAllClients);
            this.Controls.Add(this.buttonGetAllServices);
            this.Controls.Add(this.buttonGetAllComputers);
            this.Controls.Add(this.buttonGetAllEmployees);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewComputerService);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputerService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.DataGridView dataGridViewComputerService;
        private System.Windows.Forms.Button buttonGetAllEmployees;
        private System.Windows.Forms.Button buttonGetAllComputers;
        private System.Windows.Forms.Button buttonGetAllServices;
        private System.Windows.Forms.Button buttonGetAllClients;
        private System.Windows.Forms.Button buttonGetHighCostServices;
        public System.Windows.Forms.TextBox textBoxPrice;
    }
}

