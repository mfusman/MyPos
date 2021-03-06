USE [master]
GO
/****** Object:  Database [MyPOS]    Script Date: 8/19/2020 11:13:35 PM ******/
CREATE DATABASE [MyPOS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyPOS', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyPOS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyPOS_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyPOS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MyPOS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyPOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyPOS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyPOS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyPOS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyPOS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyPOS] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyPOS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyPOS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MyPOS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyPOS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyPOS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyPOS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyPOS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyPOS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyPOS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyPOS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyPOS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyPOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyPOS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyPOS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyPOS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyPOS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyPOS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyPOS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyPOS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyPOS] SET  MULTI_USER 
GO
ALTER DATABASE [MyPOS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyPOS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyPOS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyPOS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MyPOS]
GO
/****** Object:  StoredProcedure [dbo].[ups_Products_LoadAllProductsByProductName]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ups_Products_LoadAllProductsByProductName]
(
	@Name NVARCHAR(100)
)
AS
	BEGIN

	SELECT
		
		P.ProductID
		,P.name as 'Name'
		,l1.[Description] AS 'Category'
		,l2.[Description] AS 'Supplier'
		,P.PurchasePrice  AS 'Purchase Price'
		,p.SalesPrice     AS 'Sales Price'
		,l3.[Description] AS 'Size'
		
		FROM	[dbo].[Products] P
		LEFT JOIN [dbo].[ListTypesData] l1 ON P.CategoryID=l1.ListDataID
		LEFT JOIN [dbo].[ListTypesData] l2 ON P.SupplierID=l2.ListDataID
		LEFT JOIN [dbo].[ProductSizes]  ps ON P.ProductID=ps.ProductID
		LEFT JOIN [dbo].[ListTypesData] l3 ON ps.SizeID=l3.ListDataID

		where P.name LIKE + '%' +@Name + '%'
		END
GO
/****** Object:  StoredProcedure [dbo].[ups_Products_LoadAllProductsForDataGridView]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ups_Products_LoadAllProductsForDataGridView]
AS
	BEGIN

	SELECT
		
		P.ProductID
		,P.name as 'Name'
		,l1.[Description] AS 'Category'
		,l2.[Description] AS 'Supplier'
		,P.PurchasePrice  AS 'Purchase Price'
		,p.SalesPrice     AS 'Sales Price'
		,l3.[Description] AS 'Size'
		
		FROM	[dbo].[Products] P
		INNER JOIN [dbo].[ListTypesData] l1 ON P.CategoryID=l1.ListDataID
		INNER JOIN [dbo].[ListTypesData] l2 ON P.SupplierID=l2.ListDataID
		INNER JOIN [dbo].[ProductSizes]  ps ON P.ProductID=ps.ProductID
		INNER JOIN [dbo].[ListTypesData] l3 ON ps.SizeID=l3.ListDataID

		END
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerGetCustomerDataByCustomerID]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CustomerGetCustomerDataByCustomerID]
(
	@CustomerID INT
)
AS
BEGIN
SELECT [CustomerID]
      ,[Name]
      ,[Mobile]
      ,[Address]
  FROM [dbo].[CustomerInfo]
WHERE [CustomerID]=@CustomerID
END


GO
/****** Object:  StoredProcedure [dbo].[usp_ListTypesData_LoadDataIntoComboBox]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE	[dbo].[usp_ListTypesData_LoadDataIntoComboBox]
(
	@ListTypeID INT
)
AS
	BEGIN
		SELECT [ListDataID]  AS 'ID'
			  ,[Description] AS 'Description'
		FROM   [dbo].[ListTypesData]
		WHERE  [ListTypeID] = @ListTypeID
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_Login_verifyLoginDetails]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Login_verifyLoginDetails]
(
	@UserName NVARCHAR(50)
   ,@Password NVARCHAR(50)
)
AS
	BEGIN
		SELECT '#' FROM [dbo].[LoginUsers]
		WHERE [UserName]= @UserName
		AND   [Password]= @Password

	END
GO
/****** Object:  StoredProcedure [dbo].[usp_Products_DeleteProductAndSizes]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Products_DeleteProductAndSizes]
(
	@ProductID INT
	,@SizeID INT
)
AS 
	
	BEGIN
	
	DELETE FROM [dbo].[ProductSizes]
	WHERE (([ProductID] = @ProductID) and ([SizeID]=@SizeID))

	
	END
GO
/****** Object:  StoredProcedure [dbo].[usp_Products_InsertCustomerInfo]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE	[dbo].[usp_Products_InsertCustomerInfo]	
(
	 @Name NVARCHAR(100)
	,@Mobile NVARCHAR(15)
	,@Address NVARCHAR(200)
	
)
AS
	BEGIN
	INSERT INTO [dbo].[CustomerInfo]
				   (
					[Name]
				   ,[Mobile]
				   ,[Address]
					)
	VALUES(
				  @Name
				 ,@Mobile
				 ,@Address
		  )
		 
	END

	
GO
/****** Object:  StoredProcedure [dbo].[usp_Products_InsertNewProductt]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE	[dbo].[usp_Products_InsertNewProductt]	
(
	 @Name NVARCHAR(100)
	,@CategoryID INT
	,@SupplierID INT
	,@PurchasePrice DECIMAL(18,2)
	,@SalesPrice DECIMAL(18,2)
)
AS
	BEGIN
	INSERT INTO [dbo].[Products]
				   ([name]
				   ,[CategoryID]
				   ,[SupplierID]
				   ,[PurchasePrice]
				   ,[SalesPrice])
	VALUES(
				  @Name
				 ,@CategoryID
				 ,@SupplierID
				 ,@PurchasePrice
				 ,@SalesPrice
		  )
		  SELECT SCOPE_IDENTITY()
	END


GO
/****** Object:  StoredProcedure [dbo].[usp_Products_InsertProductSizes]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE	[dbo].[usp_Products_InsertProductSizes]
(
	@ProductID INT
	,@SizeID INT
)
AS
	BEGIN

	INSERT INTO [dbo].[ProductSizes]
	(
		[ProductID]
	   ,[SizeID]
	)
	VALUES
	(
		@ProductID
	   ,@SizeID
	)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Sizes_LoadAllSizes]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Sizes_LoadAllSizes]
(
	@ListTypeID INT
)
AS
	BEGIN
		
		SELECT [ListDataID] AS 'ID'
			  ,[Description] AS 'Title'
			  ,[Visible] AS 'Select'
		FROM [dbo].[ListTypesData]
		WHERE [ListTypeID] = @ListTypeID

	END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateCustomerDataByCustomerID]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateCustomerDataByCustomerID]
(
	 @CustomerID INT
	,@Name NVARCHAR(100)
	,@Mobile NVARCHAR(15)
    ,@Address NVARCHAR(200)
)
AS
	BEGIN
	UPDATE [dbo].[CustomerInfo]
	SET[Name] = @Name
      ,[Mobile] = @Mobile
      ,[Address] = @Address
	 WHERE [CustomerID]=@CustomerID

	END


GO
/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerInfo](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Mobile] [nvarchar](15) NULL,
	[Address] [nvarchar](200) NULL,
 CONSTRAINT [PK_CustomerInfo] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ListTypes]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTypes](
	[ListTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_ListTypes] PRIMARY KEY CLUSTERED 
(
	[ListTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ListTypesData]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListTypesData](
	[ListDataID] [int] IDENTITY(1,1) NOT NULL,
	[ListTypeID] [int] NULL,
	[Description] [nvarchar](100) NULL,
	[Visible] [bit] NULL,
 CONSTRAINT [PK_ListTypesData] PRIMARY KEY CLUSTERED 
(
	[ListDataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoginUsers]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginUsers](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoginUsers] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[CategoryID] [int] NULL,
	[SupplierID] [int] NULL,
	[PurchasePrice] [decimal](18, 2) NULL,
	[SalesPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductSizes]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSizes](
	[ProductID] [int] NOT NULL,
	[SizeID] [int] NOT NULL,
 CONSTRAINT [PK_ProductSizes] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[SizeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesOrderDetails]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderDetails](
	[DetailID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [int] NULL,
	[StockID] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[Quantity] [decimal](18, 2) NULL,
	[TotalPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_SalesOrderDetails] PRIMARY KEY CLUSTERED 
(
	[DetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalesOrders]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrders](
	[InvoiceNumber] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceDate] [datetime] NULL,
	[CustomerID] [int] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Net] [decimal](18, 2) NULL,
	[Cash] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
 CONSTRAINT [PK_SalesOrders] PRIMARY KEY CLUSTERED 
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stock]    Script Date: 8/19/2020 11:13:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[SizeID] [int] NULL,
	[Quantity] [decimal](18, 2) NULL,
	[PurchasePrice] [decimal](18, 2) NULL,
	[SalesPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [MyPOS] SET  READ_WRITE 
GO
