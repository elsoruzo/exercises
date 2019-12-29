namespace ChainOfResponsibilityModel
{

    /// <summary>
    /// Интерфейс Обработчика объявляет метод построения цепочки обработчиков. Он
    /// также объявляет метод для выполнения запроса.
    /// </summary>
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
