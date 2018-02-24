using CodeTest.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService _fizzBuzzService;

        [TestInitialize]
        public void Initialize()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        public void FizzBuzzService_GetResult_Returns_C_When_IsMultipleOf_7()
        {
            Assert.IsTrue(_fizzBuzzService.GetResult(7) == "C");
            Assert.IsTrue(_fizzBuzzService.GetResult(14) == "C");
        }

        [TestMethod]
        public void FizzBuzzService_GetResult_Returns_C_When_IsMultipleOf_9()
        {
            Assert.IsTrue(_fizzBuzzService.GetResult(9) == "N");
            Assert.IsTrue(_fizzBuzzService.GetResult(18) == "N");
        }

        [TestMethod]
        public void FizzBuzzService_GetResult_Returns_C_When_IsMultipleOf_7_And_9()
        {
            Assert.IsTrue(_fizzBuzzService.GetResult(63) == "CN");
            Assert.IsTrue(_fizzBuzzService.GetResult(252) == "CN");
        }

        [TestMethod]
        public void FizzBuzzService_GetResult_Returns_Input_Number_When_Not_IsMultipleOf_7_Or_9()
        {
            Assert.IsTrue(_fizzBuzzService.GetResult(1) == "1");
            Assert.IsTrue(_fizzBuzzService.GetResult(60) == "60");
        }

    }
}
