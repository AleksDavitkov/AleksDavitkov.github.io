// JS advanced homework - fetch 

const fetchStudentData = async () => {
  const url = 'https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json';

  try {
    const response = await fetch(url);
    const students = await response.json();

    // Return an array with students' full names
    const fullNames = students.map(student => `${student.firstName} ${student.lastName}`);
    console.log("Students' Full Names:", fullNames);

    // All students sorted by the averageGrade property (ascending)
    const sortedByGrade = [...students].sort((a, b) => a.averageGrade - b.averageGrade);
    console.log('Students by Average Grade:', sortedByGrade);

    // All students with an average grade higher than 3
    const gradeAboveThree = students.filter(student => student.averageGrade > 3);
    console.log('Students with Average Grade > 3:', gradeAboveThree);

    // All female student names with an average grade of 5
    const topFemaleStudents = students
    .filter(student => student.gender === 'Female' && student.averageGrade === 5)
    .map(student => `${student.firstName} ${student.lastName}`);
    console.log('Female Students with Average Grade = 5:', topFemaleStudents);

    // All male student names who live in Skopje and are over 18 years old
    const skopjeMalesOver18 = students
    .filter(student => student.gender === 'Male' && student.city === 'Skopje' && student.age > 18)
    .map(student => `${student.firstName} ${student.lastName}`);
    console.log('Male Students in Skopje Over 18:', skopjeMalesOver18);

    // The average grades of all female students over the age of 24
    const avgGradeFemalesOver24 = students
    .filter(student => student.gender === 'Female' && student.age > 24)
    .reduce((sum, student) => sum + student.averageGrade, 0) / students.filter(student => student.gender === 'Female' && student.age > 24).length;
    console.log('Average Grade of Females Over 24:', avgGradeFemalesOver24);

    // All male students with a name starting with B and average grade over 2
    const maleNameBGradeOver2 = students
    .filter(student => student.gender === 'Male' && student.firstName.startsWith('B') && student.averageGrade > 2)
    .map(student => `${student.firstName} ${student.lastName}`);
    console.log('Male Students with Name Starting with B and Average Grade > 2:', maleNameBGradeOver2);

  } catch (error) {
    console.error('Error fetching');
  }
};

fetchStudentData();