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
            Montre montre = new Montre();
         

           


            Assert.AreEqual(0,montre.heure);
            Assert.AreEqual(0, montre.minute);
            Assert.AreEqual(0,montre.seconde);

           
            
              
           

        }
        [TestMethod]
        public void TesterFonctionnaliteMontre4()
        {
            Montre montre = new Montre(22,40,45);
            Montre montre2 = new Montre(22, 40, 46);


              montre.AvancerUneSeconde();
            string  montre21 = montre.ObtenirTempsCourant();

            string inci = "22:40:46";
            Assert.AreEqual(inci, montre21);


        }
        [TestMethod]
        public void TesterFonctionnaliteMontre5()
        {
            Montre montre = new Montre(22, 40, 59);
            Montre montre2 = new Montre(22, 41, 00);


            montre.AvancerUneSeconde();
            string montre21 = montre.ObtenirTempsCourant();

            string inci = montre2.ObtenirTempsCourant();
            Assert.AreEqual(inci, montre21);


     
        }
        [TestMethod]
        public void TesterFonctionnaliteMontre6()
        {
            Montre montre = new Montre(22, 59, 59);
            Montre montre2 = new Montre(23, 00, 00);


            montre.AvancerUneSeconde();
            string montre21 = montre.ObtenirTempsCourant();

            string inci = montre2.ObtenirTempsCourant();
            Assert.AreEqual(inci, montre21);



        }
        [TestMethod]
        public void TesterFonctionnaliteMontre7()
        {
            Montre montre = new Montre(23, 59, 59);
            Montre montre2 = new Montre(0, 00, 00);


            montre.AvancerUneSeconde();
            string montre21 = montre.ObtenirTempsCourant();

            string inci = montre2.ObtenirTempsCourant();
            Assert.AreEqual(inci, montre21);



        }

    }
}
