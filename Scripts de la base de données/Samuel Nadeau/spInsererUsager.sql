USE presence;

DELIMITER //
CREATE PROCEDURE spInsererUsager (IN Prenom VARCHAR(40), IN Nom VARCHAR(40), IN NomUtilisateur VARCHAR(40), IN MotPasse VARCHAR(100), OUT Retour VARCHAR(2))
BEGIN
	DECLARE NbLigne INT;
	
	SET NbLigne = (SELECT Count(*) FROM Usagers WHERE UsagersNomUtilisateur = NomUtilisateur);
	IF (NbLigne <= 0) THEN
		INSERT INTO Usagers (UsagersPrenom, UsagersNom, UsagersNomUtilisateur, UsagersMotDePasse, UsagersDroit)
		VALUES (Prenom, Nom, NomUtilisateur, md5(MotPasse), -1);
			
		SET Retour = "1";
	ELSE
		SET Retour = "-1";
	END IF;
END//