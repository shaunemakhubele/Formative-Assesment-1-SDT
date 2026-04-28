using System.Xml.Linq;

namespace SecBQuestion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            CitizenProfile profile = new CitizenProfile(
          textName.Text,
          textID.Text,
          comboCitizenship.Text
      );

            string result = profile.ValidateID();

            // Show message ABOVE textbox
            if (result == "ID is valid.")
            {
                labelValidation.Text = $"Valid ID. {profile.CitizenshipStatus} is {profile.Age} years old.";
            }
            else
            {
                labelValidation.Text = result;
            }

            // Optional: also show in textbox
            textResults.Text = result;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
         CitizenProfile profile = new CitizenProfile(
        textName.Text,
        textID.Text,
        comboCitizenship.Text
    );

            string validation = profile.ValidateID();

            textResults.Text =
                "=== DIGITAL IDENTITY PROFILE ===\r\n" +
                $"Name: {profile.FullName}\r\n" +
                $"ID Number: {profile.IDNumber}\r\n" +
                $"Age: {profile.Age}\r\n" +
                $"Citizenship: {profile.CitizenshipStatus}\r\n" +
                $"Validation: {validation}\r\n" +
                $"Processed: {DateTime.Now}";
        }
    }
}
