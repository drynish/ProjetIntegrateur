USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherUsagers
	(NomUtilisateurUsager VARCHAR(40), 
	MotPasse VARCHAR(40))
	
BEGIN
	IF (fnRetournerDroit(NomUtilisateurUsager, MotPasse) = 0) THEN	
		SELECT UsagersID, UsagersNomUtilisateur, UsagersPrenom, UsagersNom, UsagersDroit FROM Usagers;	
	END IF;
END//