// Homework 1
// Write a JavaScript function which accepts a parameter 
// and returns its type and prints it in the console.

function getType(value) {
    console.log(`The type of the given value (${value}) is:`, typeof value);
    return typeof value;
  }
  
  getType({}); // Object
  getType(true); // Boolean
  getType(42); // Number
  getType("Hello"); // String
  getType(undefined); // Undefined

// Homework 2
// Calculate your dog's age based on the 
// conversion rate of 1 human year to 7 dog years and vice versa

function calculateAge(age, type) {
    if (type === 'humanToDog') {
      const dogAge = age * 7;
      console.log(`${age} human years is approximately ${dogAge} dog years.`);
    } else if (type === 'dogToHuman') {
      const humanAge = age / 7;
      console.log(`${age} dog years is approximately ${humanAge} human years.`);
    }
  }  
  
  calculateAge(5, 'humanToDog');
  calculateAge(35, 'dogToHuman');

  //Homework 3 
  // ATM
  
let accountBalance = 1000;

function atm() {
  // Ask user how much money they want to withdraw
  let amountRequested = parseInt(prompt("Enter the amount you want to withdraw:"));

  if (amountRequested > accountBalance) {
    alert("Not enough money");
  } else {
    accountBalance -= amountRequested;
    alert(`You withdrew $${amountRequested}. Remaining balance: $${accountBalance}`);
  }
}

atm();