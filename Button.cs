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
