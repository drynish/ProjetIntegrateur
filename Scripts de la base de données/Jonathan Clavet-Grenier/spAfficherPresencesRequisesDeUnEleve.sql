USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesRequisesDeUnEleve(nomUtilisateur VARCHAR(40))
BEGIN
  SET SESSION lc_time_names = fr_CA;
  
  SELECT periodes.PeriodesHeureDebut AS Heure, presencesrequises.PresencesRequisesJournee AS Journee, periodes.PeriodesNo AS PeriodeNo
  FROM (((usagers INNER JOIN presencesrequises 
  ON usagers.UsagersID = presencesrequises.PresencesRequisesUsagersID)  
		
  INNER JOIN presencesrequisesperiodes
  ON presencesrequises.PresencesRequisesID = presencesrequisesperiodes.PresencesRequisesPeriodesPresencesRequisesID)
		
  INNER JOIN periodes
  ON presencesrequisesperiodes.PresencesRequisesPeriodesPeriodesID = periodes.PeriodesID)

  WHERE UsagersNomUtilisateur=nomUtilisateur AND PresencesRequisesJournee=DAYNAME(CURDATE());

END//