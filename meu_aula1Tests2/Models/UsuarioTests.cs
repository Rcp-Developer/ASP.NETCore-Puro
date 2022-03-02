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
        public void buscarTest()
        {
            Usuario usua = new Usuario();
            usua.buscar(1);

            Assert.Fail();
        }
    }
}