
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Runtime.Caching

Public Module Extensions_1

    ''' <summary>A MemoryCache extension method that adds an or get existing.</summary>
    ''' <typeparam name="TValue">Type of the value.</typeparam>
    ''' <param name="cache">The cache to act on.</param>
    ''' <param name="key">The key.</param>
    ''' <param name="value">The value.</param>
    ''' <returns>A TValue.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function AddOrGetExisting(Of TValue)(cache As MemoryCache, key As String, value As TValue) As TValue
        Dim item As Object = If(cache.AddOrGetExisting(key, value, New CacheItemPolicy()), value)

        Return DirectCast(item, TValue)
    End Function

    ''' <summary>A MemoryCache extension method that adds an or get existing.</summary>
    ''' <typeparam name="TValue">Type of the value.</typeparam>
    ''' <param name="cache">The cache to act on.</param>
    ''' <param name="key">The key.</param>
    ''' <param name="valueFactory">The value factory.</param>
    ''' <returns>A TValue.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function AddOrGetExisting(Of TValue)(cache As MemoryCache, key As String, valueFactory As Func(Of String, TValue)) As TValue
        Dim lazy = New Lazy(Of TValue)(Function() valueFactory(key))

        Dim item As Lazy(Of TValue) = If(DirectCast(cache.AddOrGetExisting(key, lazy, New CacheItemPolicy()), Lazy(Of TValue)), lazy)

        Return item.Value
    End Function

    ''' <summary>A MemoryCache extension method that adds an or get existing.</summary>
    ''' <typeparam name="TValue">Type of the value.</typeparam>
    ''' <param name="cache">The cache to act on.</param>
    ''' <param name="key">The key.</param>
    ''' <param name="valueFactory">The value factory.</param>
    ''' <param name="policy">The policy.</param>
    ''' <param name="regionName">(Optional) name of the region.</param>
    ''' <returns>A TValue.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function AddOrGetExisting(Of TValue)(cache As MemoryCache, key As String, valueFactory As Func(Of String, TValue), policy As CacheItemPolicy, Optional regionName As String = Nothing) As TValue
        Dim lazy = New Lazy(Of TValue)(Function() valueFactory(key))

        Dim item As Lazy(Of TValue) = If(DirectCast(cache.AddOrGetExisting(key, lazy, policy, regionName), Lazy(Of TValue)), lazy)

        Return item.Value
    End Function

    ''' <summary>A MemoryCache extension method that adds an or get existing.</summary>
    ''' <typeparam name="TValue">Type of the value.</typeparam>
    ''' <param name="cache">The cache to act on.</param>
    ''' <param name="key">The key.</param>
    ''' <param name="valueFactory">The value factory.</param>
    ''' <param name="absoluteExpiration">The policy.</param>
    ''' <param name="regionName">(Optional) name of the region.</param>
    ''' <returns>A TValue.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function AddOrGetExisting(Of TValue)(cache As MemoryCache, key As String, valueFactory As Func(Of String, TValue), absoluteExpiration As DateTimeOffset, Optional regionName As String = Nothing) As TValue
        Dim lazy = New Lazy(Of TValue)(Function() valueFactory(key))

        Dim item As Lazy(Of TValue) = If(DirectCast(cache.AddOrGetExisting(key, lazy, absoluteExpiration, regionName), Lazy(Of TValue)), lazy)

        Return item.Value
    End Function
End Module


