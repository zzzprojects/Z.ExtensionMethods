using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

public static partial class Extensions
{
    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction)
    {
        using (SqlCommand command = @this.CreateCommand())
        {
            command.CommandText = cmdText;
            command.CommandType = commandType;
            command.Transaction = transaction;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            return command.ExecuteXmlReader();
        }
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, Action<SqlCommand> commandFactory)
    {
        using (SqlCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            return command.ExecuteXmlReader();
        }
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText)
    {
        return @this.ExecuteXmlReader(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlTransaction transaction)
    {
        return @this.ExecuteXmlReader(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteXmlReader(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction)
    {
        return @this.ExecuteXmlReader(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
    {
        return @this.ExecuteXmlReader(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction)
    {
        return @this.ExecuteXmlReader(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlConnection extension method that executes the XML reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>An XmlReader.</returns>
    public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType)
    {
        return @this.ExecuteXmlReader(cmdText, parameters, commandType, null);
    }
}

}