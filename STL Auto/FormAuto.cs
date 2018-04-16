using OfficeOpenXml;
using STL_Auto.Helpers;
using STL_Auto.Services;
using STL_Auto.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace STL_Auto
{
    public enum Col
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z
    }
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

            if (ExcelConvert.ConvertXlsx(filename, filePath))
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

            if (ExcelConvert.ConvertXlsx(filename, filePath))
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

            if (ExcelConvert.ConvertXlsx(filename, filePath))
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
            var dtBigSalaries = MakeTable.BigSalaries();
            var dsBigSalaries = new DataSet().Tables.Add(dtBigSalaries.TableName);
           
            var payrollConnString = Path.GetExtension(textBoxPayroll.Text).GetConnectionString(textBoxPayroll.Text);
            var gosiConnString = Path.GetExtension(textBoxGosi.Text).GetConnectionString(textBoxGosi.Text);
            var bigConnString = Path.GetExtension(textBoxBig.Text).GetConnectionString(textBoxBig.Text);

            var tablePayroll = "[" + textBoxTblPayroll.Text + "$]";
            var dtPayroll = payrollConnString.GetDataTable(tablePayroll);
            var tableGosi = "[" + textBoxTblGosi.Text + "$]";
            var dtGosi = gosiConnString.GetDataTable(tableGosi);
            var tableBig = "[" + textBoxTblBig.Text + "$]";
            var dtBig = bigConnString.GetDataTable(tableBig);

            #region EmpIdBigSalaries
            Col colIndex = (Col) Enum.Parse(typeof(Col), TextBoxCol.Text) ;
            Int64 value;
            Dictionary<string, string> employeeId = new Dictionary<string, string>();
            foreach (DataRow dr in dtBig.Rows)
            {
                if (Int64.TryParse(dr[(int)colIndex].ToString().Trim(), out value))
                {
                    employeeId.Add(value.ToString(), dtBig.Rows.IndexOf(dr).ToString());
                }
            }
            #endregion

            #region BatchIdIqama
            Int64 value2;
            var employeeIdBatch = new Dictionary<string, string>();
            foreach (DataRow dr in dtGosi.Rows)
            {
                //Console.WriteLine(dr[4].ToString());
                if (Int64.TryParse(dr[4].ToString().Trim(), out value2))
                {
                    foreach (var id in employeeId)
                    {
                        if (value2.ToString() == id.Key)
                        {
                            if (!employeeIdBatch.ContainsKey(id.Key))
                            {
                                employeeIdBatch.Add(id.Key, dr[2].ToString());
                                dtBigSalaries.Rows.Add(id.Key, dr[2].ToString(), Convert.ToDecimal(dr[13].ToString()), 0m, 0m, 0m, Convert.ToDecimal(dr[8]), Convert.ToDecimal(dr[10]), Convert.ToDecimal(dr[12]), id.Value);
                                //Console.WriteLine(id.Key, dr[2].ToString(), Convert.ToDecimal(dr[13].ToString()), 0m, 0m, 0m, Convert.ToDecimal(dr[8]), Convert.ToDecimal(dr[10]), Convert.ToDecimal(dr[12]), id.Value);
                                //Console.WriteLine($"{id.Key} {dr[2]} {Convert.ToDecimal(dr[13].ToString())} {Convert.ToDecimal(dr[8])} {Convert.ToDecimal(dr[10])} {Convert.ToDecimal(dr[12])} {id.Value}");
                            }
                        }
                    }
                }
            }
            #endregion

            #region PayrollBigSalary
            Int64 value3;
            var payroll = new Dictionary<string, string>();
            foreach (DataRow dr in dtPayroll.Rows)
            {
                if (Int64.TryParse(dr[0].ToString().Replace(".00","").Trim(), out value3))
                {
                    Console.WriteLine(value3);
                    foreach (var id in employeeIdBatch)
                    {
                        if (value3.ToString() == id.Value)
                        {
                            //Check Duplicate here remove then add again
                            if (!payroll.ContainsKey(id.Key))
                            {
                                payroll.Add(id.Key, dr[21].ToString());
                                //Console.WriteLine($"{dr[21]}");
                                DataRow[] row = dtBigSalaries.Select("Iqama ='" + id.Key + "'");
                                row[0]["Payroll"] = Convert.ToDecimal(dr[21]);
                                row[0]["Bank"] = Convert.ToDecimal(dr[21]) >= Convert.ToDecimal(row[0]["Aesthetic"]) ? Convert.ToDecimal(row[0]["Aesthetic"]) : Convert.ToDecimal(dr[21]);
                                row[0]["Cash"] = (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"]));
                                Console.WriteLine($"{id.Key}, {id.Value}, {Convert.ToDecimal(dr[21])}, {Convert.ToDecimal(row[0]["Aesthetic"])}");
                            }
                            else
                            {
                                var firstSalary = payroll[id.Key];
                                var salary = Convert.ToDecimal(dr[21]) + Convert.ToDecimal(firstSalary);
                                payroll.Remove(id.Key);
                                payroll.Add(id.Key, salary.ToString());
                                Console.WriteLine($"Duplicate {id.Key} {salary}");
                                DataRow[] row = dtBigSalaries.Select("Iqama ='" + id.Key + "'");
                                row[0]["Payroll"] = salary;
                                row[0]["Bank"] = Convert.ToDecimal(salary) >= Convert.ToDecimal(row[0]["Aesthetic"]) ? Convert.ToDecimal(row[0]["Aesthetic"]) : Convert.ToDecimal(dr[21]);
                                row[0]["Cash"] = (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"])) < 0 ? 0 : (Convert.ToDecimal(row[0]["Payroll"]) - Convert.ToDecimal(row[0]["Aesthetic"]));
                            }
                            dtBigSalaries.AcceptChanges();
                        }
                    }
                }
            }
            #endregion

            dataGridView1.DataSource = dtBigSalaries;

            UpdateBigSalaries(dtBigSalaries, textBoxBig.Text);
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
    }
}
