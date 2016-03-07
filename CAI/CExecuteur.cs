using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Classe permettant d'intéragir avec une base de données et d'exécuter procédures stockées sur celle-ci.
/// </summary>
class CExecuteur
{
    /// <summary>
    /// Représente l'objet CExecuteurl
    /// </summary>
    private static CExecuteur m_CExecuteur;
    /// <summary>
    /// Chaine de connexion par défaut, modifiée selon le TP.
    /// </summary>
    private const string CHAINE_DEFAUT = "Server=sql5.freemysqlhosting.net; Port=3306; Database=sql5109751; Uid=sql5109751; Pwd=3ZTWmyU8xJ;";

    /// <summary>
    /// Connexion utilisée
    /// </summary>
    private MySqlConnection m_ConSQL;

    /// <summary>
    /// Constructeur par défaut avec une chaîne de connexion par défaut.
    /// </summary>
    private CExecuteur()
    {
        m_ConSQL = new MySqlConnection();
        m_ConSQL.ConnectionString = CHAINE_DEFAUT;
    }

    /// <summary>
    /// Permet d'obtenir l'objet CExecuteur et d'ainsi avoir accès à ses méthodes
    /// </summary>
    /// <returns>Retourne le CExecuteur</returns>
    public static CExecuteur ObtenirCExecuteur()
    {
        if (m_CExecuteur == null)
            m_CExecuteur = new CExecuteur();
        return m_CExecuteur;
    }
    /// <summary>
    /// Changer le nom de la base de données dans la chaîne de connexion courante.
    /// </summary>
    /// <param name="_NomBD">Nom de la base de donnée que l'on souhaite sauvegarder.</param>
    public void ChangerBD(string _NomBD)
    {
        m_ConSQL.ConnectionString = m_ConSQL.ConnectionString.Replace(m_ConSQL.Database, _NomBD);
    }
    /// <summary>
    /// Changer le nom du serveur de la connexion courante selon le nom reçu en paramètre.
    /// </summary>
    /// <param name="_NomServeur">Nom du serveur.</param>
    public void ChangerServeur(string _NomServeur)
    {
        m_ConSQL.ConnectionString = m_ConSQL.ConnectionString.Replace(m_ConSQL.DataSource, _NomServeur);
    }
    /// <summary>
    /// Déterminer si la connexion vers la base de données fonctionne.
    /// </summary>
    /// <returns>Retourne vrai si elle est valide. Sinon, retourne faux.</returns>
    public bool ConnexionValide()
    {
        bool ConnexionValide = true; // Si la connexion vers la BD fonctionne.

        try
        {
            m_ConSQL.Open();
            m_ConSQL.Close();
        }
        catch
        {
            ConnexionValide = false;
        }

        return ConnexionValide;
    }
    /// <summary>
    /// Exécuter une vue selon le nom de la vue que l'on reçoit en paramètre.
    /// </summary>
    /// <param name="_NomVue">Correspond au nom de la vue que l'on souhaite exécuter.</param>
    /// <returns>Retourne la table de la vue si la vue retourne une table. Sinon, retourne null.</returns>
    public DataTable ExecVue(string _NomVue)
    {
        DataTable pTabInfos = null; // Représente les informations retournées de la view exécuté.

        // Si la vue reçu existe
        if (RetournerSiVueExiste(_NomVue))
        {
            MySqlCommand pCmdSql = new MySqlCommand("SELECT * FROM " + _NomVue, m_ConSQL); // Pointe vers une commande SQL (ici ce sera une vue qui va être exécuté)

            pCmdSql.CommandType = CommandType.Text;

            try
            {
                m_ConSQL.Open();
                MySqlDataReader pLigneActuel = pCmdSql.ExecuteReader(); // Pointe vers l'enregistrement courant des informations retournées de la procédure stockée exécuté.
                // Si la vue retourné a au moins un enregistrement ou plus.
                if (pLigneActuel.HasRows)
                {
                    pTabInfos = new DataTable(); // Correspond à la table d'enregistrement que l'on va retourner selon les informations retournées de la vue.
                    // Pour chaque colonne de la vue retourné
                    for (int indCol = 0; indCol < pLigneActuel.FieldCount; indCol++)
                        pTabInfos.Columns.Add();
                    // Pour chaque enregistrement reçu de la vue exécuté, on place celui-ci dans la table que l'on souhaite retourner.
                    while (pLigneActuel.Read())
                    {
                        object[] TabInfosLigneActuel = new object[pLigneActuel.FieldCount]; // Tableau qui contient toutes les informations de la ligne actuelle
                        pLigneActuel.GetValues(TabInfosLigneActuel);
                        pTabInfos.Rows.Add(TabInfosLigneActuel);
                    }
                    pLigneActuel.Close();
                }
            }
            finally
            {
                // Si la connexion SQL existe encore, on ferme celle-ci.
                if (m_ConSQL != null)
                    m_ConSQL.Close();
            }
        }

        return pTabInfos;
    }
    /// <summary>
    /// Retourne si une vue existe selon le nom reçu en paramètre.
    /// </summary>
    /// <param name="_NomVue">Nom de la vue que l'on souhaite vérifier si elle existe ou pas.</param>
    /// <returns>Retourne vrai si elle existe. Sinon, retourne faux.</returns>
    public bool RetournerSiVueExiste(string _NomVue)
    {
        bool VueExiste = false; // Représente si la vue existe.
        MySqlCommand pCmdSql = new MySqlCommand("SELECT * FROM " + _NomVue, m_ConSQL); // Commande SQL que l'on va exécuter (ici on exécute une vue).

        pCmdSql.CommandType = CommandType.Text;

        try
        {
            m_ConSQL.Open();
            MySqlDataReader pRequete = pCmdSql.ExecuteReader(); // La procédure stockée va retourner si le nom de la procédure reçu en paramètre existe ou pas.
            VueExiste = (pRequete.Read()); // Si la procédure stockée existe
        }
        finally
        {
            // Si la connexion existe encore, on ferme celle-ci.
            if (m_ConSQL != null)
                m_ConSQL.Close();
        }

        return VueExiste;
    }

