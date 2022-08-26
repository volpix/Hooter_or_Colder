// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace PL
{
    class Program
    {
        public static string HottteronColder(int num)
        {
            int numeroaleatorio = Form1_Load();
            string mensaje;
            if (num >= 1 || num <= 100)
            {
                if (num == numeroaleatorio)
                {
                    return mensaje = "You got it";
                }
                else if (num == numeroaleatorio + 9 || num >= numeroaleatorio - 9)
                {
                    return mensaje = "Hotter";
                }
                else if (num == numeroaleatorio + 10 || num == numeroaleatorio - 10)
                {
                    return mensaje = "Hot";
                }
                else if (num == numeroaleatorio + 20 || num == numeroaleatorio - 20)
                {
                    return mensaje = "Cold";
                }
                else if(num <= numeroaleatorio - 21 || num >= numeroaleatorio - 21)
                {
                    return mensaje = "Colder";
                }
            }
            else
            {
                if (num == 0 || num >= 101)
                    return mensaje = "El numero no esta dentro del rango";
            }
            return mensaje = "Ocurrio un error";
        }
        
        public static int Form1_Load()
        {
            int numeroaleatorio = 0;
            Random rnd = new Random();
            numeroaleatorio = rnd.Next(1, 100);
            return numeroaleatorio;
        }
        static void Main(string[] args)
        {
            int num = 0;
            while(num != 2)
            {
                Console.WriteLine("Menu" + "\n1-Play" + "\n2-Exit");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1: Console.WriteLine("Favor de Ingresar un numero dentro del rango del 1 al 100");
                        num = int.Parse(Console.ReadLine());
                        string mensaje = HottteronColder(num);
                        Console.WriteLine(mensaje);
                        break;
                    case 2: Console.WriteLine("Exit");
                        break;
                }
            }
        }
    }
}