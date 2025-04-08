namespace OnlineLearningSystem.Forms
{
    partial class TestTakingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbAnswerA;
        private System.Windows.Forms.RadioButton rbAnswerB;
        private System.Windows.Forms.RadioButton rbAnswerC;
        private System.Windows.Forms.RadioButton rbAnswerD;
        private System.Windows.Forms.Button btnNext;

        /// <summary>
        /// Обязательно необходимый метод для очистки списка ресурсов.
        /// </summary>
        /// <param name="disposing">true, если ресурсы следует удалить; в противном случае false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для инициализации компонента.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbAnswerA = new System.Windows.Forms.RadioButton();
            this.rbAnswerB = new System.Windows.Forms.RadioButton();
            this.rbAnswerC = new System.Windows.Forms.RadioButton();
            this.rbAnswerD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(113, 20);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Вопрос здесь";
            // 
            // rbAnswerA
            // 
            this.rbAnswerA.AutoSize = true;
            this.rbAnswerA.Location = new System.Drawing.Point(15, 40);
            this.rbAnswerA.Name = "rbAnswerA";
            this.rbAnswerA.Size = new System.Drawing.Size(97, 24);
            this.rbAnswerA.TabIndex = 1;
            this.rbAnswerA.TabStop = true;
            this.rbAnswerA.Text = "Ответ A";
            this.rbAnswerA.UseVisualStyleBackColor = true;
            // 
            // rbAnswerB
            // 
            this.rbAnswerB.AutoSize = true;
            this.rbAnswerB.Location = new System.Drawing.Point(15, 70);
            this.rbAnswerB.Name = "rbAnswerB";
            this.rbAnswerB.Size = new System.Drawing.Size(97, 24);
            this.rbAnswerB.TabIndex = 2;
            this.rbAnswerB.TabStop = true;
            this.rbAnswerB.Text = "Ответ B";
            this.rbAnswerB.UseVisualStyleBackColor = true;
            // 
            // rbAnswerC
            // 
            this.rbAnswerC.AutoSize = true;
            this.rbAnswerC.Location = new System.Drawing.Point(15, 100);
            this.rbAnswerC.Name = "rbAnswerC";
            this.rbAnswerC.Size = new System.Drawing.Size(97, 24);
            this.rbAnswerC.TabIndex = 3;
            this.rbAnswerC.TabStop = true;
            this.rbAnswerC.Text = "Ответ C";
            this.rbAnswerC.UseVisualStyleBackColor = true;
            // 
            // rbAnswerD
            //

            this.rbAnswerD.AutoSize = true;
            this.rbAnswerD.Location = new System.Drawing.Point(15, 130);
            this.rbAnswerD.Name = "rbAnswerD";
            this.rbAnswerD.Size = new System.Drawing.Size(98, 24);
            this.rbAnswerD.TabIndex = 4;
            this.rbAnswerD.TabStop = true;
            this.rbAnswerD.Text = "Ответ D";
            this.rbAnswerD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(15, 170);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 30);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // TestTakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbAnswerD);
            this.Controls.Add(this.rbAnswerC);
            this.Controls.Add(this.rbAnswerB);
            this.Controls.Add(this.rbAnswerA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "TestTakingForm";
            this.Text = "Прохождение Теста";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
