USE presence;

DELIMITER //
CREATE FUNCTION fnRetournerDroit (NomUtilisateur VARCHAR(40), MotPasse VARCHAR(100))
RETURNS INT
BEGIN
  DECLARE Droit INT;
  DECLARE NbLigne INT;
  
  SET NbLigne = (SELECT Count(*) FROM Usagers WHERE (UsagersNomUtilisateur=NomUtilisateur AND UsagersMotDePasse = md5(MotPasse)));
  
  IF (NbLigne <= 0) THEN
	SET Droit = -1;
  ELSE
    SET Droit = (SELECT UsagersDroit FROM Usagers WHERE (UsagersNomUtilisateur=NomUtilisateur AND UsagersMotDePasse = md5(MotPasse)));
  END IF;
  
  RETURN Droit;
END;//
