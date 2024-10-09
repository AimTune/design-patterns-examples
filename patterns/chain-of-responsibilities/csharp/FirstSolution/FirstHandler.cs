namespace ChainOfResponsibilityDesignPattern.FirstSolution;

public abstract class FirstHandler
{
    protected FirstHandler? next;

    // Bir sonraki işleyiciyi ayarla
    public void SetNext(FirstHandler nextHandler)
    {
        this.next = nextHandler;
    }

    // İsteği işleyen soyut metot
    public abstract void HandleRequest(string request);
}
