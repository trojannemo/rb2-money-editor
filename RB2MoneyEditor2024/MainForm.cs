using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using RB2MoneyEditor2025.x360;

namespace RB2MoneyEditor2025
{
    public partial class MainForm : Form
    {        
        private PictureBox imgBanner;
        private Button btnAbout;
        private Button btnSave;
        private Button btnOpen;
        private Label lblCurrMoney;
        private Label lblMoney;
        private TextBox txtNewMoney;
        private TextBox txtCurrentMoney;
        private string inputFile;
        private Int32 currentMoney;
        private long moneyOffset;
        private STFSPackage savePackage;
        private byte[] encryptedSave;
        private byte[] decryptedSave;
        private byte[] strippedSave;
        private uint xorKey;

        public MainForm()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            btnMaxMoney.Enabled = false;
            txtNewMoney.ReadOnly = true;
        }

        private void btnOpen_Click(object obj0, EventArgs obj1)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select your 'band' save game file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ValidateInputFile(openFileDialog.FileName);
            }
        }

        public static uint dtb_xor(uint data)
        {
            uint val = ((data - ((data / 0x1F31D) * 0x1F31D)) * 0x41A7) - ((data / 0x1F31D) * 0xB14);
            if ((int)val <= 0)
            {
                val = (val - 0x80000000) - 1;
            }
            return val;
        }

        public byte[] dtb_decrypt(byte[] input)
        {
            xorKey = BitConverter.ToUInt32(input, 0);
            int outSize = input.Length - 4;
            byte[] output = new byte[outSize];

            for (int i = 0; i < outSize; i++)
            {
                xorKey = dtb_xor(xorKey);
                output[i] = (byte)(input[i + 4] ^ (xorKey & 0xff));
            }

            return output;
        }

        public byte[] dtb_encrypt(byte[] input)
        {
            xorKey = BitConverter.ToUInt32(new byte[] { 0x4E, 0x45, 0x4D, 0x4F }, 0);
            Array.Resize(ref input, input.Length + 4);
            int outSize = input.Length;
            byte[] output = new byte[outSize];

            Array.Copy(BitConverter.GetBytes(xorKey), output, 4);
            for (int i = 4; i < outSize; i++)
            {
                xorKey = dtb_xor(xorKey);
                output[i] = (byte)(BitConverter.ToUInt32(input, i - 4) ^ (xorKey & 0xff));
            }

            return output;
        }

        private void ValidateInputFile(string inFile)
        {
            if (!string.IsNullOrEmpty(Path.GetExtension(inFile)) || VariousFunctions.ReadFileType(inFile) != XboxFileType.STFS)
            {
                MessageBox.Show("Invalid input file, please use the extensionless 'band' file", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            inputFile = inFile;                      
            ReadFile();            
        }     

        public void ReadFile()
        {
            txtCurrentMoney.Text = "";
            txtNewMoney.Text = "";
            txtOffset.Text = "";
                        
            if (savePackage != null)
            {
                savePackage.CloseIO();
            }

            //back up file
            var backup = inputFile + ".bak";
            if (!File.Exists(backup))
            {
                File.Copy(inputFile, inputFile + ".bak", true);
            }

            savePackage = new STFSPackage(inputFile);
            if (!savePackage.ParseSuccess)
            {
                MessageBox.Show("Failed to parse input file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var xSave = savePackage.GetFile("save.dat");
            if (xSave == null)
            {
                if (!savePackage.ParseSuccess)
                {
                    MessageBox.Show("Could not locate save.dat file in input file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    savePackage.CloseIO();
                    return;
                }
            }
            encryptedSave = xSave.Extract();               
            strippedSave = encryptedSave.Skip(4).ToArray();
            decryptedSave = dtb_decrypt(strippedSave);

            int nameLength = BitConverter.ToInt32(decryptedSave, 0x0C);
            txtName.Text = Encoding.ASCII.GetString(decryptedSave, 0x10, nameLength);

            moneyOffset = FindMoneyOffset(decryptedSave);
            txtOffset.Text = moneyOffset.ToString();
            if (moneyOffset == -1)
            {
                MessageBox.Show("Failed to locate money offset, can't continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            currentMoney = BitConverter.ToInt32(decryptedSave, Convert.ToInt32(moneyOffset));
            txtCurrentMoney.Text = currentMoney.ToString();
            btnSave.Enabled = false;
            txtNewMoney.ReadOnly = false;
            btnMaxMoney.Enabled = true;
            txtNewMoney.Focus();
        }

        long FindMoneyOffset(byte[] data)
        {
            var offset = 0;
            try
            {
                offset += 12; //ignore first unknown 12 bytes
                var length = BitConverter.ToInt32(data, offset); //length of player name string
                offset += 4;
                txtName.Text = Encoding.ASCII.GetString(data, offset, length); //read player name
                offset += length;
                offset += 31; //ignore unknown bytes
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 22;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 22;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 22;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 22;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 22;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 22;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 30;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 4;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this
                offset += 14;
                length = BitConverter.ToInt32(data, offset); //length of next string
                offset += 4;
                offset += length; //skip string bytes since we're not doing anything with this                           
                offset += 16; //this is where the money offset should be
            }
            catch (Exception e)
            {
                MessageBox.Show("Error calculating money offset:\n\n" + e.Message + "\n\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return offset;
            
            /* my initial way to find the money offset, above is more likely to always be accurate since it follows the file structure
            byte[] target = Encoding.ASCII.GetBytes("boston"); //always happens 12 bytes before the first instance of 'boston'

            for (int i = 0; i < data.Length - target.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < target.Length; j++)
                {
                    if (data[i + j] != target[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    int moneyOffset = i - 12;
                    if (moneyOffset >= 0)
                        return moneyOffset;
                }
            }

            return -1; // not found*/
        }

        public void WriteFile()
        {          
            Array.Copy(BitConverter.GetBytes(Convert.ToInt32(txtNewMoney.Text)), 0, decryptedSave, moneyOffset, 4);

            byte[] reEncrypted = dtb_encrypt(decryptedSave);

            byte[] finalSave = new byte[reEncrypted.Length + 4];
            finalSave[0] = 0x0E;
            finalSave[1] = 0x00;
            finalSave[2] = 0x00;
            finalSave[3] = 0x00;
            Array.Copy(reEncrypted, 0, finalSave, 4, reEncrypted.Length);

            var xSave = savePackage.GetFile("save.dat");
            if (!xSave.Inject(new DJsIO(finalSave, true)))
            {
                MessageBox.Show("Failed to modify save.dat file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                savePackage.CloseIO();
                return;
            }

            //sign CON file
            var success = false;
            try
            {
                var kv = new RSAParams(Application.StartupPath + "\\KV.bin");
                if (kv.Valid)
                {
                    savePackage.FlushPackage(kv);
                    savePackage.UpdateHeader(kv);
                    success = true;
                }
                else
                {
                    success = false;
                }
                savePackage.CloseIO();
            }
            catch
            {
                savePackage.CloseIO();
                success = false;
            }

            if (success)
            {
                MessageBox.Show("Modified save game file successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Modifying save game file failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       

        private void btnSave_Click(object obj0, EventArgs obj1)
        {
            if (moneyOffset == -1)
            {
                MessageBox.Show("Invalid offset, can't save to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }                        
            WriteFile();            
            btnSave.Enabled = false;
            txtNewMoney.ReadOnly = true;
            btnMaxMoney.Enabled = false;
        }            

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rock Band 2 Money Editor (2025)\n\nInspired by an executable dating back to 2012 by an unknown creator\n" +
                "Original executable refuses to run and it is unknown if it actually worked - based on thorough decompilation of the obfuscated" +
                " source code it is my opinion that it would not actually work\n\nThis version was created by Nemo in 2025 as a proof of concept " +
                "based on the decompiled source code of the original, plus the necessary DTB decryption routines taken from StackOverflow0x's Rock Band 3 Save " +
                "Game Scores Editor and further improvements by Nemo\n\nEnjoy", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMaxMoney_Click(object sender, EventArgs e)
        {
            txtNewMoney.Text = int.MaxValue.ToString();            
        }

        private void txtNewMoney_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewMoney.Text)) return;            
            try
            {
                Convert.ToInt32(txtNewMoney.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewMoney.Text = "";
            }
            btnSave.Enabled = txtNewMoney.Text.Length > 0;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ValidateInputFile(files[0]);
        }
    }    
}