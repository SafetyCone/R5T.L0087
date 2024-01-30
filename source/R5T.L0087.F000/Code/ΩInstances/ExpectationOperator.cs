using System;


namespace R5T.L0087.F000
{
    public class ExpectationOperator : IExpectationOperator
    {
        #region Infrastructure

        public static IExpectationOperator Instance { get; } = new ExpectationOperator();


        private ExpectationOperator()
        {
        }

        #endregion
    }
}
