/*1 février 2016 par Félix Roy (felix.roy.26@gmail.com)
	-Création du script.
*/

/*Cette procédure effectue une signature de présence. 
Gère la vérification de présence et de l'utilisateur requise pour faire une signature.*/

USE presence;

DELIMITER //
CREATE PROCEDURE spSignerPresence(IN nomUtilisateur VARCHAR(40), IN motPasse VARCHAR(100), IN ipOrdi VARCHAR(20), IN macOrdi VARCHAR(60), OUT MsgRetour VARCHAR(10))
BEGIN
	DECLARE idUsager INT DEFAULT -1;
	DECLARE idPresenceRequise INT DEFAULT -1;
	DECLARE idPresencePasse INT DEFAULT -1;
	
	SET idUsager = -1;
	SET idPresenceRequise = -1;
	SET idPresencePasse = -1;
	SET MsgRetour = "-1";
	
	SET SESSION lc_time_names = fr_CA;

	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 1) THEN
		/*Le ID de l'usagé est obtenu.*/
		SELECT UsagersID FROM usagers
		WHERE UsagersNomUtilisateur = nomUtilisateur AND UsagersMotDePasse = md5(motPasse)
		INTO idUsager;

		/*Vérification si une présence est requise.*/
		SELECT PresencesRequisesID FROM presencesrequises
		WHERE PresencesRequisesJournee = DAYNAME(CURDATE()) AND PresencesRequisesUsagersID = idUsager
		ORDER BY PresencesRequisesID ASC
		LIMIT 1
		INTO idPresenceRequise;
		
		/*Si la présence est requise, celle-ci est enregistrée*/
		IF (idPresenceRequise != -1) THEN
			/*Si une signature de présence correspondente est trouvée mais n'est pas fermée, celle-ci est mis à jour. (logout)*/
			
			SELECT PresencesPassesID FROM PresencesPasses
			WHERE DATE(PresencesPassesDateCheckIn) = CURDATE() AND PresencesPassesDateCheckOut IS NULL AND PresencesPassesUsagersID = idUsager
			INTO idPresencePasse;
			
			IF (idPresencePasse != -1) THEN
				UPDATE presencespasses
				SET PresencesPassesDateCheckOut = NOW(), PresencesPassesAddrIPCheckOut = ipOrdi, PresencesPassesMacCheckOut = macOrdi
				WHERE DATE(PresencesPassesDateCheckIn) = CURDATE() AND PresencesPassesDateCheckOut IS NULL AND PresencesPassesUsagersID = idUsager;
				
				SET MsgRetour = "1"; /* L'utilisateur a fait un check-out. */
			ELSE
				/*Sinon, une nouvelle signature est crée. (login)*/
				INSERT INTO presencespasses (PresencesPassesUsagersID, PresencesPassesDateCheckIn, PresencesPassesAddrIPCheckIn, PresencesPassesMacCheckIn)
				VALUES (idUsager, NOW(), ipOrdi, macOrdi);
				
				SET MsgRetour = "0"; /* L'utilisateur a fait un check-in. */
			END IF;
			
		END IF;

	END IF;

END//