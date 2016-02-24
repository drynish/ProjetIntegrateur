USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherEleves
	(NomUtilisateurUsager VARCHAR(40), 
	MotPasse VARCHAR(40))
	
BEGIN
	IF (fnRetournerDroit(NomUtilisateurUsager, MotPasse) = 0) THEN	
		SELECT UsagersID, UsagersNomUtilisateur, UsagersPrenom, UsagersNom 
        FROM Usagers
        WHERE UsagersDroit = 1;
	END IF;
END//