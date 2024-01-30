using System;

using R5T.L0090.T000;
using R5T.T0142;


namespace R5T.L0087.T000
{
    /// <inheritdoc cref="ISynchronousFunctionTest{TInput, TOutput}"/>
    [DataTypeMarker, UtilityTypeMarker]
    public class SynchronousFunctionTest<TInput, TOutput> : ISynchronousFunctionTest<TInput, TOutput>
    {
        #region Static

        /// <summary>
        /// <inheritdoc cref="Documentation.ConvenientConversionToInputType"/>
        /// </summary>
        public static implicit operator TInput(SynchronousFunctionTest<TInput, TOutput> pair)
        {
            return pair.Input;
        }

        /// <inheritdoc cref="Documentation.NoImplicitConversionToOutputType"/>

        #endregion


        public TInput Input { get; set; }
        public TOutput Output { get; set; }
        public IEqualityComparer<TOutput> OutputEqualityComparer { get; set; }
        public Func<TInput, TOutput> Function { get; set; }


        public override string ToString()
        {
            var representation = $"{this.Output}\n- expected from -\n\t{this.Input}";
            return representation;
        }
    }
}
