using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TareaFinal.Models;

namespace TareaFinal.Controllers
{
	public class MainController : Controller
	{
		private readonly ILogger<MainController> _logger;

		public MainController(ILogger<MainController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Profesores()
		{
			var model = new List<Profesores>
			{
				new Profesores{ Id = 1, Nombre = "Rodrigo", Apellido = "De Triana", MateriaImparte = "Sociales" },
				new Profesores{ Id = 2, Nombre = "Maria", Apellido = "Casimiro", MateriaImparte = "Español" },
				new Profesores{ Id = 3, Nombre = "Eriberta", Apellido = "Bio", MateriaImparte = "Naturales" },
				new Profesores{ Id = 4, Nombre = "Josefo", Apellido = "Claudio", MateriaImparte = "Matemáticas" }
			};

			return View(model);
		}

		public IActionResult Estudiantes()
		{
			var model = new List<Estudiantes>
			{
				new Estudiantes{ Id = 1, Nombre = "David", Apellidos = "Encarnación", MateriaPreferida = "Matemáticas" },
				new Estudiantes{ Id = 2, Nombre = "Omar", Apellidos = "Bello", MateriaPreferida = "Sociales" },
				new Estudiantes{ Id = 3, Nombre = "Arturo", Apellidos = "Bazil", MateriaPreferida = "Español" },
				new Estudiantes{ Id = 4, Nombre = "Yorki", Apellidos = "Encarnación", MateriaPreferida = "Naturales" }
			};

			return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}