namespace OnlineLearningSystem.Forms
{
    partial class MaterialDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaterialTitle;
        private System.Windows.Forms.TextBox txtMaterialContent;
        private System.Windows.Forms.Button btnClose;

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
            this.lblMaterialTitle = new System.Windows.Forms.Label();
            this.txtMaterialContent = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaterialTitle
            // 
            this.lblMaterialTitle.AutoSize = true;
            this.lblMaterialTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaterialTitle.Location = new System.Drawing.Point(12, 9);
            this.lblMaterialTitle.Name = "lblMaterialTitle";
            this.lblMaterialTitle.Size = new System.Drawing.Size(277, 29);
            this.lblMaterialTitle.TabIndex = 0;
            this.lblMaterialTitle.Text = "Название материала"; // Устанавливается программно
            // 
            // txtMaterialContent
            // 
            this.txtMaterialContent.Location = new System.Drawing.Point(12, 42);
            this.txtMaterialContent.Multiline = true;
            this.txtMaterialContent.Name = "txtMaterialContent";
            this.txtMaterialContent.ReadOnly = true; // Только для чтения
            this.txtMaterialContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMaterialContent.Size = new System.Drawing.Size(360, 200);
            this.txtMaterialContent.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //

            // MaterialDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMaterialContent);
            this.Controls.Add(this.lblMaterialTitle);
            this.Name = "MaterialDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; // Центрировать форму
            this.Text = "Детали материала";
            this.Load += new System.EventHandler(this.MaterialDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
