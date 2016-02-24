/*
  10 février 2016 par Félix Roy (felix.roy.26@gmail.com).
	-Création du script.
*/

/*Modifie une entrée pour une période existante avec les paramètres passés.*/

DELIMITER //
CREATE PROCEDURE spModifierPeriode(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100), heureDebut VARCHAR(5), heureFin VARCHAR(5), idPeriode INT)
BEGIN

	/*Si l'utilisateur est un admin, il peut modifier une période.*/
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		UPDATE Periodes 
		SET PeriodesHeureDebut = heureDebut, PeriodesHeureFin = heureFin
		WHERE PeriodesID = idPeriode;  
	END IF;
	
END//