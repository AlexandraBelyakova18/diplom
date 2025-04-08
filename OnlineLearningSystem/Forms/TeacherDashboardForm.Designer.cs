namespace OnlineLearningSystem.Forms
{
    partial class TeacherDashboardForm
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
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTests
            // 
            this.listBoxTests.FormattingEnabled = true;

            this.listBoxTests.Location = new System.Drawing.Point(12, 12);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(300, 160);
            this.listBoxTests.TabIndex = 0;
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(12, 180);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(300, 23);
            this.btnCreateTest.TabIndex = 1;
            this.btnCreateTest.Text = "Создать тест";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 210);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(300, 23);
            this.btnAddMaterial.TabIndex = 2;
            this.btnAddMaterial.Text = "Добавить материал";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(12, 240);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(300, 23);
            this.btnViewStatistics.TabIndex = 3;
            this.btnViewStatistics.Text = "Посмотреть статистику";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // TeacherDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(324, 281);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.listBoxTests);
            this.Name = "TeacherDashboardForm";
            this.Load += new System.EventHandler(this.TeacherDashboardForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxTests; // Поле для списка тестов
        private System.Windows.Forms.Button btnCreateTest; // Кнопка создания теста
        private System.Windows.Forms.Button btnAddMaterial; // Кнопка добавления материала
        private System.Windows.Forms.Button btnViewStatistics; // Кнопка для просмотра статистики
    }
}
