using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Form.Models
{
	public class Empleado
	{
		[Required]
		public long Cedula { get; set; }
		[Required]
		public string Nombre { get; set; }
		[Required]
		public string Apellido { get; set; }
		[Range(15, 100, ErrorMessage = "Debe de ser mayor de 15")]
		public string Edad { get; set; }
		public long Telefono { get; set; }
		[EmailAddress(ErrorMessage = "Correo no valido")]
		public string Email { get; set; }
		public bool Genero { get; set; }
		public string[] Estado_Civil { get; set; }
		public bool Casado { get; set; }
		public bool Soltero { get; set; }
		public bool Viudo { get; set; }
		public bool Union_Libre { get; set; }
		public string[] Hobbys { get; set; }
		public bool Ciclismo { get; set; }
		public bool Basketball { get; set; }
		public bool Escuchar_Musica { get; set; }
		public bool Nadar { get; set; }
	}
}
