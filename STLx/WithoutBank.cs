using STLx.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace STLx
{
    public partial class WithoutBank : Form
    {
        private string _empId;
        private bool _save;
       
        public WithoutBank()
        {
            InitializeComponent();
        }

        private void WithoutBank_Load(object sender, EventArgs e)
        {
            ResetControls();
            BindEmployeeWithDataGrid();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxIqama.Enabled = true;
            TextBoxBatchNo.Enabled = true;
            TextBoxName.Enabled = true;
            textBoxBankAcct.Enabled = true;
            TextBoxProject.Enabled = true;
            textBoxBWAccount.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxIqama.Text = "";
            TextBoxBatchNo.Text = "";
            _empId = "";
            TextBoxIqama.Focus();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxIqama.Enabled = true;
            TextBoxBatchNo.Enabled = true;
            TextBoxName.Enabled = true;
            textBoxBankAcct.Enabled = true;
            TextBoxProject.Enabled = true;
            textBoxBWAccount.Enabled = true;
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
                    var emp = _context.WithoutBankAccounts.First(j => j.BatchNo == TextBoxSearch.Text.Trim());
                    _context.WithoutBankAccounts.Remove(emp);
                    _context.SaveChanges();
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
                    var emp = _context.WithoutBankAccounts.First(e => e.BatchNo == TextBoxBatchNo.Text);
                    emp.Iqama = TextBoxIqama.Text;
                    emp.BatchNo = TextBoxBatchNo.Text;
                    emp.Name = TextBoxName.Text;
                    emp.BackAccountNo = textBoxBankAcct.Text;
                    emp.Project = TextBoxProject.Text;
                    emp.BWAccount = textBoxBWAccount.Text;
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error on deleting employee.");
            }
        }

        private void SaveEmployee()
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var emp = new Data.WithoutBankAccount()
                    {
                        Iqama = TextBoxIqama.Text,
                        BatchNo = TextBoxBatchNo.Text,
                        Name = TextBoxName.Text,
                        BackAccountNo = textBoxBankAcct.Text,
                        Project = TextBoxProject.Text,
                        BWAccount = textBoxBWAccount.Text,
                        Status = true,
                        IsDelete = false
                    };
                    _context.WithoutBankAccounts.Add(emp);
                    _context.SaveChanges();
                    MessageBox.Show("Employee Save");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Employee not save");
            }
        }

        private void ResetControls()
        {
            TextBoxIqama.Enabled = false;
            TextBoxBatchNo.Enabled = false;
            TextBoxName.Enabled = false;
            textBoxBankAcct.Enabled = false;
            TextBoxProject.Enabled = false;
            textBoxBWAccount.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxIqama.Text = "";
            TextBoxBatchNo.Text = "";
            TextBoxName.Text = "";
            textBoxBankAcct.Text = "";
            TextBoxProject.Text = "";
            textBoxBWAccount.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindEmployeeWithDataGrid();
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
                this.errorProviderWOBank.SetError(this.TextBoxIqama, "You must provide Iqama!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxIqama_Validated(object sender, EventArgs e)
        {
            this.errorProviderWOBank.SetError(this.TextBoxIqama, string.Empty);
        }
        private void TextBoxBatchNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxBatchNo.Text))
            {
                cancel = true;
                this.errorProviderWOBank.SetError(this.TextBoxBatchNo, "You must provide Batch No!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxBatchNo_Validated(object sender, EventArgs e)
        {
            this.errorProviderWOBank.SetError(this.TextBoxBatchNo, string.Empty);
        }
        private void TextBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxName.Text))
            {
                cancel = true;
                this.errorProviderWOBank.SetError(this.TextBoxName, "You must provide Name!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxName_Validated(object sender, EventArgs e)
        {
            this.errorProviderWOBank.SetError(this.TextBoxName, string.Empty);
        }
        private void textBoxBankAcct_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxBankAcct.Text))
            {
                cancel = true;
                this.errorProviderWOBank.SetError(this.textBoxBankAcct, "You must provide Bank Acct!");
            }
            e.Cancel = cancel;
        }
        private void textBoxBankAcct_Validated(object sender, EventArgs e)
        {
            this.errorProviderWOBank.SetError(this.textBoxBankAcct, string.Empty);
        }
        private void TextBoxProject_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxProject.Text))
            {
                cancel = true;
                this.errorProviderWOBank.SetError(this.TextBoxProject, "You must provide Project!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxProject_Validated(object sender, EventArgs e)
        {
            this.errorProviderWOBank.SetError(this.TextBoxProject, string.Empty);
        }
        private void textBoxBWAccount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxBWAccount.Text))
            {
                cancel = true;
                this.errorProviderWOBank.SetError(this.textBoxBWAccount, "You must provide BW Account!");
            }
            e.Cancel = cancel;
        }
        private void textBoxBWAccount_Validated(object sender, EventArgs e)
        {
            this.errorProviderWOBank.SetError(this.textBoxBWAccount, string.Empty);
        }
        #endregion

        private void BindEmployeeWithDataGrid()
        {   
            try
            {
                using (var _context = new STLxEntities())
                {
                    var source = _context.WithoutBankAccounts.Where(e => e.BatchNo.Contains(TextBoxSearch.Text));
                    dataGridViewWOBank.DataSource = source.ToList();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dataGridViewWOBank_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var iqama = dataGridViewWOBank.CurrentRow.Cells[0].Value.ToString();

                using (var _context = new STLxEntities())
                {
                    var source = _context.WithoutBankAccounts.FirstOrDefault(i => i.Iqama == iqama);

                    if (!string.IsNullOrEmpty(source.Iqama))
                    {
                        TextBoxIqama.Text = source.Iqama;
                        TextBoxBatchNo.Text = source.BatchNo;
                        TextBoxName.Text = source.Name;
                        textBoxBankAcct.Text = source.BackAccountNo;
                        TextBoxProject.Text = source.Project;
                        textBoxBWAccount.Text = source.BWAccount;

                        _empId = source.Iqama; ;
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
