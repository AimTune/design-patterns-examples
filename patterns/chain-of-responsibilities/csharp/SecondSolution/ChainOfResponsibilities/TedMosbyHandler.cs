namespace ChainOfResponsibilityDesignPattern.SecondSolution.ChainOfResponsibilities;

public class TedMosbyHandler : SecondHandler
{
    public override string Handle(string name, string surname)
    {
        if (name == "Ted" && surname == "Mosby")
        {
            return "Ben Ted Mosby'im";
        }

        return base.Handle(name, surname);
    }
}
