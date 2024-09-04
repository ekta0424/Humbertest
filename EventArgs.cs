using System;

// Define a custom EventArgs class to hold event data
public class ButtonClickedEventArgs : EventArgs
{
    public string Message { get; }

    public ButtonClickedEventArgs(string message)
    {
        Message = message;
    }
}

// Define a delegate for the event
public delegate void ButtonClickedEventHandler(object sender, ButtonClickedEventArgs e);

public class Button
{
    // Declare the event using the delegate
    public event ButtonClickedEventHandler ButtonClicked;

    // Method to simulate a button click
    public void Click()
    {
        // Check if there are any subscribers
        if (ButtonClicked != null)
        {
            // Create event data
            ButtonClickedEventArgs args = new ButtonClickedEventArgs("Button was clicked!");
            // Raise the event
            ButtonClicked(this, args);
        }
    }
}

public class ButtonHandler
{
    // Method to handle the button click event
    public void OnButtonClicked(object sender, ButtonClickedEventArgs e)
    {
        Console.WriteLine(e.Message);
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Button and ButtonHandler
        Button button = new Button();
        ButtonHandler handler = new ButtonHandler();

        // Associate the event with the event handler
        button.ButtonClicked += handler.OnButtonClicked;

        // Simulate a button click
        button.Click();
    }
}
