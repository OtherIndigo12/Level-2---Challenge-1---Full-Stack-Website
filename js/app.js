const url = "http://localhost:5064/api/"

//Say Hello
const nameInput = document.getElementById("name-input");
const nameForm = document.getElementById("name-form");
const nameOutput = document.getElementById("name-output");

//Adding Numbers
const addForm = document.getElementById("add-form");
const inputOne = document.getElementById("number-one");
const inputTwo = document.getElementById("number-two");
const addOutput = document.getElementById("add-output");

//Comparing Numbers
const compareForm = document.getElementById("compare-form");
const otherInputOne = document.getElementById("other-number-one");
const otherInputTwo = document.getElementById("other-number-two");
const compareOutput = document.getElementById("compare-output");
const compareOutput2 = document.getElementById("compare-output2");


//Magic 8 Ball
const ballForm = document.getElementById("ball-form");
const qInput = document.getElementById("question-input");
const ballOutput = document.getElementById("ball-output");

//Mad-Lib
const mlForm = document.getElementById("ML-form");
const mlNameInput = document.getElementById("ML-input_name");
const locationInput = document.getElementById("ML-input_location");
const colorInput = document.getElementById("ML-input_color");
const eventInput = document.getElementById("ML-input_event");
const numberInput = document.getElementById("ML-input_number");
const letterInput = document.getElementById("ML-input_letter");
const friendInput = document.getElementById("ML-input_friend");
const eatInput = document.getElementById("ML-input_eat");
const foodInput = document.getElementById("ML-input_food");
const dessertInput = document.getElementById("ML-input_dessert");
const mlOutput = document.getElementById("ML-output")

//Restaurants
const foodForm = document.getElementById("food-form");
const newFoodInput = document.getElementById("food-input");
const foodOutput = document.getElementById("food-output");

//Say Hello
const nameFetch = async (helloName) => {
    const response = await fetch(`${url}hello/sayhello/${helloName}`);

    const data = await response.json();

    console.log(data);

    return data;
}

//Adding Numbers
const additionFetch = async (numberOne, numberTwo) => {
    const response = await fetch(`${url}add/addition/${numberOne}/${numberTwo}`);

    const data = await response.json();

    console.log(data);
    return data;
}

//Comparing Numbers
const compareFetch = async (otherNumberOne, otherNumberTwo) => {
    const response = await fetch(`${url}compare/compare/${otherNumberOne}/${otherNumberTwo}`);

    const data = await response.json();

    console.log(data);

    return data
}

//Magic 8 Ball
const ballFetch = async (question) => {
    const response = await fetch(`${url}ball/ball/${question}`);

    const data = await response.json();

    return data;
}

//Mad-Lib
const madlibFetch = async (mlName, mlLocation, mlColor, mlEvent, mlNumber, mlLetter, mlFriend, mlEat, mlFood, mlDessert) => {
    const response = await fetch(`${url}ml/madlib/${mlName}/${mlLocation}/${mlColor}/${mlEvent}/${mlNumber}/${mlLetter}/${mlFriend}/${mlEat}/${mlFood}/${mlDessert}`);

    const data = await response.json();

    console.log(data);

    return data;
}

const foodFetch = async (choice) => {
    const response = await fetch(`${url}restaurant/select/${choice}`);

    const data = await response.json();

    console.log(data);

    return data;
}

//Say Hello
if (nameForm) {
    nameForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await nameFetch(nameInput.value);

        nameOutput.textContent = `Hello There, ${output.result}!`;
    })
}

//Adding Numbers
if (addForm) {
    addForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await additionFetch(inputOne.value, inputTwo.value);

        addOutput.textContent = `${output.numOne} + ${output.numTwo} = ${output.result}`;
    })
}

//Comparing Numbers
if (compareForm) {
    compareForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await compareFetch(otherInputOne.value, otherInputTwo.value);

        compareOutput.textContent = `${output.result}`;
    })
}

//Magic 8 Ball
if (ballForm) {
    ballForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await ballFetch(qInput.value);

        ballOutput.textContent = `${output.result}`;
    })
}

//Mad-Lib
if (mlForm) {
    mlForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await madlibFetch(
            mlNameInput.value, 
            locationInput.value, 
            colorInput.value,
            eventInput.value,
            numberInput.value,
            letterInput.value,
            friendInput.value,
            eatInput.value,
            foodInput.value,
            dessertInput.value);

            mlOutput.textContent = `${output.result}`;
    })
}

//Restaurants
if (foodForm) {
    foodForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await foodFetch (newFoodInput.value);

        foodOutput.textContent = `${output.result}`;
    })
}
