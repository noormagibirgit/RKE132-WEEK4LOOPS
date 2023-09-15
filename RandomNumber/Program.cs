
// juhuslik number , kasutatakse nt.krüpteerimisel

Random rnd = new Random();  // nii kutsume välja klassi, mis on datnetframworki osa. sisseehitatud süsteemis

int myRandomNum;

int randomSum = 0;  

for ( int i = 0; i < 3; i++)  // genereerib 3 korda juhuslikku väärtust. kui võtta see for ära ja lihtsalt int MyRandomNum ja Console.writeline... read jätta
    //siis genereerib lihtsalt ühe korra juhusliku väärtuse.  
{

    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;   
    Console.WriteLine($"My random number is :{myRandomNum}");

}

Console.WriteLine($"My random sum total {randomSum}: ");