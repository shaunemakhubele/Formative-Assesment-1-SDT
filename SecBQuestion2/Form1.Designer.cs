namespace SecBQuestion2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            FullName = new Label();
            IDNumber = new Label();
            Citizenship = new Label();
            textName = new TextBox();
            textID = new TextBox();
            textResults = new TextBox();
            comboCitizenship = new ComboBox();
            buttonValidate = new Button();
            buttonGenerate = new Button();
            labelValidation = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSalmon;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(276, 28);
            label1.Name = "label1";
            label1.Size = new Size(435, 31);
            label1.TabIndex = 1;
            label1.Text = "Home Affairs Digital Identity Processor";
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.Location = new Point(276, 79);
            FullName.Name = "FullName";
            FullName.Size = new Size(132, 20);
            FullName.TabIndex = 2;
            FullName.Text = "Enter your Name:";
            // 
            // IDNumber
            // 
            IDNumber.AutoSize = true;
            IDNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDNumber.Location = new Point(276, 122);
            IDNumber.Name = "IDNumber";
            IDNumber.Size = new Size(106, 20);
            IDNumber.TabIndex = 3;
            IDNumber.Text = "Enter your ID:";
            // 
            // Citizenship
            // 
            Citizenship.AutoSize = true;
            Citizenship.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Citizenship.Location = new Point(276, 162);
            Citizenship.Name = "Citizenship";
            Citizenship.Size = new Size(151, 20);
            Citizenship.TabIndex = 4;
            Citizenship.Text = "Choose your Citizen:";
            // 
            // textName
            // 
            textName.Location = new Point(434, 72);
            textName.Name = "textName";
            textName.Size = new Size(277, 27);
            textName.TabIndex = 5;
            // 
            // textID
            // 
            textID.Location = new Point(434, 119);
            textID.Name = "textID";
            textID.Size = new Size(277, 27);
            textID.TabIndex = 6;
            // 
            // textResults
            // 
            textResults.Location = new Point(434, 292);
            textResults.Multiline = true;
            textResults.Name = "textResults";
            textResults.ScrollBars = ScrollBars.Vertical;
            textResults.Size = new Size(245, 146);
            textResults.TabIndex = 7;
            // 
            // comboCitizenship
            // 
            comboCitizenship.FormattingEnabled = true;
            comboCitizenship.Items.AddRange(new object[] { "Citizen", "Permanent Resident", "Visitor" });
            comboCitizenship.Location = new Point(434, 159);
            comboCitizenship.Name = "comboCitizenship";
            comboCitizenship.Size = new Size(282, 28);
            comboCitizenship.TabIndex = 8;
            // 
            // buttonValidate
            // 
            buttonValidate.BackColor = Color.Green;
            buttonValidate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonValidate.Location = new Point(434, 207);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(114, 31);
            buttonValidate.TabIndex = 9;
            buttonValidate.Text = "Validate ID";
            buttonValidate.UseVisualStyleBackColor = false;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.Green;
            buttonGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerate.Location = new Point(434, 450);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(151, 29);
            buttonGenerate.TabIndex = 10;
            buttonGenerate.Text = "Generate Profile";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // labelValidation
            // 
            labelValidation.AutoSize = true;
            labelValidation.Location = new Point(443, 252);
            labelValidation.Name = "labelValidation";
            labelValidation.Size = new Size(0, 20);
            labelValidation.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 501);
            Controls.Add(labelValidation);
            Controls.Add(buttonGenerate);
            Controls.Add(buttonValidate);
            Controls.Add(comboCitizenship);
            Controls.Add(textResults);
            Controls.Add(textID);
            Controls.Add(textName);
            Controls.Add(Citizenship);
            Controls.Add(IDNumber);
            Controls.Add(FullName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "HomeAffairsDigitalIdentityProcessor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label FullName;
        private Label IDNumber;
        private Label Citizenship;
        private TextBox textName;
        private TextBox textID;
        private TextBox textResults;
        private ComboBox comboCitizenship;
        private Button buttonValidate;
        private Button buttonGenerate;
        private Label labelValidation;
    }
}
