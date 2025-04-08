namespace OnlineLearningSystem.Forms
{
    partial class MaterialForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxMaterials;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnUpdateMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;

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
            this.listBoxMaterials = new System.Windows.Forms.ListBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMaterials
            // 
            this.listBoxMaterials.FormattingEnabled = true;
            this.listBoxMaterials.ItemHeight = 16;
            this.listBoxMaterials.Location = new System.Drawing.Point(12, 12);
            this.listBoxMaterials.Name = "listBoxMaterials";
            this.listBoxMaterials.Size = new System.Drawing.Size(360, 148);
            this.listBoxMaterials.TabIndex = 0;
            this.listBoxMaterials.SelectedIndexChanged += new System.EventHandler(this.ListBoxMaterials_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 191);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(360, 22);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 232);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(360, 150);
            this.txtContent.TabIndex = 2;
            this.txtContent.Enter += new System.EventHandler(this.txtContent_Enter);
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 407);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(120, 30);
            this.btnAddMaterial.TabIndex = 3;
            this.btnAddMaterial.Text = "Добавить";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.BtnAddMaterial_Click);
            // 
            // btnUpdateMaterial
            // 
            this.btnUpdateMaterial.Location = new System.Drawing.Point(138, 407);
            this.btnUpdateMaterial.Name = "btnUpdateMaterial";
            this.btnUpdateMaterial.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateMaterial.TabIndex = 4;
            this.btnUpdateMaterial.Text = "Изменить";
            this.btnUpdateMaterial.UseVisualStyleBackColor = true;
            this.btnUpdateMaterial.Click += new System.EventHandler(this.BtnUpdateMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Location = new System.Drawing.Point(264, 407);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(120, 30);

            this.btnDeleteMaterial.TabIndex = 5;
            this.btnDeleteMaterial.Text = "Удалить";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.BtnDeleteMaterial_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 171);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Заголовок";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(12, 212);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(72, 17);
            this.lblContent.TabIndex = 7;
            this.lblContent.Text = "Содержимое";
            // 
            // MaterialForm
            // 
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.btnUpdateMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.listBoxMaterials);
            this.Name = "MaterialForm";
            this.Text = "Материалы";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
