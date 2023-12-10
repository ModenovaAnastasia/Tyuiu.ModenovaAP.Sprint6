using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint6.Task7.V12.Lib;
using System.IO;

namespace Tyuiu.ModenovaAP.Sprint6.Task7.V12
{
    public partial class FormMain_MAP : Form
    {
        public FormMain_MAP()
        {
            InitializeComponent();
            openFileDialogTask_MAP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_MAP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpen_MAP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAP.ShowDialog();
            openFilePath = openFileDialogTask_MAP.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_MAP.ColumnCount = columns;
            dataGridViewInput_MAP.RowCount = rows;
            dataGridViewOutput_MAP.ColumnCount = columns;
            dataGridViewOutput_MAP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_MAP.Columns[i].Width = 30;
                dataGridViewOutput_MAP.Columns[i].Width = 30;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_MAP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_MAP.Enabled = true;
        }

        private void buttonDone_MAP_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_MAP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_MAP.Enabled = true;
        }

        private void buttonSave_MAP_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MAP.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MAP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MAP.ShowDialog();

            string path = saveFileDialogMatrix_MAP.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutput_MAP.RowCount;
            int columns = dataGridViewOutput_MAP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_MAP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_MAP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_MAP_Click(object sender, EventArgs e)
        {
            FormAbout_MAP formAbout = new FormAbout_MAP();
            formAbout.ShowDialog();
        }
        private void FormMain_MAP_Load(object sender, EventArgs e)
        {
            dataGridViewInput_MAP.ColumnCount = 50;
            dataGridViewOutput_MAP.ColumnCount = 50;

            dataGridViewInput_MAP.RowCount = 50;
            dataGridViewOutput_MAP.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_MAP.Columns[i].Width = 30;
                dataGridViewOutput_MAP.Columns[i].Width = 30;
            }
        }
        private void buttonOpenFile_MAP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAP.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MAP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAP.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MAP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAP.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_MAP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAP.ToolTipTitle = "Сведения";
        }
    }
}
