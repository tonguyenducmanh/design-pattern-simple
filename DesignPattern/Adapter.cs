using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// class Adapter để kết nối vào dòng điện không tương thích
    /// theo mô hình Adapter pattern
    /// </summary>
    public class AdapterElectric : LedInterface
    {
        #region Declare

        /// <summary>
        /// dòng điện cần chuyển đổi
        /// </summary>
        private VietNamElectric _vietNamElectric;

        /// <summary>
        /// dòng điện sẽ giảm bao nhiêu Von
        /// </summary>
        private const int _reduceVonElectric = 217;

        /// <summary>
        /// dòng điện phù hợp để chạy bóng đèn
        /// </summary>
        private const int _suitableVonElectric = 3;

        #endregion

        #region Constructor

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        public AdapterElectric(VietNamElectric vietNamElectric)
        {
            _vietNamElectric = vietNamElectric;
        }

        #endregion

        #region Methods

        /// <summary>
        /// kết nối tới dòng điện
        /// </summary>
        public LedStatus ConnectToElectric()
        {
            // đèn không phát sáng
            LedStatus resultElectric = LedStatus.Off;

            if (_vietNamElectric != null)
            {
                int sourceElectric = _vietNamElectric.VonElectric;
                int outElectric = DownElectric(sourceElectric);

                // điện thế lớn hơn mức cho phép đèn sẽ cháy
                if (outElectric > _suitableVonElectric)
                {
                    resultElectric = LedStatus.Fired;

                }
                // điện thế bằng mức cho phép thì đèn sẽ sáng
                else if (outElectric == _suitableVonElectric)
                {
                    resultElectric = LedStatus.On;
                }
            }
            return resultElectric;
        }

        /// <summary>
        /// giảm điện thế đầu vào tới mức mong muốn
        /// </summary>
        /// <param name="electric">dòng điện đầu vào</param>
        private int DownElectric(int electric)
        {
            return electric - _reduceVonElectric;
        }

        #endregion
    }

    /// <summary>
    /// interface đại diện cho đối tượng đèn led
    /// </summary>
    public interface LedInterface 
    {
        /// <summary>
        /// kết nối tới dòng điện
        /// </summary>
        public LedStatus ConnectToElectric();
    }

    /// <summary>
    /// class đại diện cho mạng lưới điện của Việt Nam
    /// </summary>
    public class VietNamElectric
    {
        /// <summary>
        /// dòng điện của Việt Nam là 220 V
        /// </summary>
        public int VonElectric = 220;
    }

    /// <summary>
    /// trạng thái của bóng đèn sau khi chuyển đổi
    /// </summary>
    public enum LedStatus
    {
        /// <summary>
        /// đèn giờ này đã tắt
        /// </summary>
        Off = 0,

        /// <summary>
        /// đèn đang sáng
        /// </summary>
        On = 1,

        /// <summary>
        /// đèn đã cháy
        /// </summary>
        Fired = -1
    }
}
