USE [FinaceManager]
GO
SET IDENTITY_INSERT [dbo].[Satle_CompanyInfo] ON 

INSERT [dbo].[Satle_CompanyInfo] ([ID], [Name], [LinkMan], [Adress]) VALUES (1, N'所有部门', N'李', N'北京市海淀区中南海')
SET IDENTITY_INSERT [dbo].[Satle_CompanyInfo] OFF
SET IDENTITY_INSERT [dbo].[Stale_Contract] ON 

INSERT [dbo].[Stale_Contract] ([ContractID], [ContractNo], [Party], [B], [DemoName], [Money], [Payment], [Schedule], [Cost], [EmpName], [InvoiceNo], [Signedtime], [Addtime], [OperPerson], [Remark]) VALUES (1, N'11', N'1', N'1', N'11', CAST(2.0000 AS Decimal(19, 4)), N'分期付款', N'', CAST(0.0000 AS Decimal(19, 4)), N'--无--', N'', CAST(N'2010-11-22 00:00:00.000' AS DateTime), CAST(N'2010-11-22 18:23:35.470' AS DateTime), N'1', N'1')
SET IDENTITY_INSERT [dbo].[Stale_Contract] OFF
SET IDENTITY_INSERT [dbo].[Stale_Department] ON 

INSERT [dbo].[Stale_Department] ([ID], [DepartName]) VALUES (2, N'市场部')
INSERT [dbo].[Stale_Department] ([ID], [DepartName]) VALUES (3, N'技术部')
INSERT [dbo].[Stale_Department] ([ID], [DepartName]) VALUES (4, N'编辑部')
INSERT [dbo].[Stale_Department] ([ID], [DepartName]) VALUES (5, N'论坛部')
INSERT [dbo].[Stale_Department] ([ID], [DepartName]) VALUES (6, N'财务部')
SET IDENTITY_INSERT [dbo].[Stale_Department] OFF
SET IDENTITY_INSERT [dbo].[Stale_Employee] ON 

INSERT [dbo].[Stale_Employee] ([ID], [EmpName], [Sex], [EntryTime], [DepartID], [Job], [Mobile], [OfficePhone], [Status], [Remark], [Code], [EmpPwd]) VALUES (10002, N'陈东川', N'男 ', CAST(N'2010-11-25 00:00:00.000' AS DateTime), 3, N'程序员', N'', N'', N'转正', N'123', 0, N'123')
INSERT [dbo].[Stale_Employee] ([ID], [EmpName], [Sex], [EntryTime], [DepartID], [Job], [Mobile], [OfficePhone], [Status], [Remark], [Code], [EmpPwd]) VALUES (10003, N'李超', N'男 ', CAST(N'2010-11-25 00:00:00.000' AS DateTime), 3, N'技术部', N'', N'', N'转正', N'', 0, N'123')
INSERT [dbo].[Stale_Employee] ([ID], [EmpName], [Sex], [EntryTime], [DepartID], [Job], [Mobile], [OfficePhone], [Status], [Remark], [Code], [EmpPwd]) VALUES (10004, N'谭强', N'男 ', CAST(N'2010-11-25 00:00:00.000' AS DateTime), 4, N'编辑', N'', N'', N'转正', N'', 0, N'123')
INSERT [dbo].[Stale_Employee] ([ID], [EmpName], [Sex], [EntryTime], [DepartID], [Job], [Mobile], [OfficePhone], [Status], [Remark], [Code], [EmpPwd]) VALUES (10005, N'贺小娟', N'男 ', CAST(N'2010-11-25 00:00:00.000' AS DateTime), 4, N'编辑', N'', N'', N'转正', N'', 0, N'123')
INSERT [dbo].[Stale_Employee] ([ID], [EmpName], [Sex], [EntryTime], [DepartID], [Job], [Mobile], [OfficePhone], [Status], [Remark], [Code], [EmpPwd]) VALUES (10006, N'吴静', N'男 ', CAST(N'2010-11-25 00:00:00.000' AS DateTime), 5, N'论坛', N'', N'', N'转正', N'', 0, N'123')
INSERT [dbo].[Stale_Employee] ([ID], [EmpName], [Sex], [EntryTime], [DepartID], [Job], [Mobile], [OfficePhone], [Status], [Remark], [Code], [EmpPwd]) VALUES (10007, N'姚芬', N'男 ', CAST(N'2010-11-25 00:00:00.000' AS DateTime), 5, N'论坛', N'', N'', N'转正', N'', 0, N'123')
SET IDENTITY_INSERT [dbo].[Stale_Employee] OFF
SET IDENTITY_INSERT [dbo].[Stale_Income] ON 

