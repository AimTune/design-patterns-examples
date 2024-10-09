namespace ChainOfResponsibilityDesignPattern.SecondSolution.ChainOfResponsibilities;

public class RobinScherbatskyHandler : SecondHandler
{
    public override string Handle(string name, string surname)
    {
        if (name == "Robin" && surname == "Scherbatsky")
        {
            return "Ben Robin Scherbatsky'im";
        }

        return base.Handle(name, surname);
    }
}
