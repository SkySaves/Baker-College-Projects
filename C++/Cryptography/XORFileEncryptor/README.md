# C++ Project: File Encryption and Decryption Tool
### Description
This C++ project presents a simple yet effective file encryption and decryption tool. It utilizes the XOR cipher, a basic form of encryption, to transform the contents of a file based on a user-provided password. The program is designed to handle binary data, making it versatile for various file types.
### Key Features
* XOR Encryption: Implements the XOR cipher method, which encrypts or decrypts data using a password. Each character in the file is XORed with a character from the password. When the end of the password is reached, it cycles back to the beginning, ensuring continuous encryption or decryption.
* Binary File Processing: Capable of processing binary files, allowing encryption and decryption of a wide range of file formats beyond plain text.
* Command-Line Interface: Operates through command-line arguments, offering a straightforward way to specify input files, output files, and the encryption/decryption password.
* Error Handling: Includes robust error handling to manage issues like file access errors, ensuring the user is informed of any problems during file operations.

### Usage
The tool is used via command-line arguments in the following format:
* To encrypt: XORFileEncryptor.exe [input file] [output file] [password]
* To decrypt: XORFileEncryptor.exe [encrypted file] [output file] [password]

For example:

* Encrypt test.txt to encetest.bin with password password: XORFileEncryptor.exe test.txt encetest.bin password
* Decrypt encetest.bin to decryptedtest.txt with password password: XORFileEncryptor.exe encetest.bin decryptedtest.txt password

A comparison command like comp test.txt decryptedtest.txt can be used to verify the integrity of the encryption and decryption process.
### Project Structure
* main.cpp: Contains the main logic for file handling, encryption/decryption, and command-line interface.
* test.txt: A sample text file used for testing the encryption and decryption process.
* encetest.bin: The output file after encryption.
* decryptedtest.txt: The output file after decryption, used for comparison with the original test.txt

This project is an excellent demonstration of basic file handling, binary data processing, and encryption techniques in C++. It serves as a practical tool for secure file transformation and showcases the application of fundamental C++ programming concepts.
