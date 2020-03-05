--DQL

USE InLock_Games_Manha

--Listar todos os usuários
SELECT * FROM Usuario;

-- Listar todos os estúdios
SELECT * FROM Estudios;

-- Listar todos os jogos
SELECT * FROM Jogos;

-- Listar todos os jogos e seus respectivos estúdios
SELECT NomeJogo,  Estudios.NomeEstudio FROM Jogos
INNER JOIN Estudios ON Estudios.idEstudio = Jogos.idEstudio;

-- Buscar e trazer na lista todos os estúdios (mesmo que eles não contenham nenhum jogo de referência)
 SELECT * FROM Estudios
 WHERE NomeEstudio LIKE '%a%';

-- Buscar um usuário por email e senha
SELECT idUsuario, Email, Usuario.idTipoUsuario, TipoUsuario.Titulo FROM Usuario
INNER JOIN TipoUsuario ON Usuario.idTipoUsuario = TipoUsuario.idTipoUsuario
WHERE Usuario.Email = 'admin@admin.com' AND Usuario.Senha = 'admin';

-- Buscar um jogo por IdJogo
SELECT NomeJogo, Descricao, DataLancamento, Valor, Estudios.NomeEstudio as Estudio FROM Jogos
INNER JOIN Estudios ON Estudios.idEstudio = Jogos.idEstudio
Where idJogo = 1;

-- Buscar um estúdio por IdEstudio
SELECT NomeEstudio FROM Estudios
WHERE idEstudio = 1;
