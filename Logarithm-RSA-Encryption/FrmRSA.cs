using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
/*
 Name: Eng. Habeab Alhamed
 Twitter: @Eng_Habeab
 GitHub: https://github.com/Habeab
 Email: Habeab@gmail.com
 Whatsapp: 0553400333
 Location: Saudi Arabia
*/
namespace Logarithm_RSA_Encryption
{
    public partial class FrmRSA : Form
    {
        public FrmRSA()
        {
            InitializeComponent();
        }
        byte[] DataEncrypt;
        byte[] EncryptedData;
        byte[] DecryptedData;

        RSAParameters Key1;
        RSAParameters Key2;

        string StrEncryptin;

        private byte[] Logarithm_RSA_Encrypt(byte[] DataEncryption, RSAParameters Key, bool fOAEP)
        {
            byte[] EncryptResult;
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            RSA.ImportParameters(Key);
            EncryptResult = RSA.Encrypt(DataEncryption, fOAEP);

            return EncryptResult;
        }
        private byte[] Logarithm_RSA_Decrypt(byte[] DataEncryption, RSAParameters Key, bool fOAEP)
        {
            byte[] DecryptResult;
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            RSA.ImportParameters(Key);
            DecryptResult = RSA.Decrypt(DataEncryption, fOAEP);

            return DecryptResult;
        }

        private void BtnEncryption_Click(object sender, EventArgs e)
        {
            DataEncrypt = Encoding.Default.GetBytes(TbxData.Text);
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            Key1 = RSA.ExportParameters(false);
            Key2 = RSA.ExportParameters(true);

            EncryptedData = Logarithm_RSA_Encrypt(DataEncrypt, Key1, false);
            StrEncryptin = Encoding.Default.GetString(EncryptedData);
            TbxEncryptin.Text = StrEncryptin;
        }

        private void BtnDecryption_Click(object sender, EventArgs e)
        {
            EncryptedData = Encoding.Default.GetBytes(StrEncryptin);
            DecryptedData = Logarithm_RSA_Decrypt(EncryptedData, Key2, false);
            TbxDecryptin.Text = Encoding.Default.GetString(DecryptedData);
        }
    }
}
