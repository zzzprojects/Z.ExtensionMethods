// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Data;
using System.Data.SqlServerCe;
using Z.Data.SQLite;

public static partial class Extensions
{
    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters, CommandType commandType, SqlCeTransaction transaction)
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

            return command.ExecuteScalar().To<T>();
        }
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, Action<SqlCeCommand> commandFactory)
    {
        using (SqlCeCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            return command.ExecuteScalar().To<T>();
        }
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText, SqlCeTransaction transaction)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText, CommandType commandType, SqlCeTransaction transaction)
    {
        return @this.ExecuteScalarTo<T>(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters)
    {
        return @this.ExecuteScalarTo<T>(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters, SqlCeTransaction transaction)
    {
        return @this.ExecuteScalarTo<T>(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SqlCeConnection extension method that executes the scalar operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>An object.</returns>
    public static T ExecuteScalarTo<T>(this SqlCeConnection @this, string cmdText, SqlCeParameter[] parameters, CommandType commandType)
    {
        return @this.ExecuteScalarTo<T>(cmdText, parameters, commandType, null);
    }
}