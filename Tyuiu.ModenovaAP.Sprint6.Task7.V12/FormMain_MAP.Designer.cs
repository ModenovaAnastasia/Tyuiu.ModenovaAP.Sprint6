
namespace Tyuiu.ModenovaAP.Sprint6.Task7.V12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MAP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_MAP = new System.Windows.Forms.Button();
            this.buttonSave_MAP = new System.Windows.Forms.Button();
            this.buttonDone_MAP = new System.Windows.Forms.Button();
            this.buttonOpen_MAP = new System.Windows.Forms.Button();
            this.groupBoxUslovie_MAP = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_MAP = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxOutput_MAP = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_MAP = new System.Windows.Forms.DataGridView();
            this.groupBoxInput_MAP = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_MAP = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_MAP = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_MAP = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_MAP = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBoxUslovie_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxOutput_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_MAP)).BeginInit();
            this.groupBoxInput_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonHelp_MAP);
            this.panel1.Controls.Add(this.buttonSave_MAP);
            this.panel1.Controls.Add(this.buttonDone_MAP);
            this.panel1.Controls.Add(this.buttonOpen_MAP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_MAP
            // 
            this.buttonHelp_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MAP.BackgroundImage")));
            this.buttonHelp_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_MAP.Location = new System.Drawing.Point(696, 12);
            this.buttonHelp_MAP.Name = "buttonHelp_MAP";
            this.buttonHelp_MAP.Size = new System.Drawing.Size(92, 64);
            this.buttonHelp_MAP.TabIndex = 3;
            this.toolTipButton_MAP.SetToolTip(this.buttonHelp_MAP, "О программе");
            this.buttonHelp_MAP.UseVisualStyleBackColor = true;
            this.buttonHelp_MAP.Click += new System.EventHandler(this.buttonHelp_MAP_Click);
            // 
            // buttonSave_MAP
            // 
            this.buttonSave_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave_MAP.BackgroundImage")));
            this.buttonSave_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave_MAP.Location = new System.Drawing.Point(208, 12);
            this.buttonSave_MAP.Name = "buttonSave_MAP";
            this.buttonSave_MAP.Size = new System.Drawing.Size(92, 64);
            this.buttonSave_MAP.TabIndex = 2;
            this.buttonSave_MAP.UseVisualStyleBackColor = true;
            this.buttonSave_MAP.Click += new System.EventHandler(this.buttonSave_MAP_Click);
            // 
            // buttonDone_MAP
            // 
            this.buttonDone_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone_MAP.BackgroundImage")));
            this.buttonDone_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_MAP.Enabled = false;
            this.buttonDone_MAP.Location = new System.Drawing.Point(110, 12);
            this.buttonDone_MAP.Name = "buttonDone_MAP";
            this.buttonDone_MAP.Size = new System.Drawing.Size(92, 64);
            this.buttonDone_MAP.TabIndex = 1;
            this.buttonDone_MAP.UseVisualStyleBackColor = true;
            this.buttonDone_MAP.Click += new System.EventHandler(this.buttonDone_MAP_Click);
            // 
            // buttonOpen_MAP
            // 
            this.buttonOpen_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpen_MAP.BackgroundImage")));
            this.buttonOpen_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpen_MAP.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen_MAP.Name = "buttonOpen_MAP";
            this.buttonOpen_MAP.Size = new System.Drawing.Size(92, 64);
            this.buttonOpen_MAP.TabIndex = 0;
            this.toolTipButton_MAP.SetToolTip(this.buttonOpen_MAP, "Открыть файл\r\nВыберите нужный файл для обработки ");
            this.buttonOpen_MAP.UseVisualStyleBackColor = true;
            this.buttonOpen_MAP.Click += new System.EventHandler(this.buttonOpen_MAP_Click);
            // 
            // groupBoxUslovie_MAP
            // 
            this.groupBoxUslovie_MAP.Controls.Add(this.textBoxUslovie_MAP);
            this.groupBoxUslovie_MAP.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUslovie_MAP.Location = new System.Drawing.Point(0, 95);
            this.groupBoxUslovie_MAP.Name = "groupBoxUslovie_MAP";
            this.groupBoxUslovie_MAP.Size = new System.Drawing.Size(800, 93);
            this.groupBoxUslovie_MAP.TabIndex = 1;
            this.groupBoxUslovie_MAP.TabStop = false;
            this.groupBoxUslovie_MAP.Text = "Условие:";
            // 
            // textBoxUslovie_MAP
            // 
            this.textBoxUslovie_MAP.Location = new System.Drawing.Point(4, 20);
            this.textBoxUslovie_MAP.Multiline = true;
            this.textBoxUslovie_MAP.Name = "textBoxUslovie_MAP";
            this.textBoxUslovie_MAP.ReadOnly = true;
            this.textBoxUslovie_MAP.Size = new System.Drawing.Size(787, 67);
            this.textBoxUslovie_MAP.TabIndex = 0;
            this.textBoxUslovie_MAP.Text = resources.GetString("textBoxUslovie_MAP.Text");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 188);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOutput_MAP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxInput_MAP);
            this.splitContainer1.Size = new System.Drawing.Size(800, 262);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBoxOutput_MAP
            // 
            this.groupBoxOutput_MAP.Controls.Add(this.dataGridViewOutput_MAP);
            this.groupBoxOutput_MAP.Location = new System.Drawing.Point(4, 4);
            this.groupBoxOutput_MAP.Name = "groupBoxOutput_MAP";
            this.groupBoxOutput_MAP.Size = new System.Drawing.Size(259, 255);
            this.groupBoxOutput_MAP.TabIndex = 0;
            this.groupBoxOutput_MAP.TabStop = false;
            this.groupBoxOutput_MAP.Text = "Вывод:";
            // 
            // dataGridViewOutput_MAP
            // 
            this.dataGridViewOutput_MAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_MAP.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput_MAP.Name = "dataGridViewOutput_MAP";
            this.dataGridViewOutput_MAP.Size = new System.Drawing.Size(253, 236);
            this.dataGridViewOutput_MAP.TabIndex = 0;
            // 
            // groupBoxInput_MAP
            // 
            this.groupBoxInput_MAP.Controls.Add(this.dataGridViewInput_MAP);
            this.groupBoxInput_MAP.Location = new System.Drawing.Point(3, 4);
            this.groupBoxInput_MAP.Name = "groupBoxInput_MAP";
            this.groupBoxInput_MAP.Size = new System.Drawing.Size(524, 255);
            this.groupBoxInput_MAP.TabIndex = 0;
            this.groupBoxInput_MAP.TabStop = false;
            this.groupBoxInput_MAP.Text = "Ввод:";
            // 
            // dataGridViewInput_MAP
            // 
            this.dataGridViewInput_MAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_MAP.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_MAP.Name = "dataGridViewInput_MAP";
            this.dataGridViewInput_MAP.Size = new System.Drawing.Size(518, 236);
            this.dataGridViewInput_MAP.TabIndex = 0;
            // 
            // openFileDialogTask_MAP
            // 
            this.openFileDialogTask_MAP.FileName = "openFileDialog1";
            // 
            // FormMain_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBoxUslovie_MAP);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain_MAP";
            this.Text = "Спринт 6 | Таск 7 | Вариант 12 | Моденова А. П.";
            this.panel1.ResumeLayout(false);
            this.groupBoxUslovie_MAP.ResumeLayout(false);
            this.groupBoxUslovie_MAP.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxOutput_MAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_MAP)).EndInit();
            this.groupBoxInput_MAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_MAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_MAP;
        private System.Windows.Forms.Button buttonSave_MAP;
        private System.Windows.Forms.Button buttonDone_MAP;
        private System.Windows.Forms.Button buttonOpen_MAP;
        private System.Windows.Forms.GroupBox groupBoxUslovie_MAP;
        private System.Windows.Forms.TextBox textBoxUslovie_MAP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAP;
        private System.Windows.Forms.DataGridView dataGridViewOutput_MAP;
        private System.Windows.Forms.GroupBox groupBoxInput_MAP;
        private System.Windows.Forms.DataGridView dataGridViewInput_MAP;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MAP;
        private System.Windows.Forms.ToolTip toolTipButton_MAP;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_MAP;
    }
}

