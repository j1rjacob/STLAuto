using ExcelLibrary.SpreadSheet;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using STL_Auto.Helpers;
using STL_Auto.Models;
using STL_Auto.Services;
using STL_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Workbook = ExcelLibrary.SpreadSheet.Workbook;
using Worksheet = ExcelLibrary.SpreadSheet.Worksheet;

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

            //var fileinfo = new FileInfo(@"E:\MaskRider\FormsTemplate\Gosi.xlsx");
            //if (fileinfo.Exists)
            //{
            //    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
            //    {
            //        //ExcelWorkbook excelWorkBook = excelPackage.Workbook;
            //        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
            //        excelWorksheet.Cells["O142"].Value = "Test";
            //        //excelWorksheet.Cells[3, 2].Value = "Test2";
            //        //excelWorksheet.Cells[3, 3].Value = "Test3";

            //        excelPackage.Save();
            //        Console.WriteLine("Done");
            //    }
            //}

            OpenFileDialogExcel.Filter = "Excel files|*.xls;*.xlsx;*.xlsm";
            DialogResult result = OpenFileDialogExcel.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextBoxFiles.Text = OpenFileDialogExcel.FileName;
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

        private void ButtonCompute_Click(object sender, EventArgs e)
        {
            var fileinfo = new FileInfo(@"E:\MaskRider\FormsTemplate\Gosi.xlsx");
            if (fileinfo.Exists)
            {
                using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                {
                    ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                    var x = new Helpers.Util().ToDataTable(excelWorksheet,true);
                    dataGridView1.DataSource = x;
                    Console.WriteLine("Done");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var denominations = new[]
            //{
            //    500m, 200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m,
            //    0.5m, 0.2m, 0.1m, 0.05m, 0.02m, 0.01m
            //};

            //var amount = Convert.ToDecimal(Console.ReadLine());

            //var change = new List<decimal>();
            //var remaining = amount;
            //foreach (var denomination in denominations)
            //{
            //    while (remaining >= denomination)
            //    {
            //        remaining -= denomination;
            //        change.Add(denomination);
            //    }
            //}

            //var display =
            //    String.Join(
            //        Environment.NewLine,
            //        change
            //            .GroupBy(x => x)
            //            .Select(x => String.Format("{0}x{1}", x.Count(), x.Key)));

            var filename = Path.GetFileNameWithoutExtension(OpenFileDialogExcel.SafeFileName);
            string currentDirectory = Path.GetDirectoryName(OpenFileDialogExcel.FileName);
            string filePath = Path.GetFullPath(currentDirectory);

            if (new ExcelConvert().ConvertXlsx(filename, filePath))
            {
                TextBoxFiles.Text = filePath + "\\" + filename + ".xlsx";
            }
            else
            {
                MessageBox.Show("Invalid file");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(EmployeeIdNo.CheckMatch("2001458797").ToString());
            //var xs =  WorkSheetName.Get(@"E:\MaskRider\mahmoud\gosi march.xlsx");
            //foreach (var x in xs)
            //{
            //    Console.WriteLine(x.ToString());
            //}
            try
            {
                var fileinfo = new FileInfo("E:\\MaskRider\\mahmoud\\LATEST UPDATE PAYROLL\\BIG SALARIES ORIGINAL - UPDATED  April 02,2018.xlsx");
                if (fileinfo.Exists)
                {
                    using (var package = new ExcelPackage(fileinfo))
                    {
                        var ys = package.Workbook.Worksheets.Select(x => x.Name);
                        foreach (var y in ys)
                        {
                            Console.WriteLine(y);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Characters a α à¤•   
            string a = "الرقم الوظيفي بالمنشأة";
            byte[] name = Encoding.UTF8.GetBytes(a);
            foreach (var n in name)
            {
                Console.WriteLine(n);
            }
            // Just for sake of pausing  
            //Console.Read();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var money = new Dictionary<string, Int32>();
            var amount = Convert.ToInt32(329);

            money.Add("500+", (int)amount/500);
            amount %= 500;

            money.Add("100+", (int)amount/100);
            amount %= 100;

            money.Add("50+", (int)amount/50);
            amount %= 50;

            money.Add("10+", (int)amount/10);
            amount %= 10;

            money.Add("5+", (int)amount/5);
            amount %= 5;

            money.Add("1+", (int)amount/1);

            foreach (var m in money)
            {
                MessageBox.Show($"{m.Key} {m.Value}");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            var colNum = 20;
            var fileinfo = new FileInfo(@"E:\MaskRider\App\STL Auto\STL Auto\bin\Debug\Template\PayrollProof.xlsx");
            if (fileinfo.Exists)
            {
                using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                {
                    ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                    excelWorksheet.InsertRow(9, colNum);
                    //excelWorksheet.Cells["D1"];
                    var modelRows = 9+ colNum;
                    string modelRange = "A9:N" + modelRows;
                    var modelTable = excelWorksheet.Cells[modelRange];

                    // Assign borders
                    modelTable.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    modelTable.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    modelTable.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    modelTable.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                    excelPackage.Save();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //var dtBigSalaries = new MakeTable().BigSalaries();
            //DataTable dtBig = null;

            //var filePath = @"E:\MaskRider\mahmoud\LATEST UPDATE PAYROLL\BIG SALARIES ORIGINAL - UPDATED  April 02,2018.xlsx";
            //var ctsB = GetDataTableData(GetWorkSheetName(filePath), filePath);

            //foreach (var ct in ctsB)
            //{
            //    if (ct.ColoumnCount >= 13)
            //    {
            //        dtBig = ct.Table;
            //        break;
            //    }
            //}

            //foreach (DataRow dr in dtBig.Rows)
            //{
            //    for (int i = 0; i < dtBig.Columns.Count; i++)
            //    {
            //        if (new EmployeeIdNo().CheckMatch(dr[i].ToString().Trim()))
            //        {
            //            dtBigSalaries.Rows.Add(dr[i].ToString().Trim(), dr[i - 1].ToString().Trim(), 0m, 0m, 0m, 0m, 0m, 0m, 0m, dtBig.Rows.IndexOf(dr).ToString());
            //            break;
            //        }
            //    }
            //}

            var fileinfo = new FileInfo(@"E:\MaskRider\mahmoud\LATEST UPDATE PAYROLL\Payroll 1189 format Org UPDATED April 01-2018 NEW.xlsx");
            if (fileinfo.Exists)
            {
                using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                {
                    ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[2];
                    //var sheet = excelPackage.Workbook.Worksheets[sheetname_orSheetIndex];
                    excelWorksheet.Cells
                        .Where(cell =>
                            cell.Address.StartsWith("H")
                            && cell.Value is double
                            && (double)cell.Value == 00d)
                        .Select(cell => cell.Start.Row)
                        .ToList()
                        .ForEach(r => excelWorksheet.Row(r).Hidden = true);

                    //foreach (var o in objs)
                    //{
                    //    Console.WriteLine(o);
                    //}

                    //excelWorksheet.DeleteRow(1, 5, true);
                    excelPackage.Save();
                }
            }
        }

        private List<CustomTable> GetDataTableData(List<string> workSheetName, string filePath)
        {
            var ct = new List<CustomTable>();
            try
            {
                for (int i = 0; i < workSheetName.Count - 1; i++)
                {
                    var dtConnString =
                        new ConnectionString()
                            .GetConnectionString(Path.GetExtension(filePath), filePath);

                    ct.Add(new CustomTable()
                    {
                        Table = new ExcelDataTable().GetDataTable(dtConnString, "[" + workSheetName[i] + "$]"),
                        ColoumnCount = new ExcelDataTable().GetDataTable(dtConnString, "[" + workSheetName[i] + "$]").Columns.Count
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return ct;
        }

        private List<string> GetWorkSheetName(string path)
        {
            var wsName = new List<string>();
            try
            {
                var fileinfo = new FileInfo(path);
                if (fileinfo.Exists)
                {
                    using (var package = new ExcelPackage(fileinfo))
                    {
                        package.Workbook.Worksheets.Add("Halla"); //WorkAround for list...
                        var ws = package.Workbook.Worksheets.Select(x => x.Name);
                        foreach (var sheet in ws)
                        {
                            //Console.WriteLine(sheet);
                            wsName.Add(sheet);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return wsName;
        }

    }
}
