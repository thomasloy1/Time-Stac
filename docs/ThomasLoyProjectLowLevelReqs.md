# Timer App -- Detailed Requirements

## Functional Requirements

### Starting Application

#### Upon the user inputing the url or opening the app, the application will begin to run.

#### Upon the user opening the application, the application will display the "log in" and "create new user" buttons.

### Creating a User

#### Upon the user clicking the "create new user" button, the application will display the "user information" form until the user clicks the "create new user" button or the "cancel" button.

#### Upon the user adding a unique username and password to the "user information" form, the application will display the input data until the user clicks the "create new user" button or the "cancel" button.

#### Upon the user clicking the "create new user" button, while there is a unique username and password set, the application will take the user to the user main page.

#### Upon the user clicking the "create new user" button, while there is not a unique username and password set, the application will display a "username taken or not input" error message until the user clicks "cancel" button or inputs a valid username.

#### Upon the user clicking the "cancel" button, the application will display the start screen until the user inputs additional data. 

### Logging in

#### Upon the user clicking the "log in" button, while there is no user logged in, the application will display the user log in window until the user inputs their log in credentials.

#### Upon the user inputing their credentials, while the credentials are valid, the application will display the users main page.

#### Upon the user inputing their credentials, while the credentials are not valid, the application will display the log in window with an error message until the user inputs valid credentials.

#### Upon the user clicking the "log in" button, while there is a user logged in, the application will display the users main page.

### User Main Page

#### Once the user has logged on, while the user does not input any additional information, the application will diplay the users main page which contains folders that store timer stacks

### Timer folders

#### Upon the user clicking the "create new folder" button on the main page, the application will display a text box until the user clicks the "create" or "cancel" button.

#### Upon the user typing into the text box, the application will display the updated text in the text box until the user clicks the "create" or "cancel" button.

#### Upon the user clicking the "create" button, while there is text in the text box, the application will create and display a folder on the main page with the text entered as its name.

#### Upon the user clicking the "create" button, while there is no text in the text box, the application will continue to display the text box along with an error message until the user clicks the "create" or "cancel" button.

#### Upon the user clicking the "cancel" button, regardless of there being text in the text box, the application will display the main page until the user inputs data.

#### Upon the user creating a folder, while there is no timer stacks saved in the folder, the folder screen will be blank until the user adds a timer stack.

#### Upon the user adding a timer stack to the folder, while the user in viewing the display folder window, the application will display the timer stacks stored in the folder.

### Creating a Stack

#### Once the user is inside a folder or on the main user page, while the user isnt doing any other process, the application will display a "create stack" button.

#### Upon the user clicking the "create stack" button, the application will dispay a blank stack screen with an "add timer" button and an "exit" button until the user inputs additional information.

#### Upon the user clicking the add timer button, the application will display a blank timer to be adjusted by the user until user clicks the "add" or "cancel" button.

#### Upon the user clicking the "exit" button, while there are no timers in the stack, the application will take the user to the previous page the user was on. 

#### Upon the user clicking the "exit" button, while there are timers in the stack, the application will display a message asking the user "Would you like to save and exit?", a "save and exit" button and an "exit without saving" button.

#### Upon the user clicking the "save and exit" button, the application will save the timers in the stack and take the user to the previous page.

#### Upon the user clicking the "exit without saving" button, the application will not save the timers in the stack and take the user to the previous page.

### Adding a Timer

#### Upon the user clicking the add timer button while in the stack creation window, the application will display an adjustable timer to be adjusted by the user until user clicks the "add" or "cancel" button.

#### Upon the blank timer being displayed, while the user has not input any time, the application will display the blank timer as "00h:00m:00s" until the user adds the desired time.

#### Upon the user adding the time to the timer, the application will display the added time and display the "add" and "cancel" buttons until the user clicks the "add" or "cancel" button.

#### Upon the user clicking the "add" button, while the time is not "00h:00m:00s", the application will add the saved timer to the stack and display the updated stack page

#### Upon the user clicking the "add" button, while the time is "00h:00m:00s", the application will display a "Please input a time that is greater than zero." message and the "add" and "cancel" buttons until the user clicks the "add" or "cancel" button.

#### Upon the user clicking the "cancel" button, the application will not save the timer and will display the stack page.

### Deleting a Timer

#### Upon a user clicking on a timer, the application will display a "delete" button until the user clicks the delete button or any other place on screen.

#### Upon a user clicking the delete button, the application will delete the timer that was selected.

### Run Timers

#### Upon the user pressing the start button, while there is at least one timer in the stack, the application shall count down to zero from the time set by the user until the timer reaches zero or the user presses the pause button.

#### Once a timer has reached zero, if there is another timer in the stack, the application will start counting down to zero from the time set on the next timer until the timer reaches zero or the user presses the pause button.

#### Once the user presses the pause button, while the timer is running, the timer will stop on the current time until the user presses the start button.

### Audible Tone

#### Upon a timer reaching zero, regardless if there is another timer to run, the application will produce a brief, audible tone to indicate the timer reached zero.

### Display Timers

#### Upon the start button being pressed, while there is at least one timer in the stack, the application shall display the timer widget counting down from the user set time, until the timer reaches zero.

#### Upon the timer reaching zero, while there is no additional timers, the application shall display "Time Complete" until the user inputs more data or selects another function.

#### Upon user setting a timer, while there is no timer currently running, the application will display, a timer widget, on the "stack" below the previously set timer, or if it is the first timer in the stack, at the top of the display window.

#### Upon user clicking and dragging a timer widget, while there are multiple timers in the stack, the application shall display the order of the stack changeing, as long as the user continues to drag the timer up and down the stack.

## Non- Functional Requirements

### Keep Accurate Time

#### Once the start button is pressed, and the timer begins to run, the application shall ensure that the timer keeps accurate time in accordance with the International System of Units.

### Must be accessable from the Internet or an app

#### Once the user types in the url, the application will begin to run provieded the user has internet access. 

#### Once the user opens the app, the application will begin to run while the hardware can support the application.

### Store User Data

#### Upon a user creating an account, the application will save the data for that user that can be accessed by said user at any time.

#### Should a user save a stack of timers, the application will store that data to be accessed later by the user.






