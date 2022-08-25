namespace Week2Day1
{
    internal class DateTimeCase

    {
        public static void DateTimeCases()
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            int mount = now.Month;
            int year = now.Year;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;


            //only date

            DateTime onlyDate = now.Date;
            Console.WriteLine($"Only Date : {onlyDate}");

            //dateoffweeK
            DayOfWeek dayOfWeek = now.DayOfWeek;
            DayOfWeek kamis = DayOfWeek.Tuesday;
            DayOfWeek friday = DayOfWeek.Friday;    
            DayOfWeek saturday = DayOfWeek.Saturday;
            DayOfWeek tuesday = DayOfWeek.Tuesday;

            //ADDDAY
            DateTime tomorrow = now.AddDays(2);

            //selisih hari
            TimeSpan dateDifference = tomorrow - now;
            int daysRemaining = dateDifference.Days;
            Console.WriteLine($"{now} -{tomorrow},seliish: {daysRemaining}");

            //store spesific date
            DateTime birthDay = new DateTime(1689, 10, 21);

        }
    }
}