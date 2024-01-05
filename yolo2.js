// Prompt the user for their name
var userName = prompt("What is your name?");

// Check if the user entered a name
if (userName !== null && userName !== "") {
    // Display a personalized greeting
    var greeting = "Hello, " + userName + "! Welcome to the world of JavaScript!";
    alert(greeting);
} else {
    // Handle the case where the user didn't enter a name
    alert("Hello, anonymous! Welcome to the world of JavaScript!");
}
