using System;


namespace R5T.L0087.T000
{
	/// <summary>
	/// Testing infrastructure types (Expectation, input/output pair, etc.).
	/// </summary>
	public static class Documentation
	{
        /// <summary>
        /// Convenient conversion to the input type allows:
        /// <code>
        /// var expected = GetExpected();
        /// var actual = TestObject.TestMethod(expected);
        /// </code>
        /// </summary>
        public static readonly object ConvenientConversionToInputType;

        /// <summary>
        /// Input-output pairs, no implicit converstion to the output output type avoids the trouble that occurs when the input type is the same as output type, and an expectation is given to a method requring the output type.
        /// In that case, which value will be returned, the input or the output? Both have the same type, so which implicit operator will called; the operator returning the input or the operator returning the output?
        /// By only allowing implicit conversion to the input type, input-output pairs can be given directly to test operations using the input type instance, while the output must be explicitly specified for equality test operations comparing expected and actual output type instances.
        /// </summary>
        public static readonly object NoImplicitConversionToOutputType;
    }
}
