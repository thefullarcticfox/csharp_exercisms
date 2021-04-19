using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int _month;
    private int _year;

    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime    res = new DateTime(_year, _month, 1);

        if (schedule == Schedule.Teenth) {
            res = res.AddDays(18);
            while (res.DayOfWeek != dayOfWeek)
                res = res.AddDays(-1);
        }

        if (schedule == Schedule.Last) {
            res = res.AddMonths(1);
            res = res.AddDays(-1);
            while (res.DayOfWeek != dayOfWeek)
                res = res.AddDays(-1);
        }

        if (schedule >= Schedule.First && schedule <= Schedule.Fourth) {
            int number = schedule - Schedule.First + 1;
            while (res.DayOfWeek != dayOfWeek)
                res = res.AddDays(1);
            while (--number != 0 && res.Month == _month)
                res = res.AddDays(7);
        }

        return res;
    }
}
