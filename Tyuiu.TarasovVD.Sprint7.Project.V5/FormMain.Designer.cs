
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
            this.components = new System.ComponentModel.Container();
            this.panelTop_TVD = new System.Windows.Forms.Panel();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.buttonInstrument_TVD = new System.Windows.Forms.Button();
            this.panelLeft_TVD = new System.Windows.Forms.Panel();
            this.toolTipInfo_TVD = new System.Windows.Forms.ToolTip(this.components);
            this.labelName_TVD = new System.Windows.Forms.Label();
            this.panelTop_TVD.SuspendLayout();
            this.panelLeft_TVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_TVD
            // 
            this.panelTop_TVD.Controls.Add(this.buttonHelp_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonInstrument_TVD);
            this.panelTop_TVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_TVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_TVD.Name = "panelTop_TVD";
            this.panelTop_TVD.Size = new System.Drawing.Size(427, 69);
            this.panelTop_TVD.TabIndex = 0;
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.help;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(362, 3);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(62, 64);
            this.buttonHelp_TVD.TabIndex = 2;
            this.toolTipInfo_TVD.SetToolTip(this.buttonHelp_TVD, "О программе");
            this.buttonHelp_TVD.UseVisualStyleBackColor = true;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.button3_Click);
            this.buttonHelp_TVD.MouseEnter += new System.EventHandler(this.buttonHelp_TVD_MouseEnter);
            // 
            // buttonInstrument_TVD
            // 
            this.buttonInstrument_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.wrench_orange;
            this.buttonInstrument_TVD.Location = new System.Drawing.Point(3, 3);
            this.buttonInstrument_TVD.Name = "buttonInstrument_TVD";
            this.buttonInstrument_TVD.Size = new System.Drawing.Size(65, 64);
            this.buttonInstrument_TVD.TabIndex = 1;
            this.toolTipInfo_TVD.SetToolTip(this.buttonInstrument_TVD, "Перейти на инструментальную панель.");
            this.buttonInstrument_TVD.UseVisualStyleBackColor = true;
            this.buttonInstrument_TVD.Click += new System.EventHandler(this.button2_Click);
            this.buttonInstrument_TVD.MouseEnter += new System.EventHandler(this.buttonInstrument_TVD_MouseEnter);
            // 
            // panelLeft_TVD
            // 
            this.panelLeft_TVD.Controls.Add(this.labelName_TVD);
            this.panelLeft_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft_TVD.Location = new System.Drawing.Point(0, 69);
            this.panelLeft_TVD.Name = "panelLeft_TVD";
            this.panelLeft_TVD.Size = new System.Drawing.Size(427, 60);
            this.panelLeft_TVD.TabIndex = 1;
            // 
            // toolTipInfo_TVD
            // 
            this.toolTipInfo_TVD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // labelName_TVD
            // 
            this.labelName_TVD.AutoSize = true;
            this.labelName_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName_TVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_TVD.Location = new System.Drawing.Point(0, 0);
            this.labelName_TVD.Name = "labelName_TVD";
            this.labelName_TVD.Size = new System.Drawing.Size(411, 55);
            this.labelName_TVD.TabIndex = 0;
            this.labelName_TVD.Text = "ОПТОВАЯ БАЗА";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 129);
            this.Controls.Add(this.panelLeft_TVD);
            this.Controls.Add(this.panelTop_TVD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Главное меню";
            this.panelTop_TVD.ResumeLayout(false);
            this.panelLeft_TVD.ResumeLayout(false);
            this.panelLeft_TVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.Button buttonInstrument_TVD;
        private System.Windows.Forms.Panel panelLeft_TVD;
        private System.Windows.Forms.ToolTip toolTipInfo_TVD;
        private System.Windows.Forms.Label labelName_TVD;
    }
}

