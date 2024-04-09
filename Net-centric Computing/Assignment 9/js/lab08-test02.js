
const userInput = prompt("Please enter your bill total:");


const billTotal = parseFloat(userInput);

const TIP_PERCENTAGE = 0.1;

if (isNaN(billTotal)) {
    console.error("Error: The input is not a valid number.");
} else {

    const tipAmount = billTotal * TIP_PERCENTAGE;


    console.log(`For bill of $${billTotal.toFixed(2)} the tip should be $${tipAmount.toFixed(2)}`);
}
