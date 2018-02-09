using Excel = Microsoft.Office.Interop.Excel;

namespace Mozzie.Excelerator
{
    internal class Excelerator
    {
        public Excelerator(){
            var spreadsheet = new Excel.Application();
            spreadsheet.Visible = false;
        }
    }
}