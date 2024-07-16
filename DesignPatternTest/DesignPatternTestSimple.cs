using DesignPattern;

namespace DesignPatternTest
{
    /// <summary>
    /// class test các design pattern
    /// </summary>
    [TestClass]
    public class DesignPatternTestSimple
    {
        /// <summary>
        /// kiểm tra xem có phải chỉ có 1 instance duy nhất theo singleton pattern không
        /// </summary>
        [TestMethod]
        public void TestSingleton_OneInstance()
        {
            // chuẩn bị dữ liệu
            Singleton singleton = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;
            Singleton singleton3 = new Singleton();

            // test
            Assert.AreEqual(singleton, singleton2);
            Assert.AreNotEqual(singleton, singleton3);
        }

        /// <summary>
        /// kiểm tra xem có build được string theo builder pattern không
        /// </summary>
        [TestMethod]
        public void TestBuilder_BuildSuccess()
        {
            // chuẩn bị dữ liệu
            string testDateTime = new Builder()
                                    .BuildDay(11)
                                    .BuildMonth(06)
                                    .BuildYear(2024)
                                    .BuildHour(09)
                                    .BuildMinute(00)
                                    .BuildSecond(00)
                                    .GetResult()
                                    .ToString();
            string testDateTime2 = new Builder()
                                    .BuildYear(2023)
                                    .GetResult()
                                    .ToString();
            // test
            Assert.IsTrue(testDateTime == "11/06/2024 09:00:00");
            Assert.IsTrue(testDateTime2 == "01/01/2023 12:00:00");
        }
    }
}