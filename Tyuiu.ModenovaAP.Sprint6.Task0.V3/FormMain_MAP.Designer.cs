
namespace Tyuiu.ModenovaAP.Sprint6.Task0.V3
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
            this.groupBoxУсловие = new System.Windows.Forms.GroupBox();
            this.pictureBoxформула = new System.Windows.Forms.PictureBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.groupBoxВыводданных = new System.Windows.Forms.GroupBox();
            this.textBoxРезультат = new System.Windows.Forms.TextBox();
            this.labelres = new System.Windows.Forms.Label();
            this.labelperem = new System.Windows.Forms.Label();
            this.groupBoxВводданных = new System.Windows.Forms.GroupBox();
            this.textBoxПеременнаяX = new System.Windows.Forms.TextBox();
            this.buttonВопросы = new System.Windows.Forms.Button();
            this.buttonВыполнить = new System.Windows.Forms.Button();
            this.groupBoxУсловие.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxформула)).BeginInit();
            this.groupBoxВыводданных.SuspendLayout();
            this.groupBoxВводданных.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxУсловие
            // 
            this.groupBoxУсловие.Controls.Add(this.pictureBoxформула);
            this.groupBoxУсловие.Controls.Add(this.labelinfo);
            this.groupBoxУсловие.Location = new System.Drawing.Point(12, 20);
            this.groupBoxУсловие.Name = "groupBoxУсловие";
            this.groupBoxУсловие.Size = new System.Drawing.Size(653, 229);
            this.groupBoxУсловие.TabIndex = 0;
            this.groupBoxУсловие.TabStop = false;
            this.groupBoxУсловие.Text = "Условие:";
            // 
            // pictureBoxформула
            // 
            this.pictureBoxформула.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxформула.ErrorImage = null;
            this.pictureBoxформула.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxформула.Image")));
            this.pictureBoxформула.Location = new System.Drawing.Point(508, 27);
            this.pictureBoxформула.Name = "pictureBoxформула";
            this.pictureBoxформула.Size = new System.Drawing.Size(111, 63);
            this.pictureBoxформула.TabIndex = 3;
            this.pictureBoxформула.TabStop = false;
            // 
            // labelinfo
            // 
            this.labelinfo.Location = new System.Drawing.Point(18, 27);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(356, 100);
            this.labelinfo.TabIndex = 0;
            this.labelinfo.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой. Графический интерфейс оформить по шаблону и" +
    "з лекции.";
            // 
            // groupBoxВыводданных
            // 
            this.groupBoxВыводданных.Controls.Add(this.textBoxРезультат);
            this.groupBoxВыводданных.Controls.Add(this.labelres);
            this.groupBoxВыводданных.Location = new System.Drawing.Point(444, 247);
            this.groupBoxВыводданных.Name = "groupBoxВыводданных";
            this.groupBoxВыводданных.Size = new System.Drawing.Size(221, 136);
            this.groupBoxВыводданных.TabIndex = 1;
            this.groupBoxВыводданных.TabStop = false;
            this.groupBoxВыводданных.Text = "Вывод данных:";
            // 
            // textBoxРезультат
            // 
            this.textBoxРезультат.Location = new System.Drawing.Point(68, 61);
            this.textBoxРезультат.Name = "textBoxРезультат";
            this.textBoxРезультат.Size = new System.Drawing.Size(100, 20);
            this.textBoxРезультат.TabIndex = 2;
            // 
            // labelres
            // 
            this.labelres.AutoSize = true;
            this.labelres.Location = new System.Drawing.Point(84, 45);
            this.labelres.Name = "labelres";
            this.labelres.Size = new System.Drawing.Size(62, 13);
            this.labelres.TabIndex = 1;
            this.labelres.Text = "Результат:";
            // 
            // labelperem
            // 
            this.labelperem.AutoSize = true;
            this.labelperem.Location = new System.Drawing.Point(163, 45);
            this.labelperem.Name = "labelperem";
            this.labelperem.Size = new System.Drawing.Size(84, 13);
            this.labelperem.TabIndex = 0;
            this.labelperem.Text = "Переменная X:";
            // 
            // groupBoxВводданных
            // 
            this.groupBoxВводданных.Controls.Add(this.textBoxПеременнаяX);
            this.groupBoxВводданных.Controls.Add(this.labelperem);
            this.groupBoxВводданных.Location = new System.Drawing.Point(12, 247);
            this.groupBoxВводданных.Name = "groupBoxВводданных";
            this.groupBoxВводданных.Size = new System.Drawing.Size(426, 136);
            this.groupBoxВводданных.TabIndex = 2;
            this.groupBoxВводданных.TabStop = false;
            this.groupBoxВводданных.Text = "Ввод данных:";
            // 
            // textBoxПеременнаяX
            // 
            this.textBoxПеременнаяX.Location = new System.Drawing.Point(157, 61);
            this.textBoxПеременнаяX.Name = "textBoxПеременнаяX";
            this.textBoxПеременнаяX.Size = new System.Drawing.Size(100, 20);
            this.textBoxПеременнаяX.TabIndex = 1;
            // 
            // buttonВопросы
            // 
            this.buttonВопросы.Location = new System.Drawing.Point(520, 389);
            this.buttonВопросы.Name = "buttonВопросы";
            this.buttonВопросы.Size = new System.Drawing.Size(30, 23);
            this.buttonВопросы.TabIndex = 1;
            this.buttonВопросы.Text = "?";
            this.buttonВопросы.UseVisualStyleBackColor = true;
            this.buttonВопросы.Click += new System.EventHandler(this.buttonВопросы_Click);
            // 
            // buttonВыполнить
            // 
            this.buttonВыполнить.Location = new System.Drawing.Point(556, 389);
            this.buttonВыполнить.Name = "buttonВыполнить";
            this.buttonВыполнить.Size = new System.Drawing.Size(75, 23);
            this.buttonВыполнить.TabIndex = 2;
            this.buttonВыполнить.Text = "Выполнить";
            this.buttonВыполнить.UseVisualStyleBackColor = true;
            this.buttonВыполнить.Click += new System.EventHandler(this.buttonВыполнить_Click);
            // 
            // FormMain_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 418);
            this.Controls.Add(this.buttonВопросы);
            this.Controls.Add(this.buttonВыполнить);
            this.Controls.Add(this.groupBoxВводданных);
            this.Controls.Add(this.groupBoxВыводданных);
            this.Controls.Add(this.groupBoxУсловие);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(693, 457);
            this.MinimumSize = new System.Drawing.Size(693, 457);
            this.Name = "FormMain_MAP";
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Моденова А. П.";
            this.groupBoxУсловие.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxформула)).EndInit();
            this.groupBoxВыводданных.ResumeLayout(false);
            this.groupBoxВыводданных.PerformLayout();
            this.groupBoxВводданных.ResumeLayout(false);
            this.groupBoxВводданных.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxУсловие;
        private System.Windows.Forms.GroupBox groupBoxВыводданных;
        private System.Windows.Forms.Label labelperem;
        private System.Windows.Forms.GroupBox groupBoxВводданных;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.PictureBox pictureBoxформула;
        private System.Windows.Forms.Button buttonВопросы;
        private System.Windows.Forms.Button buttonВыполнить;
        private System.Windows.Forms.Label labelres;
        private System.Windows.Forms.TextBox textBoxРезультат;
        private System.Windows.Forms.TextBox textBoxПеременнаяX;
    }
}

