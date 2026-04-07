import socket
import sqlite3
import json
import uuid

# Create database
conn = sqlite3.connect("customers.db")
cursor = conn.cursor()

cursor.execute("""
CREATE TABLE IF NOT EXISTS customers (
    id TEXT PRIMARY KEY,
    name TEXT,
    address TEXT,
    pps TEXT,
    license TEXT
)
""")
conn.commit()

# Create server socket
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind(("localhost", 5000))
server.listen(1)

print("Server is running and waiting for connection...")

while True:
    client_socket, addr = server.accept()
    print(f"Connected with {addr}")

    data = client_socket.recv(1024).decode()

    customer = json.loads(data)

    # Generate unique ID
    reg_id = str(uuid.uuid4())[:8]

    # Insert into database
    cursor.execute("INSERT INTO customers VALUES (?, ?, ?, ?, ?)",
                   (reg_id, customer["name"], customer["address"],
                    customer["pps"], customer["license"]))
    conn.commit()

    # Send registration number back
    client_socket.send(reg_id.encode())

    print(f"Customer stored with ID: {reg_id}")

    client_socket.close()