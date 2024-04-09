
const countries = csv.split(",");


const countriesString = countries.join(", ");


console.log(Array.isArray(csv)); // false
console.log(Array.isArray(countries)); // true


countries.sort();


countries.reverse();

countries.shift();

countries.pop();

countries.unshift("Brazil", "Argentina");

console.log(countries.includes("Germany"));

console.log(countries.indexOf("Germany"));

const newCountries = countries.splice(2, 3);

// Part 4
// a. Use a loop to output all cities whose continent == "NA".
cities.forEach(city => {
    if (city.continent === "NA") {
        console.log(city.city);
    }
});

// b. Use a loop to output gallery name property whose country == "USA".
galleries.forEach(gallery => {
    if (gallery.location.country === "USA") {
        console.log(gallery.name);
    }
});

// c. Convert JSON colorsAsString to JavaScript literal object using JSON.parse().
const colors = JSON.parse(colorsAsString);

// d. Use a loop to output the color name property if luminance < 75.
colors.forEach(color => {
    if (color.luminance < 75) {
        console.log(color.name);
    }
});

// Part 5
// a. Output an unordered list of links to the galleries in the galleries array.
document.write('<ul>');
galleries.forEach(gallery => {
    document.write(`<li><a href="${gallery.url}">${gallery.name}</a></li>`);
});
document.write('</ul>');
