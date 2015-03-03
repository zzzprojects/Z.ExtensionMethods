using System;
using System.Data;
using System.Data.SqlServerCe;

public static partial class Extensions
{
    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters, CommandType commandType, SqlCeTransaction transaction)
    {
        using (SqlCeCommand command = @this.CreateCommand())
        {
            command.CommandText = cmdText;
            command.CommandType = commandType;
            command.Transaction = transaction;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            return command.ExecuteReader();
        }
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, Action<SqlCeCommand> commandFactory)
    {
        using (SqlCeCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            return command.ExecuteReader();
        }
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText)
    {
        return @this.ExecuteReader(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText, SqlCeTransaction transaction)
    {
        return @this.ExecuteReader(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteReader(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText, CommandType commandType, SqlCeTransaction transaction)
    {
        return @this.ExecuteReader(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters)
    {
        return @this.ExecuteReader(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters, SqlCeTransaction transaction)
    {
        return @this.ExecuteReader(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A SqlCeDataReader.</returns>
    public static SqlCeDataReader ExecuteReader(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters, CommandType commandType)
    {
        return @this.ExecuteReader(cmdText, parameters, commandType, null);
    }
}