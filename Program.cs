
int [] num;
num = new int [5];
num[0] = Convert.ToInt32(Console.ReadLine());
num[1] = Convert.ToInt32(Console.ReadLine());
num[2] = Convert.ToInt32(Console.ReadLine());
num[3] = Convert.ToInt32(Console.ReadLine());
num[4] = Convert.ToInt32(Console.ReadLine());

int[] edad =  new int[5] { 12, 58, 98, 65, 10 };

Console.WriteLine(edad[1]);


string[]nombres= new string[3];
string[]apellidos= new string[3];
int[]edades= new int[3];


Console.WriteLine("*****Captura de valores*****");
for(int i = 0; i < nombres.Length; i++)
{
    Console.Clear();
    Console.Write("Inserte el nombre: ");
    nombres[i]= Console.ReadLine()!;

    Console.Write("Inserte el apellido: ");
    apellidos[i]= Console.ReadLine()!;

    Console.Write("Inserte la edad: ");
    edades[i]= Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("*****Mostrando valores*****");
for(int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i] + " "+apellidos[i]+ " "+edades[i]);
}
Console.ReadKey();


string[]nombre=new string[3];

Console.Write("ingrese un nombre: ");
for(int i=0; i<nombre.Length; i++)
{
    Console.WriteLine("Inserte un nombre: ");
    nombre[i]= Console.ReadLine()!;
    
}

Console.WriteLine("busqueda de nombres:");
Console.WriteLine("Inserte el nombre a buscar: ");
string busqueda = Console.ReadLine()!;

for(int i = 0; i<nombre.Length; i++)
{
    if (nombre[i]== busqueda)
    {
        Console.WriteLine("Valor encontrado: "+ nombre[i]);
    }
}
Console.ReadKey();