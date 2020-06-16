﻿namespace PromQL.Functions.Instant.Time
{
    public class DayOfWeekFunction : BaseFunction<AbsentFunction>
    {
        private DayOfWeekFunction() : base("day_of_week")
        {
        }

        public static DayOfWeekFunction Create()
        {
            return new DayOfWeekFunction();
        }
    }
}