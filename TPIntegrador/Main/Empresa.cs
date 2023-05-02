/*
 * Created by SharpDevelop.
 * User: Rodrigo
 * Date: 23/4/2023
 * Time: 12:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Main
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		private string name;
		private ArrayList grupos= new ArrayList();
		private ArrayList obras= new ArrayList();
		private ArrayList obreros= new ArrayList();		
		public Empresa(){

		 	
		}
		public Empresa(string nombre){
			this.nombre = nombre;
		}


		// Obrero Existente en el grupo.
		public bool ObreroExistente(Obrero obrero){
			return obreros.Contains(obrero);
		}

		//Propiedades

		public ArrayList Grupos {
			get	{
				return this.grupos;
			}
			set{
				this.grupos = value;
			}
		}
		public ArrayList Obras {
			get	{
				return this.obras;
			}
			set{
				this.obras = value;
			}
		}
		public ArrayList Obreros {
			get	{
				return this.obreros;
			}
			set{
				this.obreros = value;
			}
		}
	}
}