    /// <summary>
    /// Exécuter une procédure stockée et retourner les informations qu'elle retourne si elle retourne des informations.
    /// </summary>
    /// <param name="_NomPs">Nom de la procédure stockée que l'on veut exécuter.</param>
    /// <param name="_TabParametres">Tableau des paramètres EN ORDRE des procédures.</param>
    /// <returns>Retourne la table contenant les informations que la procédure stockée a retourné si c'est le cas. Sinon, retourne null si rien n'a été retourné.</returns>
    public DataTable ExecFn(string _NomPs, string[] _TabParametres)
    {
        DataTable pTabInfos = null; // Représente les informations retournées de la procédure stockée exécuté.

        string[] TabNomParametres = RetournerNomParametre(_NomPs); // Tableau qui représente les paramètres pour la procédure stockée.
        MySqlCommand pCmdSql = new MySqlCommand(_NomPs, m_ConSQL); // Pointe vers une procédure stockée.
        pCmdSql.CommandType = CommandType.StoredProcedure;

        try
        {
            m_ConSQL.Open();

            // S'il y a des paramètres existant, on ajoute ces paramètres pour que lorsqu'on va exécuter la procédure stockée, cette procéduire va recevoir les valeurs pour chaque paramètre.
            if (TabNomParametres != null && _TabParametres.Length == TabNomParametres.Length)
                for (int indParam = 0; indParam < TabNomParametres.Length; indParam++)
                    pCmdSql.Parameters.AddWithValue(TabNomParametres[indParam], _TabParametres[indParam]);
            pCmdSql.Parameters.Add("@return", MySqlDbType.Int32);
            pCmdSql.Parameters["@return"].Direction = ParameterDirection.ReturnValue;

            MySqlDataReader pLigneActuel = pCmdSql.ExecuteReader(); // Pointe vers l'enregistrement courant des informatiosn retournées de la procédure stockée exécuté.

            // Si la procédure retourné a au moins un enregistrement ou plus.
            if (pLigneActuel.HasRows)
            {
                pTabInfos = new DataTable(); // Correspond à la table d'enregistrement que l'on va retourner selon les informations retournées de la procédure stockée.
                // Pour chaque colonne de la vue retourné
                for (int indCol = 0; indCol < pLigneActuel.FieldCount; indCol++)
                    pTabInfos.Columns.Add();
                // Pour chaque enregistrement reçu de la vue exécuté, on place celui-ci dans la table que l'on souhaite retourner.
                while (pLigneActuel.Read())
                {
                    object[] TabInfosLigneActuel = new object[pLigneActuel.FieldCount]; // Tableau qui contient toutes les informations de la ligne actuelle
                    pLigneActuel.GetValues(TabInfosLigneActuel);
                    pTabInfos.Rows.Add(TabInfosLigneActuel);
                }
                pTabInfos.Rows.Add(pCmdSql.Parameters["@return"].Value);
                pLigneActuel.Close();
            }
        }
        finally
        {
            // Si la connexion existe encore, on ferme celle-ci.
            if (m_ConSQL != null)
                m_ConSQL.Close();
               
        }

        return pTabInfos;
    }

