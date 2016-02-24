USE presence;

DELIMITER //
CREATE PROCEDURE spSupprimerEleve(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100), IDEleve INT)
BEGIN
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		DELETE FROM Usagers WHERE UsagersID = IDEleve;
	END IF;
END//