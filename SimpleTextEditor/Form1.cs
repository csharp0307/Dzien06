using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if  (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                // załadowanie do edytora
                LoadToEditor(openFileDialog.FileName);
            }
        }

        private String currentFileName = null;
        private void LoadToEditor(string fileName)
        {
            try
            {
                richTextBox.Text = File.ReadAllText(fileName);
                richTextBox.Enabled = true;
                mnuSave.Enabled = true;
                mnuSaveAs.Enabled = true;
                tsFilename.Text = fileName;
                currentFileName = fileName;
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SaveToFile(string fileName)
        {
            try
            {
                File.WriteAllText(fileName, richTextBox.Text);
                isModified = false;
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "Błąd", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveToFile(currentFileName);
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                SaveToFile(saveFileDialog.FileName);
                currentFileName = saveFileDialog.FileName;
                tsFilename.Text = saveFileDialog.FileName;
            }
        }

        bool isModified = false;
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}
