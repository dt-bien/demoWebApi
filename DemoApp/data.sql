USE [demo]
GO
INSERT [dbo].[Positions] ([Id], [PositionName]) VALUES (N'13272fcf-b04a-402c-8df8-cd063fe69663', N'leader2')
INSERT [dbo].[Positions] ([Id], [PositionName]) VALUES (N'6cc3ceb4-8387-4386-abc7-7e2ace7394b0', N'leader1')
INSERT [dbo].[Positions] ([Id], [PositionName]) VALUES (N'738b1d44-5e6f-4b4f-a38c-d273b27bd8dc', N'manager')
INSERT [dbo].[Positions] ([Id], [PositionName]) VALUES (N'd298a68a-cf65-465d-8ec5-018094e16850', N'staff')
GO
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'2337e49a-3c3e-4218-8238-cfc8dd7ce734', N'Ngô Thị Khánh Chi', N'd298a68a-cf65-465d-8ec5-018094e16850', CAST(N'2022-10-27T03:38:18.987' AS DateTime), N'52a5b6d6-7264-44ff-aa81-c4ebf7e477ab', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'52a5b6d6-7264-44ff-aa81-c4ebf7e477ab', N'Nguyễn Văn Bình', N'13272fcf-b04a-402c-8df8-cd063fe69663', CAST(N'2022-10-27T03:35:47.450' AS DateTime), N'df01f345-bcd0-462b-a6f6-e84cc65c5e14', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'675ed4e9-0eb4-446a-9822-b967bb981e88', N'Tạ Đình Vũ Đàm', N'6cc3ceb4-8387-4386-abc7-7e2ace7394b0', CAST(N'2022-10-27T03:33:02.420' AS DateTime), N'df01f345-bcd0-462b-a6f6-e84cc65c5e14', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'6a3d5885-141f-4542-9f82-d607edfbbcda', N'Âu Thị Hồng Hoa	', N'd298a68a-cf65-465d-8ec5-018094e16850', CAST(N'2022-10-27T03:36:37.903' AS DateTime), N'675ed4e9-0eb4-446a-9822-b967bb981e88', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'7b1d1d18-649d-4874-80ca-dcc264525869', N'Trịnh Thị Thu Hương', N'd298a68a-cf65-465d-8ec5-018094e16850', CAST(N'2022-10-27T03:37:06.137' AS DateTime), N'52a5b6d6-7264-44ff-aa81-c4ebf7e477ab', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'8fabc922-a855-4f46-a1bd-8306053aad24', N'Đặng Thùy Trang', N'd298a68a-cf65-465d-8ec5-018094e16850', CAST(N'2022-10-27T03:37:13.623' AS DateTime), N'52a5b6d6-7264-44ff-aa81-c4ebf7e477ab', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'988a82f8-47f8-459d-acf0-6e68a03d9e7d', N'Bùi Thị Thùy Trang', N'd298a68a-cf65-465d-8ec5-018094e16850', CAST(N'2022-10-27T03:37:31.283' AS DateTime), N'52a5b6d6-7264-44ff-aa81-c4ebf7e477ab', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'a7850a16-87ec-4b9c-9c63-0b37089b26ee', N'Trần Hồng Oanh', N'd298a68a-cf65-465d-8ec5-018094e16850', CAST(N'2022-10-27T03:36:26.823' AS DateTime), N'675ed4e9-0eb4-446a-9822-b967bb981e88', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'ce335858-4c70-445c-b0e2-cf4eac7585dc', N'Trần Thế Sinh', N'd298a68a-cf65-465d-8ec5-018094e16850', CAST(N'2022-10-27T03:36:16.250' AS DateTime), N'675ed4e9-0eb4-446a-9822-b967bb981e88', NULL)
INSERT [dbo].[UserInfoes] ([Id], [UserName], [PositionId], [CreatedAt], [Supervisor_Id], [UserInfo_FK_Id]) VALUES (N'df01f345-bcd0-462b-a6f6-e84cc65c5e14', N'Hoàng Văn Thắng', N'738b1d44-5e6f-4b4f-a38c-d273b27bd8dc', CAST(N'2022-10-27T03:32:41.640' AS DateTime), NULL, NULL)
GO
