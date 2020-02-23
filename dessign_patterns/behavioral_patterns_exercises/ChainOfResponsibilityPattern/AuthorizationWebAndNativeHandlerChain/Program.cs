namespace AuthorizationWebAndNativeHandlerChain
{
    using System;
    using AuthorizationWebAndNativeHandlerChain.Models;
    class Program
    {
        static void Main(string[] args)
        {
            var nativeEmailAuthorizationHandler = new NativeEmailAuthorizationHandler();
            var nativePhoneAuthorizationHandler = new NativePhoneAuthorizationHandler();
            var gmailAuthorizationHandler = new GmailAuthorizationHandler();
            var facebookAuthorizationHandler = new FacebookAuthorizationHandler();

            nativeEmailAuthorizationHandler
                .SetNext(facebookAuthorizationHandler)
                .SetNext(gmailAuthorizationHandler)
                .SetNext(nativePhoneAuthorizationHandler);

            Console.WriteLine("Chain: nativeEmailAuthorizationHandler > nativePhoneAuthorizationHandler" +
                "\n > gmailAuthorizationHandler > facebookAuthorizationHandler > \n");
            ChainOfResponsibilityClient.ClientCode(nativeEmailAuthorizationHandler);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}