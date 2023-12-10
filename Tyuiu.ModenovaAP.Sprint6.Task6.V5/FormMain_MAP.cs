using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint6.Task6.V5.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task6.V5
{
    public partial class FormMain_MAP : Form
    {
        public FormMain_MAP()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        string path;
        private void buttonOpen_MAP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAP.ShowDialog(this);
            openFilePath = openFileDialogTask_MAP.FileName;
            textBoxInput_MAP.Text = File.ReadAllText(openFilePath);
            groupBoxInput_MAP.Text = groupBoxInput_MAP.Text + " " + openFileDialogTask_MAP.FileName;
            buttonDone_MAP.Enabled = true;
        }

        private void buttonHelp_MAP_Click(object sender, EventArgs e)
        {
            FormAbout_MAP formAbout = new FormAbout_MAP();
            formAbout.ShowDialog();
        }

        private void buttonDone_MAP_Click(object sender, EventArgs e)
        {
            string str = "I";
            textBoxOutput_MAP.Text = ds.CollectTextFromFile(str, openFilePath);
        }
    }
}
