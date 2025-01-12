// Homework - Exercise 3 (Phone Book)

// Array
const contacts = [];

// Set variables to reference the inputs and button
const nameInput = document.getElementById('name');
const lastNameInput = document.getElementById('lastname');
const phoneInput = document.getElementById('phone');
const saveButton = document.getElementById('saveButton');
const contactsTableBody = document.getElementById('contactsTableBody');

// Function to handle Save button on click
saveButton.onclick = function(event) {
    // Prevent from submitting
    event.preventDefault();

    const name = nameInput.value;
    const lastName = lastNameInput.value;
    const phone = phoneInput.value;

    // Validation
    if (name === '' || lastName === '' || phone === '') {
        alert('Please enter all fields');
        return;
    }

    if (isNaN(phone)) {
        alert('Please enter a valid number');
        return;
    }

    const newContact = {
        firstName: name,
        lastName: lastName,
        phoneNumber: phone,
    };

    // Push the new contact to the table
    contacts.push(newContact);

    // Update the table
    updateTable();

    // Clear input fields
    nameInput.value = '';
    lastNameInput.value = '';
    phoneInput.value = '';
}

// Function to update the table with contacts
function updateTable() {
    contactsTableBody.innerHTML = '';

    // Add each new contact as a new row in the table
    contacts.forEach(function(contact) {
        const row = document.createElement('tr');
        const nameCell = document.createElement('td');
        const lastNameCell = document.createElement('td');
        const phoneCell = document.createElement('td');

        nameCell.textContent = contact.firstName;
        lastNameCell.textContent = contact.lastName;
        phoneCell.textContent = contact.phoneNumber;

        row.appendChild(nameCell);
        row.appendChild(lastNameCell);
        row.appendChild(phoneCell);

        contactsTableBody.appendChild(row);
    });
}