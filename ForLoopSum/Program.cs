

//kõigepealt proovime panna ForLoop käima ja kuvame konsoolis i väärtuse 

int sum = 0;    

for (int i = 0; i < 10; i++)  // i-- ehk sama mis i-1 
{
    Console.WriteLine($"i = {i}");   // selleks ,et i kirjutaks mingi nr. // i+1 on siin mõeldud ainult kuvamiseks, ei muuda i väärtust. 
    Console.WriteLine($"Current total: {sum} ");
    sum = sum + i;   // teine võimalus sum+=i

}


// - Console.WriteLine($"Final total {sum}"); siia panime kommentaarid võib ka ära võrra
 // loeme tagurpidi, selleks vaja lihtsalt teist algust. ja kõik vastupidi