namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Returns the  for the specified object.
        /// </summary>
        /// <param name="value">An object that implements the  interface.</param>
        /// <returns>The  for , or  if  is null.</returns>
        public static TypeCode GetTypeCode(this System.Object value)
        {
            return Convert.GetTypeCode(value);
        }
    }


}