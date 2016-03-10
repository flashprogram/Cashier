
using System.Configuration;

namespace Cashier.classes
{
   public struct  Connect
    {
        public static string ToDB()
        {
            
            return ConfigurationManager.ConnectionStrings[CommonConstants.DB].ToString();
            
        }


        public static string ToDB(string value)
        {
            return ConfigurationManager.ConnectionStrings[value].ToString();
        }
    }
}
