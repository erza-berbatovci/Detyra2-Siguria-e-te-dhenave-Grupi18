# Detyra2-Siguria-e-te-dhenave-Grupi18
3DES Encryption and Decryption using C#
This project demonstrates how to perform 3DES encryption and decryption on text and files using C#.

TripleDES (Triple Data Encryption Standard) is a symmetric-key block cipher algorithm that encrypts data in blocks of 64 bits, and uses a key size of 168 bits. It is an improvement over the original DES algorithm, which had a key size of only 56 bits and was shown to be vulnerable to brute-force attacks.

TripleDES has been widely used in various industries, including finance, healthcare, and government, to protect sensitive data such as credit card numbers, medical records, and classified information. However, in recent years, more advanced encryption algorithms such as AES (Advanced Encryption Standard) have become more popular due to their improved security and efficiency.

The program first imports several libraries needed for the program to work correctly, including _3DES, System.IO, System, System.Reflection, and System.Security.Cryptography.

The Main method of the program prompts the user to choose between encrypting a text or a file, and then calls the EncryptDecrypt method, passing in the user's choice.

The EncryptDecrypt method checks whether the user wants to encrypt a text or a file, and then performs the encryption and decryption using the TripleDes.Encrypt and TripleDes.Decrypt methods. If the user chooses to encrypt a file, the program reads the contents of a file named "text.txt" located in the same directory as the program.

After the encryption and decryption is performed, the program outputs the original text, encrypted text, and decrypted text to the console.

The program then prompts the user to decide whether to continue running the program and encrypting/decrypting more text or files. If the user enters "y", the program prompts the user again to choose between encrypting a text or a file, and the process repeats. If the user enters "n", the program ends.




To run this C# code, you will need a development environment such as Visual Studio or .NET Core installed on your computer. Here are the steps to run the code:

Open a text editor (such as Notepad) or your development environment.
Copy and paste the code into the text editor.
Save the file with a ".cs" extension (e.g., TripleDES.cs).
Open the command prompt or terminal on your computer.
Navigate to the directory where you saved the file using the "cd" command.
Compile the code by entering the command "csc TripleDES.cs" in the command prompt.
Run the program by entering the command "TripleDES.exe" in the command prompt.
Follow the instructions on the console to encrypt and decrypt text or a file using TripleDES.
To exit the program, enter "n" when prompted to continue the execution.