namespace Module3HM6;

public class MessageBox
{
    public event Predicate<State> action;

    public async void Open()
    {
        Console.WriteLine("The window is open");
        await Task.Delay(3000);
        Console.WriteLine("The window was closed by user");
        var state = new State();
        int result = new Random().Next(0, 1);
        switch (result)
        {
            case 1:
                state = State.Cansel;
                break;
            case 2:
                state = State.Ok;
                break;
        }

        
    }
}