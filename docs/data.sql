USE [de41_TItov_v2]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [last_name], [first_name], [patronimyc], [login], [passwod], [role], [status]) VALUES (1, N'Титов', N'Михаил', N'Александрович', N'mishanyaGG', N'123', N'Администртор', N'Работает')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[shifts] ON 

INSERT [dbo].[shifts] ([id], [id_User], [date_Start], [date_End]) VALUES (1, 1, CAST(N'2004-08-27T12:30:00.000' AS DateTime), CAST(N'2004-08-27T14:50:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[shifts] OFF
GO
