//Console.WriteLine("For tsükkel");

//int kogus = 5;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("🤬");
//    Console.Beep();
//}

//string[] objectArray = new string[5]; //array, massiiv mitmest elemendist
int objectCount = 0; //loend kui palju kordi küsida
//string temp = "no name"; // muutuja mis hetkel on "tühi"
//while (objectCount < 5) //while tsükkel mis küsib nimesid
//{
//    Console.WriteLine("Sisesta järgmine lemmikloomanimi:");
//    temp = Console.ReadLine(); // temp muutujasse väärtuse (mida me tahame) sisestamine
//    objectArray[objectCount] = temp; //massiivi, asukohal objectCount asetame ajutiselt muutujast väärtuse
//    objectCount++; // tsükli inkrementatsioon
//}
//Console.WriteLine("Oled sisestanud järgnevad objektid"); // sõnum
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i + 1}. element on: {objectArray[i]}");
//    //kuvame välja reanumbri koos vastava elenemdiga, muutuja i abil.
//}
//Console.ReadLine(); //peatame programmi klahvisisestuse taha

// kirjuta programm mis küsib kasutajalt tema nime ja parooli
// kui parool on vale, anna nimeline teavitus
// kui nimi on vale, ütle et isik pole registreerunud
// tekita massiiv suurusega 3
// kui mõlemad on õiged, siis while tsüklis küsi kasutajalt tema 3 lemmikloomanime
// kuva talle sisestuste arv (mitu ta sisestas)
// ning küsi milline on ta lemmikuim
// tagasta kasutajale lause koos selle lemmiknimega, adresseerides seda järjendist[]

string Nimi = "Mariell";
string pass = "12345";

Console.WriteLine("Palun sisesta oma nimi: ");
string nimi = Console.ReadLine();
Console.WriteLine("Palun sisesta oma parool");
string parool = Console.ReadLine();
if (nimi != Nimi)
{
    Console.Write("Isik pole registreerunud");
    return;
}
if (parool != pass)
{
    Console.Write($"{nimi} teie parool on vale.");
    return;
}

string[] lemmikloomad = new string[3];
int objectcount = 0;
string tühi = "no name";
while(objectCount < 3)
{
    Console.WriteLine($"Sisesta oma {objectCount + 1} lemmiklooma nimi: ");
    tühi = Console.ReadLine();
    lemmikloomad[objectCount] = tühi;
    objectCount++;
}
Console.WriteLine($"Sisestatud loomad: {lemmikloomad.Length}");

Console.WriteLine("Milline on sinu lemmikuim loom 1-3?");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number <= lemmikloomad.Length)
{
    string lemmik = lemmikloomad[number -1];
    Console.WriteLine($"Sinu lemmikloom on {lemmik}");
}
