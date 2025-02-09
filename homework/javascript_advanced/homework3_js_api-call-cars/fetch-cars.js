// Fetch Cars-API data
fetch('https://raw.githubusercontent.com/AleksDavitkov/AleksDavitkov.github.io/main/homework/javascript_advanced/homework3_js_api-call-cars/cars_json/cars.json')
  .then(response => {
    if (!response.ok) {
      throw new Error('Something went wrong...');
    }
    return response.json();
  })
  .then(data => {
    const tableMain = document.querySelector("#cars tbody");
    const searchBtn = document.getElementById('searchBtn');
    const filterType = document.getElementById('filterType');
    const filterBrand = document.getElementById('filterBrand');

    // Loop data and add rows to the table
    data.forEach(car => {
      const row = document.createElement("tr");
      row.innerHTML = `
        <td>${car.model}</td>
        <td>${car.brand}</td>
      `;
      tableMain.appendChild(row);
    });
  })
  .catch(error => {
    console.error('Error fetching data:', error);
});

// Functions

// Event listeners