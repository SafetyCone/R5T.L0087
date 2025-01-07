using System;

using R5T.T0142;


namespace R5T.L0087.T000
{
    /// <inheritdoc cref="IExpectation{TInput, TOutput}"/>
    [DataTypeMarker, UtilityTypeMarker]
    public class ExpectationPair<TInput, TOutput> : IExpectationPair<TInput, TOutput>
    {
        #region Static

        /// <summary>
        /// <inheritdoc cref="Documentation.ConvenientConversionToInputType"/>
        /// </summary>
        public static implicit operator TInput(ExpectationPair<TInput, TOutput> pair)
        {
            return pair.Input;
        }

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }


        public override string ToString()
        {
            var representation = $"{this.Output}\n- expected from -\n\t{this.Input}";
            return representation;
        }
    }

    /// <summary>
    /// A static class for expection methods.
    /// Also helps to provide a non-type parametered class for use in documentation comments related to expectations.
    /// </summary>
    [UtilityTypeMarker]
    public static class ExpectationPair
    {
        public static Expectation<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output)
        {
            var expectation = new Expectation<TInput, TOutput>
            {
                Input = input,
                Output = output,
            };

            return expectation;
        }
    }
}
