using System;


namespace R5T.L0087.F000
{
    public class ExpectationOutputOperator : IExpectationOutputOperator
    {
        #region Infrastructure

        public static IExpectationOutputOperator Instance { get; } = new ExpectationOutputOperator();


        private ExpectationOutputOperator()
        {
        }

        #endregion
    }
}
