# EmployeeContacts
A web service consuming mobile application that allows users to create, store, update and delete employee contact information. There is also the option to customise the appearance, where users are able to alternate between a choice of two themes: default and purple-centric. Finally, user guide documentation is provided within the app. 
This mobile app was developed using the Xamarin Forms Mobile Framework, where the UI is written in XAML and the backend logic in C#.  

The web service was developed using the ASP.NET framework, and contact information stored in XML file. 


# How To Set Up (Important!):

Please follow the steps below before attempting to launch the mobile app. You must open the web service in browser before launching the mobile application. It is a known bug that neglecting this step will result in the mobile app failing to consume the referenced web service.   

1. Open the TodoASMX.sln in Visual Studio 2019.

2. Launch the referenced ASP.NET web service project. ToDoASMXService >  Right-click TodoService.asmx > 'View in Browser'.

3. Start the Android App located in TodoASMX.Droid project.

# How To Add A New Employee Contact
1. On start-up, the app displays the Contacts page. Tap the '+' sign in the top right corner. 

2. The app navigates to a new page displaying the employee's details. Enter values into the appropriate fields. 

4. Click “Save” button to successfully add a new employee contact. 

# How To Update An Employee's Contact Details
1. On start-up, the app displays a record of employees (if there is any). 

2. Tap on the employee whose details will be edited

3. The app navigates to a new page displayed the employee's details. Tap on the field/s you wish to change and enter your new values.

4. Click “Save” button to persist your changes.

# How To Delete An Employee's Contact Details
1. On start-up, the app displays a record of employees (if there is any). 

2. Tap on the employee whose contact details will be deleted. 

3. The app navigates to a new page displaying the employee's details. Click “Delete” button to remove the employee record. 

# How To Customise Appearance
1. On start-up, the app displays a record of employees. Tap on an employee record.
2. Scroll to the bottom and tap 'Select a theme'

# How To Access User Guide
1. On start-up, tap the '?' icon on the bottom right corner. 

