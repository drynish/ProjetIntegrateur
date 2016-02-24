USE presence;

DELIMITER //
CREATE PROCEDURE spAfficherPresencesPassesDeUnEleve(NomUtilisateur VARCHAR(40), MotDePasse VARCHAR(100), IDEleve INT)
BEGIN
  SELECT PresencesPassesDateCheckIn,PresencesPassesAddrIPCheckIn,PresencesPassesMacCheckIn,PresencesPassesDateCheckOut,
         PresencesPassesAddrIPCheckOut,PresencesPassesMacCheckOut
  FROM PresencesPasses INNER JOIN Usagers ON UsagersID=PresencesPassesUsagersID
  WHERE UsagersNomUtilisateur=NomUtilisateur AND UsagersMotDePasse=md5(MotDePasse) AND UsagersID=IDEleve;
END//