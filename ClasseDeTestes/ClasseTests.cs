using ClasseDeExemplo;
using NUnit.Framework;
using System;

namespace ClasseDeTestes
{
    [TestFixture]
    public class ClasseTests
    {
        [Test]
        public void somarNumerosInteiros()
        {
            var sut = new ClasseExemplo();

            var resultado = sut.somarInteiros(5, 5, 5, 5);

            Assert.That(resultado, Is.EqualTo(20));
        }

        [Test]
        public void juntarEVerificarSeStringExiste()
        {
            var sut = new ClasseExemplo();

            var resultado = sut.concatenarStrings("José", "Ferreira");

            StringAssert.Contains("Ferreira", resultado);
            Assert.That(resultado, Is.EqualTo("José Ferreira"));
        }

        [Test]
        public void verificarSeEstaLigado()
        {
            var sut = new ClasseExemplo();

            var resultado = sut.ligado(1);

            Assert.True(resultado);

        }
    }
}
