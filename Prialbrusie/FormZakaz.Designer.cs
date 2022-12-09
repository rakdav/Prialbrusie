namespace Prialbrusie
{
    partial class FormZakaz
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHourStart = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMinutesStart = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownMinutesFinish = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownHourFinish = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewZakaz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZakaz)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Location = new System.Drawing.Point(15, 612);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 42);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(560, 33);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(214, 29);
            this.textBoxNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата начала";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(560, 92);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(214, 29);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время начала заказа";
            // 
            // numericUpDownHourStart
            // 
            this.numericUpDownHourStart.Location = new System.Drawing.Point(560, 151);
            this.numericUpDownHourStart.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownHourStart.Name = "numericUpDownHourStart";
            this.numericUpDownHourStart.Size = new System.Drawing.Size(44, 29);
            this.numericUpDownHourStart.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // numericUpDownMinutesStart
            // 
            this.numericUpDownMinutesStart.Location = new System.Drawing.Point(628, 151);
            this.numericUpDownMinutesStart.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutesStart.Name = "numericUpDownMinutesStart";
            this.numericUpDownMinutesStart.Size = new System.Drawing.Size(54, 29);
            this.numericUpDownMinutesStart.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Клиент";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(560, 215);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(214, 32);
            this.comboBoxClient.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(560, 282);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(214, 32);
            this.comboBoxStatus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата окончания";
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(560, 349);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(214, 29);
            this.dateTimePickerFinish.TabIndex = 16;
            // 
            // numericUpDownMinutesFinish
            // 
            this.numericUpDownMinutesFinish.Location = new System.Drawing.Point(626, 407);
            this.numericUpDownMinutesFinish.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutesFinish.Name = "numericUpDownMinutesFinish";
            this.numericUpDownMinutesFinish.Size = new System.Drawing.Size(54, 29);
            this.numericUpDownMinutesFinish.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = ":";
            // 
            // numericUpDownHourFinish
            // 
            this.numericUpDownHourFinish.Location = new System.Drawing.Point(560, 408);
            this.numericUpDownHourFinish.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownHourFinish.Name = "numericUpDownHourFinish";
            this.numericUpDownHourFinish.Size = new System.Drawing.Size(44, 29);
            this.numericUpDownHourFinish.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Время окончания заказа";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(560, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 159);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(560, 612);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(214, 42);
            this.buttonPrint.TabIndex = 22;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewZakaz
            // 
            this.dataGridViewZakaz.Location = new System.Drawing.Point(13, 6);
            this.dataGridViewZakaz.Name = "dataGridViewZakaz";
            this.dataGridViewZakaz.ReadOnly = true;
            this.dataGridViewZakaz.Size = new System.Drawing.Size(541, 597);
            this.dataGridViewZakaz.TabIndex = 23;
            // 
            // FormZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 661);
            this.Controls.Add(this.dataGridViewZakaz);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownMinutesFinish);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownHourFinish);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerFinish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownMinutesStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownHourStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormZakaz";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZakaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHourStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutesStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutesFinish;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownHourFinish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridViewZakaz;
    }
}