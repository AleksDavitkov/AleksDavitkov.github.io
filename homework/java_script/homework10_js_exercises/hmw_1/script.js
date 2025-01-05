// Homework - Exercise 2 (Expense Tracker)

function Expense(description, amount, category) {
    this.description = description;
    this.amount = parseFloat(amount);
    this.category = category;
  }
  
  $(document).ready(function () {
    let totalExpenses = 0;
  
    // Handle form submission
    $('#expense-form').submit(function (e) {
      e.preventDefault();
  
      // Get input
      const description = $('#description').val();
      const amount = $('#amount').val();
      const category = $('#category').val();
  
      // Validation
      if (!description || !amount || !category) {
        alert('Please fill in all fields!');
        return;
      }
  
      // Create and display the new expense
      const expense = new Expense(description, amount, category);
      addExpenseToTable(expense);
  
      // Update total expenses
      totalExpenses += expense.amount;
      $('#total-sum').text(totalExpenses);
  
      // Clear form
      $(this)[0].reset();
    });
  
    // Add expense to the table
    function addExpenseToTable(expense) {
      const row = `<tr>
        <td>${expense.description}</td>
        <td>$${expense.amount}</td>
        <td>${expense.category}</td>
        <td><button class="delete-btn">Delete</button></td>
      </tr>`;
      $('#expense-table tbody').append(row);
    }
  
    // Delete an expense from the table
    $('#expense-table').on('click', '.delete-btn', function () {
      const row = $(this).closest('tr');
      const amount = parseFloat(row.find('td').eq(1).text().replace('$', ''));
  
      // Remove row and update total
      row.remove();
      totalExpenses -= amount;
      $('#total-sum').text(totalExpenses);
    });
  });  