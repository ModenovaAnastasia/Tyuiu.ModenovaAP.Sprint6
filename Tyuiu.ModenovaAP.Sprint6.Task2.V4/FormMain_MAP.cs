using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint6.Task2.V4.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task2.V4
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFfromX_MAP.Titles.Add("График функции F(x)");

                this.chartFfromX_MAP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFfromX_MAP.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MAP.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFfromX_MAP.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttoninfo_MAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-3 Моденова Анастасия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonuse_MAP_MouseEnter(object sender, EventArgs e)
        {
            buttonuse_MAP.BackColor = Color.Red;

        }
        private void buttonuse_MAP_MouseLeave(object sender, EventArgs e)
        {
            buttonuse_MAP.BackColor = Color.Lime;
        }

        private void buttonuse_MAP_MouseDown(object sender, MouseEventArgs e)
        {
            buttonuse_MAP.BackColor = Color.Blue;
        }

        private void labelLine_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_MAP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
