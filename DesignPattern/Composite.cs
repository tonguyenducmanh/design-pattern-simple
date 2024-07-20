using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// Component khai báo các method chung cho cả object và composition (chứa object)
    /// </summary>
    public interface ICompositeGraphic
    {
        /// <summary>
        /// di chuyển pixel
        /// </summary>
        public void Move(int xRange, int yRange);
        
        /// <summary>
        /// vẽ pixel
        /// </summary>
        public string Draw();
    }

    /// <summary>
    /// class đại diện cho 1 chiếc lá trong mô hình cây. 
    /// 1 object trong 1 composition.
    /// 1 chiếc lá không thể chứa các đối tượng con khác
    /// class này sẽ làm các công việc thực tế trong khi composition
    /// sẽ ủy thác cho các class này làm việc
    /// </summary>
    public class DotOfComposite : ICompositeGraphic
    {
        #region Declare

        /// <summary>
        /// tọa độ ox của điểm pixel
        /// </summary>
        private int _oxCordinate = 0;

        /// <summary>
        /// tọa độ oy của điểm pixel
        /// </summary>
        private int _oyOYCordinate = 0;

        #endregion

        #region Constructor

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        /// <param name="x">tọa độ x của điểm khởi tạo</param>
        /// <param name="y">tọa độ y của điểm khởi tạo</param>
        public DotOfComposite(int x, int y) 
        {
            _oxCordinate = x;
            _oyOYCordinate = y;
        }

        #endregion

        #region Methods

        /// <summary>
        /// vẽ pixel lên màn hình
        /// </summary>
        public virtual string Draw()
        {
            return $"Draw a pixel at ox: {_oxCordinate}, oy: {_oyOYCordinate}";
        }

        /// <summary>
        /// di chuyển điểm pixel sang tọa độ mới
        /// </summary>
        /// <param name="xRange">dịch chuyển theo trục ox bao nhiêu</param>
        /// <param name="yRange">dịch chuyển theo trục oy bao nhiêu</param>
        public virtual void Move(int xRange, int yRange)
        {
            _oxCordinate += xRange;
            _oyOYCordinate += yRange;
        }

        #endregion
    }

    /// <summary>
    /// các class component có thể kế thừa các component khác
    /// </summary>
    public class CircleOfComposite : DotOfComposite
    {
        #region Declare

        /// <summary>
        /// bán kính của hình tròn
        /// </summary>
        private int _radius = 0;

        #endregion

        #region Constructor

        public CircleOfComposite(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        #endregion

        #region Methods

        public override string Draw()
        {
            return base.Draw() + $" radius: {_radius}";
        }

        #endregion
    }

    /// <summary>
    /// đối tượng phức tạp, là nơi chứa đựng nhiều đối tượng con
    /// (chứa nhiều cái lá). Các đối tượng này thường ủy quyền cho các đối tượng
    /// con làm việc rồi tổng hợp kết quả
    /// </summary>
    public class ComponentOfComposite : ICompositeGraphic
    {
        #region Delcare

        /// <summary>
        /// tập hợp các đối tượng con để tính toán dạng hình cây
        /// </summary>
        private List<ICompositeGraphic> _childrens = new List<ICompositeGraphic>();

        #endregion

        #region Constructor
        
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        public ComponentOfComposite()
        {

        }

        #endregion

        #region Methods giống với các đối tượng con

        /// <summary>
        /// vẽ từng đối tượng con
        /// </summary>
        public string Draw()
        {
            List<string> result = new List<string>();
            if (_childrens.Count > 0) 
            {
                foreach (ICompositeGraphic child in _childrens)
                {
                    result.Add(child.Draw());
                }
            }
            return string.Join(";", result.ToArray());
        }

        /// <summary>
        /// di chuyển từng đối tượng con
        /// </summary>
        public void Move(int xRange, int yRange)
        {
            if (_childrens.Count > 0) 
            {
                foreach (ICompositeGraphic child in _childrens) 
                { 
                    child.Move(xRange, yRange); 
                }
            }
        }

        #endregion

        #region Methods riêng của đổi tượng tập hợp

        /// <summary>
        /// thêm đối tượng con
        /// </summary>
        /// <param name="child"></param>
        public void Add(ICompositeGraphic child) 
        {
            _childrens.Add(child);
        }

        /// <summary>
        /// xóa đối tượng con
        /// </summary>
        /// <param name="child"></param>
        public void Remove(ICompositeGraphic child) 
        {    
            _childrens.Remove(child); 
        }

        #endregion
    }
}
