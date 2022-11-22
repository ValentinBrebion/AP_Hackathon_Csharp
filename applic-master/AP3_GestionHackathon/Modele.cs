using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace AP3_GestionHackathon
{
    public static class Modele
    {
        private static hackathonEntities maConnexion;

        /// <summary>
        /// initialise la connexion à la BD
        /// </summary>
        public static void init()
        {
            maConnexion = new hackathonEntities();
        }

        /// <summary>
        /// Retourne toute la liste des hackathons
        /// </summary>
        /// <returns></returns>
        public static List<HACKATHON> listeHackathons()
        {
            return maConnexion.HACKATHON.ToList();
        }

        /// <summary>
        /// Retourne toute la liste des equipe
        /// </summary>
        /// <returns></returns>
        public static List<EQUIPE> listeEquipe()
        {
            return maConnexion.EQUIPE.ToList();
        }

        /// <summary>
        /// Retourne toute la liste des organisateurs
        /// </summary>
        /// <returns></returns>
        public static List<ORGANISATEUR> listeOrganisateurs()
        {
            return maConnexion.ORGANISATEUR.ToList();
        }

        /// <summary>
        /// Retourne la liste des équipes inscrites à l'hackathon dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idH"></param>
        /// <returns></returns>
        public static List<EQUIPE> listeEquipesParHackathon(int idH)
        {
            // parcourir les équipes et récupérer celle de l'hackathon
            HACKATHON h = maConnexion.HACKATHON.Find(idH);
            List<INSCRIRE> lesI = h.INSCRIRE.ToList();
            List<EQUIPE> lesE = new List<EQUIPE>();
            foreach (INSCRIRE I in lesI)
            {
                lesE.Add(I.EQUIPE);
            }
            return lesE;
        }

        /// <summary>
        /// Retourne l'identifiant du dernier hackathon saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierHackathonSaisi()
        {
            return maConnexion.HACKATHON.Max(x => x.idhackathon);
        }

        /// <summary>
        /// Retourne l'identifiant du dernier Equipe saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDerniereEquipeSaisi()
        {
            return maConnexion.EQUIPE.Max(x => x.idequipe);
        }



        /// <summary>
        /// Retourne vrai si l'ajout d'un hackathon a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="idOrganisateur"></param>
        /// <param name="nbmaxequip"></param>
        /// <param name="datefininscription"></param>
        /// <returns></returns>
        public static bool AjoutHackathon(string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF,int idOrganisateur,int nbmaxequip, DateTime datefininscription)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unHackathon = new HACKATHON();
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.dateFinInscription = datefininscription;
                unHackathon.nbMaxEquip = nbmaxequip;
       
                maConnexion.HACKATHON.Add(unHackathon);
                maConnexion.SaveChanges();
                               
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        ///AJOUT HACKATHON
        /// <summary>
        /// Retourne vrai si l'ajout d'un membre a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <param name="telephone"></param>
        /// <param name="portfolio"></param>
        /// <param name="datenaiss"></param>
       
        /// <returns></returns>
        public static bool AjoutMembre(int idequipe,string nom, string prenom, string email, string telephone, string portfolio, DateTime datenaiss)
        {
            MEMBRE unMembre;
            /*int unMailMembre;*/
            bool mailtrue = false;
            

            /*unMailMembre = maConnexion.MEMBRE.Max(x => x.idmembre);*/


            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unMembre = new MEMBRE();
                if(idequipe == -1)
                {
                    unMembre.idequipe = null;
                }
                else
                {
                    unMembre.idequipe = idequipe;
                }
               
                unMembre.nom = nom;
                unMembre.prenom = prenom;

                List<MEMBRE> l = listeMembres();
                foreach (MEMBRE m in l)
                {
                    if (m.email == email)
                    {
                        
                        mailtrue = true;
                        vretour = false;
                    }
                   
                    
                }
                if (!mailtrue)
                {
                    unMembre.email = email;
                
                

                unMembre.telephone = telephone;
                unMembre.lienportfolio = portfolio;
                unMembre.datenaissance = datenaiss;
               

                maConnexion.MEMBRE.Add(unMembre);
                maConnexion.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Retourne vrai si la modification d'un membre a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
      
        /// <param name="nomMembre"></param>
        /// <param name="PrenomMembre"></param>
        /// <param name="EmailMembre"></param>
        /// <param name="telephone"></param>
        /// <param name="dtnaiss"></param>
        /// <param name="portfolio"></param>

        /// <returns></returns>
        /*PARTIE MODIFICATION Membre*/
        public static bool ModificationMembre(int idM,string nomMembre, string PrenomMembre, string EmailMembre, string telephone, DateTime dtnaiss, string portfolio)
        {
            MEMBRE unMembre;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unMembre = RecupererMEMBRE(idM);

                // mise à jour des champs de l'hackathon
             
                unMembre.nom = nomMembre;
                unMembre.prenom = PrenomMembre;
                unMembre.email = EmailMembre;
                unMembre.telephone = telephone;
                unMembre.datenaissance = dtnaiss;
                unMembre.lienportfolio = portfolio;
                


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        /*Archivage Membre*/
        public static bool ModifiArchivageMembre(int idM)
        {
            bool EstArchivee = true;
            MEMBRE unMembre;


            try
            {
                unMembre = RecupererMEMBRE(idM);
                unMembre.EstArchivéMembre = true;

                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return EstArchivee;

        }
        public static bool SuppMEMBRE(int idMEMBRE)
        {
            MEMBRE unMembre;
            bool vretour = true;
            try
            {
                unMembre = RecupererMEMBRE(idMEMBRE);
                maConnexion.MEMBRE.Remove(unMembre);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }
        /*PARTIE RECUPERER MEMBRE*/
        public static MEMBRE RecupererMEMBRE(int idM)
        {
            MEMBRE unMembre = new MEMBRE();
            try
            {
                unMembre = maConnexion.MEMBRE.First(x => x.idmembre == idM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMembre;
        }
        /*AJout membre à une équipe*/
        public static bool AjoutEquipeMembre(int idEMem, int indexEquipe)
        {

            MEMBRE uneMembre;
            bool EstAjoute = true;
            try
            {
                // récupération de l'hackathon à modifier
                uneMembre = RecupererMEMBRE(idEMem);

                // mise à jour des champs de l'hackathon
                uneMembre.idequipe = indexEquipe;


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                EstAjoute = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return EstAjoute;
        }

        /*Partie suppression membre d'une équipe*/
        public static bool SupprEquipeMembre(int idEMem)
        {

            MEMBRE uneMembre;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                uneMembre = RecupererMEMBRE(idEMem);

                // mise à jour des champs de l'hackathon
                uneMembre.idequipe = null;


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Retourne vrai si l'ajout d'une equipe a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="nomEquipe"></param>
        /// <param name="lienprot"></param>
        /// <param name="log"></param>
        /// <param name="mdp"></param>
        /// /// <param name="nbpart"></param>

        /// <returns></returns>
        public static bool AjoutEquipe(string nomEquipe, string lienprot, int nbpart, string log, string mdp)
        {
            
            EQUIPE uneEquipe;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneEquipe = new EQUIPE();
                uneEquipe.nomequipe = nomEquipe;
                uneEquipe.lienprototype = lienprot;
                uneEquipe.nbparticipants = nbpart;
                uneEquipe.login = log;
                uneEquipe.password = BCrypt.Net.BCrypt.HashPassword(mdp);


                maConnexion.EQUIPE.Add(uneEquipe);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /*PARTIE MODIFICATION EQUIPE*/
        public static bool ModificationEquipe(int idE, string nomequi, string lienpro, int nbpart,string login, string mdp)
        {
            EQUIPE uneEquipe;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                uneEquipe = RecupererEquipe(idE);

                // mise à jour des champs de l'hackathon
                uneEquipe.nomequipe = nomequi;
                uneEquipe.lienprototype = lienpro;
                uneEquipe.nbparticipants = nbpart;
                uneEquipe.nbparticipants = 0;
                uneEquipe.login = login;
                uneEquipe.password = BCrypt.Net.BCrypt.HashPassword(mdp);


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
       

        /*PARTIE RECUPERER EQUIPE*/

        /// <summary>
        /// Fonction qui retourne l'objet hackathon qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idE">identifiant de l'hackathon</param>
        /// <returns></returns>
        public static EQUIPE RecupererEquipe(int idE)
        {
            EQUIPE uneEquipe = new EQUIPE();
            try
            {
                uneEquipe = maConnexion.EQUIPE.First(x => x.idequipe == idE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneEquipe;
        }

        /// <summary>
        /// Retourne l'identifiant du dernier Membre saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierMembreSaisi()
        {
            return maConnexion.MEMBRE.Max(x => x.idmembre);
        }
        /// <summary>
        /// Fonction qui retourne l'objet hackathon qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idH">identifiant de l'hackathon</param>
        /// <returns></returns>
        public static HACKATHON RecupererHackathon(int idH)
        {
            HACKATHON unHackathon = new HACKATHON();
            try
            {
                unHackathon = maConnexion.HACKATHON.First(x => x.idhackathon == idH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unHackathon;
        }

        /// <summary>
        /// Retourne vrai si la modification de l'hackathon dont l'identifiant est passé en paramètre a pu avoir lieu
        /// </summary>
        /// <param name="idH"></param>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="idOrganisateur"></param>
        /// <param name="nbmaxequip"></param>
        /// <param name="datefininscription"></param>
        /// <returns></returns>
        public static bool ModificationHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur, int nbmaxequip, DateTime datefininscription)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unHackathon = RecupererHackathon(idH);

                // mise à jour des champs de l'hackathon
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nbMaxEquip = nbmaxequip;
                unHackathon.dateFinInscription = datefininscription;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }


        /// <summary>
        /// Retourne vrai si l'ajout d'un organisateur a pu avoir lieu
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool AjoutOrganisateur(string nom, string prenom, string email)
        {
            ORGANISATEUR unOrga;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unOrga = new ORGANISATEUR();
                unOrga.nom = nom;
                unOrga.prenom = prenom;
                unOrga.email = email;

                maConnexion.ORGANISATEUR.Add(unOrga);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ConnexionAdministrateur(string login, string mdp)
        {
            bool connreturn = false;
            ADMINISTRATEUR adm = new ADMINISTRATEUR();
            try
            {
                connreturn = true;
              
               
              
                adm = maConnexion.ADMINISTRATEUR.First(x => x.nom == login); // objet contenant l'enregistrement administrateur

                string passwordHash = adm.motpasse; 
                bool verified = BCrypt.Net.BCrypt.Verify(mdp, passwordHash);

                if (verified)
                {
                    return true;
                }
                else
                {
                    return false;
                }
              

            }
            catch (Exception e)
            {
                connreturn = false;
                MessageBox.Show(e.Message.ToString());
            }
            return connreturn;

        }
        /*PARTIE MODIFICATION ARCHIVAGE*/
        public static bool ModifiArchivage(int idH)
        {
            bool EstArchivee = true;
            HACKATHON unHackathon;

            
            try
            {
                unHackathon = RecupererHackathon(idH);
                unHackathon.EstArchivé = true;

                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return EstArchivee;

        }
        
        /*PARTIE SUPPRESSION HACKATHON*/
        public static bool SupphACKATHON(int idhACKA)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                unHackathon = RecupererHackathon(idhACKA);
                maConnexion.HACKATHON.Remove(unHackathon);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }
        public static List<MEMBRE> listeMembres()
        {
            return maConnexion.MEMBRE.ToList();
        }
    }
}
