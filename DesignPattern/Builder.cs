using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// Class theo mô hình Builder pattern
    /// </summary>
    public class Builder
    {
        #region Declare

        /// <summary>
        /// đối tượng cần build
        /// </summary>
        private StringDateTime _stringDateTime = new StringDateTime();

        #endregion

        #region Method Build
        private string BuildNumber(int number)
        {
            if (number < 10)
            {
                return "0" + number.ToString();
            }
            else
            {
                return number.ToString();
            }
        }
        public Builder BuildMinute(int minute)
        {
            _stringDateTime.BuildMinute(BuildNumber(minute));
            return this;
        }

        public Builder BuildSecond(int second)
        {
            _stringDateTime.BuildSecond(BuildNumber(second));
            return this;
        }

        public Builder BuildHour(int hour)
        {
            _stringDateTime.BuildHour(BuildNumber(hour));
            return this;
        }

        public Builder BuildDay(int day) 
        {
            _stringDateTime.BuildDay(BuildNumber(day));
            return this;
        }

        public Builder BuildMonth(int month) 
        {
            _stringDateTime.BuildMonth(BuildNumber(month));
            return this;
        }
        public Builder BuildYear(int year) 
        {
            _stringDateTime.BuildYear(BuildNumber(year));
            return this;
        }

        #endregion

        /// <summary>
        /// lấy ra kết quả sau khi build
        /// </summary>
        /// <returns></returns>
        public string GetResult()
        {
            return _stringDateTime.ToString();
        }
    }

    /// <summary>
    /// class của đối tượng cần build
    /// </summary>
    public class StringDateTime
    {
        #region Declare

        /// <summary>
        /// phút
        /// </summary>
        private string _minute = "00";

        /// <summary>
        /// giây
        /// </summary>
        private string _second = "00";

        /// <summary>
        /// giờ
        /// </summary>
        private string _hour = "12";

        /// <summary>
        /// ngày
        /// </summary>
        private string _day = "01";

        /// <summary>
        /// tháng
        /// </summary>
        private string _month = "01";

        /// <summary>
        /// năm
        /// </summary>
        private string _year = "1970";

        #endregion

        #region Methods

        public void BuildMinute(string minute)
        {
            _minute = minute;
        }
        public void BuildSecond(string second) 
        {
            _second = second;
        }
        public void BuildHour(string hour)
        {
            _hour = hour;
        }
        public void BuildDay(string day) 
        {
            _day = day;
        }
        public void BuildMonth(string month) 
        {
            _month = month;
        }
        public void BuildYear(string year) 
        {
            _year = year;
        }

        public override string ToString() 
        {
            return $"{_day}/{_month}/{_year} {_hour}:{_minute}:{_second}";
        }

        #endregion
    }
}
