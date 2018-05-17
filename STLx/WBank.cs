using STLx.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace STLx
{
    public partial class WBank : Form
    {
        private bool _save;
        public WBank()
        {
            InitializeComponent();
        }

        private void WBank_Load(object sender, EventArgs e)
        {
            ResetControls();
            BindEmployeeWithDataGrid();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxIqama.Enabled = true;
            TextBoxBatchNo.Enabled = true;
            TextBoxName.Enabled = true;
            textBoxBankCode.Enabled = true;
            TextBoxBankAcctNo.Enabled = true;
            textBoxProject.Enabled = true;
            textBoxAddress1.Enabled = true;
            textBoxAddress2.Enabled = true;
            textBoxAddress3.Enabled = true;
            ComboBoxStatusW.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxIqama.Text = "";
            TextBoxBatchNo.Text = "";
            TextBoxName.Text = "";
            textBoxBankCode.Text = "";
            TextBoxBankAcctNo.Text = "";
            textBoxProject.Text = "";
            textBoxAddress1.Text = "";
            textBoxAddress2.Text = "";
            textBoxAddress3.Text = "";
            ComboBoxStatusW.Text = "";
            TextBoxIqama.Focus();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxIqama.Enabled = false;
            TextBoxBatchNo.Enabled = true;
            TextBoxName.Enabled = true;
            textBoxBankCode.Enabled = true;
            TextBoxBankAcctNo.Enabled = true;
            textBoxProject.Enabled = true;
            textBoxAddress1.Enabled = true;
            textBoxAddress2.Enabled = true;
            textBoxAddress3.Enabled = true;
            ComboBoxStatusW.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
            TextBoxIqama.Focus();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (_save)
                    SaveEmployee();
                else
                    EditEmployee();
            }
            else
            {
                MessageBox.Show("There are invalid controls on the form.");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var emp = _context.WithBankAccounts.First(i => i.BatchNo == TextBoxBatchNo.Text);
                    emp.IsDelete = true;
                    _context.SaveChanges();
                    BindEmployeeWithDataGrid();
                    MessageBox.Show("Employee was deleted");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No employee is deleted, Contact Admin.");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindEmployeeWithDataGrid();
        }

        private void EditEmployee()
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var emp = _context.WithBankAccounts.First(e => e.Iqama == TextBoxIqama.Text);
                    emp.Iqama = TextBoxIqama.Text;
                    emp.BatchNo = TextBoxBatchNo.Text;
                    emp.Name = TextBoxName.Text;
                    emp.BankCode = textBoxBankCode.Text;
                    emp.BankAccountNo = TextBoxBankAcctNo.Text;
                    emp.Project = textBoxProject.Text;
                    emp.EmployeeAddress1 = textBoxAddress1.Text;
                    emp.EmployeeAddress2 = textBoxAddress2.Text;
                    emp.EmployeeAddress3 = textBoxAddress3.Text;
                    emp.Status = "YES".Equals(ComboBoxStatusW.Text);
                    _context.SaveChanges();
                    ResetControls();
                    MessageBox.Show("Employee was updated");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error on editing employee.");
            }
        }

        private void SaveEmployee()
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var emp = new Data.WithBankAccount()
                    {
                        Iqama = TextBoxIqama.Text,
                        BatchNo = TextBoxBatchNo.Text,
                        Name = TextBoxName.Text,
                        BankCode = textBoxBankCode.Text,
                        BankAccountNo = TextBoxBankAcctNo.Text,
                        Project = textBoxProject.Text,
                        EmployeeAddress1 = textBoxAddress1.Text,
                        EmployeeAddress2 = textBoxAddress2.Text,
                        EmployeeAddress3 = textBoxAddress3.Text,
                        Status = true,
                        IsDelete = false
                    };
                    _context.WithBankAccounts.Add(emp);
                    _context.SaveChanges();
                    ResetControls();
                    MessageBox.Show("Employee Save");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Employee not save");
            }
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape || keyData == Keys.F5)
            {
                ResetControls();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Validation
        private void TextBoxIqama_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxIqama.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.TextBoxIqama, "You must provide Iqama!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxIqama_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.TextBoxIqama, string.Empty);
        }
        private void TextBoxBatchNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxBatchNo.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.TextBoxBatchNo, "You must provide Batch No.");
            }
            e.Cancel = cancel;
        }
        private void TextBoxBatchNo_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.TextBoxBatchNo, string.Empty);
        }
        private void TextBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxName.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.TextBoxName, "You must provide Name!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxName_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.TextBoxName, string.Empty);
        }
        private void textBoxBankCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxBankCode.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.textBoxBankCode, "You must provide Bank Code!");
            }
            e.Cancel = cancel;
        }
        private void textBoxBankCode_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.textBoxBankCode, string.Empty);
        }
        private void TextBoxBankAcctNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxBankAcctNo.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.TextBoxBankAcctNo, "You must provide Bank Account No!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxBankAcctNo_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.TextBoxBankAcctNo, string.Empty);
        }
        private void textBoxProject_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxProject.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.textBoxProject, "You must provide Project!");
            }
            e.Cancel = cancel;
        }
        private void textBoxProject_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.textBoxProject, string.Empty);
        }
        private void textBoxAddress1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxAddress1.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.textBoxAddress1, "You must provide Address1");
            }
            e.Cancel = cancel;
        }
        private void textBoxAddress1_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.textBoxAddress1, string.Empty);
        }
        private void textBoxAddress2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxAddress2.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.textBoxAddress2, "You must provide Address2");
            }
            e.Cancel = cancel;
        }
        private void textBoxAddress2_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.textBoxAddress2, string.Empty);
        }
        private void textBoxAddress3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxAddress3.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.textBoxAddress3, "You must provide Address3");
            }
            e.Cancel = cancel;
        }
        private void textBoxAddress3_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.textBoxAddress3, string.Empty);
        }
        private void ComboBoxStatus_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.ComboBoxStatusW.Text))
            {
                cancel = true;
                this.errorProviderWithBank.SetError(this.ComboBoxStatusW, "You must provide Status!");
            }
            e.Cancel = cancel;
        }
        private void ComboBoxStatus_Validated(object sender, EventArgs e)
        {
            this.errorProviderWithBank.SetError(this.ComboBoxStatusW, string.Empty);
        }
        #endregion

        private void ResetControls()
        {
            TextBoxIqama.Enabled = false;
            TextBoxBatchNo.Enabled = false;
            TextBoxName.Enabled = false;
            textBoxBankCode.Enabled = false;
            TextBoxBankAcctNo.Enabled = false;
            textBoxProject.Enabled = false;
            textBoxAddress1.Enabled = false;
            textBoxAddress2.Enabled = false;
            textBoxAddress3.Enabled = false;
            ComboBoxStatusW.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxIqama.Text = "";
            TextBoxBatchNo.Text = "";
            TextBoxName.Text = "";
            textBoxBankCode.Text = "";
            TextBoxBankAcctNo.Text = "";
            textBoxProject.Text = "";
            textBoxAddress1.Text = "";
            textBoxAddress2.Text = "";
            textBoxAddress3.Text = "";
            ComboBoxStatusW.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindEmployeeWithDataGrid();
        }

        private void BindEmployeeWithDataGrid()
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var source = _context.WithBankAccounts.Where(e => e.BatchNo.Contains(TextBoxSearch.Text) &&
                                                                         e.Status != false &&
                                                                         e.IsDelete != true);
                    dataGridViewWBank.DataSource = source.ToList();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dataGridViewWBank_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var iqama = dataGridViewWBank.CurrentRow.Cells[0].Value.ToString();

                using (var _context = new STLxEntities())
                {
                    var source = _context.WithBankAccounts.FirstOrDefault(i => i.Iqama == iqama);

                    if (!string.IsNullOrEmpty(source.Iqama))
                    {
                        TextBoxIqama.Text = source.Iqama;
                        TextBoxBatchNo.Text = source.BatchNo;
                        TextBoxName.Text = source.Name;
                        textBoxBankCode.Text = source.BankCode;
                        TextBoxBankAcctNo.Text = source.BankAccountNo;
                        textBoxProject.Text = source.Project;
                        textBoxAddress1.Text = source.EmployeeAddress1;
                        textBoxAddress2.Text = source.EmployeeAddress2;
                        textBoxAddress3.Text = source.EmployeeAddress3;

                        ButtonEdit.Enabled = true;
                        ButtonDelete.Enabled = true;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
