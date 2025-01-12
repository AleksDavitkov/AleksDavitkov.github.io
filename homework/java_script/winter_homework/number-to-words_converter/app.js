// ==== Number to Words Converter ====

// Functions

// Declaration
function convertNumberToWords(num) {
    if (isNaN(num) || num < 0 || num > 1000000) {
      return `<span class="error">Error: Please enter a valid number between 0 and 1,000,000.</span>`;
    }
    
    if (num === 0) return "Zero"; // Handle the case for 0
    if (num === 1000000) return "One Million";

    const belowTen = ["", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
    const belowTwenty = ["Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
    const belowHundred = ["", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];

// Converting convention
function convertToWords(n) {
    let words = "";
    if (n >= 100) {
        words += `${belowTen[Math.floor(n / 100)]} Hundred `;
        n %= 100;
    }
    if (n >= 20) {
        words += `${belowHundred[Math.floor(n / 10)]} `;
        n %= 10;
    }
    if (n >= 10) {
        words += `${belowTwenty[n - 10]} `;
        n = 0;
    }
    if (n > 0) {
        words += `${belowTen[n]} `;
    }
        return words.trim();
    }

    let result = "";
    const thousands = Math.floor(num / 1000);
    const remainder = num % 1000;

    if (thousands > 0) {
        result += `${convertToWords(thousands)} Thousand `;
    }
    if (remainder > 0) {
        result += `${convertToWords(remainder)}`;
    }
    return result.trim();
}

// Display result
function convertAndDisplay() {
    const input = document.getElementById("numberInput").value;
    const number = parseInt(input, 10);
    const resultDiv = document.getElementById("result");

    const convertedText = convertNumberToWords(number);
    resultDiv.innerHTML = convertedText;
}