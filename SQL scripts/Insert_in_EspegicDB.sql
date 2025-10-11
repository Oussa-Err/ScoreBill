USE ESPEGIC
GO

-- Create new admin
INSERT INTO Admin(Password, Login) Values('admin', 'admin')

-- Create new classe 
INSERT INTO Classe (Titre) VALUES ('TSDI-1')

-- Insert how many subject for the classe
INSERT INTO Examen (NbrExamen) VALUES (3)

-- Insert data into Matieres et Note table
INSERT INTO Matiere (Matiere) VALUES ('Algorithm'), ('C#'), ('SQL');

-- Insert default zeros on note des examens

-- Insert note des examens
INSERT INTO Note (Note)   VALUES(12.34), (14.42), (10.52),
								(13.34), (16.42), (20),
								(17.34), (15.42), (11.52)

-- Associate exams to matiere
INSERT INTO ExamenMatiere (ExamenID, MatiereID) VALUES(1, 1), (1, 2), (1, 3)

INSERT INTO MatiereNote (MatiereID, NoteID)   VALUES(1, 1), (1, 2), (1, 3), 
													(2, 4), (2, 5), (2, 6),
													(3, 7), (3, 8), (3, 9)

-- Insert data into Paiements table
INSERT INTO Paiement (FraisInitial, FraisMensuel, NbrMois) VALUES (300, 1000, 10)

-- Associate config to Classe
INSERT INTO ClasseConfig (ClasseID, ExamenID, PaiementID) VALUES (1, 1, 1)

-- Create new Eleve
INSERT INTO Eleve (Nom, Prenom, Genre, Age, Telephone, ClasseID) VALUES ('Karim', 'ZEATOUT', 'homme', 23, '06516624234', 1)
-- Associate config to Eleve
INSERT INTO EleveConfig (EleveID, ExamenID, PaiementID) VALUES (1, 1, 1)