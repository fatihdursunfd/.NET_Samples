namespace ImplicitAndExplicit
{
    public struct CustomDay
    {
        public int Day { get; set; }

        public CustomDay(int day)
        {
            Day = day;
            DayOfWeek = (DayOfWeek)day;
        }

        public DayOfWeek DayOfWeek { get; set; }
        public bool IsWeekend => Day >= 1 && Day <= 5;
        public bool IsWeekDay => Day == 0 || Day == 6;


        //public static implicit operator CustomDay(int d) => new CustomDay(d);
         
        //public static implicit operator int (CustomDay d) => d.Day;


        public static explicit operator CustomDay(int d) => new CustomDay(d);

        public static explicit operator int(CustomDay d) => d.Day;

    }
}