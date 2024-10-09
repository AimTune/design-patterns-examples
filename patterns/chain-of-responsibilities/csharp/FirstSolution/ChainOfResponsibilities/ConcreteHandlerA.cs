namespace ChainOfResponsibilityDesignPattern.FirstSolution.ChainOfResponsibilities;

public class ConcreteHandlerA : FirstHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "A")
        {
            Console.WriteLine("Handler A: İsteği işliyor.");
        }
        else if (next != null)
        {
            next.HandleRequest(request);
        }
    }
}