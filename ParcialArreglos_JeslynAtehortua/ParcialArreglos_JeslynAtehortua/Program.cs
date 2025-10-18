namespace ParcialArreglos_JeslynAtehortua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ocupacion = new int[6, 4];
            double[,] facturacion = new double[6, 4];
            string[] letras = { "A", "B", "C", "D", };
            int i, j;

            Console.WriteLine("Gestion de ocupacion y  facturacion del hotel\n");

            i = 0;
            while (i < 6)
            {
                Console.WriteLine("Piso " + (i + 1));
                j = 0;
                while (j < 4)
                {
                    Console.WriteLine("Piso " + (i + 1));
                    j = 0;
                    while (j < 4)
                    {
                        int noches = -1;
                        while (noches < 0 || noches > 365)
                        {
                            Console.WriteLine("Habitacion" + letras[j] + "'-noches (0-365):");
                            noches = int.Parse(Console.ReadLine());
                            if (noches < 0 || noches > 365)
                            {
                                Console.WriteLine("valor invalido,repita");
                            }
                        }
                        ocupacion[i, j] = noches;

                        double monto = -1;
                        while (monto < 0) ;
                        {
                            Console.WriteLine("Habitacion" + letras[j] + "-monto:$");
                            monto = double.Parse(Console.ReadLine());
                            if (monto < 0)
                            {
                                Console.WriteLine("monto invalido , repita");
                            }

                        }
                        facturacion[i, j] = monto;

                        j = j + 1;
                    }
                    i = i + 1;
                }

               
                Console.WriteLine("\nMATRIZ DE OCUPACIÓN (Noches)");
                Console.Write("\tA\tB\tC\tD\n");
                i = 0;
                while (i < 6)
                {
                    Console.Write("Piso " + (i + 1) + "\t");
                    j = 0;
                    while (j < 4)
                    {
                        Console.Write(ocupacion[i, j] + "\t");
                        j = j + 1;
                    }
                    Console.WriteLine();
                    i = i + 1;
                }

                
                Console.WriteLine("\nMATRIZ DE FACTURACIÓN ($)");
                Console.Write("\tA\tB\tC\tD\n");
                i = 0;
                while (i < 6)
                {
                    Console.Write("Piso " + (i + 1) + "\t");
                    j = 0;
                    while (j < 4)
                    {
                        Console.Write(facturacion[i, j].ToString("F2") + "\t");
                        j = j + 1;
                    }
                    Console.WriteLine();
                    i = i + 1;
                }

                
                Console.WriteLine("\nTOTAL DE NOCHES POR PISO:");
                i = 0;
                while (i < 6)
                {
                    int totalPiso = 0;
                    j = 0;
                    while (j < 4)
                    {
                        totalPiso = totalPiso + ocupacion[i, j];
                        j = j + 1;
                    }
                    Console.WriteLine("Piso " + (i + 1) + ": " + totalPiso);
                    i = i + 1;
                }

                
                Console.WriteLine("\nINGRESO TOTAL POR HABITACIÓN:");
                j = 0;
                while (j < 4)
                {
                    double totalHabitacion = 0;
                    i = 0;
                    while (i < 6)
                    {
                        totalHabitacion = totalHabitacion + facturacion[i, j];
                        i = i + 1;
                    }
                    Console.WriteLine("Habitación " + letras[j] + ": $" + totalHabitacion.ToString("F2"));
                    j = j + 1;
                }

                
                double max = facturacion[0, 0];
                int pisoMax = 0;
                int habMax = 0;
                i = 0;
                while (i < 6)
                {
                    j = 0;
                    while (j < 4)
                    {
                        if (facturacion[i, j] > max)
                        {
                            max = facturacion[i, j];
                            pisoMax = i;
                            habMax = j;
                        }
                        j = j + 1;
                    }
                    i = i + 1;
                }
                Console.WriteLine("\nHABITACIÓN MÁS RENTABLE:");
                Console.WriteLine("Piso " + (pisoMax + 1) + " - Habitación " + letras[habMax] + " ($" + max.ToString("F2") + ")");

                
                int totalNoches = 0;
                i = 0;
                while (i < 6)
                {
                    j = 0;
                    while (j < 4)
                    {
                        totalNoches = totalNoches + ocupacion[i, j];
                        j = j + 1;
                    }
                    i = i + 1;
                }

                int totalPosibles = 6 * 4 * 365;
                double porcentaje = ((double)totalNoches / totalPosibles) * 100.0;

                Console.WriteLine("\nOCUPACIÓN TOTAL DEL HOTEL:");
                Console.WriteLine("Noches ocupadas: " + totalNoches);
                Console.WriteLine("Porcentaje de ocupación: " + porcentaje.ToString("F2") + "%");

                
                int sinOcupacion = 0;
                i = 0;
                while (i < 6)
                {
                    j = 0;
                    while (j < 4)
                    {
                        if (ocupacion[i, j] == 0)
                        {
                            sinOcupacion = sinOcupacion + 1;
                        }
                        j = j + 1;
                    }
                    i = i + 1;
                }
                Console.WriteLine("\nHABITACIONES SIN OCUPACIÓN: " + sinOcupacion);
            }
        }
    

                
            

          
    


