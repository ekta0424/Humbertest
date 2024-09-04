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
