using System;
namespace Proyecto{
    
    class Empleado{
        private string Nombre;
        private string Apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private char Genero;

        private DateTime fechaIng;
        private double SueldoB;

        private Cargos cargo;

        public Empleado()
        {
        }

        public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, char genero, DateTime fechaIng, double sueldoB, Cargos cargo)
        {
            Nombre1 = nombre;
            Apellido1 = apellido;
            this.FechaNac = fechaNac;
            this.EstadoCivil = estadoCivil;
            Genero1 = genero;
            this.FechaIng = fechaIng;
            SueldoB1 = sueldoB;
            this.Cargo = cargo;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero1 { get => Genero; set => Genero = value; }
        public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
        public double SueldoB1 { get => SueldoB; set => SueldoB = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }



        public double Edad(){
           double edad;
           DateTime p  = DateTime.Now;
           double year  = p.Year;
           edad =   year - this.fechaNac.Year; 
           
           return edad;
        }
        public double Antiguedad(){
            return  DateTime.Now.Year -  this.fechaIng.Year;
        }
        public double CantJubiA(){
            double añosF;
            if (this.Genero == 'M')
            {
                añosF = 60 - this.Edad();
            }else
            {
                añosF = 65 - this.Edad();
            }
            return añosF;
        }
        public double CalcSueldo(){

            if (this.Antiguedad()<20)
            {
                this.SueldoB = SueldoB +(SueldoB * 0.01)* this.Antiguedad();
            }else
            {
                this.SueldoB = (SueldoB * 1.25);
            }
            if (this.cargo == Cargos.Ingeniero || this.cargo  ==  Cargos.Especialista)
            {
                this.SueldoB = SueldoB * 1.5;
            }
            if (this.estadoCivil.Equals('C'))
            {
                this.SueldoB += 15000;
            }

            return SueldoB;





        }
        public Empleado CrearEmpleado(){
           Console.WriteLine("Ingrese su nombre:");
           string nombre = Console.ReadLine(); 
           Console.WriteLine("Ingrese su Apellido:");
           string ape = Console.ReadLine();
           Console.Write("Ingrese el mes de nacimiento: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese dia de nacimiento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año de nacimiento: ");
            int year = int.Parse(Console.ReadLine());

            DateTime FechaNac = new DateTime(year, mes, dia);
            Console.WriteLine("Ingrese estado civil: C :(Casado)/S : (Soltero)/ D: (Divorciado)");
            char c  = Console.ReadLine()[0];
            Console.WriteLine("Ingrese genero: M :(Masculino)/F : (Femenino)");
            char g  = Console.ReadLine()[0];
            Console.Write("Ingrese el mes de ingreso: ");
            int mesIng = int.Parse(Console.ReadLine());
            Console.Write("Ingrese dia de ingreso: ");
            int diaIng = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año de ingreso: ");
            int yearIng = int.Parse(Console.ReadLine());

            DateTime FechaIng = new DateTime(yearIng, mesIng, diaIng);
            Console.WriteLine("Ingrese su sueldo");
            double sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su cargo: 0 = (Auxliar ) / 1  = (Administrativo) // 2 = (Ingeniero) // 3 = (Especialista) // 4 = (Investigador) ");
            int opc1 = Convert.ToInt32(Console.ReadLine());
            Cargos l = AsigCargo(opc1);
            
            Empleado p  = new Empleado(nombre, ape, FechaNac , c , g ,FechaIng ,sueldo , l);
            return p;
    }
     public Cargos AsigCargo(int x){
         switch (x)
                    {
                        case 0:
                            return Cargos.Auxiliar;
                            break;
                        case 1:
                            return Cargos.Administrativo;
                            break;
                        case 2:
                            return Cargos.Ingeniero;
                            break;
                        case 3:
                            return Cargos.Especialista;
                            break;
                        case 4:
                            return Cargos.Investigador;
                            break;
                    
                    }
                    return Cargos.Auxiliar;
                
            

     }
    
    
    
    
    
    
    }
}