using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace JusticeWebApp.Services
{
    public class MockMessageService : IMessageService
    {
        public bool SendMessage(string name, string email, string message)
        {
            Debug.WriteLine(string.Concat("SendMessage: ", name));

            return true;
        }
    }
}