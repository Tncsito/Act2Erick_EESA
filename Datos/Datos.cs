using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2Erick_EESA.Datos
{
    public class Datos
    {
        public void uno()
        {
            int[] arreglo1 = new int[3];
            int[] arreglo2 = new int[3];
            int[] resultado = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese un valor para el arreglo 1 en la posición {0}: ", i);
                arreglo1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese un valor para el arreglo 2 en la posición {0}: ", i);
                arreglo2[i] = Convert.ToInt32(Console.ReadLine());

                resultado[i] = arreglo1[i] + arreglo2[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{arreglo1[i]} + {arreglo2[i]} = {resultado[i]}");
            }
        }
        public void dos()
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Ingrese el valor para la posición {i}: ");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Ingrese el elemento a buscar: ");
            int elementoBuscar = Convert.ToInt32(Console.ReadLine());

            int contador = 0;
            for (int i = 0; i < size; i++)
            {
                if (arreglo[i] == elementoBuscar)
                {
                    Console.WriteLine($"El elemento {elementoBuscar} se encuentra en la posición {i}");
                    contador++;
                }
            }

            if (contador == 0)
            {
                Console.WriteLine($"El elemento {elementoBuscar} no se encuentra en el arreglo.");
            }
        }
        public void tres()
        {
            int[] algebra = new int[5];
            int[] analisis = new int[5];
            int[] inscritosAmbas = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el ID del alumno en Álgebra: ");
                algebra[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Ingrese el ID del alumno en Análisis: ");
                analisis[i] = Convert.ToInt32(Console.ReadLine());

                if (Array.IndexOf(algebra, analisis[i]) != -1)
                {
                    inscritosAmbas[i] = analisis[i];
                }
            }

            Console.WriteLine("Alumnos inscritos en ambas asignaturas:");
            foreach (int alumno in inscritosAmbas)
            {
                if (alumno != 0)
                {
                    Console.WriteLine(alumno);
                }
            }
        }
        public void cuatro()
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arreglo = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Ingrese un valor para la posición {i}: ");
                int valor = Convert.ToInt32(Console.ReadLine());

                while (Array.IndexOf(arreglo, valor) != -1)
                {
                    Console.WriteLine("El valor ya existe en el arreglo. Ingrese otro valor.");
                    Console.Write($"Ingrese un valor para la posición {i}: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                }

                arreglo[i] = valor;
            }

            Console.WriteLine("Contenido del arreglo:");
            foreach (int elemento in arreglo)
            {
                Console.Write($"{elemento} ");
            }
        }
        public void cinco()
        {
            Console.Write("Ingrese la cantidad de notas: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] notas = new int[n];
            int aprobados = 0;
            int desaprobados = 0;
            int sumaAprobados = 0;
            int sumaDesaprobados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese la nota {i + 1}: ");
                int nota = Convert.ToInt32(Console.ReadLine());

                if (nota >= 11 && nota <= 20)
                {
                    aprobados++;
                    sumaAprobados += nota;
                }
                else if (nota >= 0 && nota <= 10)
                {
                    desaprobados++;
                    sumaDesaprobados += nota;
                }
                else
                {
                    Console.WriteLine("La nota ingresada no está en el rango válido (0-20).");
                    i--;
                }
            }


            double promedioAprobados = (aprobados > 0) ? sumaAprobados / (double)aprobados : 0;
            double promedioDesaprobados = (desaprobados > 0) ? sumaDesaprobados / (double)desaprobados : 0;

            Console.WriteLine($"Promedio de notas aprobadas: {promedioAprobados}");
            Console.WriteLine($"Promedio de notas desaprobadas: {promedioDesaprobados}");
            Console.WriteLine($"Cantidad de notas aprobadas: {aprobados}");
            Console.WriteLine($"Cantidad de notas desaprobadas: {desaprobados}");
        }
    }
}
