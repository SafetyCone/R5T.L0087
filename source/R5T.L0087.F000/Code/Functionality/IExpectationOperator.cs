using System;
using System.Collections.Generic;
using System.Linq;

using R5T.L0090.T000;
using R5T.T0132;

using R5T.L0087.T000;

using Framework = System.Collections.Generic;
using Simplified = R5T.L0090.T000;
using System.Net.WebSockets;



namespace R5T.L0087.F000
{
    [FunctionalityMarker]
    public partial interface IExpectationOperator : IFunctionalityMarker,
        // Include the output operator since all IExpectations are IExpectionOutpus.
        // Put the expectation output functionality in a separate file for clarity.
        IExpectationOutputOperator
    {
        public Expectation<TInput[], TOutput[]> From_ToArray<TInput, TOutput>(
            IList<IExpectationPair<TInput, TOutput>> expectationPairs,
            Framework.IEqualityComparer<TOutput[]> outputArray_EqualityComparer)
            => this.From_ToArray(
                expectationPairs,
                Instances.EqualityComparerOperator.From(outputArray_EqualityComparer));

        public Expectation<TInput[], TOutput[]> From_ToArray<TInput, TOutput>(
            IEnumerable<IExpectationPair<TInput, TOutput>> expectationPairs,
            Framework.IEqualityComparer<TOutput[]> outputArray_EqualityComparer)
            => this.From_ToArray(
                expectationPairs.ToArray(),
                outputArray_EqualityComparer);

        public Expectation<TInput[], TOutput[]> From<TInput, TOutput>(
            IEnumerable<IExpectationPair<TInput, TOutput>> expectationPairs,
            Simplified.IEqualityComparer<TOutput[]> outputArray_EqualityComparer)
            => this.From_ToArray(
                expectationPairs.ToArray(),
                outputArray_EqualityComparer);

        public Expectation<TInput[], TOutput[]> From_ToArray<TInput, TOutput>(
            IList<IExpectationPair<TInput, TOutput>> expectationPairs,
            Simplified.IEqualityComparer<TOutput[]> outputArray_EqualityComparer)
        {
            var inputs = expectationPairs
                .Select(x => x.Input)
                .ToArray();

            var outputs = expectationPairs
                .Select(x => x.Output)
                .ToArray();

            var output = this.From(
                inputs,
                outputs,
                outputArray_EqualityComparer);

            return output;
        }

        public Expectation<TInput[], TOutput[]> From_ToArray<TInput, TOutput>(
            IEnumerable<IExpectationPair<TInput, TOutput>> expectationPairs,
            Simplified.IEqualityComparer<TOutput[]> outputArray_EqualityComparer)
            => this.From_ToArray(
                expectationPairs.ToArray(),
                outputArray_EqualityComparer);


        public Expectation<TInput[], TOutput[]> From_ToArray<TInput, TOutput>(
            IList<IExpectationPair<TInput, TOutput>> expectationPairs,
            Simplified.IEqualityComparer<TOutput> output_EqualityComparer)
        {
            var outputArray_EqualityComparer = Instances.EqualityComparerOperator.From_ToArray<TOutput>(output_EqualityComparer);

            var output = this.From_ToArray(
                expectationPairs,
                outputArray_EqualityComparer);

            return output;
        }

        public Expectation<TInput[], TOutput[]> From_ToArray<TInput, TOutput>(
            IList<IExpectationPair<TInput, TOutput>> expectationPairs,
            Framework.IEqualityComparer<TOutput> output_EqualityComparer)
        {
            // Take a short-cut as provided by the 
            var outputArray_EqualityComparer = Instances.EqualityComparerOperator.From_Function<TOutput[]>((x, y) =>
            {
                var output = Instances.ArrayOperator.Are_Equal(x, y, output_EqualityComparer);
                return output;
            });

            var output = this.From_ToArray(
                expectationPairs,
                outputArray_EqualityComparer);

            return output;
        }

        public Expectation<TInput[], TOutput[]> From_ToArray<TInput, TOutput>(IList<IExpectationPair<TInput, TOutput>> expectationPairs)
            => this.From_ToArray(
                expectationPairs,
                Instances.EqualityOperator.Get_EqualityComparer<TOutput>());

        public Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output,
            Simplified.IEqualityComparer<TOutput> outputEqualityComparer)
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
            Simplified.IEqualityComparer<TOutput> outputEqualityComparer)
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
