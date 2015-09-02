// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Data;
using System.Data.SQLite;

public static partial class Extensions
{
    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText, SQLiteParameter[] parameters, CommandType commandType, SQLiteTransaction transaction)
    {
        using (SQLiteCommand command = @this.CreateCommand())
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
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, Action<SQLiteCommand> commandFactory)
    {
        using (SQLiteCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            return command.ExecuteReader();
        }
    }

    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText)
    {
        return @this.ExecuteReader(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText, SQLiteTransaction transaction)
    {
        return @this.ExecuteReader(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText, CommandType commandType)
    {
        return @this.ExecuteReader(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText, CommandType commandType, SQLiteTransaction transaction)
    {
        return @this.ExecuteReader(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText, SQLiteParameter[] parameters)
    {
        return @this.ExecuteReader(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText, SQLiteParameter[] parameters, SQLiteTransaction transaction)
    {
        return @this.ExecuteReader(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A SQLiteConnection extension method that executes the reader operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A SQLiteDataReader.</returns>
    public static SQLiteDataReader ExecuteReader(this SQLiteConnection @this, string cmdText, SQLiteParameter[] parameters, CommandType commandType)
    {
        return @this.ExecuteReader(cmdText, parameters, commandType, null);
    }
}