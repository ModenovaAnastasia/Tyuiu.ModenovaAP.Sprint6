
namespace Tyuiu.ModenovaAP.Sprint6.Task1.V14
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
            this.groupBoxuslov_MAP = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_MAP = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_MAP = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_MAP = new System.Windows.Forms.TextBox();
            this.textBox_Start_MAP = new System.Windows.Forms.TextBox();
            this.labeltext_MAP = new System.Windows.Forms.Label();
            this.labeltextprod_MAP = new System.Windows.Forms.Label();
            this.pictureBoxformula_MAP = new System.Windows.Forms.PictureBox();
            this.labelres_MAP = new System.Windows.Forms.Label();
            this.buttoninfo_MAP = new System.Windows.Forms.Button();
            this.buttonuse_MAP = new System.Windows.Forms.Button();
            this.labelend_MAP = new System.Windows.Forms.Label();
            this.labelstart_MAP = new System.Windows.Forms.Label();
            this.textBoxres_MAP = new System.Windows.Forms.TextBox();
            this.groupBoxuslov_MAP.SuspendLayout();
            this.groupBoxOutput_MAP.SuspendLayout();
            this.groupBoxInput_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxformula_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxuslov_MAP
            // 
            this.groupBoxuslov_MAP.Controls.Add(this.pictureBoxformula_MAP);
            this.groupBoxuslov_MAP.Controls.Add(this.labeltextprod_MAP);
            this.groupBoxuslov_MAP.Controls.Add(this.labeltext_MAP);
            this.groupBoxuslov_MAP.Location = new System.Drawing.Point(13, 13);
            this.groupBoxuslov_MAP.Name = "groupBoxuslov_MAP";
            this.groupBoxuslov_MAP.Size = new System.Drawing.Size(491, 353);
            this.groupBoxuslov_MAP.TabIndex = 0;
            this.groupBoxuslov_MAP.TabStop = false;
            this.groupBoxuslov_MAP.Text = "Условие:";
            // 
            // groupBoxOutput_MAP
            // 
            this.groupBoxOutput_MAP.Controls.Add(this.textBoxres_MAP);
            this.groupBoxOutput_MAP.Controls.Add(this.labelres_MAP);
            this.groupBoxOutput_MAP.Location = new System.Drawing.Point(510, 12);
            this.groupBoxOutput_MAP.Name = "groupBoxOutput_MAP";
            this.groupBoxOutput_MAP.Size = new System.Drawing.Size(278, 426);
            this.groupBoxOutput_MAP.TabIndex = 1;
            this.groupBoxOutput_MAP.TabStop = false;
            this.groupBoxOutput_MAP.Text = "Вывод данных:";
            // 
            // groupBoxInput_MAP
            // 
            this.groupBoxInput_MAP.Controls.Add(this.labelstart_MAP);
            this.groupBoxInput_MAP.Controls.Add(this.labelend_MAP);
            this.groupBoxInput_MAP.Controls.Add(this.textBox_Start_MAP);
            this.groupBoxInput_MAP.Controls.Add(this.textBoxEnd_MAP);
            this.groupBoxInput_MAP.Location = new System.Drawing.Point(13, 372);
            this.groupBoxInput_MAP.Name = "groupBoxInput_MAP";
            this.groupBoxInput_MAP.Size = new System.Drawing.Size(292, 77);
            this.groupBoxInput_MAP.TabIndex = 2;
            this.groupBoxInput_MAP.TabStop = false;
            this.groupBoxInput_MAP.Text = "Ввод данных:";
            // 
            // textBoxEnd_MAP
            // 
            this.textBoxEnd_MAP.Location = new System.Drawing.Point(150, 51);
            this.textBoxEnd_MAP.Name = "textBoxEnd_MAP";
            this.textBoxEnd_MAP.Size = new System.Drawing.Size(133, 20);
            this.textBoxEnd_MAP.TabIndex = 0;
            // 
            // textBox_Start_MAP
            // 
            this.textBox_Start_MAP.Location = new System.Drawing.Point(11, 51);
            this.textBox_Start_MAP.Name = "textBox_Start_MAP";
            this.textBox_Start_MAP.Size = new System.Drawing.Size(133, 20);
            this.textBox_Start_MAP.TabIndex = 0;
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
            // labeltextprod_MAP
            // 
            this.labeltextprod_MAP.Location = new System.Drawing.Point(7, 85);
            this.labeltextprod_MAP.Name = "labeltextprod_MAP";
            this.labeltextprod_MAP.Size = new System.Drawing.Size(325, 130);
            this.labeltextprod_MAP.TabIndex = 1;
            this.labeltextprod_MAP.Text = "(произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвест" +
    "и проверку деления на ноль. При делении на ноль вернуть значение 0. ";
            // 
            // pictureBoxformula_MAP
            // 
            this.pictureBoxformula_MAP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxformula_MAP.Image")));
            this.pictureBoxformula_MAP.Location = new System.Drawing.Point(10, 42);
            this.pictureBoxformula_MAP.Name = "pictureBoxformula_MAP";
            this.pictureBoxformula_MAP.Size = new System.Drawing.Size(189, 37);
            this.pictureBoxformula_MAP.TabIndex = 2;
            this.pictureBoxformula_MAP.TabStop = false;
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
            // buttoninfo_MAP
            // 
            this.buttoninfo_MAP.BackColor = System.Drawing.Color.SteelBlue;
            this.buttoninfo_MAP.Location = new System.Drawing.Point(321, 372);
            this.buttoninfo_MAP.Name = "buttoninfo_MAP";
            this.buttoninfo_MAP.Size = new System.Drawing.Size(75, 77);
            this.buttoninfo_MAP.TabIndex = 3;
            this.buttoninfo_MAP.Text = "Справка";
            this.buttoninfo_MAP.UseVisualStyleBackColor = false;
            // 
            // buttonuse_MAP
            // 
            this.buttonuse_MAP.BackColor = System.Drawing.Color.Green;
            this.buttonuse_MAP.Location = new System.Drawing.Point(402, 372);
            this.buttonuse_MAP.Name = "buttonuse_MAP";
            this.buttonuse_MAP.Size = new System.Drawing.Size(102, 77);
            this.buttonuse_MAP.TabIndex = 4;
            this.buttonuse_MAP.Text = "Выполнить";
            this.buttonuse_MAP.UseVisualStyleBackColor = false;
            this.buttonuse_MAP.Click += new System.EventHandler(this.buttonuse_MAP_Click);
            // 
            // labelend_MAP
            // 
            this.labelend_MAP.AutoSize = true;
            this.labelend_MAP.Location = new System.Drawing.Point(147, 31);
            this.labelend_MAP.Name = "labelend_MAP";
            this.labelend_MAP.Size = new System.Drawing.Size(69, 13);
            this.labelend_MAP.TabIndex = 1;
            this.labelend_MAP.Text = "Конец шага:";
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
            // textBoxres_MAP
            // 
            this.textBoxres_MAP.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxres_MAP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxres_MAP.Location = new System.Drawing.Point(10, 43);
            this.textBoxres_MAP.Multiline = true;
            this.textBoxres_MAP.Name = "textBoxres_MAP";
            this.textBoxres_MAP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxres_MAP.Size = new System.Drawing.Size(262, 383);
            this.textBoxres_MAP.TabIndex = 1;
            // 
            // FormMain_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonuse_MAP);
            this.Controls.Add(this.buttoninfo_MAP);
            this.Controls.Add(this.groupBoxInput_MAP);
            this.Controls.Add(this.groupBoxOutput_MAP);
            this.Controls.Add(this.groupBoxuslov_MAP);
            this.Name = "FormMain_MAP";
            this.Text = "Спринт 6 | Таск 1 | Вариант 14 | Моденова А. П.";
            this.groupBoxuslov_MAP.ResumeLayout(false);
            this.groupBoxuslov_MAP.PerformLayout();
            this.groupBoxOutput_MAP.ResumeLayout(false);
            this.groupBoxOutput_MAP.PerformLayout();
            this.groupBoxInput_MAP.ResumeLayout(false);
            this.groupBoxInput_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxformula_MAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxuslov_MAP;
        private System.Windows.Forms.PictureBox pictureBoxformula_MAP;
        private System.Windows.Forms.Label labeltextprod_MAP;
        private System.Windows.Forms.Label labeltext_MAP;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAP;
        private System.Windows.Forms.TextBox textBoxres_MAP;
        private System.Windows.Forms.Label labelres_MAP;
        private System.Windows.Forms.GroupBox groupBoxInput_MAP;
        private System.Windows.Forms.Label labelstart_MAP;
        private System.Windows.Forms.Label labelend_MAP;
        private System.Windows.Forms.TextBox textBox_Start_MAP;
        private System.Windows.Forms.TextBox textBoxEnd_MAP;
        private System.Windows.Forms.Button buttoninfo_MAP;
        private System.Windows.Forms.Button buttonuse_MAP;
    }
}

