// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilityDesignPattern.FirstSolution.ChainOfResponsibilities;
using ChainOfResponsibilityDesignPattern.SecondSolution.ChainOfResponsibilities;

#region İlk Yöntem
Console.WriteLine("##İLK YÖNTEM##");

// İşleyici örneklerini oluştur
var handlerA = new ConcreteHandlerA();
var handlerB = new ConcreteHandlerB();
var handlerC = new ConcreteHandlerC();

// Zinciri oluştur
handlerA.SetNext(handlerB);
handlerB.SetNext(handlerC);

// İsteği gönder
Console.WriteLine("İstek A gönderiliyor:");
handlerA.HandleRequest("A");

Console.WriteLine("\nİstek B gönderiliyor:");
handlerA.HandleRequest("B");

Console.WriteLine("\nİstek C gönderiliyor:");
handlerA.HandleRequest("C");

Console.WriteLine("\nİstek D gönderiliyor:");
handlerA.HandleRequest("D"); // Bu isteği hiç kimse işlemeyecek
#endregion

#region İkinci Yöntem
Console.WriteLine("\n\n--------------------");
Console.WriteLine("\n\n##İKİNCİ YÖNTEM##\n\n");
// İşleyici örneklerini oluştur
var himymChain = new RobinScherbatskyHandler();

himymChain
    .SetNext(new MarshallEriksenHandler())
    .SetNext(new TracyMcConnellHandler())
    .SetNext(new TedMosbyHandler());

Console.WriteLine();
Console.WriteLine("Robin Scherbatsky:");
Console.WriteLine(himymChain.Handle("Robin", "Scherbatsky"));

Console.WriteLine();
Console.WriteLine("Marshall Eriksen:");
Console.WriteLine(himymChain.Handle("Marshall", "Eriksen"));

Console.WriteLine();
Console.WriteLine("Tracy McConnell:");
Console.WriteLine(himymChain.Handle("Tracy", "McConnell"));

Console.WriteLine();
Console.WriteLine("Ted Mosby:");
Console.WriteLine(himymChain.Handle("Ted", "Mosby"));

Console.WriteLine();
Console.WriteLine("Ted Scherbatsky");
Console.WriteLine(himymChain.Handle("Ted", "Scherbatsky")); // Bu isteği hiç kimse işlemeyecek
#endregion