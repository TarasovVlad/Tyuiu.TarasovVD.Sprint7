
namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    partial class FormStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInfo_TVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // chartInfo_TVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo_TVD.ChartAreas.Add(chartArea1);
            this.chartInfo_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartInfo_TVD.Legends.Add(legend1);
            this.chartInfo_TVD.Location = new System.Drawing.Point(0, 0);
            this.chartInfo_TVD.Name = "chartInfo_TVD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo_TVD.Series.Add(series1);
            this.chartInfo_TVD.Size = new System.Drawing.Size(800, 450);
            this.chartInfo_TVD.TabIndex = 0;
            this.chartInfo_TVD.Text = "chart1";
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartInfo_TVD);
            this.Name = "FormStats";
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_TVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_TVD;
    }
}