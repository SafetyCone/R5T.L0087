using System;

using R5T.T0132;

using R5T.L0087.T000;


namespace R5T.L0087.F001
{
    [FunctionalityMarker]
    public partial interface ITestOperator : IFunctionalityMarker
    {
        public void Test_Function<TInput, TOutput>(
            Func<TInput, TOutput> function,
            IExpectation<TInput, TOutput> expectation)
        {
            var actual = Instances.FunctionOperator.Run(
                expectation.Input,
                function);

            Instances.Assertion.Are_Equal(
                expectation,
                actual);
        }

        public void Run<TInput, TOutput>(ISynchronousFunctionTest<TInput, TOutput> test)
        {
            var actual = Instances.FunctionOperator.Run(
                test.Input,
                test.Function);

            Instances.Assertion.Are_Equal(
                test.Output,
                actual);
        }
    }
}
