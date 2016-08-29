USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesRequisesDeUnEleve(nomUtilisateur VARCHAR(40))
BEGIN
  SET SESSION lc_time_names = fr_CA;
  
  SELECT Periodes.PeriodesHeureDebut AS Heure, PresencesRequises.PresencesRequisesJournee AS Journee, Periodes.PeriodesNo AS PeriodeNo
  FROM (((Usagers INNER JOIN PresencesRequises 
  ON Usagers.UsagersID = PresencesRequises.PresencesRequisesUsagersID)  
		
  INNER JOIN PresencesRequisesPeriodes
  ON PresencesRequises.PresencesRequisesID = PresencesRequisesPeriodes.PresencesRequisesPeriodesPresencesRequisesID)
		
  INNER JOIN Periodes
  ON PresencesRequisesPeriodes.PresencesRequisesPeriodesPeriodesID = Periodes.PeriodesID)

  WHERE UsagersNomUtilisateur=nomUtilisateur AND PresencesRequisesJournee=DAYNAME(CURDATE());

END//