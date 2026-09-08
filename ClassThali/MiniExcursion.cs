using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali
{
    public class MiniExcursion
    {
        // atributs privés
        private int numero;
        private string libelle;
        private int nombrePlaces;
        private List<Etape> lesEtapes;  // contient les étapes constituant la mini-excursion 


        /// <summary>
        /// Constructeur de la classe MiniExcursion
        /// </summary>
        /// <param name="unNumero">numero de la mini-excursion</param>
        /// <param name="unLibelle">libelle de la mini-excursion</param>
        /// <param name="unNombre">nombre de places maxi de la mini-excursion</param>
        public MiniExcursion(int unNumero, string unLibelle, int unNombre)
        {
            this.numero = unNumero;
            this.libelle = unLibelle;
            this.nombrePlaces = unNombre;
            this.lesEtapes = new List<Etape>();
	    }
            

        /// <summary>
        /// Retourne le nombre de places maxi de la mini-excursion
        /// </summary>
        /// <returns>Nombre de places maximum</returns>
        public int GetNombrePlaces()
        {
            return this.nombrePlaces;
        }

        /// <summary>
        /// Retourne la liste des etapes de la mini-excursion
        /// </summary>
        /// <returns>Liste des etapes</returns>
        public List<Etape> GetlesEtapes()
        {
            return this.lesEtapes;
        }

        /// <summary>
        /// Permet d'ajouter une etape a la mini-excursion - le numero de l'etape est calculé automatiquement
        /// </summary>
        /// <param name="uneDescription">description de l'etape à ajouter</param>
        /// <param name="uneDuree">duree de l'etape à ajouter</param>
        public void AjouteEtape(string uneDescription, int uneDuree)
        {
            Etape lEtape = new Etape(1, uneDescription, uneDuree);
            this.lesEtapes.Add(lEtape);
        }

        /// <summary>
        /// Retourne la durée totale de la mini-excursion en minutes. Cette durée est 
        /// la somme des durées en minutes des étapes constituant la mini-excursion.
        /// </summary>
        /// <returns></returns>
        public int DonneDureePrevue()
        {
            return 0;
        }

        /// <summary>
        /// Retourne la durée totale de la mini-excursion sous la forme hh:mm
        /// </summary>
        /// <returns>Duree totale de la mini-excursion au format hh:mm</returns>
        public string DonneDureePrevuehhmm()
        {
            int dureeMin = this.DonneDureePrevue();
            int mm = dureeMin / 60;
            int hh = dureeMin % 60;
            return hh.ToString("00") + ":" + mm.ToString("00");
        }


        /// <summary>
        /// Méthode utile pour les tests unitaires
        /// </summary>
        /// <param name="desEtapes"></param>
        public void SetLesEtapes(List<Etape> desEtapes)
        {
            this.lesEtapes = desEtapes;
        }
    }
}
