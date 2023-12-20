
namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    partial class FormInstrument
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSaveFile_TVD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewInPutData_TVD = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_TVD = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_TVD = new System.Windows.Forms.SaveFileDialog();
            this.buttonReturn_TVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_TVD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReturn_TVD);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonSaveFile_TVD);
            this.panel1.Controls.Add(this.buttonOpenFile_TVD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 140);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(362, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(281, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile_TVD
            // 
            this.buttonSaveFile_TVD.Enabled = false;
            this.buttonSaveFile_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.page_save;
            this.buttonSaveFile_TVD.Location = new System.Drawing.Point(165, 12);
            this.buttonSaveFile_TVD.Name = "buttonSaveFile_TVD";
            this.buttonSaveFile_TVD.Size = new System.Drawing.Size(66, 51);
            this.buttonSaveFile_TVD.TabIndex = 1;
            this.buttonSaveFile_TVD.UseVisualStyleBackColor = true;
            this.buttonSaveFile_TVD.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewInPutData_TVD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 310);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewInPutData_TVD
            // 
            this.dataGridViewInPutData_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPutData_TVD.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInPutData_TVD.Name = "dataGridViewInPutData_TVD";
            this.dataGridViewInPutData_TVD.RowHeadersVisible = false;
            this.dataGridViewInPutData_TVD.Size = new System.Drawing.Size(800, 310);
            this.dataGridViewInPutData_TVD.TabIndex = 0;
            // 
            // openFileDialogTask_TVD
            // 
            this.openFileDialogTask_TVD.FileName = "openFileDialog1";
            // 
            // buttonReturn_TVD
            // 
            this.buttonReturn_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.arrow_left;
            this.buttonReturn_TVD.Location = new System.Drawing.Point(12, 12);
            this.buttonReturn_TVD.Name = "buttonReturn_TVD";
            this.buttonReturn_TVD.Size = new System.Drawing.Size(75, 51);
            this.buttonReturn_TVD.TabIndex = 6;
            this.buttonReturn_TVD.UseVisualStyleBackColor = true;
            this.buttonReturn_TVD.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonOpenFile_TVD
            // 
            this.buttonOpenFile_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.folder_page;
            this.buttonOpenFile_TVD.Location = new System.Drawing.Point(95, 12);
            this.buttonOpenFile_TVD.Name = "buttonOpenFile_TVD";
            this.buttonOpenFile_TVD.Size = new System.Drawing.Size(64, 51);
            this.buttonOpenFile_TVD.TabIndex = 0;
            this.buttonOpenFile_TVD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_TVD.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormInstrument";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_TVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReturn_TVD;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSaveFile_TVD;
        private System.Windows.Forms.Button buttonOpenFile_TVD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_TVD;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_TVD;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_TVD;
    }
}