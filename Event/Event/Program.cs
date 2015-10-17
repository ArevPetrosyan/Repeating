using System;

namespace Event
{
    delegate void PushPrinterButton();//1. classified delegate

    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            //3. registration event
            mouse.Click += new PushPrinterButton(mouse.OnMouseClick);
            // ...
            // ...
            // ...
            mouse.DoEvent();
        }
    }

    class Mouse
    {
        public event PushPrinterButton Click;//2. classified event type - click mouse button
        public void DoEvent()//4. generation event
        {
            if(Click!=null)
            Click();//run event
        }

        public void OnMouseClick()
        {
            Console.WriteLine("click mouse - ok...");
            Console.ReadLine();
        }
    }
}
