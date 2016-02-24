USE presence;

DELIMITER //
CREATE PROCEDURE spObtenirDateEtHeure()
BEGIN
  SELECT NOW();
END
//