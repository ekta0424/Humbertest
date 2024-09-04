public class ButtonHandler
{
    // Method to handle the button click event
    public void OnButtonClicked(object sender, ButtonClickedEventArgs e)
    {
        Console.WriteLine(e.Message);
    }
}
