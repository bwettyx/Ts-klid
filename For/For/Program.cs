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

// 4. foreach
int[] arvuLoend = { 3, 89, 123412, 7, 67 }; //massiiv mida foreach tsükkel kasutab, või töötleb mingil kujul.
foreach (var arvInLoend in arvuLoend) // kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                      // ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev
                                      // kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend"
                                      // muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtavat
                                      // tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub ehk tsükli töö käib
                                      // iga üksiku elemendi kohta andmekogumis. Tsüklit ei ole vaja tsüklimuutujasse, kuna talle on
                                      // sisse ehitatud vaikimisi elemendi järjestuse jälgimine. Niipalju kui andmeid on, ongi see,
                                      // mitu korda tsükkel käivitatakse.
                                      // {} koodiplokk kus tehakse mingi tegevus
                                      // antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi element.
// 2. loend:
// List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
//            Täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse asetatakse mis tüüpi andmed loendis on.
//            Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on. Loendisse saab dünaamiliselt elemente juurde
//            Lisada, ehk tema pikkus ei ole fikseeritud.
//            Sarnaselt massiiviga, saab loend omada endas, teisi loendeid.
//
// Esimene tekitusviis:
List<int> arvuNimekiri = new List<int>(); //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, List noolsulgude vahel on loendis
                                          //olevate andmete andmetüüp. muutuja nimeks on "arvuNimekiri". Omistame sellesse muutujasse
                                          //kaitstud sõna "new" abil uue tühja täisarvuloendi sätestusega "List<int>()".
// Teine tekitusviis:
List<int> arvuNimekiri2 = new List<int>() {1,2,3}; //teine loendi tekitusviis, muutuja instantseerimine võrdusmärgi ees on sama nagu
                                                   //esimesel, juurde tuleb ainult võrdusmärgi taga olevate sätestustele loogelised
                                                   //sulud koos juba sinna asetatud elementidega. Enam ei ole tegu tühja nimekirjaga,
                                                   //vaid loendiga kus on kolm elementi.
                                                   // Kolmas tekitusviis:
List<int> arvuNimekiri