USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesRequisesDeUnEleveSelonID(ID INT)
BEGIN
  SELECT presencesrequises.PresencesRequisesJournee AS Journee, periodes.PeriodesNo AS PeriodeNo
  FROM (((usagers INNER JOIN presencesrequises 
  ON usagers.UsagersID = presencesrequises.PresencesRequisesUsagersID)  
		
  INNER JOIN presencesrequisesperiodes
  ON presencesrequises.PresencesRequisesID = presencesrequisesperiodes.PresencesRequisesPeriodesPresencesRequisesID)
		
  INNER JOIN periodes
  ON presencesrequisesperiodes.PresencesRequisesPeriodesPeriodesID = periodes.PeriodesID)

  WHERE UsagersID=ID;

END//