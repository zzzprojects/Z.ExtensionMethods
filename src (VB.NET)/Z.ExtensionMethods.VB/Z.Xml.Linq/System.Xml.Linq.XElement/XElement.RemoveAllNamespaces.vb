
'' Copyright (c) 2015 ZZZ Projects. All rights reserved
'' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
'' Website: http://www.zzzprojects.com/
'' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
'' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

'Imports System.Linq
'Imports System.Xml.Linq

'Public Module Extensions_888

'	''' <summary>
'	'''     An XElement extension method that removes all namespaces described by @this.
'	''' </summary>
'	''' <param name="this">The @this to act on.</param>
'	''' <returns>An XElement.</returns>
'	<System.Runtime.CompilerServices.Extension> _
'	Public Function RemoveAllNamespaces(this As XElement) As XElement
'		Return New XElement(this.Name.LocalName, (From n In this.Nodes()(If((TypeOf n Is XElement), RemoveAllNamespaces(TryCast(n, XElement)), n))), If((this.HasAttributes), (From a In this.Attributes()a), Nothing))
'	End Function
'End Module


