USE presence;

DELIMITER //
CREATE PROCEDURE spAjouterPresenceRequise(NomUtilisateur VARCHAR(40), MotDePasse VARCHAR(100), UsagerIDAAjouter INT, Journee VARCHAR(10), PeriodeNo INT)
BEGIN
  DECLARE IDPresencesRequises INT;
  DECLARE IDPeriode INT;
  
  IF (fnRetournerDroit(NomUtilisateur, MotDePasse) = 0) THEN
	SELECT PeriodesID FROM Periodes WHERE PeriodesNo=PeriodeNo INTO IDPeriode;
    INSERT INTO PresencesRequises (PresencesRequisesUsagersID, PresencesRequisesJournee) VALUES (UsagerIDAAjouter, Journee);

	SELECT MAX(PresencesRequisesID) INTO IDPresencesRequises FROM PresencesRequises;
	
    INSERT INTO PresencesRequisesPeriodes (PresencesRequisesPeriodesPresencesRequisesID, PresencesRequisesPeriodesPeriodesID) VALUES (IDPresencesRequises, IDPeriode);
  END IF;
END//
