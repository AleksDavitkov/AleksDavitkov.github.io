// ==== Calculator ====

// Variables
let currentExpression = '';
let display = document.getElementById('display');

// Functions
function clearDisplay() {
    currentExpression = '';
    display.value = '';
}

function adjustFontSize() {
    const maxLength = 15;
    const maxFontSize = 3;
    const minFontSize = 1.5;

    let fontSize = maxFontSize;

    if (currentExpression.length > maxLength) {
        fontSize = Math.max(minFontSize, maxFontSize - (currentExpression.length - maxLength) * 0.1);
    }

    display.style.fontSize = `${fontSize}rem`;
}

function appendToDisplay(value) {
    const operators = ['+', '-', '*', '/'];

    if (operators.includes(value)) {
        const lastChar = currentExpression.slice(-1);
        if (operators.includes(lastChar)) {
            // Replace the last operator with the new one
            currentExpression = currentExpression.slice(0, -1) + value;
            display.value = currentExpression;
            adjustFontSize();
            return;
        }
    }

    // Decimal handling
    if (value === '.') {
        const lastNumber = currentExpression.split(/[\+\-\*\/]/).pop();

        // Prevent adding '.' if the current number already has one
        if (lastNumber.includes('.')) {
            return;
        }
    }

    currentExpression += value;
    display.value = currentExpression;
    adjustFontSize();
}

function calculate() {
    const lastChar = currentExpression.slice(-1);
    const operators = ['+', '-', '*', '/'];

    // Prevent calculation if the expression ends with an operator
    if (operators.includes(lastChar)) {
        display.value = 'Error';
        return;
    }

    try {
        const result = new Function('return ' + currentExpression)();

        // Handle division by zero
        if (result === Infinity || result === -Infinity) {
            display.value = 'Error: Division by Zero';
        } else {
            display.value = result;
            currentExpression = result.toString();
        }
    } catch (error) {
        display.value = 'Error'; // Handle invalid input
    }
}

function backspace() {
    currentExpression = currentExpression.slice(0, -1);
    display.value = currentExpression;
}

// Event listener for key pressing
document.addEventListener('keydown', handleKeyPress);

function handleKeyPress(event) {
    const key = event.key;
    const validKeys = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/', '.', 'Enter', 'Backspace'];

    if (validKeys.includes(key)) {
        if (key === 'Enter') {
            calculate();
        } else if (key === 'Backspace') {
            backspace();
        } else {
            appendToDisplay(key);
        }
    }
}