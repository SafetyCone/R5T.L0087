using System;

using R5T.T0142;
using R5T.T0239;


namespace R5T.L0087.T000
{
    /// <summary>
    /// Combines the input and output data values of some operation.
    /// </summary>
    /// <remarks>
    /// This is useful in testing.
    /// </remarks>
    [DataTypeMarker, UtilityTypeMarker]
    public class InputOutputPair<TInput, TOutput> :
        IWithOutput<TOutput>
    {
        #region Static

        /// <summary>
        /// <inheritdoc cref="Documentation.ConvenientConversionToInputType"/>
        /// </summary>
        public static implicit operator TInput(InputOutputPair<TInput, TOutput> pair)
        {
            return pair.Input;
        }

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }


        public override string ToString()
        {
            // Put output first, since it is more interesting.
            var representation = $"'{this.Output}'\n- from -\n\t'{this.Input}'";
            return representation;
        }
    }


    /// <inheritdoc cref="InputOutputPair{TInput, TOutput}"/>
    public class InputOutputPair<TInput1, TInput2, TOutput>
    {
        #region Static

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion

        public TInput1 Input1 { get; set; }
        public TInput2 Input2 { get; set; }
        public TOutput Output { get; set; }


        public override string ToString()
        {
            // Put output first, since it is more interesting.
            var representation = $"{this.Output}\n- from -\n\t'{this.Input1}'\n\t{this.Input2}";
            return representation;
        }
    }


    /// <summary>
    /// Static class for input/output pair methods.
    /// Also helps to provide a non-type parametered class for use in documentation comments related to input/output pairs.
    /// </summary>
    public static class InputOutputPair
    {
        public static InputOutputPair<TInput, TOutput> From<TInput, TOutput>(
            TInput input,
            TOutput output)
        {
            var pair = new InputOutputPair<TInput, TOutput>
            {
                Input = input,
                Output = output,
            };

            return pair;
        }

        public static InputOutputPair<TInput1, TInput2, TOutput> From<TInput1, TInput2, TOutput>(
            TInput1 input1,
            TInput2 input2,
            TOutput output)
        {
            var pair = new InputOutputPair<TInput1, TInput2, TOutput>
            {
                Input1 = input1,
                Input2 = input2,
                Output = output,
            };

            return pair;
        }
    }
}
