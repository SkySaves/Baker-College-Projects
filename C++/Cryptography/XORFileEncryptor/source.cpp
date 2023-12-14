#include <fstream>
#include <iostream>
#include <string>
using namespace std;

void processFile(ifstream& ifs, ofstream& ofs, string password) {
    char c;
    size_t passIndex = 0;
    // loop reading characters from ifs
    while (ifs.get(c)) {
        // Encrypt/decrypt using XOR with password
        char encryptedChar = c ^ password[passIndex];
        // Put modified character to ofs
        ofs.put(encryptedChar);
        // Move to the next character in the password
        // If we reach the end of the password, start again from the beginning
        passIndex = (passIndex + 1) % password.size();
    }
}

// Entry point of the program.
int main(int argc, char** argv) {
    // Check if the number of command-line arguments is exactly four (including the program name).
    if (argc != 4) {
        // If not, print the correct usage syntax and exit the program with an error code.
        cout << "Syntax: " << argv[0] << " {input file} {output file} {password}" << endl;
        exit(1);
    }
    // Store the input file name provided as the first argument.
    string in_file(argv[1]);
    // Store the output file name provided as the second argument.
    string out_file(argv[2]);
    // Store the password provided as the third argument.
    string password(argv[3]);

    // Try block to attempt the following operations which might throw exceptions.
    try {
        // Open the input file in binary mode to read the data as binary rather than text.
        ifstream ifh(in_file.c_str(), ios_base::binary);
        // Check if the input file stream is good (i.e., no errors occurred opening the file).
        if (!ifh.good()) {
            // If there's a problem opening the input file, throw an exception.
            throw ios_base::failure("Problem opening input file!");
        }
        // Open the output file in binary mode to write the data as binary.
        ofstream ofh(out_file.c_str(), ios_base::binary);
        // Check if the output file stream is good (i.e., no errors occurred opening the file).
        if (!ofh.good()) {
            // If there's a problem opening the output file, throw an exception.
            throw ios_base::failure("Problem opening output file!");
        }
        // Call the processFile function to perform encryption/decryption.
        processFile(ifh, ofh, password);
        // Close the input file stream.
        ifh.close();
        // Close the output file stream.
        ofh.close();
    }
    // Catch block to handle exceptions of type ios_base::failure.
    catch (ios_base::failure& ex) {
        // If an exception is caught, print the error message.
        cout << "Error: " << ex.what() << endl;
    }
    // Return 0 to indicate the program ended successfully.
    return 0;
}



// To test use the test.txt located in the build folder and the commands:
//Project2b.exe test.txt encetest.bin password (this will encrypt)
//Project2b.exe encetest.bin decryptedtest.txt password (this will decrypt)
//comp test.txt decryptedtest.txt (this will compare text to confirm)