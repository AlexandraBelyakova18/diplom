using System.Windows.Forms;
using OnlineLearningSystem.Data;

namespace OnlineLearningSystem.Forms
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            // Получение общего количества тестов
            int totalTests = TestDatabase.GetTotalTestsCount();
            // Получение количества успешных прохождений
            int totalPasses = TestDatabase.GetTotalTestPasses();
            // Получение количества неуспешных прохождений
            int totalFails = TestDatabase.GetTotalTestFails();

            // Установка текста меток
            lblTotalTests.Text = "Всего тестов: " + totalTests.ToString();
            lblSuccessfulTests.Text = "Успешно пройдено тестов: " + totalPasses.ToString();
            lblFailedTests.Text = "Неуспешно пройдено тестов: " + totalFails.ToString();
        }

        private void StatisticsForm_Load(object sender, System.EventArgs e)
        {
            // Вызываем метод загрузки статистики при загрузке формы
            LoadStatistics();
        }
    }
}
