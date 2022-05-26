using System;
using System.Threading;

namespace Proyecto{
    public enum Cargos{
        Auxiliar ,
        Administrativo ,
        Ingeniero ,
        Especialista,
        Investigador
    }
    class Program
{
    public static void  Main(string [] args){

        Calculadora nuevaC = new Calculadora(5000);
        int opc = 0;
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Limpiar");
            Console.WriteLine("6 - Salir");
            opc = Int32.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1 :
                nuevaC.Sumar(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine(nuevaC.Resultado);

                break;
                case 2 :
                nuevaC.Restar(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine(nuevaC.Resultado);

                break;
                case 3 :
                nuevaC.Dividir(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine(nuevaC.Resultado);

                break;
                case 4 :
                nuevaC.Multiplicar(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine(nuevaC.Resultado);

                break;
                case 5 :
                nuevaC.Limpiar(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine(nuevaC.Resultado);

                break;
                case 6 :
                continuar = false;

                break;
                
                
            }
        }

        // Punto 2

       Empleado [] empleados = new Empleado[3];

       for (int i = 0; i < 3; i++)
       {
           Empleado p  = new Empleado();
           p = p.CrearEmpleado();
           
            empleados[i] = p;  
       }
       double Salarios = 0;
       double jubi;
       int  indice = 0;
       
      for (int i = 0; i < 3; i++)
       {
           Console.WriteLine("Nombre : {0}",empleados[i].Nombre1);
           Console.WriteLine("Apellido : {0}",empleados[i].Apellido1);
           Console.WriteLine("Nacimiento : {0}",empleados[i].FechaNac);
           Console.WriteLine("Estado Civil : {0}",empleados[i].EstadoCivil);
           Console.WriteLine("Genero : {0}",empleados[i].Genero1);
           Console.WriteLine("Fecha de ingreso : {0}",empleados[i].FechaIng);
           Console.WriteLine("Sueldo Base : {0}",empleados[i].SueldoB1);
           Console.WriteLine("Cargo : {0}",empleados[i].Cargo);
           Console.WriteLine("Sueldo Base + Adicional: {0}",empleados[i].CalcSueldo());
           Salarios += empleados[i].SueldoB1;
           Console.WriteLine("Antiguedad : {0}",empleados[i].Antiguedad());
          if (i == 0)
          {
               jubi = empleados[0].Antiguedad();
          }else
          {
              indice = i;
              jubi = empleados[i].Antiguedad();
          }
       }
           Console.WriteLine("Sueldos a pagar {0}", Salarios);
           Console.WriteLine("Nombre : {0}",empleados[indice].Nombre1);
           Console.WriteLine("Apellido : {0}",empleados[indice].Apellido1);
           Console.WriteLine("Nacimiento : {0}",empleados[indice].FechaNac);
           Console.WriteLine("Estado Civil : {0}",empleados[indice].EstadoCivil);
           Console.WriteLine("Genero : {0}",empleados[indice].Genero1);
           Console.WriteLine("Fecha de ingreso : {0}",empleados[indice].FechaIng);
           Console.WriteLine("Sueldo Base : {0}",empleados[indice].SueldoB1);
           Console.WriteLine("Cargo : {0}",empleados[indice].Cargo);
           Console.WriteLine("Sueldo Base + Adicional: {0}",empleados[indice].CalcSueldo());
           Console.WriteLine("Antiguedad : {0}",empleados[indice].Antiguedad());


        




    }
    
   
}
public  class Calculadora{
        private double resultado;

        public double Resultado { get => resultado; set => resultado = value; }

        public  Calculadora(double resultado){
            this.resultado  = resultado;
        }
   

        public  void Sumar(double termino){
            this.resultado = resultado + termino;
           
        }
        public void Restar(double termino ){
            this.resultado  = resultado - termino;
        }
        public void Multiplicar(double termino){
            this.resultado  = resultado*termino;
        }
        public void Dividir(double termino){
            if (termino == 0)
            {
                Console.WriteLine("No se puede dividir en cero");
            }
            this.resultado = resultado/termino;
        }
        public void Limpiar(double x){
            this.resultado  = x;

        }
        
       

    }

}
