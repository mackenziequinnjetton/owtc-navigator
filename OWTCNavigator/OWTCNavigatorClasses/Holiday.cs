using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace OWTCNavigatorClasses

{
    // Credit to David Everton for original code, which has been further
    // modified by myself, MacKenzie Quinn Jetton
    public class Holiday

    {
        // Checks if the current working date in the due date generating
        // algorithm is one of various holidays
        public static bool IsHoliday(DateTime date)

        {

            return

                Holiday.IsChristmasRecess2021(date)

             || Holiday.IsChrismasRecess2022(date)

             || Holiday.IsEmployeeDevelopment(date)

             || Holiday.IsSpringRecess(date)

             || Holiday.IsPioneerDay(date)

             || Holiday.IsThanksgivingDay(date)

             || Holiday.IsDayAfterThanksgiving(date)

             || Holiday.IsFourthOfJuly(date)

             || Holiday.IsLaborDay(date)

             || Holiday.IsMemorialDay(date)

             || Holiday.IsMartinLutherKing(date)

             || Holiday.IsPresidentsDay(date);

        }

        private static DateTime[] christmasRecess2021 =
        {
            new DateTime(2021, 12, 22),
            new DateTime(2021, 12, 23),
            new DateTime(2021, 12, 24),
            new DateTime(2021, 12, 25),
            new DateTime(2021, 12, 26),
            new DateTime(2021, 12, 27),
            new DateTime(2021, 12, 28),
            new DateTime(2021, 12, 29),
            new DateTime(2021, 12, 30),
            new DateTime(2021, 12, 31)
        };

        private static DateTime[] christmasRecess2022 =
        {
            new DateTime(2022, 12, 23),
            new DateTime(2022, 12, 24),
            new DateTime(2022, 12, 25),
            new DateTime(2022, 12, 26),
            new DateTime(2022, 12, 27),
            new DateTime(2022, 12, 28),
            new DateTime(2022, 12, 29),
            new DateTime(2022, 12, 30),
            new DateTime(2022, 12, 31),
            new DateTime(2023, 1, 1),
            new DateTime(2023, 1, 2)
        };

        private static DateTime[] employeeDevelopment2021Through2023 =
        {
            new DateTime(2021, 10, 1),
            new DateTime(2022, 1, 14),
            new DateTime(2022, 4, 8),
            new DateTime(2022, 7, 14),
            new DateTime(2022, 7, 15),
            new DateTime(2022, 1, 14),
            new DateTime(2022, 10, 7),
            new DateTime(2022, 12, 9),
            new DateTime(2023, 3, 10)
        };

        private static DateTime[] springRecess2022And2023 =
        {
            new DateTime(2022, 4, 15),
            new DateTime(2022, 4, 18),
            new DateTime(2023, 4, 6),
            new DateTime(2023, 4, 7),
            new DateTime(2023, 4, 8),
            new DateTime(2023, 4, 9),
            new DateTime(2023, 4, 10)
        };
        public static bool IsChristmasRecess2021(DateTime date)
        {
            return christmasRecess2021.Contains(date);
        }

        public static bool IsChrismasRecess2022(DateTime date)
        {
            return christmasRecess2022.Contains(date);
        }

        public static bool IsEmployeeDevelopment(DateTime date)
        {
            return employeeDevelopment2021Through2023.Contains(date);
        }

        public static bool IsSpringRecess(DateTime date)
        {
            return springRecess2022And2023.Contains(date);
        }

        public static bool IsPioneerDay(DateTime date)
        {
            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 7, 24)).DayOfYear;
        }

        public static bool IsNewYearsDay(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 1, 1)).DayOfYear;

        }

        public static bool IsChristmasEve(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 24)).DayOfYear;

        }

        public static bool IsChristmasDay(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 25)).DayOfYear;

        }

        public static bool IsChristmasHoliday(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 26)).DayOfYear;

        }

        public static bool IsChristmasHoliday27(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 27)).DayOfYear;

        }

        public static bool IsChristmasHoliday28(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 28)).DayOfYear;

        }

        public static bool IsChristmasHoliday29(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 29)).DayOfYear;

        }

        public static bool IsChristmasHoliday30(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 30)).DayOfYear;

        }

        public static bool IsNewYearsEve(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 12, 31)).DayOfYear;

        }

        public static bool IsFourthOfJuly(DateTime date)

        {

            return date.DayOfYear == AdjustForWeekendHoliday(new DateTime(date.Year, 7, 4)).DayOfYear;

        }

        public static bool IsLaborDay(DateTime date)

        { // First Monday in September

            DateTime laborDay = new DateTime(date.Year, 9, 1);

            DayOfWeek dayOfWeek = laborDay.DayOfWeek;

            while (dayOfWeek != DayOfWeek.Monday)

            {

                laborDay = laborDay.AddDays(1);

                dayOfWeek = laborDay.DayOfWeek;

            }

            return date.DayOfYear == laborDay.DayOfYear;

        }

        public static bool IsMemorialDay(DateTime date)

        { //Last Monday in May

            DateTime memorialDay = new DateTime(date.Year, 5, 31);

            DayOfWeek dayOfWeek = memorialDay.DayOfWeek;

            while (dayOfWeek != DayOfWeek.Monday)

            {

                memorialDay = memorialDay.AddDays(-1);

                dayOfWeek = memorialDay.DayOfWeek;

            }

            return date.DayOfYear == memorialDay.DayOfYear;

        }

        public static bool IsThanksgivingDay(DateTime date)

        {//4th Thursday in November

            var thanksgiving = (from day in Enumerable.Range(1, 30)

                                where new DateTime(date.Year, 11, day).DayOfWeek == DayOfWeek.Thursday

                                select day).ElementAt(3);

            DateTime thanksgivingDay = new DateTime(date.Year, 11, thanksgiving);

            return date.DayOfYear == thanksgivingDay.DayOfYear;

        }

        public static bool IsDayAfterThanksgiving(DateTime date)

        {//Day after Thanksgiving

            var thanksgiving = (from day in Enumerable.Range(1, 30)

                                where new DateTime(date.Year, 11, day).DayOfWeek == DayOfWeek.Thursday

                                select day).ElementAt(3);

            if (thanksgiving == 30)
            {
                DateTime thanksgivingDay = new DateTime(date.Year, 12, 1);

                return date.DayOfYear == thanksgivingDay.DayOfYear;
            }
            else
            {
                DateTime thanksgivingDay = new DateTime(date.Year, 11, thanksgiving + 1);

                return date.DayOfYear == thanksgivingDay.DayOfYear;
            }

        }

        public static bool IsDayAfterEaster(DateTime date)

        {//Day after Easter

            var Easter = (from day in Enumerable.Range(1, 30)

                          where new DateTime(date.Year, 4, day).DayOfWeek == DayOfWeek.Sunday

                          select day).ElementAt(0);

            if (Easter == 30)
            {
                DateTime EasterDay = new DateTime(date.Year, 5, 1);

                return date.DayOfYear == EasterDay.DayOfYear;
            }
            else
            {
                DateTime EasterDay = new DateTime(date.Year, 4, Easter + 1);

                return date.DayOfYear == EasterDay.DayOfYear;
            }

        }

        public static bool IsThursdayBeforeEaster(DateTime date)

        {//Day thursday before Easter

            var Easter = (from day in Enumerable.Range(1, 30)

                          where new DateTime(date.Year, 4, day).DayOfWeek == DayOfWeek.Sunday

                          select day).ElementAt(0);

            if (Easter - 3 <= 0)
            {
                DateTime EasterDay = new DateTime(date.Year, 3, 31 + (Easter - 3));

                return date.DayOfYear == EasterDay.DayOfYear;
            }
            else
            {
                DateTime EasterDay = new DateTime(date.Year, 4, Easter - 3);

                return date.DayOfYear == EasterDay.DayOfYear;
            }

        }

        public static bool IsFridayBeforeEaster(DateTime date)

        {//Day Friday before Easter

            var Easter = (from day in Enumerable.Range(1, 30)

                          where new DateTime(date.Year, 4, day).DayOfWeek == DayOfWeek.Sunday

                          select day).ElementAt(0);

            if (Easter - 2 <= 0)
            {
                DateTime EasterDay = new DateTime(date.Year, 3, 31 + (Easter - 2));

                return date.DayOfYear == EasterDay.DayOfYear;
            }
            else
            {
                DateTime EasterDay = new DateTime(date.Year, 4, Easter - 2);

                return date.DayOfYear == EasterDay.DayOfYear;
            }

        }

        public static bool IsPresidentsDay(DateTime date)

        {//3th Monday in February

            var presidentsday = (from day in Enumerable.Range(1, 30)

                                 where new DateTime(date.Year, 2, day).DayOfWeek == DayOfWeek.Monday

                                 select day).ElementAt(2);

            DateTime presidentsDay = new DateTime(date.Year, 2, presidentsday);

            return date.DayOfYear == presidentsDay.DayOfYear;

        }

        public static bool IsMartinLutherKing(DateTime date)

        {//Martin Luther King Day: Third Monday in January

            var martinlutherkingday = (from day in Enumerable.Range(1, 30)

                                       where new DateTime(date.Year, 1, day).DayOfWeek == DayOfWeek.Monday

                                       select day).ElementAt(2);

            DateTime martinLutherKingDay = new DateTime(date.Year, 1, martinlutherkingday);

            return date.DayOfYear == martinLutherKingDay.DayOfYear;

        }

        public static bool IsWeekend(DateTime weekend)

        {

            if (weekend.DayOfWeek == DayOfWeek.Saturday || weekend.DayOfWeek == DayOfWeek.Sunday)

            {

                return true;

            }

            else

            {

                return false;

            }

        }

        // Shifts the observed date of a holiday to account for it
        // landing on a weekend
        private static DateTime AdjustForWeekendHoliday(DateTime holiday)

        {

            if (holiday.DayOfWeek == DayOfWeek.Saturday)

            {

                return holiday.AddDays(-1);

            }

            else if (holiday.DayOfWeek == DayOfWeek.Sunday)

            {

                return holiday.AddDays(1);

            }

            else

            {

                return holiday;

            }

        }

    }

}