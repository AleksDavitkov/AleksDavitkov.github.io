
// Homework 1 - Object Animal with 2 Properties and a Method

let penguin = {
    name: "Skipper",
    kind: "Avian",
    speak: function(message) {
        console.log(`${this.name} says: ${message}`);
    }
};

let message = prompt('What does the penguin say?');
penguin.speak(message);
penguin.speak(`Kowalski! Analysis`);

// Homework 2 -  Display the reading status of a Book

function BooksToRead(title, author, readingStatus) {
    this.title = title;
    this.author = author;
    this.readingStatus = readingStatus;

    this.bookStatus = function() {
        if (this.readingStatus === true) {
            console.log(`Already read '${this.title}' by ${this.author}.`);
        } else {
            console.log(`You still need to read '${this.title}' by ${this.author}.`);
        }
    };
}

// Prompt for book details
let title = prompt("Enter the title of the book:");
let author = prompt("Enter the author of the book:");
let readingStatusInput = prompt("Have you read this book? (yes / no / y / n)").toLowerCase();
let readingStatus = (readingStatusInput === "yes" || readingStatusInput === "y");

// Validate input for reading status
while (readingStatusInput !== "yes" && readingStatusInput !== "no" && readingStatusInput !== "y" && readingStatusInput !== "n") {
    readingStatusInput = prompt("Invalid input. Please enter yes / no / y / n:").toLowerCase();
}

// Create a new book object from user input
let book1 = new BooksToRead(title, author, readingStatus);
book1.bookStatus();

// Without prompt, creating a predefined book object
let book2 = new BooksToRead(`The Robots of Dawn`, `Isaac Asimov`, false);
book2.bookStatus();