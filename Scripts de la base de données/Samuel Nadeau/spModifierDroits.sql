USE presence;

DELIMITER //
CREATE PROCEDURE spModifierDroits(NomUtilisateur VARCHAR(40), MotPasse VARCHAR(40), ID INT, Droits INT)
BEGIN
  IF (fnRetournerDroit(NomUtilisateur, MotPasse) = 0) THEN
	IF (Droits = -1 || Droits = 0 || Droits = 1) THEN
		UPDATE Usagers SET UsagersDroit = Droits WHERE UsagersID = ID;
	END IF;
  END IF;
END//