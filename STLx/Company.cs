using STLx.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace STLx
{
    public partial class Company : Form
    {
        private bool _save;
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            ResetControls();
            BindCompanyWithDataGrid();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxCode.Enabled = true;
            TextBoxName.Enabled = true;
            ComboBoxStatus.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            TextBoxCode.Text = "";
            TextBoxName.Text = "";
            ComboBoxStatus.Text = "";
            TextBoxCode.Focus();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxCode.Enabled = false;
            TextBoxName.Enabled = true;
            ComboBoxStatus.Enabled = true;
            ButtonNew.Enabled = false;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = true;
            ButtonDelete.Enabled = false;
            _save = false;
            TextBoxCode.Focus();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (_save)
                    SaveCompany();
                else
                    EditCompany();
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
                    var emp = _context.Companies.First(i => i.Code == TextBoxCode.Text);
                    emp.IsDelete = true;
                    _context.SaveChanges();
                    BindCompanyWithDataGrid();
                    MessageBox.Show("Company was deleted");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No company is deleted, Contact Admin.");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BindCompanyWithDataGrid();
        }

        #region Validation
        private void TextBoxCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxCode.Text))
            {
                cancel = true;
                this.errorProviderCompany.SetError(this.TextBoxCode, "You must provide Code!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxCode_Validated(object sender, EventArgs e)
        {
            this.errorProviderCompany.SetError(this.TextBoxCode, string.Empty);
        }
        private void TextBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.TextBoxName.Text))
            {
                cancel = true;
                this.errorProviderCompany.SetError(this.TextBoxName, "You must provide Name!");
            }
            e.Cancel = cancel;
        }
        private void TextBoxName_Validated(object sender, EventArgs e)
        {
            this.errorProviderCompany.SetError(this.TextBoxName, string.Empty);
        }
        private void ComboBoxStatus_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.ComboBoxStatus.Text))
            {
                cancel = true;
                this.errorProviderCompany.SetError(this.ComboBoxStatus, "You must choose Status!");
            }
            e.Cancel = cancel;
        }
        private void ComboBoxStatus_Validated(object sender, EventArgs e)
        {
            this.errorProviderCompany.SetError(this.ComboBoxStatus, string.Empty);
        }
        #endregion

        private void EditCompany()
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var company = _context.Companies.First(e => e.Code == TextBoxCode.Text);
                    company.Code = TextBoxCode.Text;
                    company.Name = TextBoxName.Text;
                    company.Status = "YES".Equals(ComboBoxStatus.Text.Trim());
                    _context.SaveChanges();
                    ResetControls();
                    MessageBox.Show("Company was updated");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error on editing company.");
            }
        }

        private void SaveCompany()
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var company = new Data.Company()
                    {
                        Code = TextBoxCode.Text,
                        Name = TextBoxName.Text,
                        Status = true,
                        IsDelete = false
                    };
                    _context.Companies.Add(company);
                    _context.SaveChanges();
                    ResetControls();
                    MessageBox.Show("Company Save");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Company not save");
            }
        }

        private void ResetControls()
        {
            TextBoxCode.Enabled = false;
            TextBoxName.Enabled = false;
            ComboBoxStatus.Enabled = false;
            TextBoxSearch.Text = "";
            TextBoxCode.Text = "";
            TextBoxName.Text = "";
            ComboBoxStatus.Text = "";
            ButtonNew.Enabled = true;
            ButtonEdit.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            _save = true;
            BindCompanyWithDataGrid();
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
        
        private void BindCompanyWithDataGrid()
        {
            try
            {
                using (var _context = new STLxEntities())
                {
                    var source = _context.Companies.Where(e => e.Name.Contains(TextBoxSearch.Text) &&
                                                                         e.Status != false && 
                                                                         e.IsDelete != true);
                    dataGridViewCompany.DataSource = source.ToList();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dataGridViewCompany_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dataGridViewCompany.CurrentRow.Cells[0].Value.ToString());

                using (var _context = new STLxEntities())
                {
                    var source = _context.Companies.FirstOrDefault(i => i.Id == id);

                    if (!string.IsNullOrEmpty(source.Code))
                    {
                        TextBoxCode.Text = source.Code;
                        TextBoxName.Text = source.Name;

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
