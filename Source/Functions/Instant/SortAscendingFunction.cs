﻿namespace PromQL.Functions.Instant
{
    internal class SortAscendingFunction : BaseFunction<SortAscendingFunction>
    {
        private SortAscendingFunction() : base("sort")
        {
        }

        public static SortAscendingFunction Create()
        {
            return new SortAscendingFunction();
        }
    }
}