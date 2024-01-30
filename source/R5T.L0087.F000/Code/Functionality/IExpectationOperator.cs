using System;

using R5T.L0090.T000;
using R5T.T0132;

using R5T.L0087.T000;

using Framework = System.Collections.Generic;


namespace R5T.L0087.F000
{
    [FunctionalityMarker]
    public partial interface IExpectationOperator : IFunctionalityMarker,
        // Include the output operator since all IExpectations are IExpectionOutpus.
        // Put the expectation output functionality in a separate file for clarity.
        IExpectationOutputOperator
    {
        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output,
            IEqualityComparer<TOutput> outputEqualityComparer)
        {
            var expectation = Expectation.From(
                input,
                output,
                outputEqualityComparer);

            return expectation;
        }

        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output,
            Framework.IEqualityComparer<TOutput> systemOutputEqualityComparer)
        {
            var outputEqualityComparer = EqualityComparerBasedEqualityComparer<TOutput>.From(
                systemOutputEqualityComparer);

            var expectation = new Expectation<TInput, TOutput>
            {
                Input = input,
                Output = output,
                OutputEqualityComparer = outputEqualityComparer,
            };

            return expectation;
        }

        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output)
        {
            // Specify the type parameters to avoid selecting the two-inputs version.
            var expectation = this.From<TInput, TOutput>(
                input,
                output,
                EqualityComparerBasedEqualityComparer<TOutput>.Default);

            return expectation;
        }

        public Expectation<TInput1, TInput2, TOutput> From<TInput1, TInput2, TOutput>(
            TInput1 input1,
            TInput2 input2,
            TOutput output,
            IEqualityComparer<TOutput> outputEqualityComparer)
        {
            var expectation = new Expectation<TInput1, TInput2, TOutput>
            {
                Input1 = input1,
                Input2 = input2,
                Output = output,
                OutputEqualityComparer = outputEqualityComparer,
            };

            return expectation;
        }

        public Expectation<TInput1, TInput2, TOutput> From<TInput1, TInput2, TOutput>(
            TInput1 input1,
            TInput2 input2,
            TOutput output)
        {
            var expectation = this.From(
                input1,
                input2,
                output,
                EqualityComparerBasedEqualityComparer<TOutput>.Default);

            return expectation;
        }
    }
}
