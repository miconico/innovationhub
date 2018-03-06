using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace InnovationMembership
{
    class Mobile
    {
        // Get the twilio-csharp library from twilio.com/docs/libraries/csharp

        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "ACf42aa7016f9c3c50c5d4e0105c5d3ed0";
        const string authToken = "f07fa68f5820144898191b04501456a8";
       
        public static Boolean SendSMS(string memberId)
        {
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+353877453339");

            var message = MessageResource.Create(to, from: new PhoneNumber("+353861802731"), body: "Welcome to the Innovation Hub Portarlington - your new member number is " + memberId);

            Console.WriteLine(message.Sid);

            return true;
        }
    }
}

