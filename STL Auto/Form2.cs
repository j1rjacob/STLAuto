using Standard.Licensing;
using Standard.Licensing.Security.Cryptography;
using Standard.Licensing.Validation;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STL_Auto
{
    public partial class Form2 : Form
    {
        private static string _passPhrase = "BetterTheDevilYouThanTheYouDon't";
        private static KeyGenerator _keyGenerator = KeyGenerator.Create();
        private static KeyPair _keyPair = _keyGenerator.GenerateKeyPair();
        private string _privateKey = _keyPair.ToEncryptedPrivateKeyString(_passPhrase);
        private string _publicKey = _keyPair.ToPublicKeyString();
        public Form2()
        {
            InitializeComponent();
        }
        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            var license = License.New()
                .WithUniqueIdentifier(Guid.NewGuid())
                .As(LicenseType.Trial)
                .ExpiresAt(DateTime.Now.AddDays(7))
                .WithMaximumUtilization(5)
                .LicensedTo(TextBoxName.Text, TextBoxEmail.Text)
                .CreateAndSignWithPrivateKey(_privateKey, _passPhrase);
            textBoxPublicKey.Text = _publicKey;
            File.WriteAllText(textBoxPath.Text + "License.lic", license.ToString(), Encoding.UTF8);
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            var path = textBoxLicense.Text;
            var publicKey = textBoxPublicKey.Text;
            using (var sr = new StreamReader(path))
            {
                var license = License.Load(sr);


                var validationFailures = license.Validate()
                    .ExpirationDate()
                    .When(lic => lic.Type == LicenseType.Trial)
                    .And()
                    .Signature(publicKey)
                    .AssertValidLicense();

                if (validationFailures.Any())
                {
                    MessageBox.Show("Invalid License!");
                }
                else
                {
                    //Store to Db
                    MessageBox.Show("Valid License!");
                }
            }
        }
    }
}
