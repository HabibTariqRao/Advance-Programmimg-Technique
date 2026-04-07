import socket
import json

# Collect user input
print("=== EasyDrive Registration ===")

name = input("Enter Name: ")
address = input("Enter Address: ")
pps = input("Enter PPS Number: ")
license_doc = input("Enter Driving License: ")

# Create data dictionary
customer = {
    "name": name,
    "address": address,
    "pps": pps,
    "license": license_doc
}

# Convert to JSON
data = json.dumps(customer)

# Connect to server
client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
client.connect(("localhost", 5000))

# Send data
client.send(data.encode())

# Receive registration ID
reg_id = client.recv(1024).decode()

print(f"\nRegistration Successful! Your ID is: {reg_id}")

client.close()