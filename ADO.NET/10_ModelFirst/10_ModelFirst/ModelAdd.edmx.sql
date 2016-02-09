
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/09/2016 21:21:50
-- Generated from EDMX file: D:\ITStepProjects\ADO.NET\10_ModelFirst\10_ModelFirst\ModelAdd.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'OfficeAssignmentSet'
CREATE TABLE [dbo].[OfficeAssignmentSet] (
    [Location] nvarchar(max)  NOT NULL,
    [InstructorID] nvarchar(max)  NOT NULL,
    [Instructor_ID] int  NOT NULL
);
GO

-- Creating table 'EnrollmentSet'
CREATE TABLE [dbo].[EnrollmentSet] (
    [EnrollmentID] int IDENTITY(1,1) NOT NULL,
    [Grade] nvarchar(max)  NOT NULL,
    [CourseID] nvarchar(max)  NOT NULL,
    [StudentID] nvarchar(max)  NOT NULL,
    [Student_ID] int  NOT NULL,
    [Course_CourseID] int  NOT NULL
);
GO

-- Creating table 'CourseSet'
CREATE TABLE [dbo].[CourseSet] (
    [CourseID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Credits] decimal(18,0)  NOT NULL,
    [DepartmentID] nvarchar(max)  NOT NULL,
    [Department_DepartmentID] int  NOT NULL
);
GO

-- Creating table 'DepartmentSet'
CREATE TABLE [dbo].[DepartmentSet] (
    [DepartmentID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Budget] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [RowVersion] int  NOT NULL,
    [InstructorID] nvarchar(max)  NOT NULL,
    [Instructor_ID] int  NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [FirstMidName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonSet_Instructor'
CREATE TABLE [dbo].[PersonSet_Instructor] (
    [HireDate] datetime  NOT NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'PersonSet_Student'
CREATE TABLE [dbo].[PersonSet_Student] (
    [EnrollmentDate] datetime  NOT NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'CourseInstructor'
CREATE TABLE [dbo].[CourseInstructor] (
    [Course_CourseID] int  NOT NULL,
    [Instructor_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [InstructorID] in table 'OfficeAssignmentSet'
ALTER TABLE [dbo].[OfficeAssignmentSet]
ADD CONSTRAINT [PK_OfficeAssignmentSet]
    PRIMARY KEY CLUSTERED ([InstructorID] ASC);
GO

-- Creating primary key on [EnrollmentID] in table 'EnrollmentSet'
ALTER TABLE [dbo].[EnrollmentSet]
ADD CONSTRAINT [PK_EnrollmentSet]
    PRIMARY KEY CLUSTERED ([EnrollmentID] ASC);
GO

-- Creating primary key on [CourseID] in table 'CourseSet'
ALTER TABLE [dbo].[CourseSet]
ADD CONSTRAINT [PK_CourseSet]
    PRIMARY KEY CLUSTERED ([CourseID] ASC);
GO

-- Creating primary key on [DepartmentID] in table 'DepartmentSet'
ALTER TABLE [dbo].[DepartmentSet]
ADD CONSTRAINT [PK_DepartmentSet]
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC);
GO

-- Creating primary key on [ID] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PersonSet_Instructor'
ALTER TABLE [dbo].[PersonSet_Instructor]
ADD CONSTRAINT [PK_PersonSet_Instructor]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PersonSet_Student'
ALTER TABLE [dbo].[PersonSet_Student]
ADD CONSTRAINT [PK_PersonSet_Student]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Course_CourseID], [Instructor_ID] in table 'CourseInstructor'
ALTER TABLE [dbo].[CourseInstructor]
ADD CONSTRAINT [PK_CourseInstructor]
    PRIMARY KEY CLUSTERED ([Course_CourseID], [Instructor_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Instructor_ID] in table 'OfficeAssignmentSet'
ALTER TABLE [dbo].[OfficeAssignmentSet]
ADD CONSTRAINT [FK_OfficeAssignmentInstructor]
    FOREIGN KEY ([Instructor_ID])
    REFERENCES [dbo].[PersonSet_Instructor]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfficeAssignmentInstructor'
CREATE INDEX [IX_FK_OfficeAssignmentInstructor]
ON [dbo].[OfficeAssignmentSet]
    ([Instructor_ID]);
GO

-- Creating foreign key on [Student_ID] in table 'EnrollmentSet'
ALTER TABLE [dbo].[EnrollmentSet]
ADD CONSTRAINT [FK_EnrollmentStudent]
    FOREIGN KEY ([Student_ID])
    REFERENCES [dbo].[PersonSet_Student]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EnrollmentStudent'
CREATE INDEX [IX_FK_EnrollmentStudent]
ON [dbo].[EnrollmentSet]
    ([Student_ID]);
GO

-- Creating foreign key on [Course_CourseID] in table 'EnrollmentSet'
ALTER TABLE [dbo].[EnrollmentSet]
ADD CONSTRAINT [FK_EnrollmentCourse]
    FOREIGN KEY ([Course_CourseID])
    REFERENCES [dbo].[CourseSet]
        ([CourseID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EnrollmentCourse'
CREATE INDEX [IX_FK_EnrollmentCourse]
ON [dbo].[EnrollmentSet]
    ([Course_CourseID]);
GO

-- Creating foreign key on [Course_CourseID] in table 'CourseInstructor'
ALTER TABLE [dbo].[CourseInstructor]
ADD CONSTRAINT [FK_CourseInstructor_Course]
    FOREIGN KEY ([Course_CourseID])
    REFERENCES [dbo].[CourseSet]
        ([CourseID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Instructor_ID] in table 'CourseInstructor'
ALTER TABLE [dbo].[CourseInstructor]
ADD CONSTRAINT [FK_CourseInstructor_Instructor]
    FOREIGN KEY ([Instructor_ID])
    REFERENCES [dbo].[PersonSet_Instructor]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseInstructor_Instructor'
CREATE INDEX [IX_FK_CourseInstructor_Instructor]
ON [dbo].[CourseInstructor]
    ([Instructor_ID]);
GO

-- Creating foreign key on [Department_DepartmentID] in table 'CourseSet'
ALTER TABLE [dbo].[CourseSet]
ADD CONSTRAINT [FK_CourseDepartment]
    FOREIGN KEY ([Department_DepartmentID])
    REFERENCES [dbo].[DepartmentSet]
        ([DepartmentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseDepartment'
CREATE INDEX [IX_FK_CourseDepartment]
ON [dbo].[CourseSet]
    ([Department_DepartmentID]);
GO

-- Creating foreign key on [Instructor_ID] in table 'DepartmentSet'
ALTER TABLE [dbo].[DepartmentSet]
ADD CONSTRAINT [FK_DepartmentInstructor]
    FOREIGN KEY ([Instructor_ID])
    REFERENCES [dbo].[PersonSet_Instructor]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentInstructor'
CREATE INDEX [IX_FK_DepartmentInstructor]
ON [dbo].[DepartmentSet]
    ([Instructor_ID]);
GO

-- Creating foreign key on [ID] in table 'PersonSet_Instructor'
ALTER TABLE [dbo].[PersonSet_Instructor]
ADD CONSTRAINT [FK_Instructor_inherits_Person]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[PersonSet]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'PersonSet_Student'
ALTER TABLE [dbo].[PersonSet_Student]
ADD CONSTRAINT [FK_Student_inherits_Person]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[PersonSet]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------