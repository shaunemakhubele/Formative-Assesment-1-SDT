namespace SecAQuestion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.");
                return;
            }

            string removed = listLanguages.SelectedItem.ToString();
            listLanguages.Items.Remove(listLanguages.SelectedItem);

            labelStatus.Text = $"Removed '{removed}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string language = textLanguage.Text.Trim();

            // Prevent empty input
            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }

            // Prevent duplicates
            if (listLanguages.Items.Contains(language))
            {
                MessageBox.Show("This language already exists in the list.");
                return;
            }

            listLanguages.Items.Add(language);

            // Clear input
            textLanguage.Clear();

            // Show time added
            labelStatus.Text = $"Added '{language}' at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
