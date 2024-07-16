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
            Singleton singleton = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Assert.AreEqual(singleton, singleton2);
        }
    }
}