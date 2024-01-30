using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.L0087.T000
{
    /// <summary>
    /// Represents a test tying together a function, an input, an expected output, and the means to equate encounted output instances against the expected output instance.
    /// This means is provided by a simplified equality comparer instance (<see cref="IEqualityComparer{T}"/>).
    /// A test provides all the information required to run and verify an operation transforming a <typeparamref name="TInput"/> into a <typeparamref name="TOutput"/>.
    /// </summary>
    [DataTypeMarker, UtilityTypeMarker]
    public interface ISynchronousFunctionTest<TInput, TOutput> :
        IExpectation<TInput, TOutput>
    {
        public Func<TInput, TOutput> Function { get; set; }
    }
}
