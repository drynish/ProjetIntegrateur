DELIMITER//
CREATE PROCEDURE spAfficherPresences (Nom VARCHAR(40), MDP VARCHAR(100))				
BEGIN

  IF (fnRetournerDroit(Nom, MDP) = 0) THEN
   	SELECT UsagersPrenom AS "Prenom",
		UsagersNom AS "Nom", 
		PresencesPassesDateCheckIn AS "DateEntree", 
		PresencesPassesAddrIPCheckin AS "IPEntree",
		PresencesPassesMacCheckIn AS "MACEntree",
		PresencesPassesDateCheckOut AS "DateSortie",
		PresencesPassesAddrIPCheckOut AS "IPSortie",
		PresencesPassesMacCheckOut AS "MACSortie",
		
	
	FROM Usagers 
		INNER JOIN PresencesRequises 
			ON UsagersID = PresencesRequisesUsagersID
		
		INNER JOIN PresencePasses
			ON PresencesRequisesID = PresencesPassesPresencesRequisesID
		
  END IF;

END//