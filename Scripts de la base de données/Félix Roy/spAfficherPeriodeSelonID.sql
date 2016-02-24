DELIMITER //
CREATE PROCEDURE spAfficherPeriodeSelonID(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100), IDPeriode INT)
BEGIN

	/*Si l'utilisateur est un admin, il peut voir les périodes.*/
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		SELECT * FROM Periodes WHERE PeriodesID = IDPeriode;
	END IF;
	
END//