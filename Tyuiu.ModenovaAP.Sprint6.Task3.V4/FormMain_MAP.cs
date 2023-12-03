using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint6.Task3.V4.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task3.V4
{
    public partial class FormMain_MAP : Form
    {
        public FormMain_MAP()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {  -14,-7,18,12,-20 },
                                         { -2,-15,-19,-19,-3 },
                                         { -18,-5,-10,14,-17 },
                                         { -1,2,-10,0,11 },
                                         { 6,-18,0,19,16 } };
        private void buttonUse_MAP_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewRes_MAP.ColumnCount = columns;
            dataGridViewRes_MAP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_MAP.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_MAP.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonInfo_MAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-3 Моденова Анастасия Павловна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_MAP_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewStart_MAP.ColumnCount = columns;
            dataGridViewStart_MAP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewStart_MAP.Columns[i].Width = 46;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewStart_MAP.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
