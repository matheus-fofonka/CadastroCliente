/****** Tabela usada  ******/
CREATE TABLE CLIENTES
(
	ID INT IDENTITY(1, 1) NOT NULL,
	NOME VARCHAR(60) NOT NULL,
	DATA_NASCIMENTO DATETIME NOT NULL,
	EMAIL VARCHAR(150) NULL,
	CONSTRAINT PK_CLIENTES PRIMARY KEY (ID) 
)
GO

SELECT TOP (1000) [ID]
      ,[NOME]
      ,[DATA_NASCIMENTO]
      ,[EMAIL]
  FROM [master].[dbo].[CLIENTES]

INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Adriano Cuaresma','11/09/12','dictum@pretium.net')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Afonso Casquero','14/02/14','cetur.ridiculus@Curae.net')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Augusta Pirassununga','18/05/12','sollicitudin.orci@atpede.net')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Dino Lobo','11/10/15','adipiscing@Phasellusfermentum.net')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Isaque Carreiro','16/11/03','ut.ipsum.ac@Aliquam.net')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Brenda Acevedo','12/05/17','toque.penatibus@Integervulputate.com')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Lorena Miera','19/03/19','Suspense.tristique.neque@turpis.ca')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Miriam Bugallo','15/12/24','imper.non.vestibulum@Nunc.net')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Teresa Cordeiro','16/11/23','urna.suspit@felisullamcorper.co.uk')
INSERT INTO clientes([nome],[data_nascimento],[email]) VALUES('Vera Barboza','18/02/19','mollis.in@id.com')
