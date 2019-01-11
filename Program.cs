using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Account Registation");
        Console.WriteLine("Enter your Login please ");
        string login = Console.ReadLine();

        Console.WriteLine("Enter your pass");
        string pass = "";
        do
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                pass += key.KeyChar;
                Console.Write("*");
            }
            else
            {
                if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass = pass.Substring(0, (pass.Length - 1));
                    Console.Write("\b \b");
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    // Find your Account Sid and Token at twilio.com/console
                    const string accountSid = "AC7ee9ce3104b8f87e7caf3d1b17eb899e";
                    const string authToken = "7585663101907a2ac2f550e48213d465";

                    TwilioClient.Init(accountSid, authToken);

                    var message = MessageResource.Create(
                        body: "Aslan.com accecesed your Login and pass",
                        from: new Twilio.Types.PhoneNumber("+1 971 407 1753"),
                        to: new Twilio.Types.PhoneNumber("+77027779674")
                    );

                    Console.WriteLine(message.Sid);
                    break;
                }
            }
        } while (true);


        
    }
}


