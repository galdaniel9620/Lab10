using System.Net.Http.Headers;
using Lab10;
using Lab10.Devices;

var cashRegister = new CashRegister();
var classicCard = new ClassicCard();
var contactlessCard = new ContactlessCard();
var phone = new SmartPhone();

cashRegister.ProcessCashPayment(122);
Console.WriteLine("...");

cashRegister.GetPOS().AcceptContactFullPayment(classicCard, 120);
Console.WriteLine("...");

cashRegister.GetPOS().AcceptContactFullPayment(contactlessCard, 50);
Console.WriteLine("...");

cashRegister.GetPOS().AcceptContactlessPayment(contactlessCard, 300);
Console.WriteLine("...");

cashRegister.GetPOS().AcceptContactlessPayment(phone, 200);
