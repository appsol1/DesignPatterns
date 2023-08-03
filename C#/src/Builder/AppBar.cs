using System;
public class AppBar {
    public string[] Properties { get; set; }
    public string[] Links { get; set; }
    public string Title { get; set; }
    public string[] Actions { get; set; }

    public void ShowAppBar() {
        Console.WriteLine(Title + " AppBar");
        Console.WriteLine("Properties: " + string.Join(", ", Properties));
        Console.WriteLine("Links: " + string.Join(", ", Links));
        Console.WriteLine("Actions: " + string.Join(", ", Actions));
    }
}