using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Statistiques
    {
       
        private List<int> m_colNombres;

        public List<int> ColNombres
        {
            get { return m_colNombres; }
            private set
            {
                if (value == null )
                { throw new ArgumentNullException(); }
                m_colNombres = value;
            }
        }     
                        
        

        /// <summary>
        /// Obtenir les nombres pairs de la collection ColNombres 
        /// </summary>
        public List<int> NombresPairs
        {                   
            get
            {
                List<int> pairs = new List<int>();
                foreach (int nombre in ColNombres)
                {
                    if (nombre % 2 == 0)
                    {
                        pairs.Add(nombre);
                    }
                }

                return pairs;
               
            }
        }
        /// <summary>
        /// Obtenir le total des nombres dans la collection
        /// </summary>
        public int Somme
        {           
            get
            {
                int vs = 0;
                foreach( int pair in ColNombres)
                {
                    vs += pair;
                }
                // TODO À compléter
                return vs;

            }
            
        }
        /// <summary>
        /// Obtenir la moyenne des nombres de la collection ou zéro si aucun élément.      
        /// </summary>
        /// <returns>décimal</returns>
        public double Moyenne
        {
            get
            {
                // TODO À compléter
           
                double total = 0;
                foreach( double pair in ColNombres)
                {
                   total += pair ;
                }
                
                return total / ColNombres.Count ;

            }
        }
        /// <summary>
        /// Instancier la classe avec une collection vide de nombres entiers
        /// </summary>
        public Statistiques()
        {
            // TODO À compléter
            ColNombres = new List<int>();
           
        }
        /// <summary>
        /// Instancier la classe avec collection d'entiers passée en paramètre
        /// </summary>
        /// <param name="pColNombres"> Collection d'entiers</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Statistiques(List<int> pColNombres)
        {
            if (pColNombres == null)
            {
                throw new ArgumentNullException();
            }
            ColNombres = pColNombres;
            // TODO À compléter
        }
        /// <summary>
        /// Ajouter un nom,bre entier à la fin de la collection
        /// </summary>
        /// <param name="pNombre">Nombre entier</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Ajouter(int pNombre)
        {
            // TODO À compléter
            ColNombres.Add(pNombre);
        }
        /// <summary>
        /// Compter le nombre d'occurences d'un entier dans la collection
        /// </summary>
        /// <param name="pNombre">nombre entier</param>
        /// <returns></returns>
        public int NbOccurences(int pNombre)
        {
            // TODO À compléter
            int compteur = 0;
            foreach( int pair in ColNombres)
            {
                if (pair == pNombre)
                {
                    compteur++;
                }
            }

            return compteur;
        }



    }
}

