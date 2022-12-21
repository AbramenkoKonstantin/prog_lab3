using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static Prog_lab3.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prog_lab3
{
    public partial class Form1 : Form
    {
        public static GregorianCalendar calendar = new GregorianCalendar(GregorianCalendarTypes.Localized);
        public Form1()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            startDate.Text = today.ToString("d");
            dateFormat1.Text = today.ToString("d");
            dateFormat2.Text = today.ToString("g");
            dateFormat3.Text = today.ToString("s");
            dateFormat4.Text = today.ToString("f");
        }

        private void StartButton(object sender, EventArgs e)
        {
            try
            {
                int dataDays = Convert.ToInt32(dataTB.Text);
                if (plusRB.Checked == true)
                {
                    result.Text = AddDays(startDate.Text, dataDays);
                }
                if (minusRB.Checked == true)
                {
                    result.Text = SubstructDays(startDate.Text, dataDays);
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели слишком большое число");
            }
        }

        private void EqulityStartButton(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(dateForEquality.Text) == false)
                {
                    string[] startDateStr = startDate.Text.Trim().Split('.');
                    if (equalityRB.Checked == true)
                    {
                        equalityResult.Text = EqulityDate(startDate.Text, dateForEquality.Text);
                    }
                    else if (unEqualityRB.Checked == true)
                    {
                        equalityResult.Text = UnEqulityDate(startDate.Text, dateForEquality.Text);
                    }
                    else
                    {
                        MessageBox.Show("Выберите операцию сравнения");
                    }
                }
                else
                {
                    MessageBox.Show("Введите дату для сравнения");
                }
            }
            catch
            {
                string[] startDateStr = startDate.Text.Trim().Split('.');
                int isEndOfMonth = calendar.GetDaysInMonth(int.Parse(startDateStr[2]), int.Parse(startDateStr[1]));
                string[] dateForEqualityStr = dateForEquality.Text.Trim().Split('.');
                if (dateForEqualityStr.Length < 3)
                {
                    MessageBox.Show("Дата введена в неверном формате");
                }
                else
                {
                    if (int.Parse(dateForEqualityStr[0]) > isEndOfMonth || int.Parse(dateForEqualityStr[0]) == 0)
                    {
                        MessageBox.Show("День введен неверно");
                    }
                    int.TryParse(dateForEqualityStr[1], out int resultMonth);
                    if (resultMonth > 12 || resultMonth == 0)
                    {
                        MessageBox.Show("Месяц введен неверно");
                    }
                    int.TryParse(dateForEqualityStr[2], out int resultYear);
                    if (resultYear == 0)
                    {
                        MessageBox.Show("Год введен неверно");
                    }
                }
            }
        }

        public class Date
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public Date(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public static string operator +(Date startDate, int daysToSum)
            {
                int isEndOfMonth = calendar.GetDaysInMonth(startDate.Year, startDate.Month);
                for (int i = 0; i < daysToSum; ++i)
                    if (startDate.Day < isEndOfMonth)
                    {
                        startDate.Day++;
                    }
                    else
                    {
                        if (startDate.Month == 12)
                        {
                            startDate.Year++;
                            startDate.Month = 1;
                        }
                        else startDate.Month++;
                        startDate.Day = 1;
                        isEndOfMonth = calendar.GetDaysInMonth(startDate.Year, startDate.Month);
                    };
                return new DateTime(startDate.Year, startDate.Month, startDate.Day).ToString("d");
            }

            public static string operator -(Date startDate, int daysToSubtract)
            {
                for (int i = daysToSubtract; i != 0; --i)
                    if (startDate.Day != 1) startDate.Day--;
                    else
                    {
                        if (startDate.Month != 1) startDate.Month--;
                        else
                        {
                            startDate.Year--;
                            startDate.Month = 12;
                        };
                        startDate.Day = calendar.GetDaysInMonth(startDate.Year, startDate.Month);
                    }
                return new DateTime(startDate.Year, startDate.Month, startDate.Day).ToString("d");
            }

            public static bool operator ==(Date startDate, Date dateToCompate)
            {
                if (startDate.Year != dateToCompate.Year || startDate.Month != dateToCompate.Month || startDate.Day != dateToCompate.Day)
                {
                    return false;
                }
                return true;
            }

            public static bool operator !=(Date startDate, Date dateToCompate)
            {
                if (startDate.Year != dateToCompate.Year || startDate.Month != dateToCompate.Month || startDate.Day != dateToCompate.Day)
                {
                    return true;
                }
                return false;
            }

            public override bool Equals(object obj)
            {
                return obj is Date date &&
                       Year == date.Year &&
                       Month == date.Month &&
                       Day == date.Day;
            }

            public override int GetHashCode()
            {
                int hashCode = 308839189;
                hashCode = hashCode * -1521134295 + Year.GetHashCode();
                hashCode = hashCode * -1521134295 + Month.GetHashCode();
                hashCode = hashCode * -1521134295 + Day.GetHashCode();
                return hashCode;
            }
        }

        static Date StrToDate(string date)
        {
            string[] partsOfDate = date.Trim().Split('.');
            int[] parts = new int[3];
            for (int index = 0; index < 3; index++)
            {
                parts[index] = int.Parse(partsOfDate[index]);
            }
            int isEndOfMonth = calendar.GetDaysInMonth(parts[2], parts[1]);
            if (parts[0] == 0 || parts[0] > isEndOfMonth)
            {
                throw new Exception();
            }
            if (parts[1] == 0 || parts[1] > 12)
            {
                throw new Exception();
            }
            if (parts[2] == 0)
            {
                throw new Exception();
            }
            return new Date(parts[0], parts[1], parts[2]);
        }

        public static string AddDays(string startDate, int daysToSum)
        {
            return (StrToDate(startDate) + daysToSum).ToString();
        }

        public static string SubstructDays(string startDate, int daysToSum)
        {
            return (StrToDate(startDate) - daysToSum).ToString();
        }

        public static string EqulityDate(string startDate, string dateToCompare)
        {
            return (StrToDate(startDate) == StrToDate(dateToCompare)).ToString();
        }

        public static string UnEqulityDate(string startDate, string dateToCompare)
        {
            return (StrToDate(startDate) != StrToDate(dateToCompare)).ToString();
        }

        private void KeyPressForDays(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void KeyPressForEquality(object sender, KeyPressEventArgs e)
        {
            var textBox = (System.Windows.Forms.TextBox)sender;
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '.') || (e.KeyChar == '/') ||  (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }

    

    



    
}
