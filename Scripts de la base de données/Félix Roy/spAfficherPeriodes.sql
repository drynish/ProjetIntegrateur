DELIMITER //
CREATE PROCEDURE spAfficherPeriodes(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100))
BEGIN

	/*Si l'utilisateur est un admin, il peut voir les périodes.*/
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		SELECT * FROM Periodes;
	END IF;
	
END//