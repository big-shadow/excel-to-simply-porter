using System;
using System.Windows.Forms;

namespace Mozzie.Excelerator
{
    public partial class ParentView : Form
    {
        public ParentView()
        {
            InitializeComponent();
        }

        private void openSpreadsheetToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DialogResult result = openFilesDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
            }
            Console.WriteLine(result);
        }
    }
}