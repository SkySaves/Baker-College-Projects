# Open the input file with CPI data and the output HTML file
with open('cpi_data.txt', 'r') as input_file, open('cpi_table.html', 'w') as output_file:
    # Write the initial part of the HTML file
    output_file.write("""
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CPI Data Table</title>
</head>
<body>
    <table>
        <tr>
            <th>Year</th>
            <th>Jan</th>
            <th>Feb</th>
            <th>Mar</th>
            <th>Apr</th>
            <th>May</th>
            <th>Jun</th>
            <th>Jul</th>
            <th>Aug</th>
            <th>Sep</th>
            <th>Oct</th>
            <th>Nov</th>
            <th>Dec</th>
            <th>Annual</th>
        </tr>
""")

    # Read each line from the input file and write it to the HTML file in table row format
    for line in input_file:
        year, *values = line.split()
        output_file.write("        <tr>\n")
        output_file.write(f"            <td>{year}</td>\n")
        for value in values:
            output_file.write(f"            <td>{value}</td>\n")
        output_file.write("        </tr>\n")

    # Write the closing tags of the HTML file
    output_file.write("""
    </table>
</body>
</html>
""")

print("HTML file 'cpi_table.html' generated successfully.")
