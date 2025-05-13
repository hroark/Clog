namespace CloggerUIStub
{
    public partial class Form1 : Form
    {
        private string _path;

        private void CmdBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder to save the log file";
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    _path = folderBrowserDialog.SelectedPath;
                    LblOutPath.Text = _path;
                }
            }
        }

        private void CmdTestFileLogger_Click(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}