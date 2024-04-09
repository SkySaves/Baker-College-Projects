
const billTotal = parseFloat(prompt("Please enter your bill total:"));

const TIP_PERCENTAGE = 0.1;

const tipAmount = billTotal * TIP_PERCENTAGE;

console.log(`For bill of $${billTotal.toFixed(2)} the tip should be $${tipAmount.toFixed(2)}`);
