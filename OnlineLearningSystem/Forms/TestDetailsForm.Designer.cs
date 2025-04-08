namespace OnlineLearningSystem.Forms
{
    partial class TestDetailsForm
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
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.txtQuestions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTestTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(131, 20);
            this.lblTestTitle.TabIndex = 0;
            this.lblTestTitle.Text = "Название теста";
            // 
            // txtQuestions
            // 
            this.txtQuestions.Location = new System.Drawing.Point(18, 38);
            this.txtQuestions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuestions.Multiline = true;
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.ReadOnly = true;
            this.txtQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestions.Size = new System.Drawing.Size(388, 341);
            this.txtQuestions.TabIndex = 1;
            this.txtQuestions.TextChanged += new System.EventHandler(this.txtQuestions_TextChanged);
            // 
            // TestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.lblTestTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestDetailsForm";
            this.Text = "Детали теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.TextBox txtQuestions;
    }
}
