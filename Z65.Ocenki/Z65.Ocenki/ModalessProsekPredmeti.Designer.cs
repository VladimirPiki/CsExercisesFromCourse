﻿namespace Z65.Ocenki
{
    partial class ModalessProsekPredmeti
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
            this.lvProsekPredmeti = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvProsekPredmeti
            // 
            this.lvProsekPredmeti.HideSelection = false;
            this.lvProsekPredmeti.Location = new System.Drawing.Point(46, 25);
            this.lvProsekPredmeti.Name = "lvProsekPredmeti";
            this.lvProsekPredmeti.Size = new System.Drawing.Size(1390, 309);
            this.lvProsekPredmeti.TabIndex = 0;
            this.lvProsekPredmeti.UseCompatibleStateImageBehavior = false;
            this.lvProsekPredmeti.SelectedIndexChanged += new System.EventHandler(this.lvProsekPredmeti_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(46, 340);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ucenici";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1390, 342);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // ModalessProsekPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 704);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lvProsekPredmeti);
            this.Name = "ModalessProsekPredmeti";
            this.Text = "ModalessProsekPredmeti";
            this.Load += new System.EventHandler(this.ModalessProsekPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProsekPredmeti;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}