
// Homework Exercise 6 - Average grade

function AverageGrade(g1, g2, g3, g4, g5) {
    this.grade1 = g1;
    this.grade2 = g2;
    this.grade3 = g3;
    this.grade4 = g4;
    this.grade5 = g5;

    this.averageCalc = function() {
        let average = (this.grade1 + this.grade2 + this.grade3 + this.grade4 + this.grade5) / 5; // Calculate average
        if (average >= 8) {
            alert(`The student passed with an average grade of ${average}`);
        } else {
            alert(`The student failed with an average grade of ${average}`);
        }
    };
}

let student1 = new AverageGrade(10, 6, 8, 9, 6);
student1.averageCalc();

// Homework Exercise 7 - Remove falsy values

let myArray = [10, null, 5, undefined, NaN, "", false, "hello", 0, true];

function removeFalsyValues(arr) {
    return arr.filter(item => item);
}

let filteredArray = removeFalsyValues(myArray);

console.log(filteredArray);

// Homework Exercise 8 - ToDo app

let toDoApp = new Object();

toDoApp.array = [];

toDoApp.addToDo = function(ToDo) {
    this.array.push(ToDo);
}

toDoApp.displayToDo = function() {
    if (this.array.length === 0) {
        console.log("No ToDo's yet");
    } else {
        console.log("Here's your ToDo list:");
        this.array.forEach((ToDo, index) => {
            console.log(`${index + 1}. ${ToDo}`);
        });
    }
};

toDoApp.addToDo('Complete JavaScript homework');
toDoApp.addToDo('Buy groceries');
toDoApp.addToDo('Travel');

toDoApp.displayToDo();

// Homework Exercise 9 - Phone book

let phoneBook = {
    contacts: [],
    
    addContact: function(name, number) {
        let contact = { name, number };
        this.contacts.push(contact);
        console.log(`Contact added: ${name}`);
    },
    
    displayContacts: function() {
        if (this.contacts.length === 0) {
            console.log("No contacts in the phone book.");
        } else {
            console.log("Phone Book:");
            this.contacts.forEach((contact, index) => {
                console.log(`${index + 1}. ${contact.name}, Number: ${contact.number}`);
            });
        }
    }
};

phoneBook.addContact('Aleks', '072258062');
phoneBook.addContact('Marko', '073553978');
phoneBook.addContact('Katerina', '071266784');

phoneBook.displayContacts();

// Homework Exercise 10 - Entities

// Academy definition
let Academy = {
    academyName: "Qinshift",
    numberOfGroups: 6,
    numberOfClassrooms: 1,

    displayAcademyName: function() {
        console.log(`Academy Name: ${this.academyName}`);
    }
};

// Group definition
let Group = {
    name: "G2",
    numberOfStudents: 0,
    students: [],

    displayNumberOfStudents: function() {
        console.log(`Number of Students in ${this.name}: ${this.numberOfStudents}`);
    },

    addStudent: function(student) {
        this.students.push(student);
        this.numberOfStudents = this.students.length;
    }
};

// Student constructor
function Student(firstName, lastName, age, email, academy, group) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.email = email;
    this.academy = academy;
    this.group = group;

    this.displayStudentAcademy = function() {
        console.log(`${this.firstName} ${this.lastName} is enrolled in the academy: ${this.academy.academyName}`);
    };
}

let student2 = new Student("Aleks", "Davitkov", 24, "aleksdavitkov@hotmail.com", Academy, Group);
let student3 = new Student("Angel", "Ivanovski", 26, "angel@gmail.com", Academy, Group);
let student4 = new Student("Marko", "Petkovski", 22, "marko@gmail.com", Academy, Group);

Group.addStudent(student2);
Group.addStudent(student3);
Group.addStudent(student4);

Academy.displayAcademyName();
student2.displayStudentAcademy();
student3.displayStudentAcademy();
student4.displayStudentAcademy();
Group.displayNumberOfStudents();