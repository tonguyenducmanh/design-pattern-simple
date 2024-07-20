using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// interface chung cho các loại cà phê 
    /// theo mô hình Decorator Pattern
    /// </summary>
    public interface ICoffee
    {
        /// <summary>
        /// mô tả các nguyên vật liệu làm ra tách cà phê
        /// </summary>
        public List<string> GetDescription();

        /// <summary>
        /// toàn bộ chi phí cho nguyên vật liệu
        /// </summary>
        /// <returns></returns>
        public List<int> GetCost();
    }

    /// <summary>
    /// class cấp cao nhất của ly cà phê này
    /// </summary>
    public class SimpleCoffee : ICoffee
    {
        #region Declare

        /// <summary>
        /// giá của ly cà phê
        /// </summary>
        private readonly int _cost = 10;

        /// <summary>
        /// nguyên liệu cà phê
        /// </summary>
        private readonly string _description = "Hạt cà phê";

        #endregion

        #region Constructor

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        public SimpleCoffee() { }

        #endregion

        #region Methods

        /// <summary>
        /// tổng chi phí
        /// </summary>
        /// <returns></returns>
        public List<int> GetCost()
        {
            return new List<int>() { _cost };
        }

        /// <summary>
        /// thông tin nguyên liệu
        /// </summary>
        public List<string> GetDescription()
        {
            return new List<string> { _description };
        }

        #endregion
    }

    /// <summary>
    /// lớp trang trí cà phê theo mô hình Decorator pattern
    /// </summary>
    public abstract class DecoratorCoffee : ICoffee
    {

        #region Declare

        /// <summary>
        /// cà phê đã được trang trí qua nhiều bước
        /// </summary>
        protected ICoffee _decoratedCoffee;

        #endregion

        #region Constructor

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        public DecoratorCoffee(ICoffee coffee)
        {
            _decoratedCoffee = coffee;
        }

        #endregion

        #region Methods

        /// <summary>
        /// tổng chi phí
        /// </summary>
        /// <returns></returns>
        public virtual List<int> GetCost()
        {
            return _decoratedCoffee.GetCost();
        }

        /// <summary>
        /// thông tin nguyên liệu
        /// </summary>
        public virtual List<string> GetDescription()
        {
            return _decoratedCoffee.GetDescription();
        }

        #endregion
    }

    /// <summary>
    /// class bổ sung thêm sữa vào cà phê
    /// </summary>
    public class MilkDecorator : DecoratorCoffee
    {
        #region Declare

        /// <summary>
        /// giá của ly cà phê
        /// </summary>
        private readonly int _cost = 2;

        /// <summary>
        /// nguyên liệu cà phê
        /// </summary>
        private readonly string _description = "Sữa đặc không đường";

        #endregion

        #region Constructor

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        #endregion

        #region Methods

        /// <summary>
        /// tổng chi phí
        /// </summary>
        /// <returns></returns>
        public override List<int> GetCost()
        {
            List<int> costs = base.GetCost();
            costs.Add(_cost);
            return costs;
        }

        /// <summary>
        /// thông tin nguyên liệu
        /// </summary>
        public override List<string> GetDescription()
        {
            List<string> descriptions = base.GetDescription();
            descriptions.Add(_description);
            return descriptions;
        }

        #endregion
    }

    /// <summary>
    /// class bổ sung thêm đường vào cà phê
    /// </summary>
    public class SugarDecorator : DecoratorCoffee
    {
        #region Declare

        /// <summary>
        /// giá của ly cà phê
        /// </summary>
        private readonly int _cost = 5;

        /// <summary>
        /// nguyên liệu cà phê
        /// </summary>
        private readonly string _description = "Đường ngọt như tình yêu anh dành cho em";

        #endregion

        #region Constructor

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        #endregion

        #region Methods

        /// <summary>
        /// tổng chi phí
        /// </summary>
        /// <returns></returns>
        public override List<int> GetCost()
        {
            List<int> costs = base.GetCost();
            costs.Add(_cost);
            return costs;
        }

        /// <summary>
        /// thông tin nguyên liệu
        /// </summary>
        public override List<string> GetDescription()
        {
            List<string> descriptions = base.GetDescription();
            descriptions.Add(_description);
            return descriptions;
        }

        #endregion
    }
}
