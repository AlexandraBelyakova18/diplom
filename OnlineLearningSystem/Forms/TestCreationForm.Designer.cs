namespace OnlineLearningSystem.Forms
{
    partial class TestCreationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTestTitle;
        private System.Windows.Forms.TextBox txtTestDescription;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.TextBox txtAnswerD;
        private System.Windows.Forms.ComboBox cmbCorrectAnswer;
        private System.Windows.Forms.Button btnCreateTest;

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
            this.txtTestTitle = new System.Windows.Forms.TextBox();
            this.txtTestDescription = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerC = new System.Windows.Forms.TextBox();

            this.txtAnswerD = new System.Windows.Forms.TextBox();
            this.cmbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTestTitle
            // 
            this.txtTestTitle.Location = new System.Drawing.Point(20, 20);
            this.txtTestTitle.Name = "txtTestTitle";
            this.txtTestTitle.Size = new System.Drawing.Size(250, 22);
            this.txtTestTitle.TabIndex = 0;
            // 
            // txtTestDescription
            // 
            this.txtTestDescription.Location = new System.Drawing.Point(20, 60);
            this.txtTestDescription.Name = "txtTestDescription";
            this.txtTestDescription.Size = new System.Drawing.Size(250, 22);
            this.txtTestDescription.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(20, 100);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(250, 22);
            this.txtQuestion.TabIndex = 2;
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.Location = new System.Drawing.Point(20, 140);
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(250, 22);
            this.txtAnswerA.TabIndex = 3;
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.Location = new System.Drawing.Point(20, 180);
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(250, 22);
            this.txtAnswerB.TabIndex = 4;
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.Location = new System.Drawing.Point(20, 220);
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(250, 22);
            this.txtAnswerC.TabIndex = 5;
            // 
            // txtAnswerD
            // 
            this.txtAnswerD.Location = new System.Drawing.Point(20, 260);
            this.txtAnswerD.Name = "txtAnswerD";
            this.txtAnswerD.Size = new System.Drawing.Size(250, 22);
            this.txtAnswerD.TabIndex = 6;
            // 
            // cmbCorrectAnswer
            // 
            this.cmbCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorrectAnswer.FormattingEnabled = true;
            this.cmbCorrectAnswer.Location = new System.Drawing.Point(20, 300);
            this.cmbCorrectAnswer.Name = "cmbCorrectAnswer";
            this.cmbCorrectAnswer.Size = new System.Drawing.Size(250, 24);
            this.cmbCorrectAnswer.TabIndex = 7;
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(20, 340);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(100, 30);
            this.btnCreateTest.TabIndex = 8;
            this.btnCreateTest.Text = "Создать тест";
            this.btnCreateTest.UseVisualStyleBackColor = true;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // TestCreationForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.txtTestTitle);
            this.Controls.Add(this.txtTestDescription);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtAnswerA);

            this.Controls.Add(this.txtAnswerB);
            this.Controls.Add(this.txtAnswerC);
            this.Controls.Add(this.txtAnswerD);
            this.Controls.Add(this.cmbCorrectAnswer);
            this.Controls.Add(this.btnCreateTest);
            this.Name = "TestCreationForm";
            this.Text = "Создание теста";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
