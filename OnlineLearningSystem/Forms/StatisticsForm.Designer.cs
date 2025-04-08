namespace OnlineLearningSystem.Forms
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTotalTests;
        private System.Windows.Forms.Label lblSuccessfulTests;
        private System.Windows.Forms.Label lblFailedTests;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTotalTests = new System.Windows.Forms.Label();
            this.lblSuccessfulTests = new System.Windows.Forms.Label();
            this.lblFailedTests = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalTests
            // 
            this.lblTotalTests.AutoSize = true;
            this.lblTotalTests.Location = new System.Drawing.Point(20, 20);
            this.lblTotalTests.Name = "lblTotalTests";
            this.lblTotalTests.Size = new System.Drawing.Size(127, 20);
            this.lblTotalTests.TabIndex = 0;
            this.lblTotalTests.Text = "Всего тестов: 0";
            // 
            // lblSuccessfulTests
            // 
            this.lblSuccessfulTests.AutoSize = true;
            this.lblSuccessfulTests.Location = new System.Drawing.Point(20, 50);
            this.lblSuccessfulTests.Name = "lblSuccessfulTests";
            this.lblSuccessfulTests.Size = new System.Drawing.Size(228, 20);
            this.lblSuccessfulTests.TabIndex = 1;
            this.lblSuccessfulTests.Text = "Успешно пройдено тестов: 0";
            // 
            // lblFailedTests
            // 
            this.lblFailedTests.AutoSize = true;
            this.lblFailedTests.Location = new System.Drawing.Point(20, 80);
            this.lblFailedTests.Name = "lblFailedTests";
            this.lblFailedTests.Size = new System.Drawing.Size(246, 20);
            this.lblFailedTests.TabIndex = 2;
            this.lblFailedTests.Text = "Неуспешно пройдено тестов: 0";
            // 
            // StatisticsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.lblFailedTests);
            this.Controls.Add(this.lblSuccessfulTests);
            this.Controls.Add(this.lblTotalTests);
            this.Name = "StatisticsForm";
            this.Text = "Статистика тестов";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
