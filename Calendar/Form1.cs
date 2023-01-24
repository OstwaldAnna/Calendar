using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {

        private List<Holiday> holidays = new List<Holiday>();
        private List<Reminder> remiders = new List<Reminder>();

        public Form1()
        {
            holidays = GetSomeHoliday();
            remiders = GetSomeRemider();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBDate.Text = DateTime.Now.ToString("d");
            LBDayOfTheWeek.Text = DateTime.Now.ToString("dddd");
            LBTime.Text = LBDate.Text = DateTime.Now.ToString("T");

            DGHoliday.DataSource = holidays.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
            DGHoliday.Columns["Class"].Visible = false;
            DGRemider.DataSource = remiders.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
            DGRemider.Columns["Class"].Visible = false;

            FillListBoxes();
        }

        private List<Holiday> GetSomeHoliday()
        {
            var list = new List<Holiday>();
            list.Add(new Holiday("Новый год", new DateTime(2023, 12, 31)));
            list.Add(new Holiday("1ое сентебря", new DateTime(2023, 9, 1)));
            list.Add(new Holiday("1ое сентебря", new DateTime(2023, 1, 24)));

            return list;
        }

        private List<Reminder> GetSomeRemider()
        {
            var list = new List<Reminder>();
            list.Add(new Reminder("Начать делать салаты к НГ", new DateTime(2023, 12, 31, 16, 00, 00)));
            list.Add(new Reminder("Завтра 1 сентебря", new DateTime(2023, 9, 1, 21, 00, 00)));
            list.Add(new Reminder("Завтра 1 сентебря", new DateTime(2023, 9, 1, 21, 00, 00)));

            return list;
        }

        private void BtnAddHoliday_Click(object sender, EventArgs e)
        {
            var holiday = new Holiday(TBHName.Text, Convert.ToDateTime(TBHDate.Text));
            holidays.Add(holiday);
            DGHoliday.DataSource = holidays.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
            FillListBoxes();
        }

        private void BtnChangeHoliday_Click(object sender, EventArgs e)
        {
            Holiday SelectedClass = (Holiday)DGHoliday.SelectedRows[0].Cells[2].Value;
            foreach (var holiday in holidays)
            {
                if (SelectedClass != null && holiday == SelectedClass)
                {
                    holiday.Name = TBHNameR.Text;
                    holiday.Date = Convert.ToDateTime(TBHDateR.Text);
                    DGHoliday.DataSource = holidays.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
                    break;
                }
            }
            FillListBoxes();
        }

        private void BtnDeleteHoliday_Click(object sender, EventArgs e)
        {
            Holiday SelectedClass = (Holiday)DGHoliday.SelectedRows[0].Cells[2].Value;
            foreach (var holiday in holidays)
            {
                if (SelectedClass != null && holiday == SelectedClass)
                {
                    holidays.Remove(holiday);
                    DGHoliday.DataSource = holidays.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
                    break;
                }
            }
            FillListBoxes();
        }

        private void BtnAddRemider_Click(object sender, EventArgs e)
        {
            string[] SubStr1 = TBRDate.Text.Split('.');
            string[] SubStr2 = TBRTime.Text.Split(':');
            DateTime NewTime = new DateTime(Convert.ToInt32(SubStr1[2]), Convert.ToInt32(SubStr1[1]), Convert.ToInt32(SubStr1[0]),
                Convert.ToInt32(SubStr2[0]), Convert.ToInt32(SubStr2[1]), Convert.ToInt32(SubStr2[2]));
            var reminder = new Reminder(TBRName.Text, NewTime);
            remiders.Add(reminder);
            DGRemider.DataSource = remiders.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
            FillListBoxes();
        }

        private void BtnChangeRemider_Click(object sender, EventArgs e)
        {
            Reminder SelectedClass = (Reminder)DGRemider.SelectedRows[0].Cells[2].Value;
            foreach (var reminder in remiders)
            {
                if (SelectedClass != null && reminder == SelectedClass)
                {
                    reminder.Name = TBRNameR.Text;
                    string[] SubStr1 = TBRDateR.Text.Split('.');
                    string[] SubStr2 = TBRTimeR.Text.Split(':');
                    DateTime NewTime = new DateTime(Convert.ToInt32(SubStr1[2]), Convert.ToInt32(SubStr1[1]), Convert.ToInt32(SubStr1[0]),
                        Convert.ToInt32(SubStr2[0]), Convert.ToInt32(SubStr2[1]), Convert.ToInt32(SubStr2[2]));
                    reminder.Date = Convert.ToDateTime(NewTime);
                    DGRemider.DataSource = remiders.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
                    break;
                }
            }
            FillListBoxes();
        }

        private void BtnDeleteRemider_Click(object sender, EventArgs e)
        {
            Reminder SelectedClass = (Reminder)DGRemider.SelectedRows[0].Cells[2].Value;
            foreach (var reminder in remiders)
            {
                if (SelectedClass != null && reminder == SelectedClass)
                {
                    remiders.Remove(reminder);
                    DGRemider.DataSource = remiders.ConvertAll(x => new { Name = x.Name, Date = x.Date, Class = x });
                    break;
                }
            }
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            LBHolidays.Items.Clear();
            LBReminder.Items.Clear();

            // заполнить листбокс праздников на сегодня
            foreach (var holiday in holidays)
            {
                if (holiday.Date.Day == DateTime.Now.Day)
                {
                    LBHolidays.Items.Add(holiday.Name + "  " + holiday.Date.ToString("d"));
                }
            }

            // заполнить листбокс напоминаний на сегодня
            foreach (var reminder in remiders)
            {
                if (reminder.Date.Day == DateTime.Now.Day)
                {
                    LBReminder.Items.Add(reminder.Name + "  " + reminder.Date.ToString());
                }
            }
        }
    }
}
