
namespace Tyuiu.ModenovaAP.Sprint6.Task3.V4
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
            this.groupBoxUslovie_MAP = new System.Windows.Forms.GroupBox();
            this.dataGridViewStart_MAP = new System.Windows.Forms.DataGridView();
            this.textBoxUslovie_MAP = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MAP = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_MAP = new System.Windows.Forms.DataGridView();
            this.labelResult_MAP = new System.Windows.Forms.Label();
            this.buttonInfo_MAP = new System.Windows.Forms.Button();
            this.buttonUse_MAP = new System.Windows.Forms.Button();
            this.groupBoxUslovie_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart_MAP)).BeginInit();
            this.groupBoxOutput_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_MAP
            // 
            this.groupBoxUslovie_MAP.Controls.Add(this.dataGridViewStart_MAP);
            this.groupBoxUslovie_MAP.Controls.Add(this.textBoxUslovie_MAP);
            this.groupBoxUslovie_MAP.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_MAP.Name = "groupBoxUslovie_MAP";
            this.groupBoxUslovie_MAP.Size = new System.Drawing.Size(546, 370);
            this.groupBoxUslovie_MAP.TabIndex = 0;
            this.groupBoxUslovie_MAP.TabStop = false;
            this.groupBoxUslovie_MAP.Text = "Условие:";
            // 
            // dataGridViewStart_MAP
            // 
            this.dataGridViewStart_MAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStart_MAP.ColumnHeadersVisible = false;
            this.dataGridViewStart_MAP.Location = new System.Drawing.Point(289, 35);
            this.dataGridViewStart_MAP.Name = "dataGridViewStart_MAP";
            this.dataGridViewStart_MAP.RowHeadersVisible = false;
            this.dataGridViewStart_MAP.Size = new System.Drawing.Size(240, 219);
            this.dataGridViewStart_MAP.TabIndex = 1;
            // 
            // textBoxUslovie_MAP
            // 
            this.textBoxUslovie_MAP.Location = new System.Drawing.Point(7, 20);
            this.textBoxUslovie_MAP.Multiline = true;
            this.textBoxUslovie_MAP.Name = "textBoxUslovie_MAP";
            this.textBoxUslovie_MAP.ReadOnly = true;
            this.textBoxUslovie_MAP.Size = new System.Drawing.Size(264, 149);
            this.textBoxUslovie_MAP.TabIndex = 0;
            this.textBoxUslovie_MAP.Text = resources.GetString("textBoxUslovie_MAP.Text");
            // 
            // groupBoxOutput_MAP
            // 
            this.groupBoxOutput_MAP.Controls.Add(this.dataGridViewRes_MAP);
            this.groupBoxOutput_MAP.Controls.Add(this.labelResult_MAP);
            this.groupBoxOutput_MAP.Location = new System.Drawing.Point(565, 12);
            this.groupBoxOutput_MAP.Name = "groupBoxOutput_MAP";
            this.groupBoxOutput_MAP.Size = new System.Drawing.Size(253, 370);
            this.groupBoxOutput_MAP.TabIndex = 1;
            this.groupBoxOutput_MAP.TabStop = false;
            this.groupBoxOutput_MAP.Text = "Вывод данных:";
            // 
            // dataGridViewRes_MAP
            // 
            this.dataGridViewRes_MAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MAP.ColumnHeadersVisible = false;
            this.dataGridViewRes_MAP.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewRes_MAP.Name = "dataGridViewRes_MAP";
            this.dataGridViewRes_MAP.RowHeadersVisible = false;
            this.dataGridViewRes_MAP.Size = new System.Drawing.Size(240, 219);
            this.dataGridViewRes_MAP.TabIndex = 1;
            // 
            // labelResult_MAP
            // 
            this.labelResult_MAP.AutoSize = true;
            this.labelResult_MAP.Location = new System.Drawing.Point(7, 20);
            this.labelResult_MAP.Name = "labelResult_MAP";
            this.labelResult_MAP.Size = new System.Drawing.Size(62, 13);
            this.labelResult_MAP.TabIndex = 0;
            this.labelResult_MAP.Text = "Результат:";
            // 
            // buttonInfo_MAP
            // 
            this.buttonInfo_MAP.Location = new System.Drawing.Point(698, 395);
            this.buttonInfo_MAP.Name = "buttonInfo_MAP";
            this.buttonInfo_MAP.Size = new System.Drawing.Size(37, 36);
            this.buttonInfo_MAP.TabIndex = 2;
            this.buttonInfo_MAP.Text = "?";
            this.buttonInfo_MAP.UseVisualStyleBackColor = true;
            // 
            // buttonUse_MAP
            // 
            this.buttonUse_MAP.Location = new System.Drawing.Point(741, 395);
            this.buttonUse_MAP.Name = "buttonUse_MAP";
            this.buttonUse_MAP.Size = new System.Drawing.Size(77, 36);
            this.buttonUse_MAP.TabIndex = 3;
            this.buttonUse_MAP.Text = "Выполнить";
            this.buttonUse_MAP.UseVisualStyleBackColor = true;
            this.buttonUse_MAP.Click += new System.EventHandler(this.buttonUse_MAP_Click);
            // 
            // FormMain_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.buttonUse_MAP);
            this.Controls.Add(this.buttonInfo_MAP);
            this.Controls.Add(this.groupBoxOutput_MAP);
            this.Controls.Add(this.groupBoxUslovie_MAP);
            this.Name = "FormMain_MAP";
            this.Text = "Спринт 6 | Таск 3 | Вариант 4 | Моденова А. П.";
            this.Load += new System.EventHandler(this.FormMain_MAP_Load);
            this.groupBoxUslovie_MAP.ResumeLayout(false);
            this.groupBoxUslovie_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart_MAP)).EndInit();
            this.groupBoxOutput_MAP.ResumeLayout(false);
            this.groupBoxOutput_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_MAP;
        private System.Windows.Forms.DataGridView dataGridViewStart_MAP;
        private System.Windows.Forms.TextBox textBoxUslovie_MAP;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAP;
        private System.Windows.Forms.DataGridView dataGridViewRes_MAP;
        private System.Windows.Forms.Label labelResult_MAP;
        private System.Windows.Forms.Button buttonInfo_MAP;
        private System.Windows.Forms.Button buttonUse_MAP;
    }
}

