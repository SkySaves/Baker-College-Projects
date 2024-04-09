
const billTotals = [50, 150, 20, 500];

let tips = [];

function calculateTip(total) {
    let tipPercentage;


    if (total > 75) {
        tipPercentage = 0.1; // 10%
    } else if (total >= 30 && total <= 75) {
        tipPercentage = 0.2; // 20%
    } else {
        tipPercentage = 0.3; // 30%
    }


    return total * tipPercentage;
}

for (let i = 0; i < billTotals.length; i++) {
    let tip = calculateTip(billTotals[i]);
    tips.push(tip); // Add the calculated tip to the tips array
}

for (let i = 0; i < billTotals.length; i++) {
    console.log(`For a bill of $${billTotals[i]}, the tip should be $${tips[i].toFixed(2)}`);
}
