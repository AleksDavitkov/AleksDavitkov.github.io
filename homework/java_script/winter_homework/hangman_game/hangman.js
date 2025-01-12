// ==== Hangman Mini-Game ====

// Word list
const words = ["javascript", "hangman", "programming", "developer", "browser"];

// DOM Elements
const wordDisplay = document.getElementById("word");
const attemptsDisplay = document.getElementById("attempts");
const guessedDisplay = document.getElementById("guessed");
const messageDisplay = document.getElementById("message");
const inputField = document.getElementById("letterInput");
const guessButton = document.getElementById("guessButton");
const hintButton = document.getElementById("hintButton");
const resetButton = document.getElementById("resetButton");

// Game state
let randomWord, hiddenWord, remainingAttempts, guessedLetters, hintCount;

// Initialize a new game
function startNewGame() {
  randomWord = words[Math.floor(Math.random() * words.length)];
  hiddenWord = Array(randomWord.length).fill('_');
  remainingAttempts = 6;
  guessedLetters = [];
  hintCount = 0;

  updateDisplay();
  enableGameButtons();
  messageDisplay.textContent = "";
}

// Update the UI display
function updateDisplay() {
  wordDisplay.textContent = hiddenWord.join(" ");
  attemptsDisplay.textContent = `Remaining Attempts: ${remainingAttempts}`;
  guessedDisplay.textContent = `Guessed Letters: ${guessedLetters.join(", ")}`;
}

// Guess a letter
function guessLetter() {
  const letter = inputField.value.toLowerCase();
  inputField.value = "";

  if (letter === "" || !/^[a-z]$/.test(letter)) {
    messageDisplay.textContent = "Please enter a valid letter.";
    return;
  }

  if (guessedLetters.includes(letter)) {
    messageDisplay.textContent = "You've already guessed that letter!";
    return;
  }

  guessedLetters.push(letter);

  if (randomWord.includes(letter)) {
    for (let i = 0; i < randomWord.length; i++) {
      if (randomWord[i] === letter) hiddenWord[i] = letter;
    }
    messageDisplay.textContent = "Good guess!";
  } else {
    remainingAttempts--;
    messageDisplay.textContent = "Wrong guess!";
  }

  updateDisplay();
  checkGameOver();
}

// Check if the game is over
function checkGameOver() {
  if (!hiddenWord.includes("_")) {
    messageDisplay.textContent = "Congratulations! You've guessed the word!";
    disableGameButtons();
    resetButton.disabled = false; // Enable reset button when game ends
  } else if (remainingAttempts === 0) {
    messageDisplay.textContent = `Game over! The word was: ${randomWord}`;
    disableGameButtons();
    resetButton.disabled = false; // Enable reset button when game ends
  }
}

// Provide a hint
function giveHint() {
  if (hintCount >= 2) {
    messageDisplay.textContent = "No more hints available!";
    return;
  }

  const remainingLetters = randomWord.split("").filter((char, index) => !guessedLetters.includes(char) && hiddenWord[index] === "_");
  if (remainingLetters.length > 0) {
    const randomHintLetter = remainingLetters[Math.floor(Math.random() * remainingLetters.length)];
    for (let i = 0; i < randomWord.length; i++) {
      if (randomWord[i] === randomHintLetter) hiddenWord[i] = randomHintLetter;
    }
    updateDisplay();
    messageDisplay.textContent = `Hint: The letter is '${randomHintLetter}'`;
    hintCount++;
  } else {
    messageDisplay.textContent = "No hints left!";
  }
}

// Enable all game buttons
function enableGameButtons() {
  guessButton.disabled = false;
  inputField.disabled = false;
  hintButton.disabled = false;
  resetButton.disabled = false;
}

// Disable all game buttons
function disableGameButtons() {
  guessButton.disabled = true;
  inputField.disabled = true;
  hintButton.disabled = true;
  resetButton.disabled = true;
}

// Event Listeners
guessButton.addEventListener("click", guessLetter);
hintButton.addEventListener("click", giveHint);
resetButton.addEventListener("click", startNewGame);

// Start the game when the page loads
startNewGame();