// See https://aka.ms/new-console-template for more information
using static DelegateClass;

Console.WriteLine("Hello, World!");
DelegateClass delegateClass = new DelegateClass();

delegateDefination dele = new delegateDefination(delegateClass.Area);
dele += delegateClass.Perimeter;
dele(12, 13);