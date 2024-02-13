CREATE TABLE [Carmodels] (
    [ModelID] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Price] int,
	[AutomarketID] int FOREIGN KEY REFERENCES [dbo].Automarket([AutomarketID])
);