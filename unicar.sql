CREATE SCHEMA `unicar` ;


CREATE TABLE `unicar`.`clientes` (
  `idCliente` int(11) NOT NULL COMMENT 'Identificação do cliente',
  `cnh` bigint(11) UNSIGNED ZEROFILL NOT NULL COMMENT 'CNH do cliente',
  `nome` varchar(80) NOT NULL COMMENT 'Nome do cliente',
  `endereco` varchar(80) DEFAULT NULL COMMENT 'Endereço do cliente',
  `cidade` varchar(50) DEFAULT NULL COMMENT 'Cidade do cliente',
  `estado` char(2) DEFAULT NULL COMMENT 'Estado do cliente',
  `cep` bigint(8) UNSIGNED ZEROFILL DEFAULT NULL COMMENT 'CEP do cliente'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `unicar`.`clientes` (`idCliente`, `cnh`, `nome`, `endereco`, `cidade`, `estado`, `cep`) VALUES
(1, 00000012345, 'Rafael Fiuza', 'Nome da Rua, 800', 'São Paulo', 'SP', 0450851);

CREATE TABLE `unicar`.`funcionarios` (
  `idFuncionario` int(11) NOT NULL COMMENT 'Identificação do funcionário',
  `registro` varchar(10) NOT NULL COMMENT 'Registro do funcionário',
  `nome` varchar(30) NOT NULL COMMENT 'Nome do funcionário',
  `sobrenome` varchar(50) NOT NULL COMMENT 'Sobrenome do funcionário',
  `cpf` bigint(11) UNSIGNED ZEROFILL NOT NULL COMMENT 'CPF do funcionário',
  `cargo` varchar(30) DEFAULT NULL COMMENT 'Cargo do funcionário'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `unicar`.`funcionarios` (`idFuncionario`, `registro`, `nome`, `sobrenome`, `cpf`, `cargo`) VALUES
(1, 'UNI-0035', 'Rafael', 'Fiuza', 37036852833, 'FAXINEIRO(A)');

CREATE TABLE `unicar`.`veiculos` (
  `idVeiculo` int(11) NOT NULL,
  `fabricante` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `ano` int(4) NOT NULL,
  `placa` varchar(10) NOT NULL,
  `disponibilidade` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `unicar`.`veiculos` (`idVeiculo`, `fabricante`, `modelo`, `ano`, `placa`, `disponibilidade`) VALUES
(1, 'Renaut', 'Sandero', 2014, 'XXX-1234', 'Disponível'),
(2, 'Volkswagen', 'Gol', 2020, 'XXX-5463', 'Indisponível');


ALTER TABLE `unicar`.`clientes`
  ADD PRIMARY KEY (`idCliente`),
  ADD UNIQUE KEY `cnh` (`cnh`);

ALTER TABLE `unicar`.`funcionarios`
  ADD PRIMARY KEY (`idFuncionario`) USING BTREE,
  ADD UNIQUE KEY `cpf` (`cpf`);

ALTER TABLE `unicar`.`veiculos`
  ADD PRIMARY KEY (`idVeiculo`);


ALTER TABLE `unicar`.`clientes`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Identificação do cliente', AUTO_INCREMENT=4;

ALTER TABLE `unicar`.`funcionarios`
  MODIFY `idFuncionario` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Identificação do funcionário', AUTO_INCREMENT=2;

ALTER TABLE `unicar`.`veiculos`
  MODIFY `idVeiculo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;
