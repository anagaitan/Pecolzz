CREATE TABLE [dbo].[Produs] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [Denumire_produs] NVARCHAR (MAX) NOT NULL,
    [Descriere]       NVARCHAR (MAX) NOT NULL,
    [Pret]            DECIMAL (6, 2) NOT NULL,
    [DataAdaugarii]   DATETIME2 (7)  DEFAULT ('0001-01-01T00:00:00.0000000') NOT NULL,
    CONSTRAINT [PK_Produs] PRIMARY KEY CLUSTERED ([ID] ASC)
);

