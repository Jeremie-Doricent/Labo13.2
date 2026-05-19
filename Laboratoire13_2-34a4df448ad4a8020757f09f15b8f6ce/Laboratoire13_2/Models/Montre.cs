using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// ===================================================================================
    /// <summary>
    /// Représente une montre indiquant l'heure dans le format: HH:MM:SS
    /// On peut faire avancer le temps d'une seconde à la fois.
    /// </summary>
    /// ===================================================================================
    public class Montre
    {
        #region CHAMPS ET PROPRIÉTÉS
        ///================================================================================
        private int m_heures;
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Obtient l'heure courante de la montre
        /// </summary>
        public int Heures
        {
            get //	accès en lecture
            {
                return m_heures;
            }
            set // accès en écriture
            {
                // TODO À compléter
                m_heures = value;
            }
        }

        ///================================================================================
        private int m_minutes;
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Obtient les minutes courantes de la montre
        /// </summary>
        public int Minutes
        {
            get  // accès en lecture
            {
                return m_minutes;
            }
            set // accès en écriture
            {
                // TODO À compléter
                value = m_minutes;
            }
        }

        ///================================================================================
        private int m_secondes;
        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Obtient les secondes courantes de la montre
        /// </summary>-
        public int Secondes
        {
            get // accès en lecture
            {
                return m_secondes;
            }
            set // accès en écriture
            {
                // TODO À compléter
                m_secondes = value;
            }
        }
        #endregion

        #region CONSTRUCTEURS (2 surcharges)
        ///===================================================================================
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Montre.
        ///  Le temps au départ est 00:00:00
        /// </summary>
        public Montre()
        {
            // TODO À compléter
            heure = 00;
            minute = 00;
            Secondes = 00;
        }

        ///===================================================================================
        /// <summary>
        /// Initialise une nouvelle instance de la classe Montre.
        /// Le temps au départ est celui spécifié par les paramètres.
        /// </summary>
        /// <param name="pHeures">heure courante</param>
        /// <param name="pMinutes">minute courante</param>
        /// <param name="pSecondes">seconde courante</param>
        public Montre(int pHeures, int pMinutes, int pSecondes)
        {
            // TODO À compléter
            heure = pHeures;
            minute = pMinutes;
            seconde = pSecondes;
        }

        #endregion

        #region MÉTHODE
        public int heure 
        { get 
            { return m_heures; }
            set { if (value < 0 || value > 23) { throw new ArgumentOutOfRangeException(); } 
          
                
            m_heures = value;
            
            } 
        
        
        }


        public int minute
        {
            get
            { return m_minutes; }
            set
            {
                if (value < 0 || value > 59) { throw new ArgumentOutOfRangeException(); }


                m_minutes = value;

            }


        }
        public int seconde
        {
            get
            { return m_secondes; }
            set
            {
                if (value < 0 || value > 59) { throw new ArgumentOutOfRangeException(); }


                m_secondes = value;

            }


        }
        /// <summary>
        /// Augmente le temps courant d'une seconde 
        /// </summary>
        public void AvancerUneSeconde()
        {
            // TODO À compléter
            seconde++;
            if( seconde > 60)
            {
                seconde = 0;
                minute++;
            }
                if( minute > 60)
            {
                minute = 0;
                heure++;
            }
            if (heure> 23) { 
            
            heure = 0;
            minute = 0;
                seconde = 0;
            }
        
        }

        /// <summary>
        /// Permet d'obtenir le temps courant de la montre
        /// </summary>
        /// <returns>Le temps courant de la montre dans une chaîne formatée</returns>
        public string ObtenirTempsCourant()
        {
            // TODO À compléter
            return$"{heure}:{minute}:{seconde}";
        }

        #endregion
    }


}
