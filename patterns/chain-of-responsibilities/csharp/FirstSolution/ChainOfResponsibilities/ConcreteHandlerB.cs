namespace ChainOfResponsibilityDesignPattern.FirstSolution.ChainOfResponsibilities;

public class ConcreteHandlerB : FirstHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "B")
        {
            Console.WriteLine("Handler B: İsteği işliyor.");
        }
        else if (next != null)
        {
            next.HandleRequest(request);
        }
    }
}