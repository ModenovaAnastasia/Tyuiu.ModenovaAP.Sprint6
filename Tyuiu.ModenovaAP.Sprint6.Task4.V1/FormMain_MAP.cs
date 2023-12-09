using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ModenovaAP.Sprint6.Task4.V1.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task4.V1
{
    public partial class FormMain_MAP : Form
    {
        public FormMain_MAP()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonUse_MAP_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_MAP.Text);
                int stop = Convert.ToInt32(textBoxEnd_MAP.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chartGraf_MAP.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraf_MAP.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_MAP.Text = "";
                chartGraf_MAP.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartGraf_MAP.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxResult_MAP.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_MAP_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFile.Task4.txt";
                File.WriteAllText(path, textBoxResult_MAP.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_MAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-3, Моденова Анастасия Павловна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
