using System;

using R5T.T0132;

using R5T.L0087.T000;
using R5T.T0239;

using Framework = System.Collections.Generic;
using Simplified = R5T.L0090.T000;


namespace R5T.L0087.F001
{
    /// <summary>
    /// <see cref="Microsoft.VisualStudio.TestTools.UnitTesting.Assert"/> functionality for <see cref="Expectation"/> and <see cref="InputOutputPair"/>.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="L0088.F001.Documentation.AssertionOperatorNonStandardName" path="/summary"/>
    /// </remarks>
    [FunctionalityMarker]
    public partial interface IAssertion : IFunctionalityMarker,
        L0088.F002.IAssertion
    {
        public void Are_Equal<TOutput>(
            IExpectationOutput<TOutput> expectedValue,
            TOutput encounteredValue)
        {
            this.Are_Equal(
                expectedValue as IHasOutput<TOutput>,
                encounteredValue);
        }

        public void Are_Equal<TOutput>(
            IExpectationOutput<TOutput> expectedValue,
            TOutput encounteredValue,
            Framework.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue as IHasOutput<TOutput>,
                encounteredValue,
                equalityComparer);
        }

        public void Are_Equal<TOutput>(
            IExpectationOutput<TOutput> expectedValue,
            TOutput encounteredValue,
            Simplified.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue as IHasOutput<TOutput>,
                encounteredValue,
                equalityComparer);
        }

        public void Are_Equal<TInput, TOutput>(
            InputOutputPair<TInput, TOutput> expectedValue,
            TOutput encounteredValue)
        {
            this.Are_Equal(
                expectedValue as IHasOutput<TOutput>,
                encounteredValue);
        }

        public void Are_Equal<TInput, TOutput>(
            InputOutputPair<TInput, TOutput> expectedValue,
            TOutput encounteredValue,
            Framework.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue as IHasOutput<TOutput>,
                encounteredValue,
                equalityComparer);
        }

        public void Are_Equal<TInput, TOutput>(
            InputOutputPair<TInput, TOutput> expectedValue,
            TOutput encounteredValue,
            Simplified.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue as IHasOutput<TOutput>,
                encounteredValue,
                equalityComparer);
        }
    }
}
