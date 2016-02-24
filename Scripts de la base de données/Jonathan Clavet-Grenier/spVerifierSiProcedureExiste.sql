USE presence;

DELIMITER //
CREATE PROCEDURE spVerifierSiProcedureExiste(NomProcedure VARCHAR(50))
BEGIN
	SELECT * FROM `information_schema`.`ROUTINES` where specific_name = NomProcedure and routine_schema = 'presence';
END//