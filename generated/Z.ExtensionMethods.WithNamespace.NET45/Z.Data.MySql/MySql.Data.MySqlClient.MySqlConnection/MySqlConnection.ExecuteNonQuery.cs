using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.Data.MySqlExtensions
{

using System;
using System.Data;
using MySql.Data.MySqlClient;

public static partial class Extensions
{
    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters, CommandType commandType, MySqlTransaction transaction)
    {
        using (MySqlCommand command = @this.CreateCommand())
        {
            command.CommandText = cmdText;
            command.CommandType = commandType;
            command.Transaction = transaction;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.ExecuteNonQuery();
        }
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, Action<MySqlCommand> commandFactory)
    {
        using (MySqlCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            command.ExecuteNonQuery();
        }
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText)
    {
        @this.ExecuteNonQuery(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText, MySqlTransaction transaction)
    {
        @this.ExecuteNonQuery(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText, CommandType commandType)
    {
        @this.ExecuteNonQuery(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText, CommandType commandType, MySqlTransaction transaction)
    {
        @this.ExecuteNonQuery(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters)
    {
        @this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters, MySqlTransaction transaction)
    {
        @this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the non query operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    public static void ExecuteNonQuery(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters, CommandType commandType)
    {
        @this.ExecuteNonQuery(cmdText, parameters, commandType, null);
    }
}

}