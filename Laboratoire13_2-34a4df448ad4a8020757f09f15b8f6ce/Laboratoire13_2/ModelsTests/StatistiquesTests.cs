using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tests
{
    [TestClass()]
    public class StatistiquesTests
    {
        [TestMethod()]
        public void StatistiquesTest()
        {
            List<int> nombres = new List<int>() { 2, 4, 6 };

            Statistiques statistiques =
                new Statistiques(nombres);

            Assert.IsNotNull(statistiques.ColNombres);
            Assert.AreEqual(3, statistiques.ColNombres.Count);
            Assert.AreEqual(2, statistiques.ColNombres[0]);
            Assert.AreEqual(4, statistiques.ColNombres[1]);
            Assert.AreEqual(6, statistiques.ColNombres[2]);
        }

       

        [TestMethod()]
        public void AjouterTest()
        {
            Statistiques statistiques =
                new Statistiques(new List<int>() { 2, 4, 6 });

            int resultat = statistiques.Somme;

            Assert.AreEqual(12, resultat);

        }

        [TestMethod()]
        public void NbOccurencesTest()
        {
            Statistiques statistiques =
         new Statistiques(new List<int>() { 10, 20, 30 });

            double resultat = statistiques.Moyenne;
            Assert.AreEqual(20, resultat);
        }

        [TestMethod()]
        public void NbPairsTest()
        {
            Statistiques statistiques =
     new Statistiques(new List<int>() { 1, 2, 3, 4, 5, 6 });

            
            
            List<int> resultat = statistiques.NombresPairs;
            Assert.IsNotNull(resultat);
            Assert.AreEqual(3 , resultat.Count);
            Assert.IsTrue(resultat.Contains(2));
            Assert.IsTrue(resultat.Contains(4));
            Assert.IsTrue(resultat.Contains(6));


        }
        [TestMethod()]
        public void AjouterTest1()
        {
            Statistiques statistiques = new Statistiques();

             statistiques.Ajouter(10);

            Assert.AreEqual(10, statistiques.ColNombres[0]);



        }
        [TestMethod()]
        public void AjouterTest12()
        {
            Statistiques statistiques =
            new Statistiques(new List<int>() { 2, 4, 2, 6, 2 });

            int resultat = statistiques.NbOccurences(2);

            Assert.AreEqual(3, resultat);

        }

    }
}