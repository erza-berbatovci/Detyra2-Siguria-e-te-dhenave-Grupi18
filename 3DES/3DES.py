from Crypto.Cipher import DES3
import os

def get_key():
    """Returns a bytes object containing a 24-byte (192-bit) key"""
    key = os.urandom(24)
    return key

def pad_message(message):
    """Pads the message with spaces until its length is a multiple of 8 bytes"""
    remainder = len(message) % 8
    if remainder != 0:
        message += ' ' * (8 - remainder)
    return message

def encrypt(message, key):
    """Encrypts the message using 3DES"""
    cipher = DES3.new(key, DES3.MODE_ECB)
    encrypted_message = cipher.encrypt(message.encode())
    return encrypted_message

def decrypt(encrypted_message, key):
    """Decrypts the encrypted message using 3DES"""
    cipher = DES3.new(key, DES3.MODE_ECB)
    decrypted_message = cipher.decrypt(encrypted_message)
    return decrypted_message.decode().strip()

def main():
    while True:
        print("Do you want to encrypt a message or a file? (type 'message' or 'file', or 'exit' to quit)")
        input_type = input().lower()

        if input_type == 'message':
            message = input("Enter the message to encrypt: ")
            message = pad_message(message)
            key = get_key()
            encrypted_message = encrypt(message, key)
            decrypted_message = decrypt(encrypted_message, key)
            print(f"Original message: {message}")
            print(f"Encrypted message: {encrypted_message.hex()}")
            print(f"Decrypted message: {decrypted_message}")
        elif input_type == 'file':
            filename = input("Enter the name of the file to encrypt: ")
            if not os.path.exists(filename):
                print("File does not exist")
                continue
            with open(filename, 'r') as f:
                message = pad_message(f.read())
            key = get_key()
            encrypted_message = encrypt(message, key)
            decrypted_message = decrypt(encrypted_message, key)
            print(f"Original message: {message}")
            print(f"Encrypted message: {encrypted_message.hex()}")
            print(f"Decrypted message: {decrypted_message}")
        elif input_type == 'exit':
            break
        else:
            print("Invalid input")

if __name__ == '__main__':
    main()