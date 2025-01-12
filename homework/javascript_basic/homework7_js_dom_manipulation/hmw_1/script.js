
// Homework 1 - Change the text of all paragraphs and headers with javascript

// Paragraph changes
let firstParagraph = document.getElementsByClassName('paragraph')[0];
firstParagraph.innerText = 'When You Read the Same Sentence 1 Time';

let secondDiv = document.querySelector('.anotherDiv');
let firstDivChild = document.getElementsByClassName('paragraph second')[0];
firstDivChild.innerText = 'When You Read the Same Sentence 2 Times';

// Header changes
let headers = document.querySelectorAll('h1');

let firstHeader = headers[0];
firstHeader.innerText = 'When Your Wi-Fi Is Stronger Than Your Will to Code.';

if (headers.length > 1) {
    let secondHeader = headers[1];
    secondHeader.innerText = "Introvert's Guide to Public Speaking.";
}

let h3Elements = document.querySelectorAll('h3');
if (h3Elements.length > 0) {
    let thirdHeader = h3Elements[0];
    thirdHeader.innerText = "Please Hold, I'm Googling This.";
}

// Text changes
let textElements = document.querySelectorAll('text');
let lastTextElement = textElements[textElements.length - 1];
lastTextElement.innerText = 'When You Read the Same Sentence 3 Times';