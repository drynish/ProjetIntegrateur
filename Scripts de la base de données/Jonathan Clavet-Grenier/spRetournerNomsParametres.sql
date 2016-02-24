USE presence;

DELIMITER //
CREATE PROCEDURE spRetournerNomsParametres(NomProcedure VARCHAR(100))
BEGIN
	SELECT PARAMETER_NAME
	FROM information_schema.parameters
	WHERE specific_name = NomProcedure AND PARAMETER_NAME IS NOT NULL;
END//