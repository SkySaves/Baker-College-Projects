# Assignment 7: PHP Environment Variables and HTML Form

## Overview

This assignment demonstrates how to capture and display server-side environment variables using PHP and how to build a comprehensive HTML form for collecting user inputs.

### Files Overview

- `env.php`: A PHP script designed to display the values of various PHP superglobals such as `$_GET`, `$_POST`, `$_COOKIE`, `$_FILES`, and `$_SERVER`.
- `index.html`: An HTML document containing a detailed form with various types of input fields. The form data is submitted to `env.php`.

## env.php

The `env.php` script outputs the contents of several PHP superglobals, making it a useful tool for debugging and understanding how data is transmitted to the server via a web form.

### Key Superglobals Displayed

- `$_GET`: Shows query string parameters.
- `$_POST`: Contains data submitted in the HTTP POST request.
- `$_COOKIE`: Lists all cookies sent by the browser to the server.
- `$_FILES`: Details about uploaded files.
- `$_SERVER`: Server and execution environment information.

## index.html

The `index.html` file presents a form that allows for the collection of a wide range of data types including text, passwords, emails, dates, telephone numbers, colors, numbers, ranges, files, and comments. This form is an example of capturing diverse user inputs for processing on a server.

### Form Features

- Text inputs for first name, last name, email, etc.
- Checkboxes for student and married statuses.
- Radio buttons for gender selection.
- A password field.
- An email field with validation.
- A date picker for birthdate.
- A telephone number input with a pattern for validation.
- Color picker for favorite color.
- Number input for favorite number with specified range.
- Range input for volume control.
- File input for uploading files.
- Textarea for comments.

### Submission

The form uses POST method to submit data to the `env.php` script and includes `enctype="multipart/form-data"` to ensure file uploads are properly handled.

## How to Use

1. Place both files (`env.php` and `index.html`) on a PHP-enabled server environment.
2. Open `index.html` in a browser, fill out the form, and submit it.
3. View the output on `env.php` which displays the submitted data.

## Conclusion

Assignment 7 provides a practical look into handling HTML form data with PHP, showcasing how server-side scripts can access client-submitted data through superglobals.

