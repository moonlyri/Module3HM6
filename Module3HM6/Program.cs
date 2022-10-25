using Module3HM6;

class Program
{
    static void Main(string[] args)
    {
        var message = new MessageBox();
        message.Open();
        message.action += state =>
        {
            if (state == State.Cansel)
            {
                Console.WriteLine("Operation was canceled");
            }
            else if (state == State.Ok)
            {
                Console.WriteLine("Operation was confirmed");
            }

            return false;
        };

    }
}
