using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCL1_Proyecto1_201800499
{
    public partial class VentanaPrincipal : Form
    {
        private int noTab = 1;

        public VentanaPrincipal()
        {
            InitializeComponent();
            controlTabs.Controls.Add(new TabFile("Pestaña " + noTab));
            noTab++;
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlTabs.Controls.Add(new TabFile("Pestaña " + noTab));
            noTab++;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(controlTabs.SelectedTab != null) openFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(openFile.OpenFile());

            TabFile tabSeleccion = (TabFile)controlTabs.SelectedTab;
            tabSeleccion.fileOPen.Text = reader.ReadToEnd();

            tabSeleccion.Text = openFile.SafeFileName;
            reader.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlTabs.SelectedTab != null) saveFile.ShowDialog();
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFile.OpenFile());

            TabFile tabSeleccion = (TabFile)controlTabs.SelectedTab;

            writer.Write(tabSeleccion.fileOPen.Text);
            writer.Close();
        }
    }
}
