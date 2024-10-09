namespace ChainOfResponsibilityDesignPattern.SecondSolution.ChainOfResponsibilities;

public class TracyMcConnellHandler : SecondHandler
{
    public override string Handle(string name, string surname)
    {
        if (name == "Tracy" && surname == "McConnell")
        {
            return "Ben Tracy McConnell'ım";
        }

        return base.Handle(name, surname);
    }
}
