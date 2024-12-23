
// Homework 2 - Print all numbers from an Array and Sum

const numbers = [2, 4, 5, 6, 7];

const numberList = document.getElementById('numberList');
const sumElement = document.getElementById('sum');
const equationElement = document.getElementById('equation');

let sum = 0;

// Loop through the array and create <li> elements
numbers.forEach(number => {
  const listItem = document.createElement('li');
  listItem.textContent = number;
  numberList.appendChild(listItem);
  sum += number;
});

sumElement.textContent = `Sum: ${sum}`;

const equation = numbers.join(' + ') + ' = ' + sum;
equationElement.textContent = `Equation: ${equation}`;