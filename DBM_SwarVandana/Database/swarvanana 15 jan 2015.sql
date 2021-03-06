USE [DBMSwarVandana]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[StudentRenewal]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[StudentRenewal]
GO
/****** Object:  Table [dbo].[StudentRemarks]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[StudentRemarks]
GO
/****** Object:  Table [dbo].[StudentEnrollment]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[StudentEnrollment]
GO
/****** Object:  Table [dbo].[StudentBatchMapping]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[StudentBatchMapping]
GO
/****** Object:  Table [dbo].[StudentAttendence]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[StudentAttendence]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Student]
GO
/****** Object:  Table [dbo].[States]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[States]
GO
/****** Object:  Table [dbo].[Sources]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Sources]
GO
/****** Object:  Table [dbo].[PaymentDetails]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[PaymentDetails]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Faculties]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Expenses]
GO
/****** Object:  Table [dbo].[ExpenseForMaster]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[ExpenseForMaster]
GO
/****** Object:  Table [dbo].[ExamDetails]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[ExamDetails]
GO
/****** Object:  Table [dbo].[Enquiries]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Enquiries]
GO
/****** Object:  Table [dbo].[Disciplines]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Disciplines]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Cities]
GO
/****** Object:  Table [dbo].[Centres]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Centres]
GO
/****** Object:  Table [dbo].[BudgetMaster]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[BudgetMaster]
GO
/****** Object:  Table [dbo].[Batches]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP TABLE [dbo].[Batches]
GO
/****** Object:  UserDefinedFunction [dbo].[Split]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP FUNCTION [dbo].[Split]
GO
/****** Object:  StoredProcedure [dbo].[USP_UsersGetByUserId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_UsersGetByUserId]
GO
/****** Object:  StoredProcedure [dbo].[USP_UsersGetAll]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_UsersGetAll]
GO
/****** Object:  StoredProcedure [dbo].[USP_Users_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_Users_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_Students_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_Students_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_StudentRenewal_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_StudentRenewal_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_StudentEntrollment_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_StudentEntrollment_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_StatesGetAll]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_StatesGetAll]
GO
/****** Object:  StoredProcedure [dbo].[USP_SourcesGetAll]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_SourcesGetAll]
GO
/****** Object:  StoredProcedure [dbo].[USP_Sources_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_Sources_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginCheck]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_LoginCheck]
GO
/****** Object:  StoredProcedure [dbo].[USP_FacultyGetByCenterId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_FacultyGetByCenterId]
GO
/****** Object:  StoredProcedure [dbo].[USP_Faculties_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_Faculties_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_Enquiries_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_Enquiries_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_Disciplines_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_Disciplines_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_DisciplineGetById]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_DisciplineGetById]
GO
/****** Object:  StoredProcedure [dbo].[USP_DisciplineGetAll]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_DisciplineGetAll]
GO
/****** Object:  StoredProcedure [dbo].[USP_ClassDetails_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_ClassDetails_IUD]
GO
/****** Object:  StoredProcedure [dbo].[USP_CitiesGetByStateId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_CitiesGetByStateId]
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangePassword]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_ChangePassword]
GO
/****** Object:  StoredProcedure [dbo].[USP_CentresGetAll]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_CentresGetAll]
GO
/****** Object:  StoredProcedure [dbo].[USP_Centres_IUD]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[USP_Centres_IUD]
GO
/****** Object:  StoredProcedure [dbo].[InsertStudentRemarks]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[InsertStudentRemarks]
GO
/****** Object:  StoredProcedure [dbo].[InsertStudentAttendence]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[InsertStudentAttendence]
GO
/****** Object:  StoredProcedure [dbo].[InsertPaymentDetails]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[InsertPaymentDetails]
GO
/****** Object:  StoredProcedure [dbo].[InsertExpenses]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[InsertExpenses]
GO
/****** Object:  StoredProcedure [dbo].[InsertExamDetails]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[InsertExamDetails]
GO
/****** Object:  StoredProcedure [dbo].[InsertClassTimming]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[InsertClassTimming]
GO
/****** Object:  StoredProcedure [dbo].[InsertBudgetMaster]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[InsertBudgetMaster]
GO
/****** Object:  StoredProcedure [dbo].[GetWeekDays]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetWeekDays]
GO
/****** Object:  StoredProcedure [dbo].[GetUsersForEnquiryBy]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetUsersForEnquiryBy]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByUniqueId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetStudentsByUniqueId]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByCentreId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetStudentsByCentreId]
GO
/****** Object:  StoredProcedure [dbo].[GetStudents]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetStudents]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentRemarksByRemarksID]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetStudentRemarksByRemarksID]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentRemarksByCentreId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetStudentRemarksByCentreId]
GO
/****** Object:  StoredProcedure [dbo].[GetPaymentDetailsReportData]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetPaymentDetailsReportData]
GO
/****** Object:  StoredProcedure [dbo].[GetFaculity]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetFaculity]
GO
/****** Object:  StoredProcedure [dbo].[GetExpensesForAll]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetExpensesForAll]
GO
/****** Object:  StoredProcedure [dbo].[GetExpenseById]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetExpenseById]
GO
/****** Object:  StoredProcedure [dbo].[GetExamDetailsByExamID]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetExamDetailsByExamID]
GO
/****** Object:  StoredProcedure [dbo].[GetExamDetailsByCentreID]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetExamDetailsByCentreID]
GO
/****** Object:  StoredProcedure [dbo].[GetEnquiryById]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetEnquiryById]
GO
/****** Object:  StoredProcedure [dbo].[GetEnquiryByEnquiryNumber]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetEnquiryByEnquiryNumber]
GO
/****** Object:  StoredProcedure [dbo].[GetEnquiry]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetEnquiry]
GO
/****** Object:  StoredProcedure [dbo].[GetEndClassDateTest]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetEndClassDateTest]
GO
/****** Object:  StoredProcedure [dbo].[GetEndClassDate]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetEndClassDate]
GO
/****** Object:  StoredProcedure [dbo].[GetDashboardData]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetDashboardData]
GO
/****** Object:  StoredProcedure [dbo].[GetClassDetails]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetClassDetails]
GO
/****** Object:  StoredProcedure [dbo].[GetClassByDisciplineId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetClassByDisciplineId]
GO
/****** Object:  StoredProcedure [dbo].[GetClassByClassId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetClassByClassId]
GO
/****** Object:  StoredProcedure [dbo].[GetCentreByCenterId]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetCentreByCenterId]
GO
/****** Object:  StoredProcedure [dbo].[GetBudgetForAll]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetBudgetForAll]
GO
/****** Object:  StoredProcedure [dbo].[GetAllExpenses]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[GetAllExpenses]
GO
/****** Object:  StoredProcedure [dbo].[CalculateProfitLoss]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP PROCEDURE [dbo].[CalculateProfitLoss]
GO
USE [master]
GO
/****** Object:  Database [DBMSwarVandana]    Script Date: 1/15/2015 5:13:46 PM ******/
DROP DATABASE [DBMSwarVandana]
GO
/****** Object:  Database [DBMSwarVandana]    Script Date: 1/15/2015 5:13:46 PM ******/
CREATE DATABASE [DBMSwarVandana] ON  PRIMARY 
( NAME = N'DBMSwarVandana', FILENAME = N'D:\MSQSQL\Data\DBMSwarVandana.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBMSwarVandana_log', FILENAME = N'D:\MSQSQL\Data\DBMSwarVandana_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBMSwarVandana] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBMSwarVandana].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBMSwarVandana] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DBMSwarVandana] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBMSwarVandana] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBMSwarVandana] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBMSwarVandana] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBMSwarVandana] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBMSwarVandana] SET RECOVERY FULL 
GO
ALTER DATABASE [DBMSwarVandana] SET  MULTI_USER 
GO
ALTER DATABASE [DBMSwarVandana] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBMSwarVandana] SET DB_CHAINING OFF 
GO
USE [DBMSwarVandana]
GO
/****** Object:  StoredProcedure [dbo].[CalculateProfitLoss]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CalculateProfitLoss](@CenterId INT,@FinancialYear varchar(30))
	AS
		BEGIN
		SET NOCOUNT ON;

		DECLARE @Revenue money=0.0,@Salary money=0.0,@Expenseses money=0.0,@startYear int=0,@EndYear int=0


		SET @startYear =CAST(SUBSTRING(@FinancialYear, 0, 5)  AS INT)
		SET @EndYear = CAST(SUBSTRING(@FinancialYear, 7, 5)  AS INT)

		SET @Revenue=(SELECT SUM(RegistratonAmount+AmountPaid) FROM [dbo].[StudentEnrollment] 	WHERE EnrollmentId IN(SELECT EnrollmentId FROM PaymentDetails WHERE  DATEPART(yyyy,DateOfPayment) between @startYear and @EndYear) AND StudentId IN(select StudentId from [dbo].[Student] where Centerid=@CenterId))

		SET @Salary = (SELECT SUM(Salary) from [dbo].[Faculties] WHERE CentreId=@CenterId AND IsActive=1 )
		SET @Expenseses =(SELECT SUM(ExpenseAmount) from [dbo].[Expenses] WHERE CentreId=@CenterId AND DATEPART(yyyy,DateOfExpense) between @startYear and @EndYear)

		SELECT @Revenue AS Revenue, @Salary as Salary, @Expenseses as Expenseses,(@Revenue -(@Salary+@Expenseses)) AS FinalAmount

		END
		
		
		--CalculateProfitLoss 1 ,'2004 - 2017'


		--SELECT ISNULL(sum(BudgetAmount),0) as FinancialYearBudget FROM [dbo].[BudgetMaster] WHERE centreId =1 and FinancialYear ='2010 - 2011'
GO
/****** Object:  StoredProcedure [dbo].[GetAllExpenses]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllExpenses]
(@CentreId int,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(max)='')
AS
BEGIN
SELECT * FROM (
Select  ROW_NUMBER() OVER (ORDER BY ModifiedOn desc) AS RowNum,* from [Expenses] where IsActive=1 and CentreID=@CentreId and
(
ExpenseAmount like '%'+@search+'%' OR
Description like '%'+@search+'%' OR
DateOfExpense like '%'+@search+'%' OR
ExpenseFor in (select ExpenseID from  [dbo].[ExpenseForMaster] where ExpenseFor like '%'+@Search+'%')
)) AS Esxence WHERE Esxence.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)

				
			SELECT @TotalPages = (SELECT COUNT(ExpenseID) FROM [dbo].[Expenses] where IsActive=1 and CentreID=@CentreId and
								 (
								 ExpenseAmount like '%'+@search+'%' OR
								 Description like '%'+@search+'%' OR
								 DateOfExpense like '%'+@search+'%' OR
								 ExpenseFor in (select ExpenseID from  [dbo].[ExpenseForMaster] where ExpenseFor like '%'+@Search+'%')
								 ))
END

GO
/****** Object:  StoredProcedure [dbo].[GetBudgetForAll]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetBudgetForAll](@CenterId Int,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(max)='')
AS
	set nocount on;
BEGIN
SELECT * FROM (
SELECT  ROW_NUMBER() OVER (ORDER BY ModifiedOn desc) AS RowNum,* From [dbo].[BudgetMaster] where IsActive=1 and  centreId = @CenterId and
(BudgetAmount like '%'+@search+'%' OR FinancialYear like '%'+@search+'%' OR [Month] like '%'+@search+'%' OR ExpenseFor in (SELECT ExpenseForId  FROM [DBMSwarVandana].[dbo].[ExpenseForMaster] where ExpenseFor like '%'+@search+'%')))
AS Budget WHERE Budget.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)

SELECT @TotalPages = (SELECT COUNT(BudgetID) FROM [dbo].[BudgetMaster] where IsActive=1 and  centreId = @CenterId and
(BudgetAmount like '%'+@search+'%' OR FinancialYear like '%'+@search+'%' OR [Month] like '%'+@search+'%' OR ExpenseFor in (SELECT ExpenseForId  FROM [DBMSwarVandana].[dbo].[ExpenseForMaster] where ExpenseFor like '%'+@search+'%')))
END


-- select * From [BudgetMaster]


GO
/****** Object:  StoredProcedure [dbo].[GetCentreByCenterId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetCentreByCenterId]
(@CentreId int)
AS
BEGIN
SELECT [CentreId]
      ,[CentreName]
      ,[Address]
      ,[StateId]
      ,[CityId]
      ,[CentreOpenDate]
	,[IsActive]
  FROM [DBMSwarVandana].[dbo].[Centres] where CentreId=@CentreId
END
GO
/****** Object:  StoredProcedure [dbo].[GetClassByClassId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetClassByClassId]
(@ClassId int)
AS
BEGIN
SELECT  CD.ClassId, CD.ClassName, F.NameOfFaculty, CD.StudentLimit, CD.StartDate, CD.EndDate, CD.IsActive,(SELECT COUNT(studentid) FROM studentenrollment WHERE ClassId=CD.ClassID) AS NoOfStudent
FROM   dbo.ClassDetails AS CD INNER JOIN dbo.Faculties AS F ON CD.FacultyId = F.FacultyId where CD.ClassId=@ClassId and CD.IsActive=1
END



GO
/****** Object:  StoredProcedure [dbo].[GetClassByDisciplineId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetClassByDisciplineId]
(@DisciplineId int,@CentreId BIGINT)
AS
BEGIN
SELECT ClassId,ClassName,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate
FROM ClassDetails  WHERE IsActive=1 and DisciplineId=@DisciplineId AND CentreId = @CentreId AND EndDate > GETDATE()
END
GO
/****** Object:  StoredProcedure [dbo].[GetClassDetails]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--declare @TotalPages int 
--exec GetClassDetails 3 ,2, 1 ,@TotalPages OUTPUT,''
--select @TotalPages

CREATE PROCEDURE [dbo].[GetClassDetails](@CenterId INT,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(max)='')
	AS
		BEGIN
		SELECT * FROM (
		SELECT ROW_NUMBER() OVER (ORDER BY ModifyDate desc) AS RowNum, ClassId,ClassName,DisciplineId,FacultyId,StudentLimit,StartDate,EndDate,CentreId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted  
		FROM [dbo].[ClassDetails] where IsDeleted=0 and isactive=1 and CentreId = @CenterId 
		 AND(ClassName LIKE '%'+ @Search+'%' OR DisciplineId IN (SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE'%' + @Search + '%'))) AS Classes		 
			WHERE Classes.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)
				
			SELECT @TotalPages = (SELECT COUNT(ClassId) FROM [dbo].[ClassDetails] WHERE  IsDeleted=0 and isactive=1 and CentreId = @CenterId 
			 AND(ClassName LIKE '%'+ @Search+'%' OR DisciplineId IN (SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE'%' + @Search + '%')))

		END
GO
/****** Object:  StoredProcedure [dbo].[GetDashboardData]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Abhishek Chaturvedi>
-- Create date: <31 Dec 2014>
-- Description:	<Select Data fro Displaying in Dashboard>
-- =============================================

--GetDashboardData 3

CREATE PROCEDURE [dbo].[GetDashboardData] @CentreId INT
AS
BEGIN
	set nocount on;
		--- fee to collect 
		select ST.Name,ST.UniqueKey,(select Discipline from [dbo].[Disciplines] where DisciplineId=SE.DisciplineId) as Discipline,(SE.CourseAmount-(SE.RegistratonAmount+SE.AmountPaid)) as Balance,(select convert(varchar,Duedate,106) from [dbo].[PaymentDetails] where paymentid=(select max(paymentid) from [dbo].[PaymentDetails] where enrollmentid=SE.enrollmentid)) as DueDate from [dbo].[StudentEnrollment] SE,Student ST Where (SE.CourseAmount-(SE.RegistratonAmount+SE.AmountPaid))>0 and SE.StudentId=ST.StudentId and ST.CenterId=@CentreId Order By Balance

		-- upcoming renewal
		select ST.Name,ST.UniqueKey,convert(varchar,SE.EndDate,106) EndDate from [dbo].[StudentEnrollment] SE,Student ST Where SE.StudentId=ST.StudentId and ST.CenterId=@CentreId and EndDate<getdate()+15

		--tELEPHONIC eNQUERY BY TODAY
		select count(EnquiryId) as TodayTeleEnq , convert(varchar(30),getdate(),106) as Today from [dbo].[Enquiries] where EnquiryTypeId=2 AND CONVERT(VARCHAR(30),DateOfEnquiry,106) =  CONVERT(VARCHAR(30),GETDATE(),106) and CentreId=@CentreId
		
		-- TELEPHONIC ENQUERY BY  MONTH 
		select count(EnquiryId) as TodayTeleEnqMonth,DateName( month , getdate()) as monthName from [dbo].[Enquiries] where EnquiryTypeId=2 AND DATEPART(month,DateOfEnquiry) = DATEPART(month,GETDATE()) and  CentreId=@CentreId

		--Physical eNQUERY BY TODAY
		select count(EnquiryId)  as TodayPEEnq ,convert(varchar(30),getdate(),106) as Today from [dbo].[Enquiries] where EnquiryTypeId=1 AND CONVERT(VARCHAR(30),DateOfEnquiry,106) =  CONVERT(VARCHAR(30),GETDATE(),106) and CentreId=@CentreId
		
		-- Physical ENQUERY BY  MONTH 
		select count(EnquiryId) as TodayPEEnqMonth,DateName( month , getdate()) as MonthName from [dbo].[Enquiries] where EnquiryTypeId=1 AND DATEPART(month,DateOfEnquiry) = DATEPART(month,GETDATE()) and  CentreId=@CentreId
		
		-- today Billing		
		select sum(AmountPaid) as BillingToday , convert(varchar(30),getdate(),106) as Today from [dbo].[PaymentDetails] where StudentId in( select StudentId from [dbo].[Student] where CenterId =@CentreId) and convert(varchar(30),AddDate,106) = convert(varchar(30),getdate(),106)

		-- Monthly Billing		
		select sum(AmountPaid) as MonthBilling,DateName( month , getdate()) as monthName from [dbo].[PaymentDetails] where StudentId in(select StudentId from [dbo].[Student] where CenterId =@CentreId) and datepart(month,AddDate) = datepart(month,getdate())

		-- Today enrollment
		select count(EnrollmentId),convert(varchar(30),getdate(),106) as Today from [dbo].[StudentEnrollment] where StudentId in( select StudentId from [dbo].[Student] where CenterId =@CentreId) and convert(varchar(30),CreatedDate,106) = convert(varchar(30),getdate(),106)

		-- Monthly enrollment 
		select count(EnrollmentId),DateName( month , getdate()) as monthName from [dbo].[StudentEnrollment]  where StudentId in(select StudentId from [dbo].[Student] where CenterId =@CentreId) and datepart(month,CreatedDate) = datepart(month,getdate())

END

GO
/****** Object:  StoredProcedure [dbo].[GetEndClassDate]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- [GetEndClassDate] '2015-01-06 02:48:00.403',10,'1,5,9,2,3',1

CREATE PROCEDURE [dbo].[GetEndClassDate](@StartDate DATETIME,@NoofDay INT,@BatchIds varchar(150),@CenterId BIGINT)
AS
	DECLARE @DayId INT,@Day INT,@Count INT=0
	DECLARE @WeekDays TABLE(WeekDayId INT)
	DECLARE @Flag BIT=1
	BEGIN
	SET NOCOUNT ON;	

	INSERT INTO @WeekDays select Day from  [dbo].[Batches] WHERE CenterId = @CenterId AND BatchId IN (SELECT items FROM [dbo].[Split](@BatchIds,','))
		
	IF((SELECT COUNT(WeekDayId) FROM @WeekDays)<=0)
		SET @Flag =0

	WHILE(@Flag=1)
		BEGIN
		    SET @DayId=(SELECT DATEPART(weekday, @StartDate))		
			IF(@DayId = 1)
				SET @DayId = 7
			ELSE IF(@DayId>1)
				SET @DayId = @DayId -1
			
			SET @Day = (SELECT DISTINCT WeekDayId FROM @WeekDays WHERE WeekDayId = @DayId )
			IF(@Day IS NOT NULL)
					BEGIN			
						SET @Count=@Count+1
					END
			IF(@Count<@NoofDay)
			BEGIN
			  SET @StartDate = DATEADD(day,1,@StartDate)
			END
			ELSE
			BEGIN 
			 SET @Flag=0
			 SELECT @StartDate as EndDate
			END
		END
	END

	--SELECT * FROM BATCHES
GO
/****** Object:  StoredProcedure [dbo].[GetEndClassDateTest]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEndClassDateTest](@ClassID	INT,@StartDate DATETIME,@NoofDay INT ,@OutPut datetime out)
AS
	DECLARE @DayId INT,@Day INT,@Count INT=0
	DECLARE @WeekDays TABLE(WeekDayId INT)
	DECLARE @Flag BIT=1
	BEGIN
	SET NOCOUNT ON;
	INSERT INTO @WeekDays select WeekDayId from [dbo].[ClassTimingPatterns] where classid = @ClassId
	WHILE(@Flag=1)
		BEGIN
		    SET @DayId=(SELECT DATEPART(weekday, @StartDate))			
			SET @Day = (SELECT WeekDayId FROM @WeekDays WHERE WeekDayId = @DayId )
			IF(@Day IS NOT NULL)
					BEGIN			
						SET @Count=@Count+1
					END
			IF(@Count<=@NoofDay)
			BEGIN
			  SET @StartDate = DATEADD(day,1,@StartDate)
			END
			ELSE
			BEGIN 
			 SET @Flag=0
			 SET @OutPut = @StartDate
			 --SELECT @OutPut
			END
		END
	END
GO
/****** Object:  StoredProcedure [dbo].[GetEnquiry]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--declare @TotalPages int 
--exec GetEnquiry 1 ,2, 5 ,1 ,@TotalPages output,'2',1
--select @TotalPages

CREATE PROC [dbo].[GetEnquiry](@centerId INT , @enqueryType int,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(max)='',@IsStatus bit=0 )
	AS
	SET NOCOUNT ON;
		BEGIN
		IF @IsStatus=0
		BEGIN
		   SELECT * FROM (
			SELECT ROW_NUMBER() OVER (ORDER BY ModifyDate desc) AS RowNum, EnquiryId,SourceId,EnquiryTypeId,ContactNumber,Name,DateOfEnquiry,Discipline,StateId,CityId,[Address],AttendedBy,Demo,RemarksByFaculty,StatusId,ProbableStudentFor,Gender,Age,Occupation,FinalComments,
			NoOfClasses,Package,RegistrationAmount,CentreId,IsEnquiryClosed,FacultyId
			,(select NameOfFaculty from [Faculties] where FacultyID=En.FacultyId) as FacultyName,TelephonicEnquiryId,EnquiryNumber
			,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted FROM [dbo].[Enquiries] as En
			WHERE EnquiryTypeId = @enqueryType AND CentreId = @centerId AND IsDeleted=0
			AND(
			Name like '%'+@search+'%' OR ContactNumber like '%'+@search+'%' 
			OR NoOfClasses like '%'+@search+'%' OR Package like '%'+@search+'%'  OR EnquiryNumber like '%'+@search+'%'  
			OR SourceId = (SELECT SOURCEID FROM SOURCES where Source like '%'+@search+'%') 
			OR Discipline = (SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE'%'+@search+'%')) ) AS Enquery
			WHERE Enquery.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)


			SELECT @TotalPages = (SELECT COUNT(EnquiryId) FROM [dbo].[Enquiries]  WHERE EnquiryTypeId = @enqueryType AND CentreId = @centerId AND IsDeleted=0
			AND(
			Name like '%'+@search+'%' OR ContactNumber like '%'+@search+'%' 
			OR NoOfClasses like '%'+@search+'%' OR Package like '%'+@search+'%'  OR EnquiryNumber like '%'+@search+'%'  
			OR SourceId = (SELECT SOURCEID FROM SOURCES where Source like '%'+@search+'%') 
			OR Discipline = (SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE'%'+@search+'%')))
		END
		ELSE
		BEGIN
		   SELECT * FROM (
			SELECT ROW_NUMBER() OVER (ORDER BY ModifyDate desc) AS RowNum, EnquiryId,SourceId,EnquiryTypeId,ContactNumber,Name,DateOfEnquiry,Discipline,StateId,CityId,[Address],AttendedBy,Demo,RemarksByFaculty,StatusId,ProbableStudentFor,Gender,Age,Occupation,FinalComments,
			NoOfClasses,Package,RegistrationAmount,CentreId,IsEnquiryClosed,FacultyId
			,(select NameOfFaculty from [Faculties] where FacultyID=En.FacultyId) as FacultyName,TelephonicEnquiryId,EnquiryNumber
			,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted FROM [dbo].[Enquiries] as En
			WHERE EnquiryTypeId = @enqueryType AND CentreId = @centerId AND IsDeleted=0
			AND StatusId=@search) AS Enquery
			WHERE Enquery.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)


			SELECT @TotalPages = (SELECT COUNT(EnquiryId) FROM [dbo].[Enquiries]  WHERE EnquiryTypeId = @enqueryType AND CentreId = @centerId AND IsDeleted=0 AND StatusId=@search)
		END
		
		END


		
GO
/****** Object:  StoredProcedure [dbo].[GetEnquiryByEnquiryNumber]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetEnquiryByEnquiryNumber](@EnquiryNumber varchar(50),@CenterId bigint )
AS
BEGIN

IF NOT EXISTS(SELECT EnquiryId FROM enquiries WHERE TelephonicEnquiryId=@EnquiryNumber and CentreId=@CenterId)
	BEGIN
		SELECT EnquiryId,SourceId,EnquiryTypeId,ContactNumber,Name,DateOfEnquiry,Discipline,StateId,CityId,Address,AttendedBy,Demo,RemarksByFaculty,StatusId,
		ProbableStudentFor,Gender,Age,Occupation,FinalComments,NoOfClasses,Package,RegistrationAmount,CentreId,IsEnquiryClosed,FacultyID,
		(select NameOfFaculty from [Faculties] where FacultyId=en.FacultyID) as NameOfFaculty,TelephonicEnquiryId,EnquiryNumber,AddDate,AddedBy,ModifyDate,ModifyBy,(select FirstName +' '+LastName from [Users] where UserId=en.ModifyBy) as [UserName],
		IsActive,IsDeleted FROM [dbo].[enquiries] as en WHERE EnquiryNumber=@EnquiryNumber and IsDeleted=0
	END
	

END


--[GetEnquiryByEnquiryNumber] 'jan15-2',1

--SELECT EnquiryId FROM enquiries as en WHERE EnquiryNumber='jan15-2' and CenterId=1 IsDeleted=0


GO
/****** Object:  StoredProcedure [dbo].[GetEnquiryById]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetEnquiryById]
(@EnquiryId BIGINT)
AS
BEGIN
SELECT EnquiryId,SourceId,EnquiryTypeId,ContactNumber,Name,DateOfEnquiry,
Discipline,StateId,CityId,Address,AttendedBy,Demo,RemarksByFaculty,StatusId,
ProbableStudentFor,Gender,Age,Occupation,FinalComments,NoOfClasses,Package,
RegistrationAmount,CentreId,IsEnquiryClosed,FacultyID,
(select NameOfFaculty from [Faculties] where FacultyId=en.FacultyID) as NameOfFaculty,TelephonicEnquiryId,EnquiryNumber
,AddDate,AddedBy,ModifyDate,ModifyBy,
(select FirstName +' '+LastName from [Users] where UserId=en.ModifyBy) as [UserName],
IsActive,IsDeleted FROM enquiries as en WHERE enquiryid=@EnquiryId and IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[GetExamDetailsByCentreID]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetExamDetailsByCentreID](@CentreID int,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(max)='')
AS
BEGIN

	SELECT * FROM (
	SELECT ROW_NUMBER() OVER (ORDER BY ModifiedOn desc) AS RowNum, * from [ExamDetails] where CentreId=@CentreID and IsActive=1 and IsDeleted=0 and
	(
		StudentID=(select StudentID from [Student] where Name like '%'+@Search+'%' OR UniqueKey LIKE '%'+@Search+'%' ) OR	ExamName like '%'+@Search+'%' OR	ExamFees like '%'+@Search+'%' OR	Comments like '%'+@Search+'%'
	)) AS Exam
			WHERE Exam.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)

	SELECT @TotalPages = (SELECT COUNT(ExamID) FROM [dbo].[ExamDetails] where CentreId=@CentreID and IsActive=1 and IsDeleted=0 and
	(StudentID=(select StudentID from [Student] where Name like '%'+@Search+'%' OR UniqueKey LIKE '%'+@Search+'%') OR	ExamName like '%'+@Search+'%' OR ExamFees like '%'+@Search+'%' OR	Comments like '%'+@Search+'%'	))

END
GO
/****** Object:  StoredProcedure [dbo].[GetExamDetailsByExamID]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetExamDetailsByExamID]
@ExamID BIGINT
AS
BEGIN

	select * from [ExamDetails] where ExamID=@ExamID and IsActive=1 and IsDeleted=0

END
GO
/****** Object:  StoredProcedure [dbo].[GetExpenseById]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[GetExpenseById]
@ExpenseID int
AS
BEGIN
Select * from [Expenses] where IsActive=1 and ExpenseID=@ExpenseID
END
GO
/****** Object:  StoredProcedure [dbo].[GetExpensesForAll]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetExpensesForAll]
AS
BEGIN
Select * from [ExpenseforMaster]
END
GO
/****** Object:  StoredProcedure [dbo].[GetFaculity]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GetEnquiry 0 ,1
CREATE PROC [dbo].[GetFaculity](@centerId INT)
	AS
		BEGIN
			SELECT FacultyId,NameOfFaculty,EmailID,ContactNumber,Address,StateId,CityId,DOJ,Gender,Salary,SalaryRevision,DisciplineId,YearOfExperience,CentreId,Picture,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive FROM [dbo].[Faculties]
			where CentreId = @centerId
		END

GO
/****** Object:  StoredProcedure [dbo].[GetPaymentDetailsReportData]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPaymentDetailsReportData] @EnrollmentId BIGINT,@StudentId BIGINT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @PaymentDetails TABLE (DateofPayment VARCHAR(MAX),BankName VARCHAR(MAX),PaymentMode INT,AmountPid MONEY,DueDate VARCHAR(MAX))
    
	INSERT INTO @PaymentDetails(DateofPayment,BankName,PaymentMode,AmountPid,DueDate) SELECT convert(varchar,DateOfPayment,106),BankName,PaymentMode,AmountPaid,convert(varchar,DueDate,106) FROM [dbo].[PaymentDetails] WHERE EnrollmentID=@EnrollmentId AND StudentId=@StudentId

    SELECT DateofPayment,BankName,PaymentMode,AmountPid,DueDate FROM @PaymentDetails
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudentRemarksByCentreId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetStudentRemarksByCentreId]
(@CentreID int,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(max)='')
AS
BEGIN

SELECT * FROM (
select ROW_NUMBER() OVER (ORDER BY Modifiedon desc) AS RowNum, * from [StudentRemarks] where CentreID=@CentreId and IsActive=1 and IsDeleted=0 and
(FacultyID=(select FacultyID from [Faculties] where NameOfFaculty like '%'+@search+'%') OR
StudentID=(select StudentID from [Student] where Name like '%'+@search+'%' or UniqueKey like '%'+@search+'%')
 OR Remarks like '%'+@search+'%'
)) AS Remarks
			WHERE Remarks.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)

	set @TotalPages = (select  count(StudentID) from  [dbo].[StudentRemarks] WHERE CentreID=@CentreId and IsActive=1 and IsDeleted=0 and
(FacultyID=(select FacultyID from [Faculties] where NameOfFaculty like '%'+@search+'%') OR
StudentID=(select StudentID from [Student] where Name like '%'+@search+'%' or UniqueKey like '%'+@search+'%')
 OR Remarks like '%'+@search+'%'
))
END

 --select * from [StudentRemarks]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentRemarksByRemarksID]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetStudentRemarksByRemarksID]
(@RemarksID bigint)
AS
BEGIN

select * from [StudentRemarks] where RemarksID=@RemarksID and IsActive=1 and IsDeleted=0

END
GO
/****** Object:  StoredProcedure [dbo].[GetStudents]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--declare @TotalPages int 
--exec GetStudents 3 ,2, 1 ,@TotalPages OUTPUT,''
--select @TotalPages

CREATE PROC [dbo].[GetStudents](@centerId INT ,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(max)='')
	AS
		BEGIN
		SELECT * FROM (
			 SELECT ROW_NUMBER() OVER (ORDER BY ModifyDate DESC) AS RowNum, [StudentId],[UniqueKey],[Name],[CenterId],[DOB],[Contact1],[Contact2],[EmailAddress],[StateId],[CityId],[Address],[GuardianName],[Occupation],[HasTransportFacility],[IsActive]
			,[CreatedBy],[CreatedDate],[ModifyBy],[ModifyDate],[IsDeleted] FROM [DBMSwarVandana].[dbo].[Student]
			WHERE CenterId = @centerId AND IsDeleted=0
			AND(Name like '%'+@search+'%' OR DOB like '%'+@search+'%' OR Contact1 like '%'+@search+'%' OR EmailAddress like '%'+@search+'%'
			OR Address like '%'+@search+'%' OR Occupation like '%'+@search+'%' OR UniqueKey like '%'+@search+'%'
			))AS Students		 
			WHERE Students.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)

			SELECT @TotalPages = (SELECT COUNT(StudentId) FROM [dbo].[Student] 	WHERE CenterId = @centerId AND IsDeleted=0
			AND(Name like '%'+@search+'%' OR DOB like '%'+@search+'%' OR Contact1 like '%'+@search+'%' OR EmailAddress like '%'+@search+'%'
			OR Address like '%'+@search+'%' OR Occupation like '%'+@search+'%' OR UniqueKey like '%'+@search+'%'))
		END
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByCentreId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetStudentsByCentreId] (@CentreId int)
as
begin
SELECT [StudentId],[UniqueKey],[Name] FROM [DBMSwarVandana].[dbo].[Student] where CenterId=@CentreId
end
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByUniqueId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetStudentsByUniqueId]
(@UniqueId varchar(50),@CenterId bigint)
as
begin
SELECT [StudentId],[UniqueKey],[Name],[CenterId],[DOB],[Contact1],[Contact2],[EmailAddress],[StateId],[CityId],[Address],[GuardianName],[Occupation],[HasTransportFacility]
  FROM [DBMSwarVandana].[dbo].[Student] where UniqueKey=@UniqueId and [CenterId] = @CenterId
end

GO
/****** Object:  StoredProcedure [dbo].[GetUsersForEnquiryBy]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetUsersForEnquiryBy](@CentreId int)
AS
BEGIN
SELECT UserId, (FirstName+' '+LastName) as UserName from [dbo].[Users] where IsActive=1 and IsDeleted=0 and CentreId=@CentreId
END
GO
/****** Object:  StoredProcedure [dbo].[GetWeekDays]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--GetWeekDays '2014-12-14','2014-12-30'

CREATE PROCEDURE [dbo].[GetWeekDays](@start_date DATETIME,@end_date DATETIME)
	AS
		BEGIN

;WITH Days_Of_The_Week AS (
    SELECT 0 AS day_number, 'Sunday' AS day_name UNION ALL
	SELECT 1 AS day_number, 'Monday' AS day_name UNION ALL
    SELECT 2 AS day_number, 'Tuesday' AS day_name UNION ALL
    SELECT 3 AS day_number, 'Wednesday' AS day_name UNION ALL
    SELECT 4 AS day_number, 'Thursday' AS day_name UNION ALL
    SELECT 5 AS day_number, 'Friday' AS day_name UNION ALL
    SELECT 6 AS day_number, 'Saturday' AS day_name 
    
)
SELECT
	 ROW_NUMBER() OVER (ORDER BY GETDATE()) DayNo,
    Day_name,
    (1 +DATEDIFF(wk, @start_date, @end_date) - CASE WHEN DATEPART(weekday, @start_date) > day_number THEN 1 ELSE 0 END - CASE WHEN DATEPART(weekday, @end_date)  < day_number THEN 1 ELSE 0 END) AS NoOfDays
		FROM  Days_Of_The_Week

		END
GO
/****** Object:  StoredProcedure [dbo].[InsertBudgetMaster]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertBudgetMaster]
@ActionID		int,
@BudgetID		int,
@ExpenseFor		int,
@BudgetAmount	money,
@Month			int,
@Description	varchar(max),
@FinancialYear varchar(50),
@CentreID		int,
@CreatedBy		int,
@CreatedOn		datetime,
@ModifiedBy		int,
@ModifiedOn		datetime,
@IsActive		bit,
@IsDeleted		bit
AS
BEGIN

IF (@ActionID=0)
BEGIN
IF NOT EXISTS(select * from [BudgetMaster] where CentreID=@CentreID and FinancialYear=@FinancialYear and [Month]=@Month and ExpenseFor= @ExpenseFor)
BEGIN

	INSERT INTO [BudgetMaster]
           ([ExpenseFor]
           ,[BudgetAmount]
           ,[Month]
           ,[Description]
           ,[FinancialYear]
           ,[CentreID]
           ,[CreatedBy]
           ,[CreatedOn]
           ,[ModifiedBy]
           ,[ModifiedOn]
           ,[IsActive]
           ,[IsDeleted])
     VALUES
           (@ExpenseFor
           ,@BudgetAmount
           ,@Month
           ,@Description
           ,@FinancialYear
           ,@CentreID
           ,@CreatedBy
           ,@CreatedOn
           ,@ModifiedBy
           ,@ModifiedOn
           ,@IsActive
           ,@IsDeleted)
		select @@identity
END
ELSE
BEGIN
	select -1
END
END

IF (@ActionID>0)
BEGIN
	UPDATE [BudgetMaster]
	   SET [ExpenseFor]=@ExpenseFor
		,[BudgetAmount] = @BudgetAmount
		,[Month]=@Month
		  ,[Description] = @Description
		  ,[FinancialYear]=@FinancialYear
		  ,[ModifiedBy] = @ModifiedBy
		  ,[ModifiedOn] = @ModifiedOn
		  ,[IsActive] = @IsActive
		  ,[IsDeleted] = @IsDeleted
	WHERE
		BudgetID=@BudgetID
		select @BudgetID
END

END

GO
/****** Object:  StoredProcedure [dbo].[InsertClassTimming]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertClassTimming](@XMLdata XML) 
AS 
  BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from 
      -- interfering with SELECT statements. 
      SET nocount ON; 

      DECLARE @LoopCounter INT =1, 
              @LoopLength  INT=0 
      DECLARE @ClassId   BIGINT, 
              @WeekDayId BIGINT, 
              @Year      BIGINT 
      DECLARE @StartTime VARCHAR(30),@EndTime   VARCHAR(30) 
      DECLARE @ClassTimePattern TABLE ( patternid  BIGINT IDENTITY(1, 1) PRIMARY KEY, 
           classid    BIGINT, weekdayid  BIGINT, starttime  VARCHAR(200), endtime VARCHAR(200),summary VARCHAR(max), 
           adddate    DATETIME, addedby    BIGINT, modifydate DATETIME, modifyby BIGINT, isactive BIT) 

      INSERT INTO @ClassTimePattern 
	            (classid,weekdayid, starttime, endtime, summary, adddate, addedby,modifydate, modifyby, isactive) 
      SELECT [Table].[Column].value('ClassId [1]', 'BIGINT')        AS 
             ' ColumnId' 
             , 
             [Table].[Column].value(' WeekDayId[1]', 'BIGINT')      AS 
             ' WeekDayId', 
             [Table].[Column].value(' StartTime[1]', 'varchar(30)') AS 
             ' StartTime', 
             [Table].[Column].value(' EndTime[1]', 'varchar(30)')   AS 'EndTime' 
             , 
             [Table].[Column].value(' Summary[1]', 'varchar(max)') 
             AS 'Summary', 
             [Table].[Column].value(' AddDate [1]', 'datetime')     AS 
             ' AddDate', 
             [Table].[Column].value(' AddedBy [1]', 'BIGINT')       AS 
             ' AddedBy', 
             [Table].[Column].value(' ModifyDate [1]', 'datetime')  AS 
             'ModifyDate', 
             [Table].[Column].value(' ModifyBy [1]', 'BIGINT')      AS 
             'ModifyBy', 
             [Table].[Column].value(' IsActive [1]', 'bit')         AS 
             'IsActive' 
      FROM   @xmlData.nodes('/body/MainNode') AS [Table]([Column]) 

      SET @LoopLength = (SELECT Count(*) 
                         FROM   @ClassTimePattern) 
      SET @ClassId = (SELECT TOP(1) classid 
                      FROM   @ClassTimePattern) 

      DELETE FROM [dbo].[classtimingpatterns] WHERE  classid = @ClassId 

      INSERT INTO [dbo].[classtimingpatterns] 
                  (classid, 
                   weekdayid, 
                   starttime, 
                   endtime, 
                   summary, 
                   adddate, 
                   addedby, 
                   modifydate, 
                   modifyby, 
                   isactive) 
      SELECT classid, 
             weekdayid, 
             starttime, 
             endtime, 
             summary, 
             adddate, 
             addedby, 
             modifydate, 
             modifyby, 
             isactive 
      FROM   @ClassTimePattern 
  END 

  --select * from classtimingpatterns
GO
/****** Object:  StoredProcedure [dbo].[InsertExamDetails]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertExamDetails]
@ActionID int,
@ExamID bigint,
@StudentID bigint,
@ExamName varchar(max),
@ExamDate datetime,
@FacultyID bigint,
@ExamFees money,
@Comments varchar(max),
@ResultOfExam varchar(max),
@CentreID int,
@CreatedBy int,
@CreatedOn datetime,
@ModifiedBy int,
@ModifiedOn datetime,
@IsActive bit,
@IsDeleted bit
AS
BEGIN

IF(@ActionID=0)
BEGIN

	IF not exists(select * from [examdetails] where StudentID=@StudentID and ExamName=@ExamName and ExamDate=@ExamDate)
	BEGIN
	
		INSERT INTO [DBMSwarVandana].[dbo].[ExamDetails]
           ([StudentID]
           ,[ExamName]
           ,[ExamDate]
           ,[FacultyID]
           ,[ExamFees]
           ,[Comments]
           ,[ResultOfExam]
           ,[CentreID]
           ,[CreatedBy]
           ,[CreatedOn]
           ,[ModifiedBy]
           ,[ModifiedOn]
           ,[IsActive]
           ,[IsDeleted])
     VALUES
           (@StudentID
           ,@ExamName
           ,@ExamDate
           ,@FacultyID
           ,@ExamFees
           ,@Comments
           ,@ResultOfExam
           ,@CentreID
           ,@CreatedBy
           ,@CreatedOn
           ,@ModifiedBy
           ,@ModifiedOn
           ,@IsActive
           ,@IsDeleted)
           select @@identity
	
	END
	ELSE
	BEGIN
		select -1
	END
END
ELSE IF (@ActionID>0)
BEGIN
	
	UPDATE [DBMSwarVandana].[dbo].[ExamDetails]
   SET [StudentID] = @StudentID
      ,[ExamName] = @ExamName
      ,[ExamDate] = @ExamDate
      ,[FacultyID] = @FacultyID
      ,[ExamFees] = @ExamFees
      ,[Comments] = @Comments
      ,[ResultOfExam] = @ResultOfExam
      ,[ModifiedBy] = @ModifiedBy
      ,[ModifiedOn] = @ModifiedOn
      ,[IsActive] = @IsActive
      ,[IsDeleted] = @IsDeleted
	WHERE ExamID=@ExamID
	select @ExamID
END
END

GO
/****** Object:  StoredProcedure [dbo].[InsertExpenses]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertExpenses]
@ActionID		int,
@ExpenseID		int,
@ExpenseAmount	money,
@ExpenseFor		int,
@Description	varchar(max),
@DateOfExpense	datetime,
@CentreID		int,
@CreatedOn		datetime,
@CreatedBy		int,
@ModifiedOn		datetime,
@ModifiedBy		int,
@IsActive		bit,
@IsDeleted		bit
AS
BEGIN

IF(@ActionID=0)
BEGIN
	INSERT INTO [Expenses]
           ([ExpenseAmount]
           ,[ExpenseFor]
           ,[Description]
           ,[DateOfExpense]
           ,[CentreID]
           ,[CreatedOn]
           ,[CreatedBy]
           ,[ModifiedOn]
           ,[ModifiedBy]
           ,[IsActive]
           ,[IsDeleted])
     VALUES
           (@ExpenseAmount
           ,@ExpenseFor
           ,@Description
           ,@DateOfExpense
           ,@CentreID
           ,@CreatedOn
           ,@CreatedBy
           ,@ModifiedOn
           ,@ModifiedBy
           ,@IsActive
           ,@IsDeleted)
           select @@IDENTITY
END
IF (@ActionID>0)
BEGIN
UPDATE [DBMSwarVandana].[dbo].[Expenses]
   SET [ExpenseAmount] = @ExpenseAmount
      ,[ExpenseFor] = @ExpenseFor
      ,[Description] = @Description
      ,[DateOfExpense] = @DateOfExpense
      ,[ModifiedOn] = @ModifiedOn
      ,[ModifiedBy] = @ModifiedBy
      ,[IsActive] = @IsActive
      ,[IsDeleted] = @IsDeleted
      where ExpenseID=@ExpenseID
      select @ExpenseID
END
END

GO
/****** Object:  StoredProcedure [dbo].[InsertPaymentDetails]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertPaymentDetails] (@StudentId BIGINT,@BankName VARCHAR(100),@PaymentMode INT,@PaymentDetails VARCHAR(100),@DateOfPayment DATETIME,@AmountPaid MONEY
                   ,@DueDate DATETIME,@AddedBy BIGINT,@AddDate DATETIME,@ModifyBy BIGINT,@ModifyDate DATETIME,@DisciplineId INT,@EnrollmentID BIGINT)
AS
BEGIN
        INSERT INTO [PaymentDetails](EnrollmentId,StudentId,BankName,PaymentMode,PaymentDetails,DateOfPayment,AmountPaid,DueDate,AddBy,AddDate,ModifyBy,ModifyDate)
        VALUES (@EnrollmentID,@StudentId,@BankName,@PaymentMode,@PaymentDetails,@DateOfPayment,@AmountPaid,@DueDate,@AddedBy,@AddDate,@ModifyBy,@ModifyDate)
        
		UPDATE [dbo].[StudentEnrollment] SET AmountPaid=(AmountPaid+@AmountPaid)  where DisciplineId=@DisciplineId and StudentId=@StudentId and EnrollmentId=@EnrollmentID

		select @@IDENTITY
END


GO
/****** Object:  StoredProcedure [dbo].[InsertStudentAttendence]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertStudentAttendence](@XMLdata XML)
AS 
  BEGIN 
      -- SET NOCOUNT ON added to prevent extra result sets from 
      -- interfering with SELECT statements. 
      SET nocount ON; 

      DECLARE @LoopCounter INT =1,               @LoopLength  INT=0 
      DECLARE @BatchId BIGINT, @WeekDayId BIGINT,@DateOfAttendence DATETIME             

      DECLARE @StudentAttendence TABLE (Id  BIGINT IDENTITY(1, 1) PRIMARY KEY, BatchId    BIGINT, EnrollmentId  BIGINT, StuentId BIGINT , AttendenceStatus int ,
           DateOfAttendence DATETIME ,AddDate DATETIME, AddBy    BIGINT,  ModifyDate DATETIME, ModifyBy BIGINT) 

      INSERT INTO @StudentAttendence 
	            (BatchId,EnrollmentId,StuentId,AttendenceStatus,DateOfAttendence,AddDate,AddBy,ModifyDate,ModifyBy) 
      SELECT [Table].[Column].value('BatchId [1]', 'BIGINT')        AS 
             ' BatchId' , 
             [Table].[Column].value(' EnrollmentId[1]', 'BIGINT')      AS 
             ' EnrollmentId', 
             [Table].[Column].value(' StuentId[1]', 'BIGINT') AS 
             ' StuentId', 
             [Table].[Column].value(' AttendenceStatus[1]', 'int')   AS 'AttendenceStatus' , 
             [Table].[Column].value(' DateOfAttendence[1]', 'datetime') 
             AS 'DateOfAttendence', 
             [Table].[Column].value(' AddDate [1]', 'datetime')     AS 
             ' AddDate', 
             [Table].[Column].value(' AddBy [1]', 'BIGINT')       AS 
             ' AddBy', 
             [Table].[Column].value(' ModifyDate [1]', 'datetime')  AS 
             'ModifyDate', 
             [Table].[Column].value(' ModifyBy [1]', 'BIGINT')      AS 
             'ModifyBy'
      FROM   @xmlData.nodes('/body/MainNode') AS [Table]([Column]) 

      SET @LoopLength = (SELECT Count(*) FROM   @StudentAttendence)       
	  SET @DateOfAttendence = (SELECT TOP(1) DateOfAttendence  FROM   @StudentAttendence)
	  SET @BatchId = (SELECT TOP(1) BatchId  FROM   @StudentAttendence)
      DELETE FROM [dbo].[StudentAttendence] WHERE  BatchId = @BatchId  and CONVERT(VARCHAR(10), DateOfAttendence, 111)  =CONVERT(VARCHAR(10), @DateOfAttendence, 111) 

      INSERT INTO [dbo].[StudentAttendence]
                  (BatchId,EnrollmentId,StuentId,AttendenceStatus,DateOfAttendence,AddDate,AddBy,ModifyDate,ModifyBy) 
      SELECT BatchId,EnrollmentId,StuentId,AttendenceStatus,DateOfAttendence,AddDate,AddBy,ModifyDate,ModifyBy  FROM   @StudentAttendence 
  END 

  -- 
   

   







GO
/****** Object:  StoredProcedure [dbo].[InsertStudentRemarks]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertStudentRemarks]
@ActionID	int,
@RemarksID bigint,
@FacultyID bigint,
@StudentId bigint,
@Remarks varchar(max),
@DateOfRemarks datetime,
@CentreID	int,
@CreatedOn datetime,
@CreatedBy int,
@ModifiedOn datetime,
@ModifiedBy int,
@IsActive bit,
@IsDeleted bit
AS
BEGIN

IF (@ActionID=0)
BEGIN
	IF not exists(select * from [StudentRemarks] where Remarks=@Remarks and DateOfRemarks=@DateOfRemarks)
	Begin
	INSERT INTO [StudentRemarks]
           ([FacultyID]
           ,[StudentId]
           ,[Remarks]
           ,[DateOfRemarks]
           ,[centreid]
           ,[CreatedOn]
           ,[CreatedBy]
           ,[ModifiedOn]
           ,[ModifiedBy]
           ,[IsActive]
           ,[IsDeleted])
     VALUES
           (@FacultyID
           ,@StudentId
           ,@Remarks
           ,@DateOfRemarks
           ,@CentreID
           ,@CreatedOn
           ,@CreatedBy
           ,@ModifiedOn
           ,@ModifiedBy
           ,@IsActive
           ,@IsDeleted)
           select @@IDENTITY
      END
      ELSE
      BEGIN
		select -1
      END
END
ELSE IF (@ActionID>0)
BEGIN
	UPDATE [StudentRemarks]
   SET [FacultyID] = @FacultyID
      ,[StudentId] = @StudentId
      ,[Remarks] = @Remarks
      ,[DateOfRemarks] = @DateOfRemarks
      ,[ModifiedOn] = @ModifiedOn
      ,[ModifiedBy] = @ModifiedBy
      ,[IsActive] = @IsActive
      ,[IsDeleted] = @IsDeleted
      WHERE RemarksID=@RemarksID
      
      select @RemarksID
END
END

GO
/****** Object:  StoredProcedure [dbo].[USP_Centres_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Centres_IUD] (@ActionId INT,@CentreId INT,@CentreName VARCHAR(100),@Address VARCHAR(MAX),@StateId INT,@CityId INT,@CentreOpenDate DATETIME=null,@AddDate DATETIME,@AddedBy INT,@ModifyDate DATETIME,@ModifyBy INT,@IsActive BIT,@IsDeleted BIT)
AS
BEGIN
if (@ActionId<0)
BEGIN
	Update [Centres] SET IsActive=0 where CentreId=@CentreId
	Select @CentreId
END
ELSE IF (@ActionId=0)
BEGIN
	IF NOT EXISTS(SELECT * FROM [dbo].[Centres] WHERE CentreName=@CentreName)
	BEGIN
		INSERT INTO [DBMSwarVandana].[dbo].[Centres] ([CentreName],[Address],[StateId],[CityId],[CentreOpenDate],[AddDate],[AddedBy],[ModifyDate],[ModifyBy],[IsActive],IsDeleted)
		VALUES (@CentreName,@Address,@StateId,@CityId,@CentreOpenDate,@AddDate,@AddedBy,@ModifyDate,@ModifyBy,@IsActive,@IsDeleted)
		SELECT @@IDENTITY
      END
      ELSE
      BEGIN
			SELECT -1
      END
END
ELSE IF (@ActionId>0)
BEGIN
	IF NOT EXISTS(SELECT * FROM [dbo].[Centres] WHERE CentreName=@CentreName AND CentreId NOT IN (@CentreId))
		BEGIN
			UPDATE [DBMSwarVandana].[dbo].[Centres] SET	CentreName=@CentreName,Address=@Address,StateId=@StateId,CityId=@CityId,CentreOpenDate=@CentreOpenDate,IsDeleted=@IsDeleted	WHERE CentreId=@CentreId
			SELECT @CentreId
		END
	ELSE
		BEGIN
			SELECT -1
		END
END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CentresGetAll]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_CentresGetAll] (@search varchar(400)='')
AS
BEGIN
Select * from  [dbo].[Centres] where IsActive=1 and isdeleted =0 and (CentreName like '%'+@search +'%' or Address like '%'+@search +'%' OR StateId =(SELECT StateId from dbo.states where stateName like'%'+ @search+'%')

 OR CityId =(SELECT CityId from [dbo].[Cities] where CityNAme like'%'+ @search+'%')
 )
END



GO
/****** Object:  StoredProcedure [dbo].[USP_ChangePassword]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_ChangePassword]
(@UserId int
,@CurrentPassword varchar(50)
,@Password varchar(50))
AS
BEGIN
	if exists(select UserId from [Users] where UserId=@UserId and Password=@CurrentPassword)
	BEGIN
		UPDATE [Users]
		SET
		[Password]=@Password
		WHERE
		UserId=@UserId
		select @UserId
	END
	ELSE
	BEGIN
		Select -1
	END
END

-- exec USP_ChangePassword 1,'123'
GO
/****** Object:  StoredProcedure [dbo].[USP_CitiesGetByStateId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_CitiesGetByStateId]
(@StateId int)
AS
BEGIN
Select * from Cities where IsActive=1 and StateId=@StateId
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ClassDetails_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_ClassDetails_IUD]
@ActionId int,
@ClassId BIGINT,
@ClassName varchar(30),
@StudentLimit int,
@DisciplineId int,
@FacultyId BIGINT,
@StartDate datetime,
@EndDate datetime,
@CentreId int,
@AddDate datetime,
@AddedBy int,
@ModifyDate datetime,
@ModifyBy int,
@IsActive bit,
@IsDeleted bit
AS
BEGIN
if (@ActionId=0)
BEGIN
	if not exists(select * from [ClassDetails] where DisciplineId=@DisciplineId and FacultyId=@FacultyId and StartDate=@StartDate and EndDate=@EndDate)
	BEGIN
		INSERT INTO [DBMSwarVandana].[dbo].[ClassDetails]
           ([DisciplineId]
           ,[FacultyId]
           ,[StartDate]
           ,[EndDate]
           ,[CentreId]
		   ,[ClassName]
		   ,[StudentLimit]
           ,[AddDate]
           ,[AddedBy]
           ,[ModifyDate]
           ,[ModifyBy]
           ,[IsActive],IsDeleted )
     VALUES
           (@DisciplineId
           ,@FacultyId
           ,@StartDate
           ,@EndDate
           ,@CentreId
		   ,@ClassName
		   ,@StudentLimit
           ,@AddDate
           ,@AddedBy
           ,@ModifyDate
           ,@ModifyBy
           ,@IsActive,@IsDeleted)
           select @@IDENTITY
	END
	ELSE
	BEGIN
		select -1
	END
END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DisciplineGetAll]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_DisciplineGetAll](@search varchar(30)='',@CentreID int)
AS
BEGIN
SELECT [DisciplineId]
      ,[Discipline]
      ,[Description]
      ,[CentreID]
      ,(select CentreName from [Centres] where CentreId=D.[CentreID]) AS [CentreName]
      ,[AddDate]
      ,[AddedBy]
      ,[ModifyDate]
      ,[ModifyBy]
      ,[IsActive]
      ,[IsDeleted]
       from [Disciplines] AS D where IsActive=1 and isdeleted = 0 and Discipline like'%'+@search+'%' and CentreID=@CentreID
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DisciplineGetById]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_DisciplineGetById]
(@DisciplineId int)
AS
BEGIN
select * from [Disciplines] where DisciplineId=@DisciplineId
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Disciplines_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_Disciplines_IUD] @ActionId INT,@DisciplineId INT,@Discipline VARCHAR(100),@Description VARCHAR(MAX),@CentreID int,@AddDate DATETIME,@AddedBy INT,@ModifyDate DATETIME,@ModifyBy INT,@IsActive BIT,@IsDeleted BIT
AS
BEGIN
if (@ActionId=0)
BEGIN
	if NOT EXISTS(SELECT * FROM [Disciplines] WHERE Discipline=@Discipline)
	BEGIN
		INSERT INTO [DBMSwarVandana].[dbo].[Disciplines] ([Discipline],[Description],[CentreID],[AddDate],[AddedBy],[ModifyDate],[ModifyBy],[IsActive],IsDeleted) 
		VALUES (@Discipline,@Description,@CentreID,@AddDate,@AddedBy,@ModifyDate,@ModifyBy,@IsActive,@IsDeleted)
		SELECT @@identity
	END
	ELSE
	BEGIN
		select -1
	END
END
ELSE IF (@ActionId>0)
BEGIN
if NOT EXISTS(SELECT * FROM [Disciplines] WHERE Discipline=@Discipline)
	BEGIN
	UPDATE [DBMSwarVandana].[dbo].[Disciplines] SET [Discipline] = @Discipline,[Description] = @Description,[ModifyDate] = @ModifyDate,[ModifyBy] = @ModifyBy,IsDeleted=@IsDeleted WHERE DisciplineId=@DisciplineId
	select @DisciplineId
	END
	ELSE
		BEGIN
			select -1
		END
END
END

GO
/****** Object:  StoredProcedure [dbo].[USP_Enquiries_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Enquiries_IUD] @ActionId int,@EnquiryId int=0,@SourceId int=0,@EnquiryTypeId int=0,@ContactNumber varchar(100)=null,@Name varchar(100)=null,@DateOfEnquiry datetime=null,@Discipline int=0,@StateId int=0,
        @CityId int=0,@Address varchar(max)=null,@AttendedBy int=0,@Demo bit,@RemarksByFaculty varchar(max)=null,@StatusId int=0,@ProbableStudentFor int=0,@Gender int=0,@Age int=0,@Occupation varchar(100)=null,@FinalComments varchar(max)=null,
        @NoOfClasses int=0,@Package money=0,@RegistrationAmount money=0,@CentreId int=0,@IsEnquiryClosed bit,@FacultyID bigint=0,@TelephonicEnquiryId varchar(30),@AddDate datetime,@AddedBy int,@ModifyDate datetime,@ModifyBy int,@IsActive bit,@IsDeleted bit
AS
BEGIN
if (@ActionId=0)
  BEGIN
     -- Check either it Telephonic Enquery Id Exist or not.

  	  IF NOT EXISTS(SELECT * FROM [Enquiries] WHERE SourceId=@SourceId and Name=@Name and DateOfEnquiry=@DateOfEnquiry and Discipline=@Discipline and EnquiryTypeId=@EnquiryTypeId)
  	  BEGIN
  	  	INSERT INTO [DBMSwarVandana].[dbo].[Enquiries] ([SourceId],[EnquiryTypeId],[ContactNumber],[Name],[DateOfEnquiry],[Discipline],[StateId],[CityId],[Address],[AttendedBy],[Demo],[RemarksByFaculty],[StatusId],[ProbableStudentFor],[Gender],[Age]
               ,[Occupation],[FinalComments],[NoOfClasses],[Package],[RegistrationAmount],[CentreId],[IsEnquiryClosed],[facultyid],[TelephonicEnquiryId],[AddDate],[AddedBy],[ModifyDate],[ModifyBy],[IsActive],[IsDeleted])
            VALUES (@SourceId,@EnquiryTypeId,@ContactNumber,@Name,@DateOfEnquiry,@Discipline,@StateId,@CityId,@Address,@AttendedBy,@Demo,@RemarksByFaculty,@StatusId,@ProbableStudentFor,@Gender,@Age,@Occupation,@FinalComments,@NoOfClasses,@Package,@RegistrationAmount
               ,@CentreId,@IsEnquiryClosed ,@FacultyID,@TelephonicEnquiryId,@AddDate,@AddedBy,@ModifyDate,@ModifyBy,@IsActive,@IsDeleted)
               SELECT @@IDENTITY
				UPDATE [dbo].[Enquiries] SET [EnquiryNumber]=(SUBSTRING(DATENAME(mm,GETDATE()),1,3)+convert(varchar(50),year(getdate()) % 100)+ '-' +convert(varchar(10),@@Identity)) WHERE EnquiryId=@@IDENTITY
  	  END
  	  ELSE
  	  BEGIN
  	  	SELECT -1
  	  END
  END
ELSE
  BEGIN	
     UPDATE [DBMSwarVandana].[dbo].[Enquiries] SET [SourceId]=@SourceId,[EnquiryTypeId]=@EnquiryTypeId,[ContactNumber]=@ContactNumber,[Name]=@Name,[DateOfEnquiry]= @DateOfEnquiry,[Discipline]= @Discipline,[StateId]=@StateId,[CityId]= @CityId,[Address]=@Address
            ,[AttendedBy]=@AttendedBy,[Demo]=@Demo,[RemarksByFaculty]=@RemarksByFaculty,[StatusId]= @StatusId,[ProbableStudentFor]=@ProbableStudentFor,[Gender]=@Gender,[Age]= @Age,[Occupation]= @Occupation,[FinalComments]=  @FinalComments,[NoOfClasses]=@NoOfClasses
             ,[Package]=@Package,[RegistrationAmount]=@RegistrationAmount,[CentreId]=@CentreId,[IsEnquiryClosed]= @IsEnquiryClosed,[FacultyId]=@FacultyID,[AddDate]=@AddDate,[AddedBy]=@AddedBy,[ModifyDate]=@ModifyDate,[ModifyBy]= @ModifyBy,[IsActive]=@IsActive
             ,[IsDeleted]=@IsDeleted WHERE EnquiryId= @EnquiryId

			 SELECT 1
  
  END
END

-- select * from [Enquiries]  where CentreId =1
GO
/****** Object:  StoredProcedure [dbo].[USP_Faculties_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Faculties_IUD] @ActionId	int,@FacultyId bigint,@NameOfFaculty varchar(100),@EmailID varchar(100),@ContactNumber varchar(50),@Address varchar(max),@StateId int,
@CityId int,@DOJ datetime,@Gender int,@Salary money,@SalaryRevision money,@DisciplineId int,@YearOfExperience int,@CentreId int,@Picture varchar(50),@AddDate datetime,@AddedBy int,
@ModifyDate datetime,@ModifyBy int,@IsActive bit,@IsDeleted bit
AS
BEGIN
IF (@ActionId=0)
  BEGIN
  	IF not exists(select [NameOfFaculty] from dbo.[Faculties] where NameOfFaculty=@NameOfFaculty and Address=@Address and EmailId=@EmailId)
  	BEGIN
  		INSERT INTO [DBMSwarVandana].[dbo].[Faculties]([NameOfFaculty]
             ,[EmailID],[ContactNumber],[Address],[StateId],[CityId],[DOJ],[Gender],[Salary],[SalaryRevision],[DisciplineId],[YearOfExperience],[CentreId],[Picture],[AddDate],[AddedBy]
             ,[ModifyDate],[ModifyBy],[IsActive],IsDeleted)
          VALUES (@NameOfFaculty,@EmailID,@ContactNumber,@Address,@StateId,@CityId,@DOJ,@Gender,@Salary,@SalaryRevision,@DisciplineId,@YearOfExperience,@CentreId,@Picture,@AddDate,@AddedBy
             ,@ModifyDate,@ModifyBy,@IsActive,@IsDeleted)  select @@IDENTITY
  	END
  	ELSE
  	BEGIN
  		select -1
  	END
  END
ELSE
  BEGIN
    IF NOT EXISTS(select [NameOfFaculty] from dbo.[Faculties] where FacultyId!=@FacultyId and EmailId=@EmailId)
    BEGIN
      UPDATE Faculties SET NameOfFaculty=@NameOfFaculty ,EmailID=@EmailID ,ContactNumber=@ContactNumber,[Address]=@Address  ,[StateId]=@StateId  ,[CityId]=@CityId  ,[DOJ]= @DOJ ,[Gender]=@Gender  ,[Salary]=@Salary
        ,[SalaryRevision]=@SalaryRevision,[DisciplineId]=@DisciplineId  ,[YearOfExperience]= @YearOfExperience ,[CentreId]= @CentreId,[Picture]= @Picture ,[AddDate]= @AddDate  ,[AddedBy]= @AddedBy
        ,[ModifyDate]= @ModifyDate ,[ModifyBy]=@ModifyBy ,[IsActive]=@IsActive,IsDeleted=@IsDeleted WHERE FacultyId=@FacultyId
    END
	ELSE
	BEGIN
  		select -1
  	END
  END
END

GO
/****** Object:  StoredProcedure [dbo].[USP_FacultyGetByCenterId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--DECLARE @tOTAPAGES  int 
--exec USP_FacultyGetByCenterId '3', 6,1 , @tOTAPAGES out
--SELECT @tOTAPAGES

CREATE PROC [dbo].[USP_FacultyGetByCenterId](@CentreID INT, @RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT,@search varchar(max)='')
	AS
		BEGIN
		SELECT * FROM (
			SELECT ROW_NUMBER() OVER (ORDER BY ModifyDate) AS RowNum, FacultyId,NameOfFaculty,EmailID,ContactNumber,Address,StateId,CityId,DOJ,Gender,Salary,SalaryRevision,DisciplineId,YearOfExperience,CentreId,Picture,AddDate,
			AddedBy,ModifyDate,ModifyBy,IsActive,DOB FROM [dbo].[Faculties]
			WHERE CentreId = @CentreID AND IsDeleted=0  
			AND (NameOfFaculty LIKE '%'+@search+'%' OR EmailID LIKE '%'+@search+'%' OR ContactNumber LIKE '%'+@search+'%' OR DisciplineId IN(SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE '%'+@search+'%' ) )
			) AS FD
			WHERE FD.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)
			SELECT @TotalPages = (SELECT COUNT(FacultyId) FROM [dbo].[Faculties]  WHERE CentreId = @CentreID AND IsDeleted=0 AND (NameOfFaculty LIKE '%'+@search+'%' OR EmailID LIKE '%'+@search+'%' OR ContactNumber LIKE '%'+@search+'%' OR DisciplineId IN(SELECT DisciplineId FROM [dbo].[Disciplines] WHERE Discipline LIKE '%'+@search+'%' ) ))
		END

		

		
		
		
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginCheck]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_LoginCheck]
(@UserName varchar(50)
,@Password varchar(50))
AS
BEGIN
SELECT [UserId]
      ,[FirstName]
      ,[LastName]
      ,[DOB]
      ,[DOJ]
      ,[ContactNumber]
      ,[EmailID]
      ,[CentreId]
      ,[Salary]
      ,[RoleId]
      ,[UserName]
      ,[Password]
      ,[StateId]
      ,[CityId]
      ,[Address]
      ,[AddDate]
      ,[AddedBy]
      ,[ModifyDate]
      ,[ModifyBy]
      ,[IsActive]
  FROM [DBMSwarVandana].[dbo].[Users] where UserName=@UserName and [Password]=@Password
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Sources_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_Sources_IUD]
@ActionId int,
@SourceId int,
@Source VARCHAR(100),
@Description VARCHAR(MAX),
@AddDate DATETIME,
@AddedBy INT,
@ModifyDate DATETIME,
@ModifyBy int,
@IsActive BIT
AS
BEGIN
if (@ActionId=0)
BEGIN
	if not exists(select * from [Sources] where Source=@Source)
	BEGIN
		INSERT INTO [DBMSwarVandana].[dbo].[Sources]
				   ([Source]
				   ,[Description]
				   ,[AddDate]
				   ,[AddedBy]
				   ,[ModifyDate]
				   ,[ModifyBy]
				   ,[IsActive])
			 VALUES
				   (@Source
				   ,@Description
				   ,@AddDate
				   ,@AddedBy
				   ,@ModifyDate
				   ,@ModifyBy
				   ,@IsActive)
				   select @@identity
      END
      
      ELSE
      BEGIN
      select -1
      END
END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SourcesGetAll]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_SourcesGetAll]
AS
BEGIN
Select * from [Sources] where IsActive=1
END
GO
/****** Object:  StoredProcedure [dbo].[USP_StatesGetAll]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_StatesGetAll]
AS
BEGIN
Select * from States where IsActive=1
END
GO
/****** Object:  StoredProcedure [dbo].[USP_StudentEntrollment_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_StudentEntrollment_IUD] (@ActionId int,@EnrollmentId bigint,@StudentId bigint,@DisciplineId int,@CourseAmount money,@RegistratonAmount money,@NoOfClasses int,@AmountPaid money,@SatrtDate datetime,
             @EndDate datetime,@CreatedDate datetime,@CreatedBy int,@ModifyDate datetime,@ModifBy int,@IsActive bit,@IsDeleted bit,@BankName varchar(150),@PaymentMode int ,@PaymentDetails varchar(300),@DueDate datetime,@EnqueryNo varchar(150),@IsRenewal bit)
AS
BEGIN
IF (@ActionId=0)
BEGIN
	IF NOT EXISTS(SELECT * FROM [dbo].[StudentEnrollment] where StudentId=@StudentId and DisciplineId=@DisciplineId)
	BEGIN
		INSERT INTO [DBMSwarVandana].[dbo].[StudentEnrollment] ([StudentId],[DisciplineId],[CourseAmount],[RegistratonAmount],[NoOfClasses],[AmountPaid],[SatrtDate],[EndDate],
		[CreatedDate],[CreatedBy],[ModifyDate],[ModifBy],[IsActive],[IsDeleted],BankName,PaymentMode,PaymentDetails,EnqueryNo,IsRenewal)
        VALUES (@StudentId,@DisciplineId,@CourseAmount,@RegistratonAmount,@NoOfClasses,@AmountPaid,@SatrtDate,@EndDate,@CreatedDate,@CreatedBy,@ModifyDate,@ModifBy,@IsActive,@IsDeleted,@BankName,@PaymentMode,@PaymentDetails,@EnqueryNo,@IsRenewal)
        
		DECLARE @EnrollmentIdP BIGINT
		SET @EnrollmentIdP=(SELECT @@IDENTITY)

		INSERT INTO [DBMSwarVandana].[dbo].[PaymentDetails](EnrollmentId,StudentId,BankName,PaymentMode,PaymentDetails,DateOfPayment,AmountPaid,AddBy,AddDate,ModifyBy,ModifyDate,DueDate)
        VALUES (@EnrollmentIdP,@StudentId,@BankName,@PaymentMode,@PaymentDetails,@CreatedDate,(@AmountPaid+@RegistratonAmount),@CreatedBy,@CreatedDate,@ModifBy,@ModifyDate,@DueDate)

		SELECT @EnrollmentIdP
	END
	ELSE
	BEGIN
		select -1
	END
END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_StudentRenewal_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_StudentRenewal_IUD] (@ActionId INT,@RenewalId BIGINT,@EnrollmentNo VARCHAR(30),@StudentId BIGINT,@FacultyId BIGINT,@AddDate DATETIME,@Description VARCHAR(max),@Remark VARCHAR(max),@Status VARCHAR(30),
             @CenterId BIGINT,@AddedBy BIGINT,@ModifyBy BIGINT,@ModifyDate DATETIME)
AS
BEGIN
IF (@ActionId=0)
BEGIN
	INSERT INTO StudentRenewal(EnrollmentNo,StudentId,FacultyId,AddDate,Description,Remark,Status,CenterId,AddedBy,ModifyBy,ModifyDate)
    VALUES (@EnrollmentNo,@StudentId,@FacultyId,@AddDate,@Description,@Remark,@Status,@CenterId,@AddedBy,@ModifyBy,@ModifyDate)
    select @@IDENTITY
END
ELSE
BEGIN
 UPDATE StudentRenewal SET Status=@Status,Description=@Description,Remark=@Remark,ModifyBy=@ModifyBy,ModifyDate=@ModifyDate WHERE RenewalId=@RenewalId 
 select @RenewalId
END
END


GO
/****** Object:  StoredProcedure [dbo].[USP_Students_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Students_IUD] (@ActionId INT,@StudentId BIGINT,@UniqueKey VARCHAR(300),@Name VARCHAR(600),@CentreId INT,@DOB DATETIME,@Contact1 VARCHAR(50),@Contact2 varchar(50),@EmailAddress varchar(300),@Address VARCHAR(MAX),
@StateId INT,@CityId INT,@GuardianName varchar(600),@Occupation varchar(300),@HasTransportFacility bit,@AddDate DATETIME,@AddedBy int,@ModifyDate DATETIME,@ModifyBy int,@IsActive bit,@IsDeleted bit)
AS
BEGIN
IF (@ActionId=0)
BEGIN
	IF NOT EXISTS(SELECT * FROM [Student] WHERE Name=@Name and Address=@Address and EmailAddress=@EmailAddress)
	  BEGIN
	  DECLARE @UNIQUEID nvarchar(15)
	  IF((SELECT COUNT(UniqueKey) FROM [DBO].[student] WHERE SUBSTRING(UniqueKey, 0, 4)='S'+Convert(VARCHAR,YEAR(GETDATE()) % 100))=0)
	  BEGIN
	   SET @UNIQUEID=(SELECT 'S'+CONVERT(VARCHAR,YEAR(GETDATE()) % 100) +'0000101')
	  END
	  ELSE
	  BEGIN
	  SET @UNIQUEID=(SELECT 'S'+CONVERT(VARCHAR,MAX(SUBSTRING(UniqueKey, PATINDEX('%[0-9]%', UniqueKey), LEN(UniqueKey)))+1) FROM student)
	  END
		INSERT INTO [DBMSwarVandana].[dbo].[Student] ([UniqueKey],[Name],[CenterId],[DOB],[Contact1],[Contact2],[EmailAddress],[StateId],[CityId],[Address],[GuardianName],[Occupation],[HasTransportFacility],[IsActive]
           ,[CreatedBy],[CreatedDate],[ModifyBy],[ModifyDate],[IsDeleted])
        VALUES (@UNIQUEID,@Name,@CentreId,@DOB,@Contact1,@Contact2,@EmailAddress,@StateId,@CityId,@Address,@GuardianName,@Occupation,@HasTransportFacility,@IsActive,@AddedBy,@AddDate,@ModifyBy,@ModifyDate,@IsDeleted)
			   SELECT @UNIQUEID
      END
    ELSE
      BEGIN
			SELECT '-1'
      END
END
ELSE
BEGIN
   UPDATE student SET [Name]=@Name,[DOB]=@DOB,[Contact1]=@Contact1,[Contact2]=@Contact2,[EmailAddress]=@EmailAddress,[StateId]=@StateId,[CityId]=@CityId,[Address]=@Address,[GuardianName]=@GuardianName,[Occupation]=@Occupation
   ,[HasTransportFacility]=@HasTransportFacility,[IsActive]=@IsActive,[ModifyBy]=@ModifyBy,[ModifyDate]=@ModifyDate,[IsDeleted]=@IsDeleted WHERE [UniqueKey]=@UniqueKey
   SELECT @UniqueKey
END
END

GO
/****** Object:  StoredProcedure [dbo].[USP_Users_IUD]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_Users_IUD] (@ActionId int,@UserId int,@FirstName VARCHAR(100),@LastName VARCHAR(100),@DOB DATETIME=null,@DOJ DATETIME=null,@ContactNumber VARCHAR(100),@EmailID VARCHAR(100),@CentreId INT,@Salary MONEY,
@RoleId int,@UserName VARCHAR(100),@Password VARCHAR(100),@Address VARCHAR(MAX),@StateId INT,@CityId INT,@AddDate DATETIME,@AddedBy INT,@ModifyDate DATETIME,@ModifyBy INT,@IsActive BIT,@IsDeleted BIT)
AS
BEGIN
if (@ActionId<0)
BEGIN
	UPDATE [Users] SET IsActive=0 WHERE UserId=@UserId
	SELECT @UserId
END
ELSE IF (@ActionId=0)
BEGIN
	IF NOT EXISTS(SELECT FirstName FROM [DBO].[Users] WHERE UserName=@UserName)
	BEGIN
		INSERT INTO [DBMSwarVandana].[dbo].[Users] ([FirstName],[LastName],[DOB],[DOJ],[ContactNumber],[EmailID],[CentreId],[Salary],[RoleId],[UserName],[Password],[StateId],[CityId],[Address],[AddDate],[AddedBy],[ModifyDate],[ModifyBy],[IsActive],IsDeleted)
        VALUES (@FirstName,@LastName,@DOB,@DOJ,@ContactNumber,@EmailID,@CentreId,@Salary,@RoleId,@UserName,@Password,@StateId,@CityId,@Address,@AddDate,@AddedBy,@ModifyDate,@ModifyBy,@IsActive,@IsDeleted)
	    SELECT @@IDENTITY
      END
      ELSE
      BEGIN
			SELECT -1
      END
END
ELSE IF (@ActionId>0)
BEGIN
	IF NOT EXISTS(SELECT FirstName FROM [Users] WHERE UserName=@UserName AND UserId NOT IN(@UserId))
	BEGIN
	UPDATE [DBMSwarVandana].[dbo].[Users] SET [FirstName] = @FirstName,[LastName] = @LastName,[DOB] = @DOB,[DOJ] = @DOJ,[ContactNumber] = @ContactNumber,[EmailID] = @EmailID,[CentreId] = @CentreId,[Salary] = @Salary,[RoleId] = @RoleId,[UserName] = @UserName
      ,[Password] = @Password,[StateId] = @StateId,[CityId] = @CityId,[Address] = @Address,[ModifyDate] = @ModifyDate,[ModifyBy] = @ModifyBy,IsDeleted=@IsDeleted WHERE UserId=@UserId
		SELECT @UserId
	END
	ELSE
		BEGIN
		SELECT -1
		END
END
END


GO
/****** Object:  StoredProcedure [dbo].[USP_UsersGetAll]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_UsersGetAll](@centerId bigint,@RowsPerPage INT = 20 ,@PageNumber INT = 1,@TotalPages INT=1 OUTPUT, @search varchar(300)='')
AS
BEGIN
SELECT * FROM (
			SELECT ROW_NUMBER() OVER (ORDER BY ModifyDate) AS RowNum,UserId,FirstName,LastName,DOB,DOJ,ContactNumber,EmailID,CentreId,Salary,RoleId,UserName,Password,StateId,CityId,Address,AddDate,AddedBy,
			ModifyDate,ModifyBy,IsActive,IsDeleted from [dbo].[Users]
			where IsActive=1 and isdeleted=0 and CentreId = @centerId AND(FirstName LIKE '%'+@search+'%'	OR LastName LIKE '%'+@search+'%' OR  StateId =(SELECT StateId from dbo.states where stateName like'%'+ @search+'%')
			OR CityId =(SELECT CityId from [dbo].[Cities] where CityNAme like'%'+ @search+'%')
			OR EmailID LIKE '%' + @search+'%' OR ContactNumber LIKE '%' + @search+'%' OR UserName LIKE '%' + @search+'%')) AS users
			WHERE users.RowNum BETWEEN ((@PageNumber-1)*@RowsPerPage)+1 AND @RowsPerPage*(@PageNumber)

			SELECT @TotalPages = (SELECT COUNT(UserId) FROM [dbo].[Users]  where IsActive=1 and isdeleted=0 and CentreId = @centerId AND(FirstName LIKE '%'+@search+'%'	OR LastName LIKE '%'+@search+'%' OR  StateId =(SELECT StateId from dbo.states where stateName like'%'+ @search+'%')
			OR CityId =(SELECT CityId from [dbo].[Cities] where CityNAme like'%'+ @search+'%')
			OR EmailID LIKE '%' + @search+'%' OR ContactNumber LIKE '%' + @search+'%' OR UserName LIKE '%' + @search+'%'))
END


GO
/****** Object:  StoredProcedure [dbo].[USP_UsersGetByUserId]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_UsersGetByUserId]
(@UserId int)
AS
BEGIN
SELECT [UserId]
      ,[FirstName]
      ,[LastName]
      ,[DOB]
      ,[DOJ]
      ,[ContactNumber]
      ,[EmailID]
      ,[CentreId]
      ,[Salary]
      ,[RoleId]
      ,[UserName]
      ,[Password]
      ,[StateId]
      ,[CityId]
      ,[Address]
      ,[AddDate]
      ,[AddedBy]
      ,[ModifyDate]
      ,[ModifyBy]
      ,[IsActive]
  FROM [DBMSwarVandana].[dbo].[Users] where UserId=@UserId
END
GO
/****** Object:  UserDefinedFunction [dbo].[Split]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Split](@String nvarchar(4000), @Delimiter char(1))RETURNS @Results TABLE (Items nvarchar(4000))
AS
BEGIN
DECLARE @INDEX INT
DECLARE @SLICE nvarchar(4000)
-- HAVE TO SET TO 1 SO IT DOESNT EQUAL Z
--     ERO FIRST TIME IN LOOP
SELECT @INDEX = 1
WHILE @INDEX !=0
BEGIN
-- GET THE INDEX OF THE FIRST OCCURENCE OF THE SPLIT CHARACTER
SELECT @INDEX = CHARINDEX(@Delimiter,@STRING)
-- NOW PUSH EVERYTHING TO THE LEFT OF IT INTO THE SLICE VARIABLE
IF @INDEX !=0
SELECT @SLICE = LEFT(@STRING,@INDEX - 1)
ELSE
SELECT @SLICE = @STRING
-- PUT THE ITEM INTO THE RESULTS SET
INSERT INTO @Results(Items) VALUES(@SLICE)
-- CHOP THE ITEM REMOVED OFF THE MAIN STRING
SELECT @STRING = RIGHT(@STRING,LEN(@STRING) - @INDEX)
-- BREAK OUT IF WE ARE DONE
IF LEN(@STRING) = 0 BREAK
END
RETURN
END



GO
/****** Object:  Table [dbo].[Batches]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Batches](
	[BatchId] [bigint] IDENTITY(1,1) NOT NULL,
	[Day] [int] NULL,
	[Timming] [varchar](30) NULL,
	[StudentLinit] [int] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyBy] [bigint] NULL,
	[ModifyDate] [datetime] NULL,
	[CenterId] [bigint] NULL,
 CONSTRAINT [PK_Batches] PRIMARY KEY CLUSTERED 
(
	[BatchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BudgetMaster]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BudgetMaster](
	[BudgetID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseFor] [int] NULL,
	[BudgetAmount] [money] NULL,
	[Month] [int] NULL,
	[Description] [varchar](max) NULL,
	[FinancialYear] [varchar](50) NULL,
	[CentreID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_BudgetMaster] PRIMARY KEY CLUSTERED 
(
	[BudgetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Centres]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Centres](
	[CentreId] [int] IDENTITY(1,1) NOT NULL,
	[CentreName] [varchar](100) NULL,
	[Address] [varchar](max) NULL,
	[StateId] [int] NULL,
	[CityId] [int] NULL,
	[CentreOpenDate] [datetime] NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Centres] PRIMARY KEY CLUSTERED 
(
	[CentreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cities](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[StateId] [int] NULL,
	[CityName] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Disciplines]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Disciplines](
	[DisciplineId] [int] IDENTITY(1,1) NOT NULL,
	[Discipline] [varchar](50) NULL,
	[Description] [varchar](max) NULL,
	[CentreID] [int] NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Disciplines] PRIMARY KEY CLUSTERED 
(
	[DisciplineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Enquiries]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Enquiries](
	[EnquiryId] [bigint] IDENTITY(1,1) NOT NULL,
	[EnquiryNumber] [varchar](50) NULL,
	[SourceId] [int] NULL,
	[EnquiryTypeId] [int] NULL,
	[ContactNumber] [varchar](50) NULL,
	[Name] [varchar](100) NULL,
	[DateOfEnquiry] [datetime] NULL,
	[Discipline] [int] NULL,
	[StateId] [int] NULL,
	[CityId] [int] NULL,
	[Address] [varchar](max) NULL,
	[AttendedBy] [int] NULL,
	[Demo] [bit] NULL,
	[RemarksByFaculty] [varchar](max) NULL,
	[StatusId] [int] NULL,
	[ProbableStudentFor] [int] NULL,
	[Gender] [int] NULL,
	[Age] [int] NULL,
	[Occupation] [varchar](50) NULL,
	[FinalComments] [varchar](max) NULL,
	[NoOfClasses] [int] NULL,
	[Package] [money] NULL,
	[RegistrationAmount] [money] NULL,
	[CentreId] [int] NULL,
	[IsEnquiryClosed] [bit] NULL,
	[FacultyID] [bigint] NULL,
	[EnquiryBy] [bigint] NULL,
	[TelephonicEnquiryId] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Enquiries] PRIMARY KEY CLUSTERED 
(
	[EnquiryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExamDetails]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamDetails](
	[ExamID] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentID] [bigint] NULL,
	[ExamName] [varchar](max) NULL,
	[ExamDate] [datetime] NULL,
	[FacultyID] [bigint] NULL,
	[ExamFees] [money] NULL,
	[Comments] [varchar](max) NULL,
	[ResultOfExam] [varchar](50) NULL,
	[CentreID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_ExamDetails] PRIMARY KEY CLUSTERED 
(
	[ExamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExpenseForMaster]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExpenseForMaster](
	[ExpenseForId] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseFor] [varchar](100) NULL,
	[ExpenseCode] [varchar](50) NULL,
 CONSTRAINT [PK_ExpenseForMaster] PRIMARY KEY CLUSTERED 
(
	[ExpenseForId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseAmount] [money] NULL,
	[ExpenseFor] [int] NULL,
	[Description] [varchar](max) NULL,
	[DateOfExpense] [datetime] NULL,
	[CentreID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyId] [bigint] IDENTITY(1,1) NOT NULL,
	[NameOfFaculty] [varchar](100) NULL,
	[EmailID] [varchar](100) NULL,
	[ContactNumber] [varchar](50) NULL,
	[Address] [varchar](max) NULL,
	[StateId] [int] NULL,
	[CityId] [int] NULL,
	[DOJ] [datetime] NULL,
	[Gender] [int] NULL,
	[Salary] [money] NULL,
	[SalaryRevision] [money] NULL,
	[DisciplineId] [int] NULL,
	[YearOfExperience] [int] NULL,
	[CentreId] [int] NULL,
	[Picture] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[DOB] [datetime] NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentDetails]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentDetails](
	[PaymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[EnrollmentId] [bigint] NOT NULL,
	[StudentId] [bigint] NOT NULL,
	[BankName] [nvarchar](50) NOT NULL,
	[PaymentMode] [int] NOT NULL,
	[PaymentDetails] [nvarchar](50) NULL,
	[DateOfPayment] [datetime] NULL,
	[AmountPaid] [money] NOT NULL,
	[DueDate] [datetime] NULL,
	[AddBy] [bigint] NULL,
	[AddDate] [datetime] NULL,
	[ModifyBy] [bigint] NULL,
	[ModifyDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sources]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sources](
	[SourceId] [int] IDENTITY(1,1) NOT NULL,
	[Source] [varchar](100) NULL,
	[Description] [varchar](max) NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Sources] PRIMARY KEY CLUSTERED 
(
	[SourceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[States]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[States](
	[StateId] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [bigint] IDENTITY(1,1) NOT NULL,
	[UniqueKey] [varchar](300) NULL,
	[Name] [varchar](600) NULL,
	[CenterId] [int] NULL,
	[DOB] [datetime] NULL,
	[Contact1] [varchar](50) NULL,
	[Contact2] [varchar](50) NULL,
	[EmailAddress] [varchar](300) NULL,
	[StateId] [int] NULL,
	[CityId] [int] NULL,
	[Address] [varchar](max) NULL,
	[GuardianName] [varchar](600) NULL,
	[Occupation] [varchar](300) NULL,
	[HasTransportFacility] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StudentAttendence]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAttendence](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BatchId] [bigint] NULL,
	[EnrollmentId] [bigint] NULL,
	[StuentId] [bigint] NULL,
	[AttendenceStatus] [int] NULL,
	[DateOfAttendence] [datetime] NULL,
	[AddDate] [datetime] NULL,
	[AddBy] [bigint] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [bigint] NULL,
 CONSTRAINT [PK_StudentAttendence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentBatchMapping]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentBatchMapping](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentId] [bigint] NULL,
	[EnrollmentId] [bigint] NULL,
	[BatchId] [nchar](10) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyBy] [bigint] NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_StudentBatchMapping] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentEnrollment]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StudentEnrollment](
	[EnrollmentId] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentId] [bigint] NULL,
	[DisciplineId] [int] NULL,
	[CourseAmount] [money] NULL,
	[RegistratonAmount] [money] NULL,
	[NoOfClasses] [int] NULL,
	[AmountPaid] [money] NULL,
	[SatrtDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifBy] [bigint] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[BankName] [nvarchar](50) NULL,
	[PaymentMode] [int] NULL,
	[PaymentDetails] [nvarchar](50) NULL,
	[EnqueryNo] [varchar](50) NULL,
	[IsRenewal] [bit] NULL,
 CONSTRAINT [PK_StudentEnrollment] PRIMARY KEY CLUSTERED 
(
	[EnrollmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StudentRemarks]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StudentRemarks](
	[RemarksID] [bigint] IDENTITY(1,1) NOT NULL,
	[FacultyID] [bigint] NULL,
	[StudentId] [bigint] NULL,
	[Remarks] [varchar](max) NULL,
	[DateOfRemarks] [datetime] NULL,
	[CentreID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_StudentRemarks] PRIMARY KEY CLUSTERED 
(
	[RemarksID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StudentRenewal]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StudentRenewal](
	[RenewalId] [bigint] IDENTITY(1,1) NOT NULL,
	[EnrollmentNo] [varchar](30) NULL,
	[StudentId] [bigint] NULL,
	[FacultyId] [bigint] NULL,
	[AddDate] [datetime] NULL,
	[Description] [varchar](max) NULL,
	[Remark] [varchar](max) NULL,
	[Status] [varchar](30) NULL,
	[CenterId] [bigint] NULL,
	[AddedBy] [bigint] NULL,
	[ModifyBy] [bigint] NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_StudentRenewal] PRIMARY KEY CLUSTERED 
(
	[RenewalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/15/2015 5:13:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[DOB] [datetime] NULL,
	[DOJ] [datetime] NULL,
	[ContactNumber] [varchar](50) NULL,
	[EmailID] [varchar](150) NULL,
	[CentreId] [int] NULL,
	[Salary] [money] NULL,
	[RoleId] [int] NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[StateId] [int] NULL,
	[CityId] [int] NULL,
	[Address] [varchar](max) NULL,
	[AddDate] [datetime] NULL,
	[AddedBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Batches] ON 

GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (1, 1, N'4:00 - 5:00', 100, 1, CAST(0x0000A4170032EFA8 AS DateTime), 1, CAST(0x0000A4170032EFA8 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (2, 1, N'5:00 - 6:00', 100, 1, CAST(0x0000A4170032FDCB AS DateTime), 1, CAST(0x0000A4170032FDCB AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (3, 1, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700330BCA AS DateTime), 1, CAST(0x0000A41700330BCA AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (4, 1, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (5, 3, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (6, 3, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (7, 3, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (8, 3, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (9, 4, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (10, 4, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (11, 4, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (12, 4, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (13, 1, N'4:00 - 5:00', 100, 2, CAST(0x0000A4170032EFA8 AS DateTime), 1, CAST(0x0000A4170032EFA8 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (14, 1, N'5:00 - 6:00', 100, 1, CAST(0x0000A4170032FDCB AS DateTime), 1, CAST(0x0000A4170032FDCB AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (15, 1, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700330BCA AS DateTime), 1, CAST(0x0000A41700330BCA AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (16, 1, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (17, 3, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (18, 3, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (19, 3, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (20, 3, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (21, 4, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (22, 4, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (23, 4, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (24, 4, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (25, 1, N'4:00 - 5:00', 100, 2, CAST(0x0000A4170032EFA8 AS DateTime), 1, CAST(0x0000A4170032EFA8 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (26, 1, N'5:00 - 6:00', 100, 1, CAST(0x0000A4170032FDCB AS DateTime), 1, CAST(0x0000A4170032FDCB AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (27, 1, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700330BCA AS DateTime), 1, CAST(0x0000A41700330BCA AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (28, 1, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (29, 3, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (30, 3, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (31, 3, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (32, 3, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (33, 4, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (34, 4, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (35, 4, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (36, 4, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (37, 5, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (38, 5, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (39, 5, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (40, 5, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (41, 5, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (42, 5, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (43, 5, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (44, 5, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (45, 5, N'4:00 - 5:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (46, 5, N'5:00 - 6:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (47, 5, N'6:00 - 7:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (48, 5, N'7:00 - 8:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (49, 6, N'10:00 - 11:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (50, 6, N'11:00 - 12:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (51, 6, N'12:00 - 1:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (52, 6, N'1:00 - 2:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (53, 6, N'10:00 - 11:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (54, 6, N'11:00 - 12:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (55, 6, N'12:00 - 1:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (56, 6, N'1:00 - 2:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (57, 6, N'10:00 - 11:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (58, 6, N'11:00 - 12:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (59, 6, N'12:00 - 1:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (60, 6, N'1:00 - 2:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (61, 7, N'10:00 - 11:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (62, 7, N'11:00 - 12:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (63, 7, N'12:00 - 1:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (64, 7, N'1:00 - 2:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 3)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (65, 7, N'10:00 - 11:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (66, 7, N'11:00 - 12:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (67, 7, N'12:00 - 1:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (68, 7, N'1:00 - 2:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 2)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (69, 7, N'10:00 - 11:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (70, 7, N'11:00 - 12:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (71, 7, N'12:00 - 1:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
INSERT [dbo].[Batches] ([BatchId], [Day], [Timming], [StudentLinit], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [CenterId]) VALUES (72, 7, N'1:00 - 2:00', 100, 1, CAST(0x0000A41700331A07 AS DateTime), 1, CAST(0x0000A41700331A07 AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Batches] OFF
GO
SET IDENTITY_INSERT [dbo].[BudgetMaster] ON 

GO
INSERT [dbo].[BudgetMaster] ([BudgetID], [ExpenseFor], [BudgetAmount], [Month], [Description], [FinancialYear], [CentreID], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [IsActive], [IsDeleted]) VALUES (1, 3, 12000.0000, 1, N'NA', N'2014 - 2015', 1, 1, CAST(0x0000A4210102F8A8 AS DateTime), 1, CAST(0x0000A4210102F8A8 AS DateTime), 1, 0)
GO
INSERT [dbo].[BudgetMaster] ([BudgetID], [ExpenseFor], [BudgetAmount], [Month], [Description], [FinancialYear], [CentreID], [CreatedBy], [CreatedOn], [ModifiedBy], [ModifiedOn], [IsActive], [IsDeleted]) VALUES (2, 5, 8000.0000, 1, N'NA', N'2014 - 2015', 1, 1, CAST(0x0000A42101034A04 AS DateTime), 1, CAST(0x0000A42101034A04 AS DateTime), 1, 0)
GO
SET IDENTITY_INSERT [dbo].[BudgetMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[Centres] ON 

GO
INSERT [dbo].[Centres] ([CentreId], [CentreName], [Address], [StateId], [CityId], [CentreOpenDate], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (1, N'Svar Vandana - Noida', N'A-181 Sector 48, Noida 201301.', 26, 427, CAST(0x0000A28700000000 AS DateTime), CAST(0x0000A3E9015662F6 AS DateTime), 1, CAST(0x0000A3E9015667BD AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Centres] ([CentreId], [CentreName], [Address], [StateId], [CityId], [CentreOpenDate], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (2, N'Svar Vandana', N' PK – 5, Kidzee Genius School, Sector 122, Noida 201301', 26, 427, CAST(0x0000A39900000000 AS DateTime), CAST(0x0000A3F60076AFFA AS DateTime), 1, CAST(0x0000A3F60076AFFA AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Centres] ([CentreId], [CentreName], [Address], [StateId], [CityId], [CentreOpenDate], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (3, N'Svar Vandana - Gurgaon ', N'SCO -70, Huda Market, Sector 40, Gurgaon', 8, 163, CAST(0x0000A39900000000 AS DateTime), CAST(0x0000A3FA0078A9EA AS DateTime), 1, CAST(0x0000A3FA0078A9EA AS DateTime), 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Centres] OFF
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (1, 1, N'Anantapur', CAST(0x0000A3F50011D49E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (2, 1, N'Chittoor', CAST(0x0000A3F50011E1ED AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (3, 1, N'East Godavari', CAST(0x0000A3F50011E994 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (4, 1, N'Guntur', CAST(0x0000A3F50011F2CA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (5, 1, N'YSR Kadapa', CAST(0x0000A3F50011FB52 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (6, 1, N'Krishna', CAST(0x0000A3F5001202DC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (7, 1, N'Kurnool', CAST(0x0000A3F500120901 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (8, 1, N'Prakasam', CAST(0x0000A3F500120EA3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (9, 1, N'Nellore', CAST(0x0000A3F500121D6D AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (10, 1, N'Srikakulam', CAST(0x0000A3F50012234F AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (11, 1, N'Visakhapatnam', CAST(0x0000A3F500122A6B AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (12, 1, N'Vizianagaram', CAST(0x0000A3F50012309A AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (13, 1, N'West Godavari', CAST(0x0000A3F5001237E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (14, 2, N'Anjaw', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (15, 2, N'Changlang', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (16, 2, N'East Kameng', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (17, 2, N'East Siang', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (18, 2, N'Lohit', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (19, 2, N'Longding', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (20, 2, N'Lower Subansiri', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (21, 2, N'Papum Pare', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (22, 2, N'Tawang', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (23, 2, N'Tirap', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (24, 2, N'Lower Dibang Valley', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (25, 2, N'Upper Siang', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (26, 2, N'Upper Subansiri', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (27, 2, N'West Kameng', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (28, 2, N'West Siang', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (29, 2, N'Upper Dibang Valley', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (30, 2, N'Kurung Kumey', CAST(0x0000A3F500152130 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (31, 3, N'Barpeta				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (32, 3, N'Bongaigaon			 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (33, 3, N'Cachar				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (34, 3, N'Darrang				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (35, 3, N'Dhemaji				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (36, 3, N'Dhubri				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (37, 3, N'Dibrugarh				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (38, 3, N'Goalpara				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (39, 3, N'Golaghat				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (40, 3, N'Hailakandi			 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (41, 3, N'Jorhat				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (42, 3, N'Karbi Anglong			 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (43, 3, N'Karimganj				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (44, 3, N'Kokrajhar				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (45, 3, N'Lakhimpur				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (46, 3, N'Morigaon				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (47, 3, N'Nagaon				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (48, 3, N'Nalbari				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (49, 3, N'Dima Hasao			 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (50, 3, N'Sivasagar				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (51, 3, N'Sonitpur				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (52, 3, N'Tinsukia				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (53, 3, N'Kamrup				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (54, 3, N'Kamrup Metropolitan	 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (55, 3, N'Baksa					 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (56, 3, N'Udalguri				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (57, 3, N'Chirang				 ', CAST(0x0000A3F50016EB43 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (58, 4, N'Araria ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (59, 4, N'Arwal ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (60, 4, N'Aurangabad ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (61, 4, N'Banka ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (62, 4, N'Begusarai ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (63, 4, N'Bhagalpur ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (64, 4, N'Bhojpur ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (65, 4, N'Buxar ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (66, 4, N'Darbhanga ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (67, 4, N'East Champaran ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (68, 4, N'Gaya ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (69, 4, N'Gopalganj ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (70, 4, N'Jamui ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (71, 4, N'Jehanabad ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (72, 4, N'Khagaria ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (73, 4, N'Kishanganj ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (74, 4, N'Kaimur ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (75, 4, N'Katihar ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (76, 4, N'Lakhisarai ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (77, 4, N'Madhubani ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (78, 4, N'Munger ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (79, 4, N'Madhepura ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (80, 4, N'Muzaffarpur ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (81, 4, N'Nalanda ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (82, 4, N'Nawada ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (83, 4, N'Patna ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (84, 4, N'Purnia ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (85, 4, N'Rohtas ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (86, 4, N'Saharsa ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (87, 4, N'Samastipur ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (88, 4, N'Sheohar ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (89, 4, N'Sheikhpura ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (90, 4, N'Saran ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (91, 4, N'Sitamarhi ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (92, 4, N'Supaul ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (93, 4, N'Siwan ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (94, 4, N'Vaishali ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (95, 4, N'West Champaran ', CAST(0x0000A3F5001919BC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (97, 5, N'Balod', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (98, 5, N'Baloda Bazar', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (99, 5, N'Balrampur', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (100, 5, N'Bastar', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (101, 5, N'Bemetara', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (102, 5, N'Bijapur', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (103, 5, N'Bilaspur', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (104, 5, N'Dantewada', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (105, 5, N'Dhamtari', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (106, 5, N'Durg', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (107, 5, N'Gariaband', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (108, 5, N'Jashpur', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (109, 5, N'Janjgir-Champa', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (110, 5, N'Kondagaon', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (111, 5, N'Korba', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (112, 5, N'Koriya', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (113, 5, N'Kanker', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (114, 5, N'Kabirdham', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (115, 5, N'Mahasamund', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (116, 5, N'Mungeli', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (117, 5, N'Narayanpur', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (118, 5, N'Raigarh', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (119, 5, N'Rajnandgaon', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (120, 5, N'Raipur', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (121, 5, N'Surajpur', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (122, 5, N'Sukma', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (123, 5, N'Surguja', CAST(0x0000A3F5002E2F98 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (124, 6, N'North Goa', CAST(0x0000A3F5002E97FC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (125, 6, N'South Goa', CAST(0x0000A3F5002E97FC AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (126, 7, N'Ahmedabad', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (127, 7, N'Amreli', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (128, 7, N'Anand', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (129, 7, N'Aravalli', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (130, 7, N'Banaskantha', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (131, 7, N'Bharuch', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (132, 7, N'Bhavnagar', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (133, 7, N'Botad', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (134, 7, N'Chhota Udaipur', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (135, 7, N'Dahod', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (136, 7, N'Dang', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (137, 7, N'Devbhoomi Dwarka', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (138, 7, N'Gandhinagar', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (139, 7, N'Gir Somnath', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (140, 7, N'Jamnagar', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (141, 7, N'Junagadh', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (142, 7, N'Kutch', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (143, 7, N'Kheda', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (144, 7, N'Mahisagar', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (145, 7, N'Mehsana', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (146, 7, N'Morbi', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (147, 7, N'Narmada', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (148, 7, N'Navsari', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (149, 7, N'Panchmahal', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (150, 7, N'Patan', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (151, 7, N'Porbandar', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (152, 7, N'Rajkot', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (153, 7, N'Sabarkantha', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (154, 7, N'Surat', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (155, 7, N'Surendranagar', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (156, 7, N'Tapi', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (157, 7, N'Vadodara', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (158, 7, N'Valsad', CAST(0x0000A3F5002EDDAB AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (159, 8, N'Ambala', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (160, 8, N'Bhiwani', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (161, 8, N'Faridabad', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (162, 8, N'Fatehabad', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (163, 8, N'Gurgaon', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (164, 8, N'Hisar', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (165, 8, N'Jhajjar', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (166, 8, N'Jind', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (167, 8, N'Kaithal', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (168, 8, N'Karnal', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (169, 8, N'Kurukshetra', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (170, 8, N'Mahendragarh', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (171, 8, N'Mewat', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (172, 8, N'Palwal', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (173, 8, N'Panchkula', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (174, 8, N'Panipat', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (175, 8, N'Rewari', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (176, 8, N'Rohtak', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (177, 8, N'Sirsa', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (178, 8, N'Sonipat', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (179, 8, N'Yamuna Nagar', CAST(0x0000A3F5002F51C3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (180, 9, N'Bilaspur', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (181, 9, N'Chamba', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (182, 9, N'Hamirpur', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (183, 9, N'Kangra', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (184, 9, N'Kinnaur', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (185, 9, N'Kullu', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (186, 9, N'Lahaul and Spiti', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (187, 9, N'Mandi', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (188, 9, N'Shimla', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (189, 9, N'Sirmaur', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (190, 9, N'Solan', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (191, 9, N'Una', CAST(0x0000A3F5003004F3 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (192, 12, N'Bagalkot', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (193, 12, N'Bengaluru Urban', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (194, 12, N'Bengaluru Rural', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (195, 12, N'Belagavi', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (196, 12, N'Ballari', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (197, 12, N'Bidar', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (198, 12, N'Vijayapura', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (199, 12, N'Chamarajanagar', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (200, 12, N'Chikballapur', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (201, 12, N'Chikkamagaluru', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (202, 12, N'Chitradurga', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (203, 12, N'Dakshina Kannada', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (204, 12, N'Davanagere', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (205, 12, N'Dharwad', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (206, 12, N'Gadag', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (207, 12, N'Kalaburagi', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (208, 12, N'Hassan', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (209, 12, N'Haveri', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (210, 12, N'Kodagu', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (211, 12, N'Kolar', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (212, 12, N'Koppal', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (213, 12, N'Mandya', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (214, 12, N'Mysuru', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (215, 12, N'Raichur', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (216, 12, N'Ramanagara', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (217, 12, N'Shivamogga', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (218, 12, N'Tumakuru', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (219, 12, N'Udupi', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (220, 12, N'Uttara Kannada', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (221, 12, N'Yadgir', CAST(0x0000A3F50030E7FA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (222, 13, N'Alappuzha', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (223, 13, N'Ernakulam', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (224, 13, N'Idukki', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (225, 13, N'Kannur', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (226, 13, N'Kasaragod', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (227, 13, N'Kollam', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (228, 13, N'Kottayam', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (229, 13, N'Kozhikode', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (230, 13, N'Malappuram', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (231, 13, N'Palakkad', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (232, 13, N'Pathanamthitta', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (233, 13, N'Thiruvananthapuram', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (234, 13, N'Thrissur', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (235, 13, N'Wayanad', CAST(0x0000A3F50031635E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (236, 15, N'Ahmednagar', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (237, 15, N'Akola', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (238, 15, N'Amravati', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (239, 15, N'Aurangabad', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (240, 15, N'Beed', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (241, 15, N'Bhandara', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (242, 15, N'Buldhana', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (243, 15, N'Chandrapur', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (244, 15, N'Dhule', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (245, 15, N'Gadchiroli', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (246, 15, N'Gondia', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (247, 15, N'Hingoli', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (248, 15, N'Jalgaon', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (249, 15, N'Jalna', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (250, 15, N'Kolhapur', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (251, 15, N'Latur', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (252, 15, N'Mumbai City', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (253, 15, N'Mumbai Suburban', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (254, 15, N'Nagpur', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (255, 15, N'Nanded', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (256, 15, N'Nandurbar', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (257, 15, N'Nashik', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (258, 15, N'Osmanabad', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (259, 15, N'Parbhani', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (260, 15, N'Pune', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (261, 15, N'Raigad', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (262, 15, N'Ratnagiri', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (263, 15, N'Sangli', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (264, 15, N'Satara', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (265, 15, N'Sindhudurg', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (266, 15, N'Solapur', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (267, 15, N'Thane', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (268, 15, N'Wardha', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (269, 15, N'Washim', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (270, 15, N'Yavatmal', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (271, 15, N'Palghar', CAST(0x0000A3F500325EE8 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (273, 16, N'Bishnupur', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (274, 16, N'Churachandpur', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (275, 16, N'Chandel', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (276, 16, N'Imphal East', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (277, 16, N'Senapati', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (278, 16, N'Tamenglong', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (279, 16, N'Thoubal', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (280, 16, N'Ukhrul', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (281, 16, N'Imphal West', CAST(0x0000A3F50033059E AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (282, 18, N'Aizawl', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (283, 18, N'Kolasib', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (284, 18, N'Lawngtlai', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (285, 18, N'Lunglei', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (286, 18, N'Mamit', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (287, 18, N'Saiha', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (288, 18, N'Serchhip', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (289, 18, N'Champhai', CAST(0x0000A3F50033D928 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (290, 20, N'Anugul', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (291, 20, N'Boudh', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (292, 20, N'Bhadrak', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (293, 20, N'Balangir', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (294, 20, N'Bargarh', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (295, 20, N'Balasore', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (296, 20, N'Cuttack', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (297, 20, N'Debagarh', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (298, 20, N'Dhenkanal', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (299, 20, N'Ganjam', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (300, 20, N'Gajapati', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (301, 20, N'Jharsuguda', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (302, 20, N'Jajapur', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (303, 20, N'Jagatsinghapur', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (304, 20, N'Khordha', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (305, 20, N'Kendujhar', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (306, 20, N'Kalahandi', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (307, 20, N'Kandhamal', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (308, 20, N'Koraput', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (309, 20, N'Kendrapara', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (310, 20, N'Malkangiri', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (311, 20, N'Mayurbhanj', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (312, 20, N'Nabarangpur', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (313, 20, N'Nuapada', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (314, 20, N'Nayagarh', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (315, 20, N'Puri', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (316, 20, N'Rayagada', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (317, 20, N'Sambalpur', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (318, 20, N'Subarnapur', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (319, 20, N'Sundargarh', CAST(0x0000A3F50034A146 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (321, 22, N'Ajmer', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (322, 22, N'Alwar', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (323, 22, N'Banswara', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (324, 22, N'Baran', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (325, 22, N'Barmer', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (326, 22, N'Bharatpur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (327, 22, N'Bhilwara', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (328, 22, N'Bikaner', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (329, 22, N'Bundi', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (330, 22, N'Chittorgarh', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (331, 22, N'Churu', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (332, 22, N'Dausa', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (333, 22, N'Dholpur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (334, 22, N'Dungarpur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (335, 22, N'Hanumangarh', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (336, 22, N'Jaipur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (337, 22, N'Jaisalmer', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (338, 22, N'Jalore', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (339, 22, N'Jhalawar', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (340, 22, N'Jhunjhunu', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (341, 22, N'Jodhpur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (342, 22, N'Karauli', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (343, 22, N'Kota', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (344, 22, N'Nagaur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (345, 22, N'Pali', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (346, 22, N'Pratapgarh', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (347, 22, N'Rajsamand', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (348, 22, N'Sawai Madhopur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (349, 22, N'Sikar', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (350, 22, N'Sirohi', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (351, 22, N'Sri Ganganagar', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (352, 22, N'Tonk', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (353, 22, N'Udaipur', CAST(0x0000A3F5003552E7 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (355, 23, N'East Sikkim', CAST(0x0000A3F5004A30B9 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (356, 23, N'North Sikkim', CAST(0x0000A3F5004A30B9 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (357, 23, N'South Sikkim', CAST(0x0000A3F5004A30B9 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (358, 23, N'West Sikkim', CAST(0x0000A3F5004A30B9 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (359, 24, N'Ariyalur', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (360, 24, N'Chennai', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (361, 24, N'Coimbatore', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (362, 24, N'Cuddalore', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (363, 24, N'Dharmapuri', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (364, 24, N'Dindigul', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (365, 24, N'Erode', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (366, 24, N'Kanchipuram', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (367, 24, N'Kanniyakumari', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (368, 24, N'Karur', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (369, 24, N'Krishnagiri', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (370, 24, N'Madurai', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (371, 24, N'Nagapattinam', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (372, 24, N'Namakkal', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (373, 24, N'The Nilgiris', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (374, 24, N'Perambalur', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (375, 24, N'Pudukkottai', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (376, 24, N'Ramanathapuram', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (377, 24, N'Salem', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (378, 24, N'Sivagangai', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (379, 24, N'Thanjavur', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (380, 24, N'Theni', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (381, 24, N'Thoothukudi', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (382, 24, N'Tiruchirappalli', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (383, 24, N'Thirunelveli', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (384, 24, N'Tiruppur', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (385, 24, N'Thiruvallur', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (386, 24, N'Tiruvannamalai', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (387, 24, N'Thiruvarur', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (388, 24, N'Vellore', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (389, 24, N'Villupuram', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (390, 24, N'Virudhunagar', CAST(0x0000A3F5004A79D2 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (391, 25, N'Adilabad', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (392, 25, N'Hyderabad', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (393, 25, N'Karimnagar', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (394, 25, N'Khammam', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (395, 25, N'Mahbubnagar', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (396, 25, N'Medak', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (397, 25, N'Nalgonda', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (398, 25, N'Nizamabad', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (399, 25, N'Rangareddy', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (400, 25, N'Warangal', CAST(0x0000A3F5004AAD08 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (401, 26, N'Agra', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (402, 26, N'Allahabad', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (403, 26, N'Aligarh', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (404, 26, N'Ambedkar Nagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (405, 26, N'Auraiya', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (406, 26, N'Azamgarh', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (407, 26, N'Barabanki', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (408, 26, N'Badaun', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (409, 26, N'Bahraich', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (410, 26, N'Bijnor', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (411, 26, N'Ballia', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (412, 26, N'Sambhal', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (413, 26, N'Banda District', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (414, 26, N'Balrampur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (415, 26, N'Bareilly', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (416, 26, N'Basti', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (417, 26, N'Bulandshahr', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (418, 26, N'Chandauli', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (419, 26, N'Chitrakoot', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (420, 26, N'Deoria', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (421, 26, N'Etah', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (422, 26, N'Etawah', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (423, 26, N'Firozabad', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (424, 26, N'Farrukhabad', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (425, 26, N'Fatehpur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (426, 26, N'Faizabad', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (427, 26, N'Gautam Buddha Nagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (428, 26, N'Gonda', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (429, 26, N'Ghazipur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (430, 26, N'Gorkakhpur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (431, 26, N'Ghaziabad', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (432, 26, N'Hamirpur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (433, 26, N'Hardoi', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (434, 26, N'Mahamaya Nagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (435, 26, N'Jhansi', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (436, 26, N'Amroha', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (437, 26, N'Jaunpur District', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (438, 26, N'Kanpur Dehat', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (439, 26, N'Kannauj', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (440, 26, N'Kanpur Nagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (441, 26, N'Kanshi Ram Nagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (442, 26, N'Kaushambi', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (443, 26, N'Kushinagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (444, 26, N'Lalitpur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (445, 26, N'Lakhimpur Kheri', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (446, 26, N'Lucknow', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (447, 26, N'Mau', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (448, 26, N'Meerut', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (449, 26, N'Maharajganj', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (450, 26, N'Mahoba', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (451, 26, N'Mirzapur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (452, 26, N'Moradabad', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (453, 26, N'Mainpuri', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (454, 26, N'Mathura', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (455, 26, N'Muzaffarnagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (456, 26, N'Pilibhit', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (457, 26, N'Pratapgarh', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (458, 26, N'Rampur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (459, 26, N'Rae Bareli', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (460, 26, N'Saharanpur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (461, 26, N'Sitapur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (462, 26, N'Shahjahanpur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (463, 26, N'Shamli', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (464, 26, N'Siddharthnagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (465, 26, N'Sonbhadra', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (466, 26, N'Sant Ravidas Nagar', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (467, 26, N'Sultanpur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (468, 26, N'Shravasti', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (469, 26, N'Unnao', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (470, 26, N'Varanasi', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (471, 26, N'Hapur', CAST(0x0000A3F5004BE802 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (472, 27, N'Almora', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (473, 27, N'Bageshwar', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (474, 27, N'Chamoli', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (475, 27, N'Champawat', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (476, 27, N'Dehradun', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (477, 27, N'Haridwar', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (478, 27, N'Nainital', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (479, 27, N'Pauri Garhwal', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (480, 27, N'Pithoragarh', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (481, 27, N'Rudraprayag', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (482, 27, N'Tehri Garhwal', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (483, 27, N'Udham Singh Nagar', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (484, 27, N'Uttarkashi', CAST(0x0000A3F5004C7EEA AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (485, 28, N'Dhalai', CAST(0x0000A3F5004CF221 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (486, 28, N'North Tripura', CAST(0x0000A3F5004CF221 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (487, 28, N'South Tripura', CAST(0x0000A3F5004CF221 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (488, 28, N'West Tripura', CAST(0x0000A3F5004CF221 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (489, 29, N'Alipurduar', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (490, 29, N'Bankura', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (491, 29, N'Bardhaman', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (492, 29, N'Birbhum', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (493, 29, N'Cooch Behar', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (494, 29, N'Darjeeling', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (495, 29, N'East Midnapore', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (496, 29, N'Hooghly', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (497, 29, N'Howrah', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (498, 29, N'Jalpaiguri', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (499, 29, N'Kolkata', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (500, 29, N'Malda', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (501, 29, N'Murshidabad', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (502, 29, N'Nadia', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (503, 29, N'North 24 Parganas', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (504, 29, N'North Dinajpur', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (505, 29, N'Purulia', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (506, 29, N'South 24 Parganas', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (507, 29, N'South Dinajpur', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (508, 29, N'West Midnapore', CAST(0x0000A3F5004D4826 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (509, 36, N'New Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (510, 36, N'North Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (511, 36, N'North West Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (512, 36, N'West Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (513, 36, N'South West Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (514, 36, N'South Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (515, 36, N'South East Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (516, 36, N'Central Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (517, 36, N'North East Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (518, 36, N'Shahdara', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
INSERT [dbo].[Cities] ([CityId], [StateId], [CityName], [AddDate], [AddedBy], [IsActive]) VALUES (519, 36, N'East Delhi', CAST(0x0000A3F5004DC286 AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Disciplines] ON 

GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (1, N'DRUM', N'DRUM', 1, CAST(0x0000A3EB0086EDE7 AS DateTime), 1, CAST(0x0000A3FB00B8A257 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (2, N'VOCAL', N'VOCAL', 1, CAST(0x0000A3EB0086F5DE AS DateTime), 1, CAST(0x0000A3FB00B82654 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (4, N'KEYBOARD', N'KEYBOARD', 1, CAST(0x0000A3FB00B83D5F AS DateTime), 1, CAST(0x0000A3FB00B83D5F AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (5, N'KATHAK', N'KATHAK', 1, CAST(0x0000A3FB00B845FA AS DateTime), 1, CAST(0x0000A3FB00B845FA AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (6, N'Western Dance', N'Western Dance', 1, CAST(0x0000A3FB00B851BA AS DateTime), 1, CAST(0x0000A3FB00B851BA AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (7, N'Guitar', N'Guitar', 1, CAST(0x0000A3FB00B86481 AS DateTime), 1, CAST(0x0000A3FB00B86481 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (8, N'Drawing', N'Drawing', 2, CAST(0x0000A3FB00B86FC0 AS DateTime), 1, CAST(0x0000A3FB00B86FC0 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Disciplines] ([DisciplineId], [Discipline], [Description], [CentreID], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (9, N'Violin', N'Violin', 2, CAST(0x0000A3FB00B87D3B AS DateTime), 1, CAST(0x0000A3FB00B87D3B AS DateTime), 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Disciplines] OFF
GO
SET IDENTITY_INSERT [dbo].[Enquiries] ON 

GO
INSERT [dbo].[Enquiries] ([EnquiryId], [EnquiryNumber], [SourceId], [EnquiryTypeId], [ContactNumber], [Name], [DateOfEnquiry], [Discipline], [StateId], [CityId], [Address], [AttendedBy], [Demo], [RemarksByFaculty], [StatusId], [ProbableStudentFor], [Gender], [Age], [Occupation], [FinalComments], [NoOfClasses], [Package], [RegistrationAmount], [CentreId], [IsEnquiryClosed], [FacultyID], [EnquiryBy], [TelephonicEnquiryId], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (1, N'Jan15-1', 1, 2, N'9632587401', N'Rakesh Kumar', CAST(0x0000A42100000000 AS DateTime), 1, 26, 427, N'Noida Sec-48', 0, 0, N'', 3, 0, 0, 0, N'', N'Looking for lower fee.', 0, 0.0000, 0.0000, 1, 0, 0, NULL, N'', CAST(0x0000A42100CBB7CD AS DateTime), 1, CAST(0x0000A42100CBB7CD AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Enquiries] ([EnquiryId], [EnquiryNumber], [SourceId], [EnquiryTypeId], [ContactNumber], [Name], [DateOfEnquiry], [Discipline], [StateId], [CityId], [Address], [AttendedBy], [Demo], [RemarksByFaculty], [StatusId], [ProbableStudentFor], [Gender], [Age], [Occupation], [FinalComments], [NoOfClasses], [Package], [RegistrationAmount], [CentreId], [IsEnquiryClosed], [FacultyID], [EnquiryBy], [TelephonicEnquiryId], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (2, N'Jan15-2', 2, 2, N'9874563210', N'Vikas Sha', CAST(0x0000A42100000000 AS DateTime), 2, 8, 161, N'NA', 0, 0, N'', 2, 0, 0, 0, N'', N'Call After 2 Days.', 0, 0.0000, 0.0000, 1, 0, 0, NULL, N'', CAST(0x0000A42100CEA65C AS DateTime), 1, CAST(0x0000A42100E48E32 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Enquiries] ([EnquiryId], [EnquiryNumber], [SourceId], [EnquiryTypeId], [ContactNumber], [Name], [DateOfEnquiry], [Discipline], [StateId], [CityId], [Address], [AttendedBy], [Demo], [RemarksByFaculty], [StatusId], [ProbableStudentFor], [Gender], [Age], [Occupation], [FinalComments], [NoOfClasses], [Package], [RegistrationAmount], [CentreId], [IsEnquiryClosed], [FacultyID], [EnquiryBy], [TelephonicEnquiryId], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (3, N'Jan15-3', 2, 1, N'9874563210', N'Vikas Sha', CAST(0x0000A42100000000 AS DateTime), 2, 8, 161, N'NA', 6, 1, N'much interested.', 3, 1, 1, 22, N'Business', N'Call After 2 Days', 10, 10000.0000, 1000.0000, 1, 0, 2, NULL, N'jan15-2', CAST(0x0000A42100DEF06F AS DateTime), 1, CAST(0x0000A42100DEF06F AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Enquiries] ([EnquiryId], [EnquiryNumber], [SourceId], [EnquiryTypeId], [ContactNumber], [Name], [DateOfEnquiry], [Discipline], [StateId], [CityId], [Address], [AttendedBy], [Demo], [RemarksByFaculty], [StatusId], [ProbableStudentFor], [Gender], [Age], [Occupation], [FinalComments], [NoOfClasses], [Package], [RegistrationAmount], [CentreId], [IsEnquiryClosed], [FacultyID], [EnquiryBy], [TelephonicEnquiryId], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (4, N'Jan15-4', 5, 1, N'9654783210', N'Amit Kumar', CAST(0x0000A42100000000 AS DateTime), 4, 26, 427, N'Noida Sec-22', 3, 0, NULL, 2, 2, 1, 19, N'Student', N'NA..', 12, 12000.0000, 1000.0000, 1, 0, 0, NULL, NULL, CAST(0x0000A42100E25FE5 AS DateTime), 1, CAST(0x0000A42100E732BA AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Enquiries] ([EnquiryId], [EnquiryNumber], [SourceId], [EnquiryTypeId], [ContactNumber], [Name], [DateOfEnquiry], [Discipline], [StateId], [CityId], [Address], [AttendedBy], [Demo], [RemarksByFaculty], [StatusId], [ProbableStudentFor], [Gender], [Age], [Occupation], [FinalComments], [NoOfClasses], [Package], [RegistrationAmount], [CentreId], [IsEnquiryClosed], [FacultyID], [EnquiryBy], [TelephonicEnquiryId], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (5, N'Jan15-5', 6, 1, N'8974023164', N'Akash Singh', CAST(0x0000A42100000000 AS DateTime), 5, 26, 427, N'Noida sec -30', 6, 1, N'Good Demo given', 3, 2, 2, 12, N'Student', N'NA', 10, 10000.0000, 1000.0000, 1, 0, 2, NULL, NULL, CAST(0x0000A42100E83317 AS DateTime), 1, CAST(0x0000A42100E83317 AS DateTime), 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Enquiries] OFF
GO
SET IDENTITY_INSERT [dbo].[ExpenseForMaster] ON 

GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (1, N'Coffee/Tea Machine', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (2, N'Water & glass', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (3, N'Generator Diesel', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (4, N'Stationary', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (5, N'Phone Bill', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (6, N'Pick & Drop Diesel', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (7, N'Conveyance', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (8, N'Pamphlet distribution', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (9, N'Telephone', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (10, N'Office Products', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (11, N'Maintenance & Upkeep', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (12, N'Lunch', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (13, N'Contigencies', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (14, N'Event', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (15, N'Pamphlet printing', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (16, N'Hoardings', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (17, N'Electricity', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (18, N'Ads', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (19, N'Marketing', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (20, N'Canopy', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (21, N'DG Hiring', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (22, N'Rent', NULL)
GO
INSERT [dbo].[ExpenseForMaster] ([ExpenseForId], [ExpenseFor], [ExpenseCode]) VALUES (23, N'Salaries', NULL)
GO
SET IDENTITY_INSERT [dbo].[ExpenseForMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[Expenses] ON 

GO
INSERT [dbo].[Expenses] ([ExpenseID], [ExpenseAmount], [ExpenseFor], [Description], [DateOfExpense], [CentreID], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [IsActive], [IsDeleted]) VALUES (1, 3000.0000, 3, N'NA', CAST(0x0000A42000000000 AS DateTime), 1, CAST(0x0000A42101031EAC AS DateTime), 1, CAST(0x0000A42101031EAC AS DateTime), 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Expenses] OFF
GO
SET IDENTITY_INSERT [dbo].[Faculties] ON 

GO
INSERT [dbo].[Faculties] ([FacultyId], [NameOfFaculty], [EmailID], [ContactNumber], [Address], [StateId], [CityId], [DOJ], [Gender], [Salary], [SalaryRevision], [DisciplineId], [YearOfExperience], [CentreId], [Picture], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted], [DOB]) VALUES (1, N'afdfasdf', NULL, N'9811694229', N'sad saaDF dsdf f', 1, 1, CAST(0x0000A3FF00000000 AS DateTime), 1, 12000.0000, 15000.0000, 2, 11, 0, N'8b26f77e-de4a-4e00-aa23-7e3aa8f9f2f1.jpg', CAST(0x0000A3EB015C2FE0 AS DateTime), 1, CAST(0x0000A3EB015C2FE0 AS DateTime), 1, 1, 0, CAST(0x0000A3EB015C2FE0 AS DateTime))
GO
INSERT [dbo].[Faculties] ([FacultyId], [NameOfFaculty], [EmailID], [ContactNumber], [Address], [StateId], [CityId], [DOJ], [Gender], [Salary], [SalaryRevision], [DisciplineId], [YearOfExperience], [CentreId], [Picture], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted], [DOB]) VALUES (2, N'Abhishek', N'atul@gmail.com', N'9811694229', N'H.NO-302,Tower-2,Officer colony', 26, 401, CAST(0x0000A3EF00000000 AS DateTime), 1, 10000.0000, 0.0000, 1, 2, 1, N'33d0604f-7606-46a5-90dd-022a6c89f60e.jpg', CAST(0x0000A42100F9A9F9 AS DateTime), 1, CAST(0x0000A42100F9A9F9 AS DateTime), 1, 1, 0, CAST(0x000081AD015C2FE0 AS DateTime))
GO
INSERT [dbo].[Faculties] ([FacultyId], [NameOfFaculty], [EmailID], [ContactNumber], [Address], [StateId], [CityId], [DOJ], [Gender], [Salary], [SalaryRevision], [DisciplineId], [YearOfExperience], [CentreId], [Picture], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted], [DOB]) VALUES (3, N'Test', N'abhi@gmail.com', N'9874563201', N'adfghjgfjkhkjhlk', 6, 124, CAST(0x0000A3FF00000000 AS DateTime), 1, 0.0000, 0.0000, 1, 2, 1, N'', CAST(0x0000A3F800A53E45 AS DateTime), 1, CAST(0x0000A3F800A53E45 AS DateTime), 1, 1, 1, CAST(0x0000A3EB015C2FE0 AS DateTime))
GO
INSERT [dbo].[Faculties] ([FacultyId], [NameOfFaculty], [EmailID], [ContactNumber], [Address], [StateId], [CityId], [DOJ], [Gender], [Salary], [SalaryRevision], [DisciplineId], [YearOfExperience], [CentreId], [Picture], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted], [DOB]) VALUES (4, N'Gaurav Sharma', N'gaurav@yahoo.com', N'9638527410', N'NA', 26, 401, CAST(0x0000A3F500000000 AS DateTime), 1, 8000.0000, 0.0000, 1, 5, 3, N'', CAST(0x0000A3FD0116BD36 AS DateTime), 5, CAST(0x0000A3FD0116BD36 AS DateTime), 5, 1, 0, CAST(0x0000A3EB015C2FE0 AS DateTime))
GO
INSERT [dbo].[Faculties] ([FacultyId], [NameOfFaculty], [EmailID], [ContactNumber], [Address], [StateId], [CityId], [DOJ], [Gender], [Salary], [SalaryRevision], [DisciplineId], [YearOfExperience], [CentreId], [Picture], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted], [DOB]) VALUES (5, N'Rajeev Kumar', N'rajeev@yahoo.com', N'8529631470', N'NA', 4, 59, CAST(0x0000A3F400000000 AS DateTime), 1, 9000.0000, 0.0000, 2, 2, 3, N'', CAST(0x0000A3FE00C67CDC AS DateTime), 5, CAST(0x0000A3FE00C67CDC AS DateTime), 5, 1, 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[Faculties] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentDetails] ON 

GO
INSERT [dbo].[PaymentDetails] ([PaymentId], [EnrollmentId], [StudentId], [BankName], [PaymentMode], [PaymentDetails], [DateOfPayment], [AmountPaid], [DueDate], [AddBy], [AddDate], [ModifyBy], [ModifyDate]) VALUES (1, 1, 1, N'NA', 1, N'NA', CAST(0x0000A4210101D7BD AS DateTime), 4000.0000, CAST(0x0000A42800000000 AS DateTime), 1, CAST(0x0000A4210101D7BD AS DateTime), 1, CAST(0x0000A4210101D7BD AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[PaymentDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Sources] ON 

GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (1, N'Just dial', N'Just dial', CAST(0x0000A3EB007EAF6B AS DateTime), 1, CAST(0x0000A3EB007EAF6B AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (2, N'My City', N'My City', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (5, N'Pamphleting', N'Pamphleting', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (6, N'Newspapers Ads', N'Newspapers Ads', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (7, N'Newspaper news', N'Newspaper news', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (8, N'Internet', N'Internet', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (9, N'Mall', N'mall', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (10, N'Canopy', N'Canopy', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (11, N'Events', N'Events', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Sources] ([SourceId], [Source], [Description], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (12, N'other', N'other', CAST(0x0000A3EB007EC0C3 AS DateTime), 1, CAST(0x0000A3EB007EC0C3 AS DateTime), 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Sources] OFF
GO
SET IDENTITY_INSERT [dbo].[States] ON 

GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (1, N'Andhra Pradesh', CAST(0x0000A3F5000F35B7 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (2, N'Arunachal Pradesh', CAST(0x0000A3F5000F4084 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (3, N'Assam', CAST(0x0000A3F5000F4D37 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (4, N'Bihar', CAST(0x0000A3F5000F5D63 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (5, N'Chhattisgarh', CAST(0x0000A3F5000F6BC4 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (6, N'Goa', CAST(0x0000A3F5000F7300 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (7, N'Gujarat', CAST(0x0000A3F5000F7BA0 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (8, N'Haryana', CAST(0x0000A3F5000F8270 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (9, N'Himachal Pradesh', CAST(0x0000A3F5000F8A5A AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (10, N'Jammu and Kashmir', CAST(0x0000A3F5000F942D AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (11, N'Jharkhand', CAST(0x0000A3F5000F9D8F AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (12, N'Karnataka', CAST(0x0000A3F5000FA692 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (13, N'Kerala', CAST(0x0000A3F5000FAD15 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (14, N'Madhya Pradesh', CAST(0x0000A3F5000FB4ED AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (15, N'Maharashtra', CAST(0x0000A3F5000FBF15 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (16, N'Manipur', CAST(0x0000A3F5000FC72A AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (17, N'Meghalaya', CAST(0x0000A3F5000FCD53 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (18, N'Mizoram', CAST(0x0000A3F5000FD329 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (19, N'Nagaland', CAST(0x0000A3F5000FD98F AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (20, N'Odisha', CAST(0x0000A3F5000FDF45 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (21, N'Punjab', CAST(0x0000A3F5000FE721 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (22, N'Rajasthan', CAST(0x0000A3F5000FEF97 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (23, N'Sikkim', CAST(0x0000A3F5000FF5A8 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (24, N'Tamil Nadu', CAST(0x0000A3F5000FFBAD AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (25, N'Telangana', CAST(0x0000A3F500100525 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (26, N'Uttar Pradesh', CAST(0x0000A3F500100C53 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (27, N'Uttarakhand', CAST(0x0000A3F50010151C AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (28, N'Tripura', CAST(0x0000A3F500101D0F AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (29, N'West Bengal', CAST(0x0000A3F5001023F1 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (30, N'Andaman and Nicobar', CAST(0x0000A3F500102F50 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (31, N'Chandigarh', CAST(0x0000A3F500103B9D AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (32, N'Dadra and Nagar Haveli', CAST(0x0000A3F500104695 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (33, N'Daman and Diu', CAST(0x0000A3F50010528B AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (34, N'Lakshadweep', CAST(0x0000A3F500105B84 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (35, N'Puducherry', CAST(0x0000A3F500107190 AS DateTime), 1, 1)
GO
INSERT [dbo].[States] ([StateId], [StateName], [AddDate], [AddedBy], [IsActive]) VALUES (36, N'Delhi', CAST(0x0000A3F500109926 AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[States] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

GO
INSERT [dbo].[Student] ([StudentId], [UniqueKey], [Name], [CenterId], [DOB], [Contact1], [Contact2], [EmailAddress], [StateId], [CityId], [Address], [GuardianName], [Occupation], [HasTransportFacility], [IsActive], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate], [IsDeleted]) VALUES (1, N'S150000101', N'Vikas Sha', 1, CAST(0x00009B1A00000000 AS DateTime), N'9865740321', NULL, N'vikas.sha@gmail.com', 26, 427, N'noida sec-48', N'Mr. Roshan Sha', N'Business', 0, 1, 1, CAST(0x0000A42100F29185 AS DateTime), 1, CAST(0x0000A42100F29185 AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentBatchMapping] ON 

GO
INSERT [dbo].[StudentBatchMapping] ([ID], [StudentId], [EnrollmentId], [BatchId], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate]) VALUES (1, 1, 1, N'1         ', 1, CAST(0x0000A4210101D834 AS DateTime), 1, CAST(0x0000A4210101D834 AS DateTime))
GO
INSERT [dbo].[StudentBatchMapping] ([ID], [StudentId], [EnrollmentId], [BatchId], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate]) VALUES (2, 1, 1, N'2         ', 1, CAST(0x0000A4210101D834 AS DateTime), 1, CAST(0x0000A4210101D834 AS DateTime))
GO
INSERT [dbo].[StudentBatchMapping] ([ID], [StudentId], [EnrollmentId], [BatchId], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate]) VALUES (3, 1, 1, N'5         ', 1, CAST(0x0000A4210101D834 AS DateTime), 1, CAST(0x0000A4210101D834 AS DateTime))
GO
INSERT [dbo].[StudentBatchMapping] ([ID], [StudentId], [EnrollmentId], [BatchId], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate]) VALUES (4, 1, 1, N'6         ', 1, CAST(0x0000A4210101D834 AS DateTime), 1, CAST(0x0000A4210101D834 AS DateTime))
GO
INSERT [dbo].[StudentBatchMapping] ([ID], [StudentId], [EnrollmentId], [BatchId], [CreatedBy], [CreatedDate], [ModifyBy], [ModifyDate]) VALUES (5, 1, 1, N'9         ', 1, CAST(0x0000A4210101D834 AS DateTime), 1, CAST(0x0000A4210101D834 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[StudentBatchMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentEnrollment] ON 

GO
INSERT [dbo].[StudentEnrollment] ([EnrollmentId], [StudentId], [DisciplineId], [CourseAmount], [RegistratonAmount], [NoOfClasses], [AmountPaid], [SatrtDate], [EndDate], [CreatedDate], [CreatedBy], [ModifyDate], [ModifBy], [IsActive], [IsDeleted], [BankName], [PaymentMode], [PaymentDetails], [EnqueryNo], [IsRenewal]) VALUES (1, 1, 1, 12000.0000, 1000.0000, 12, 3000.0000, CAST(0x0000A42200000000 AS DateTime), CAST(0x0000A43D00000000 AS DateTime), CAST(0x0000A4210101D7BD AS DateTime), 1, CAST(0x0000A4210101D7BD AS DateTime), 1, 1, 0, N'NA', 1, N'NA', N'Jan15-3', 0)
GO
SET IDENTITY_INSERT [dbo].[StudentEnrollment] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [DOB], [DOJ], [ContactNumber], [EmailID], [CentreId], [Salary], [RoleId], [UserName], [Password], [StateId], [CityId], [Address], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (1, N'Super', N'Admin', CAST(0x0000A3E700A6A650 AS DateTime), CAST(0x0000A3E700A6A650 AS DateTime), N'01234567', N'mohitdagar80@gmail.com', 0, 0.0000, 3, N'superadmin', N'123', 23, 12, N'1292', CAST(0x0000A3E700A6A650 AS DateTime), 1, CAST(0x0000A3E700A6A650 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [DOB], [DOJ], [ContactNumber], [EmailID], [CentreId], [Salary], [RoleId], [UserName], [Password], [StateId], [CityId], [Address], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (3, N'Abhi', N'Kapoor', CAST(0x0000831500000000 AS DateTime), CAST(0x0000A27D00000000 AS DateTime), N'8860307991', N'abhi@swarvandana.com', 1, 15000.0000, 2, N'abhi', N'abhi@123', 26, 427, N'sec-58 ,Noida ', CAST(0x0000A3FA00C52913 AS DateTime), 1, CAST(0x0000A40A011056CF AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [DOB], [DOJ], [ContactNumber], [EmailID], [CentreId], [Salary], [RoleId], [UserName], [Password], [StateId], [CityId], [Address], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (4, N'Akanksha', N'Yadav', CAST(0x00007DAA00000000 AS DateTime), CAST(0x0000A39900000000 AS DateTime), N'7838886116', N'akanksha@swarvandana.com', 2, 20000.0000, 2, N'akanksha', N'akanksha@123', 26, 427, N'NA', CAST(0x0000A3FA00C7CFA5 AS DateTime), 1, CAST(0x0000A3FA00C7CFA5 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [DOB], [DOJ], [ContactNumber], [EmailID], [CentreId], [Salary], [RoleId], [UserName], [Password], [StateId], [CityId], [Address], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (5, N'Chetan', N'Kapoor', CAST(0x0000801A00000000 AS DateTime), CAST(0x0000A3B300000000 AS DateTime), N'9643250627', N'chetan@swarvandana.com', 3, 20000.0000, 2, N'chetan', N'chetan@123', 8, 163, N'NA', CAST(0x0000A3FA00C89BA0 AS DateTime), 1, CAST(0x0000A3FA00C89BA0 AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [DOB], [DOJ], [ContactNumber], [EmailID], [CentreId], [Salary], [RoleId], [UserName], [Password], [StateId], [CityId], [Address], [AddDate], [AddedBy], [ModifyDate], [ModifyBy], [IsActive], [IsDeleted]) VALUES (6, N'Ravi', N'Sharma', CAST(0x00008E8E00000000 AS DateTime), CAST(0x0000A40300000000 AS DateTime), N'2589631470', N'abc@yahoo.com', 1, 6000.0000, 1, N'ravi', N'ravi@123', 26, 401, N'No address.', CAST(0x0000A40A0121CC23 AS DateTime), 1, CAST(0x0000A40A0122179D AS DateTime), 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [DBMSwarVandana] SET  READ_WRITE 
GO
