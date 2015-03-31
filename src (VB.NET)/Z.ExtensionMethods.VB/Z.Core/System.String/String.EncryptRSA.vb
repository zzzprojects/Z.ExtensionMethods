
'' Copyright (c) 2015 ZZZ Projects. All rights reserved
'' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
'' Website: http://www.zzzprojects.com/
'' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
'' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

'Imports System.Security.Cryptography
'Imports System.Text

'Public Module Extensions_492

'	''' <summary>
'	'''     A string extension method that encrypts the string.
'	''' </summary>
'	''' <param name="this">The @this to act on.</param>
'	''' <param name="key">The key.</param>
'	''' <returns>The encrypted string.</returns>
'	<System.Runtime.CompilerServices.Extension> _
'	Public Function EncryptRSA(this As String, key As String) As String
'		Dim cspp = New CspParameters() With { _
'			Key .KeyContainerName = key _
'		}
'		Dim rsa = New RSACryptoServiceProvider(cspp) With { _
'			Key .PersistKeyInCsp = True _
'		}
'		Dim bytes As Byte() = rsa.Encrypt(Encoding.UTF8.GetBytes(this), True)

'		Return BitConverter.ToString(bytes)
'	End Function
'End Module


