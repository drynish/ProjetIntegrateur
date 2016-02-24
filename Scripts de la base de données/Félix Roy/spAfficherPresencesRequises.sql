/*
  10 f�vrier 2016 par F�lix Roy (felix.roy.26@gmail.com).
	-Cr�ation du script.
*/

/*Affiche toutes les pr�sences requises pour tous les �tudiants.*/

USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesRequises(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100))
BEGIN

	/*Si l'utilisateur est un admin, il peut modifier une p�riode.*/
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		SELECT usagers.UsagersPrenom, usagers.UsagersNom, presencesrequises.PresencesRequisesJournee, periodes.PeriodesHeureDebut, periodes.PeriodesHeureFin  
		FROM (((usagers INNER JOIN presencesrequises 
		ON usagers.UsagersID = presencesrequises.PresencesRequisesUsagersID)  
		
		INNER JOIN presencesrequisesperiodes
		ON presencesrequises.PresencesRequisesID = presencesrequisesperiodes.PresencesRequisesPeriodesPresencesRequisesID)
		
		INNER JOIN periodes
		ON presencesrequisesperiodes.PresencesRequisesPeriodesPeriodesID = periodes.PeriodesID);
                                                                         
	END IF;
	
END//

/* Va retourner sous le format suivant: F�lix | Roy | 10 fev 2016 | 10:00 | 12:00 */