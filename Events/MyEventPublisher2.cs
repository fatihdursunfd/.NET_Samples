namespace Events
{
    public class MyEventPublisher2
    {
        public delegate void MyEventHandler();
        MyEventHandler my_delegate;

        public event MyEventHandler MyEvent
        {
            add 
            {
                Console.WriteLine("An event method has been subscribed.");
                my_delegate += value; 
            }
            remove 
            {
                Console.WriteLine("An event method has been unsubscribed.");
                my_delegate -= value; 
            }
        }

        public void RaiseEvent()
        {
            my_delegate();
        }

        public void MyEventMethod()
        {
            Console.WriteLine("Event has been triggered");
        }

    }
}