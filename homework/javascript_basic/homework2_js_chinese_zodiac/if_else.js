// Get the year from Input
let year = parseInt(prompt("Please enter your Year of Birth:"));

let zodiacIndex = (year - 4) % 12;

// Determine the Chinese Zodiac
let zodiac = "";

if (zodiacIndex === 0) {
    zodiac = "Rat";
} else if (zodiacIndex === 1) {
    zodiac = "Ox";
} else if (zodiacIndex === 2) {
    zodiac = "Tiger";
} else if (zodiacIndex === 3) {
    zodiac = "Rabbit";
} else if (zodiacIndex === 4) {
    zodiac = "Dragon";
} else if (zodiacIndex === 5) {
    zodiac = "Snake";
} else if (zodiacIndex === 6) {
    zodiac = "Horse";
} else if (zodiacIndex === 7) {
    zodiac = "Goat";
} else if (zodiacIndex === 8) {
    zodiac = "Monkey";
} else if (zodiacIndex === 9) {
    zodiac = "Rooster";
} else if (zodiacIndex === 10) {
    zodiac = "Dog";
} else if (zodiacIndex === 11) {
    zodiac = "Pig";
} else {
    zodiac = "Error";
}

// Display the result
alert(`Your Chinese Zodiac sign is: ${zodiac}`);