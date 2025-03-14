namespace ByteArrayConverter
{
    partial class ByteArrayConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStringText = new TextBox();
            txtASCII1 = new TextBox();
            BtnConvert = new Button();
            txtFileName = new TextBox();
            BtnAddPict = new Button();
            BtnConvertPict = new Button();
            cmbFormat = new ComboBox();
            txtASCII2 = new TextBox();
            BoxText = new GroupBox();
            BoxImage = new GroupBox();
            label1 = new Label();
            BoxText.SuspendLayout();
            BoxImage.SuspendLayout();
            SuspendLayout();
            // 
            // txtStringText
            // 
            txtStringText.Location = new Point(9, 22);
            txtStringText.Name = "txtStringText";
            txtStringText.Size = new Size(244, 23);
            txtStringText.TabIndex = 0;
            // 
            // txtASCII1
            // 
            txtASCII1.Location = new Point(269, 22);
            txtASCII1.Name = "txtASCII1";
            txtASCII1.ReadOnly = true;
            txtASCII1.Size = new Size(244, 23);
            txtASCII1.TabIndex = 1;
            // 
            // BtnConvert
            // 
            BtnConvert.Location = new Point(427, 51);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(86, 23);
            BtnConvert.TabIndex = 2;
            BtnConvert.Text = "Convert";
            BtnConvert.UseVisualStyleBackColor = true;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(9, 22);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(320, 23);
            txtFileName.TabIndex = 3;
            // 
            // BtnAddPict
            // 
            BtnAddPict.Location = new Point(335, 22);
            BtnAddPict.Name = "BtnAddPict";
            BtnAddPict.Size = new Size(86, 23);
            BtnAddPict.TabIndex = 4;
            BtnAddPict.Text = "Upload";
            BtnAddPict.UseVisualStyleBackColor = true;
            BtnAddPict.Click += BtnAddPict_Click;
            // 
            // BtnConvertPict
            // 
            BtnConvertPict.Location = new Point(427, 22);
            BtnConvertPict.Name = "BtnConvertPict";
            BtnConvertPict.Size = new Size(86, 23);
            BtnConvertPict.TabIndex = 5;
            BtnConvertPict.Text = "Convert";
            BtnConvertPict.UseVisualStyleBackColor = true;
            BtnConvertPict.Click += BtnConvertPict_Click;
            // 
            // cmbFormat
            // 
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Items.AddRange(new object[] { "Decimal", "Hex", "Binary" });
            cmbFormat.Location = new Point(269, 51);
            cmbFormat.Name = "cmbFormat";
            cmbFormat.Size = new Size(152, 23);
            cmbFormat.TabIndex = 6;
            // 
            // txtASCII2
            // 
            txtASCII2.Location = new Point(9, 84);
            txtASCII2.Multiline = true;
            txtASCII2.Name = "txtASCII2";
            txtASCII2.ReadOnly = true;
            txtASCII2.ScrollBars = ScrollBars.Vertical;
            txtASCII2.Size = new Size(504, 115);
            txtASCII2.TabIndex = 7;
            // 
            // BoxText
            // 
            BoxText.Controls.Add(txtASCII1);
            BoxText.Controls.Add(txtStringText);
            BoxText.Controls.Add(cmbFormat);
            BoxText.Controls.Add(BtnConvert);
            BoxText.Location = new Point(12, 12);
            BoxText.Name = "BoxText";
            BoxText.Size = new Size(526, 100);
            BoxText.TabIndex = 8;
            BoxText.TabStop = false;
            BoxText.Text = "Text to ASCII";
            // 
            // BoxImage
            // 
            BoxImage.Controls.Add(label1);
            BoxImage.Controls.Add(txtFileName);
            BoxImage.Controls.Add(BtnAddPict);
            BoxImage.Controls.Add(txtASCII2);
            BoxImage.Controls.Add(BtnConvertPict);
            BoxImage.Location = new Point(12, 125);
            BoxImage.Name = "BoxImage";
            BoxImage.Size = new Size(526, 217);
            BoxImage.TabIndex = 9;
            BoxImage.TabStop = false;
            BoxImage.Text = "Image to ASCII (Hex)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 66);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Result";
            // 
            // ByteArrayConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 354);
            Controls.Add(BoxImage);
            Controls.Add(BoxText);
            Name = "ByteArrayConverter";
            Text = "ByteArrayConverter";
            BoxText.ResumeLayout(false);
            BoxText.PerformLayout();
            BoxImage.ResumeLayout(false);
            BoxImage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtStringText;
        private TextBox txtASCII1;
        private Button BtnConvert;
        private TextBox txtFileName;
        private Button BtnAddPict;
        private Button BtnConvertPict;
        private ComboBox cmbFormat;
        private TextBox txtASCII2;
        private GroupBox BoxText;
        private GroupBox BoxImage;
        private Label label1;
    }
}
