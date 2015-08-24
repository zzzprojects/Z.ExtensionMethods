using System;
using System.Data;

public static partial class Extensions
{
    public static SqlDbType SqlSystemTypeToSqlDbType(this short @this)
    {
        switch (@this)
        {
            case 34: // 34 | "image" | SqlDbType.Image
                return SqlDbType.Image;

            case 35: // 35 | "text" | SqlDbType.Text
                return SqlDbType.Text;

            case 36: // 36 | "uniqueidentifier" | SqlDbType.UniqueIdentifier
                return SqlDbType.UniqueIdentifier;

            case 40: // 40 | "date" | SqlDbType.Date
                return SqlDbType.Date;

            case 41: // 41 | "time" | SqlDbType.Time
                return SqlDbType.Time;

            case 42: // 42 | "datetime2" | SqlDbType.DateTime2
                return SqlDbType.DateTime2;

            case 43: // 43 | "datetimeoffset" | SqlDbType.DateTimeOffset
                return SqlDbType.DateTimeOffset;

            case 48: // 48 | "tinyint" | SqlDbType.TinyInt
                return SqlDbType.TinyInt;

            case 52: // 52 | "smallint" | SqlDbType.SmallInt
                return SqlDbType.SmallInt;

            case 56: // 56 | "int" | SqlDbType.Int
                return SqlDbType.Int;

            case 58: // 58 | "smalldatetime" | SqlDbType.SmallDateTime
                return SqlDbType.SmallDateTime;

            case 59: // 59 | "real" | SqlDbType.Real
                return SqlDbType.Real;

            case 60: // 60 | "money" | SqlDbType.Money
                return SqlDbType.Money;

            case 61: // 61 | "datetime" | SqlDbType.DateTime
                return SqlDbType.DateTime;

            case 62: // 62 | "float" | SqlDbType.Float
                return SqlDbType.Float;

            case 98: // 98 | "sql_variant" | SqlDbType.Variant
                return SqlDbType.Variant;

            case 99: // 99 | "ntext" | SqlDbType.NText
                return SqlDbType.NText;

            case 104: // 104 | "bit" | SqlDbType.Bit
                return SqlDbType.Bit;

            case 106: // 106 | "decimal" | SqlDbType.Decimal
                return SqlDbType.Decimal;

            case 108: // 108 | "numeric" | SqlDbType.Decimal
                return SqlDbType.Decimal;

            case 122: // 122 | "smallmoney" | SqlDbType.SmallMoney
                return SqlDbType.SmallMoney;

            case 127: // 127 | "bigint" | SqlDbType.BigInt
                return SqlDbType.BigInt;

            case 165: // 165 | "varbinary" | SqlDbType.VarBinary
                return SqlDbType.VarBinary;

            case 167: // 167 | "varchar" | SqlDbType.VarChar
                return SqlDbType.VarChar;

            case 173: // 173 | "binary" | SqlDbType.Binary
                return SqlDbType.Binary;

            case 175: // 175 | "char" | SqlDbType.Char
                return SqlDbType.Char;

            case 189: // 189 | "timestamp" | SqlDbType.Timestamp
                return SqlDbType.Timestamp;

            case 231: // 231 | "nvarchar", "sysname" | SqlDbType.NVarChar
                return SqlDbType.NVarChar;

            case 239: // 239 | "nchar" | SqlDbType.NChar
                return SqlDbType.NChar;

            case 240: // 240 | "hierarchyid", "geometry", "geography" | SqlDbType.Udt
                return SqlDbType.Udt;

            case 241: // 241 | "xml" | SqlDbType.Xml
                return SqlDbType.Xml;

            default:
                throw new Exception(string.Format("Unsupported Type: {0}. Please let us know about this type and we will support it: sales@zzzprojects.com", @this));
        }
    }
}