﻿namespace PromQL.Functions.Range
{
    public class CountOverTimeFunction : BaseOverTimeFunction
    {
        private CountOverTimeFunction() : base("count")
        {
        }

        public static CountOverTimeFunction Create()
        {
            return new CountOverTimeFunction();
        }
    }
}