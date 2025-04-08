namespace OnlineLearningSystem.Forms
{
    partial class TestForm
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
            this.lstTests = new System.Windows.Forms.ListBox();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTests
            // 
            this.lstTests.FormattingEnabled = true;
            this.lstTests.Location = new System.Drawing.Point(12, 12);
            this.lstTests.Name = "lstTests";
            this.lstTests.Size = new System.Drawing.Size(260, 199);
            this.lstTests.TabIndex = 0;
            this.lstTests.DoubleClick += new System.EventHandler(this.IstTests_DoubleClick); // Подписка на событие двойного щелчка
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(12, 217);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(260, 23);
            this.btnCreateTest.TabIndex = 1;
            this.btnCreateTest.Text = "Создать тест";
            this.btnCreateTest.UseVisualStyleBackColor = true;

            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click); // Подписка на событие нажатия кнопки
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.lstTests);
            this.Name = "TestForm";
            this.Text = "Управление тестами";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstTests; // Элемент списка для тестов
        private System.Windows.Forms.Button btnCreateTest; // Кнопка для создания теста
    }
}
