
namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.buttonOk_TVD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(124, 9);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_TVD.TabIndex = 3;
            this.labelInfo_TVD.Text = resources.GetString("labelInfo_TVD.Text");
            // 
            // buttonOk_TVD
            // 
            this.buttonOk_TVD.Location = new System.Drawing.Point(333, 134);
            this.buttonOk_TVD.Name = "buttonOk_TVD";
            this.buttonOk_TVD.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_TVD.TabIndex = 4;
            this.buttonOk_TVD.Text = "Ок";
            this.buttonOk_TVD.UseVisualStyleBackColor = true;
            this.buttonOk_TVD.Click += new System.EventHandler(this.buttonOk_TVD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 162);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOk_TVD);
            this.Controls.Add(this.labelInfo_TVD);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.Button buttonOk_TVD;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}