namespace ConsoleImplementationOfChainOfResponsibility
{
    using System;
    using ChainOfResponsibilityModel;
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeAuthorizationHandler();
            var specialOperator = new SpecialOperatorHandler();
            var hr = new HrAutorizationHandler();

            employee.SetNext(specialOperator).SetNext(hr);

            Console.WriteLine("Chain: employee > specialOperator > hr\n");
            ChainOfResponsibilityClient.ClientCode(employee);
            Console.WriteLine();

            Console.WriteLine("Subchain: specialOperator > hr\n");
            ChainOfResponsibilityClient.ClientCode(specialOperator);

            Console.ReadKey();
        }
    }
}













