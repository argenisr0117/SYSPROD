using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaz.Controles;
using System.Data;
using System.Data.OleDb;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Excel;
using DevComponents.DotNetBar;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;


namespace Interfaz
{
    class Utilidades
    {
        public static bool ValidarForm(System.Windows.Forms.Control objForm, ErrorProvider error)
        {
            bool valor = true;
            foreach (System.Windows.Forms.Control obj in objForm.Controls)
            {
                //if (obj.Controls.Count > 0)
                //{
                //    valor = ValidarForm2(obj, error);
                //    continue;
                //}

                if (obj is textbox)
                {
                    textbox obj2 = (textbox)obj;
                    if (obj2.Validar)
                    {
                        if (string.IsNullOrEmpty(obj2.Text.Trim()))
                        {
                            valor = false;

                            error.SetError(obj, (string.IsNullOrEmpty(obj2.Text.Trim())) ? "Campo obligatorio" : "");
                        }
                    }
                }
            }
            return valor;
        }

        public static bool ValidarCombo(System.Windows.Forms.Control objForm, ErrorProvider error)
        {
            bool valor = true;
            foreach (System.Windows.Forms.Control obj in objForm.Controls)
            {
                //if (obj.Controls.Count > 0)
                //{
                //    valor = ValidarForm2(obj, error);
                //    continue;
                //}

                if (obj is comboboxar)
                {
                    comboboxar obj2 = (comboboxar)obj;
                    if (obj2.Validar)
                    {
                        if (string.IsNullOrEmpty(obj2.Text.Trim()))
                        {
                            valor = false;

                            error.SetError(obj, (string.IsNullOrEmpty(obj2.Text.Trim())) ? "Campo obligatorio" : "");
                        }
                    }
                }
                else if (obj is textbox)
                {
                    textbox obj2 = (textbox)obj;
                    if (obj2.Validar)
                    {
                        if (string.IsNullOrEmpty(obj2.Text.Trim()))
                        {
                            valor = false;

                            error.SetError(obj, (string.IsNullOrEmpty(obj2.Text.Trim())) ? "Campo obligatorio" : "");
                        }
                    }
                }
            }
            return valor;
        }
        public static bool ValidarForm2(System.Windows.Forms.Control objForm, ErrorProvider error)
        {
            bool valor = true;
            foreach (System.Windows.Forms.Control obj in objForm.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    valor = ValidarForm2(obj, error);
                    continue;
                }

                if (obj is textbox)
                {
                    textbox obj2 = (textbox)obj;
                    if (obj2.Validar)
                    {
                        if (string.IsNullOrEmpty(obj2.Text.Trim()))
                        {
                            valor = false;

                            error.SetError(obj, (string.IsNullOrEmpty(obj2.Text.Trim())) ? "Campo obligatorio" : "");
                        }
                    }
                }
            }
            return valor;
        }
        public static DataTable ImportarExcel()
        {
            OleDbConnection conn;
            OleDbDataAdapter MyDataAdapter;
            DataTable dt=new DataTable();
            String ruta = "";
            string nombre = "";
            String nombreHoja = "";
            
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }
                if (!string.IsNullOrEmpty(ruta.Trim()))
                {
                    nombre = openfile1.FileName;
                    var Excel = new Excel.Application();
                    Excel.Workbook libro = Excel.Workbooks.Open(nombre);
                    foreach (Excel.Worksheet hoja in libro.Sheets)
                    {
                        nombreHoja = hoja.Name;
                    }
                    conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=No'");
                    MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                    OleDbCommandBuilder comando = new OleDbCommandBuilder(MyDataAdapter);
                    MyDataAdapter.Fill(dt);
                    Excel.Workbooks.Close();
                    //libro.Close();
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.ToString());
            }
            return dt;
        }
       
        public static bool CreateExcelDocument(DataSet ds, string excelFilename)
        {
            try
            {
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(excelFilename, SpreadsheetDocumentType.Workbook))
                {
                    WriteExcelFile(ds, document);
                }
                int ultima;
                Excel.Application Excel_;
                Excel_ = new Excel.Application();
                Excel.Workbook libro = Excel_.Workbooks.Open(excelFilename);
                Excel.Worksheet hoja1 = libro.Sheets[1];
                //hoja1.Rows.ClearFormats();
                //hoja1.Columns.ClearFormats();
                ultima = hoja1.UsedRange.Rows.Count;
                Excel.Range formato;
                int b = 0;
                int p = 1;
                string[] vector = new string[] {"A","B","C","D"};
                for(int x=0;x<ultima;x++)
                {              
                    formato = hoja1.Range[vector[b]+p, vector[b]+p];
                    formato.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    formato.BorderAround2(Excel.XlLineStyle.xlContinuous,
                    Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic,
                    Excel.XlColorIndex.xlColorIndexAutomatic);
                    if (x == ultima - 1)
                    {

                        if (vector[b] == "D")
                        {
                            break;
                        }
                        b++;
                        x = -1;
                        p = 0;
                    }
                    p++;
                }
                hoja1.Range["C1", "C" + ultima].Columns.AutoFit();
                libro.Save();
                libro.Close();
                Excel_.Workbooks.Close();
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ha Fallado, Error: " + ex.Message);
                return false;
            }
        }


        private static void WriteExcelFile(DataSet ds, SpreadsheetDocument spreadsheet)
        {
            //  Create the Excel file contents.  This function is used when creating an Excel file either writing 
            //  to a file, or writing to a MemoryStream.
            spreadsheet.AddWorkbookPart();
            spreadsheet.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

            //  My thanks to James Miera for the following line of code (which prevents crashes in Excel 2010)
            spreadsheet.WorkbookPart.Workbook.Append(new BookViews(new WorkbookView()));

            //  If we don't add a "WorkbookStylesPart", OLEDB will refuse to connect to this .xlsx file !
            WorkbookStylesPart workbookStylesPart = spreadsheet.WorkbookPart.AddNewPart<WorkbookStylesPart>("rIdStyles");
            Stylesheet stylesheet = new Stylesheet();
            workbookStylesPart.Stylesheet = stylesheet;


            //  Loop through each of the DataTables in our DataSet, and create a new Excel Worksheet for each.
            uint worksheetNumber = 1;
            Sheets sheets = spreadsheet.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());
            foreach (DataTable dt in ds.Tables)
            {
                //  For each worksheet you want to create
                string worksheetName = dt.TableName;

                //  Create worksheet part, and add it to the sheets collection in workbook
                WorksheetPart newWorksheetPart = spreadsheet.WorkbookPart.AddNewPart<WorksheetPart>();
                Sheet sheet = new Sheet() { Id = spreadsheet.WorkbookPart.GetIdOfPart(newWorksheetPart), SheetId = worksheetNumber, Name = worksheetName };

                // If you want to define the Column Widths for a Worksheet, you need to do this *before* appending the SheetData
                // http://social.msdn.microsoft.com/Forums/en-US/oxmlsdk/thread/1d93eca8-2949-4d12-8dd9-15cc24128b10/

                sheets.Append(sheet);

                //  Append this worksheet's data to our Workbook, using OpenXmlWriter, to prevent memory problems
                WriteDataTableToExcelWorksheet(dt, newWorksheetPart);

                worksheetNumber++;
            }

            spreadsheet.WorkbookPart.Workbook.Save();

        }

        private static void WriteDataTableToExcelWorksheet(DataTable dt, WorksheetPart worksheetPart)
        {
            OpenXmlWriter writer = OpenXmlWriter.Create(worksheetPart, Encoding.ASCII);
            writer.WriteStartElement(new DocumentFormat.OpenXml.Spreadsheet.Worksheet());
            writer.WriteStartElement(new SheetData());

            string cellValue = "";

            //  Create a Header Row in our Excel file, containing one header for each Column of data in our DataTable.
            //
            //  We'll also create an array, showing which type each column of data is (Text or Numeric), so when we come to write the actual
            //  cells of data, we'll know if to write Text values or Numeric cell values.
            int numberOfColumns = dt.Columns.Count;
            bool[] IsNumericColumn = new bool[numberOfColumns];
            bool[] IsDateColumn = new bool[numberOfColumns];

            string[] excelColumnNames = new string[numberOfColumns];
            for (int n = 0; n < numberOfColumns; n++)
                excelColumnNames[n] = GetExcelColumnName(n);

            //
            //  Create the Header row in our Excel Worksheet
            //
            uint rowIndex = 1;

            writer.WriteStartElement(new Row { RowIndex = rowIndex });
            for (int colInx = 0; colInx < numberOfColumns; colInx++)
            {
                DataColumn col = dt.Columns[colInx];
                AppendTextCell(excelColumnNames[colInx] + "1", col.ColumnName, ref writer);
                IsNumericColumn[colInx] = (col.DataType.FullName == "System.Decimal") || (col.DataType.FullName == "System.Int32") || (col.DataType.FullName == "System.Double") || (col.DataType.FullName == "System.Single");
                IsDateColumn[colInx] = (col.DataType.FullName == "System.DateTime");
            }
            writer.WriteEndElement();   //  End of header "Row"

            //
            //  Now, step through each row of data in our DataTable...
            //
            double cellNumericValue = 0;
            foreach (DataRow dr in dt.Rows)
            {
                // ...create a new row, and append a set of this row's data to it.
                ++rowIndex;

                writer.WriteStartElement(new Row { RowIndex = rowIndex });

                for (int colInx = 0; colInx < numberOfColumns; colInx++)
                {
                    cellValue = dr.ItemArray[colInx].ToString();
                    cellValue = ReplaceHexadecimalSymbols(cellValue);

                    // Create cell with data
                    if (IsNumericColumn[colInx])
                    {
                        //  For numeric cells, make sure our input data IS a number, then write it out to the Excel file.
                        //  If this numeric value is NULL, then don't write anything to the Excel file.
                        cellNumericValue = 0;
                        if (double.TryParse(cellValue, out cellNumericValue))
                        {
                            cellValue = cellNumericValue.ToString();
                            AppendNumericCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, ref writer);
                        }
                    }
                    else if (IsDateColumn[colInx])
                    {
                        //  This is a date value.
                        DateTime dtValue;
                        string strValue = "";
                        if (DateTime.TryParse(cellValue, out dtValue))
                            strValue = dtValue.ToShortDateString();
                        AppendTextCell(excelColumnNames[colInx] + rowIndex.ToString(), strValue, ref writer);
                    }
                    else
                    {
                        //  For text cells, just write the input data straight out to the Excel file.
                        AppendTextCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, ref writer);
                    }
                }
                writer.WriteEndElement(); //  End of Row
            }
            writer.WriteEndElement(); //  End of SheetData
            writer.WriteEndElement(); //  End of worksheet

            writer.Close();
        }

        private static void AppendTextCell(string cellReference, string cellStringValue, ref OpenXmlWriter writer)
        {
            //  Add a new Excel Cell to our Row 
            writer.WriteElement(new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.String
            });
        }

        private static void AppendNumericCell(string cellReference, string cellStringValue, ref OpenXmlWriter writer)
        {
            //  Add a new Excel Cell to our Row 
            writer.WriteElement(new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.Number
            });
        }

        private static string ReplaceHexadecimalSymbols(string txt)
        {
            string r = "[\x00-\x08\x0B\x0C\x0E-\x1F\x26]";
            return Regex.Replace(txt, r, "", RegexOptions.Compiled);
        }

        //  Convert a zero-based column index into an Excel column reference  (A, B, C.. Y, Y, AA, AB, AC... AY, AZ, B1, B2..)
        public static string GetExcelColumnName(int columnIndex)
        {
            //  eg  (0) should return "A"
            //      (1) should return "B"
            //      (25) should return "Z"
            //      (26) should return "AA"
            //      (27) should return "AB"
            //      ..etc..
            char firstChar;
            char secondChar;
            char thirdChar;

            if (columnIndex < 26)
            {
                return ((char)('A' + columnIndex)).ToString();
            }

            if (columnIndex < 702)
            {
                firstChar = (char)('A' + (columnIndex / 26) - 1);
                secondChar = (char)('A' + (columnIndex % 26));

                return string.Format("{0}{1}", firstChar, secondChar);
            }

            int firstInt = columnIndex / 26 / 26;
            int secondInt = (columnIndex - firstInt * 26 * 26) / 26;
            if (secondInt == 0)
            {
                secondInt = 26;
                firstInt = firstInt - 1;
            }
            int thirdInt = (columnIndex - firstInt * 26 * 26 - secondInt * 26);

            firstChar = (char)('A' + firstInt - 1);
            secondChar = (char)('A' + secondInt - 1);
            thirdChar = (char)('A' + thirdInt);

            return string.Format("{0}{1}{2}", firstChar, secondChar, thirdChar);
        }
    }
}

