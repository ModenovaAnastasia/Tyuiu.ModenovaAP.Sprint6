using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint6.Task0.V3.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task0.V3
{
    public partial class FormMain_MAP : Form
    {
        public FormMain_MAP()
        {
            InitializeComponent();
        }

        private void buttonВыполнить_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxРезультат.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxПеременнаяX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonВопросы_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-3 Моденова Анастасия Павловна", "Alert");
        }
        private void textBoxПеременнаяX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
