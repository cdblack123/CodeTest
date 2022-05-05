using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelMan = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data;
//using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;

namespace CodeTest
{
    sealed class ExcelDataManager
    {


        public ExcelMan.Application xlApp { get; private set; }
        public ExcelMan.Worksheet xlWorkSheet { get; private set; }

        public ExcelMan.Workbook xlWkBook { get; private set; }

        private readonly string _wkBookPath;


        public ExcelDataManager(string wkBookPath)
        {
            _wkBookPath = wkBookPath;
            xlApp = new ExcelMan.Application();
            xlApp.Visible = false;

        }

        public void openWorkBook(string sheetName)
        {
            try
            {
                xlWkBook = xlApp.Workbooks.Open(_wkBookPath);

                xlWorkSheet = xlWkBook.Worksheets[sheetName];
            }
            catch
            {
                throw;
            }
        }


        DataTable csvDataTable;

        public DataTable getDataTable()
        {
            csvDataTable = new System.Data.DataTable();
            // the system needs to be able to bind ANY spreadsheet data, so should accommodate any number of columns/rows

            // 1st, get the columns (top row of sheet) 
            buildHeaders();


            return csvDataTable;
        }


        public void killExcel()
        {
            xlWkBook.Close();
            xlApp.Quit();
            
        }

        private void buildHeaders()
        {

            string columnName;
            int colCount = 1;

            do
            {
                ExcelMan.Range rng = xlWorkSheet.Cells[1, colCount];
                columnName = rng.Value;
                
                if (columnName != null)
                {
                    DataColumn dataCol = csvDataTable.Columns.Add(columnName);
                    colCount++;
                }
            }
            while (columnName != null);

            buildRows(colCount);
        }

        private void buildRows(int columnCount)
        {
            int rowCnt = 2; // will always start at 2 with 1 as the header
            dynamic dataValue;
            do
            {
                DataRow dr = csvDataTable.Rows.Add();
                for (int i = 0; i < columnCount - 1; i++)
                {
                    ExcelMan.Range r = xlWorkSheet.Cells[rowCnt, i+1];
                    var rowVal = r.Value;
                    dr[i] = rowVal;

                }
                rowCnt++;
                ExcelMan.Range rng = xlWorkSheet.Cells[rowCnt, 1];
                dataValue = rng.Value;

            }
            while (dataValue != null);

        }




    }
}
