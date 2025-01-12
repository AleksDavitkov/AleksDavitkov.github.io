// Get the year from Input
let year = parseInt(prompt("Please enter your Year of Birth:"));

let zodiacIndex = (year - 4) % 12;

// Determine the Chinese Zodiac
let zodiac = "";
switch (zodiacIndex) {
    case 0:
        zodiac = "Rat";
        break;
    case 1:
        zodiac = "Ox";
        break;
    case 2:
        zodiac = "Tiger";
        break;
    case 3:
        zodiac = "Rabbit";
        break;
    case 4:
        zodiac = "Dragon";
        break;
    case 5:
        zodiac = "Snake";
        break;
    case 6:
        zodiac = "Horse";
        break;
    case 7:
        zodiac = "Goat";
        break;
    case 8:
        zodiac = "Monkey";
        break;
    case 9:
        zodiac = "Rooster";
        break;
    case 10:
        zodiac = "Dog";
        break;
    case 11:
        zodiac = "Pig";
        break;
    default:
        zodiac = "Error";
}

// Display the result
alert(`Your Chinese Zodiac sign is: ${zodiac}`);