namespace BMICalculator
{
    partial class BMICalculator
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
            this.AppLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.Height = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.HeightUnits = new System.Windows.Forms.Label();
            this.WightUnits = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.BMIResults = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.AppLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppLayout
            // 
            this.AppLayout.ColumnCount = 3;
            this.AppLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AppLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AppLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AppLayout.Controls.Add(this.Metric, 1, 0);
            this.AppLayout.Controls.Add(this.Height, 0, 3);
            this.AppLayout.Controls.Add(this.Weight, 0, 4);
            this.AppLayout.Controls.Add(this.HeightUnits, 2, 3);
            this.AppLayout.Controls.Add(this.WightUnits, 2, 4);
            this.AppLayout.Controls.Add(this.Calculate, 0, 5);
            this.AppLayout.Controls.Add(this.Imperial, 0, 0);
            this.AppLayout.Controls.Add(this.BMIResults, 0, 1);
            this.AppLayout.Controls.Add(this.result, 0, 2);
            this.AppLayout.Controls.Add(this.HeightText, 1, 3);
            this.AppLayout.Controls.Add(this.WeightText, 1, 4);
            this.AppLayout.Location = new System.Drawing.Point(1, 1);
            this.AppLayout.Name = "AppLayout";
            this.AppLayout.RowCount = 6;
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AppLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AppLayout.Size = new System.Drawing.Size(300, 430);
            this.AppLayout.TabIndex = 0;
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metric.Location = new System.Drawing.Point(103, 3);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(82, 28);
            this.Metric.TabIndex = 1;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            this.Metric.CheckedChanged += new System.EventHandler(this.Metric_CheckedChanged);
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(3, 213);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(68, 50);
            this.Height.TabIndex = 2;
            this.Height.Text = "My Height";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(3, 284);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(74, 50);
            this.Weight.TabIndex = 3;
            this.Weight.Text = "My Weight";
            // 
            // HeightUnits
            // 
            this.HeightUnits.AutoSize = true;
            this.HeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnits.Location = new System.Drawing.Point(203, 213);
            this.HeightUnits.Name = "HeightUnits";
            this.HeightUnits.Size = new System.Drawing.Size(28, 25);
            this.HeightUnits.TabIndex = 4;
            this.HeightUnits.Text = "m";
            // 
            // WightUnits
            // 
            this.WightUnits.AutoSize = true;
            this.WightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WightUnits.Location = new System.Drawing.Point(203, 284);
            this.WightUnits.Name = "WightUnits";
            this.WightUnits.Size = new System.Drawing.Size(33, 25);
            this.WightUnits.TabIndex = 5;
            this.WightUnits.Text = "kg";
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.Snow;
            this.AppLayout.SetColumnSpan(this.Calculate, 3);
            this.Calculate.Location = new System.Drawing.Point(3, 358);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(294, 50);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate BMI";
            this.Calculate.UseVisualStyleBackColor = false;
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imperial.Location = new System.Drawing.Point(3, 3);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(94, 28);
            this.Imperial.TabIndex = 7;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // BMIResults
            // 
            this.BMIResults.BackColor = System.Drawing.Color.Snow;
            this.BMIResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppLayout.SetColumnSpan(this.BMIResults, 3);
            this.BMIResults.Enabled = false;
            this.BMIResults.Location = new System.Drawing.Point(3, 74);
            this.BMIResults.Multiline = true;
            this.BMIResults.Name = "BMIResults";
            this.BMIResults.ReadOnly = true;
            this.BMIResults.Size = new System.Drawing.Size(294, 65);
            this.BMIResults.TabIndex = 8;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Snow;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppLayout.SetColumnSpan(this.result, 3);
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(3, 145);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(294, 45);
            this.result.TabIndex = 9;
            // 
            // HeightText
            // 
            this.HeightText.BackColor = System.Drawing.Color.Snow;
            this.HeightText.Location = new System.Drawing.Point(103, 216);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(93, 45);
            this.HeightText.TabIndex = 10;
            // 
            // WeightText
            // 
            this.WeightText.BackColor = System.Drawing.Color.Snow;
            this.WeightText.Location = new System.Drawing.Point(103, 287);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(93, 45);
            this.WeightText.TabIndex = 11;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.AppLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AppLayout.ResumeLayout(false);
            this.AppLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AppLayout;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label HeightUnits;
        private System.Windows.Forms.Label WightUnits;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.TextBox BMIResults;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.TextBox WeightText;
    }
}

