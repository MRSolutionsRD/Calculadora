using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamo' al mambo"+"\n");
            string respuesta, operacion;
            int termino1, termino2;            
            double resultado;
            bool continua, primernumerovalido;

            do {
                continua = false;
                primernumerovalido = false;
                Console.WriteLine("Qué tipo de operación desea realizar?");
                operacion = Console.ReadLine();
                if (operacion == "+" || operacion == "-" || operacion == "*" || operacion == "/")
                {

                    Console.WriteLine("Valor del primer termino:");
                    if (Int32.TryParse(Console.ReadLine(), out termino1))
                    { 
                        primernumerovalido = true;
                    }
                    else
                    {
                        Console.WriteLine("Esto no es un numero");
                    }
                    if (primernumerovalido) 
                    { 
                    Console.WriteLine("Valor del segundo termino:");
                        if (Int32.TryParse(Console.ReadLine(), out termino2))
                        {
                            if (operacion == "/" && termino2 == 0)
                                Console.WriteLine("No puede dividir entre cero");
                            if (operacion == "+")
                            {
                                resultado = termino1 + termino2;
                                Console.WriteLine("Suma: " + termino1 + " " + operacion + " " + termino2 + " = " + resultado);
                            }
                            else if (operacion == "-")
                            {
                                resultado = termino1 - termino2;
                                Console.WriteLine("Resta: " + termino1 + " " + operacion + " " + termino2 + " = " + resultado);
                            }
                            else if (operacion == "*")
                            {
                                resultado = termino1 * termino2;
                                Console.WriteLine("Multiplicacion: " + termino1 + " " + operacion + " " + termino2 + " = " + resultado);
                            }
                            else if (operacion == "/")
                            {
                                resultado = Convert.ToDouble(termino1) / Convert.ToDouble(termino2);
                                Console.WriteLine("Division: " + termino1 + " " + operacion + " " + termino2 + " = " + resultado);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Esto no es un numero");
                        }
                    }


                    Console.WriteLine("Presione S para continuar realizando operaciones.");
                    respuesta = Console.ReadLine();

                    if (respuesta == "S"|| respuesta == "s")
                        continua = true;

                    Console.WriteLine("===============================");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Operacion no soportada");
                    continua = true;
                }
            }

            while (continua);
                     
    
        }
    }
}
