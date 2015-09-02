// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Data;
using MySql.Data.MySqlClient;
using Z.Data.MySql;

public static partial class Extensions
{
    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters, CommandType commandType, MySqlTransaction transaction) where T : new()
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

            using (IDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                return reader.ToEntity<T>();
            }
        }
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="commandFactory">The command factory.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, Action<MySqlCommand> commandFactory) where T : new()
    {
        using (MySqlCommand command = @this.CreateCommand())
        {
            commandFactory(command);

            using (IDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                return reader.ToEntity<T>();
            }
        }
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText) where T : new()
    {
        return @this.ExecuteEntity<T>(cmdText, null, CommandType.Text, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText, MySqlTransaction transaction) where T : new()
    {
        return @this.ExecuteEntity<T>(cmdText, null, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText, CommandType commandType) where T : new()
    {
        return @this.ExecuteEntity<T>(cmdText, null, commandType, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText, CommandType commandType, MySqlTransaction transaction) where T : new()
    {
        return @this.ExecuteEntity<T>(cmdText, null, commandType, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters) where T : new()
    {
        return @this.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, null);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="transaction">The transaction.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters, MySqlTransaction transaction) where T : new()
    {
        return @this.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, transaction);
    }

    /// <summary>
    ///     A MySqlConnection extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">Options for controlling the operation.</param>
    /// <param name="commandType">Type of the command.</param>
    /// <returns>A T.</returns>
    public static T ExecuteEntity<T>(this MySqlConnection @this, string cmdText, MySqlParameter[] parameters, CommandType commandType) where T : new()
    {
        return @this.ExecuteEntity<T>(cmdText, parameters, commandType, null);
    }
}