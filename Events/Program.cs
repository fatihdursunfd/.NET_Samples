/*
 * Event br olayın/durumun/askiyonun vs. meydana geldiğini ve bu olaya karşın tepki vermek amacıyla kullanılan bir özelliktir.
 * Delegate'ler ile beraber kullanılırlar.
 * Kullanım amaçları : 
 * 1) Olayları izlemek ve tepki vermek
 * 2) Olayları kaydetmek
 * 3) İletişim
 */

using Events;



MyEventPublisher myEventPublisher = new();

// subscribe
myEventPublisher.MyEvent += myEventPublisher.MyEventMethod;

myEventPublisher.RaiseEvent();

// unsubscribe
myEventPublisher.MyEvent -= myEventPublisher.MyEventMethod;

Console.WriteLine("*************************************");

MyEventPublisher2 myEventPublisher2 = new();

myEventPublisher2.MyEvent += myEventPublisher.MyEventMethod;
myEventPublisher2.RaiseEvent();
myEventPublisher2.MyEvent -= myEventPublisher2.MyEventMethod;

Console.WriteLine("*************************************");

string path = @"C:\Users\FatihDursun\OneDrive - Neyasis Bilgi Teknolojileri A.Ş\Masaüstü\FD\C#\C#_Samples\Events";

PathControl pathControl = new PathControl();
pathControl.PathControlEvent += (size) => pathControl.Stop(size);

await pathControl.Control(path);
