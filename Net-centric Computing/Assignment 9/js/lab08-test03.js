
const billTotals = [50, 150, 20, 500];

let tips = [];


for (let i = 0; i < billTotals.length; i++) {
    let tipPercentage;

    if (billTotals[i] > 75) {
        tipPercentage = 0.1; // 10%
    } else if (billTotals[i] >= 30 && billTotals[i] <= 75) {
        tipPercentage = 0.2; // 20%
    } else {
        tipPercentage = 0.3; // 30%
    }

    const tip = billTotals[i] * tipPercentage;

    tips.push(tip);
}

for (let i = 0; i < billTotals.length; i++) {
    console.log(`For bill of $${billTotals[i]} the tip should be $${tips[i].toFixed(2)}`);
}
