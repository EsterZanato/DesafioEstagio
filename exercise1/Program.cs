//Sequência fibonacci
Console.WriteLine("Digite um numero");
int n;
int x=1, y=0, z=0;
n=int.Parse(Console.ReadLine());
Console.Clear();
while(z<n){
    z= x + y;
    y=x;
    x=z;
    
    if(z>n){
        Console.Write("Seu número não faz parte da sequência Fibonacci");
    }
    else if(z == n){
        Console.WriteLine("Seu número faz parte da sequência Fibonacci!!");
    }
}
