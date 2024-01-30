using System;

using R5T.L0090.T000;
using R5T.T0142;
using R5T.T0239;


namespace R5T.L0087.T000
{
    /// <summary>
    /// Represents an just the output portion of an expectation, that ties together an expected output and the means to equate encounted output instances against the expected output instance.
    /// This means is provided by a simplified equality comparer instance (<see cref="IEqualityComparer{T}"/>).
    /// </summary>
    /// <remarks>
    /// This is useful when defining methods to verify the output of a testing operation where the input type of an expectation is no longer required.
    /// </remarks>
    [DataTypeMarker, UtilityTypeMarker]
    public interface IExpectationOutput<TOutput> :
        IWithOutput<TOutput>
    {
        public IEqualityComparer<TOutput> OutputEqualityComparer { get; set; }
    }
}
