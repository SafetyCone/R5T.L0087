using System;


namespace R5T.L0087.F001
{
    public class TestOperator : ITestOperator
    {
        #region Infrastructure

        public static ITestOperator Instance { get; } = new TestOperator();


        private TestOperator()
        {
        }

        #endregion
    }
}
