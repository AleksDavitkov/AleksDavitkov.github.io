
// Homework - Header generator

$(document).ready(function() {
    $('#generate-header').click(function() {
        let text = $('#header-text').val();
        let color = $('#header-color').val();
        let errorMessage = $('#error-message');
        let generatedHeader = $('#generated-header');
        
        // Clear previous error message
        errorMessage.text('');
        
        // Validate inputs
        if (!text || !color) {
            errorMessage.text('Please provide valid text and select a color.');
            generatedHeader.empty();
        } else {
            generatedHeader.html('<h1 style="color:' + color + ';">' + text + '</h1>');
            $('#header-text').val('');
            $('#header-color').val('');
        }
    });
});