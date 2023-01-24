namespace Calendar
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBDayOfTheWeek = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBTime = new System.Windows.Forms.Label();
            this.DGHoliday = new System.Windows.Forms.DataGridView();
            this.DGRemider = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TBHName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBHDate = new System.Windows.Forms.TextBox();
            this.BtnAddHoliday = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnChangeHoliday = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TBHDateR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBHNameR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDeleteHoliday = new System.Windows.Forms.Button();
            this.BtnDeleteRemider = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnChangeRemider = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TBRDateR = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TBRNameR = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnAddRemider = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.TBRDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TBRName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TBRTime = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TBRTimeR = new System.Windows.Forms.TextBox();
            this.LBHolidays = new System.Windows.Forms.ListBox();
            this.LBReminder = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGRemider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // LBDate
            // 
            this.LBDate.AutoSize = true;
            this.LBDate.Location = new System.Drawing.Point(56, 13);
            this.LBDate.Name = "LBDate";
            this.LBDate.Size = new System.Drawing.Size(61, 13);
            this.LBDate.TabIndex = 1;
            this.LBDate.Text = "07.12.2001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "День недели: ";
            // 
            // LBDayOfTheWeek
            // 
            this.LBDayOfTheWeek.AutoSize = true;
            this.LBDayOfTheWeek.Location = new System.Drawing.Point(209, 13);
            this.LBDayOfTheWeek.Name = "LBDayOfTheWeek";
            this.LBDayOfTheWeek.Size = new System.Drawing.Size(75, 13);
            this.LBDayOfTheWeek.TabIndex = 3;
            this.LBDayOfTheWeek.Text = "Понедельник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Время:";
            // 
            // LBTime
            // 
            this.LBTime.AutoSize = true;
            this.LBTime.Location = new System.Drawing.Point(341, 13);
            this.LBTime.Name = "LBTime";
            this.LBTime.Size = new System.Drawing.Size(49, 13);
            this.LBTime.TabIndex = 5;
            this.LBTime.Text = "18:23:04";
            // 
            // DGHoliday
            // 
            this.DGHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGHoliday.Location = new System.Drawing.Point(12, 127);
            this.DGHoliday.MultiSelect = false;
            this.DGHoliday.Name = "DGHoliday";
            this.DGHoliday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGHoliday.Size = new System.Drawing.Size(240, 150);
            this.DGHoliday.TabIndex = 6;
            // 
            // DGRemider
            // 
            this.DGRemider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRemider.Location = new System.Drawing.Point(12, 339);
            this.DGRemider.MultiSelect = false;
            this.DGRemider.Name = "DGRemider";
            this.DGRemider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGRemider.Size = new System.Drawing.Size(240, 150);
            this.DGRemider.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Создать праздник";
            // 
            // TBHName
            // 
            this.TBHName.Location = new System.Drawing.Point(357, 146);
            this.TBHName.Name = "TBHName";
            this.TBHName.Size = new System.Drawing.Size(100, 20);
            this.TBHName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Название:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 175);
            this.label6.MaximumSize = new System.Drawing.Size(80, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата(формат 01.01.2001): ";
            // 
            // TBHDate
            // 
            this.TBHDate.Location = new System.Drawing.Point(358, 172);
            this.TBHDate.Name = "TBHDate";
            this.TBHDate.Size = new System.Drawing.Size(100, 20);
            this.TBHDate.TabIndex = 11;
            // 
            // BtnAddHoliday
            // 
            this.BtnAddHoliday.Location = new System.Drawing.Point(276, 204);
            this.BtnAddHoliday.Name = "BtnAddHoliday";
            this.BtnAddHoliday.Size = new System.Drawing.Size(75, 23);
            this.BtnAddHoliday.TabIndex = 13;
            this.BtnAddHoliday.Text = "Создать";
            this.BtnAddHoliday.UseVisualStyleBackColor = true;
            this.BtnAddHoliday.Click += new System.EventHandler(this.BtnAddHoliday_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выбирете строку и измените данные";
            // 
            // BtnChangeHoliday
            // 
            this.BtnChangeHoliday.Location = new System.Drawing.Point(506, 204);
            this.BtnChangeHoliday.Name = "BtnChangeHoliday";
            this.BtnChangeHoliday.Size = new System.Drawing.Size(75, 23);
            this.BtnChangeHoliday.TabIndex = 19;
            this.BtnChangeHoliday.Text = "Изменить";
            this.BtnChangeHoliday.UseVisualStyleBackColor = true;
            this.BtnChangeHoliday.Click += new System.EventHandler(this.BtnChangeHoliday_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 175);
            this.label9.MaximumSize = new System.Drawing.Size(80, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата(формат 01.01.2001): ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TBHDateR
            // 
            this.TBHDateR.Location = new System.Drawing.Point(588, 172);
            this.TBHDateR.Name = "TBHDateR";
            this.TBHDateR.Size = new System.Drawing.Size(100, 20);
            this.TBHDateR.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Название:";
            // 
            // TBHNameR
            // 
            this.TBHNameR.Location = new System.Drawing.Point(588, 146);
            this.TBHNameR.Name = "TBHNameR";
            this.TBHNameR.Size = new System.Drawing.Size(100, 20);
            this.TBHNameR.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(721, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Выбирете строку и удалите праздник";
            // 
            // BtnDeleteHoliday
            // 
            this.BtnDeleteHoliday.Location = new System.Drawing.Point(724, 149);
            this.BtnDeleteHoliday.Name = "BtnDeleteHoliday";
            this.BtnDeleteHoliday.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteHoliday.TabIndex = 21;
            this.BtnDeleteHoliday.Text = "Удалить";
            this.BtnDeleteHoliday.UseVisualStyleBackColor = true;
            this.BtnDeleteHoliday.Click += new System.EventHandler(this.BtnDeleteHoliday_Click);
            // 
            // BtnDeleteRemider
            // 
            this.BtnDeleteRemider.Location = new System.Drawing.Point(724, 361);
            this.BtnDeleteRemider.Name = "BtnDeleteRemider";
            this.BtnDeleteRemider.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteRemider.TabIndex = 35;
            this.BtnDeleteRemider.Text = "Удалить";
            this.BtnDeleteRemider.UseVisualStyleBackColor = true;
            this.BtnDeleteRemider.Click += new System.EventHandler(this.BtnDeleteRemider_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(721, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Выбирете строку и удалите напоминание";
            // 
            // BtnChangeRemider
            // 
            this.BtnChangeRemider.Location = new System.Drawing.Point(509, 456);
            this.BtnChangeRemider.Name = "BtnChangeRemider";
            this.BtnChangeRemider.Size = new System.Drawing.Size(75, 23);
            this.BtnChangeRemider.TabIndex = 33;
            this.BtnChangeRemider.Text = "Изменить";
            this.BtnChangeRemider.UseVisualStyleBackColor = true;
            this.BtnChangeRemider.Click += new System.EventHandler(this.BtnChangeRemider_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(506, 387);
            this.label12.MaximumSize = new System.Drawing.Size(80, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "Дата(формат 01.01.2001): ";
            // 
            // TBRDateR
            // 
            this.TBRDateR.Location = new System.Drawing.Point(602, 384);
            this.TBRDateR.Name = "TBRDateR";
            this.TBRDateR.Size = new System.Drawing.Size(100, 20);
            this.TBRDateR.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(506, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Название:";
            // 
            // TBRNameR
            // 
            this.TBRNameR.Location = new System.Drawing.Point(602, 358);
            this.TBRNameR.Name = "TBRNameR";
            this.TBRNameR.Size = new System.Drawing.Size(100, 20);
            this.TBRNameR.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Выбирете строку и измените данные";
            // 
            // BtnAddRemider
            // 
            this.BtnAddRemider.Location = new System.Drawing.Point(279, 456);
            this.BtnAddRemider.Name = "BtnAddRemider";
            this.BtnAddRemider.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRemider.TabIndex = 27;
            this.BtnAddRemider.Text = "Создать";
            this.BtnAddRemider.UseVisualStyleBackColor = true;
            this.BtnAddRemider.Click += new System.EventHandler(this.BtnAddRemider_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(277, 387);
            this.label15.MaximumSize = new System.Drawing.Size(80, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 26);
            this.label15.TabIndex = 26;
            this.label15.Text = "Дата(формат 01.01.2001): ";
            // 
            // TBRDate
            // 
            this.TBRDate.Location = new System.Drawing.Point(361, 384);
            this.TBRDate.Name = "TBRDate";
            this.TBRDate.Size = new System.Drawing.Size(100, 20);
            this.TBRDate.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Название:";
            // 
            // TBRName
            // 
            this.TBRName.Location = new System.Drawing.Point(360, 358);
            this.TBRName.Name = "TBRName";
            this.TBRName.Size = new System.Drawing.Size(100, 20);
            this.TBRName.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(273, 339);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Создать напоминание";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(276, 416);
            this.label18.MaximumSize = new System.Drawing.Size(85, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 26);
            this.label18.TabIndex = 37;
            this.label18.Text = "Время(формат 01:01:01): ";
            // 
            // TBRTime
            // 
            this.TBRTime.Location = new System.Drawing.Point(361, 416);
            this.TBRTime.Name = "TBRTime";
            this.TBRTime.Size = new System.Drawing.Size(100, 20);
            this.TBRTime.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(509, 416);
            this.label19.MaximumSize = new System.Drawing.Size(85, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 26);
            this.label19.TabIndex = 39;
            this.label19.Text = "Время(формат 01:01:01): ";
            // 
            // TBRTimeR
            // 
            this.TBRTimeR.Location = new System.Drawing.Point(602, 413);
            this.TBRTimeR.Name = "TBRTimeR";
            this.TBRTimeR.Size = new System.Drawing.Size(100, 20);
            this.TBRTimeR.TabIndex = 38;
            // 
            // LBHolidays
            // 
            this.LBHolidays.FormattingEnabled = true;
            this.LBHolidays.Location = new System.Drawing.Point(525, 13);
            this.LBHolidays.Name = "LBHolidays";
            this.LBHolidays.Size = new System.Drawing.Size(197, 95);
            this.LBHolidays.TabIndex = 40;
            // 
            // LBReminder
            // 
            this.LBReminder.FormattingEnabled = true;
            this.LBReminder.Location = new System.Drawing.Point(870, 12);
            this.LBReminder.Name = "LBReminder";
            this.LBReminder.Size = new System.Drawing.Size(197, 95);
            this.LBReminder.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(397, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Праздники на сегодня";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(728, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Напоминания на сегодня";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 508);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.LBReminder);
            this.Controls.Add(this.LBHolidays);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TBRTimeR);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TBRTime);
            this.Controls.Add(this.BtnDeleteRemider);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnChangeRemider);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TBRDateR);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TBRNameR);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnAddRemider);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TBRDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TBRName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BtnDeleteHoliday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnChangeHoliday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBHDateR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBHNameR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAddHoliday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBHDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBHName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGRemider);
            this.Controls.Add(this.DGHoliday);
            this.Controls.Add(this.LBTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBDayOfTheWeek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGRemider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBDayOfTheWeek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBTime;
        private System.Windows.Forms.DataGridView DGHoliday;
        private System.Windows.Forms.DataGridView DGRemider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBHName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBHDate;
        private System.Windows.Forms.Button BtnAddHoliday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnChangeHoliday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBHDateR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBHNameR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDeleteHoliday;
        private System.Windows.Forms.Button BtnDeleteRemider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnChangeRemider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBRDateR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBRNameR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnAddRemider;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBRDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TBRName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TBRTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TBRTimeR;
        private System.Windows.Forms.ListBox LBHolidays;
        private System.Windows.Forms.ListBox LBReminder;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

