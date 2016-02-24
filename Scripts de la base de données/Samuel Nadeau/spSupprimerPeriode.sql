USE presence;

DELIMITER //
CREATE PROCEDURE spSupprimerPeriode(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100))
BEGIN
	DECLARE PID INT DEFAULT 0;
	
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		SELECT PeriodesID FROM Periodes ORDER BY PeriodesID DESC LIMIT 1 INTO PID;
		
		DELETE FROM Periodes WHERE PeriodesID = PID;
	END IF;
END//