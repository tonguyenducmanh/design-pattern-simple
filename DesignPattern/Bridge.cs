using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// class Bridge phân chia logic nghiệp vụ hoặc lớp lớn thành các hệ thống phân cấp lớp riêng biệt có thể được phát triển độc lập theo mô hình Bridge pattern
    /// thay vì tạo ra 1 class có cả điều khiển và thiết bị
    /// tách rời điều khiển và thiết bị thành 2 class, 
    /// rồi thêm thiết bị vào trong hàm khởi tạo của class
    /// </summary>
    public class RemoteControl
    {
        #region Declare

        /// <summary>
        /// thiết bị cần điều khiển
        /// </summary>
        protected IDevice device;

        /// <summary>
        /// khoảng thay đổi volumn
        /// </summary>
        private const int _volumnRange = 10;

        #endregion

        #region Contructor

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        /// <param name="device"></param>
        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        #endregion

        #region Methods

        /// <summary>
        /// bật tắt thiết bị
        /// </summary>
        public void TogglePower()
        {
            if (device.IsEnable())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        /// <summary>
        /// giảm âm lượng
        /// </summary>
        public void VolumnDown()
        {
            device.SetVolume(device.GetVolumne() - _volumnRange);
        }

        /// <summary>
        /// tăng âm lượng
        /// </summary>
        public void VolumnUp() 
        {
            device.SetVolume(device.GetVolumne() + _volumnRange);
        }

        /// <summary>
        /// đổi kênh lên trên
        /// </summary>
        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }

        /// <summary>
        /// đổi kênh xuống dưới
        /// </summary>
        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }

        /// <summary>
        /// có thể tạo ra 1 class khác kế thừa điều khiển tách biệt hoàn toàn với class thiết bị
        /// </summary>
        public class AdvanceRemoteControl : RemoteControl
        {
            #region Contructor

            /// <summary>
            /// hàm khởi tạo
            /// </summary>
            public AdvanceRemoteControl(IDevice device) : base(device)
            {
            }

            #endregion

            #region Methods

            /// <summary>
            /// tắt tiếng của thiết bị
            /// </summary>
            public void MuteDevice()
            {
                device.SetVolume(0);
            }

            #endregion
        }

        #endregion
    }

    /// <summary>
    /// interface khai báo tất cả các method cần thiết của các class impelement cụ thể
    /// không cần phải match với interface của tầng abstraction. 2 interface có thể hoàn toàn tách biệt
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// thiết bị có đang bật không
        /// </summary>
        public bool IsEnable();
        
        /// <summary>
        /// bật thiết bị
        /// </summary>
        public void Enable();

        /// <summary>
        /// tắt thiết bị
        /// </summary>
        public void Disable();

        /// <summary>
        /// lấy giá trị âm lượng của thiết bị
        /// </summary>
        public int GetVolumne();
        
        /// <summary>
        /// thiết lập âm lượng cho thiết bị
        /// </summary>
        public void SetVolume(int percent);
        
        /// <summary>
        /// lấy ra tên kênh hiện tại
        /// </summary>
        /// <returns></returns>
        public int GetChannel();

        /// <summary>
        /// thiết lập giá trị kênh hiện tại
        /// </summary>
        public void SetChannel(int channel);
    }

    /// <summary>
    /// thiết bị tivi
    /// </summary>
    public class Televition : IDevice
    {
        #region  Declare

        /// <summary>
        /// trạng thái bật tắt của thiết bị
        /// </summary>
        private bool _enabled = false;

        /// <summary>
        /// âm lượng của thiết bị
        /// </summary>
        private int _volume = 0;

        /// <summary>
        /// kênh của thiết bị
        /// </summary>
        private int _channel = 0;

        #endregion

        #region Methods

        public void Disable()
        {
            _enabled = false;
        }

        public void Enable()
        {
            _enabled = true;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public int GetVolumne()
        {
            return _volume;
        }

        public bool IsEnable()
        {
            return _enabled;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public void SetVolume(int percent)
        {
            _volume = percent;
        }

        #endregion
    }

    /// <summary>
    /// thiết bị radio
    /// </summary>
    public class Radio : IDevice
    {
        #region  Declare

        /// <summary>
        /// trạng thái bật tắt của thiết bị
        /// </summary>
        private bool _enabled = false;

        /// <summary>
        /// âm lượng của thiết bị
        /// </summary>
        private int _volume = 0;

        /// <summary>
        /// kênh của thiết bị
        /// </summary>
        private int _channel = 0;

        #endregion

        #region Methods

        public void Disable()
        {
            _enabled = false;
        }

        public void Enable()
        {
            _enabled = true;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public int GetVolumne()
        {
            return _volume;
        }

        public bool IsEnable()
        {
            return _enabled;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public void SetVolume(int percent)
        {
            _volume = percent;
        }

        #endregion
    }
}
