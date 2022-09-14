namespace Consoleapp
{
    [TestClass]
    public class UnitTest1
    {
      

        [TestMethod]
        public void TestDivide()
        {
            //Arrange
            int divd = 100;
            int divisor =5;
            int res, rem;
            int expectedResult = 20;


            //Act
            ConsoleApp1.InOutDemo.Divide(divd, divisor, out res, out rem);

            //Assert
            Assert.AreEqual(expectedResult, res);
           
        }
    }
}