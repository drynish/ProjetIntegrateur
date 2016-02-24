/*1 février 2016 par Félix Roy (felix.roy.26@gmail.com) et Samuel Nadeau.
	-Création du script.
*/

/* 16 février 2016 par Jonathan Clavet-Grenier (jonathanclavetg@gmail.com)
	- Ajout des numéros de période.
*/

/*Ajoute une entrée pour une nouvelle période avec les paramètres passés.*/
USE presence;

DELIMITER //
CREATE PROCEDURE spAjouterPeriode(nomUtilisateur VARCHAR(40), motPasse VARCHAR(100), heureDebut VARCHAR(5), heureFin VARCHAR(5))
BEGIN
	DECLARE PeriodeNo INT;
	
	/*Si l'utilisateur est un admin, il peut ajouter une période.*/
	IF (fnRetournerDroit(nomUtilisateur, motPasse) = 0) THEN
		SET PeriodeNo = -1;

		SELECT PeriodesNo FROM Periodes ORDER BY PeriodesID DESC LIMIT 1 INTO PeriodeNo;
		
		IF (PeriodeNo = -1) THEN
			SET PeriodeNo = 1;
		ELSE
			SET PeriodeNo = PeriodeNo + 1;
		END IF;
		
		INSERT INTO Periodes (PeriodesNo, PeriodesHeureDebut, PeriodesHeureFin)
		VALUES (PeriodeNo, heureDebut, heureFin);
	END IF;
	
END//