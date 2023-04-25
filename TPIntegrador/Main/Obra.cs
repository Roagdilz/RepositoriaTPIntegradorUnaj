/*
 * Created by SharpDevelop.
 * User: Rodrigo
 * Date: 23/4/2023
 * Time: 12:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Main
{
	/// <summary>
	/// Description of Obra.
	/// </summary>
	public class Obra
	//Comentario
	{
		// Variables de clase / estaticas / que siempre existiran;
		private static int obras=0;
		private static ArrayList obrasEjecucion = new ArrayList();
		private static ArrayList obrasFinalizadas= new ArrayList();
		
		// Variables de Objeto;
		
		private string nombre;
		private string tipoObra;
		private long dniPropietario; // Obrero.dni;
		private ObreroGrupo grupo; // ObreroGrupo (objeto);
		private int codigoInterno;
		private int estadoDeAvance; // ej: 50% ;
		private int costo;
		
		public Obra()
		{
			this.obras += 1;
			this.codigoInterno = this.obras;
		}


		// Propiedades;


		public string Nombre {
			get{
				return this.nombre;
			}
			set{
				this.nombre = value;
			}
		}
		public string TipoObra {
			get{
				return this.tipoObra;
			}
			set{
				this.tipoObra = value;
			}
		}
		public long DniPropietario {
			get{
				return this.dniPropietario
			}
			set{
				this.dniPropietario = value;
			}
		}
		public ObreroGrupo Grupo {
			get{
				return this.grupo;
			}
			set{
				this.grupo = value;
			}
		}
		public int CodigoInterno {
			get{
				return this.codigoInterno;
			}
			set{
				this.codigoInterno = value;
			}
		}
		public int EstadoDeAvance {
			get{
				return this.estadoDeAvance;
			}
			set{
				this.estadoDeAvance = value;
			}
		}
		public int Costo {
			get{
				return this.costo;
			}
			set{
				this.costo = value;
			}
		}
		public int Obras{
			get	{
				return this.obras;
			}
			set{
				this.obras= value;
			}
		}

	}
}
