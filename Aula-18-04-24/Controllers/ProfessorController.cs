using Aula_18_04_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_18_04_24.Controllers
{
    public class ProfessorController : Controller
    {

        public void IniciarLista() 
        {
            if (Session["Professores"] == null)
                Session["Professores"] = new List<Professor>();
            
        }
        // GET: Professor
        public ActionResult Index()
        {
            IniciarLista();
            return View(Session["Professores"]);
        }

        // GET: Professor/Details/5
        public ActionResult Details(int id)
        {
            return View((Session["Professores"] as List<Professor>).ElementAt(id));
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            var listaArea = new List<SelectListItem>();
            listaArea.Add(new SelectListItem() { Text = "Informárica", Value = "TI" });
            listaArea.Add(new SelectListItem() { Text = "Matemática", Value = "MAT" });
            listaArea.Add(new SelectListItem() { Text = "Idiomas", Value = "ID" });
            listaArea.Add(new SelectListItem() { Text = "Ciências", Value = "CI" });
            listaArea.Add(new SelectListItem() { Text = "Selecione uma opção", Value = "", Selected = true });

            //colocar elementos na view, sem que ela seja o conteúdo, são elementos adicionais!
            ViewBag.listaArea = listaArea;
            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        public ActionResult Create(Professor professor)
        {
            try
            {
                // TODO: Add insert logic here
                IniciarLista();
                (Session["Professores"] as List<Professor>).Add(professor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(int id)
        {
            var listaArea = new List<SelectListItem>();
            listaArea.Add(new SelectListItem() { Text = "Artes", Value = "ART" });
            listaArea.Add(new SelectListItem() { Text = "Ciências", Value = "CI" });
            listaArea.Add(new SelectListItem() { Text = "Idiomas", Value = "ID" });
            listaArea.Add(new SelectListItem() { Text = "Informática", Value = "TI" });
            listaArea.Add(new SelectListItem() { Text = "Matemática", Value = "MAT" });
            listaArea.Add(new SelectListItem() { Text = "Selecione uma opção", Value = "", Selected = true });

            ViewBag.listaArea = listaArea;
            return View((Session["Professores"] as List<Professor>).ElementAt(id));
        }

        // POST: Professor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Professor professor)
        {
            try
            {
                // TODO: Add update logic here

                IniciarLista();
                var lista = Session["Professores"] as List<Professor>;
                lista[id] = professor;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Professor/Delete/5
        public ActionResult Delete(int id)
        {

            IniciarLista();
            return View((Session["Professores"] as List<Professor>).ElementAt(id));
        }

        // POST: Professor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                IniciarLista();
                var lista = Session["Professores"] as List<Professor>;
                lista.RemoveAt(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
