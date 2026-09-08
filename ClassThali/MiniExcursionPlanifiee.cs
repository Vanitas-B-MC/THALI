using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali
{
    public class MiniExcursionPlanifiee
    {
        // attributs privés
        private string code;
        private MiniExcursion laMiniExcursion; 
        private DateTime heureDepart;
        private int nombreInscrits;

        /// <summary>
        /// Constructeur de la classe MiniExcursionPlanifiee
        /// </summary>
        /// <param name="unCode">code de la mini-excursion</param>
        /// <param name="uneMiniExcursion">objet MiniExcursion</param>
        /// <param name="uneHeure">heure de départ de la mini-excursion</param>
        public MiniExcursionPlanifiee(string unCode, MiniExcursion uneMiniExcursion, DateTime uneHeure)
        {
            //TODO
        }

        /// <summary>
        /// Retourne le code de la mini-excursion planifiée
        /// </summary>
        /// <returns>code de la MEP</returns>
        public string GetCode()
        {
            //TODO
            return "";
        }

        /// <summary>
        /// Augmente l'attribut nombreInscrits du nombre de passagers inscrits passé en paramètre
        /// </summary>
        /// <param name="unNombre">Nombre de passagers insrits</param>
        public void SetNombreInscrits(int unNombre)
        {
            //TODO
        }

        /// <summary>
        /// Retourne un booleen qui indique si la mini-excursion planifiee est complete ou non
        /// </summary>
        /// <returns>true si la mini-excursion est complete, false dans le cas contraire</returns>
        public bool EstComplete()
        {
            //TODO
            return true;
        }

        /// <summary>
        /// Retourne la date de retour prevue de la mini-excursion planifiee
        /// </summary>
        /// <returns>Date de retour prevue de la MEP</returns>
        public DateTime HeureRetourPrevue()
        {
            //TODO
            return new DateTime();
        }
  
    }
}
