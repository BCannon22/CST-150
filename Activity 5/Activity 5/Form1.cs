using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_5
{
    public partial class ReadingInputFile : Form
    {
        public ReadingInputFile()
        {
            InitializeComponent();
        }

        private void ReadingInputFile_Load(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("input.txt");

            outputFile.WriteLine("Learning how to use File Reader and Writer");

            outputFile.Close();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string outPutText;

                StreamReader inputFile;
                inputFile = new StreamReader(openFile.FileName);
                outPutText = inputFile.ReadToEnd();
                
                string outPutTextLower = outPutText.ToLower();
                OutPutBox.Items.Add(outPutTextLower);
                
            }


        }
    }
}