    /// <summary>
    /// Exécuter une procédure stockée et retourner les informations qu'elle retourne si elle retourne des informations.
    /// </summary>
    /// <param name="_NomPs">Nom de la procédure stockée que l'on veut exécuter.</param>
    /// <param name="_TabParametres">Tableau des paramètres EN ORDRE des procédures.</param>
    /// <returns>Retourne la table contenant les informations que la procédure stockée a retourné si c'est le cas. Sinon, retourne null si rien n'a été retourné.</returns>
    public DataTable ExecPs(string _NomPs, string[] _TabParametres)
    {
        DataTable pTabInfos = null; // Représente les informations retournées de la procédure stockée exécuté.

        // Si la procédure stockée reçu existe
        if (RetournerSiPsExiste(_NomPs))
        {
            string[] TabNomParametres = RetournerNomParametre(_NomPs); // Tableau qui représente les paramètres pour la procédure stockée.
            MySqlCommand pCmdSql = new MySqlCommand(_NomPs, m_ConSQL); // Pointe vers une procédure stockée.
            pCmdSql.CommandType = CommandType.StoredProcedure;

            try
            {
                m_ConSQL.Open();

                // S'il y a des paramètres existant, on ajoute ces paramètres pour que lorsqu'on va exécuter la procédure stockée, cette procéduire va recevoir les valeurs pour chaque paramètre.
                if (TabNomParametres != null && _TabParametres.Length == TabNomParametres.Length)
                    for (int indParam = 0; indParam < TabNomParametres.Length; indParam++)
                        pCmdSql.Parameters.AddWithValue(TabNomParametres[indParam], _TabParametres[indParam]);
                
                MySqlDataReader pLigneActuel = pCmdSql.ExecuteReader(); // Pointe vers l'enregistrement courant des informatiosn retournées de la procédure stockée exécuté.
                
                // Si la procédure retourné a au moins un enregistrement ou plus.
                if (pLigneActuel.HasRows)
                {
                    pTabInfos = new DataTable(); // Correspond à la table d'enregistrement que l'on va retourner selon les informations retournées de la procédure stockée.
                    // Pour chaque colonne de la vue retourné
                    for (int indCol = 0; indCol < pLigneActuel.FieldCount; indCol++)
                        pTabInfos.Columns.Add();
                    // Pour chaque enregistrement reçu de la vue exécuté, on place celui-ci dans la table que l'on souhaite retourner.
                    while (pLigneActuel.Read())
                    {
                        object[] TabInfosLigneActuel = new object[pLigneActuel.FieldCount]; // Tableau qui contient toutes les informations de la ligne actuelle
                        pLigneActuel.GetValues(TabInfosLigneActuel);
                        pTabInfos.Rows.Add(TabInfosLigneActuel);
                    }
                    pLigneActuel.Close();
                }                                       
            }
            finally
            {
                // Si la connexion existe encore, on ferme celle-ci.
                if (m_ConSQL != null)
                    m_ConSQL.Close();
            }
        }

        return pTabInfos;
    }

    /// <summary>
    /// Exécuter une procédure stockée avec des paramètres en output.
    /// </summary>
    /// <param name="_NomPs">Nom de la procédure stockée que l'on veut exécuter.</param>
    /// <param name="_TabParametres">Tableau des paramètres EN ORDRE des procédures.</param>
    /// <param name="_TabEstEnOutput">Tableau des paramètres qui représente si le paramètre est en output ou non.</param>
    public void ExecPs(string _NomPs, ref string[] _TabParametres, bool[] _TabEstEnOutput)
    {
        string[] TabNomParametres = RetournerNomParametre(_NomPs); // Tableau qui représente les paramètres pour la procédure stockée.
        MySqlCommand pCmdSql = new MySqlCommand(_NomPs, m_ConSQL); // Pointe vers une procédure stockée.
        pCmdSql.CommandType = CommandType.StoredProcedure;

        try
        {
            m_ConSQL.Open();

            // S'il y a des paramètres existant, on ajoute ces paramètres pour que lorsqu'on va exécuter la procédure stockée, cette procédure va recevoir les valeurs pour chaque paramètre.
            if (TabNomParametres != null && _TabParametres.Length == TabNomParametres.Length && _TabParametres.Length == _TabEstEnOutput.Length)
            {
                for (int IndParam = 0; IndParam < TabNomParametres.Length; IndParam++)
                {
                    pCmdSql.Parameters.AddWithValue(TabNomParametres[IndParam], _TabParametres[IndParam]);
                    if (_TabEstEnOutput[IndParam])
                    {
                        pCmdSql.Parameters[IndParam].MySqlDbType = MySqlDbType.VarChar;
                        pCmdSql.Parameters[IndParam].Size = 4000;
                        pCmdSql.Parameters[IndParam].Direction = ParameterDirection.Output;
                    }

                }
            }
            pCmdSql.ExecuteNonQuery();
            // S'il y a des paramètres existant, on ajoute ces paramètres pour que lorsqu'on va exécuter la procédure stockée, cette procédure 
            if (TabNomParametres != null && _TabParametres.Length == TabNomParametres.Length && _TabParametres.Length == _TabEstEnOutput.Length)
            {
                for (int IndParam = 0; IndParam < _TabEstEnOutput.Length; IndParam++)
                    if (_TabEstEnOutput[IndParam])
                        _TabParametres[IndParam] = pCmdSql.Parameters[IndParam].Value.ToString();
            }
                    
        }
        finally
        {
            // Si la connexion existe encore, on ferme celle-ci.
            if (m_ConSQL != null)
                m_ConSQL.Close();
        }
    }

