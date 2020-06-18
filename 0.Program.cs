using System;
using System.IO;
using System.Windows.Forms;

namespace CalibrationHelper
{
    public class Program
    {
        [STAThread]

        static public void Main()
        {
            if (LicenseCheck.LicenseFileCheck() == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }

    static public class LicenseCheck
    {
        static public string UnCodeLicenseData(string CodedData, string LicKey)
        {
            int KeySize = LicKey.Length, LicKeyChar = 0;
            byte[] CodedDataByte = new byte[CodedData.Length / 8];
            byte[] UnCodedDataByte = new byte[CodedData.Length / 8];
            byte CodedDataPartialByte;
            string CodedDataPartialByteStr;
            string UncodedString = "";

            //Transform Coded string to byte vector
            for (int i = 0; i < CodedDataByte.Length; i++)
            {
                CodedDataPartialByteStr = "";
                CodedDataPartialByte = 0;
                for (int j = 0; j < 8; j++)
                {
                    CodedDataPartialByteStr = String.Concat(CodedDataPartialByteStr, CodedData[(8 * i) + j]);
                }
                for (int j = 7; j >= 8 - CodedDataPartialByteStr.Length; j--)
                {
                    CodedDataPartialByte += char.Equals(CodedDataPartialByteStr[j], '1') ? (byte)Math.Pow(2, 7 - j) : (byte)0;
                }
                CodedDataByte[i] = CodedDataPartialByte;
            }

            //Uncode the data with Key algorithm
            for (int i = 0; i < CodedDataByte.Length; i++)
            {
                LicKeyChar = i % KeySize;

                UnCodedDataByte[i] = (byte)(CodedDataByte[i] ^ LicKey[LicKeyChar]);
            }

            //Convert to Uncoded License String Data
            for (int i = 0; i < UnCodedDataByte.Length; i++)
            {
                UncodedString = String.Concat(UncodedString, (char)UnCodedDataByte[i]);
            }

            return UncodedString;
        }

        static public string CodeLicenseData(string LicData, string LicKey) //Receives String License, convert to Coded Binary
        {

            int KeySize = LicKey.Length, LicKeyChar = 0;
            byte[] CodeResultByte = new byte[LicData.Length];
            bool[] CodeResultBool = new bool[8 * LicData.Length];
            string CodeResultString = "";

            //Code the Key with selected algorithm
            for (int i = 0; i < LicData.Length; i++)
            {
                LicKeyChar = i % KeySize;

                CodeResultByte[i] = (byte)(LicData[i] ^ LicKey[LicKeyChar]);
            }

            //Convert to binary
            for (int i = 0; i < LicData.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    CodeResultBool[(8 * i) + (7 - j)] = (byte)(CodeResultByte[i] & (1 << j)) == Math.Pow(2, j) ? true : false;
                }
            }

            //Convert to License String Data
            for (int i = 0; i < CodeResultBool.Length; i++)
            {
                CodeResultString = String.Concat(CodeResultString, CodeResultBool[i] == true ? 1 : 0);
            }

            return CodeResultString;
        }

        static public int LicenseFileCheck()
        {
            string ComputerName = Environment.MachineName, LicenseGet, LicenseUncode;
            string[] LicenseUncodeSplit;
            int DateCurrDay = DateTime.Now.Day, DateCurrMonth = DateTime.Now.Month, DateCurrYear = DateTime.Now.Year;

            string myPath = System.AppDomain.CurrentDomain.BaseDirectory;

            try
            {
                LicenseGet = File.ReadAllText(myPath + "\\CH_License.lic");
            }
            catch //Treatment for exceptions regarding the license reading process 
            {
                MessageBox.Show("License File not found!");
                return -1;
            }

            LicenseUncode = UnCodeLicenseData(LicenseGet, "MATH"); // License Key carved inside the SW Fucntion

            LicenseUncodeSplit = LicenseUncode.Split('$', '/');

            if (LicenseUncodeSplit[0] == ComputerName)
            {
                if (int.Parse(LicenseUncodeSplit[3]) > DateCurrYear)
                {
                    return 1; //License approved
                }
                else if (int.Parse(LicenseUncodeSplit[3]) == DateCurrYear)
                {
                    if (int.Parse(LicenseUncodeSplit[2]) > DateCurrMonth)
                    {
                        return 1; //License approved
                    }
                    else if (int.Parse(LicenseUncodeSplit[2]) == DateCurrMonth)
                    {
                        if (int.Parse(LicenseUncodeSplit[1]) >= DateCurrDay)
                        {
                            return 1; //License approved
                        }
                    }
                }
            }

            if (LicenseUncodeSplit[0] == ComputerName &&
                int.Parse(LicenseUncodeSplit[1]) >= 1 && int.Parse(LicenseUncodeSplit[1]) <= 30 &&
                int.Parse(LicenseUncodeSplit[2]) >= 1 && int.Parse(LicenseUncodeSplit[2]) <= 12 &&
                int.Parse(LicenseUncodeSplit[3]) >= 2020 && int.Parse(LicenseUncodeSplit[3]) <= 2100)
            {
                MessageBox.Show("License File Expired since " + LicenseUncodeSplit[1] +
                    '/' + LicenseUncodeSplit[2] +
                    '/' + LicenseUncodeSplit[3]);
            }
            else
            {
                MessageBox.Show("License File Invalid!");
            }

            return 0; //License denied
        }
    }

}
