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
