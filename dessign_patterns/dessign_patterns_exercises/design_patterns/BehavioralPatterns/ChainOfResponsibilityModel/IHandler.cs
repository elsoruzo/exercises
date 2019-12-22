using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_exercises.BehavioralPatterns.ChainOfResponsibilityModel
{
    // Интерфейс Обработчика объявляет метод построения цепочки обработчиков. Он
    // также объявляет метод для выполнения запроса.
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
