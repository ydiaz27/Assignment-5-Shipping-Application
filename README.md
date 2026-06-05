Here are the assignment requirements: 

Users can enter: The package tracking number, the name of the recipient, Street address, City, State, 
Postal code, Email address, Phone number, Weight of the package in pounds, Date shipped, Date delivered, 
Weight (in pounds), Carrier, Delivery mode, and Indicate if the package is fragile. 
Create a class called PackageInfo to hold the information above.
Create a text file to hold package information. Use commas to separate the fields. We
can’t use blank spaces because a street address contains spaces (e.g., 123 Easy
2 Street) and a city can contain spaces (e.g., San Diego). Read the contents of the file,
create a PackageInfo object for each package, and display the package tracking number
in the list box.
The user can indicate whether the contents of the package are fragile or not.
The user can select the carrier from a list. Use a combo box control for this. The
shippers are: FedEx, USPS, UPS. 
The user can choose a shipping method using radio buttons. The options are listed
below. Make the Express option the default selection. The radio buttons should be
enclosed inside a group box control with the label “Shipping Mode” and contain 
Standard, Express, and Overnight.
The base rate for shipping mode is shown below. These values should be placed
inside an application configuration file: Standard $5.00, Express $10.00, Overnight $20.00.
On top of the base rate is a per-pound rate. These values should be placed inside an
application configuration file: Standard = $0.50 per pound, Express = $1.00 per pound, 
Overnight = $1.50 per pound.
To facilitate ease of use, the controls should follow a specific tab order: top to bottom,
left to right. All controls should be left-aligned.
All fields except the Delivery Date are required, so these fields should be validated
using an ErrorProvider. The little red Xs should not blink.
The user can add a new package to the list. Display a message box when the user adds
a package. See below for an image of the message.
The user can calculate the shipping cost and display the result on the form.
The user can exit the application.
When a user selects an item in the package list, all the controls should fill in with the
relevant information.
