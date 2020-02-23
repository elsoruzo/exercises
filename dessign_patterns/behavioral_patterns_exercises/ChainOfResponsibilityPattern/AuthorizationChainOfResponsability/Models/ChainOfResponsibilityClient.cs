namespace ChainOfResponsibilityModel
{
    using System;
    using System.Collections.Generic;
    class ChainOfResponsibilityClient
    {
        public static void ClientCode(IHandler handler)
        {
            foreach (var role in new List<string> { "Hr", "SpecialOperator", "Employee", "MinorOperator" })
            {
                Console.WriteLine($"Client: Current employee\'s role in the list of roles is => {role}");

                var result = handler.Handle(role);

                if (result != null)
                {
                    Console.Write($" {result}");
                }
                else
                {
                    Console.WriteLine($" {role} role was left unhendeled.");
                }
            }
        }
    }
}
