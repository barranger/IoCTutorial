using IoCTutorial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoCTutorial.Util
{
    public static class RandomUtil
    {
        public static string GetRandomQuote()
        {
            var service = UnityConfig.Container.Resolve(typeof(IQuoteService), null) as IQuoteService;
            // Explicitly resolve the dependencies / mappings
            return $"From the RandomUtil: {service.GetRandomQuote()}";
        }
    }
}