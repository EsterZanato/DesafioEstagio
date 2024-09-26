// 1,3,5,7,....

int numero1 = 1;
int razao1 = 2;

for(int i=1; i<5; i++){
    numero1 += razao1;
}
Console.WriteLine($"O próximo número será: {numero1}");

//2,4,8,16,32,64,...
int numero2 = 2;
int razao2 = 2;

for(int i = 1; i<7; i++){
    numero2 *= razao2;
}
Console.WriteLine($"O próximo número será: {numero2}");

//0,1,4,9,16,25,36,...
int numero3 = 36;
int proximoNumero = 0;

for(int i = 7; i<=8; i++){
   proximoNumero = i*i;
}
Console.WriteLine($"O próximo número será: {proximoNumero}");

//4,16,36,64,...
int numero4 = 6;
int proximaRaiz = 0;

for(int i = 10; i<11; i++){
   proximaRaiz = i*i;
}
Console.WriteLine($"O próximo número será: {proximaRaiz}");

//1,1,2,3,5,8,...
int x=1, y=0, z=0;

for(int i=2; i<8; i++){
    z=x + y;
    y=x;
    x=z;
}
Console.WriteLine($"O próximo número será: {z}");

//2,10,12,16,17,18,19,...
Console.WriteLine("O próximo número é: 200 (depois de horas refletindo o google me disse que é uma charada kkkk)");

