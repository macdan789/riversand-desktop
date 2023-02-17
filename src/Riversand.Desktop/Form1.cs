using Riversand.Common.Configurations;
using Riversand.Common.Constatns;
using Riversand.Common.SFTP.Abstract;
using System.Text.RegularExpressions;

namespace Riversand.Desktop;

public partial class Form1 : Form
{
    private readonly ISftpManager _manager;

    public Form1(ISftpManager manager)
    {
        InitializeComponent();
        label_WorkDir.Text = $"Founded files are located here: {SftpConfiguration.DownloadDir}";
        _manager = manager;
    }

    private async void button_Search_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBox_SKU.Text))
        {
            MessageBox.Show("Please enter Product ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            try
            {
                string productId = textBox_SKU.Text.ToUpper();

                if (!Regex.IsMatch(productId, Constants.PATTERN))
                {
                    MessageBox.Show("Wrong Product ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DateTime start = dateTimePicker_StartDate.Value.Date + timePortionDateTimePicker_StartDate.Value.TimeOfDay;
                DateTime end = dateTimePicker_EndDate.Value.Date + timePortionDateTimePicker_EndDate.Value.TimeOfDay;

                List<string> downloadedFiles = await _manager.GetFiles(productId, start, end);

                if (downloadedFiles.Count > 0)
                {
                    listBox_Output.DataSource = downloadedFiles;
                }
                else
                {
                    MessageBox.Show("There is no files for " + productId, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}