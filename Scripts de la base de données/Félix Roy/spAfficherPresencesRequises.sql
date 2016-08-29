/*
  10 février 2016 par Félix Roy (felix.roy.26@gmail.com).
	-Création du script.
*/

/*Affiche toutes les présences requises pour tous les étudiants.*/

USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesRequises(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100))
BEGIN

	/*Si l'utilisateur est un admin, il peut modifier une période.*/
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		SELECT Usagers.UsagersPrenom, Usagers.UsagersNom, PresencesRequises.PresencesRequisesJournee, Periodes.PeriodesHeureDebut, Periodes.PeriodesHeureFin  
		FROM (((Usagers INNER JOIN Presencesrequises 
		ON Usagers.UsagersID = PresencesRequises.PresencesRequisesUsagersID)  
		
		INNER JOIN presencesrequisesperiodes
		ON PresencesRequises.PresencesRequisesID = PresencesRequisesPeriodes.PresencesRequisesPeriodesPresencesRequisesID)
		
		INNER JOIN Periodes
		ON PresencesRequisesPeriodes.PresencesRequisesPeriodesPeriodesID = Periodes.PeriodesID);
                                                                         
	END IF;
	
END//

/* Va retourner sous le format suivant: Félix | Roy | 10 fev 2016 | 10:00 | 12:00 */