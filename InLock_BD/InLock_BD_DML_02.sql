--DML

USE InLock_Games_Manha

INSERT INTO TipoUsuario (Titulo) 
VALUES ('Administrador'), ('Cliente');

INSERT INTO Usuario (Email, Senha, idTipoUsuario)
VALUES ('admin@admin.com','admin',1),
	   ('cliente@cliente.com', 'cliente',2);

INSERT INTO Estudios (NomeEstudio)
VALUES  ('Blizzard'), ('Rockstar Studios '), ('Square Enix');

INSERT INTO Jogos (NomeJogo, Descricao, DataLancamento, Valor, idEstudio)
VALUES ('Diablo 3', '� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�', '2012-05-15', 99.00, 1),
       ('Red Dead Redemption II', 'Jogo eletr�nico de a��o-aventura western', '2018-10-26', 120.00,2);







