using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// class theo mô hình SingletonPattern
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// đối tượng khởi tạo 1 lần duy nhất
        /// </summary>
        private static Singleton? instance;

        /// <summary>
        /// đối tượng trỏ tới đối tượng khởi tạo 1 lần duy nhất
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                // kiểm tra xem đã khởi tạo lần nào chưa
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
