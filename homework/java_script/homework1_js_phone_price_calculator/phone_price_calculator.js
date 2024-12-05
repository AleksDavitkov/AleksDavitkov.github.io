let phone = 119.95;
let taxRate = 0.05;

// calculate the total of 30 phones + tax for each sold
let totalPrice = (30 * phone) * (1 + taxRate);

// display in the log:
console.log("Total price including tax: $" + totalPrice.toFixed(2));