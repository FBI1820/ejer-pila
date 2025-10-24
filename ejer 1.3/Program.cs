using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// Caso de Estudio 2: Colas – Gestión de Solicitudes en un Servidor Web 
//Un servidor web universitario recibe múltiples solicitudes de acceso a sus servicios en 
//línea: consultas de notas, inscripción de materias y descarga de materiales. Para evitar 
//la saturación del sistema, las peticiones se almacenan en una cola, garantizando que se 
//atiendan en el orden en que llegan (FIFO – First In, First Out). 
//El caso consiste en desarrollar en C# una simulación del procesamiento de estas 
//solicitudes, donde los estudiantes deben encolar nuevas peticiones (como “Consulta 
//de notas” o “Inscripción a asignaturas”) y desencolar las solicitudes atendidas. Además,
//podrán visualizar el estado currente de la cola y comprobar si existen solicitudes 
//pendientes. Este estudio permite relacionar el uso de colas con el manejo de procesos 
//concurrentes, colas de impresión, sistemas de mensajería o redes informáticas,
//mostrando su relevancia directa en la Ingeniería en Sistemas. 
///
namespace PlaataformaDeRegistro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> solicitudCola = new Queue<string>();
            // Inicializar la variable OpcionUsuario antes de usarla en el ciclo do-while
            int OpcionUsuario = 0;
            //do while que se asegura que el ciclo se repita al menos uno vez 
            do
            {
                Console.WriteLine("Bienvenido al menu de usuario para estudiantes, por favor ingresa una opcion: ");
                Console.WriteLine("1. Consultar notas");
                Console.WriteLine("2. Inscribir materias");
                Console.WriteLine("3. Descargar materiales estudiantes");
                Console.WriteLine("4. mostrar lista de solicitudes");
                Console.WriteLine("5. atender la primera solicitud");
                Console.WriteLine("6. Salir");
                Console.Write("escriba el numero:");
                OpcionUsuario = Convert.ToInt32(Console.ReadLine());

                //Realizamos la condicion con switch case para cada una de las opciones
                switch (OpcionUsuario)
                {
                    case 1:
                        solicitudCola.Enqueue("Consulta de notas de estudiante");
                        Console.WriteLine("Su solicitud de consulta de notas esta en lista de espera.");
                        break;
                    case 2:
                        solicitudCola.Enqueue("Inscripción a asignaturas");
                        Console.WriteLine("Su solicitud de inscripción a asignaturas esta en lista de espera.");
                        break;
                    case 3:
                        solicitudCola.Enqueue("Descarga de materiales estudiantes");
                        Console.WriteLine("Su solicitud de descarga de materiales esta en lista de espera.");
                        break;
                    case 4:
                        if (solicitudCola.Count > 0)
                        {
                            Console.WriteLine("Solicitudes pendientes en la cola:");
                            foreach (string solicitud in solicitudCola)
                            {
                                Console.WriteLine($"- {solicitud}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay solicitudes pendientes en la cola.");
                        }
                        break;
                    case 5:
                        solicitudCola.Dequeue();
                        Console.WriteLine("solicitud eliminada.");
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del sistema. Gracias por usar el servicio estudiantil.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }

            } while (OpcionUsuario != 6);
        }
    }
}

