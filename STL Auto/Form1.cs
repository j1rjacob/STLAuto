using ExcelLibrary.SpreadSheet;
using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace STL_Auto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    if (openFileDialogMeter.ShowDialog() == DialogResult.OK)
            //    {
            //        ImportMeters(openFileDialogMeter.FileNames);
            //    }
            //    MessageBox.Show("Import was successful");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Import was not successful");
            //}
            
            var fileinfo = new FileInfo(@"E:\MaskRider\FormsTemplate\Gosi.xlsx");
            if (fileinfo.Exists)
            {
                using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                {
                    //ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                    ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                    excelWorksheet.Cells["O142"].Value = "Test";
                    //excelWorksheet.Cells[3, 2].Value = "Test2";
                    //excelWorksheet.Cells[3, 3].Value = "Test3";

                    excelPackage.Save();
                    Console.WriteLine("Done");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create new xls file 
            string file = "C:\newdoc.xls";
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("First Sheet");
            worksheet.Cells[0, 1] = new Cell((short)1); worksheet.Cells[2, 0] = new Cell(9999999);
            worksheet.Cells[3, 3] = new Cell((decimal)3.45);
            worksheet.Cells[2, 2] = new Cell("Text string");
            worksheet.Cells[2, 4] = new Cell("Second string");
            worksheet.Cells[4, 0] = new Cell(32764.5, "#,##0.00");
            worksheet.Cells[5, 1] = new Cell(DateTime.Now, @"YYYY-MM-DD");
            worksheet.Cells.ColumnWidth[0, 1] = 3000; workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            // open xls file 
            Workbook book = Workbook.Load(file);
            Worksheet sheet = book.Worksheets[0];

            // traverse cells 
            //foreach (Pair<,>, Cell> cell in sheet.Cells)
            //{
            //    dgvCells[cell.Left.Right, cell.Left.Left].Value = cell.Right.Value;
            //}

            // traverse rows by Index 
            for (int rowIndex = sheet.Cells.FirstRowIndex; rowIndex <= sheet.Cells.LastRowIndex; rowIndex++)
            {
                Row row = sheet.Cells.GetRow(rowIndex);
                for (int colIndex = row.FirstColIndex; colIndex <= row.LastColIndex; colIndex++)
                {
                    Cell cell = row.GetCell(colIndex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = @"E:\MaskRider\Book1.xls";
            //Stream fileStream = System.IO.File.OpenRead(file);
            Workbook book = Workbook.Load(file);
            Worksheet sheet = book.Worksheets[0];
            sheet.Cells[25, 14] = new Cell("Test from junar");
            book.Save(file);
        }
    }
}
