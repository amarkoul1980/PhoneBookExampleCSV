PROGRAMMING LANGUAGE

Visual C# 2015

PROJECT TYPE

Windows Form Application (Visual C#)

USER INTERFACE

The UI contains 2 buttons, a combo box and a list view.

The "Get all phone numbers" button retrieves the phone numbers from a CSV file (named "phones.csv").
After the retrieval, the list view is filled with the retrieved data, while the combo box is filled with the surnames and the names of the phone users.
The "Activate phone number" activates a deactivated phone number

INSTRUCTIONS

At first, the user must press the "Get all phone numbers" button. Then, the list view is filled with the retrieved data and the button becomes disabled.

The phone number data are stored in a list (so that it won't be necessary to be retrieved again from the file). This process would not have been followed if we used a database.

The user can get the phone numbers of a specific user by selecting its full name (surname and name) from the combo box. If the user selects the "All numbers", the list view will be filled with every available data (retrieved, though, from the list -and not from the CSV file).

When the user selects a record in the list view, the program checks whether the respective "Activated" field is "true" or "false". If it is "false", the "Activate phone number' button becomes enabled.

When the user presses the "Activate phone number" button, the previously selected "Activated" field gets the "true" value and the respective list record is updated.