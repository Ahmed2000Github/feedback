using System;
using System.Net;

namespace Util
{
    public class InfoHandler
    {
        public static int GetAge(DateTime BirthDay)
        {
            int age = DateTime.Today.Year - BirthDay.Year;
            if (BirthDay.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
        public static bool IsConnect()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("https://www.bing.com/"))
                    {
                        return true;
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
