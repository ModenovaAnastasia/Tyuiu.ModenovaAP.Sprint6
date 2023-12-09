
namespace Tyuiu.ModenovaAP.Sprint6.Task5.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MAP));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_MAP = new System.Windows.Forms.GroupBox();
            this.buttonInfo_MAP = new System.Windows.Forms.Button();
            this.buttonOpen_MAP = new System.Windows.Forms.Button();
            this.buttonUse_MAP = new System.Windows.Forms.Button();
            this.textBoxUslovie_MAP = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MAP = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_MAP = new System.Windows.Forms.DataGridView();
            this.chartGrafik_MAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovie_MAP.SuspendLayout();
            this.groupBoxOutput_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_MAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafik_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_MAP
            // 
            this.groupBoxUslovie_MAP.Controls.Add(this.buttonInfo_MAP);
            this.groupBoxUslovie_MAP.Controls.Add(this.buttonOpen_MAP);
            this.groupBoxUslovie_MAP.Controls.Add(this.buttonUse_MAP);
            this.groupBoxUslovie_MAP.Controls.Add(this.textBoxUslovie_MAP);
            this.groupBoxUslovie_MAP.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_MAP.Name = "groupBoxUslovie_MAP";
            this.groupBoxUslovie_MAP.Size = new System.Drawing.Size(742, 100);
            this.groupBoxUslovie_MAP.TabIndex = 0;
            this.groupBoxUslovie_MAP.TabStop = false;
            this.groupBoxUslovie_MAP.Text = "Условие:";
            // 
            // buttonInfo_MAP
            // 
            this.buttonInfo_MAP.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonInfo_MAP.Location = new System.Drawing.Point(639, 19);
            this.buttonInfo_MAP.Name = "buttonInfo_MAP";
            this.buttonInfo_MAP.Size = new System.Drawing.Size(90, 54);
            this.buttonInfo_MAP.TabIndex = 3;
            this.buttonInfo_MAP.Text = "Справка";
            this.buttonInfo_MAP.UseVisualStyleBackColor = false;
            this.buttonInfo_MAP.Click += new System.EventHandler(this.buttonInfo_MAP_Click);
            // 
            // buttonOpen_MAP
            // 
            this.buttonOpen_MAP.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpen_MAP.Location = new System.Drawing.Point(543, 20);
            this.buttonOpen_MAP.Name = "buttonOpen_MAP";
            this.buttonOpen_MAP.Size = new System.Drawing.Size(90, 53);
            this.buttonOpen_MAP.TabIndex = 2;
            this.buttonOpen_MAP.Text = "Открыть файл";
            this.buttonOpen_MAP.UseVisualStyleBackColor = false;
            this.buttonOpen_MAP.Click += new System.EventHandler(this.buttonOpen_MAP_Click);
            // 
            // buttonUse_MAP
            // 
            this.buttonUse_MAP.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUse_MAP.Location = new System.Drawing.Point(446, 20);
            this.buttonUse_MAP.Name = "buttonUse_MAP";
            this.buttonUse_MAP.Size = new System.Drawing.Size(90, 53);
            this.buttonUse_MAP.TabIndex = 1;
            this.buttonUse_MAP.Text = "Выполнить";
            this.buttonUse_MAP.UseVisualStyleBackColor = false;
            this.buttonUse_MAP.Click += new System.EventHandler(this.buttonUse_MAP_Click);
            // 
            // textBoxUslovie_MAP
            // 
            this.textBoxUslovie_MAP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUslovie_MAP.Location = new System.Drawing.Point(7, 20);
            this.textBoxUslovie_MAP.Multiline = true;
            this.textBoxUslovie_MAP.Name = "textBoxUslovie_MAP";
            this.textBoxUslovie_MAP.Size = new System.Drawing.Size(433, 74);
            this.textBoxUslovie_MAP.TabIndex = 0;
            this.textBoxUslovie_MAP.Text = resources.GetString("textBoxUslovie_MAP.Text");
            // 
            // groupBoxOutput_MAP
            // 
            this.groupBoxOutput_MAP.Controls.Add(this.dataGridViewOutput_MAP);
            this.groupBoxOutput_MAP.Controls.Add(this.chartGrafik_MAP);
            this.groupBoxOutput_MAP.Location = new System.Drawing.Point(13, 120);
            this.groupBoxOutput_MAP.Name = "groupBoxOutput_MAP";
            this.groupBoxOutput_MAP.Size = new System.Drawing.Size(742, 397);
            this.groupBoxOutput_MAP.TabIndex = 1;
            this.groupBoxOutput_MAP.TabStop = false;
            this.groupBoxOutput_MAP.Text = "Вывод данных:";
            // 
            // dataGridViewOutput_MAP
            // 
            this.dataGridViewOutput_MAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_MAP.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOutput_MAP.Name = "dataGridViewOutput_MAP";
            this.dataGridViewOutput_MAP.Size = new System.Drawing.Size(179, 371);
            this.dataGridViewOutput_MAP.TabIndex = 1;
            // 
            // chartGrafik_MAP
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGrafik_MAP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGrafik_MAP.Legends.Add(legend2);
            this.chartGrafik_MAP.Location = new System.Drawing.Point(192, 20);
            this.chartGrafik_MAP.Name = "chartGrafik_MAP";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGrafik_MAP.Series.Add(series2);
            this.chartGrafik_MAP.Size = new System.Drawing.Size(544, 371);
            this.chartGrafik_MAP.TabIndex = 0;
            this.chartGrafik_MAP.Text = "chart1";
            // 
            // FormMain_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 529);
            this.Controls.Add(this.groupBoxOutput_MAP);
            this.Controls.Add(this.groupBoxUslovie_MAP);
            this.Name = "FormMain_MAP";
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 | Моденова А. П.";
            this.groupBoxUslovie_MAP.ResumeLayout(false);
            this.groupBoxUslovie_MAP.PerformLayout();
            this.groupBoxOutput_MAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_MAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafik_MAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_MAP;
        private System.Windows.Forms.Button buttonInfo_MAP;
        private System.Windows.Forms.Button buttonOpen_MAP;
        private System.Windows.Forms.Button buttonUse_MAP;
        private System.Windows.Forms.TextBox textBoxUslovie_MAP;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAP;
        private System.Windows.Forms.DataGridView dataGridViewOutput_MAP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafik_MAP;
    }
}

