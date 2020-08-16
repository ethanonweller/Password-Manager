# Password-Vault
Locally store login information for all of your services in a secure application

1. How is the login information stored securely?
* The application creates a SHA512 encrypted hash of your data that is then written to a local text file. Here is a code snippet from a part of the hashing procedure that I shamelessly stole from [here](https://www.codeproject.com/Articles/12092/Encrypt-Decrypt-Files-in-VB-NET-Using-Rijndael)

```vb.net
'*************************
'** Create A Key
'*************************

Private Function CreateKey(ByVal strPassword As String) As Byte()
    'Convert strPassword to an array and store in chrData.
    Dim chrData() As Char = strPassword.ToCharArray
    'Use intLength to get strPassword size.
    Dim intLength As Integer = chrData.GetUpperBound(0)
    'Declare bytDataToHash and make it the same size as chrData.
    Dim bytDataToHash(intLength) As Byte
    
    'Use For Next to convert and store chrData into bytDataToHash.
    For i As Integer = 0 To chrData.GetUpperBound(0)
        bytDataToHash(i) = CByte(Asc(chrData(i)))
    Next

    'Declare what hash to use.
    Dim SHA512 As New System.Security.Cryptography.SHA512Managed
    'Declare bytResult, Hash bytDataToHash and store it in bytResult.
    Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
    'Declare bytKey(31).  It will hold 256 bits.
    Dim bytKey(31) As Byte
    
    'Use For Next to put a specific size (256 bits) of 
    'bytResult into bytKey. The 0 To 31 will put the first 256 bits
    'of 512 bits into bytKey.
    For i As Integer = 0 To 31
        bytKey(i) = bytResult(i)
    Next

    Return bytKey 'Return the key.
End Function
```


2. Where is this file located?
* Wherever you install the *Password Vault* application. Most likely C:/*

3. How do I know this application does not send my logins to you in some way?
* You're free to look through the source code and verify that for yourself





