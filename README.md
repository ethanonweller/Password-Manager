# Password-Vault
Locally store login information for all of your services in a secure application

1. How is the login information stored securely?
* The application creates a SHA512 encrypted hash of your data that is then written to a local text file. Here is the code snippet I for the hashing procedure I took shamelessly stole from [here](https://www.codeproject.com/Articles/12092/Encrypt-Decrypt-Files-in-VB-NET-Using-Rijndael)


2. Where is this file located?
* Wherever you install the *Password Vault* application. Most likely C:/*

3. How do I know this application does not send my logins to you in some way?
* You're free to look through the source code and verify that for yourself





