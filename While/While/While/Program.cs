//Console.WriteLine("joonistan sulle kolmnurga");
//int kolmnurgaSuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while (i <= kolmnurgaSuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= i)
//    {
//        Console.Write("▓");
//        j++;
//    }
//    i++;
//}


Console.WriteLine("tere tulemast, mobfix parandusavtomaati! kuidas aidata?");
Console.WriteLine("0 - headaega\n1 - tahan telefoni parandada");
Console.WriteLine("palun tee valik, kirjutades vastav arv:");
int valik = int.Parse(Console.ReadLine());
while(valik < 0 && valik > 1)
{
    Console.WriteLine("palun tee oma valik, kirjatades vastav arv");
    valik = int.Parse(Console.ReadLine());
}
if (valik == 0)
{
    Console.WriteLine("headaega tulge teinekord jälle!");
}
else
{
    Console.WriteLine("palunsisesta oma telefoni mudel, mida parandada soovid");
    Console.WriteLine("1-föön\n2-xiomi\n3huavei\n4-samsung");
    Console.WriteLine("palun tee oma valik, kirjatades vastav arv");
    int telefonimudel = 0;
    telefonimudel = int.Parse(Console.ReadLine());
    while (telefonimudel < 1 && telefonimudel > 4)
    {
        telefonimudel = int.Parse(Console.ReadLine());
        Console.WriteLine("palun tee valik, kirjutades vastav arv:");
    }
    switch (telefonimudel)
    {
        case 1:
            Console.WriteLine("äitah oma iFööni saad 1 nädala pärast");
            break;
        default:
            break;

        case 2:
            Console.WriteLine("äitah oma xiomi saad 2 kuu pärast");
            break;
        case 3:
            Console.WriteLine("kahjuks me huaveid ei teeeninda");
            break;
        case 4:
            Console.WriteLine("sinu samsung on valmis  2 päeva pärast");
            break;
        default:
            Console.WriteLine("ei tunne sellist telefonitootjat");
            break;  



    }
}