INSERT [dbo].[Stale_Income] ([ID], [Party], [B], [DemoName], [Money], [DemoCost], [ContractNo], [Incometime], [EmpName], [Deductap], [OperPerson], [IsBank], [InvoiceMoney], [BreakMoney], [Remark], [Type]) VALUES (1, N'1', N'1', N'11', CAST(2.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'11', CAST(N'2010-11-22 00:00:00.000' AS DateTime), N'--无--', CAST(0.00 AS Decimal(18, 2)), N'1', N'是', CAST(2.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), N'1', N'网络推广')
INSERT [dbo].[Stale_Income] ([ID], [Party], [B], [DemoName], [Money], [DemoCost], [ContractNo], [Incometime], [EmpName], [Deductap], [OperPerson], [IsBank], [InvoiceMoney], [BreakMoney], [Remark], [Type]) VALUES (2, N'test', N'非合同收入', N'test', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'非合同收入', CAST(N'2012-09-20 00:00:00.000' AS DateTime), N'无', CAST(0.00 AS Decimal(18, 2)), N'test', N'非合同收入', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'test', N'test')
SET IDENTITY_INSERT [dbo].[Stale_Income] OFF
SET IDENTITY_INSERT [dbo].[Stale_Invoice] ON 

INSERT [dbo].[Stale_Invoice] ([ID], [InvoiceNo], [LTDName], [DemoName], [Money], [Invoicetime], [Payment], [Status], [Handling], [EmpName], [IsBank], [Remark], [ContractNo]) VALUES (1, N'1', N'1', N'11', CAST(2.00 AS Decimal(18, 2)), CAST(N'2010-11-22 18:23:54.063' AS DateTime), N'分期付款', N'已付完', N'1', N'--无--', N'', N'1', N'11')
SET IDENTITY_INSERT [dbo].[Stale_Invoice] OFF
SET IDENTITY_INSERT [dbo].[Stale_InvoiceMX] ON 

INSERT [dbo].[Stale_InvoiceMX] ([ID], [InvoiceNo], [LTDName], [DemoName], [Money], [Invoicetime], [Payment], [Status], [Handling], [EmpName], [IsBank], [Remark], [ContractNo]) VALUES (1, N'1', N'1', N'11', CAST(1.00 AS Decimal(18, 2)), CAST(N'2010-11-22 18:23:54.280' AS DateTime), N'分期付款', N'未付完', N'1', N'--无--', N'', N'1', N'11')
INSERT [dbo].[Stale_InvoiceMX] ([ID], [InvoiceNo], [LTDName], [DemoName], [Money], [Invoicetime], [Payment], [Status], [Handling], [EmpName], [IsBank], [Remark], [ContractNo]) VALUES (2, N'11', N'1', N'11', CAST(1.00 AS Decimal(18, 2)), CAST(N'2010-11-22 18:24:08.827' AS DateTime), N'分期付款', N'已付完', N'11', N'--无--', N'', N'1', N'11')
SET IDENTITY_INSERT [dbo].[Stale_InvoiceMX] OFF
SET IDENTITY_INSERT [dbo].[Stale_LittleType] ON 

INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (1, N'招待费', 4)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (2, N'差旅费', 4)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (3, N'住宿费', 4)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (4, N'停车费', 4)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (5, N'汽油费', 4)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (6, N'通行费', 4)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (7, N'通讯费', 4)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (8, N'营业税', 11)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (9, N'所得税', 11)
INSERT [dbo].[Stale_LittleType] ([ID], [LittleName], [TypeID]) VALUES (10, N'印花税', 11)
SET IDENTITY_INSERT [dbo].[Stale_LittleType] OFF
SET IDENTITY_INSERT [dbo].[Stale_Log] ON 

INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (1, CAST(N'2010-11-22 18:23:35.000' AS DateTime), N'财务收入(合同收入)', N'administrator', N'财务收入(合同收入)', N'LAOQUAN', N'Windows Server 2003', 8)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (2, CAST(N'2010-11-22 18:23:55.000' AS DateTime), N'开发票', N'administrator', N'开发票', N'LAOQUAN', N'Windows Server 2003', 10)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (3, CAST(N'2010-11-22 18:24:09.000' AS DateTime), N'开发票', N'administrator', N'开发票', N'LAOQUAN', N'Windows Server 2003', 10)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (4, CAST(N'2010-11-23 09:17:10.000' AS DateTime), N'登录系统', N'administrator', N'登录成功', N'LAOQUAN', N'Windows Server 2003', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (5, CAST(N'2010-11-23 17:35:41.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'LAOQUAN', N'Windows Server 2003', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (6, CAST(N'2010-11-25 14:09:37.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'LAOQUAN', N'Windows Server 2003', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (7, CAST(N'2010-11-25 14:10:08.000' AS DateTime), N'员工添加', N'admin', N'员工添加', N'LAOQUAN', N'Windows Server 2003', 2)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (8, CAST(N'2010-11-25 14:10:36.000' AS DateTime), N'员工添加', N'admin', N'员工添加', N'LAOQUAN', N'Windows Server 2003', 2)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (9, CAST(N'2010-11-25 14:11:31.000' AS DateTime), N'员工添加', N'admin', N'员工添加', N'LAOQUAN', N'Windows Server 2003', 2)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (10, CAST(N'2010-11-25 14:11:53.000' AS DateTime), N'员工添加', N'admin', N'员工添加', N'LAOQUAN', N'Windows Server 2003', 2)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (11, CAST(N'2010-11-25 14:12:24.000' AS DateTime), N'员工添加', N'admin', N'员工添加', N'LAOQUAN', N'Windows Server 2003', 2)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (12, CAST(N'2010-11-25 14:12:48.000' AS DateTime), N'员工添加', N'admin', N'员工添加', N'LAOQUAN', N'Windows Server 2003', 2)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (13, CAST(N'2010-11-26 10:26:38.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'WXC', N'Windows XP', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (14, CAST(N'2010-11-26 10:27:39.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'WXC', N'Windows XP', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (15, CAST(N'2010-11-26 10:43:41.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'WXC', N'Windows XP', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (16, CAST(N'2012-09-18 22:16:17.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (17, CAST(N'2012-09-18 22:17:26.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (18, CAST(N'2012-09-20 08:38:42.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (19, CAST(N'2012-09-20 08:44:07.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (20, CAST(N'2012-09-20 08:52:08.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (21, CAST(N'2012-09-20 08:53:57.000' AS DateTime), N'登录系统', N'51aspx', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (22, CAST(N'2012-09-20 08:57:10.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (23, CAST(N'2012-09-20 08:58:33.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (24, CAST(N'2012-09-20 09:00:15.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (25, CAST(N'2012-09-20 09:02:43.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (26, CAST(N'2012-09-20 09:04:19.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (27, CAST(N'2012-09-20 09:05:52.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (28, CAST(N'2012-09-20 09:06:59.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (29, CAST(N'2012-09-20 09:09:11.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (30, CAST(N'2012-09-20 09:09:51.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (31, CAST(N'2012-09-20 09:12:56.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (32, CAST(N'2012-09-20 09:13:44.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (33, CAST(N'2012-09-20 09:14:40.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (34, CAST(N'2012-09-20 09:27:14.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (35, CAST(N'2012-09-20 09:28:39.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (36, CAST(N'2012-09-20 09:29:23.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (37, CAST(N'2012-09-20 10:14:27.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (38, CAST(N'2012-09-20 10:18:14.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (39, CAST(N'2012-09-20 10:24:29.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (40, CAST(N'2012-09-20 10:25:26.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (41, CAST(N'2012-09-20 10:27:56.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (42, CAST(N'2012-09-20 10:31:38.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (43, CAST(N'2012-09-20 10:32:30.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (44, CAST(N'2012-09-20 10:35:56.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (45, CAST(N'2012-09-20 10:36:30.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (46, CAST(N'2012-09-20 10:36:37.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (47, CAST(N'2012-09-20 10:37:43.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (48, CAST(N'2012-09-20 10:38:09.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (49, CAST(N'2012-09-20 10:39:00.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (50, CAST(N'2012-09-20 10:39:20.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (51, CAST(N'2012-09-20 10:40:00.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (52, CAST(N'2012-09-20 10:40:56.000' AS DateTime), N'财务支出', N'admin', N'财务支出', N'PC-201206300925', N'未知', 9)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (53, CAST(N'2012-09-20 10:42:00.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (54, CAST(N'2012-09-20 10:44:45.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (55, CAST(N'2012-09-20 10:45:03.000' AS DateTime), N'财务收入(非合同)', N'admin', N'财务收入(非合同)', N'PC-201206300925', N'未知', 8)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (56, CAST(N'2012-09-20 10:46:34.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (57, CAST(N'2012-09-20 10:47:52.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (58, CAST(N'2012-09-20 10:52:10.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (59, CAST(N'2012-09-20 11:02:06.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (60, CAST(N'2012-09-20 11:07:23.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
INSERT [dbo].[Stale_Log] ([ID], [OperTime], [Type], [OperPerson], [State], [ComputerName], [System], [Code]) VALUES (61, CAST(N'2012-09-20 11:14:38.000' AS DateTime), N'登录系统', N'admin', N'登录成功', N'PC-201206300925', N'未知', 1)
SET IDENTITY_INSERT [dbo].[Stale_Log] OFF
SET IDENTITY_INSERT [dbo].[Stale_Outlay] ON 

INSERT [dbo].[Stale_Outlay] ([ID], [EmpName], [Party], [B], [DemoName], [Type], [ContractNo], [Outlayetime], [OperPerson], [Money], [Remark]) VALUES (1, N'--无--', N'test', N'test', N'test', N'佣金', N'dddd', CAST(N'2012-09-20 00:00:00.000' AS DateTime), N'test', CAST(2300.00 AS Decimal(18, 2)), N'test')
SET IDENTITY_INSERT [dbo].[Stale_Outlay] OFF
SET IDENTITY_INSERT [dbo].[Stale_RenWu] ON 

INSERT [dbo].[Stale_RenWu] ([Id], [Name], [Info], [AddTime], [State], [Progress], [UserId], [UserName], [EmpName], [StartTime], [EndTime], [DepartId], [Type], [Help]) VALUES (74, N'开展珠三角网站页面改版', N'开展珠三角网站页面改版！！！', CAST(N'2010-11-25 14:17:05.423' AS DateTime), 0, N'25%', 0, N'陈东川', N'陈东川', CAST(N'2010-11-25 00:00:00.000' AS DateTime), CAST(N'2010-12-10 00:00:00.000' AS DateTime), 3, N'计划任务', N'')
INSERT [dbo].[Stale_RenWu] ([Id], [Name], [Info], [AddTime], [State], [Progress], [UserId], [UserName], [EmpName], [StartTime], [EndTime], [DepartId], [Type], [Help]) VALUES (75, N'111111111111111111', N'1111111111111111', CAST(N'2010-11-25 15:51:58.610' AS DateTime), 0, N'25%', 0, N'谭强', N'陈东川', CAST(N'2010-11-19 00:00:00.000' AS DateTime), CAST(N'2010-11-26 00:00:00.000' AS DateTime), 3, N'常规任务', N'')
INSERT [dbo].[Stale_RenWu] ([Id], [Name], [Info], [AddTime], [State], [Progress], [UserId], [UserName], [EmpName], [StartTime], [EndTime], [DepartId], [Type], [Help]) VALUES (76, N'2222222222222222222222222222222', N'2222222222222222222222', CAST(N'2010-11-25 15:53:00.923' AS DateTime), 0, N'25%', 0, N'陈东川', N'谭强', CAST(N'2010-11-24 00:00:00.000' AS DateTime), CAST(N'2010-11-26 00:00:00.000' AS DateTime), 4, N'常规任务', N'')
INSERT [dbo].[Stale_RenWu] ([Id], [Name], [Info], [AddTime], [State], [Progress], [UserId], [UserName], [EmpName], [StartTime], [EndTime], [DepartId], [Type], [Help]) VALUES (77, N'333333333333333333333333333333333', N'333333333333333333333333333333333333', CAST(N'2010-11-25 15:53:41.657' AS DateTime), 0, N'0%', 0, N'贺小娟', N'谭强', CAST(N'2010-11-17 00:00:00.000' AS DateTime), CAST(N'2010-11-25 00:00:00.000' AS DateTime), 4, N'常规任务', N'谭强#')
SET IDENTITY_INSERT [dbo].[Stale_RenWu] OFF
SET IDENTITY_INSERT [dbo].[Stale_Type] ON 

INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (1, N'佣金')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (2, N'办公用品')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (3, N'工资')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (4, N'报销')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (5, N'物业费')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (6, N'看房团费')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (7, N'会展费')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (8, N'福利费')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (9, N'审计费')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (10, N'社保费')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (11, N'税费')
INSERT [dbo].[Stale_Type] ([ID], [TypeName]) VALUES (12, N'印刷费')
SET IDENTITY_INSERT [dbo].[Stale_Type] OFF
SET IDENTITY_INSERT [dbo].[Stale_Users] ON 

INSERT [dbo].[Stale_Users] ([ID], [UserName], [UserPwd], [Name], [IsEnabled]) VALUES (1, N'sa', N'c4ca4238a0b923820dcc509a6f75849b', N'sa', N'否')
INSERT [dbo].[Stale_Users] ([ID], [UserName], [UserPwd], [Name], [IsEnabled]) VALUES (3, N'admin', N'c4ca4238a0b923820dcc509a6f75849b', N'123', N'是')
INSERT [dbo].[Stale_Users] ([ID], [UserName], [UserPwd], [Name], [IsEnabled]) VALUES (4, N'administrator', N'c4ca4238a0b923820dcc509a6f75849b', N'Jack', N'是')
SET IDENTITY_INSERT [dbo].[Stale_Users] OFF
SET IDENTITY_INSERT [dbo].[Stale_Wage] ON 

INSERT [dbo].[Stale_Wage] ([ID], [Month], [EmpName], [BasicWage], [Jobsubsidies], [Allowance], [Overtimepay], [Bonus], [Businesscommission], [PersonalIncomeTax], [SocialSecurity], [Other], [Remark]) VALUES (1, CAST(N'2012-09-01 00:00:00.000' AS DateTime), N'陈东川', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'')
SET IDENTITY_INSERT [dbo].[Stale_Wage] OFF
