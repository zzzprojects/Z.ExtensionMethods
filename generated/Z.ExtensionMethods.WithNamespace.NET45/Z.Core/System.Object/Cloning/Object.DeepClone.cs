using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public static partial class Extensions
    {
        /// <summary>
        ///     A T extension method that makes a deep copy of '@this' object.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>the copied object.</returns>
        public static T DeepClone<T>(this T @this)
        {
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);
                return (T) formatter.Deserialize(stream);
            }
        }
    }


}