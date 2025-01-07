using System;

using R5T.T0142;
using R5T.T0239;


namespace R5T.L0087.T000
{
    [DataTypeMarker, UtilityTypeMarker]
    public interface IExpectationPair<TInput, TOutput> :
        IWithOutput<TOutput>
    {
        public TInput Input { get; set; }
    }
}