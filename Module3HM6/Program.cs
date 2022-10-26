using Module3HM6;

class Program
{
    static void Main(string[] args)
    {
        var message = new MessageBox();
        var taskcompletionsourse = new TaskCompletionSource<bool>();
        message.Open();
        message.action += state =>
        {
            if (state == State.Cansel)
            {
                Console.WriteLine("Operation was canceled");
                taskcompletionsourse.SetCanceled();
            }
            else if (state == State.Ok)
            {
                Console.WriteLine("Operation was confirmed");
                taskcompletionsourse.SetResult(true);
            }

            return taskcompletionsourse.Task.GetAwaiter().GetResult();
        };
    }
}
