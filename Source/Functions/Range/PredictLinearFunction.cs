﻿namespace PromQL.Functions.Range
{
    internal class PredictLinearFunction : BaseFunction<PredictLinearFunction>
    {
        private PredictLinearFunction() : base("predict_linear")
        {
        }

        public static PredictLinearFunction Create(float seconds)
        {
            return new PredictLinearFunction()
                .AddArgument(seconds);
        }
    }
}