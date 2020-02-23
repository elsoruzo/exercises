namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;
    using System.Collections.Generic;
    class ChainOfResponsibilityClient
    {
        public static void ClientCode(IHandler handler)
        {
            var nativeEmailUser = new AutorizationModel()
            {
                Login = "yakov@email.com",
                Password = "12345678"
            };

            var nativePhoneUser = new AutorizationModel()
            {
                Login = "+0 930 987 39 20",
                Password = "12345678"
            };

            var gmailUser = new AutorizationModel()
            {
                Login = "yakov@gmail.com",
                Password = "12345678"
            };

            var facebookUser = new AutorizationModel()
            {
                Login = "yakov@facebook.com",
                Password = "12345678"
            };

            var unknownToTheSystemUser = new AutorizationModel()
            {
                Login = "yakov@vaiber.com",
                Password = "12345678"
            };
            var loginList = new List<IAutorizationModel>();
            loginList.Add(nativeEmailUser);
            loginList.Add(nativePhoneUser);
            loginList.Add(gmailUser);
            loginList.Add(facebookUser);
            loginList.Add(unknownToTheSystemUser);
            foreach (var user in loginList)
            {
                Console.WriteLine($"Client: Current users\'s login in the list of login models is => {user.Login}");

                var result = handler.Handle(user);

                if (result != null)
                {
                    Console.Write($" {result}");
                }
                else
                {
                    Console.WriteLine($" {user.Login} login was left unhendeled.");
                }
            }
        }
    }
}
