using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali.Tests
{
    [TestClass()]
    public class EtapeTests
    {
        [TestMethod()]
        public void getNumEtapeTest()
        {
            Etape ET1 = new Etape(1, "Visite du phare", 30);
            Assert.AreEqual(1, ET1.getNumEtape(), "Le numéro de l'étape est 1");
        }

        [TestMethod()]
        public void getDureePrevueTest()
        {
            Etape ET = new Etape(1, "Promenade dans l'ile", 60);
            Assert.AreEqual(60, ET.getDureePrevue(), "La durée de l'étape est de 60 min");
        }

        [TestMethod()]
        public void getDescEtapeTest()
        {
            Etape ET = new Etape(1, "Promenade dans l'ile", 60);
            Assert.AreEqual("Promenade dans l'ile", ET.getDescEtape(), "La description de l'étape est promenade dans l'ile");
        }
    }
}