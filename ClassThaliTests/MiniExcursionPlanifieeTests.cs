using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionPlanifieeTests
    {
        [TestMethod()]
        public void MiniExcursionPlanifieeTest()
        {
            DateTime lheure = DateTime.Parse("10:30");
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            
            MiniExcursionPlanifiee E = new MiniExcursionPlanifiee("JE100-1", ME, lheure);
            Assert.AreEqual(E.GetCode(), "JE100-1", "E = MC² (True)");
            Assert.AreEqual(E.GetMiniExcursion(), ME, "Vrai si il possede la mini excursion ME");
            // Assert.AreEqual("12:10")

        }

        [TestMethod()]
        public void GetCodeTest()
        {
            DateTime lheure = DateTime.Parse("10:30");
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee E = new MiniExcursionPlanifiee("JE100-1", ME, lheure);
            Assert.AreEqual("JE100-1", E.GetCode(), "E = MC² (True)");
        }

        [TestMethod()]
        public void SetNombreInscritsTest()
        {
            DateTime lheure = DateTime.Parse("10:30");
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee E = new MiniExcursionPlanifiee("JE100-1", ME, lheure);
            Assert.AreEqual(0, E.GetNbInscrit(), "doit etre egale a 0");
            E.SetNombreInscrits(10);
            Assert.AreEqual(10, E.GetNbInscrit(), "doit etre egale a 10");
            E.SetNombreInscrits(4);
            Assert.AreEqual(14, E.GetNbInscrit(), "doit etre egale a 14");
        }

        [TestMethod()]
        public void EstCompleteTest()
        {
            DateTime lheure = DateTime.Parse("10:30");
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            MiniExcursionPlanifiee E = new MiniExcursionPlanifiee("JE100-1", ME, lheure);
            E.SetNombreInscrits(10);
            Assert.AreEqual(false, E.EstComplete(), "doit etre false");
            E.SetNombreInscrits(10);
            Assert.AreEqual(true, E.EstComplete(), "doit etre true");
        }

        [TestMethod()]
        public void HeureRetourPrevueTest()
        {
            DateTime lheure = DateTime.Parse("10:20");
            MiniExcursion ME = new MiniExcursion(1, "Visite de l'ile au large de THALI", 20);
            Etape ET1 = new Etape(1, "Traversee aller", 60);
            Etape ET2 = new Etape(2, "Promenade sur l'ile", 60);
            Etape ET3 = new Etape(3, "Visite du phare", 30);
            List<Etape> etapesME = new List<Etape> { ET1, ET2, ET3 };
            MiniExcursionPlanifiee E = new MiniExcursionPlanifiee("JE100-1", ME, lheure);
            ME.SetLesEtapes(etapesME);
            DateTime test = E.HeureRetourPrevue();
            Assert.AreEqual(DateTime.Parse("12:50"), E.HeureRetourPrevue(), "12h10 attendu");
        }
    }
}