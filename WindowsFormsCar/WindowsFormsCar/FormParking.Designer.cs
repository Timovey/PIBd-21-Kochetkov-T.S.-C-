namespace WindowsFormsCar
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkingCar = new System.Windows.Forms.Button();
            this.buttonParkingCravelCar = new System.Windows.Forms.Button();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.labelParkingCar = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelParkingTake = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(2, -9);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(627, 458);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkingCar
            // 
            this.buttonParkingCar.Location = new System.Drawing.Point(643, 14);
            this.buttonParkingCar.Name = "buttonParkingCar";
            this.buttonParkingCar.Size = new System.Drawing.Size(142, 43);
            this.buttonParkingCar.TabIndex = 1;
            this.buttonParkingCar.Text = "припарковать автомобиль";
            this.buttonParkingCar.UseVisualStyleBackColor = true;
            this.buttonParkingCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // buttonParkingCravelCar
            // 
            this.buttonParkingCravelCar.Location = new System.Drawing.Point(643, 74);
            this.buttonParkingCravelCar.Name = "buttonParkingCravelCar";
            this.buttonParkingCravelCar.Size = new System.Drawing.Size(141, 45);
            this.buttonParkingCravelCar.TabIndex = 2;
            this.buttonParkingCravelCar.Text = "припарковать гусенечный автомобиль";
            this.buttonParkingCravelCar.UseVisualStyleBackColor = true;
            this.buttonParkingCravelCar.Click += new System.EventHandler(this.buttonSetCrawlerCar_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.buttonTakeCar);
            this.groupBoxParking.Controls.Add(this.labelParkingCar);
            this.groupBoxParking.Controls.Add(this.maskedTextBox);
            this.groupBoxParking.Controls.Add(this.labelParkingTake);
            this.groupBoxParking.Location = new System.Drawing.Point(646, 147);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(137, 97);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(22, 64);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(95, 21);
            this.buttonTakeCar.TabIndex = 3;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // labelParkingCar
            // 
            this.labelParkingCar.AutoSize = true;
            this.labelParkingCar.Location = new System.Drawing.Point(19, 35);
            this.labelParkingCar.Name = "labelParkingCar";
            this.labelParkingCar.Size = new System.Drawing.Size(42, 13);
            this.labelParkingCar.TabIndex = 2;
            this.labelParkingCar.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(88, 32);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelParkingTake
            // 
            this.labelParkingTake.AutoSize = true;
            this.labelParkingTake.Location = new System.Drawing.Point(6, 16);
            this.labelParkingTake.Name = "labelParkingTake";
            this.labelParkingTake.Size = new System.Drawing.Size(112, 13);
            this.labelParkingTake.TabIndex = 0;
            this.labelParkingTake.Text = "забрать автомобиль";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.buttonParkingCravelCar);
            this.Controls.Add(this.buttonParkingCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkingCar;
        private System.Windows.Forms.Button buttonParkingCravelCar;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.Label labelParkingCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelParkingTake;
    }
}