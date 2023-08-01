using System;

class Program
{
    static void Main()
    {
        const int NEmpleados = 2;
        string[] nombres = new string[NEmpleados];
        string[] Doc1 = new string[NEmpleados];
        string[] Doc2 = new string[NEmpleados];
        double[] SalarioH = new double[NEmpleados];
        double[] Horas = new double[NEmpleados];

        for (int i = 0; i < NEmpleados; i++)
        {
            Console.WriteLine($"Ingrese nombre de empleado {i + 1}:");
            nombres[i] = Console.ReadLine();

            Console.WriteLine($"Ingrese numero de DUI de {i + 1}");
            Doc1[i] = Console.ReadLine();

            Console.WriteLine($"Ingrese numero de NIT de {i + 1}");
            Doc2[i] = Console.ReadLine();

            Console.WriteLine($"Ingrese salario por hora de {i + 1}");
            SalarioH[i] = double.Parse(Console.ReadLine());

            Console.WriteLine($"Ingrese horas trabajads por:  {i + 1}");
            Horas[i] = double.Parse(Console.ReadLine());

            Console.WriteLine();
        }
        Console.WriteLine("Nombre\t\tHoras Trabajadas\t\tSalario/Hora\t\tSalario\t\tRenta\t\tNeto");
        double TPlanilla = 0;

        for (int i = 0; i < NEmpleados; i++)
        {
            double TPago = SalarioH[i] * Horas[i];
            TPlanilla = TPago;

            double Renta = TPago * 0.10;
            double Pneto = TPago - Renta;

            Console.WriteLine($"{nombres[i]}\t{Horas[i]}\t\t{SalarioH[i]}\t\t{TPago}\t\t{Renta}\t\t{Pneto}");
        }
        Console.WriteLine("\t");
        Console.WriteLine($"Total Planilla para {NEmpleados} empleados es de: $ " + double.Round(TPlanilla, 2));
    }
}
    
