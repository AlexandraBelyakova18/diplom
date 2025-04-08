using System.Windows.Forms;
using OnlineLearningSystem.Models; // Используется модель Material

namespace OnlineLearningSystem.Forms
{
    public partial class MaterialDetailsForm : Form
    {
        public MaterialDetailsForm(Material material)
        {
            InitializeComponent();
            LoadMaterialDetails(material);
        }

        private void LoadMaterialDetails(Material material)
        {
            lblMaterialTitle.Text = material.Title; // Установка заголовка
            txtMaterialContent.Text = material.Content; // Установка содержания
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        private void MaterialDetailsForm_Load(object sender, System.EventArgs e)
        {
            // Можно добавить дополнительные действия при загрузке формы, если нужно
        }
    }
}
