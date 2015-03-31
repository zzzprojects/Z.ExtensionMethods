
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data.Entity.Design.PluralizationServices
Imports System.Globalization

Public Module Extensions_536

	''' <summary>
	'''     A string extension method that converts the @this to a plural.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToPlural(this As String) As String
		Return PluralizationService.CreateService(New CultureInfo("en-US")).Pluralize(this)
	End Function

	''' <summary>
	'''     A string extension method that converts the @this to a plural.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cultureInfo">Information describing the culture.</param>
	''' <returns>@this as a string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToPlural(this As String, cultureInfo As CultureInfo) As String
		Return PluralizationService.CreateService(cultureInfo).Pluralize(this)
	End Function
End Module


