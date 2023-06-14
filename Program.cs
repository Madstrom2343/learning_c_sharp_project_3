// See https://aka.ms/new-console-template for more information

// Conditions

// if (condition){
//  result
//}

// if (answer == "LOTR"){
//     Console.Write("Correct.");
//} else {
//    Console.Write("Incorrect, Mordor with you.");
//}

// Some conditions for an if statement include:
// '==' means is equal to
// '!=' means is not equal to
// '>' means greater than, just as '<' means less than
// '>=' means greater than or equal to, like '<=' means less than or equal to
// You can use && to set up an additional condition to meet
// You can use || to set up an alternate condition to meet
// && needs both conditions to be true, where || needs only one to be true

// Example 1: Tickets please

// The terminal asks for a number (int). The cost is 5
Console.WriteLine("Hello, Tickets are $5. Please insert cash.");

// The terminal takes the input the user gives and turns it into an int variable
int cash = Convert.ToInt32(Console.ReadLine());

// If the number given is less than 5
if (cash < 5){
    // The terminal denies entry, as the fund is too little
    Console.WriteLine("Sorry, but you do not have enough money.");
// If the number given is equal to 5 
} else if (cash == 5){
    // The terminal thanks the user, giving them entry
    Console.WriteLine("Thank you so much! Here's your ticket. Please enjoy your stay.");
// If the number given isn't less than or equal to 5 (if the number is more than 5)
} else {
    // A new variable is made, subtracting the initial 5 needed
    int change = cash - 5;
    // The terminal thanks the user, gives them entry, and gives them their change
    Console.WriteLine("Thank you! Here is your ticket, and $" + change + " for your change back. Enjoy your stay!");
}

Console.WriteLine("\n \n \n");
// Example 2: height age limit

int age;
int height;

Console.WriteLine("Input age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input height (in cm): ");
height = Convert.ToInt32(Console.ReadLine());

if(age >= 10 && height >= 160){
    Console.WriteLine("You may Enter");
} else {
    Console.WriteLine ("Requirements not met; Unallowed");
}

Console.WriteLine("\n \n \n");
// Challenge: (create a game where the user must answer a trivia)
// make 5 questions, then add each correct to sum a score

// Tells the user to answer 5 questions, getting 3 of 5 right means passing
Console.WriteLine("Welcome to the Quizinator! You must answer 5 Questions. If you get 3 or more right, then you win!");

// A result variable is made, being 0. Additionally, each question is created as a variable
int result = 0;
int q1;
string q2;
string q3;
string q4;
string q5;

// Answer: [8]
Console.WriteLine("Question 1: what is the square root of 64?: ");
// The user's answer is stored in its respectively named variable
q1 = Convert.ToInt32(Console.ReadLine());
// The user's answer is compared to the answer of the question. If it is the answer, then the if function is executed
if (q1 == 8){
    // The terminal tells the user they are correct
    Console.WriteLine("Correct");
    // The result variable is increased by 1
    result = result + 1;
// If the user's answer is incorrect, the terminal tells the user as such
} else {
    Console.WriteLine("Incorrect");
}

// Answer: [Darth Vader]
Console.WriteLine("Question 2: Who is the caped villain in Star Wars?: ");
q2 = Console.ReadLine();
if (q2 == "Darth Vader"){
    Console.WriteLine("Correct");
    result = result + 1;
}else {
    Console.WriteLine("Incorrect");
}

// Answer: [Divine Justice]
Console.WriteLine("Question 3: What type of spiritual work does Luke work with?: ");
q3 = Console.ReadLine();
if (q3 == "Divine Justice"){
    Console.WriteLine("Correct");
    result = result + 1;
}else {
    Console.WriteLine("Incorrect");
}

// Answer: [War of Roses]
Console.WriteLine("Question 4: What is the historical event Game of Thrones is based off of?: ");
q4 = Console.ReadLine();
// The answer to this question can be written in different variations, so if any are written, then the if function is executed
if (q4 == "War of Roses" || q4 == "The War of the Roses" || q4 == "Wars of Roses" || q4 == "The War of Roses"){
    Console.WriteLine("Correct");
    result = result +1;
} else {
    Console.WriteLine("Incorrect");
}

// Answer: [Dragon]
Console.WriteLine("Question 5: What is the most popular and well known fantasy monster?: ");
q5 = Console.ReadLine();
if (q5 == "Dragon"){
    Console.WriteLine("Correct");
    result = result +1;
}else {
    Console.WriteLine("Incorrect");
}

// The terminal outputs the number of answers the user got correct using the results variable
Console.WriteLine("RESULT: " + result + " out of 5 correct.");
// The terminal determines if the amount of correct answers is greater than or equal to the amount needed in order to pass the test.
if (result >= 3){
    // If the result of correct answers is 3 or more, the user passes, yipee!
    Console.WriteLine("Congratulations, you passed the test!!");
}else {
    // If the result of correct answers is less than 3, the user fails, dang
    Console.WriteLine("Sorry, better luck next time.");
}

Console.WriteLine("\n \n \n");
// Extra: Switch

// This is a simpler way in case there may be different answers to a given problem

// The terminal asks for the user to give a number between 1 and 5
Console.Write("Input a number between 1 and 5: ");

// A new variable, num, is created to store what the user inputs and convert it to a number
int num = Convert.ToInt32(Console.ReadLine());

// The num variable is put into a switch function
switch (num) {
    // The terminal will output the desired function in the case the user puts 1
    case 1:
        Console.WriteLine("One");
        // Case 1 resolves and the next case is determined
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    case 4:
        Console.WriteLine("Four");
        break;
    case 5:
        Console.WriteLine("Five");
        break;
    default:
        Console.WriteLine("default");
        break;
}

// Waits before it closes
Console.ReadKey();