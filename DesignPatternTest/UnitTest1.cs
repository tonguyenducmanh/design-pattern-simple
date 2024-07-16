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
        /// kiểm tra xem có phải chỉ có 1 instance duy nhất không
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
    }
}