// Esimene tsükkel millest hakkame rääkima on FOR-Loop. Siin alumises näiteks tsükkel peab kordama 5 korda 
//DRY-principle - do not repeat TYourself


int i = 0;   // selle kirjutasime kõige lõpus alles. sest for tsükkel lõpetab peale kontrollimist töö. 
for (i = 0; i < 5; i++)   //  int i =0 ehk start, algväärtus. Int kustutasime lõpus kui kood valmis maha, sest vahemälus ei saa hoida kahte muutujat.
                          //  Ja lisasime selle int i = 0 üles reale , siis näitab program numbrit mitu rida tehti. 
                              //  i< 5 ehk tingimus kus peab lõppema tsükkli töö, ehk ka end
                              //  i++ ehk sama mis i+1 ehk ka stop 
    
{
    Console.WriteLine("We don´t need no education.");

}

Console.WriteLine(i);

Console.WriteLine("Have a nice day!");