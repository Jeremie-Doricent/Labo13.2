using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using Models; // Permet d'accéder à la classe Montre

namespace ModelsTests
{
    [TestClass] // Indique que c'est une classe de test (MSTest)
    public class MontreTests
    {
        [TestMethod] // Indique que c'est une méthode de test
        public void TesterFonctionnaliteMontre()
        {
           
           
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Montre maMontre = new Montre(25,20,40);
            }
            );

        }
        [TestMethod] 
        public void TesterFonctionnaliteMontre1()
        {


            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Montre maMontre = new Montre(19, 110, 40);
            }
            );

        }
        [TestMethod] 
        public void TesterFonctionnaliteMontre2()
        {


            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Montre maMontre = new Montre(22, 20,900);
            }
            );

        }
        [TestMethod]
        public void TesterFonctionnaliteMontre3()
        {


           
            
              
           

        }

    }
}
