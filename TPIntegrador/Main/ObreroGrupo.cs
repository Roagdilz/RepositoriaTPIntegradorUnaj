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
		private int id;
		private int codigoDeObra;// Obra.codigoInterno
		private ArrayList obreros = new ArrayList(); // Asignar obreros
		public ObreroGrupo()
		{
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
