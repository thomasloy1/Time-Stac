# Timer App -- Detailed Requirements

## Functional Requirements

### Display Timers

#### Upon user setting a timer, while there is no timer currently running, the application will display, a timer widget, on the "stack" below the previously set timer, or if it is the first timer in the stack, at the top of the display window.

#### Upon user clicking and dragging a timer widget, while there are multiple timers in the stack, the application shall display the order of the stack changeing, as long as the user continues to drag the timer up and down the stack.

#### Upon the start button being pressed, while there is at least one timer in the stack, the application shall display the timer widget counting down from the user set time, until the timer reaches zero.

#### Upon the timer reaching zero, while there is no additional timers, the application shall display "Time Complete" until the user inputs more data or selects another function.

### Customize Timer Settings

#### Upon a user starting to input a time on a timer, the application will display the Hours: Minutes: Seconds in accordance with the user desired input.

#### Once a user finishes setting a timer, the application will store and display the set time.

#### Upon a user clicking the delete function, the application will delete the timer that was selected.

### Run Timers

#### Upon the user pressing the start button, while there is at least one timer in the stack, the application shall count down to zero from the time set by the user. 

#### Once a timer has reached zero, if there is another timer in the stack, the application will start counting down to zero from the time set on the next timer.

### Audible Tone

#### Upon a timer reaching zero, regardless if there is another timer to run, the application will produce a brief, audible tone to indicate the timer reached zero.

### Store User Data

#### Upon a user creating an account, the application will save the data for that user that can be accessed by said user at any time.

#### Should a user save a stack of timers, the application will store that data to be accessed later by the user.

#### Upon a user clicking on the name of the stack, the application will allow the user to modify the name and to store it for later use.

#### Upon the user clicking the delete function, while the user has a stack selected, the application will delete the stack selected.

## Non- Functional Requirements

### Keep Accurate Time

#### Once the start button is pressed, and the timer begins to run, the application shall ensure that the timer keeps accurate time in accordance with the International System of Units.

### Must be accessable from the Internet

#### Once the user types in the url, the application will begin to run provieded the user has internet access. 






