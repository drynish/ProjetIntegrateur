DELIMITER //
CREATE PROCEDURE spChangerMDP (IN NomUtilisateurUsager VARCHAR(40), IN MotPasse VARCHAR(40), IN MotPasseNouveau VARCHAR(40), OUT Retour varchar(2))
BEGIN
	IF (fnRetournerDroit(NomUtilisateurUsager, MotPasse) > -1) THEN
		UPDATE Usagers 
		SET UsagersMotDePasse = md5(MotPasseNouveau)
		WHERE UsagersNomUtilisateur = NomUtilisateurUsager;
		
		SET Retour = "1";
	ELSE
		SET Retour = "-1";
	END IF;
END//