using System;


namespace R5T.L0087.T000
{
    public static class FunctionTest
    {
        public static SynchronousFunctionTest<TInput, TOutput> From_Synchronous<TInput, TOutput>(
            Func<TInput, TOutput> function,
            IExpectation<TInput, TOutput> expectation)
        {
            var output = new SynchronousFunctionTest<TInput, TOutput>
            {
                Input = expectation.Input,
                Output = expectation.Output,
                Function = function,
                OutputEqualityComparer = expectation.OutputEqualityComparer,
            };

            return output;
        }

        /// <summary>
        /// Choose <see cref="From_Synchronous{TInput, TOutput}(Func{TInput, TOutput}, IExpectation{TInput, TOutput})"/> as the default.
        /// </summary>
        public static SynchronousFunctionTest<TInput, TOutput> From<TInput, TOutput>(
            Func<TInput, TOutput> function,
            IExpectation<TInput, TOutput> expectation)
        {
            return FunctionTest.From_Synchronous(
                function,
                expectation);
        }
    }
}
