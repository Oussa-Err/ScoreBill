-- CREATE INDEX IX_ElevesConfig
-- ON ElevesConfig(ElevesID);



-- retoune tous les eleves de tous les classes
CREATE PROCEDURE dbo.spEleves_getAll AS
BEGIN

	SET NOCOUNT ON;

	SELECT ID, Nom, Prenom	from Eleves
END
GO

-- retoune un eleve par son nom, recherché sur tous les classes
CREATE PROCEDURE dbo.spEleves_getByPrenom @Prenom VARCHAR(30)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT ID, Nom, Prenom, DateInscription	from Eleves WHERE Prenom = @Prenom
END
GO

exec dbo.spEleves_getAll

exec dbo.spEleves_getByPrenom 'OUSS'



