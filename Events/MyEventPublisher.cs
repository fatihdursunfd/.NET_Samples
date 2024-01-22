namespace Events
{
    public class MyEventPublisher
    {
        public delegate void MyEventHandler();
        public event MyEventHandler MyEvent;

        public void RaiseEvent()
        {
            MyEvent();
        }

        public void MyEventMethod()
        {
            Console.WriteLine("Event has been triggered");
        }

    }
}