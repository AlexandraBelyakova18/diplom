using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OnlineLearningSystem.Tests
{
    // Этот класс служит для настройки общих настроек тестирования
    [TestClass]
    public class MSTestSettings
    {
        // Указываем атрибуты, если нужно выполнять какую-либо инициализацию перед тестами
        [TestInitialize]
        public void Setup()
        {
            // Здесь можно инициализировать данные или фиксированные значения для тестов
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Здесь можно произвести очистку после тестов
        }
    }
}
