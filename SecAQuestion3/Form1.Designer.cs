namespace SecAQuestion3
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
            label1 = new Label();
            labelJava = new Label();
            listLanguages = new ListBox();
            textLanguage = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 60);
            label1.Name = "label1";
            label1.Size = new Size(377, 28);
            label1.TabIndex = 0;
            label1.Text = "My Favourite Programming Languages";
            // 
            // labelJava
            // 
            labelJava.AutoSize = true;
            labelJava.Location = new Point(73, 188);
            labelJava.Name = "labelJava";
            labelJava.Size = new Size(0, 20);
            labelJava.TabIndex = 4;
            // 
            // listLanguages
            // 
            listLanguages.FormattingEnabled = true;
            listLanguages.Items.AddRange(new object[] { "C#", "Python", "Java", "JavaScript", "Go" });
            listLanguages.Location = new Point(52, 110);
            listLanguages.Name = "listLanguages";
            listLanguages.Size = new Size(350, 164);
            listLanguages.TabIndex = 1;
            // 
            // textLanguage
            // 
            textLanguage.Location = new Point(55, 300);
            textLanguage.Name = "textLanguage";
            textLanguage.Size = new Size(347, 27);
            textLanguage.TabIndex = 5;
            textLanguage.Text = "Enter programming language";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.HotTrack;
            buttonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(57, 358);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(125, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add Language";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Red;
            buttonRemove.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(188, 358);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(115, 29);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += button1_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(55, 421);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 20);
            labelStatus.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(labelStatus);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textLanguage);
            Controls.Add(labelJava);
            Controls.Add(listLanguages);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ProgrammingLanguageManager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelJava;
        private ListBox listLanguages;
        private TextBox textLanguage;
        private Button buttonAdd;
        private Button buttonRemove;
        private Label labelStatus;
    }
}
