
namespace Tyuiu.ModenovaAP.Sprint6.Task2.V4
{
    partial class FormMain_MAP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MAP));
            this.buttonuse_MAP = new System.Windows.Forms.Button();
            this.buttoninfo_MAP = new System.Windows.Forms.Button();
            this.groupBoxInput_MAP = new System.Windows.Forms.GroupBox();
            this.labelstart_MAP = new System.Windows.Forms.Label();
            this.labelend_MAP = new System.Windows.Forms.Label();
            this.textBox_Start_MAP = new System.Windows.Forms.TextBox();
            this.textBoxEnd_MAP = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MAP = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_MAP = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FfromX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFfromX_MAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelres_MAP = new System.Windows.Forms.Label();
            this.groupBoxuslov_MAP = new System.Windows.Forms.GroupBox();
            this.pictureBoxformula_MAP = new System.Windows.Forms.PictureBox();
            this.labeltextprod_MAP = new System.Windows.Forms.Label();
            this.labeltext_MAP = new System.Windows.Forms.Label();
            this.groupBoxInput_MAP.SuspendLayout();
            this.groupBoxOutput_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFfromX_MAP)).BeginInit();
            this.groupBoxuslov_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxformula_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonuse_MAP
            // 
            this.buttonuse_MAP.BackColor = System.Drawing.Color.Green;
            this.buttonuse_MAP.Location = new System.Drawing.Point(287, 367);
            this.buttonuse_MAP.Name = "buttonuse_MAP";
            this.buttonuse_MAP.Size = new System.Drawing.Size(102, 77);
            this.buttonuse_MAP.TabIndex = 9;
            this.buttonuse_MAP.Text = "Выполнить";
            this.buttonuse_MAP.UseVisualStyleBackColor = false;
            this.buttonuse_MAP.Click += new System.EventHandler(this.buttonuse_MAP_Click);
            // 
            // buttoninfo_MAP
            // 
            this.buttoninfo_MAP.BackColor = System.Drawing.Color.SteelBlue;
            this.buttoninfo_MAP.Location = new System.Drawing.Point(206, 367);
            this.buttoninfo_MAP.Name = "buttoninfo_MAP";
            this.buttoninfo_MAP.Size = new System.Drawing.Size(75, 77);
            this.buttoninfo_MAP.TabIndex = 8;
            this.buttoninfo_MAP.Text = "Справка";
            this.buttoninfo_MAP.UseVisualStyleBackColor = false;
            this.buttoninfo_MAP.Click += new System.EventHandler(this.buttoninfo_MAP_Click);
            // 
            // groupBoxInput_MAP
            // 
            this.groupBoxInput_MAP.Controls.Add(this.labelstart_MAP);
            this.groupBoxInput_MAP.Controls.Add(this.labelend_MAP);
            this.groupBoxInput_MAP.Controls.Add(this.textBox_Start_MAP);
            this.groupBoxInput_MAP.Controls.Add(this.textBoxEnd_MAP);
            this.groupBoxInput_MAP.Location = new System.Drawing.Point(13, 367);
            this.groupBoxInput_MAP.Name = "groupBoxInput_MAP";
            this.groupBoxInput_MAP.Size = new System.Drawing.Size(187, 77);
            this.groupBoxInput_MAP.TabIndex = 7;
            this.groupBoxInput_MAP.TabStop = false;
            this.groupBoxInput_MAP.Text = "Ввод данных:";
            // 
            // labelstart_MAP
            // 
            this.labelstart_MAP.AutoSize = true;
            this.labelstart_MAP.Location = new System.Drawing.Point(8, 31);
            this.labelstart_MAP.Name = "labelstart_MAP";
            this.labelstart_MAP.Size = new System.Drawing.Size(67, 13);
            this.labelstart_MAP.TabIndex = 2;
            this.labelstart_MAP.Text = "Старт шага:";
            // 
            // labelend_MAP
            // 
            this.labelend_MAP.AutoSize = true;
            this.labelend_MAP.Location = new System.Drawing.Point(95, 32);
            this.labelend_MAP.Name = "labelend_MAP";
            this.labelend_MAP.Size = new System.Drawing.Size(69, 13);
            this.labelend_MAP.TabIndex = 1;
            this.labelend_MAP.Text = "Конец шага:";
            // 
            // textBox_Start_MAP
            // 
            this.textBox_Start_MAP.Location = new System.Drawing.Point(11, 51);
            this.textBox_Start_MAP.Name = "textBox_Start_MAP";
            this.textBox_Start_MAP.Size = new System.Drawing.Size(81, 20);
            this.textBox_Start_MAP.TabIndex = 0;
            // 
            // textBoxEnd_MAP
            // 
            this.textBoxEnd_MAP.Location = new System.Drawing.Point(98, 51);
            this.textBoxEnd_MAP.Name = "textBoxEnd_MAP";
            this.textBoxEnd_MAP.Size = new System.Drawing.Size(81, 20);
            this.textBoxEnd_MAP.TabIndex = 0;
            // 
            // groupBoxOutput_MAP
            // 
            this.groupBoxOutput_MAP.Controls.Add(this.dataGridViewFunction_MAP);
            this.groupBoxOutput_MAP.Controls.Add(this.chartFfromX_MAP);
            this.groupBoxOutput_MAP.Controls.Add(this.labelres_MAP);
            this.groupBoxOutput_MAP.Location = new System.Drawing.Point(395, 7);
            this.groupBoxOutput_MAP.Name = "groupBoxOutput_MAP";
            this.groupBoxOutput_MAP.Size = new System.Drawing.Size(532, 426);
            this.groupBoxOutput_MAP.TabIndex = 6;
            this.groupBoxOutput_MAP.TabStop = false;
            this.groupBoxOutput_MAP.Text = "Вывод данных:";
            // 
            // dataGridViewFunction_MAP
            // 
            this.dataGridViewFunction_MAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_MAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.FfromX});
            this.dataGridViewFunction_MAP.Location = new System.Drawing.Point(6, 43);
            this.dataGridViewFunction_MAP.Name = "dataGridViewFunction_MAP";
            this.dataGridViewFunction_MAP.RowHeadersVisible = false;
            this.dataGridViewFunction_MAP.Size = new System.Drawing.Size(117, 377);
            this.dataGridViewFunction_MAP.TabIndex = 3;
            this.dataGridViewFunction_MAP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_MAP_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // FfromX
            // 
            this.FfromX.HeaderText = "F(X)";
            this.FfromX.Name = "FfromX";
            this.FfromX.ReadOnly = true;
            this.FfromX.Width = 50;
            // 
            // chartFfromX_MAP
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFfromX_MAP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFfromX_MAP.Legends.Add(legend1);
            this.chartFfromX_MAP.Location = new System.Drawing.Point(129, 43);
            this.chartFfromX_MAP.Name = "chartFfromX_MAP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFfromX_MAP.Series.Add(series1);
            this.chartFfromX_MAP.Size = new System.Drawing.Size(397, 377);
            this.chartFfromX_MAP.TabIndex = 2;
            this.chartFfromX_MAP.Text = "chart1";
            // 
            // labelres_MAP
            // 
            this.labelres_MAP.AutoSize = true;
            this.labelres_MAP.Location = new System.Drawing.Point(7, 21);
            this.labelres_MAP.Name = "labelres_MAP";
            this.labelres_MAP.Size = new System.Drawing.Size(62, 13);
            this.labelres_MAP.TabIndex = 0;
            this.labelres_MAP.Text = "Результат:";
            // 
            // groupBoxuslov_MAP
            // 
            this.groupBoxuslov_MAP.Controls.Add(this.pictureBoxformula_MAP);
            this.groupBoxuslov_MAP.Controls.Add(this.labeltextprod_MAP);
            this.groupBoxuslov_MAP.Controls.Add(this.labeltext_MAP);
            this.groupBoxuslov_MAP.Location = new System.Drawing.Point(13, 8);
            this.groupBoxuslov_MAP.Name = "groupBoxuslov_MAP";
            this.groupBoxuslov_MAP.Size = new System.Drawing.Size(376, 353);
            this.groupBoxuslov_MAP.TabIndex = 5;
            this.groupBoxuslov_MAP.TabStop = false;
            this.groupBoxuslov_MAP.Text = "Условие:";
            // 
            // pictureBoxformula_MAP
            // 
            this.pictureBoxformula_MAP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxformula_MAP.Image")));
            this.pictureBoxformula_MAP.Location = new System.Drawing.Point(10, 42);
            this.pictureBoxformula_MAP.Name = "pictureBoxformula_MAP";
            this.pictureBoxformula_MAP.Size = new System.Drawing.Size(210, 40);
            this.pictureBoxformula_MAP.TabIndex = 2;
            this.pictureBoxformula_MAP.TabStop = false;
            // 
            // labeltextprod_MAP
            // 
            this.labeltextprod_MAP.Location = new System.Drawing.Point(7, 85);
            this.labeltextprod_MAP.Name = "labeltextprod_MAP";
            this.labeltextprod_MAP.Size = new System.Drawing.Size(325, 130);
            this.labeltextprod_MAP.TabIndex = 1;
            this.labeltextprod_MAP.Text = "(произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвест" +
    "и проверку деления на ноль. При делении на ноль вернуть значение 0. ";
            // 
            // labeltext_MAP
            // 
            this.labeltext_MAP.AutoSize = true;
            this.labeltext_MAP.Location = new System.Drawing.Point(7, 20);
            this.labeltext_MAP.Name = "labeltext_MAP";
            this.labeltext_MAP.Size = new System.Drawing.Size(350, 13);
            this.labeltext_MAP.TabIndex = 0;
            this.labeltext_MAP.Text = "Написать программу, которая выводит таблицу значений функции:";
            // 
            // FormMain_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.buttonuse_MAP);
            this.Controls.Add(this.buttoninfo_MAP);
            this.Controls.Add(this.groupBoxInput_MAP);
            this.Controls.Add(this.groupBoxOutput_MAP);
            this.Controls.Add(this.groupBoxuslov_MAP);
            this.Name = "FormMain_MAP";
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Моденова А. П.";
            this.groupBoxInput_MAP.ResumeLayout(false);
            this.groupBoxInput_MAP.PerformLayout();
            this.groupBoxOutput_MAP.ResumeLayout(false);
            this.groupBoxOutput_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFfromX_MAP)).EndInit();
            this.groupBoxuslov_MAP.ResumeLayout(false);
            this.groupBoxuslov_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxformula_MAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonuse_MAP;
        private System.Windows.Forms.Button buttoninfo_MAP;
        private System.Windows.Forms.GroupBox groupBoxInput_MAP;
        private System.Windows.Forms.Label labelstart_MAP;
        private System.Windows.Forms.Label labelend_MAP;
        private System.Windows.Forms.TextBox textBox_Start_MAP;
        private System.Windows.Forms.TextBox textBoxEnd_MAP;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAP;
        private System.Windows.Forms.Label labelres_MAP;
        private System.Windows.Forms.GroupBox groupBoxuslov_MAP;
        private System.Windows.Forms.PictureBox pictureBoxformula_MAP;
        private System.Windows.Forms.Label labeltextprod_MAP;
        private System.Windows.Forms.Label labeltext_MAP;
        private System.Windows.Forms.DataGridView dataGridViewFunction_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn FfromX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFfromX_MAP;
    }
}

