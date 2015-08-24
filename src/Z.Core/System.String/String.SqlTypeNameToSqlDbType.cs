using System;
using System.Data;

public static partial class Extensions
{
    public static SqlDbType SqlTypeNameToSqlDbType(this string @this)
    {
        switch (@this.ToLower())
        {
            case "image": // 34 | "image" | SqlDbType.Image
                return SqlDbType.Image;

            case "text": // 35 | "text" | SqlDbType.Text
                return SqlDbType.Text;

            case "uniqueidentifier": // 36 | "uniqueidentifier" | SqlDbType.UniqueIdentifier
                return SqlDbType.UniqueIdentifier;

            case "date": // 40 | "date" | SqlDbType.Date
                return SqlDbType.Date;

            case "time": // 41 | "time" | SqlDbType.Time
                return SqlDbType.Time;

            case "datetime2": // 42 | "datetime2" | SqlDbType.DateTime2
                return SqlDbType.DateTime2;

            case "datetimeoffset": // 43 | "datetimeoffset" | SqlDbType.DateTimeOffset
                return SqlDbType.DateTimeOffset;

            case "tinyint": // 48 | "tinyint" | SqlDbType.TinyInt
                return SqlDbType.TinyInt;

            case "smallint": // 52 | "smallint" | SqlDbType.SmallInt
                return SqlDbType.SmallInt;

            case "int": // 56 | "int" | SqlDbType.Int
                return SqlDbType.Int;

            case "smalldatetime": // 58 | "smalldatetime" | SqlDbType.SmallDateTime
                return SqlDbType.SmallDateTime;

            case "real": // 59 | "real" | SqlDbType.Real
                return SqlDbType.Real;

            case "money": // 60 | "money" | SqlDbType.Money
                return SqlDbType.Money;

            case "datetime": // 61 | "datetime" | SqlDbType.DateTime
                return SqlDbType.DateTime;

            case "float": // 62 | "float" | SqlDbType.Float
                return SqlDbType.Float;

            case "sql_variant": // 98 | "sql_variant" | SqlDbType.Variant
                return SqlDbType.Variant;

            case "ntext": // 99 | "ntext" | SqlDbType.NText
                return SqlDbType.NText;

            case "bit": // 104 | "bit" | SqlDbType.Bit
                return SqlDbType.Bit;

            case "decimal": // 106 | "decimal" | SqlDbType.Decimal
                return SqlDbType.Decimal;

            case "numeric": // 108 | "numeric" | SqlDbType.Decimal
                return SqlDbType.Decimal;

            case "smallmoney": // 122 | "smallmoney" | SqlDbType.SmallMoney
                return SqlDbType.SmallMoney;

            case "bigint": // 127 | "bigint" | SqlDbType.BigInt
                return SqlDbType.BigInt;

            case "varbinary": // 165 | "varbinary" | SqlDbType.VarBinary
                return SqlDbType.VarBinary;

            case "varchar": // 167 | "varchar" | SqlDbType.VarChar
                return SqlDbType.VarChar;

            case "binary": // 173 | "binary" | SqlDbType.Binary
                return SqlDbType.Binary;

            case "char": // 175 | "char" | SqlDbType.Char
                return SqlDbType.Char;

            case "timestamp": // 189 | "timestamp" | SqlDbType.Timestamp
                return SqlDbType.Timestamp;

            case "nvarchar": // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                return SqlDbType.NVarChar;
            case "sysname": // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                return SqlDbType.NVarChar;

            case "nchar": // 239 | "nchar" | SqlDbType.NChar
                return SqlDbType.NChar;

            case "hierarchyid": // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                return SqlDbType.Udt;
            case "geometry": // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                return SqlDbType.Udt;
            case "geography": // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                return SqlDbType.Udt;

            case "xml": // 241 | "xml" | SqlDbType.Xml
                return SqlDbType.Xml;

            default:
                throw new Exception(string.Format("Unsupported Type: {0}. Please let us know about this type and we will support it: sales@zzzprojects.com", @this));
        }
    }
}