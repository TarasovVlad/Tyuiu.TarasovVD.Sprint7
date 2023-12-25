
namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    partial class FormAboutInstrument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutInstrument));
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.buttonOk_TVD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(12, 9);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(511, 351);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = resources.GetString("labelInfo_TVD.Text");
            // 
            // buttonOk_TVD
            // 
            this.buttonOk_TVD.Location = new System.Drawing.Point(455, 363);
            this.buttonOk_TVD.Name = "buttonOk_TVD";
            this.buttonOk_TVD.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_TVD.TabIndex = 1;
            this.buttonOk_TVD.Text = "Ок";
            this.buttonOk_TVD.UseVisualStyleBackColor = true;
            this.buttonOk_TVD.Click += new System.EventHandler(this.buttonOk_TVD_Click);
            // 
            // FormAboutInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 396);
            this.Controls.Add(this.buttonOk_TVD);
            this.Controls.Add(this.labelInfo_TVD);
            this.Name = "FormAboutInstrument";
            this.Text = "Справка инструментальной панели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.Button buttonOk_TVD;
    }
}