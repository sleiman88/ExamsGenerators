USE [ExamsGenerator_DB]

CREATE TABLE [dbo].[ExamsType_tbl](
	[Id_ExamsType] int IDENTITY(1,1) PRIMARY KEY,
	[Name_ExamsType] [varchar](50) NULL
	)


CREATE TABLE [dbo].[TrueFalse_tbl](
	[Id_TrueFalseQuest] int IDENTITY(1,1) PRIMARY KEY,
	[Quest_TrueFalseQuest] [varchar](200) NULL,
	[Answer_TrueFalseQuest] [varchar](200) NULL,
	[Id_ExamsType_TrueFalseQuest] [numeric](18, 0) NOT NULL)
 



CREATE TABLE [dbo].[QCMQuest_tbl](
	[Id_QCMQuest]int IDENTITY(1,1) PRIMARY KEY,
	[Quest_QCMQuest] [varchar](200) NULL,
	[ChoiceA_QCMQuest] [varchar](50) NULL,
	[ChoiceB_QCMQuest] [varchar](50) NULL,
	[ChoiceC_QCMQuest] [varchar](50) NULL,
	[ChoiceD_QCMQuest] [varchar](50) NULL,
	[Answer_QCMQuest] [varchar](50) NULL,
	[Id_ExamsType_QCMQuest] [numeric](18, 0) NOT NULL)
 


CREATE TABLE [dbo].[Exams_tbl](
	[Id_Exams] int IDENTITY(1,1) PRIMARY KEY,
	[Name_Exams] [varchar](50) NULL,
	[Id_ExamsType_Exams] [numeric](18, 0) NULL,
	[Date_Exams] [varchar](50) NULL)
 




CREATE TABLE [dbo].[EssayQuest_tbl](
	[Id_EssayQuest] int IDENTITY(1,1) PRIMARY KEY,
	[Quest_EssamQuest] [varchar](200) NULL,
	[Answer-EssayQuest] [varchar](200) NULL,
	[Point_EssayQuest] [varchar](50) NULL,
	[Id_ExamsType_EssayQuest] [numeric](18, 0) NOT NULL)



CREATE TABLE [dbo].[ExamsQuestions_tbl](
	[Id_ExamsQuestions] int IDENTITY(1,1) PRIMARY KEY,
	[Id_Exams_ExamsQuestions] [numeric](18, 0) NULL,
	[Id_TrueFalseQuest_ExamsQuestions] [numeric](18, 0) NULL,
	[Id_QCMQuest_ExamsQuestions] [numeric](18, 0) NULL,
	[Id_EssayQuest_ExamsQuestions] [numeric](18, 0) NULL)
 


