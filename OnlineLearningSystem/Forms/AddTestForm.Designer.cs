namespace OnlineLearningSystem.Forms
{
    partial class AddTestForm
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
            this.txtTestTitle = new System.Windows.Forms.TextBox();
            this.txtTestDescription = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerC = new System.Windows.Forms.TextBox();
            this.txtAnswerD = new System.Windows.Forms.TextBox();
            this.cmbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTestTitle
            // 
            this.txtTestTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTestTitle.Name = "txtTestTitle";
            this.txtTestTitle.Size = new System.Drawing.Size(358, 20);
            this.txtTestTitle.TabIndex = 0;
            // 
            // txtTestDescription
            // 
            this.txtTestDescription.Location = new System.Drawing.Point(12, 38);
            this.txtTestDescription.Multiline = true;
            this.txtTestDescription.Name = "txtTestDescription";
            this.txtTestDescription.Size = new System.Drawing.Size(358, 50);
            this.txtTestDescription.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(12, 108);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(358, 20);
            this.txtQuestion.TabIndex = 2;
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.Location = new System.Drawing.Point(12, 134);
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(175, 20);
            this.txtAnswerA.TabIndex = 3;
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.Location = new System.Drawing.Point(195, 134);
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(175, 20);
            this.txtAnswerB.TabIndex = 4;
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.Location = new System.Drawing.Point(12, 160);
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(175, 20);
            this.txtAnswerC.TabIndex = 5;
            // 
            // txtAnswerD
            // 
            this.txtAnswerD.Location = new System.Drawing.Point(195, 160);
            this.txtAnswerD.Name = "txtAnswerD";

            this.txtAnswerD.Size = new System.Drawing.Size(175, 20);
            this.txtAnswerD.TabIndex = 6;
            // 
            // cmbCorrectAnswer
            // 
            this.cmbCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorrectAnswer.FormattingEnabled = true;
            this.cmbCorrectAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbCorrectAnswer.Location = new System.Drawing.Point(12, 186);
            this.cmbCorrectAnswer.Name = "cmbCorrectAnswer";
            this.cmbCorrectAnswer.Size = new System.Drawing.Size(358, 21);
            this.cmbCorrectAnswer.TabIndex = 7;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(12, 213);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(175, 23);
            this.btnAddQuestion.TabIndex = 8;
            this.btnAddQuestion.Text = "Добавить вопрос";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(195, 213);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(175, 23);
            this.btnSaveTest.TabIndex = 9;
            this.btnSaveTest.Text = "Сохранить тест";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(12, 243);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(358, 147);
            this.lstQuestions.TabIndex = 10;
            // 
            // AddTestForm
            // 
            this.ClientSize = new System.Drawing.Size(382, 402);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.btnSaveTest);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.cmbCorrectAnswer);
            this.Controls.Add(this.txtAnswerD);
            this.Controls.Add(this.txtAnswerC);
            this.Controls.Add(this.txtAnswerB);
            this.Controls.Add(this.txtAnswerA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtTestDescription);
            this.Controls.Add(this.txtTestTitle);
            this.Name = "AddTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTestTitle;
        private System.Windows.Forms.TextBox txtTestDescription;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.TextBox txtAnswerD;
        private System.Windows.Forms.ComboBox cmbCorrectAnswer;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.ListBox lstQuestions;
    }
}