    /// <summary>
    /// Retourne si le nom d'une procédure stockée reçu en paramètre existe dans la base de données que l'on est connecté présentement.
    /// </summary>
    /// <param name="_NomPs">Nom de la procédure stockée que l'on souhaite vérifier si elle existe ou pas.</param>
    /// <returns>Retourne vrai si celle-ci existe. Sinon, retourne faux.</returns>
    public bool RetournerSiPsExiste(string _NomPs)
    {
        bool PsExiste = false; // Représente si la procédure stockée existe.
        MySqlCommand pCmdSql = new MySqlCommand("spVerifierSiProcedureExiste", m_ConSQL); // Procédure stockée qui va vérifier si la procédure stockée que l'on souhaite exécuter existe.
        pCmdSql.Parameters.AddWithValue("@NomProcedure", _NomPs);
        pCmdSql.CommandType = CommandType.StoredProcedure;

        try
        {
            m_ConSQL.Open();
            MySqlDataReader pRequete = pCmdSql.ExecuteReader(); // La procédure stockée va retourner si le nom de la procédure reçu en paramètre existe ou pas.
            PsExiste = (pRequete.Read()); // Si la procédure stockée existe
        }
        finally
        {
            // Si la connexion existe encore, on ferme celle-ci.
            if (m_ConSQL != null)
                m_ConSQL.Close();
        }

        return PsExiste;
    }
    /// <summary>
    /// Retourner tous les noms des paramètres d'une procédure stockée.
    /// </summary>
    /// <param name="_NomPs">Nom de la procédure stockée que l'on souhaite retourner les noms des paramètres.</param>
    /// <returns>Retourne les noms des paramètres s'il y a en a. Sinon, retourne null ou 0.</returns>
    private string[] RetournerNomParametre(string _NomPs)
    {
        string[] TabParametres = null; // Tableau qui va retourner tous les noms des paramètres de la procédure stockée qu'on a reçu en paramètre.

        MySqlCommand pCmdSql = new MySqlCommand("spRetournerNomsParametres", m_ConSQL); // Pointe vers une procédure stockée (ici on va exécuter une procédure stockée)
        pCmdSql.Parameters.AddWithValue("NomProcedure", _NomPs);
        pCmdSql.CommandType = CommandType.StoredProcedure;

        try
        {
            m_ConSQL.Open();
            MySqlDataReader pLigneActuel = pCmdSql.ExecuteReader();
            List<string> pLstParametres  = new List<string>(); // Création d'une liste pour sauvegarder les paramètres.

            // Si ça la retourné des paramètres.
            while (pLigneActuel.Read())
            {
                object[] TabInfosLigneActuel = new object[pLigneActuel.FieldCount]; // Tableau qui contient toutes les informations de la ligne actuelle
                pLigneActuel.GetValues(TabInfosLigneActuel);

                if (TabInfosLigneActuel[0] != null)
                    // Ajout des noms des paramètres de la procédure ou fonction dans la liste des noms de paramètres.       
                    pLstParametres.Add((string)TabInfosLigneActuel[0]);  
            }

            if (pLstParametres.Count > 0)
                TabParametres = pLstParametres.ToArray();

            pLstParametres = null;
        }
        finally
        {
            // Si la connexion existe encore, on ferme celle-ci.
            if (m_ConSQL != null)
                m_ConSQL.Close();
        }

        return TabParametres;
    }

}

