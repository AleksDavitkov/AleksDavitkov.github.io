
// Homework 1 - Tell a story

function tellStory([name, mood, activity]) {
    console.log(`This is ${name}. ${name} is a nice person. Today he is ${mood}. He's been ${activity} code all day... The end.`);
}

tellStory(['Aleks', 'happy', 'writing']);

// Homework 2 - Array of 5 numbers as arguments returning sum

function returnSum(numbers) {
    let sumNum = 0;
    for (let i = 0; i < numbers.length; i++) {
        sumNum += numbers[i];
    }
    console.log(sumNum);
}

returnSum([3, 5, 7, 9, 2]);

// Homework 3 - Array of custom strings

function stringsArray(array) {
    let sumStrings = '';
    for(let i = 0; i < array.length; i++) {
        sumStrings += array[i] + ' ';
    }
    return sumStrings;
}

console.log(stringsArray(['Hello', 'there', 'students', 'of', 'Qinshift']));

// Homework 4 - Looping structures

function loopingNumbers() {
    let output = "";
    for (let i = 1; i <= 20; i++) {
        if (i % 2 === 0) {
            output += i + "\n"; 
        } else {
            output += i + " ";
        }
    }
    console.log(output);
}

loopingNumbers();

// Homework 5 with Bonus - Min, Max and Sum

function numbersMinMax(arr) {
    const numbers = arr.filter(item => typeof item === 'number');

    if (numbers.length === 0) {
        return 'No numeric values in the array!';
    }

    const maxNum = Math.max(...numbers);
    const minNum = Math.min(...numbers);

    const sum = maxNum + minNum;

    return `Max: ${maxNum}, Min: ${minNum}, Sum: ${sum}`;
}

console.log(numbersMinMax([3, 5, 'a', 6, null, 8, 11, undefined, true]));
console.log(numbersMinMax(['a', null, undefined, true]));
console.log(numbersMinMax([7, -3, 15, 0, 10]));

// Homework 6 - Looping structures (names)

function names(firstNames, lastNames) {
    const fullNames = [];
    for (let i = 0; i < firstNames.length; i++) {
        fullNames.push(`${i + 1}. ${firstNames[i]} ${lastNames[i]}`);
    }
    return fullNames
}

const first = ["Bob", "Jill", "Aleks"];
const last = ["Gregory", "Wurtz", "Davitkov"];

console.log(names(first, last));