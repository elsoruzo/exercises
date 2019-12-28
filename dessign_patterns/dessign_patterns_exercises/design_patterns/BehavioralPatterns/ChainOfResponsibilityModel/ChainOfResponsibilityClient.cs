using System;
using System.Collections.Generic;

namespace design_patterns_exercises.BehavioralPatterns.ChainOfResponsibilityModel
{
    class ChainOfResponsibilityClient
    {

        /// <summary>
        /// Обычно клиентский код приспособлен для работы с единственным
        /// обработчиком. В большинстве случаев клиенту даже неизвестно, что этот
        /// обработчик является частью цепочки.
        /// </summary>
        /// <param name="handler"></param>
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
