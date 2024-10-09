namespace ChainOfResponsibilityDesignPattern.FirstSolution.ChainOfResponsibilities;

public class ConcreteHandlerC : FirstHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "C")
        {
            Console.WriteLine("Handler C: İsteği işliyor.");
        }
        else if (next != null)
        {
            next.HandleRequest(request);
        }
    }
}