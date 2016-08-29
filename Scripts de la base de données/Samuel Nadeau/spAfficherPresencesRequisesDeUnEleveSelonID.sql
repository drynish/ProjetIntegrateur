USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesRequisesDeUnEleveSelonID(ID INT)
BEGIN
  SELECT PresencesRequises.PresencesRequisesJournee AS Journee, periodes.PeriodesNo AS PeriodeNo
  FROM (((usagers INNER JOIN presencesrequises 
  ON Usagers.UsagersID = PresencesRequises.PresencesRequisesUsagersID)  
		
  INNER JOIN PresencesRequisesPeriodes
  ON PresencesRequises.PresencesRequisesID = PresencesRequisesPeriodes.PresencesRequisesPeriodesPresencesRequisesID)
		
  INNER JOIN Periodes
  ON PresencesRequisesPeriodes.PresencesRequisesPeriodesPeriodesID = Periodes.PeriodesID)

  WHERE UsagersID=ID;

END//