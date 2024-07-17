using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    #region Application Config

    /// <summary>
    /// Ứng dụng mong muốn custom cho nhiều hệ điều hành
    /// </summary>
    public class ApplicationAbtractFactory
    {
        #region Declare

        /// <summary>
        /// factory tạo ra GUI (giao diện người dùng ứng dụng)
        /// </summary>
        private GUIFactory? _factory;

        /// <summary>
        /// button của ứng dụng
        /// </summary>
        private Button? _button;


        /// <summary>
        /// check box của ứng dụng
        /// </summary>
        private Checkbox? _checkbox;

        #endregion

        #region Constructor

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        /// <param name="factory">loại GUI cần tạo</param>
        public ApplicationAbtractFactory(EnumOS OSType)
        {
            switch (OSType) 
            {
                case EnumOS.Window:
                    _factory = new WindowFactory();
                    break;
                case EnumOS.Mac:
                    _factory = new MacFactory();
                    break;
                case EnumOS.Ubuntu:
                    _factory = new UbuntuFactory();
                    break;
                default:
                    throw new NotImplementedException("Không tìm ra os phù hợp");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// vẽ UI (giao diện người dùng) cho ứng dụng
        /// </summary>
        public void CreateUI()
        {
            if(_factory == null)
            {
                throw new NotImplementedException("Chưa khởi tạo được factory để vẽ giao diện người dùng cho ứng dụng này");
            }
            else
            {
                // vẽ nút button và ô check box
                _button = _factory.CreateButton();
                _checkbox = _factory.CreateCheckbox();
            }
        }

        /// <summary>
        /// gọi các hàm vẽ các element
        /// </summary>
        public List<string> Paint()
        {
            List<string> result = new List<string>();
            if (_button != null) 
            {
                result.Add(_button.Paint());
            }
            if (_checkbox != null)
            {
                result.Add(_checkbox.Paint());
            }
            return result;
        }
        #endregion
    }

    /// <summary>
    /// config hệ điều hành
    /// </summary>
    public class ConfigOS
    {
        /// <summary>
        /// loại hệ điều hành
        /// </summary>
        public EnumOS OSName { get; set; }
    }

    /// <summary>
    /// enum hệ điều hành
    /// </summary>
    public enum EnumOS
    {
        Window = 0,
        Mac = 1,
        Ubuntu = 2,
    }

    #endregion

    #region Interface

    /// <summary>
    /// interface loại GUI được áp dụng
    /// </summary>
    public interface GUIFactory
    {
        /// <summary>
        /// tạo nút bấm
        /// </summary>
        public Button CreateButton();

        /// <summary>
        /// tạo ô check box true false
        /// </summary>
        public Checkbox CreateCheckbox();
    }

    /// <summary>
    /// interface tạo nút bấm
    /// </summary>
    public interface Button
    {
        /// <summary>
        /// hàm vẽ style ô check box
        /// </summary>
        public string Paint();
    }

    /// <summary>
    /// interface tạo ô check box true false
    /// </summary>
    public interface Checkbox
    {
        /// <summary>
        /// hàm vẽ style ô check box
        /// </summary>
        public string Paint();
    }

    #endregion

    #region Window OS

    /// <summary>
    /// class tạo ra GUI cho hệ điều hành window
    /// </summary>
    public class WindowFactory : GUIFactory
    {
        /// <summary>
        /// tạo nút bấm cho hệ điều hành window
        /// </summary>
        public Button CreateButton()
        {
            return new WindowButton();
        }

        /// <summary>
        /// tạo ô check box cho hệ điều hành window
        /// </summary>
        public Checkbox CreateCheckbox()
        {
            return new WindowCheckbox();
        }
    }

    /// <summary>
    /// class nút bấm của hệ điều hành window
    /// </summary>
    public class WindowButton : Button
    {
        /// <summary>
        /// vẽ nút bấm
        /// </summary>
        public string Paint()
        {
            return "Draw window os style button";
        }
    }

    /// <summary>
    /// class ô check box của hệ điều hành window
    /// </summary>
    public class WindowCheckbox : Checkbox
    {
        /// <summary>
        /// vẽ ô check box
        /// </summary>
        /// <returns></returns>
        public string Paint()
        {
            return "Draw window os style check box";
        }
    }

    #endregion

    #region Mac OS

    /// <summary>
    /// class tạo ra GUI cho hệ điều hành Mac
    /// </summary>
    public class MacFactory : GUIFactory
    {
        /// <summary>
        /// tạo nút bấm cho hệ điều hành Mac
        /// </summary>
        public Button CreateButton()
        {
            return new MacButton();
        }

        /// <summary>
        /// tạo ô check box cho hệ điều hành Mac
        /// </summary>
        public Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }

    /// <summary>
    /// class nút bấm của hệ điều hành Mac
    /// </summary>
    public class MacButton : Button
    {
        /// <summary>
        /// vẽ nút bấm
        /// </summary>
        public string Paint()
        {
            return "Draw Mac os style button";
        }
    }

    /// <summary>
    /// class ô check box của hệ điều hành Mac
    /// </summary>
    public class MacCheckbox : Checkbox
    {
        /// <summary>
        /// vẽ ô check box
        /// </summary>
        /// <returns></returns>
        public string Paint()
        {
            return "Draw Mac os style check box";
        }
    }

    #endregion

    #region Ubuntu OS

    /// <summary>
    /// class tạo ra GUI cho hệ điều hành Ubuntu
    /// </summary>
    public class UbuntuFactory : GUIFactory
    {
        /// <summary>
        /// tạo nút bấm cho hệ điều hành Ubuntu
        /// </summary>
        public Button CreateButton()
        {
            return new UbuntuButton();
        }

        /// <summary>
        /// tạo ô check box cho hệ điều hành Ubuntu
        /// </summary>
        public Checkbox CreateCheckbox()
        {
            return new UbuntuCheckbox();
        }
    }

    /// <summary>
    /// class nút bấm của hệ điều hành Ubuntu
    /// </summary>
    public class UbuntuButton : Button
    {
        /// <summary>
        /// vẽ nút bấm
        /// </summary>
        public string Paint()
        {
            return "Draw Ubuntu os style button";
        }
    }

    /// <summary>
    /// class ô check box của hệ điều hành Ubuntu
    /// </summary>
    public class UbuntuCheckbox : Checkbox
    {
        /// <summary>
        /// vẽ ô check box
        /// </summary>
        /// <returns></returns>
        public string Paint()
        {
            return "Draw Ubuntu os style check box";
        }
    }

    #endregion
}
