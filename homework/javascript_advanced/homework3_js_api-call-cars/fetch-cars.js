// Wrapped elements
const html = {
  tableMain: document.querySelector("#cars tbody"),
  searchBtn: document.getElementById("searchBtn"),
  resetBtn: document.getElementById("resetBtn"),
  filterType: document.getElementById("filterType"),
  filterBrand: document.getElementById("filterBrand"),
  filterModel: document.getElementById("filterModel"),
  filterNumDoors: document.getElementById("filterDoors"),
  filterGasType: document.getElementById("filterGasType"),
  filterColor: document.getElementById("filterColor"),
  filterCondition: document.querySelectorAll("input[name='filterCondition']"),
  filterHorsepower: document.getElementById("filterHorsepower"),
};

let carsData = []; // Storage for fetched data

// Fetch Cars-API data
fetch(
  "https://raw.githubusercontent.com/AleksDavitkov/AleksDavitkov.github.io/main/homework/javascript_advanced/homework3_js_api-call-cars/cars_json/cars.json"
)
  .then((response) => {
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }
    return response.json();
  })
  .then((data) => {
    carsData = data;
    displayCars(data); // Call to display the data
  })
  .catch((error) => {
    console.error("Error fetching data:", error);
  });

// ===== FUNCTIONS =====

// Display cars
function displayCars(cars) {
  html.tableMain.innerHTML = "";
  cars.forEach((car) => {
    const row = document.createElement('tr');
    row.innerHTML = `
    <td>${car.type}</td>
    <td>${car.brand}</td>
    <td>${car.model}</td>
    <td>${car.doors}</td>
    <td>${car.gasType}</td>
    <td>${car.color}</td>
    <td>${car.horsepower}</td>
    `;
    html.tableMain.appendChild(row);
  });
};

// ===== EVENT LISTENERS =====

// Search by selection
html.searchBtn.addEventListener("click", () => {
  const selectedType = html.filterType.value;
  const selectedBrand = html.filterBrand.value;
  const inputModel = html.filterModel.value.toLowerCase();
  const inputNumOfDoors = html.filterNumDoors.value;
  const selectedGasType = html.filterGasType.value;
  const selectedColor = html.filterColor.value;
  const maxHorsepower = html.filterHorsepower.value;

  // Search New/Old condition
  let selectedCondition = "";
  html.filterCondition.forEach((radio) => {
    if (radio.checked) selectedCondition = radio.value;
  });

  let filteredCars = carsData;

  if (selectedType !== "") {
    filteredCars = filteredCars.filter(car => car.type === selectedType);
  }
  
  if (selectedBrand !== "") {
    filteredCars = filteredCars.filter(car => car.brand === selectedBrand);
  }

  if (inputModel !== "") {
    filteredCars = filteredCars.filter(car => car.model.toLowerCase().includes(inputModel));
  }

  if (inputNumOfDoors !== "") {
    filteredCars = filteredCars.filter(car => car.doors === Number(inputNumOfDoors));
  }

  if (selectedGasType !== "") {
    filteredCars = filteredCars.filter(car => car.gasType === selectedGasType);
  }

  if (selectedColor !== "") {
    filteredCars = filteredCars.filter(car => car.color === selectedColor);
  }

  if (selectedCondition !== "") {
    filteredCars = filteredCars.filter(car => 
      (selectedCondition === "new" && car.isNew) || (selectedCondition === "old" && !car.isNew)
    );
  }

  if (maxHorsepower !== "") {
    filteredCars = filteredCars.filter(car => car.horsepower <= Number(maxHorsepower));
  }

  displayCars(filteredCars);
});

// Reset functionality
html.resetBtn.addEventListener("click", () => {
  html.filterType.value = "";
  html.filterBrand.value = "";
  html.filterModel.value = "";
  html.filterNumDoors.value = "";
  html.filterGasType.value = "";
  html.filterColor.value = "";
  html.filterHorsepower.value = "";

  html.filterCondition.forEach(radio => radio.checked = radio.value === "");

  displayCars(carsData);
});