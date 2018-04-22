using OfficeOpenXml;
using STL_Auto.Helpers;
using STL_Auto.Models;
using STL_Auto.Services;
using STL_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace STL_Auto
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }

        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel files|*.xls;*.xlsx";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                textBoxPayroll.Text = openFileDialog.FileName;
            }

            var filename = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
            string currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
            string filePath = Path.GetFullPath(currentDirectory);

            if (new ExcelConvert().ConvertXlsx(filename, filePath))
            {
                textBoxPayroll.Text = filePath + "\\" + filename + ".xlsx";
            }
            else
            {
                MessageBox.Show("Invalid file");
            }
        }

        private void buttonGosi_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel files|*.xls;*.xlsx";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxGosi.Text = openFileDialog.FileName;
            }

            var filename = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
            string currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
            string filePath = Path.GetFullPath(currentDirectory);

            if (new ExcelConvert().ConvertXlsx(filename, filePath))
            {
                textBoxGosi.Text = filePath + "\\" + filename + ".xlsx";
            }
            else
            {
                MessageBox.Show("Invalid file");
            }
        }

        private void buttonBig_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel files|*.xls;*.xlsx;*.xlsm";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxBig.Text = openFileDialog.FileName;
            }

            var filename = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);
            string currentDirectory = Path.GetDirectoryName(openFileDialog.FileName);
            string filePath = Path.GetFullPath(currentDirectory);

            if (new ExcelConvert().ConvertXlsx(filename, filePath))
            {
                textBoxBig.Text = filePath + "\\" + filename + ".xlsx";
            }
            else
            {
                MessageBox.Show("Invalid file");
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var dtBigSalaries = new MakeTable().BigSalaries();
            var dsBigSalaries = new DataSet().Tables.Add(dtBigSalaries.TableName);
           
            var payrollConnString = new ConnectionString().GetConnectionString(Path.GetExtension(textBoxPayroll.Text), textBoxPayroll.Text);

            var tablePayroll = "[" + textBoxTblPayroll.Text + "$]";
            var dtPayroll = new ExcelDataTable().GetDataTable(payrollConnString, tablePayroll);
            DataTable dtGosi = null;
            DataTable dtBig = null;

            #region BigSalaries
            var filePath = textBoxBig.Text;
            var cts = GetDataTableData(GetWorkSheetName(filePath), filePath);

            foreach (var ct in cts)
            {
                if (ct.ColoumnCount <= 13)
                {
                    dtBig = ct.Table;
                    break;
                }
            }
            
            Dictionary<string, string> employeeId = new Dictionary<string, string>();
            foreach (DataRow dr in dtBig.Rows)
            {
                for (int i = 0; i < dtBig.Columns.Count; i++)
                {
                    if (new EmployeeIdNo().CheckMatch(dr[i].ToString().Trim()))
                    {
                        dtBigSalaries.Rows.Add(dr[i].ToString().Trim(), "", 0m, 0m, 0m, 0m, 0m, 0m, 0m, dtBig.Rows.IndexOf(dr).ToString());
                        break;
                    }
                }
            }
            #endregion

            #region Gosi
            filePath = textBoxGosi.Text;
            cts = GetDataTableData(GetWorkSheetName(filePath), filePath);

            foreach (var ct in cts)
            {
                if (ct.ColoumnCount == 14)
                {
                    dtGosi = ct.Table;
                    break;
                }
            }

            var empIdIndexGosi = GetGosiEmpIdColumn(dtGosi);
            var batchNoIndexGosi = GetGosiBatchNoColumn(dtGosi);
            var aestheticIndexGosi = GetGosiAestheticColumn(dtGosi);
            var basicSalaryIndexGosi = GetGosiBasicSalaryColumn(dtGosi);
            var housingAllowanceIndexGosi = GetHousingAllowanceColumn(dtGosi);
            var otherEarningsIndexGosi = GetOtherEarningsColumn(dtGosi);

            var EmpIdIndexBigSalaries = 0;
            Int64 emplIdValueGosi;

            foreach (DataRow dr in dtGosi.Rows)
            {
                if (Int64.TryParse(dr[empIdIndexGosi].ToString().Trim(), out emplIdValueGosi))
                {
                    
                    DataRow[] row = dtBigSalaries.Select("Iqama ='" + emplIdValueGosi + "'");
                    if (row != null)
                    {
                        row[0]["BatchNo"] = dr[batchNoIndexGosi];
                        row[0]["Aesthetic"] = Convert.ToDecimal(dr[aestheticIndexGosi]);
                        row[0]["BasicSalary"] = Convert.ToDecimal(dr[basicSalaryIndexGosi]);
                        row[0]["HousingAllowance"] = Convert.ToDecimal(dr[housingAllowanceIndexGosi]);
                        row[0]["OtherEarnings"] = Convert.ToDecimal(dr[otherEarningsIndexGosi]);

                        Console.WriteLine($"{row[0]["BatchNo"]}, {row[0]["Aesthetic"]}, {row[0]["BasicSalary"]}, {row[0]["HousingAllowance"]}, {row[0]["OtherEarnings"]}");

                        dtBigSalaries.AcceptChanges();
                    }

                }
            }
            #endregion

            #region PayrollBigSalary
            //Int64 value3;
            //var payroll = new Dictionary<string, string>();
            //foreach (DataRow dr in dtPayroll.Rows)
            //{
            //    if (Int64.TryParse(dr[0].ToString().Replace(".00","").Trim(), out value3))
            //    {
            //        Console.WriteLine(value3);
            //        foreach (var id in employeeIdBatch)
            //        {
            //            if (value3.ToString() == id.Value)
            //            {
            //                //Check Duplicate here remove then add again
            //                if (!payroll.ContainsKey(id.Key))
            //                {
            //                    payroll.Add(id.Key, dr[21].ToString());
            //                    //Console.WriteLine($"{dr[21]}");
            //                    DataRow[] row = dtBigSalaries.Select("Iqama ='" + id.Key + "'");
            //                    row[0]["Payroll"] = Convert.ToDecimal(dr[21]);
            //                    row[0]["Bank"] = Convert.ToDecimal(dr[21]) >= Convert.ToDecimal(row[0]["Aesthetic"]) ? Convert.ToDecimal(row[0]["Aesthetic"]) : Convert.ToDecimal(dr[21]);
            //                    row[0]["Cash"] = (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"]));
            //                    Console.WriteLine($"{id.Key}, {id.Value}, {Convert.ToDecimal(dr[21])}, {Convert.ToDecimal(row[0]["Aesthetic"])}");
            //                }
            //                else
            //                {
            //                    var firstSalary = payroll[id.Key];
            //                    var salary = Convert.ToDecimal(dr[21]) + Convert.ToDecimal(firstSalary);
            //                    payroll.Remove(id.Key);
            //                    payroll.Add(id.Key, salary.ToString());
            //                    Console.WriteLine($"Duplicate {id.Key} {salary}");
            //                    DataRow[] row = dtBigSalaries.Select("Iqama ='" + id.Key + "'");
            //                    row[0]["Payroll"] = salary;
            //                    row[0]["Bank"] = Convert.ToDecimal(salary) >= Convert.ToDecimal(row[0]["Aesthetic"]) ? Convert.ToDecimal(row[0]["Aesthetic"]) : Convert.ToDecimal(dr[21]);
            //                    row[0]["Cash"] = (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"]));
            //                }
            //                dtBigSalaries.AcceptChanges();
            //            }
            //        }
            //    }
            //}

            #endregion

            //dataGridView1.DataSource = dtBigSalaries;

            //UpdateBigSalaries(dtBigSalaries, textBoxBig.Text);
        }

        private int GetGosiEmpIdColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (new EmployeeIdNo().CheckMatch(dr[i].ToString().Trim()))
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetGosiAestheticColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "الرقم الوظيفي بالمنشأة")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetGosiBatchNoColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "الجمالي بعد البدلات")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetGosiBasicSalaryColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "الأجر الأساسي")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetHousingAllowanceColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "بدل السكن الشهري")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private int GetOtherEarningsColumn(DataTable dTable)
        {
            int columnNum = 0;
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (dr[i].ToString().Trim() == "بدلات أخرى")
                    {
                        columnNum = i;
                        break;
                    }
                }
            }
            return columnNum;
        }

        private void UpdateBigSalaries(DataTable dt, string xPath)
        {
            try
            {
                var fileinfo = new FileInfo(xPath);
                if (fileinfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(fileinfo))
                    {
                        Int64 value;
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (Int64.TryParse(dr[0].ToString().Trim(), out value))
                            {
                                DataRow[] row = dt.Select("Iqama ='" + dr[0] + "'");

                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 6].Value = row[0]["Bank"];
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 7].Value = row[0]["BasicSalary"];
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 8].Value = row[0]["HousingAllowance"];
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 9].Value = row[0]["OtherEarnings"];
                                decimal deduction;
                                try
                                {
                                    deduction = (Convert.ToDecimal(row[0]["BasicSalary"]) + Convert.ToDecimal(row[0]["HousingAllowance"]) + Convert.ToDecimal(row[0]["OtherEarnings"])) - Convert.ToDecimal(row[0]["Bank"]);
                                }
                                catch (Exception e)
                                {
                                    deduction = 0m;
                                }
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 10].Value = deduction;
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 10].Value = TextBoxPaymentDescription.Text;
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 12].Value = "Riyadh";
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 13].Value = "Riyadh";
                                excelWorksheet.Cells[Convert.ToInt32(row[0]["RowNum"]) + 2, 14].Value = "Riyadh";
                            }
                        }
                        excelPackage.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
                        var ws = package.Workbook.Worksheets.Select(x => x.Name);
                        foreach (var sheet in ws)
                        {
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
