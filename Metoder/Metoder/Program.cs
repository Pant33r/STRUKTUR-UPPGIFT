
//FIGHTINGSPELET
Random generator=new Random();
int result = generator.Next(0,100); 

int hp = 100;
int ophp = 100;
string utmanarnamn="utmanare";
string gladiatornamn="gladiator";

Console.WriteLine("Välkommen till arenan kära utmanare");
Console.WriteLine("Du kommer nu att möta en av våra starkaste gladiatorer");
Console.Clear();
while(hp > 0 && ophp >0)
{
    //utmanarens tur
    Console.WriteLine("Du kommer ut på arenan och det är tusentals människor som tittar på dig");
    Console.WriteLine("Du ser gladiatorn i mitten av arenan som precis dödat flertalet slavar");
    Console.WriteLine("/----- _____ Första rundan _____ -----");
    
    int svärd = generator.Next(0,60);
    ophp-=svärd;
    ophp = Math.Max(0,ophp);
    Console.WriteLine($"{utmanarnamn} hugger motståndaren med sitt svärd vilket gör {svärd} skada på {gladiatornamn}");

    int klubba=generator.Next(10,60);
    hp-=klubba;
    hp=Math.Max(0,hp);
    Console.WriteLine($"{gladiatornamn} slår utmanaren med sin  klubba vilket gör {klubba} skada på {utmanarnamn} ");

    Console.WriteLine("tryck på tangentbordet för att göra ditt nästa drag");
    Console.ReadKey();
    Console.Clear();
}

Console.WriteLine("-----_____striden är slut_____-----");
if(hp==0&&ophp==0){
    Console.WriteLine("Ni får in en träff på varandra samtidigt och tar ut varandra");
}
else if (hp==0){
    Console.WriteLine($"{gladiatornamn} dödade utmanaren och vann!");
}
else{
    Console.WriteLine($"{utmanarnamn} dödade gladiatorn!");
}

Console.WriteLine("Tryck på valfri knapp för att lämna arenan");
Console.ReadKey();
