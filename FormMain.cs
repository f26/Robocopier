using System.Diagnostics;

namespace Robocopier
{
    public partial class FormMain : Form
    {
        Color _foreColor = Color.Black;
        public FormMain()
        {
            InitializeComponent();
            _foreColor = textBoxTarget.ForeColor;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string testdir = Clipboard.GetText();
            if (Directory.Exists(testdir))
            {
                textBoxSource.Text = testdir;
            }
        }

        private void buttonRobocopy_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxSource.Text))
            {
                MessageBox.Show("ERROR: Source directory does not exist");
                return;
            }

            Process.Start("robocopy", String.Format("\"{0}\" \"{1}\" /MIR", textBoxSource.Text, textBoxTarget.Text));

        }

        private void textBoxTarget_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxTarget.Text))
            {
                toolTip1.SetToolTip(textBoxTarget, "WARNING: Directory already exists.  Target directory doesn't feel so good, Mr. Stark.");
                textBoxTarget.ForeColor = Color.Red;
            }
            else
            {
                toolTip1.SetToolTip(textBoxTarget, null);
                textBoxTarget.ForeColor = _foreColor;
            }
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxSource.Text))
            {
                toolTip1.SetToolTip(textBoxSource, "WARNING: Directory does not exist.");
                textBoxSource.ForeColor = Color.Red;
                buttonRobocopy.Enabled = false;
            }
            else
            {
                toolTip1.SetToolTip(textBoxSource, null);
                textBoxSource.ForeColor = _foreColor;
                buttonRobocopy.Enabled = true;
            }
        }
    }
}