// Publication data (API)

const publicationData = [
  {
    "title": "Intro to C#",
    "author": "Bob Bobsky",
    "publicationYear": 2023
  },
  {
    "title": "Backend Development Essentials",
    "author": "Steven Bronsky",
    "publicationYear": 2022
  },
  {
    "title": "The Art of Awareness",
    "author": "John Doe",
    "publicationYear": 2019
  },
  {
    "title": "JavaScript Fundamentals",
    "author": "Mark Johnson",
    "publicationYear": 2025
  },
  {
    "title": "The Conference of the Birds",
    "author": "Farid ud-Din Attar",
    "publicationYear": null
  },
  {
    "title": "HTML/CSS Basics",
    "author": "Robert Smith",
    "publicationYear": 2010
  }
];

// ===== FUNCTIONS =====

// Get all publications
function getAllPublications() {
  console.log("All Publications:", publicationData);
}

// Get the publication year of a specific search
function getPublicationByTitle(title) {
  const publication = publicationData.find(pub => pub.title.toLowerCase() === title.toLowerCase());
  if (publication) {
    console.log(`${publication.title} was published in ${publication.publicationYear}`);
  } else {
    console.log(`Publication titled "${title}" not found.`);
  }
}

// Get publications by publication year
function getPublicationsByYear(year) {
  const filteredPublications = publicationData.filter(pub => pub.publicationYear === year);
  if (filteredPublications.length > 0) {
    console.log(`Publications published in ${year}:`, filteredPublications);
  } else {
    console.log(`No publications found for the year ${year}`);
  }
}

// Get publications by author
function getPublicationsByAuthor(author) {
  const filteredPublications = publicationData.filter(pub => pub.author.toLowerCase().includes(author.toLowerCase()));
  if (filteredPublications.length > 0) {
    console.log(`Publications by ${author}:`, filteredPublications);
  } else {
    console.log(`No publications found by author "${author}"`);
  }
}

// ===== EXAMPLES =====

getAllPublications();
getPublicationByTitle("HTML/CSS Basics");
getPublicationsByYear(2022);
getPublicationsByAuthor("Mark Johnson");