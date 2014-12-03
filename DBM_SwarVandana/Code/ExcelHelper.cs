using System;
using NPOI.HSSF.UserModel;//For using NPOI dll 
using System.IO;//For memory stream
using System.Data;
using NPOI.SS.UserModel;
using System.Web;
using System.Linq;
namespace Code
{
    public class ExcelHelper
    {
        //This function is use to Export To Excel user need to input a datatable fo this
        //This function User the NPOI.Dll  need to include NPOI.dll to create Excel
        public static MemoryStream Export(DataTable dt, string sheetName)
        {
            //Create new Excel Workbook
            var workbook = new HSSFWorkbook();
            //Create new Excel Sheet
            var sheet = workbook.CreateSheet(sheetName);
            //Create a header row
            var headerRow = sheet.CreateRow(0);
            int totalcolumns = dt.Columns.Count;
            int columncounter = 0;

            if (dt.Rows.Count > 0)
            {
                foreach (DataColumn c in dt.Columns)
                {
                    headerRow.CreateCell(columncounter).SetCellValue(c.ColumnName);
                    columncounter++;
                }
                //(Optional) freeze the header row so it is not scrolled
                sheet.CreateFreezePane(0, 1, 0, 1);

                int rowNumber = 1;
                //Populate the sheet with values from the grid data
                foreach (var rows in dt.Rows)
                {
                    //Create a new Row
                    var row = sheet.CreateRow(rowNumber);
                    //Set cell Value
                    for (int cellnumber = 0; cellnumber < columncounter; cellnumber++)
                        row.CreateCell(cellnumber).SetCellValue(dt.Rows[rowNumber - 1][cellnumber].ToString());
                    rowNumber++;
                }
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                    headerRow.CreateCell(i).SetCellValue("");
            }
            //Write the Workbook to a memory stream
            MemoryStream output = new MemoryStream();
            workbook.Write(output);
            return output;
        }


    }
}