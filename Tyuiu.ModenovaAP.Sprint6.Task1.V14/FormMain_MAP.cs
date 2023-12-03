using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint6.Task1.V14.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task1.V14
{
    public partial class FormMain_MAP : Form
    {
        public FormMain_MAP()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonuse_MAP_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox_Start_MAP.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_MAP.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxres_MAP.Text = "";
                textBoxres_MAP.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxres_MAP.AppendText("|    X      |    F(x)   |" + Environment.NewLine);
                textBoxres_MAP.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxres_MAP.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxres_MAP.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttoninfo_MAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-3 Моденова Анастасия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
