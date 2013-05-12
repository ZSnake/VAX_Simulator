using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAX_Simulator
{
    public partial class MainWindow : Form
    {
        string[] _bruteReferences;
        List<MemoryReference> _references;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            string action;
            string adress;
            var ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            _references = new List<MemoryReference>();
            if (result == DialogResult.OK)
                _bruteReferences = File.ReadAllLines(ofd.FileName);
            else
            {
                _bruteReferences = new string[0];
            }

            //Lectura de todas las lineas del achivo transformadas a referencias de memoria (para futuros usos)
            for (int i = 0; i < _bruteReferences.Count(); i++)
            {
                adress = _bruteReferences[i].Split(' ')[0];
                action = _bruteReferences[i].Split(' ')[0];
                _references.Add(new MemoryReference(adress, action));
            }

        }
    }
}
