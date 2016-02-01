/*1 février 2016 par Félix Roy (felix.roy.26@gmail.com)
	-Création du script.
*/

--Cette procédure effectue une signature de présence. 
--Gère la vérification de présence et de l'utilisateur requise pour faire une signature.
DELIMITER //
CREATE PROCEDURE SPSignerPresences(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100), ipOrdi VARCHAR(20), macOrdi VARCHAR(60))
BEGIN

	DECLARE idUsager INT DEFAULT NULL;
	DECLARE idPresenceRequise INT DEFAULT NULL;
	DECLARE idPresencePasse INT DEFAULT NULL;

	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		--Le ID de l'usagé est obtenu.
		SELECT TOP 1 UsagersID FROM usagers
		INTO idUsager
		WHERE UsagersNomUtilisateur = nomUtilisateur AND UsagersMotDePasse = motPasse;
		
		--Vérification si une présence est requise.
		SELECT TOP 1 PresencesRequisesID FROM PresencesRequises
		INTO idPresenceRequise
		WHERE PresenceRequiseJournee = CURDATE() AND PresenceRequisesUsagersID = idUsager;
		
		--Si la présence est requise, celle-ci est enregistrée.
		IF (idPresenceRequise IS NOT NULL)
			--Si une signature de présence correspondente est trouvée mais n'est pas fermée, celle-ci est mis à jour. (logout)
			
			SELECT TOP 1 PresencesPassesID FROM PresencesPasses
			INTO idPresencePasse
			WHERE PresencePassePresenceRequiseID = idPresenceRequise;
			
			IF (idPresencePasse IS NOT NULL) THEN
				UPDATE presencesPasses
				SET PresencesPassesDateCheckOut = NOW(),  PresencePassesAddrIPCheckOut = ipOrdi, PresencesPassesMacCheckOut = macOrdi
				WHERE PresencesPassesPresencesRequisesID = idPresencePasse;
			ELSE
				--Sinon, une nouvelle signature est crée. (login)
				INSERT INTO presencesPasses (PresencesPassesPresencesRequisesID, PresencesPassesDateCheckIn, PresencePassesAddrIPCheckIn, PresencesPassesMacCheckIn)
				VALUES (idPresenceRequise, NOW(), ipOrdi, macOrdi);
			END IF;
			
		END IF;

	END IF;

END//
