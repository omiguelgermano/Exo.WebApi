// faz o controle das API, por meio do Repositories, neste caso concreto.
using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Conrollers {
	[Route("api/[controller]")]
	[ApiController]
	public class ProjetosController : ControllerBase {
		private readonly ProjetoRepository _projetoRepository;
		public ProjetosController(ProjetoRepository projetoRepository) {
			_projetoRepository = projetoRepository;
		}
		[HttpGet]
		public IActionResult Listar() {
			return Ok(_projetoRepository.Listar());
		}
	}
}
