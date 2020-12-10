namespace WindowsFormsCar
{
    partial class FormCarConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxStand = new System.Windows.Forms.CheckBox();
            this.checkBoxBackAntenna = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontLadle = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.groupBoxTypeBody = new System.Windows.Forms.GroupBox();
            this.labelCrawlerCar = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelColor8 = new System.Windows.Forms.Panel();
            this.panelColor7 = new System.Windows.Forms.Panel();
            this.panelColor6 = new System.Windows.Forms.Panel();
            this.panelColor5 = new System.Windows.Forms.Panel();
            this.panelColor4 = new System.Windows.Forms.Panel();
            this.panelColor3 = new System.Windows.Forms.Panel();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.groupBoxTypeBody.SuspendLayout();
            this.panelCar.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxStand);
            this.groupBoxParameters.Controls.Add(this.checkBoxBackAntenna);
            this.groupBoxParameters.Controls.Add(this.checkBoxFrontLadle);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(71, 219);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(342, 123);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxStand
            // 
            this.checkBoxStand.AutoSize = true;
            this.checkBoxStand.Checked = true;
            this.checkBoxStand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStand.Location = new System.Drawing.Point(223, 79);
            this.checkBoxStand.Name = "checkBoxStand";
            this.checkBoxStand.Size = new System.Drawing.Size(69, 17);
            this.checkBoxStand.TabIndex = 6;
            this.checkBoxStand.Text = "мигалка";
            this.checkBoxStand.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackAntenna
            // 
            this.checkBoxBackAntenna.AutoSize = true;
            this.checkBoxBackAntenna.Checked = true;
            this.checkBoxBackAntenna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackAntenna.Location = new System.Drawing.Point(223, 42);
            this.checkBoxBackAntenna.Name = "checkBoxBackAntenna";
            this.checkBoxBackAntenna.Size = new System.Drawing.Size(106, 17);
            this.checkBoxBackAntenna.TabIndex = 5;
            this.checkBoxBackAntenna.Text = "задняя антенна";
            this.checkBoxBackAntenna.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrontLadle
            // 
            this.checkBoxFrontLadle.AutoSize = true;
            this.checkBoxFrontLadle.Checked = true;
            this.checkBoxFrontLadle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFrontLadle.Location = new System.Drawing.Point(223, 19);
            this.checkBoxFrontLadle.Name = "checkBoxFrontLadle";
            this.checkBoxFrontLadle.Size = new System.Drawing.Size(103, 17);
            this.checkBoxFrontLadle.TabIndex = 4;
            this.checkBoxFrontLadle.Text = "передний ковш";
            this.checkBoxFrontLadle.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(150, 76);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(150, 20);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(6, 78);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(90, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес автомобиля";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 27);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(134, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Максимальная скорость";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(18, 34);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(232, 115);
            this.pictureBoxCar.TabIndex = 1;
            this.pictureBoxCar.TabStop = false;
            // 
            // groupBoxTypeBody
            // 
            this.groupBoxTypeBody.Controls.Add(this.labelCrawlerCar);
            this.groupBoxTypeBody.Controls.Add(this.labelCar);
            this.groupBoxTypeBody.Location = new System.Drawing.Point(71, 41);
            this.groupBoxTypeBody.Name = "groupBoxTypeBody";
            this.groupBoxTypeBody.Size = new System.Drawing.Size(234, 139);
            this.groupBoxTypeBody.TabIndex = 2;
            this.groupBoxTypeBody.TabStop = false;
            this.groupBoxTypeBody.Text = "Тип кузова";
            // 
            // labelCrawlerCar
            // 
            this.labelCrawlerCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCrawlerCar.Location = new System.Drawing.Point(17, 90);
            this.labelCrawlerCar.Name = "labelCrawlerCar";
            this.labelCrawlerCar.Size = new System.Drawing.Size(122, 36);
            this.labelCrawlerCar.TabIndex = 1;
            this.labelCrawlerCar.Text = "экскаватор";
            this.labelCrawlerCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCrawlertCar_MouseDown);
            // 
            // labelCar
            // 
            this.labelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCar.Location = new System.Drawing.Point(17, 33);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(122, 36);
            this.labelCar.TabIndex = 0;
            this.labelCar.Text = "обычный гусенечный автомобиль";
            this.labelCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCar_MouseDown);
            // 
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Location = new System.Drawing.Point(364, 31);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(264, 173);
            this.panelCar.TabIndex = 3;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.labelBaseColor);
            this.groupBoxColor.Controls.Add(this.panelColor8);
            this.groupBoxColor.Controls.Add(this.panelColor7);
            this.groupBoxColor.Controls.Add(this.panelColor6);
            this.groupBoxColor.Controls.Add(this.panelColor5);
            this.groupBoxColor.Controls.Add(this.panelColor4);
            this.groupBoxColor.Controls.Add(this.panelColor3);
            this.groupBoxColor.Controls.Add(this.panelColor2);
            this.groupBoxColor.Controls.Add(this.panelColor1);
            this.groupBoxColor.Location = new System.Drawing.Point(696, 31);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(215, 152);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(111, 19);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(85, 33);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(10, 21);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(87, 32);
            this.labelBaseColor.TabIndex = 8;
            this.labelBaseColor.Text = "Осн. цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelColor8
            // 
            this.panelColor8.BackColor = System.Drawing.Color.Green;
            this.panelColor8.Location = new System.Drawing.Point(157, 106);
            this.panelColor8.Name = "panelColor8";
            this.panelColor8.Size = new System.Drawing.Size(30, 30);
            this.panelColor8.TabIndex = 7;
            this.panelColor8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor7
            // 
            this.panelColor7.BackColor = System.Drawing.Color.Black;
            this.panelColor7.Location = new System.Drawing.Point(112, 106);
            this.panelColor7.Name = "panelColor7";
            this.panelColor7.Size = new System.Drawing.Size(30, 30);
            this.panelColor7.TabIndex = 6;
            this.panelColor7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor6
            // 
            this.panelColor6.BackColor = System.Drawing.Color.Fuchsia;
            this.panelColor6.Location = new System.Drawing.Point(67, 106);
            this.panelColor6.Name = "panelColor6";
            this.panelColor6.Size = new System.Drawing.Size(30, 30);
            this.panelColor6.TabIndex = 5;
            this.panelColor6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor5
            // 
            this.panelColor5.BackColor = System.Drawing.Color.Lime;
            this.panelColor5.Location = new System.Drawing.Point(22, 106);
            this.panelColor5.Name = "panelColor5";
            this.panelColor5.Size = new System.Drawing.Size(30, 30);
            this.panelColor5.TabIndex = 4;
            this.panelColor5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor4
            // 
            this.panelColor4.BackColor = System.Drawing.Color.Blue;
            this.panelColor4.Location = new System.Drawing.Point(157, 70);
            this.panelColor4.Name = "panelColor4";
            this.panelColor4.Size = new System.Drawing.Size(30, 30);
            this.panelColor4.TabIndex = 3;
            this.panelColor4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor3
            // 
            this.panelColor3.BackColor = System.Drawing.Color.Aqua;
            this.panelColor3.Location = new System.Drawing.Point(112, 70);
            this.panelColor3.Name = "panelColor3";
            this.panelColor3.Size = new System.Drawing.Size(30, 30);
            this.panelColor3.TabIndex = 2;
            this.panelColor3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.Yellow;
            this.panelColor2.Location = new System.Drawing.Point(67, 70);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(30, 30);
            this.panelColor2.TabIndex = 1;
            this.panelColor2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.Color.Red;
            this.panelColor1.Location = new System.Drawing.Point(22, 70);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(30, 30);
            this.panelColor1.TabIndex = 0;
            this.panelColor1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(826, 215);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(113, 39);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(826, 270);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 40);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.groupBoxTypeBody);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.groupBoxTypeBody.ResumeLayout(false);
            this.panelCar.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxStand;
        private System.Windows.Forms.CheckBox checkBoxBackAntenna;
        private System.Windows.Forms.CheckBox checkBoxFrontLadle;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.GroupBox groupBoxTypeBody;
        private System.Windows.Forms.Label labelCrawlerCar;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelColor8;
        private System.Windows.Forms.Panel panelColor7;
        private System.Windows.Forms.Panel panelColor6;
        private System.Windows.Forms.Panel panelColor5;
        private System.Windows.Forms.Panel panelColor4;
        private System.Windows.Forms.Panel panelColor3;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}