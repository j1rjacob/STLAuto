using NUnit.Framework;
using STLx.Data;
using System;
using System.Linq;

namespace STLx.Test
{
    [TestFixture]
    public class WithBankAccount
    {
        private readonly STLxEntities _context;
        public WithBankAccount()
        {
            _context = new STLxEntities();
        }

        [Test]
        public void Save_Employee_True()
        {
            bool flag = false;
            try
            {
                using (_context)
                {
                    var emp = new Data.WithBankAccount()
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
                    flag = true;
                }
            }
            catch (Exception)
            {
                flag = false;
            }
            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void Update_Employee_True()
        {
            bool flag = false;

            try
            {
                using (_context)
                {
                    var emp = _context.WithBankAccounts.First(e => e.BatchNo == "2451");
                    emp.Name = "Junar";
                    _context.SaveChanges();
                    flag = true;
                }
            }
            catch (Exception)
            {
                flag = false;
            }

            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void Delete_Employee_True()
        {
            bool flag = false;

            try
            {
                using (_context)
                {
                    var emp = _context.WithBankAccounts.First(e => e.BatchNo == "2451");
                    _context.WithBankAccounts.Remove(emp);
                    _context.SaveChanges();
                    flag = true;
                }
            }
            catch (Exception)
            {
                flag = false;
            }

            //Assert
            Assert.IsTrue(flag);
        }

        [Test]
        public void Search_Employee_True()
        {
            using (_context)
            {
                var emp = _context.WithBankAccounts
                                  .FirstOrDefault(e => e.BatchNo == "2451");

                Assert.AreEqual(emp.Name, "Test");
            }
        }

        [Test]
        public void Employee_List_Equal()
        {
            int totEmployees = 0;
            using (_context)
            {
                var query = _context.WithBankAccounts.ToList();
                totEmployees = query.Count;
            }
            Assert.AreEqual(175, totEmployees);
        }
    }
}
