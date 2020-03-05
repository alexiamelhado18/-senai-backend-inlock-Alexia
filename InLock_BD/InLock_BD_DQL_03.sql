--DQL

USE InLock_Games_Manha

--Listar todos os usu�rios
SELECT * FROM Usuario;

-- Listar todos os est�dios
SELECT * FROM Estudios;

-- Listar todos os jogos
SELECT * FROM Jogos;

-- Listar todos os jogos e seus respectivos est�dios
SELECT NomeJogo,  Estudios.NomeEstudio FROM Jogos
INNER JOIN Estudios ON Estudios.idEstudio = Jogos.idEstudio;

-- Buscar e trazer na lista todos os est�dios (mesmo que eles n�o contenham nenhum jogo de refer�ncia)
 SELECT * FROM Estudios
 WHERE NomeEstudio LIKE '%a%';

-- Buscar um usu�rio por email e senha
SELECT idUsuario, Email, Usuario.idTipoUsuario, TipoUsuario.Titulo FROM Usuario
INNER JOIN TipoUsuario ON Usuario.idTipoUsuario = TipoUsuario.idTipoUsuario
WHERE Usuario.Email = 'admin@admin.com' AND Usuario.Senha = 'admin';

-- Buscar um jogo por IdJogo
SELECT NomeJogo, Descricao, DataLancamento, Valor, Estudios.NomeEstudio as Estudio FROM Jogos
INNER JOIN Estudios ON Estudios.idEstudio = Jogos.idEstudio
Where idJogo = 1;

-- Buscar um est�dio por IdEstudio
SELECT NomeEstudio FROM Estudios
WHERE idEstudio = 1;
