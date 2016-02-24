USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherHeuresTous
	(NomUtilisateurUsager VARCHAR(40), 
	MotPasse VARCHAR(40))
	
BEGIN
	IF (fnRetournerDroit(NomUtilisateurUsager, MotPasse) = 0) THEN	
		SELECT  SEC_TO_TIME(SUM(TIME_TO_SEC(PresencesPassesDateCheckOut) - TIME_TO_SEC(PresencesPassesDateCheckIn))) AS timediff
        FROM presencespasses;
	END IF;
END//