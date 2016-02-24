/*
  10 f�vrier 2016 par F�lix Roy (felix.roy.26@gmail.com).
	-Cr�ation du script.
*/

/*Modifie une entr�e pour une p�riode existante avec les param�tres pass�s.*/

DELIMITER //
CREATE PROCEDURE spModifierPeriode(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100), heureDebut VARCHAR(5), heureFin VARCHAR(5), idPeriode INT)
BEGIN

	/*Si l'utilisateur est un admin, il peut modifier une p�riode.*/
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		UPDATE Periodes 
		SET PeriodesHeureDebut = heureDebut, PeriodesHeureFin = heureFin
		WHERE PeriodesID = idPeriode;  
	END IF;
	
END//