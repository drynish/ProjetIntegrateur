USE presence;

CREATE TABLE Usagers
(
	UsagersID INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	UsagersPrenom VARCHAR(40) NOT NULL,
	UsagersNom VARCHAR(40) NOT NULL,
	UsagersNomUtilisateur VARCHAR(40) NOT NULL UNIQUE,
	UsagersMotDePasse VARCHAR(100) NOT NULL,
	UsagersDroit INT NOT NULL, /*0 pour un administrateur. 1 pour un utilisateur.*/
);

CREATE TABLE Periodes
(
	PeriodesID INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	PeriodesNo INT UNIQUE NOT NULL,
	PeriodesHeureDebut VARCHAR(5) UNIQUE NOT NULL,
	PeriodesHeureFin VARCHAR(5) UNIQUE NOT NULL
);

CREATE TABLE PresencesRequises
(
	PresencesRequisesID INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	PresencesRequisesUsagersID INT UNSIGNED NOT NULL,
	PresencesRequisesJournee VARCHAR(10) NOT NULL,
	
	CONSTRAINT FK_PresencesUsagersID FOREIGN KEY (PresencesRequisesUsagersID) REFERENCES Usagers(UsagersID) ON DELETE CASCADE ON UPDATE CASCADE
 );

CREATE TABLE PresencesRequisesPeriodes
(
	PresencesRequisesPeriodesID INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	PresencesRequisesPeriodesPresencesRequisesID INT UNSIGNED NOT NULL,
	PresencesRequisesPeriodesPeriodesID INT UNSIGNED NOT NULL,
	
	CONSTRAINT FK_PresencesRequisesID FOREIGN KEY (PresencesRequisesPeriodesPresencesRequisesID) REFERENCES PresencesRequises(PresencesRequisesID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_PeriodesID FOREIGN KEY (PresencesRequisesPeriodesPeriodesID) REFERENCES Periodes(PeriodesID) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE PresencesPasses
(
	PresencesPassesID INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	PresencesPassesUsagersID INT UNSIGNED NOT NULL,
	PresencesPassesDateCheckIn DATETIME NOT NULL,
	PresencesPassesAddrIPCheckIn VARCHAR(20) NOT NULL,
	PresencesPassesMacCheckIn VARCHAR(60) NOT NULL,
	PresencesPassesDateCheckOut DATETIME,
	PresencesPassesAddrIPCheckOut VARCHAR(20),
	PresencesPassesMacCheckOut VARCHAR(60),
	
	CONSTRAINT FK_PresencesPassesUsagersID FOREIGN KEY (PresencesPassesUsagersID) REFERENCES Usagers(UsagersID) ON DELETE CASCADE ON UPDATE CASCADE
);