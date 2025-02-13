namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(26, 4, 2001);
            Console.WriteLine(birthday.ToString());
            birthday.Add(5);
            Console.WriteLine(birthday.ToString());
            birthday.Add(1, 1);
            Console.WriteLine(birthday.ToString());
            birthday.Add(new Date(1, 1, 1));
            Console.WriteLine(birthday.ToString());
        }
    }
    internal class Date
    {
        private int year;
        private int month;
        private string monthName;
        private int day;
        private int maxDays;

        public Date (int day = 1, int month = 1, int year = 2022)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            Normalize();
        }
        public override string ToString()
        {
            return $"{this.monthName} {this.day},{this.year}";
        }
        public void Add(int days)
        {
            this.day += days;
            Normalize();
        }
        public void Add(int days, int months)
        {
            this.month += months;
            this.day += days;
            Normalize();
        }
        public void Add(Date other)
        {
            this.day += other.day;
            this.month += other.month;
            this.year += other.year;
            Normalize();
        }
        private void Normalize()
        {
            Name();

            if (this.day > this.maxDays)
            {
                this.day -= (this.maxDays);
                this.month += 1;
            }
            if (this.month > 12)
            {
                this.month -= 11;
                this.year += 1;
            }
            Name();
        }
        private void Name()
        {
            switch (this.month)
            {
                case 1:
                    this.monthName = "January";
                    this.maxDays = 31;
                    break;
                case 2:
                    this.monthName = "February";
                    if (this.year % 4 == 0)
                    {
                        this.maxDays = 29;
                    }
                    else
                    {
                        this.maxDays = 28;
                    }
                    break;
                case 3:
                    this.monthName = "March";
                    this.maxDays = 31;
                    break;
                case 4:
                    this.monthName = "April";
                    this.maxDays = 30;
                    break;
                case 5:
                    this.monthName = "May";
                    this.maxDays = 31;
                    break;
                case 6:
                    this.monthName = "June";
                    this.maxDays = 30;
                    break;
                case 7:
                    this.monthName = "July";
                    this.maxDays = 31;
                    break;
                case 8:
                    this.monthName = "August";
                    this.maxDays = 30;
                    break;
                case 9:
                    this.monthName = "September";
                    this.maxDays = 30;
                    break;
                case 10:
                    this.monthName = "October";
                    this.maxDays = 31;
                    break;
                case 11:
                    this.monthName = "November";
                    this.maxDays = 30;
                    break;
                case 12:
                    this.monthName = "December";
                    this.maxDays = 31;
                    break;
            }
        }
    }
}
