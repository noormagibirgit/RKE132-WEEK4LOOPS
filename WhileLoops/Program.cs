// While loop tsükkel . mis paneb meie koodi käima niikaua kuni mingi tingimus täitub , seda läheb vaja siis kui me ei oska ennustada, mitu korda 
//meil läheb vaja seda koodi käima panna. 

Random rnd = new Random();
int cpuRandom;

bool loopActive = true; // bool + true/false


while (loopActive)  // nii kaua kuni vastus on true 
{
    cpuRandom = rnd.Next(1, 4);  // cpu ehk arvuti number juhuslik väärtus 
    Console.WriteLine($"cpu has generated {cpuRandom}. ");  // näen programmi käima pannes, mis numbrit arvuti kuvab
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());  // peame parsima seda mida kasutaja annab. Konsool loeb string ehk sõne formaadis ja peame parsima numbriks
    
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false;  // kui said õige vastuse, siis arvuti enam ei küsi uut numbrit , siin real võib kasutada ka break;
      
    }
    else
    {
        Console.WriteLine("Oops, Try again.");
    }
}
Console.WriteLine("Have a nice day!");