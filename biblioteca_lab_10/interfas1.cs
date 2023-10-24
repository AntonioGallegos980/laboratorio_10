using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    internal class interfas1
    {

        static void Main(string[] args)
        {
            int totalVentasMPhones = 0;
            int totaldevueltasmphones = 0;
            int totalVentasMPads = 0;
            int totaldevueltasmpads = 0;
            int totalVentasMAPBrooks = 0;
            int totaldevueltasmapbrooks = 0;
            int totalVentasMWatches = 0;
            int totaldevueltasmwatches = 0;
            int totalVentasProductos;
            int total1=0;
            int total2=0;
            int total3= 0;
            int total4= 0;
            int opcion;
            int opcion_1;
            int opcion2;
            int opcion2_1;

            do
            {
                opcion = letras1.Menu_principal();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        letras1.mphone_3000_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                letras1.letras2_2_1();
                                Console.WriteLine("un mPhone 3000 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMPhones++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                letras1.letra2();
                                Console.WriteLine("un mPhone 3000 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmphones++;
                                }
                                break;
                        }
                        total1 = totalVentasMPhones - totaldevueltasmphones;
                        break;

                    case 2:
                        letras1.mPad_3500_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                letras1.letras2_2_1();
                                Console.WriteLine("un mPad 3500 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMPads++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                letras1.letra2();
                                Console.WriteLine("un mPad 3500 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmpads++;
                                }
                                break;
                        }
                        total2 = totalVentasMPads + totaldevueltasmpads;
                        break;

                    case 3:
                        letras1.MAPBrook_3800_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                letras1.letras2_2_1();
                                Console.WriteLine("un MAPBrook 3800 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMAPBrooks++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                letras1.letra2();
                                Console.WriteLine("un MAPBrook 3800 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmapbrooks++;
                                }
                                break;
                        }
                        total4 = totalVentasMAPBrooks - totaldevueltasmapbrooks;
                        break;

                    case 4:
                        letras1.mWatch_8000_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                letras1.letras2_2_1();
                                Console.WriteLine("un mWatch 8000 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMWatches++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                letras1.letra2();
                                Console.WriteLine("un mWatch 8000 ¿Desea Continuar?");
                                letras1.letra2_1();
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmwatches++;
                                }
                                break;
                        }
                        total4 = totalVentasMWatches - totaldevueltasmwatches;
                        break;
                    case 5:
                        Console.WriteLine("==========ReporteFinal==========\n");
                        Console.WriteLine("Productos Vendidos | Cantidad");
                        Console.WriteLine("mPhones            | " + totalVentasMPhones);
                        Console.WriteLine("mPads              | " + totalVentasMPads);
                        Console.WriteLine("MAPBrooks          | " + totalVentasMAPBrooks);
                        Console.WriteLine("mWatches           | " + totalVentasMWatches);
                        totalVentasProductos = total1 + total2 + total3 + total4;
                        Console.WriteLine("================================\n");
                        Console.WriteLine("Total              | " + totalVentasProductos);
                        Console.WriteLine("================================\n" +
                            "¡Hasta Luego!\n");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 5);
            {
                
            }
        }
    }
}
