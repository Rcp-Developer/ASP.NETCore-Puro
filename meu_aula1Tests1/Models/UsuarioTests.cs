using Microsoft.VisualStudio.TestTools.UnitTesting;
using meu_aula1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace meu_aula1.Models.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        [TestMethod()]
        public void gravarTest()
        {
            Usuario usua = new Usuario();
            usua.Nome = "Rodrigo";
            usua.Senha = "123456";
            usua.Email = "rodrigo-q2@hotmail.com";

            bool ok = usua.gravar();

            Assert.IsTrue(ok);
        }
    }
}