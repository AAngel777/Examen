using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen { 

    public class Registro
    {
        public string namep, descrip;
        public float price;
        public long stock;
        public Registro(string namep, string descrip, float price, long stock)
        {
            this.namep = namep;
            this.descrip = descrip;
            this.price = price;
            this.stock = stock;

        }
        public void registro()
        {

            try
            {
                StreamWriter sw = new StreamWriter("Productos.txt", true);
                sw.WriteLine(namep);
                sw.WriteLine(descrip);
                sw.WriteLine(price);
                sw.WriteLine(stock);
                sw.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine("Error " + e.Message);
            }

        }
        public void Lee()
        {
            try
            {
                StreamReader sr = new StreamReader("Productos.txt", true);
                sr.ReadToEnd();
                Console.WriteLine(namep + descrip + price + stock);

            }
            catch (IOException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }

        static void Main(string[] args)
        {
            string namep;
            string descrip;
            float price;
                long stock;
            char opc;

            do
            {
                Console.WriteLine("MENU REGISTRO DE PRODUCTOS");
                Console.WriteLine("1) Añadir un producto");
                Console.WriteLine("2) Visualizar productos");
                Console.WriteLine("3) Salir del Programa");

               
                    opc = char.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case '1':
                        Console.Write("Ingrese nombre del producto: ");
                        namep = Console.ReadLine();
                        Console.Write("Descripcion del producto: ");
                        descrip = Console.ReadLine();
                        Console.Write("Ingrese el precio del producto: ");
                        price = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese cantidad en stock: ");
                        stock = long.Parse(Console.ReadLine());
                        Registro o1 = new Registro(namep,descrip,price,stock);
                            o1.registro();
                        o1.Lee();
                            Console.WriteLine("Pulse <enter> para continuar");
                            Console.ReadLine();
                            break;
                        case '2':
                        o1.Lee();

                            Console.WriteLine("Pulse <enter> para continuar");
                            Console.ReadLine();
                            break;
                        case '3':
                            Console.WriteLine("Pulse <enter> para salir...");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Ingrese un numero del 1 al 3");
                            break;

                    }
                Console.Clear();
                } while (opc != '3') ;
        }
    }
}
