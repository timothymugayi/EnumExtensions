#region

using System;

#endregion

namespace EnumExtension
{
    /// <author>Timothy Mugayi</author>
    /// <date>29/01/2015</date>
    /// <summary>
    ///     Example shows how you can extend enum through extension methods as well as using custom attributes.
    ///     Code below shows a typical System error codes enum and some of the additional information binded to the enum
    /// </summary>
    public enum SystemErrorCodes
    {
        [Configuration("Users Not Found in this Group", ErrorPriority.MEDIUM, ErrorSource.APPLICATION)] 
        GroupUsersNotFound = 6900023,

        [Configuration("Groups Not Found", ErrorPriority.MEDIUM, ErrorSource.DATABASE)] 
        GroupsNotFound = 6900024,

        [Configuration("Users Not Found", ErrorPriority.MEDIUM, ErrorSource.DATABASE)] 
        UsersNotFound = 6900025,

        [Configuration("Terminal Not Found", ErrorPriority.MEDIUM, ErrorSource.DATABASE)] 
        KioskNotFound = 6900026,

        [Configuration("Alert Data Not Found", ErrorPriority.MEDIUM, ErrorSource.DATABASE)] 
        AlertDataNotFound = 6900027,
    }

    /// <summary>
    ///     The following program illustrates how to add custom attributes to an enum and extension methods
    ///     in order to extend an enum to get additional infomation attached to each enum constant such as description. This
    ///     also shows
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (SystemErrorCodes item in Enum.GetValues(typeof (SystemErrorCodes)))
            {
                Console.WriteLine("[{0}, {1}, {2}, {3}, {4}]", item.ToString("G"), item.GetDescription(), item.GetPriority(),
                    item.GetSource(), item.ToString("D"));
            }
            Console.ReadLine();
        }
    }
}