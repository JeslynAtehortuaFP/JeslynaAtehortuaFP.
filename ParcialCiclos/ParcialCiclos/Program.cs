using System.ComponentModel.Design;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aprobados = 0, reprobados = 0;
            int Alumnos = 25;
            

            for (int i = 1; i <= Alumnos; i++) 
            {
                Console.WriteLine(" ===estudiante" + i + "==");
                Console.Write("nota examen 1");
                double ex1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("nota} examen 2");
                double ex2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("nota trabajo investigacion");
                double trabajo = Convert.ToDouble(Console.ReadLine());

                double promedio = (ex1 + ex2 + trabajo) / 3.0;
                if (promedio>= 3.5)
                {
                    Console.WriteLine("promedio =" + promedio.ToString("F2") + aprobados++);
                }
                else
                {
                    Console.WriteLine("promedio= " + promedio.ToString("F2") + reprobados++);
                }

                





            }
         

       
        
        } 


        }
    }

