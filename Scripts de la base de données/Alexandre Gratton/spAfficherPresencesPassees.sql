USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesPasses
	(NomUtilisateurUsager VARCHAR(40), 
	MotPasse VARCHAR(40),
	EleveID INT)
	
BEGIN
	IF (fnRetournerDroit(NomUtilisateurUsager, MotPasse) = 0) THEN	
		SELECT  PresencesPassesDateCheckIn, PresencesPassesAddrIPCheckIn, PresencesPassesMacCheckIn, 
				PresencesPassesDateCheckOut, PresencesPassesAddrIPCheckOut, PresencesPassesMacCheckOut
        FROM PresencesPasses 
			INNER JOIN Usagers ON PresencesPassesUsagersID = UsagersID
        WHERE UsagersID = EleveID;
	END IF;
END//