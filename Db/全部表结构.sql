USE [FinaceManager]
GO
/****** Object:  Table [dbo].[Satle_CompanyInfo]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satle_CompanyInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[LinkMan] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
 CONSTRAINT [PK_Satle_CompanyInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Contract]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Contract](
	[ContractID] [int] IDENTITY(1,1) NOT NULL,
	[ContractNo] [nvarchar](100) NULL,
	[Party] [nvarchar](100) NULL,
	[B] [nvarchar](100) NULL,
	[DemoName] [nvarchar](100) NULL,
	[Money] [decimal](19, 4) NULL,
	[Payment] [nvarchar](20) NULL,
	[Schedule] [nvarchar](20) NULL,
	[Cost] [decimal](19, 4) NULL,
	[EmpName] [nvarchar](100) NOT NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[Signedtime] [datetime] NULL,
	[Addtime] [datetime] NULL,
	[OperPerson] [nvarchar](30) NULL,
	[Remark] [nvarchar](1000) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Department]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DepartName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Stale_Department] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_EmpContract]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_EmpContract](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[EmpName] [nvarchar](50) NULL,
	[SignedTime] [datetime] NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[Type] [nvarchar](50) NULL,
	[Deadline] [nchar](10) NULL,
	[Treatment] [int] NULL,
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_Stale_EmpContract] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Employee]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Employee](
	[ID] [int] IDENTITY(10000,1) NOT NULL,
	[EmpName] [nvarchar](50) NULL,
	[Sex] [nchar](2) NULL,
	[EntryTime] [datetime] NULL,
	[DepartID] [int] NULL,
	[Job] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[OfficePhone] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[Remark] [nvarchar](200) NULL,
	[Code] [bigint] NULL CONSTRAINT [DF_Stale_Employee_Code]  DEFAULT ((0)),
	[EmpPwd] [nvarchar](50) NULL CONSTRAINT [DF_Stale_Employee_EmpPwd]  DEFAULT ((123)),
 CONSTRAINT [PK_Stale_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Income]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Income](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Party] [nvarchar](100) NULL,
	[B] [nvarchar](100) NULL,
	[DemoName] [nvarchar](100) NULL,
	[Money] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Income_Money]  DEFAULT ((0)),
	[DemoCost] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Income_DemoCost]  DEFAULT ((0)),
	[ContractNo] [nvarchar](100) NULL,
	[Incometime] [datetime] NULL,
	[EmpName] [nvarchar](50) NULL,
	[Deductap] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Income_Deductap]  DEFAULT ((0)),
	[OperPerson] [nvarchar](50) NULL,
	[IsBank] [nvarchar](50) NULL,
	[InvoiceMoney] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Income_InvoiceMoney]  DEFAULT ((0)),
	[BreakMoney] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Income_BreakMoney]  DEFAULT ((0)),
	[Remark] [nvarchar](200) NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Stale_Income] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Invoice]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[LTDName] [nvarchar](100) NULL,
	[DemoName] [nvarchar](100) NULL,
	[Money] [decimal](18, 2) NULL,
	[Invoicetime] [datetime] NULL,
	[Payment] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[Handling] [nvarchar](50) NULL,
	[EmpName] [nvarchar](50) NULL,
	[IsBank] [nvarchar](50) NULL,
	[Remark] [nvarchar](100) NULL,
	[ContractNo] [nvarchar](100) NULL,
 CONSTRAINT [PK_Stale_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_InvoiceMX]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_InvoiceMX](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[LTDName] [nvarchar](100) NULL,
	[DemoName] [nvarchar](100) NULL,
	[Money] [decimal](18, 2) NULL,
	[Invoicetime] [datetime] NULL,
	[Payment] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[Handling] [nvarchar](50) NULL,
	[EmpName] [nvarchar](50) NULL,
	[IsBank] [nvarchar](50) NULL,
	[Remark] [nvarchar](100) NULL,
	[ContractNo] [nvarchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Left]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Left](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EID] [int] NULL,
	[EmpName] [nvarchar](50) NULL,
	[Sex] [nchar](2) NULL,
	[DepartName] [nvarchar](50) NULL,
	[LeftTime] [datetime] NULL,
	[LeftType] [nvarchar](50) NULL,
	[LeftReason] [nvarchar](200) NULL,
	[ApprovalPerson] [nvarchar](50) NULL,
	[ApprovalDempart] [nvarchar](50) NULL,
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_Stale_Left] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_LittleType]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_LittleType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LittleName] [nvarchar](50) NULL,
	[TypeID] [int] NULL,
 CONSTRAINT [PK_Stale_LittleType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Log]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Log](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OperTime] [datetime] NULL,
	[Type] [nvarchar](50) NULL,
	[OperPerson] [nvarchar](50) NULL,
	[State] [nvarchar](1000) NULL,
	[ComputerName] [nvarchar](100) NULL,
	[System] [nvarchar](100) NULL,
	[Code] [int] NULL,
 CONSTRAINT [PK_Stale_Log] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Outlay]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Outlay](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](50) NULL,
	[Party] [nvarchar](100) NULL,
	[B] [nvarchar](100) NULL,
	[DemoName] [nvarchar](100) NULL,
	[Type] [nvarchar](50) NULL,
	[ContractNo] [nvarchar](100) NULL,
	[Outlayetime] [datetime] NULL,
	[OperPerson] [nvarchar](50) NULL,
	[Money] [decimal](18, 2) NULL,
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_Stale_Outlay] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_RenWu]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_RenWu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Info] [nvarchar](1000) NULL,
	[AddTime] [datetime] NULL,
	[State] [bigint] NULL,
	[Progress] [nvarchar](50) NULL,
	[UserId] [int] NULL,
	[UserName] [nvarchar](50) NULL,
	[EmpName] [nvarchar](1000) NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[DepartId] [int] NULL,
	[Type] [nvarchar](50) NULL,
	[Help] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Stale_RenWu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Salary]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Salary](
	[SalaryID] [int] IDENTITY(1,1) NOT NULL,
	[NewSalary] [decimal](19, 4) NULL,
	[OldSalary] [decimal](19, 4) NULL,
	[Reason] [nvarchar](200) NULL,
	[PubDate] [datetime] NULL,
	[EmpName] [nvarchar](50) NULL,
	[OperPerson] [nvarchar](30) NULL,
	[Remark] [nvarchar](1000) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Type]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Stale_Type] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Users]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserPwd] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[IsEnabled] [nvarchar](50) NULL,
 CONSTRAINT [PK_Stale_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stale_Wage]    Script Date: 2016/5/6 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stale_Wage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Month] [datetime] NULL,
	[EmpName] [nvarchar](50) NULL,
	[BasicWage] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_BasicWage]  DEFAULT ((0)),
	[Jobsubsidies] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_Jobsubsidies]  DEFAULT ((0)),
	[Allowance] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_Allowance]  DEFAULT ((0)),
	[Overtimepay] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_Overtimepay]  DEFAULT ((0)),
	[Bonus] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_Bonus]  DEFAULT ((0)),
	[Businesscommission] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_Businesscommission]  DEFAULT ((0)),
	[PersonalIncomeTax] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_PersonalIncomeTax]  DEFAULT ((0)),
	[SocialSecurity] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_SocialSecurity]  DEFAULT ((0)),
	[Other] [decimal](18, 2) NULL CONSTRAINT [DF_Stale_Wage_Other]  DEFAULT ((0)),
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_Stale_Wage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Stale_Salary] ADD  CONSTRAINT [DF_Stale_Salary_NewSalary]  DEFAULT ((0)) FOR [NewSalary]
GO
ALTER TABLE [dbo].[Stale_Salary] ADD  CONSTRAINT [DF_Stale_Salary_OldSalary]  DEFAULT ((0)) FOR [OldSalary]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'ContractID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同编号(手动输入)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'ContractNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'甲方' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'Party'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'乙方' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'B'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'DemoName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'Money'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'付款方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'Payment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目进度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'Schedule'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目成本' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'Cost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'业务员(外键)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'EmpName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发票编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'InvoiceNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'合同签订时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'Signedtime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'Addtime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Contract', @level2type=N'COLUMN',@level2name=N'OperPerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识码  0：在职  1：离职' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Employee', @level2type=N'COLUMN',@level2name=N'Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'提成' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Income', @level2type=N'COLUMN',@level2name=N'Deductap'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发票金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Income', @level2type=N'COLUMN',@level2name=N'InvoiceMoney'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'汇款金额
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Income', @level2type=N'COLUMN',@level2name=N'BreakMoney'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收入类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Income', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'小分类名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_LittleType', @level2type=N'COLUMN',@level2name=N'LittleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'大分类ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_LittleType', @level2type=N'COLUMN',@level2name=N'TypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识码  1：系统登录  2：员工添加  3：员工修改  4：员工删除 5：工资添加  6：工资调整  7：工资发放  8：收入 9：支出  10：开发票  11：合同签订' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Log', @level2type=N'COLUMN',@level2name=N'Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工作简介' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'Info'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0:任务开始 1:任务结束' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务进度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'Progress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务协同人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'EmpName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务开始时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'DepartId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_RenWu', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'大分类名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Type', @level2type=N'COLUMN',@level2name=N'TypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Users', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Users', @level2type=N'COLUMN',@level2name=N'UserPwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Users', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'月份' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Month'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'EmpName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'基本工资' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'BasicWage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岗位补贴' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Jobsubsidies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'津贴' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Allowance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'加班工资' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Overtimepay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'奖金' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Bonus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'业务提成' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Businesscommission'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'个人所得税' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'PersonalIncomeTax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'社保' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'SocialSecurity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'其它' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Other'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Stale_Wage', @level2type=N'COLUMN',@level2name=N'Remark'
GO
