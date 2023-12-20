
namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    partial class FormMain
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
            this.panelTop_TVD = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLeft_TVD = new System.Windows.Forms.Panel();
            this.splitterFill_TVD = new System.Windows.Forms.Splitter();
            this.panelFill_TVD = new System.Windows.Forms.Panel();
            this.panelTop_TVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_TVD
            // 
            this.panelTop_TVD.Controls.Add(this.button3);
            this.panelTop_TVD.Controls.Add(this.button2);
            this.panelTop_TVD.Controls.Add(this.button1);
            this.panelTop_TVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_TVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_TVD.Name = "panelTop_TVD";
            this.panelTop_TVD.Size = new System.Drawing.Size(800, 101);
            this.panelTop_TVD.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelLeft_TVD
            // 
            this.panelLeft_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_TVD.Location = new System.Drawing.Point(0, 101);
            this.panelLeft_TVD.Name = "panelLeft_TVD";
            this.panelLeft_TVD.Size = new System.Drawing.Size(280, 349);
            this.panelLeft_TVD.TabIndex = 1;
            // 
            // splitterFill_TVD
            // 
            this.splitterFill_TVD.Location = new System.Drawing.Point(280, 101);
            this.splitterFill_TVD.Name = "splitterFill_TVD";
            this.splitterFill_TVD.Size = new System.Drawing.Size(3, 349);
            this.splitterFill_TVD.TabIndex = 2;
            this.splitterFill_TVD.TabStop = false;
            // 
            // panelFill_TVD
            // 
            this.panelFill_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_TVD.Location = new System.Drawing.Point(283, 101);
            this.panelFill_TVD.Name = "panelFill_TVD";
            this.panelFill_TVD.Size = new System.Drawing.Size(517, 349);
            this.panelFill_TVD.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFill_TVD);
            this.Controls.Add(this.splitterFill_TVD);
            this.Controls.Add(this.panelLeft_TVD);
            this.Controls.Add(this.panelTop_TVD);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTop_TVD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_TVD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLeft_TVD;
        private System.Windows.Forms.Splitter splitterFill_TVD;
        private System.Windows.Forms.Panel panelFill_TVD;
    }
}

