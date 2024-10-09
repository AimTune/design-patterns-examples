namespace ChainOfResponsibilityDesignPattern.SecondSolution.ChainOfResponsibilities;

public class MarshallEriksenHandler : SecondHandler
{
    public override string Handle(string name, string surname)
    {
        if (name == "Marshall" && surname == "Eriksen")
        {
            return "Ben Marshall Eriksen'im";
        }

        return base.Handle(name, surname);
    }
}
