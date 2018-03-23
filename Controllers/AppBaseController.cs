//Simple Device Detection Code There are many methods to detect what kind of browser is running the method in your controller, ranging from very simple to very complex.You can even purchase a subscription to a service for device detection. In this article, you’re going to write a simple method to detect a mobile browser. I’ve found that this method works for most mobile browsers on the market today.

//  You’re going to want to use this device detection method on many controllers, not just the Product controller you
//  created in this sample.Create a controller base class from which all your controllers can inherit. 
//
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace AlternativeTable.Controllers
{
    public class AppBaseController : Controller
    {
        public bool IsMobileDevice()
        {
            bool ret = Request.IsMobileBrowser(); //  .Browser.IsMobileDevice;
            //string userAgent = Request.UserAgent;

            string userAgent = Request.Headers["User-Agent"];

            // The IsMobileDevice() method looks at the Request.Browser.IsMobileDevice property to see if MVC has detected a mobile browser. If this value is not true, you
            // then check a string against the Request.UserAgent to see if you can find some certain keywords.If any of these keywords exist, then you have a mobile device.
            if (!ret)
            {
                // Use regular expression
                Regex b = new Regex(@"(android|bb\d+|meego)
                                    .+mobile|avantgo|bada\/|blackberry|
                                    blazer|compal|elaine|fennec|hiptop|
                                    iemobile|ip(hone|od)|iris|kindle|lge
                                    |maemo|midp|mmp|mobile.+firefox|
                                    netfront|opera m(ob|in)i|palm(os)
                                    ?|phone|p(ixi|re)\/|plucker|
                                    pocket|psp|series(4|6)0|symbian|
                                    treo|up\.(browser|link)|vodafone|
                                    wap|windows ce|xda|xiino",
                RegexOptions.IgnoreCase |
                RegexOptions.Multiline);

                ret = b.IsMatch(userAgent);
                // Check user agent for certain words
                //  If the regular expression fails, check the user agent string to see if it contains “iphone” or “android”. You can add additional checks for other types of mobile devices,
                //  such as a blackberry.Instead of hard - coding these values in this method, you might create a couple of key / value pairs in the < appSettings > section of your Web.config file            
                //  to hold the string to check for the regular expression, and for each of the phone keywords.
                ret = !ret
                ? userAgent.ToLower().Contains("iphone")
                : true;
                ret = !ret
                ? userAgent.ToLower().Contains("android")
                : true;
                // etc.
            }
            return ret;
        }
    }
}
