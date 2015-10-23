using System;

namespace Event02
{
    //PrintStarted
    //PrintFinished

    /*
     * var p = new Printer();
     * p.PrintStarted += (sender, e) => { Console.WriteLine("Print Started."); };
     * p.Printing += (sender, e) => 
     * { 
     *      Console.WriteLine("Printing {0} out of {1}.", e.Current, e.Total); 
     * };
     * p.PrintFinished += (sender, e) => { Console.WriteLine("Print Finished."); };
     * p.Print(5);
     */







    delegate void PushPrinterButton();//haytararecinq PushPrinterButton delegat, cucich metodi vra
    class Program
    {
        static void Main(string[] args)
        {
            

            Mouse mouse = new Mouse();
            PushPrinterButton del = new PushPrinterButton(mouse.OnMouseClick);//haytararecinq PushPrinterButton tipi del
                                                                              // mouse.Click += new PushPrinterButton(mouse.OnMouseClick);//delegat@ cuyc e talis methodi vra
            mouse.Click += del;//click-@ kkanchi del-in
            //event@ kapecinq methodin
            //event@ iradarcutyun e
            //nran kapac method@ iradarcutyan hetevanq@


            mouse.DoEvent();

            Console.ReadKey();
        }
    }

    class Mouse
    {
        public event PushPrinterButton Click;//iradarcutyan haytararum
        public void DoEvent()//generacnum e oradarcutyun@, piti kanchel DoEvent@, vor iradarcutyun texi unena
        {
            if(Click!=null)
            Click();//method, vor@ kanchum e click-@
        }

        public void OnMouseClick()
        {
            Console.WriteLine("You click button print");
            Console.WriteLine("Start print");
            Console.Read();
        }
    }
}
