using Microsoft.VisualStudio.TestTools.UnitTesting;

// Этот файл можно оставить пустым, если нет специфичных настроек.
// Здесь можно было бы настроить общие переменные для всех тестов
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
