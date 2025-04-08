namespace OnlineLearningSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.btnViewTests = new System.Windows.Forms.Button();
            this.btnTakeTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(30, 30);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(200, 30);
            this.btnCreateTest.TabIndex = 0;
            this.btnCreateTest.Text = "Создать тест";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(30, 70);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(200, 30);
            this.btnViewStatistics.TabIndex = 1;
            this.btnViewStatistics.Text = "Просмотр статистики";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // btnViewTests
            // 
            this.btnViewTests.Location = new System.Drawing.Point(30, 110);
            this.btnViewTests.Name = "btnViewTests";
            this.btnViewTests.Size = new System.Drawing.Size(200, 30);
            this.btnViewTests.TabIndex = 2;
            this.btnViewTests.Text = "Просмотр доступных тестов";
            this.btnViewTests.UseVisualStyleBackColor = true;
            this.btnViewTests.Click += new System.EventHandler(this.btnViewTests_Click);
            // 
            // btnTakeTest
            // 
            this.btnTakeTest.Location = new System.Drawing.Point(30, 150);
            this.btnTakeTest.Name = "btnTakeTest";
            this.btnTakeTest.Size = new System.Drawing.Size(200, 30);
            this.btnTakeTest.TabIndex = 3;
            this.btnTakeTest.Text = "Пройти тест";
            this.btnTakeTest.UseVisualStyleBackColor = true;
            this.btnTakeTest.Click += new System.EventHandler(this.btnTakeTest_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(285, 220);
            this.Controls.Add(this.btnTakeTest);
            this.Controls.Add(this.btnViewTests);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.btnCreateTest);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.Button btnViewTests;
        private System.Windows.Forms.Button btnTakeTest;
    }
}
