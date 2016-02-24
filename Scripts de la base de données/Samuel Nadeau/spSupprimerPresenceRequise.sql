USE presence;

DELIMITER //
CREATE PROCEDURE spSupprimerPresenceRequise(NomUtilisateur VARCHAR(40), MotDePasse VARCHAR(100), UsagersID INT)
BEGIN
  
  IF (fnRetournerDroit(NomUtilisateur, MotDePasse) = 0) THEN
	DELETE FROM presencesrequises WHERE PresencesRequisesUsagersID = UsagersID;
  END IF;
END//
