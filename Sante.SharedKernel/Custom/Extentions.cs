using System;

namespace Sante.SharedKernel.Custom
{
   public static class Extentions
    {
        /// <summary>
        /// Determines if a nullable Guid (Guid?) is null or Guid.Empty
        /// </summary>
        public static bool IsNullOrEmpty(this Guid? guid)
        {
            return !guid.HasValue || guid.Value == Guid.Empty;
        }

        /// <summary>
        /// Determines if Guid is Guid.Empty
        /// </summary>
        public static bool IsNullOrEmpty(this Guid guid)
        {
            return guid == Guid.Empty;
        }
        
        /// <summary>
        /// Determines if a nullable DateTime (DateTime?) is null or Default Empty date (01/01/0001)
        /// </summary>
        public static bool IsNullOrEmpty(this DateTime? date)
        {
            if (null == date)
                return true;

            if (date.Value==DateTime.MinValue)
                return true;

            return false;
        }
        
        /// <summary>
        /// Determines if a DateTime (DateTime) is Default Empty date (01/01/0001)
        /// </summary>
        public static bool IsNullOrEmpty(this DateTime date)
        {
            if (date==DateTime.MinValue)
                return true;

            return false;
        }

        /// <summary>
        /// compare strings insenitive
        /// </summary>
        /// <param name="value"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool IsSameAs(this string value, string other)
        {
            if (value == null)
                return false;
            return value.Trim().ToLower() == other.Trim().ToLower();
        }
    }
}
