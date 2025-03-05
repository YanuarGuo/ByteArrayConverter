using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ByteArrayConverter
{
    public partial class ByteArrayConverter : Form
    {
        private string selectedFilePath;

        public ByteArrayConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputText = txtStringText.Text;

            // Pilih format yang diinginkan: "Decimal", "Hex", atau "Binary"
            string? selectedFormat = cmbFormat.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show(
                    "Masukkan teks terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (selectedFormat == "Decimal")
            {
                txtASCII1.Text = string.Join(" ", inputText.Select(c => ((int)c).ToString()));
            }
            else if (selectedFormat == "Hex")
            {
                txtASCII1.Text = string.Join(" ", inputText.Select(c => ((int)c).ToString("X2")));
            }
            else if (selectedFormat == "Binary")
            {
                txtASCII1.Text = string.Join(
                    " ",
                    inputText.Select(c => Convert.ToString((int)c, 2).PadLeft(8, '0'))
                );
            }
            else
            {
                MessageBox.Show(
                    "Pilih format konversi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void BtnAddPict_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter =
                    "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
                txtFileName.Text = selectedFilePath;
            }
        }

        private void BtnConvertPict_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show(
                    "Please select an image first.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                byte[] imageBytes = File.ReadAllBytes(selectedFilePath);
                string hexString = BitConverter.ToString(imageBytes).Replace("-", "");
                txtASCII2.Text = hexString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error converting image: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
