/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      DATA MODEL
 *
 * Date Created : Friday, July 14, 2023 12:33:17
 * Target DBMS : Microsoft SQL Server 2017
 */

USE Product
go
/* 
 * TABLE: Product 
 */

CREATE TABLE Product(
    id             int               IDENTITY(1,1),
    ProductName    char(255)         NULL,
    Price          decimal(18, 0)    NULL,
    Qty            int               NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Product') IS NOT NULL
    PRINT '<<< CREATED TABLE Product >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Product >>>'
go

