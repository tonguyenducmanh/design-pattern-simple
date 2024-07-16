using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// class hoạt động theo mô hình Factory pattern
    /// </summary>
    public class FactoryMethod
    {
        /// <summary>
        /// lấy ra service thao tác nghiệp vụ phù hợp theo enum loại file
        /// </summary>
        public PrintBase GetService(FileType enumFile)
        {
            switch (enumFile) 
            { 
                case FileType.Html:
                    return new HtmlPrint();
                case FileType.Word:
                    return new WordPrint();
                case FileType.Excel:
                    return new ExcelPrint();
            }
            throw new NotImplementedException("Chưa cấu hình loại file này");
        }
    }

    /// <summary>
    /// enum loại file cần in
    /// </summary>
    public enum FileType
    {
        Html = 0,
        Word = 1,
        Excel = 2
    }

    /// <summary>
    /// class base chứa 1 hàm in
    /// </summary>
    public abstract class PrintBase
    {
        public abstract string Print();
    }

    /// <summary>
    /// class in dạng file html
    /// </summary>
    public class HtmlPrint() : PrintBase 
    {
        public override string Print() 
        {
            return "Printed Html File";
        }
    }

    /// <summary>
    /// class in dạng file word
    /// </summary>
    public class WordPrint() : PrintBase 
    {
        public override string Print() 
        {
            return "Printed Word File";
        }
    }

    /// <summary>
    /// class in dạng file excel
    /// </summary>
    public class ExcelPrint() : PrintBase 
    {
        public override string Print() 
        {
            return "Printed Excel File";
        }
    }


}
