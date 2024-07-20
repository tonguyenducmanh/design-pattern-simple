using DesignPattern;
using static DesignPattern.RemoteControl;

namespace DesignPatternTest
{
    /// <summary>
    /// class test các design pattern
    /// </summary>
    [TestClass]
    public class DesignPatternTestSimple
    {
        /// <summary>
        /// kiểm tra xem có phải chỉ có 1 instance duy nhất 
        /// theo singleton pattern không
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
        /// kiểm tra xem có build được string 
        /// theo builder pattern không
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

        /// <summary>
        /// kiểm tra xem có lấy thành công service
        /// theo mô hình Factory method pattern không
        /// </summary>
        [TestMethod]
        public void TestFactoryMethod_GetServiceSuccess()
        {
            // chuẩn bị dữ liệu
            PrintBase service1 = new FactoryMethod().GetService(FileType.Html);
            PrintBase service2 = new FactoryMethod().GetService(FileType.Excel);

            // lấy dữ liệu
            string result1 = service1.Print();
            string result2 = service2.Print();

            // test kết quả
            Assert.AreEqual(result1, "Printed Html File");
            Assert.AreEqual(result2, "Printed Excel File");
        }

        /// <summary>
        /// kiểm tra xem có tạo được GUI (giao diện người dùng ứng dụng)
        /// cho nhiều hệ điều hành theo mô hình Abtract factory pattern không
        /// </summary>
        [TestMethod]
        public void TestAbtractFactory_BuildApplicationSuccess()
        {
            // chuẩn bị
            ApplicationAbtractFactory windowApp = new ApplicationAbtractFactory(EnumOS.Window);
            ApplicationAbtractFactory ubuntuApp = new ApplicationAbtractFactory(EnumOS.Ubuntu);

            // test dữ liệu

            windowApp.CreateUI();
            List<string> resultWindow = windowApp.Paint();
            ubuntuApp.CreateUI();
            List<string> resultUbuntu = ubuntuApp.Paint();

            // kết quả

            Assert.IsTrue(resultWindow.Count > 0);
            Assert.IsTrue(resultUbuntu.Count > 0);
        }

        /// <summary>
        /// kiểm tra việc clone object của prototype pattern
        /// </summary>
        [TestMethod]
        public void TestPrototype_CloneSuccess()
        {
            // chuẩn bị
            string originalName = "Jack Daniels";
            int originalNum = 666;
            int changedNum = 3838;
            PersonPrototype p1 = new PersonPrototype();
            p1.Age = 42;
            p1.BirthDate = new DateTime(1977, 1, 1);
            p1.Name = originalName;
            p1.IDInfo = new PersionIDInfo(originalNum);


            // biến đổi dữ liệu
            PersonPrototype p2 = p1.ShallowCopy();
            PersonPrototype p3 = p1.DeepCopy();

            p1.Age = 32;
            p1.BirthDate = new DateTime(2024, 1, 1);
            p1.Name = "Frank";
            p1.IDInfo.IDNumber = changedNum;


            // kết quả
            Assert.IsNotNull(p2);
            Assert.IsNotNull(p3);
            Assert.AreEqual(p2.Name, originalName);
            Assert.AreEqual(p3.Name, originalName);
            Assert.AreNotEqual(p2.IDInfo.IDNumber, originalNum);
            Assert.AreNotEqual(p3.IDInfo.IDNumber, changedNum);
        }

        /// <summary>
        /// Kiểm tra xem liệu đèn có thể sáng thông qua bộ chuyển đổi nguồn điện
        /// theo Adapter pattern
        /// </summary>
        [TestMethod]
        public void TestAdapter_ResultLedStatus()
        {
            // chuẩn bị
            VietNamElectric vietNamElectric = new VietNamElectric();

            // biến đổi dữ liệu
            vietNamElectric.VonElectric = 220;
            LedStatus led1 = new AdapterElectric(vietNamElectric).ConnectToElectric();
            vietNamElectric.VonElectric = 100;
            LedStatus led2 = new AdapterElectric(vietNamElectric).ConnectToElectric();
            vietNamElectric.VonElectric = 320;
            LedStatus led3 = new AdapterElectric(vietNamElectric).ConnectToElectric();

            // check kết quả
            Assert.AreEqual(led1, LedStatus.On);
            Assert.AreEqual(led2, LedStatus.Off);
            Assert.AreEqual(led3, LedStatus.Fired);
        }

        /// <summary>
        /// kiểm tra xem có điều khiển được thiết bị thông qua điều khiển không
        /// </summary>
        [TestMethod]
        public void TestBridgePattern_DeviceRemoteSuccess()
        {
            // chuẩn bị
            Televition tv = new Televition();
            RemoteControl remoteTv = new RemoteControl(tv);
            Radio radio = new Radio();
            AdvanceRemoteControl remoteRadio = new AdvanceRemoteControl(radio);

            // xử lý dữ liệu
            tv.SetVolume(0);
            remoteTv.VolumnUp();

            remoteRadio.MuteDevice();

            // kết quả
            Assert.AreNotEqual(tv.GetVolumne(), 0);
            Assert.AreEqual(radio.GetVolumne(), 0);
        }

        /// <summary>
        /// vẽ đồ họa pixel theo mô hình cây hiệu quả
        /// </summary>
        [TestMethod]
        public void TestCompositePattern_DrawPixelSuccess()
        {
            // chuẩn bị

            // đối tượng hình cây
            ComponentOfComposite allComponents = new ComponentOfComposite();

            // xử lý dữ liệu

            // thêm các lá vào trong cây
            allComponents.Add(new DotOfComposite(1, 2));
            allComponents.Add(new CircleOfComposite(10, 12, 5));

            // thêm các cành vào trong cây

            ComponentOfComposite branch = new ComponentOfComposite();
            List<ICompositeGraphic> branchComponents = new List<ICompositeGraphic>() 
            { 
                new DotOfComposite(12, 0),
                new DotOfComposite(22, 1),
                new CircleOfComposite(06, 07, 20)
            };
            foreach (ICompositeGraphic component in branchComponents)
            {
                branch.Add(component);
            }
            allComponents.Add(branch);

            string drawResult = allComponents.Draw();
            List<string> everyLeafResult = drawResult.Split(";").ToList();

            // kết quả

            Assert.AreEqual(everyLeafResult.Count, 5);
        }

        /// <summary>
        /// kiểm tra pha cà phê có thành công không
        /// </summary>
        [TestMethod]
        public void TestDecoratorPattern_MakeCoffeeSuccess()
        {
            // chuẩn bị
            ICoffee coffee = new SimpleCoffee();

            coffee = new MilkDecorator(coffee);

            coffee = new SugarDecorator(coffee);

            // xử lý dữ liệu
            List<int> costs = coffee.GetCost();
            List<string> descriptions = coffee.GetDescription();

            // kết quả
            Assert.AreEqual(costs.Count, 3);
            Assert.AreEqual(descriptions.Count, 3);
        }
    }
}