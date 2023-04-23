/*
 * Created by SharpDevelop.
 * User: Rodrigo
 * Date: 23/4/2023
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Main
{
	/// <summary>
	/// Description of ObreroGrupo.
	/// </summary>
	public class ObreroGrupo
	{
		private static int grupos= 0;
		private int id =0;
		private int codigoDeObra;// Obra.codigoInterno
		private ArrayList obreros = new ArrayList(); // Asignar obreros
		public ObreroGrupo()
		{
			this.grupos += 1
			this.id = this.grupos;
		}



		// Metodo Agregar Obrero;
		public void AgregarObrero(Obrero obrero){
			obreros.Add(obrero);
			Console.WriteLine("Obrero agregado al grupo {0}",id);
		}

		// Obrero Existente en el grupo.
		public bool ObreroExistente(Obrero obrero){
			foreach (Obrero seleccionado in obreros) 
			{
				Obrero persona = (Obrero)seleccionado;
				if (persona.Dni == obrero.Dni){
					return true 
				}
			}
			return false
		}


		// Propiedades;

		public int Grupos {
			get{
				return this.grupos;
			}
			set{
				this.grupos = value;
			}
		}
		public int Id {
			get{
				return this.id;
			}
			set{
				this.id= value;
			}
		}
		public int CodigoDeObra {
			get{
				return this.codigoDeObra;
			}
			set{
				this.codigoDeObra= value;
			}
		}
		public ArrayList Obreros {
			get{
				return this.obreros;
			}
			set{
				this.obreros = value;
			}
		}
	}
}
