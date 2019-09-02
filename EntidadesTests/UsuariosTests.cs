using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace Entidades.Tests
{
    [TestClass()]
    public class UsuariosTests
    {
        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>(new Contexto());
            Assert.IsNotNull(repositorio.GetList(a => true));
        }
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios> reposiorio;
            reposiorio = new RepositorioBase<Usuarios>(new Contexto());

            Assert.IsTrue(reposiorio.Guardar(new Usuarios()));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>(new Contexto());

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>(new Contexto());
            Usuarios u = new Usuarios(1,"Walder","walde@walder",1,"Walder001","12345678",DateTime.Now);
            Assert.IsTrue(repositorio.Modificar(u));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>(new Contexto());
            Assert.IsNotNull(repositorio.Eliminar(1));
        }
    }
}