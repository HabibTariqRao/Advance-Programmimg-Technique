import requests
from bs4 import BeautifulSoup
import csv

# URL
url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

# Send request
response = requests.get(url)
soup = BeautifulSoup(response.text, "html.parser")

books = soup.find_all("article", class_="product_pod")

# Create CSV file
with open("books.csv", mode="w", newline="", encoding="utf-8") as file:
    writer = csv.writer(file)
    writer.writerow(["Book Name", "Price", "Rating"])

    for book in books:
        # Book name
        name = book.h3.a["title"]

        # Price
        price = book.find("p", class_="price_color").text

        # Rating
        rating_class = book.find("p", class_="star-rating")["class"]
        rating = rating_class[1]  # e.g., One, Two, Three

        writer.writerow([name, price, rating])

print("Data saved to books.csv")

# Read CSV and display
print("\n--- Book Data ---")

with open("books.csv", mode="r", encoding="utf-8") as file:
    reader = csv.reader(file)
    for row in reader:
        print(row)