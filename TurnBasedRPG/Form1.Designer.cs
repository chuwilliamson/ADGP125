﻿namespace TurnBasedRPG
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.attack_button = new System.Windows.Forms.Button();
            this.damage_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reset_button = new System.Windows.Forms.Button();
            this.steven = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.damage_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steven)).BeginInit();
            this.SuspendLayout();
            // 
            // attack_button
            // 
            this.attack_button.Location = new System.Drawing.Point(12, 427);
            this.attack_button.Name = "attack_button";
            this.attack_button.Size = new System.Drawing.Size(75, 23);
            this.attack_button.TabIndex = 0;
            this.attack_button.Text = "Attack";
            this.attack_button.UseVisualStyleBackColor = true;
            this.attack_button.Click += new System.EventHandler(this.attack_button_Click);
            // 
            // damage_chart
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.damage_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.damage_chart.Legends.Add(legend1);
            this.damage_chart.Location = new System.Drawing.Point(12, 21);
            this.damage_chart.Name = "damage_chart";
            this.damage_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "IsXAxisQuantitative=False";
            series1.Legend = "Legend1";
            series1.Name = "Damage Roll";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Damage Roll Sorted";
            this.damage_chart.Series.Add(series1);
            this.damage_chart.Series.Add(series2);
            this.damage_chart.Size = new System.Drawing.Size(506, 400);
            this.damage_chart.TabIndex = 1;
            this.damage_chart.Text = "chart1";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(124, 427);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 2;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // steven
            // 
            chartArea2.Name = "ChartArea1";
            this.steven.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.steven.Legends.Add(legend2);
            this.steven.Location = new System.Drawing.Point(536, 21);
            this.steven.Name = "steven";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.steven.Series.Add(series3);
            this.steven.Size = new System.Drawing.Size(300, 300);
            this.steven.TabIndex = 3;
            this.steven.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 663);
            this.Controls.Add(this.steven);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.damage_chart);
            this.Controls.Add(this.attack_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.damage_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steven)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attack_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart damage_chart;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart steven;
    }
}
