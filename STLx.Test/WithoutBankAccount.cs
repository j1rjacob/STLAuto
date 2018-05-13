using NUnit.Framework;
using NUnit.Framework.Internal;
using STLx.Data;
using System;
using System.Linq;

namespace STLx.Test
{
    [TestFixture()]
    public class WithoutBankAccount
    {
        private readonly STLxEntities _context;
        public WithoutBankAccount()
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
                    var emp = new Data.WithoutBankAccount()
                    {
                        Iqama = "241536",
                        BatchNo = "2451",
                        Name = "Test",
                        BackAccountNo = "646f18f916ecdb7cf816",
                        Project = "STL",
                        BWAccount = "00866081001",
                        Status = true,
                        IsDelete = false
                    };
                    _context.WithoutBankAccounts.Add(emp);
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
                    var emp = _context.WithoutBankAccounts.First(e => e.BatchNo == "2451");
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
                    var emp = _context.WithoutBankAccounts.First(e => e.BatchNo == "12345");
                    _context.WithoutBankAccounts.Remove(emp);
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
                var emp = _context.WithoutBankAccounts
                    .FirstOrDefault(e => e.BatchNo == "7984");

                Assert.AreEqual(emp.Name, "JUNAR AQUI JACOB");
            }
        }

        [Test]
        public void Employee_List_Equal()
        {
            int totEmployees = 0;
            using (_context)
            {
                var query = _context.WithoutBankAccounts.ToList();
                totEmployees = query.Count;
            }
            Assert.AreEqual(1189, totEmployees);
        }
    }
}
