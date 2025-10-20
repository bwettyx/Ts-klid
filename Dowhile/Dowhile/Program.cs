// See https://aka.ms/new-console-template for more information

string kasutajanimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi");
    kasutajanimi = Console.ReadLine();
}
while (kasutajanimi != "user1");
if (kasutajanimi == "user1")
{
    int ruuduSuurus = 0;

    do
    {
        Console.WriteLine("Kui suurt ruutu tahad?");
        ruuduSuurus = int.Parse(Console.ReadLine());
    } while (ruuduSuurus < 0 && ruuduSuurus > 20);
    char reaKujund = '©';
    string üksRida = "";
    int tsükliMuutuja = ruuduSuurus;
    do
    {
        üksRida += "_"+reaKujund;
        tsükliMuutuja -= 1;
    } while (tsükliMuutuja != 0);
    tsükliMuutuja = ruuduSuurus;
    do
    {
        Console.WriteLine(üksRida);
        tsükliMuutuja -= 1;

    } while (tsükliMuutuja != 0);
    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
}
if (true){} //kaitstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel ning millele järgneb
              //koodiplokk tingimuste täitumisel teostatava koodiga
else if (true){} //kaitstud sõna else ja if (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
                 //on samamoodi sulgude vahel, ning millele peab eelnema alati if või else if. Tingimuse täitumisel
                 //ja eelneva tingimuse mittetäitumisel teostatakse koodiploki sees olev kood
else {} //kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas if või else if, ning mille koodi-
        //ploki sisu täidetakse kõikide if ja else if sees olevate tingimuste läbikukkumisel.

/* Loogilised tehted */
// && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) juhul kui
//     mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
// || -> "or" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) siis kui
//     vähemalt üks tingimus on täidetud. negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
// !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärgi
//      puhul tagastab false, ja vastupidi - tulemus mis muidu tagastaks false, hüüumargi puhul tagastab true.

/* Võrdlusoperaatorid */
// == -> on võrdne. Võrdlusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt Võrdlusmärkide teisel pool oleva
//       objektiga. ei ole sama nagu üks võrdlusmärk. üks võrdlusmärk omistab, kaks võrdleb.
// != -> ei ole võrdne. Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt.
//       Võrdlusoperaator on kombinatsioon "on võrdne" operaatorist, ja loogilisest tehtest "not".
// >  -> on suurem kui. Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt.
// <  -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
// >= -> on suurem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem
//       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
// <= -> on väiksem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
//       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

/* Omistusoperaatorid ja kiirtehted */
int arv = 1;// =  -> üksik võrdusmärk omistab muutujale väärtuse.
arv += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
            //       asendab tehet "arv = arv + 1". on kombinatsioon matemaatilisest tehest "+" ja omistamisest ("=")
arv -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse.
            //       asendab tehet "arv = arv - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "="
arv *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk *. automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva
            //       arvu kordi. asendab tehet "arv = arv