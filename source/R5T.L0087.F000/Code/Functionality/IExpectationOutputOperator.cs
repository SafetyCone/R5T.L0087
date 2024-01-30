using System;

using R5T.T0132;

using R5T.L0087.T000;


namespace R5T.L0087.F000
{
    [FunctionalityMarker]
    public partial interface IExpectationOutputOperator : IFunctionalityMarker
    {
        public bool Equate<TOutput>(
            IExpectationOutput<TOutput> expectationOutput,
            TOutput actual)
        {
            var areEqual = expectationOutput.OutputEqualityComparer.Equals(
                actual,
                expectationOutput.Output);

            return areEqual;
        }

        /// <summary>
        /// Either the output is equal to the expected output, or an exception is thrown.
        /// </summary>
        public void Verify<TOutput>(
            IExpectationOutput<TOutput> expectation,
            TOutput actual)
        {
            var verified = this.Equate(expectation, actual);
            if (!verified)
            {
                throw new Exception("The output was failed verification against the expected output.");
            }
        }
    }
}
