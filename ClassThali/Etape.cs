using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali
{
    public class Etape
    {
        // attributs privés
        private int numEtape;
        private string description;
        private int dureePrevue;    // durée de l'étape exprimée en minutes

        /// <summary>
        /// Constructeur de la classe Etape
        /// </summary>
        /// <param name="unNumero">numero de l'etape</param>
        /// <param name="uneDescription">description de l'etape</param>
        /// <param name="uneDuree">duree en minutes de l'etape</param>
        public Etape(int unNumero, string uneDescription, int uneDuree)
        {
            this.numEtape = unNumero;
            this.description = uneDescription;
            this.dureePrevue = uneDuree;
        }
        
        /// <summary>
        /// Retourne le numero de l'etape
        /// </summary>
        /// <returns>numero de l'etape</returns>
        public int getNumEtape()
        {
            return this.numEtape;
        }

        /// <summary>
        /// Retourne la description de l'etape
        /// </summary>
        /// <returns>description de l'etape</returns>
        public string getDescEtape()
        {
            return this.description;
        }

        /// <summary>
        /// Retourne la duree prevue de l'etape
        /// </summary>
        /// <returns>Duree en minutes de l'etape</returns>
        public int getDureePrevue()
        {
            return this.dureePrevue;
        }

    }
}
