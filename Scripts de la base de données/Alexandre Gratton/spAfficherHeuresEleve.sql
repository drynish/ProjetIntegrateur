USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherHeuresEleve
	(NomUtilisateurUsager VARCHAR(40), 
	MotPasse VARCHAR(40),
	EleveID INT)
	
BEGIN
	IF (fnRetournerDroit(NomUtilisateurUsager, MotPasse) = 0) THEN	
		SELECT  SEC_TO_TIME(SUM(TIME_TO_SEC(PresencesPassesDateCheckOut) - TIME_TO_SEC(PresencesPassesDateCheckIn))) AS timediff
        FROM PresencesPasses 
			INNER JOIN Usagers ON PresencesPassesUsagersID = UsagersID
        WHERE UsagersID = EleveID;
	END IF;
END//