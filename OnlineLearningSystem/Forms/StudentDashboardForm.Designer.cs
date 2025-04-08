using System.Windows.Forms;
using System;

namespace OnlineLearningSystem.Forms
{
    partial class StudentDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstAvailableTests;
        private System.Windows.Forms.ListBox lstAvailableMaterials;
        private System.Windows.Forms.Button btnTakeTest;
        private System.Windows.Forms.Button btnSelectMaterial;
        private System.Windows.Forms.Label lblAvailableTests;
        private System.Windows.Forms.Label lblAvailableMaterials;
        private System.Windows.Forms.Label lblUserName; // Метка для имени пользователя
        private System.Windows.Forms.Label lblKnowledgeLevel; // Метка для уровня знаний

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
            this.lstAvailableTests = new System.Windows.Forms.ListBox();
            this.lstAvailableMaterials = new System.Windows.Forms.ListBox();
            this.btnTakeTest = new System.Windows.Forms.Button();
            this.btnSelectMaterial = new System.Windows.Forms.Button();
            this.lblAvailableTests = new System.Windows.Forms.Label();
            this.lblAvailableMaterials = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblKnowledgeLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAvailableTests
            // 
            this.lstAvailableTests.FormattingEnabled = true;
            this.lstAvailableTests.ItemHeight = 20;
            this.lstAvailableTests.Location = new System.Drawing.Point(12, 83);
            this.lstAvailableTests.Name = "lstAvailableTests";
            this.lstAvailableTests.Size = new System.Drawing.Size(360, 164);
            this.lstAvailableTests.TabIndex = 0;
            // 
            // lstAvailableMaterials
            // 
            this.lstAvailableMaterials.FormattingEnabled = true;
            this.lstAvailableMaterials.ItemHeight = 20;
            this.lstAvailableMaterials.Location = new System.Drawing.Point(12, 290);
            this.lstAvailableMaterials.Name = "lstAvailableMaterials";
            this.lstAvailableMaterials.Size = new System.Drawing.Size(360, 164);
            this.lstAvailableMaterials.TabIndex = 1;
            this.lstAvailableMaterials.SelectedIndexChanged += new System.EventHandler(this.LstAvailableMaterials_SelectedIndexChanged);
            // 
            // btnTakeTest
            // 
            this.btnTakeTest.Location = new System.Drawing.Point(395, 83);
            this.btnTakeTest.Name = "btnTakeTest";
            this.btnTakeTest.Size = new System.Drawing.Size(120, 34);
            this.btnTakeTest.TabIndex = 2;
            this.btnTakeTest.Text = "Пройти тест";
            this.btnTakeTest.UseVisualStyleBackColor = true;
            this.btnTakeTest.Click += new System.EventHandler(this.BtnTakeTest_Click);
            // 
            // btnSelectMaterial
            // 
            this.btnSelectMaterial.Location = new System.Drawing.Point(395, 290);
            this.btnSelectMaterial.Name = "btnSelectMaterial";
            this.btnSelectMaterial.Size = new System.Drawing.Size(120, 34);
            this.btnSelectMaterial.TabIndex = 3;
            this.btnSelectMaterial.Text = "Выбрать материал";
            this.btnSelectMaterial.UseVisualStyleBackColor = true;
            // 
            // lblAvailableTests
            // 
            this.lblAvailableTests.AutoSize = true;
            this.lblAvailableTests.Location = new System.Drawing.Point(7, 34);
            this.lblAvailableTests.Name = "lblAvailableTests";
            this.lblAvailableTests.Size = new System.Drawing.Size(142, 20);
            this.lblAvailableTests.TabIndex = 4;
            this.lblAvailableTests.Text = "Доступные тесты";
            // 
            // lblAvailableMaterials
            // 
            this.lblAvailableMaterials.AutoSize = true;
            this.lblAvailableMaterials.Location = new System.Drawing.Point(12, 250);
            this.lblAvailableMaterials.Name = "lblAvailableMaterials";
            this.lblAvailableMaterials.Size = new System.Drawing.Size(182, 20);
            this.lblAvailableMaterials.TabIndex = 5;
            this.lblAvailableMaterials.Text = "Доступные материалы";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(8, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(161, 20);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Имя пользователя: ";
            // 
            // lblKnowledgeLevel
            // 
            this.lblKnowledgeLevel.AutoSize = true;
            this.lblKnowledgeLevel.Location = new System.Drawing.Point(8, 60);
            this.lblKnowledgeLevel.Name = "lblKnowledgeLevel";
            this.lblKnowledgeLevel.Size = new System.Drawing.Size(138, 20);
            this.lblKnowledgeLevel.TabIndex = 7;
            this.lblKnowledgeLevel.Text = "Уровень знаний: ";
            // 
            // StudentDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(588, 534);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblKnowledgeLevel);
            this.Controls.Add(this.lblAvailableTests);
            this.Controls.Add(this.lblAvailableMaterials);
            this.Controls.Add(this.btnSelectMaterial);
            this.Controls.Add(this.btnTakeTest);
            this.Controls.Add(this.lstAvailableMaterials);
            this.Controls.Add(this.lstAvailableTests);
            this.Name = "StudentDashboardForm";
            this.Text = "Панель управления студентом";
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
