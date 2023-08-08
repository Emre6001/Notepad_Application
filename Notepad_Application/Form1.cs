namespace Notepad_Application
{
    public partial class Notepad_frm : Form
    {
        public Notepad_frm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do not contact me, google it!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.Clear();

        }

        private void printPriewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.Text = rich_txtbox.Text + DateTime.Now;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true;
            
        }

        private void rich_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (rich_txtbox.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                boldToolStripMenuItem.Enabled = true;
                ýtalicToolStripMenuItem.Enabled = true;
                normalToolStripMenuItem.Enabled = true;
                strikeThroughToolStripMenuItem.Enabled = true;
                underlineToolStripMenuItem.Enabled = true;
            }
            else
            {
                boldToolStripMenuItem.Enabled = false;
                ýtalicToolStripMenuItem.Enabled = false;
                normalToolStripMenuItem.Enabled = false;
                strikeThroughToolStripMenuItem.Enabled = false;
                underlineToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
            }

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.SelectAll();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.SelectionFont = new Font(rich_txtbox.Font, FontStyle.Bold);
        }

        private void ýtalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.SelectionFont = new Font(rich_txtbox.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.SelectionFont = new Font(rich_txtbox.Font, FontStyle.Underline);
        }

        private void strikeThroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.SelectionFont = new Font(rich_txtbox.Font, FontStyle.Strikeout);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich_txtbox.SelectionFont = new Font(rich_txtbox.Font, FontStyle.Regular);
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}