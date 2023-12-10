
namespace Tyuiu.ModenovaAP.Sprint6.Task7.V12
{
    partial class FormAbout_MAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_MAP));
            this.pictureBoxAva_MAP = new System.Windows.Forms.PictureBox();
            this.labelInfo_MAP = new System.Windows.Forms.Label();
            this.buttonOk_MAP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAva_MAP
            // 
            this.pictureBoxAva_MAP.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAva_MAP.Name = "pictureBoxAva_MAP";
            this.pictureBoxAva_MAP.Size = new System.Drawing.Size(112, 143);
            this.pictureBoxAva_MAP.TabIndex = 0;
            this.pictureBoxAva_MAP.TabStop = false;
            // 
            // labelInfo_MAP
            // 
            this.labelInfo_MAP.AutoSize = true;
            this.labelInfo_MAP.Location = new System.Drawing.Point(132, 13);
            this.labelInfo_MAP.Name = "labelInfo_MAP";
            this.labelInfo_MAP.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_MAP.TabIndex = 1;
            this.labelInfo_MAP.Text = resources.GetString("labelInfo_MAP.Text");
            // 
            // buttonOk_MAP
            // 
            this.buttonOk_MAP.Location = new System.Drawing.Point(334, 136);
            this.buttonOk_MAP.Name = "buttonOk_MAP";
            this.buttonOk_MAP.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_MAP.TabIndex = 2;
            this.buttonOk_MAP.Text = "Ок";
            this.buttonOk_MAP.UseVisualStyleBackColor = true;
            this.buttonOk_MAP.Click += new System.EventHandler(this.buttonOk_MAP_Click);
            // 
            // FormAbout_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 171);
            this.Controls.Add(this.buttonOk_MAP);
            this.Controls.Add(this.labelInfo_MAP);
            this.Controls.Add(this.pictureBoxAva_MAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAbout_MAP";
            this.Text = "О приложении";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_MAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAva_MAP;
        private System.Windows.Forms.Label labelInfo_MAP;
        private System.Windows.Forms.Button buttonOk_MAP;
    }
}