using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// class hoạt động theo mô hình Prototye pattern
    /// </summary>
    public class PersonPrototype
    {
        /// <summary>
        /// tuổi
        /// </summary>
        public int Age;

        /// <summary>
        /// ngày sinh
        /// </summary>
        public DateTime BirthDate;

        /// <summary>
        /// Tên
        /// </summary>
        public string? Name;

        /// <summary>
        /// định danh cá nhân
        /// </summary>
        public PersionIDInfo IDInfo;

        /// <summary>
        /// copy cơ bản
        /// </summary>
        public PersonPrototype ShallowCopy()
        {
            return (PersonPrototype)this.MemberwiseClone();
        }


        /// <summary>
        /// copy sâu
        /// </summary>
        public PersonPrototype DeepCopy()
        {
            PersonPrototype clone = (PersonPrototype)this.MemberwiseClone();
            clone.IDInfo = new PersionIDInfo(this.IDInfo.IDNumber);
            return clone;
        }
    }

    /// <summary>
    /// class giả lập việc định danh cá nhân
    /// </summary>
    public class PersionIDInfo
    {
        /// <summary>
        /// Số định danh cá nhân
        /// </summary>
        public int IDNumber;

        public PersionIDInfo(int IDNumber)
        {
            this.IDNumber = IDNumber;
        }
    }
}
