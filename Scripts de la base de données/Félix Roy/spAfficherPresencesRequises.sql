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
		SELECT Usagers.UsagersPrenom, Usagers.UsagersNom, PresencesRequises.PresencesRequisesJournee, Periodes.PeriodesHeureDebut, Periodes.PeriodesHeureFin  
		FROM (((Usagers INNER JOIN Presencesrequises 
		ON Usagers.UsagersID = PresencesRequises.PresencesRequisesUsagersID)  
		
		INNER JOIN presencesrequisesperiodes
		ON PresencesRequises.PresencesRequisesID = PresencesRequisesPeriodes.PresencesRequisesPeriodesPresencesRequisesID)
		
		INNER JOIN Periodes
		ON PresencesRequisesPeriodes.PresencesRequisesPeriodesPeriodesID = Periodes.PeriodesID);
                                                                         
	END IF;
	
END//

/* Va retourner sous le format suivant: F�lix | Roy | 10 fev 2016 | 10:00 | 12:00 */