let inputRows = document.getElementById('rows');
let inputColumns = document.getElementById('cols');

let createBtn = document.getElementById('createTableBtn');
let divTable = document.getElementById('table-container');

createBtn.addEventListener('click', function() {
    let rows = parseInt(inputRows.value);
    let cols = parseInt(inputColumns.value);

    if (isNaN(rows) || rows <= 0 || isNaN(cols) || cols <= 0) {
        alert('Please enter valid positive numbers for rows and columns.');
        return;
    }

    let table = document.createElement('table');
    table.style.border = '1px solid black';
    table.style.borderCollapse = 'collapse';

    for (let i = 0; i < rows; i++) {
        let tr = document.createElement('tr');
        table.appendChild(tr);

        for (let j = 0; j < cols; j++) {
            let td = document.createElement('td');
            td.style.border = '1px solid black';
            td.style.padding = '10px';
            td.textContent = `Row ${i + 1} Col ${j + 1}`;
            tr.appendChild(td);
        }
    }

    divTable.innerHTML = '';
    divTable.appendChild(table);
});