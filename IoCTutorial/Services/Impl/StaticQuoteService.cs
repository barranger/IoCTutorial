using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCTutorial.Services.Impl
{
    public class StaticQuoteService : IQuoteService
    {
        public string GetRandomQuote()
        {
            return "Find your own quote";
        }
    }
}