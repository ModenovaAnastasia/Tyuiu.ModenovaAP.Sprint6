using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint6.Task5.V22.Lib;
using System.IO;

namespace Tyuiu.ModenovaAP.Sprint6.Task5.V22
{
    public partial class FormMain_MAP : Form
    {
        public FormMain_MAP()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\1\source\repos\Tyuiu.ModenovaAP.Sprint6\Tyuiu.ModenovaAP.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
        private void buttonOpen_MAP_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\1\source\repos\Tyuiu.ModenovaAP.Sprint6\Tyuiu.ModenovaAP.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUse_MAP_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_MAP.ColumnCount = 2;
            dataGridViewOutput_MAP.Columns[0].Width = 40;
            dataGridViewOutput_MAP.Columns[1].Width = 60;

            this.chartGrafik_MAP.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartGrafik_MAP.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartGrafik_MAP.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewOutput_MAP.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartGrafik_MAP.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonInfo_MAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-3, Моденова Анастасия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
