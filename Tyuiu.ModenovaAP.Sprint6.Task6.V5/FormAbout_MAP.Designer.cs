
namespace Tyuiu.ModenovaAP.Sprint6.Task6.V5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfo_MAP = new System.Windows.Forms.Label();
            this.buttonOk_MAP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelInfo_MAP
            // 
            this.labelInfo_MAP.AutoSize = true;
            this.labelInfo_MAP.Location = new System.Drawing.Point(119, 12);
            this.labelInfo_MAP.Name = "labelInfo_MAP";
            this.labelInfo_MAP.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_MAP.TabIndex = 1;
            this.labelInfo_MAP.Text = resources.GetString("labelInfo_MAP.Text");
            // 
            // buttonOk_MAP
            // 
            this.buttonOk_MAP.Location = new System.Drawing.Point(384, 137);
            this.buttonOk_MAP.Name = "buttonOk_MAP";
            this.buttonOk_MAP.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_MAP.TabIndex = 2;
            this.buttonOk_MAP.Text = "Ок";
            this.buttonOk_MAP.UseVisualStyleBackColor = true;
            // 
            // FormAbout_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 167);
            this.Controls.Add(this.buttonOk_MAP);
            this.Controls.Add(this.labelInfo_MAP);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAbout_MAP";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfo_MAP;
        private System.Windows.Forms.Button buttonOk_MAP;
    }
}