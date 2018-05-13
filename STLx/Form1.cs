using STLx.Data;
using System;
using System.Windows.Forms;

namespace STLx
{
    public partial class FormWithBank : Form
    {
        private bool _save;
        private readonly STLxEntities _context;
        public FormWithBank()
        {
            InitializeComponent();
            _context = new STLxEntities();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_save)
                SaveEmployee();
            else
                EditEmployee();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void EditEmployee()
        {
            throw new NotImplementedException();
        }

        private void SaveEmployee()
        {
            try
            {
                using (_context)
                {
                    var emp = new STLx.Data.WithBankAccount()
                    {
                        Iqama = "241536",
                        BatchNo = "2451",
                        Name = "Test",
                        BankCode = "TEST",
                        BankAccountNo = "646f18f916ecdb7cf816",
                        Project = "STL",
                        EmployeeAddress1 = "Riyadh",
                        EmployeeAddress2 = "Riyadh",
                        EmployeeAddress3 = "Riyadh",
                        Status = true,
                        IsDelete = false
                    };
                    _context.WithBankAccounts.Add(emp);
                    _context.SaveChanges();
                    MessageBox.Show("Employee Save");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Employee not save");
            }
        }
    }
}
