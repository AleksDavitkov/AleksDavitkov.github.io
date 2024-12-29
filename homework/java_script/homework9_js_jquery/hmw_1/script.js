
// Homework - Greeting app with JQuery

$(document).ready(function() {
    $('#greetButton').click(function() {
        let name = $('#nameInput').val();
        if (name) {
            $('#greeting').text('Hello there ' + name + '!');
            $('#nameInput').val("");
        } else {
            $('#greeting').text('Please enter a valid name.');
        }
    });
});