/*
 * Created by SharpDevelop.
 * User: Rodrigo
 * Date: 15/4/2023
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Main
{
	class Program
	{
		public static void Main(string[] args)
		{
			Empresa nuevaEmpresa = new Empresa()
			Console.WriteLine("Hello world!");
			

			// a) Contratar un obrero nuevo (se agrega a la empresa y a un grupo)
			// Le pedimos algunos datos.
			string nombre,apellido;
			int legajo,numeroGrupo;
			long dni;
			/*
			 ········································································
			 ·Primero verificamos que el obrero que desea contratar,				·
			 ·no este en la lista actual de la empresa.								·
			 ·si no existe, se creara el obrero con todos los datos ingresados,		·
			 ·de lo contrario, se le imprimira los datos del obrero y lo regresara  ·
			 ·al menu .																·
			 ········································································
			 */				
			if (nuevaEmpresa.ObreroExistente(dni)){

				Obrero persona = new Obrero()	
			}else{
				Obrero persona = nuevaEmpresa.DevolverObrero(dni);
				Console.WriteLine("El usuario ingresado ya se encuentra en la Empresa.");
				Console.WriteLine("Datos de la persona:");
				Console.WriteLine("Nombre: {0}.",persona.Nombre);
				Console.WriteLine("Apellido {1}.",persona.Apellido);
				Console.WriteLine("Grupo de Obra: {2}.",persona.ObreroGrupo);
				Console.WriteLine("Regresaremos al menu principal. Precione cualquier tecla.")
				Console.ReadKey();
			}
			
				
			// b) Eliminar un obrero (se elimina de la empresa y de su grupo)
			// c) Listado de obreros
			// d) Listado de obras
			/* e) Agregar una obra y asignarle un grupo de obreros. Se debe verificar que haya grupo libre; en
			   caso contrario se debe levantar una excepción que informe lo sucedido.*/
			/* f) Modificar el estado de avance de una obra. Si el estado de avance llega al 100% la obra debe
			   darse por finalizada, se elimina del listado de obras en ejecución y se guarda en obras
			   finalizadas*/
			// g) Listado de obras finalizadas
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}