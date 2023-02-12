namespace Riversand.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SKU.Text))
            {
                textBox_Output.Text = "SKU field is empty!";
                return;
            }

            DateTime.TryParse(dateTimePicker_StartDate.Text, out var startDate);
            DateTime.TryParse(dateTimePicker_EndDate.Text, out var endDate);
        }
    }
}