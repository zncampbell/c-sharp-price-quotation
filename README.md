# c-sharp-price-quotation
C# ASP.Net Core MVC app that allows you to enter subtotal and discount percentage. Calculates the discount amount and presents the total.

Specifications
•	When the app starts, it should display the Price Quotation page with no subtotal or discount percent, and it should set the discount amount and total to $0.00.
•	If the user enters a valid subtotal and discount percent and clicks the Calculate button, the app should calculate and display the discount amount and total.
•	If the user enters invalid data and clicks the Calculate button, the app should display a summary of validation errors above the form.
•	Here are the requirements for valid data:
o	The sales price is required and must be a valid number that’s greater than 0 and but less than or equal to 5000..
o	The discount percent is required and must be a valid number from 0 to 100.
•	If the user clicks the Clear link, the app should reset the form to how it was when the app first started.
•	Use the MVC pattern. To do that, create a model class that stores the subtotal and discount percent and calculates the discount amount and total. Make sure to bind that model to the Razor view that displays the Price Quotation page shown above.
•	Use a Razor layout to store the <html>, <head>, and <body> elements.
•	Use a custom CSS style sheet to style the HTML elements so they appear as shown above.
