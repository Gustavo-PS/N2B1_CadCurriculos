using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using N2B1_CadCurriculos.Models;
using System.Diagnostics;
using N2B1_CadCurriculos.DAO;
using System.Data;
using System.Text.RegularExpressions;

namespace N2B1_CadCurriculos.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            try
            {
                CurriculoDAO dao = new CurriculoDAO();
                List<CurriculoViewModel> lista = dao.Listagem();
                return View(lista);
            }
            catch (Exception erro)
            {
                return View("Error", new Exception(erro.ToString()));
            }
        }

        public IActionResult Impressao(string cpf)
        {
            try
            {
                CurriculoDAO dao = new CurriculoDAO();
                CurriculoViewModel cv = dao.ConsultaImpressao(cpf);
                return View(cv);
            }
            catch (Exception erro)
            {
                return View("Error", new Exception(erro.ToString()));
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Alterar(CurriculoViewModel cv, string Operacao)
        {
            try
            {
                ValidaDados(cv, Operacao);
                if (ModelState.IsValid)
                {
                    CurriculoDAO dao = new CurriculoDAO();
                    // if (Operacao == "I")
                    dao.Alterar(cv);
                    // else
                    //  dao.Alterar(cv);
                    return RedirectToAction("Index");

                }
                else
                {
                    //ViewBag.Operacao = Operacao;
                    return View("Editar");
                }


            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        public IActionResult Salvar(CurriculoViewModel cv, string Operacao)
        {
            try
            {
                ValidaDados(cv, Operacao);
                if (ModelState.IsValid)
                {
                    CurriculoDAO dao = new CurriculoDAO();
                    dao.Inserir(cv);
                    return RedirectToAction("Index");
                 }
                else
                {
                    ViewBag.Operacao = Operacao;
                    return View("Cadastro");
                }


            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }



        //Validação de dados 
        private void ValidaDados(CurriculoViewModel cv, string operacao)
        {
            ModelState.Clear();
            CurriculoDAO dao = new CurriculoDAO();


            //Dados Pessoais
            if (string.IsNullOrEmpty(cv.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
            if (!ValidaCPF(cv.Cpf))
                ModelState.AddModelError("CPF", "CPF inválido");
            if (cv.Telefone.Length < 9)
                ModelState.AddModelError("Telefone", "Telefone inválido");
            if (!ValidaEmail(cv.Email))
                ModelState.AddModelError("E-mail", "E-mail inválido");
            if (string.IsNullOrEmpty(cv.Cargo))
                ModelState.AddModelError("Cargo", "Preencha o cargo.");
            //Endereço
            if (string.IsNullOrEmpty(cv.Estado))
                ModelState.AddModelError("CEP", "Preencha o CEP.");
            if (cv.Numero <= 0)
                ModelState.AddModelError("Numero", "Preencha o Número.");

            //Dados Academicos
            //Curso1
            if (!string.IsNullOrEmpty(cv.Curso1) || !string.IsNullOrEmpty(cv.Escolaridade1) || !string.IsNullOrEmpty(cv.Instituicao1) || !string.IsNullOrEmpty(cv.Situacao1) || cv.Conclusao1.ToString() != "01/01/0001 00:00:00" && cv.Conclusao1.ToString() != "1/1/0001 12:00:00 AM" || !string.IsNullOrEmpty(cv.Periodo1))
            {
                if (string.IsNullOrEmpty(cv.Curso1))
                    ModelState.AddModelError("Curso", "Preencha o curso.");
                if (string.IsNullOrEmpty(cv.Escolaridade1))
                    ModelState.AddModelError("Escolaridade", "Preencha a escolaridade.");
                if (string.IsNullOrEmpty(cv.Instituicao1))
                    ModelState.AddModelError("Instiuição", "Preencha a instituição");
                if (string.IsNullOrEmpty(cv.Situacao1))
                    ModelState.AddModelError("Situação", "Preencha a situação.");
                if (cv.Conclusao1.ToString() == "01/01/0001 00:00:00" && cv.Conclusao1.ToString() != "1/1/0001 12:00:00 AM")
                    ModelState.AddModelError("Conclusão", "Preencha a conclusão corretamente.");
                if (string.IsNullOrEmpty(cv.Periodo1))
                    ModelState.AddModelError("Periodo", "Preencha o período.");
            }
            //Curso2
            if (!string.IsNullOrEmpty(cv.Curso2) || !string.IsNullOrEmpty(cv.Escolaridade2) || !string.IsNullOrEmpty(cv.Instituicao2) || !string.IsNullOrEmpty(cv.Situacao2) || cv.Conclusao2.ToString() != "01/01/0001 00:00:00" && cv.Conclusao2.ToString() != "1/1/0001 12:00:00 AM" || !string.IsNullOrEmpty(cv.Periodo2))
            {
                if (string.IsNullOrEmpty(cv.Curso2))
                    ModelState.AddModelError("Curso", "Preencha o curso.");
                if (string.IsNullOrEmpty(cv.Escolaridade2))
                    ModelState.AddModelError("Escolaridade", "Preencha a escolaridade.");
                if (string.IsNullOrEmpty(cv.Instituicao2))
                    ModelState.AddModelError("Instiuição", "Preencha a instituição");
                if (string.IsNullOrEmpty(cv.Situacao2))
                    ModelState.AddModelError("Situação", "Preencha a situação.");
                if (cv.Conclusao2.ToString() == "01/01/0001 00:00:00" && cv.Conclusao2.ToString() != "1/1/0001 12:00:00 AM")
                    ModelState.AddModelError("Conclusão", "Preencha a conclusão corretamente.");
                if (string.IsNullOrEmpty(cv.Periodo2))
                    ModelState.AddModelError("Periodo", "Preencha o período.");
            }
            //Curso3
            if (!string.IsNullOrEmpty(cv.Curso3) || !string.IsNullOrEmpty(cv.Escolaridade3) || !string.IsNullOrEmpty(cv.Instituicao3) || !string.IsNullOrEmpty(cv.Situacao3) || cv.Conclusao3.ToString() != "01/01/0001 00:00:00" && cv.Conclusao3.ToString() != "1/1/0001 12:00:00 AM" || !string.IsNullOrEmpty(cv.Periodo3))
            {
                if (string.IsNullOrEmpty(cv.Curso3))
                    ModelState.AddModelError("Curso", "Preencha o curso.");
                if (string.IsNullOrEmpty(cv.Escolaridade3))
                    ModelState.AddModelError("Escolaridade", "Preencha a escolaridade.");
                if (string.IsNullOrEmpty(cv.Instituicao3))
                    ModelState.AddModelError("Instiuição", "Preencha a instituição");
                if (string.IsNullOrEmpty(cv.Situacao3))
                    ModelState.AddModelError("Situação", "Preencha a situação.");
                if (cv.Conclusao3.ToString() == "01/01/0001 00:00:00" && cv.Conclusao3.ToString() != "1/1/0001 12:00:00 AM")
                    ModelState.AddModelError("Conclusão", "Preencha a conclusão corretamente.");
                if (string.IsNullOrEmpty(cv.Periodo3))
                    ModelState.AddModelError("Periodo", "Preencha o período.");
            }
            //Curso4
            if (!string.IsNullOrEmpty(cv.Curso4) || !string.IsNullOrEmpty(cv.Escolaridade4) || !string.IsNullOrEmpty(cv.Instituicao4) || !string.IsNullOrEmpty(cv.Situacao4) || cv.Conclusao4.ToString() != "01/01/0001 00:00:00" && cv.Conclusao4.ToString() != "1/1/0001 12:00:00 AM" || !string.IsNullOrEmpty(cv.Periodo4))
            {
                if (string.IsNullOrEmpty(cv.Curso4))
                    ModelState.AddModelError("Curso", "Preencha o curso.");
                if (string.IsNullOrEmpty(cv.Escolaridade4))
                    ModelState.AddModelError("Escolaridade", "Preencha a escolaridade.");
                if (string.IsNullOrEmpty(cv.Instituicao4))
                    ModelState.AddModelError("Instiuição", "Preencha a instituição");
                if (string.IsNullOrEmpty(cv.Situacao4))
                    ModelState.AddModelError("Situação", "Preencha a situação.");
                if (cv.Conclusao4.ToString() == "01/01/0001 00:00:00" && cv.Conclusao4.ToString() != "1/1/0001 12:00:00 AM")
                    ModelState.AddModelError("Conclusão", "Preencha a conclusão corretamente.");
                if (string.IsNullOrEmpty(cv.Periodo4))
                    ModelState.AddModelError("Periodo", "Preencha o período.");
            }
            //Curso5
            if (!string.IsNullOrEmpty(cv.Curso5) || !string.IsNullOrEmpty(cv.Escolaridade5) || !string.IsNullOrEmpty(cv.Instituicao5) || !string.IsNullOrEmpty(cv.Situacao5) || cv.Conclusao5.ToString() != "01/01/0001 00:00:00" && cv.Conclusao5.ToString() != "1/1/0001 12:00:00 AM" || !string.IsNullOrEmpty(cv.Periodo5))
            {
                if (string.IsNullOrEmpty(cv.Curso5))
                    ModelState.AddModelError("Curso", "Preencha o curso.");
                if (string.IsNullOrEmpty(cv.Escolaridade5))
                    ModelState.AddModelError("Escolaridade", "Preencha a escolaridade.");
                if (string.IsNullOrEmpty(cv.Instituicao5))
                    ModelState.AddModelError("Instiuição", "Preencha a instituição");
                if (string.IsNullOrEmpty(cv.Situacao5))
                    ModelState.AddModelError("Situação", "Preencha a situação.");
                if (cv.Conclusao5.ToString() == "01/01/0001 00:00:00" && cv.Conclusao5.ToString() != "1/1/0001 12:00:00 AM")
                    ModelState.AddModelError("Conclusão", "Preencha a conclusão corretamente.");
                if (string.IsNullOrEmpty(cv.Periodo5))
                    ModelState.AddModelError("Periodo", "Preencha o período.");
            }


            //Empresa
            //Exp1
            if (!string.IsNullOrEmpty(cv.Empresa1) || cv.Inicio1.ToString() != "01/01/0001 00:00:00" && cv.Inicio1.ToString() != "1/1/0001 12:00:00 AM" || cv.Termino1.ToString() != "01/01/0001 00:00:00" && cv.Termino1.ToString() != "1/1/0001 12:00:00 AM" ||
                !string.IsNullOrEmpty(cv.Ocupacao1) || !string.IsNullOrEmpty(cv.Atividades1))
            {
                if (string.IsNullOrEmpty(cv.Empresa1))
                    ModelState.AddModelError("Empresa", "Preencha a empresa.");
                if (cv.Inicio1.ToString() == "01/01/0001 00:00:00" && cv.Inicio1.ToString() != "1/1/0001 12:00:00 AM" || cv.Inicio1 >= DateTime.Today)
                    ModelState.AddModelError("Início", "Preencha o início corretamente.");
                if (cv.Termino1.ToString() == "01/01/0001 00:00:00" && cv.Termino1.ToString() != "1/1/0001 12:00:00 AM" || cv.Termino1 > DateTime.Today)
                    ModelState.AddModelError("Término", "Preencha o término corretamente.");
                if (string.IsNullOrEmpty(cv.Ocupacao1))
                    ModelState.AddModelError("Ocupação", "Preencha a ocupação.");
                if (string.IsNullOrEmpty(cv.Atividades1))
                    ModelState.AddModelError("Atividade", "Preencha a atividade.");
            }
            //Exp2
            if (!string.IsNullOrEmpty(cv.Empresa2) || cv.Inicio2.ToString() != "01/01/0001 00:00:00" && cv.Inicio2.ToString() != "1/1/0001 12:00:00 AM" || cv.Termino2.ToString() != "01/01/0001 00:00:00" && cv.Termino2.ToString() != "1/1/0001 12:00:00 AM" ||
                !string.IsNullOrEmpty(cv.Ocupacao2) || !string.IsNullOrEmpty(cv.Atividades2))
            {
                if (string.IsNullOrEmpty(cv.Empresa2))
                    ModelState.AddModelError("Empresa", "Preencha a empresa.");
                if (cv.Inicio2.ToString() == "01/01/0001 00:00:00" && cv.Inicio2.ToString() != "1/1/0001 12:00:00 AM" || cv.Inicio2 >= DateTime.Today)
                    ModelState.AddModelError("Início", "Preencha o início corretamente.");
                if (cv.Termino2.ToString() == "01/01/0001 00:00:00" && cv.Termino2.ToString() != "1/1/0001 12:00:00 AM" || cv.Termino2 > DateTime.Today)
                    ModelState.AddModelError("Término", "Preencha o término corretamente.");
                if (string.IsNullOrEmpty(cv.Ocupacao2))
                    ModelState.AddModelError("Ocupação", "Preencha a ocupação.");
                if (string.IsNullOrEmpty(cv.Atividades2))
                    ModelState.AddModelError("Atividade", "Preencha a atividade.");
            }
            //Exp3
            if (!string.IsNullOrEmpty(cv.Empresa3) || cv.Inicio3.ToString() != "01/01/0001 00:00:00" && cv.Inicio3.ToString() != "1/1/0001 12:00:00 AM" || cv.Termino3.ToString() != "01/01/0001 00:00:00" && cv.Termino3.ToString() != "1/1/0001 12:00:00 AM" ||
                !string.IsNullOrEmpty(cv.Ocupacao3) || !string.IsNullOrEmpty(cv.Atividades3))
            {
                if (string.IsNullOrEmpty(cv.Empresa3))
                    ModelState.AddModelError("Empresa", "Preencha a empresa.");
                if (cv.Inicio3.ToString() == "01/01/0001 00:00:00" && cv.Inicio3.ToString() != "1/1/0001 12:00:00 AM" || cv.Inicio3 >= DateTime.Today)
                    ModelState.AddModelError("Início", "Preencha o início corretamente.");
                if (cv.Conclusao2.ToString() == "01/01/0001 00:00:00" && cv.Termino3.ToString() != "1/1/0001 12:00:00 AM" || cv.Termino3 > DateTime.Today)
                    ModelState.AddModelError("Término", "Preencha o término corretamente.");
                if (string.IsNullOrEmpty(cv.Ocupacao3))
                    ModelState.AddModelError("Ocupação", "Preencha a ocupação.");
                if (string.IsNullOrEmpty(cv.Atividades3))
                    ModelState.AddModelError("Atividade", "Preencha a atividade.");
            }


            //Idioma1
            if (!string.IsNullOrEmpty(cv.Idioma1) || !string.IsNullOrEmpty(cv.Nivelidioma1))
            {
                if (string.IsNullOrEmpty(cv.Idioma1))
                    ModelState.AddModelError("Idioma", "Preencha o idioma.");
                if (string.IsNullOrEmpty(cv.Nivelidioma1))
                    ModelState.AddModelError("Nível do idioma", "Preencha o nível do idioma.");
            }
            //Idioma2
            if (!string.IsNullOrEmpty(cv.Idioma2) || !string.IsNullOrEmpty(cv.Nivelidioma2))
            {
                if (string.IsNullOrEmpty(cv.Idioma2))
                    ModelState.AddModelError("Idioma", "Preencha o idioma.");
                if (string.IsNullOrEmpty(cv.Nivelidioma2))
                    ModelState.AddModelError("Nível do idioma", "Preencha o nível do idioma.");
            }
            //Idioma3
            if (!string.IsNullOrEmpty(cv.Idioma3) || !string.IsNullOrEmpty(cv.Nivelidioma3))
            {
                if (string.IsNullOrEmpty(cv.Idioma3))
                    ModelState.AddModelError("Idioma", "Preencha o idioma.");
                if (string.IsNullOrEmpty(cv.Nivelidioma3))
                    ModelState.AddModelError("Nível do idioma", "Preencha o nível do idioma.");
            }
        }

        //Validador de CPF 
        public static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        //Validador de E-mail
        public static bool ValidaEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
                return true;
            else
                return false;
        }

        public IActionResult Edit(string cpf)
        {
            try
            {
                CurriculoDAO dao = new CurriculoDAO();
                CurriculoViewModel cadastro = dao.Consulta(cpf);
                if (cadastro == null)
                    return RedirectToAction("Listagem");
                else
                    return View("Editar", cadastro);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Delete(string cpf)
        {
            try
            {
                CurriculoDAO dao = new CurriculoDAO();
                dao.Excluir(cpf);
                return RedirectToAction("Listagem");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
    }
}
