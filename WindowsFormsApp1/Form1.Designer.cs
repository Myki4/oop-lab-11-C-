namespace VehicleApp
{
    partial class Form1
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
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelPassengers = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPassengers = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonCreateVehicle = new System.Windows.Forms.Button();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Location = new System.Drawing.Point(127, 45);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVehicleType.TabIndex = 0;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(134, 155);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(83, 16);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "Рік випуску";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(163, 89);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 16);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Ціна";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(144, 125);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(73, 16);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "Швидкість";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(223, 89);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(223, 125);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeed.TabIndex = 5;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(223, 155);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 22);
            this.textBoxYear.TabIndex = 6;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(144, 187);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(54, 16);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Висота";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(223, 187);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 8;
            // 
            // labelPassengers
            // 
            this.labelPassengers.AutoSize = true;
            this.labelPassengers.Location = new System.Drawing.Point(144, 218);
            this.labelPassengers.Name = "labelPassengers";
            this.labelPassengers.Size = new System.Drawing.Size(73, 16);
            this.labelPassengers.TabIndex = 9;
            this.labelPassengers.Text = "Пасажири";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(144, 252);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 16);
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "Порт";
            // 
            // textBoxPassengers
            // 
            this.textBoxPassengers.Location = new System.Drawing.Point(223, 218);
            this.textBoxPassengers.Name = "textBoxPassengers";
            this.textBoxPassengers.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassengers.TabIndex = 11;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(223, 252);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 22);
            this.textBoxPort.TabIndex = 12;
            // 
            // buttonCreateVehicle
            // 
            this.buttonCreateVehicle.Location = new System.Drawing.Point(127, 280);
            this.buttonCreateVehicle.Name = "buttonCreateVehicle";
            this.buttonCreateVehicle.Size = new System.Drawing.Size(158, 26);
            this.buttonCreateVehicle.TabIndex = 13;
            this.buttonCreateVehicle.Text = "Створити транспорт";
            this.buttonCreateVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateVehicle.Click += new System.EventHandler(this.buttonCreateVehicle_Click);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(127, 324);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(158, 23);
            this.buttonShowInfo.TabIndex = 14;
            this.buttonShowInfo.Text = "Показати інформацію";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(127, 373);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(554, 52);
            this.textBoxOutput.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.buttonCreateVehicle);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxPassengers);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelPassengers);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboBoxVehicleType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelPassengers;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPassengers;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonCreateVehicle;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

