using System.Linq;
using System.Reflection;

namespace EnumExtension
{
    public static class EnumExtensionMethods
    {
        /// <summary>
        ///     Gets error description from enum
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static string GetDescription(this SystemErrorCodes arg)
        {
            return GetAttribute(arg).Description;
        }

        /// <summary>
        ///     Gets error priority from enum
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static ErrorPriority GetPriority(this SystemErrorCodes arg)
        {
            return GetAttribute(arg).Priority;
        }

        /// <summary>
        ///     Gets source from enum
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static ErrorSource GetSource(this SystemErrorCodes arg)
        {
            return GetAttribute(arg).Source;
        }

        /// <summary>
        ///     Extracts the Configuration attribute from the SystemErrorCodes enum
        /// </summary>
        /// <param name="arg">SystemErrorCodes enum</param>
        /// <returns>Configuration attribute</returns>
        private static Configuration GetAttribute(SystemErrorCodes arg)
        {
            FieldInfo fieldInfo = arg.GetType().GetField(arg.ToString());
            if (fieldInfo == null)
            {
                return null;
            }
            object attr = fieldInfo.GetCustomAttributes(typeof (Configuration), true).FirstOrDefault();
            if (attr == null)
            {
                return null;
            }
            return ((Configuration) attr);
        }
    }
}