namespace ChainOfResponsibilityDesignPattern.SecondSolution;

public abstract class SecondHandler
{

    private SecondHandler? _nextHandler;

    public virtual string Handle(string name, string surname)
    {
        if (_nextHandler is not null)
        {
            Console.WriteLine("Diğer zincire geçiliyor!");
            return _nextHandler.Handle(name, surname);
        }

        return "Ben seçilen karakterlerden hiçbiri değilim!";
    }

    public SecondHandler SetNext(SecondHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }
}
