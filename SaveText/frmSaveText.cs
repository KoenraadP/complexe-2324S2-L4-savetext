using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveText
{
    public partial class frmSaveText : Form
    {
        public frmSaveText()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // waar en onder welke naam moet het bestand
            // bewaard worden
            string path = @"C:\verhalen\" + txtTitle.Text + ".txt";

            // inhoud van grote textbox in file 'schrijven'
            // path = waar moet het bestand bewaard worden
            // txtStory.Text --> de tekst die in het bestand moet komen
            File.WriteAllText(path, txtStory.Text);
        }
    }
}
