using EmprestimoLivros.Data;
using EmprestimoLivros.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class EmprestimoController(ApplicationDbContext db) : Controller
    {
        readonly private ApplicationDbContext _db = db;

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;

            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound("O ID não foi fornecido ou é inválido.");
                }

                EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

                if (emprestimo == null)
                {
                    return NotFound("Nenhum empréstimo encontrado com o ID fornecido.");
                }

                return View(emprestimo);
            }
            catch (Exception ex)
            {
                // Registre ou manipule a exceção conforme necessário
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }
    

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound("O ID não foi fornecido ou é inválido.");
                }

                EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

                if (emprestimo == null)
                {
                    return NotFound("Nenhum empréstimo encontrado com o ID fornecido.");
                }

                return View(emprestimo);
            }
            catch (Exception ex)
            {
                // Registre ou manipule a exceção conforme necessário
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                //Entra no BD -> Tabela Emprestimos -> Insere os dados
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges(); //Salva os dados
                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index"); //Retorno para a tela Index de Empréstimos
            }
            return View(emprestimos);
        }

        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Update(emprestimo);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "Erro ao editar o empréstimo!";
            return View(emprestimo);
              
        }

        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {
            if (emprestimo == null)
            {
                return NotFound();
            }

            _db.Emprestimos.Remove(emprestimo);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão realizada com sucesso!";
            return RedirectToAction("Index");
        }
    }
}