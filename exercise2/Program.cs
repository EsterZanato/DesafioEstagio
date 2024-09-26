
Console.WriteLine("Digite uma frase: ");
string phrase = Console.ReadLine();

int count = 0;
 
foreach (char c in phrase){
    if (c == 'a' || c == 'A') {
        count++;
    }
}

if (count > 0){
    Console.WriteLine($"A letra 'a' aparece no seu programa {count} vezes");
}
else{
    Console.WriteLine("A letra 'a' não foi aparece nesta frase!");
}