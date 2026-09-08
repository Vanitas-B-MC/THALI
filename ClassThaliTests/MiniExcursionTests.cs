using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionTests
    {
        [TestMethod()]
        public void GetNombrePlacesTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            Assert.AreEqual(20, ME.GetNombrePlaces(), "Le nombre de places maxi est de 20");
        }

        [TestMethod()]
        public void GetlesEtapesTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            Etape ET1 = new Etape(1, "Traversee aller", 10);
            Etape ET2 = new Etape(2, "Promenade sur l'ile", 60);
            Etape ET3 = new Etape(3, "Visite du phare", 30);
            List<Etape> etapesME = new List<Etape> { ET1, ET2, ET3 };
            Assert.AreEqual(0, ME.GetlesEtapes().Count, "Aucune étape pour la ME");
            ME.SetLesEtapes(etapesME);
            CollectionAssert.AreEqual(etapesME, ME.GetlesEtapes(), "La mini-excursion comporte 3 étapes");
            Assert.AreEqual(3, ME.GetlesEtapes().Count, "3 étapes pour la ME");
        }

        [TestMethod()]
        public void AjouteEtapeTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);

            ME.AjouteEtape("Traversee aller", 10);
            Assert.AreEqual(1, ME.GetlesEtapes().Count, "1 étape pour la ME");
            Assert.AreEqual(1, ME.GetlesEtapes()[0].getNumEtape(), "la première étape a le numéro 1");

            ME.AjouteEtape("Promenade sur l'ile", 60);
            Assert.AreEqual(2, ME.GetlesEtapes().Count, "2 étapes pour la ME");
            Assert.AreEqual(2, ME.GetlesEtapes()[1].getNumEtape(), "la deuxième étape a le numéro 2");
        }

        [TestMethod()]
        public void DonneDureePrevueTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            Etape ET1 = new Etape(1, "Traversee aller", 10);
            Etape ET2 = new Etape(2, "Promenade sur l'ile", 60);
            Etape ET3 = new Etape(3, "Visite du phare", 30);
            List<Etape> etapesME = new List<Etape> { ET1, ET2, ET3 };
            Assert.AreEqual(0, ME.DonneDureePrevue(), "Aucune étape pour la ME, donc durée de 0");
            ME.SetLesEtapes(etapesME);
            Assert.AreEqual(100, ME.DonneDureePrevue(), "3 étapes de 10, 60 et 30 min, donc durée de 100");

        }

        [TestMethod()]
        public void DonneDureePrevuehhmmTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            Etape ET1 = new Etape(1, "Traversee aller", 10);
            Etape ET2 = new Etape(2, "Promenade sur l'ile", 60);
            Etape ET3 = new Etape(3, "Visite du phare", 30);
            List<Etape> etapesME = new List<Etape> { ET1, ET2, ET3 };
            Assert.AreEqual("00:00", ME.DonneDureePrevuehhmm(), "Aucune étape pour la ME, donc durée de 00:00");
            ME.SetLesEtapes(etapesME);
            Assert.AreEqual("01:40", ME.DonneDureePrevuehhmm(), "3 étapes de 10, 60 et 30 min, donc durée de 01:40");

        }


    }
}