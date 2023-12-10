
namespace Tyuiu.ModenovaAP.Sprint6.Task6.V5
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
            this.groupBoxUslovie_MAP = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_MAP = new System.Windows.Forms.Button();
            this.buttonDone_MAP = new System.Windows.Forms.Button();
            this.buttonOpen_MAP = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput_MAP = new System.Windows.Forms.GroupBox();
            this.textBoxInput_MAP = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MAP = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_MAP = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MAP = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_MAP = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxUslovie_MAP.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInput_MAP.SuspendLayout();
            this.groupBoxOutput_MAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_MAP
            // 
            this.groupBoxUslovie_MAP.Controls.Add(this.textBox1);
            this.groupBoxUslovie_MAP.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUslovie_MAP.Location = new System.Drawing.Point(0, 83);
            this.groupBoxUslovie_MAP.Name = "groupBoxUslovie_MAP";
            this.groupBoxUslovie_MAP.Size = new System.Drawing.Size(693, 62);
            this.groupBoxUslovie_MAP.TabIndex = 1;
            this.groupBoxUslovie_MAP.TabStop = false;
            this.groupBoxUslovie_MAP.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(614, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_MAP);
            this.panel1.Controls.Add(this.buttonDone_MAP);
            this.panel1.Controls.Add(this.buttonOpen_MAP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 83);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_MAP
            // 
            this.buttonHelp_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MAP.BackgroundImage")));
            this.buttonHelp_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_MAP.Location = new System.Drawing.Point(594, 9);
            this.buttonHelp_MAP.Name = "buttonHelp_MAP";
            this.buttonHelp_MAP.Size = new System.Drawing.Size(87, 64);
            this.buttonHelp_MAP.TabIndex = 2;
            this.toolTipButton_MAP.SetToolTip(this.buttonHelp_MAP, "О программе");
            this.buttonHelp_MAP.UseVisualStyleBackColor = true;
            this.buttonHelp_MAP.Click += new System.EventHandler(this.buttonHelp_MAP_Click);
            // 
            // buttonDone_MAP
            // 
            this.buttonDone_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone_MAP.BackgroundImage")));
            this.buttonDone_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_MAP.Enabled = false;
            this.buttonDone_MAP.Location = new System.Drawing.Point(105, 9);
            this.buttonDone_MAP.Name = "buttonDone_MAP";
            this.buttonDone_MAP.Size = new System.Drawing.Size(90, 64);
            this.buttonDone_MAP.TabIndex = 1;
            this.toolTipButton_MAP.SetToolTip(this.buttonDone_MAP, "Выполнить\r\nВывести все слова, где встречается символ I\r\n");
            this.buttonDone_MAP.UseVisualStyleBackColor = true;
            this.buttonDone_MAP.Click += new System.EventHandler(this.buttonDone_MAP_Click);
            // 
            // buttonOpen_MAP
            // 
            this.buttonOpen_MAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpen_MAP.BackgroundImage")));
            this.buttonOpen_MAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpen_MAP.Location = new System.Drawing.Point(9, 9);
            this.buttonOpen_MAP.Name = "buttonOpen_MAP";
            this.buttonOpen_MAP.Size = new System.Drawing.Size(90, 64);
            this.buttonOpen_MAP.TabIndex = 0;
            this.toolTipButton_MAP.SetToolTip(this.buttonOpen_MAP, "Открыть файл\r\nВыберите нужный файл для обработки \r\n");
            this.buttonOpen_MAP.UseVisualStyleBackColor = true;
            this.buttonOpen_MAP.Click += new System.EventHandler(this.buttonOpen_MAP_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 145);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInput_MAP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutput_MAP);
            this.splitContainer1.Size = new System.Drawing.Size(693, 305);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBoxInput_MAP
            // 
            this.groupBoxInput_MAP.Controls.Add(this.textBoxInput_MAP);
            this.groupBoxInput_MAP.Location = new System.Drawing.Point(4, 0);
            this.groupBoxInput_MAP.Name = "groupBoxInput_MAP";
            this.groupBoxInput_MAP.Size = new System.Drawing.Size(224, 302);
            this.groupBoxInput_MAP.TabIndex = 0;
            this.groupBoxInput_MAP.TabStop = false;
            this.groupBoxInput_MAP.Text = "Ввод:";
            // 
            // textBoxInput_MAP
            // 
            this.textBoxInput_MAP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInput_MAP.Location = new System.Drawing.Point(5, 20);
            this.textBoxInput_MAP.Multiline = true;
            this.textBoxInput_MAP.Name = "textBoxInput_MAP";
            this.textBoxInput_MAP.ReadOnly = true;
            this.textBoxInput_MAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_MAP.Size = new System.Drawing.Size(213, 276);
            this.textBoxInput_MAP.TabIndex = 0;
            // 
            // groupBoxOutput_MAP
            // 
            this.groupBoxOutput_MAP.Controls.Add(this.textBoxOutput_MAP);
            this.groupBoxOutput_MAP.Location = new System.Drawing.Point(4, 0);
            this.groupBoxOutput_MAP.Name = "groupBoxOutput_MAP";
            this.groupBoxOutput_MAP.Size = new System.Drawing.Size(451, 302);
            this.groupBoxOutput_MAP.TabIndex = 0;
            this.groupBoxOutput_MAP.TabStop = false;
            this.groupBoxOutput_MAP.Text = "Вывод:";
            // 
            // textBoxOutput_MAP
            // 
            this.textBoxOutput_MAP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOutput_MAP.Location = new System.Drawing.Point(7, 20);
            this.textBoxOutput_MAP.Multiline = true;
            this.textBoxOutput_MAP.Name = "textBoxOutput_MAP";
            this.textBoxOutput_MAP.ReadOnly = true;
            this.textBoxOutput_MAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_MAP.Size = new System.Drawing.Size(438, 276);
            this.textBoxOutput_MAP.TabIndex = 0;
            // 
            // openFileDialogTask_MAP
            // 
            this.openFileDialogTask_MAP.FileName = "openFileDialog1";
            // 
            // FormMain_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBoxUslovie_MAP);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain_MAP";
            this.Text = "Спринт 6 | Таск 6 | Вариант 5 | Моденова А. П.";
            this.groupBoxUslovie_MAP.ResumeLayout(false);
            this.groupBoxUslovie_MAP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInput_MAP.ResumeLayout(false);
            this.groupBoxInput_MAP.PerformLayout();
            this.groupBoxOutput_MAP.ResumeLayout(false);
            this.groupBoxOutput_MAP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_MAP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_MAP;
        private System.Windows.Forms.Button buttonDone_MAP;
        private System.Windows.Forms.Button buttonOpen_MAP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInput_MAP;
        private System.Windows.Forms.TextBox textBoxInput_MAP;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAP;
        private System.Windows.Forms.TextBox textBoxOutput_MAP;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MAP;
        private System.Windows.Forms.ToolTip toolTipButton_MAP;
    }
}

