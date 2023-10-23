using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectadd1 = new Address("4988 Nuviu Fiolanse-3");

        Lecture lect1 = new Lecture(lectadd1);
        lect1.StandarDetails();
        lect1.FullDetails();
        lect1.ShortDescription();

        Address repadd1 = new Address("4198 Street La 13");

        Reception rep1 = new Reception(repadd1);
        rep1.StandarDetails();
        rep1.FullDetails();
        rep1.ShortDescription();

        Address outadd1 = new Address("Apple Corps headquarters rooftop");

        Outdoor out1 = new Outdoor(outadd1);
        out1.StandarDetails();
        out1.FullDetails();
        out1.ShortDescription();



    }
}