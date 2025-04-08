namespace OnlineLearningSystem.Forms
{
    partial class AdminDashboardForm
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
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.btnManageTests = new System.Windows.Forms.Button();
            this.btnManageMaterials = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCourses
            // 
            this.btnManageCourses.BackColor = System.Drawing.Color.AliceBlue;
            this.btnManageCourses.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManageCourses.Location = new System.Drawing.Point(75, 46);
            this.btnManageCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(300, 35);
            this.btnManageCourses.TabIndex = 0;
            this.btnManageCourses.Text = "Управление курсами";
            this.btnManageCourses.UseVisualStyleBackColor = false;
            this.btnManageCourses.Click += new System.EventHandler(this.btnManageCourses_Click);
            // 
            // btnManageTests
            // 
            this.btnManageTests.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManageTests.Location = new System.Drawing.Point(75, 108);
            this.btnManageTests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageTests.Name = "btnManageTests";
            this.btnManageTests.Size = new System.Drawing.Size(300, 35);
            this.btnManageTests.TabIndex = 1;
            this.btnManageTests.Text = "Управление тестами";
            this.btnManageTests.UseVisualStyleBackColor = true;
            this.btnManageTests.Click += new System.EventHandler(this.btnManageTests_Click);
            // 
            // btnManageMaterials
            // 
            this.btnManageMaterials.BackColor = System.Drawing.Color.AliceBlue;
            this.btnManageMaterials.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManageMaterials.Location = new System.Drawing.Point(75, 169);
            this.btnManageMaterials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageMaterials.Name = "btnManageMaterials";
            this.btnManageMaterials.Size = new System.Drawing.Size(300, 35);
            this.btnManageMaterials.TabIndex = 2;
            this.btnManageMaterials.Text = "Управление материалами";
            this.btnManageMaterials.UseVisualStyleBackColor = false;
            this.btnManageMaterials.Click += new System.EventHandler(this.btnManageMaterials_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnViewStatistics.Location = new System.Drawing.Point(75, 231);
            this.btnViewStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(300, 35);
            this.btnViewStatistics.TabIndex = 3;
            this.btnViewStatistics.Text = "Просмотр статистики";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(450, 308);
            this.Controls.Add(this.btnViewStatistics);
            this.Controls.Add(this.btnManageMaterials);
            this.Controls.Add(this.btnManageTests);
            this.Controls.Add(this.btnManageCourses);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDashboardForm";
            this.Text = "Панель администратора";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnManageCourses;
        private System.Windows.Forms.Button btnManageTests;
        private System.Windows.Forms.Button btnManageMaterials;
        private System.Windows.Forms.Button btnViewStatistics;
    }
}
