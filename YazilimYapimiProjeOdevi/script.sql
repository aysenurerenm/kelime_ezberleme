USE [yazilimYapimiProje]
GO
/****** Object:  Table [dbo].[settings]    Script Date: 8.06.2025 18:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[settings](
	[settingID] [int] IDENTITY(1,1) NOT NULL,
	[userID] [int] NULL,
	[dailyWordCount] [smallint] NULL,
	[dailyCorrectCount] [smallint] NULL,
	[setWordCount] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[settingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 8.06.2025 18:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](30) NULL,
	[password] [varchar](64) NULL,
	[name] [varchar](30) NULL,
	[surname] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[words]    Script Date: 8.06.2025 18:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[words](
	[wordsID] [int] IDENTITY(1,1) NOT NULL,
	[englishWord] [varchar](30) NOT NULL,
	[turkishWord] [varchar](30) NOT NULL,
	[image] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[wordsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wordsSamples]    Script Date: 8.06.2025 18:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wordsSamples](
	[wordsSamplesID] [int] IDENTITY(1,1) NOT NULL,
	[wordsID] [int] NULL,
	[samples] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[wordsSamplesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wordsStation]    Script Date: 8.06.2025 18:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wordsStation](
	[answerID] [int] IDENTITY(1,1) NOT NULL,
	[userID] [int] NOT NULL,
	[wordsID] [int] NOT NULL,
	[isCorrect] [bit] NULL,
	[answerdTime] [datetime] NULL,
	[correctCount] [tinyint] NULL,
	[islearned] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[answerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[settings] ON 

INSERT [dbo].[settings] ([settingID], [userID], [dailyWordCount], [dailyCorrectCount], [setWordCount]) VALUES (2, 1, NULL, NULL, 3)
INSERT [dbo].[settings] ([settingID], [userID], [dailyWordCount], [dailyCorrectCount], [setWordCount]) VALUES (3, 10, NULL, NULL, 3)
INSERT [dbo].[settings] ([settingID], [userID], [dailyWordCount], [dailyCorrectCount], [setWordCount]) VALUES (4, 11, NULL, NULL, 9)
INSERT [dbo].[settings] ([settingID], [userID], [dailyWordCount], [dailyCorrectCount], [setWordCount]) VALUES (5, 12, NULL, NULL, 5)
INSERT [dbo].[settings] ([settingID], [userID], [dailyWordCount], [dailyCorrectCount], [setWordCount]) VALUES (6, 14, NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[settings] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (1, N'buse@gmail.com', N'9556b82499cc0aaf86aee7f0d253e17c61b7ef73d48a295f37d98f08b04ffa7f', N'buse', N'çam')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (2, N'aysima@gmail.com', N'123', N'aysima', N'talantimur')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (3, N'kerem@gmail.com', N'147852', N'kerem', N'gürsoy')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (4, N'murat@gmail.com', N'137852', N'murat', N'erdinç')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (5, N'zeynep@gmail.com', N'157852', N'zeynep', N'gümüş')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (6, N'cenk@gmail.com', N'167852', N'cenk', N'celil')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (7, N'derin@gmail.com', N'187852', N'derin', N'özdemir')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (8, N'ayşe@gmail.com', N'de34229d08509ddf5729e19049ed79e87c455cd3fa90323e061003b4161c5cad', N'ayşe', N'eren')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (9, N'ali@gmail.com', N'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f', N'Ali', N'Demir')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (10, N'deniz@gmail.com', N'cc9eec16680782bfa1d922a4d638cea4a9c652872218986ba79f7501b0022813', N'Deniz', N'Demir')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (11, N'mehmet@gmail.com', N'248b592e88edbb4f62609b36a4b6640a5e65c6759b2adae2c8a7a24378e0274e', N'Mehmet', N'Kaya')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (12, N'busenur@gmail.com', N'7d2ecb7780f61d58d57427111bdc604fc8bbab1374e0b38ee2c331358c505b3c', N'Busenur', N'Çam')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (13, N'duru@gmail.com', N'8a894a33b763b0abf72cb0b05b414aaaaea90be0332095a50f803db173c96a89', N'duru', N'cam')
INSERT [dbo].[users] ([userID], [email], [password], [name], [surname]) VALUES (14, N'masal@gmail.com', N'91e25014d00d9b47484690f282a6d0328aae7db1414d373fb0d179c0020ee492', N'Masal', N'Küçük')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET IDENTITY_INSERT [dbo].[words] ON 

INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (1, N'apple', N'elma', N'C:\Users\Aysima\Desktop\yazılımyapımı\apple.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (2, N'pencil', N'kalem', N'C:\Users\Aysima\Desktop\yazılımyapımı\pencil.png')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (3, N'bag', N'çanta', N'C:\Users\Aysima\Desktop\yazılımyapımı\bag.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (4, N'baby', N'bebek', N'C:\Users\Aysima\Desktop\yazılımyapımı\baby.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (5, N'brain', N'beyin', N'C:\Users\Aysima\Desktop\yazılımyapımı\brain.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (6, N'tree', N'ağaç', N'C:\Users\Aysima\Desktop\yazılımyapımı\tree.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (7, N'cat', N'kedi', N'C:\Users\Aysima\Desktop\yazılımyapımı\cat.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (8, N'earth', N'dünya', N'C:\Users\Aysima\Desktop\yazılımyapımı\earth.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (9, N'fish', N'balık', N'C:\Users\Aysima\Desktop\yazılımyapımı\fish.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (10, N'hair', N'saç', N'C:\Users\Aysima\Desktop\yazılımyapımı\hair.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (11, N'jeans', N'kot', N'C:\Users\Aysima\Desktop\yazılımyapımı\jean.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (12, N'notebook', N'defter', N'C:\Users\Aysima\Desktop\yazılımyapımı\notebook.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (13, N'mirror', N'ayna', N'C:\Users\Aysima\Desktop\yazılımyapımı\mirror.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (14, N'money', N'para', N'C:\Users\Aysima\Desktop\yazılımyapımı\money.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (15, N'map', N'harita', N'C:\Users\Aysima\Desktop\yazılımyapımı\map.jpeg')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (16, N'table', N'masa', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (17, N'headset', N'kulaklık', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (18, N'thermos', N'termos', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (19, N'cup', N'bardak', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (20, N'plane', N'uçak', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (21, N'window', N'pencere', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (22, N'computer', N'bilgisayar', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (23, N'book', N'kitap', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (24, N'mouse', N'fare', NULL)
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (25, N'word', N'kelime', N'')
INSERT [dbo].[words] ([wordsID], [englishWord], [turkishWord], [image]) VALUES (26, N'Milk', N'Süt', N'')
SET IDENTITY_INSERT [dbo].[words] OFF
GO
SET IDENTITY_INSERT [dbo].[wordsSamples] ON 

INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (1, 1, N'I eat an apple.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (2, 2, N'This is my pencil.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (3, 3, N'She has a red bag.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (4, 4, N'The baby is sleeping.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (5, 5, N'The brain is important.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (6, 6, N'A bird is on the tree.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (7, 7, N'The cat is cute.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (8, 8, N'We live on Earth.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (9, 9, N' I see a fish.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (10, 10, N'Her hair is long.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (11, 11, N'He wears blue jeans.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (12, 12, N'I write in my notebook.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (13, 13, N' Look in the mirror.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (14, 14, N'I need some money.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (15, 15, N' The map shows the city..')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (16, 22, N'Turn on the computer.')
INSERT [dbo].[wordsSamples] ([wordsSamplesID], [wordsID], [samples]) VALUES (17, 26, N'I drink milk.')
SET IDENTITY_INSERT [dbo].[wordsSamples] OFF
GO
SET IDENTITY_INSERT [dbo].[wordsStation] ON 

INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (1, 1, 1, 0, NULL, 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (2, 1, 2, 0, NULL, 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (3, 10, 13, 0, CAST(N'2025-06-08T12:52:52.197' AS DateTime), 4, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (4, 10, 6, 0, CAST(N'2025-06-01T15:00:03.840' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (6, 10, 21, 0, CAST(N'2025-06-01T15:00:25.790' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (7, 10, 9, 0, CAST(N'2025-06-01T15:11:53.783' AS DateTime), 0, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (8, 10, 3, 0, CAST(N'2025-06-01T15:13:15.753' AS DateTime), 3, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (9, 10, 18, 0, CAST(N'2025-06-01T15:13:16.853' AS DateTime), 0, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (10, 10, 16, 0, CAST(N'2025-06-01T15:13:24.503' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (11, 10, 5, 0, CAST(N'2025-06-01T15:13:25.540' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (12, 10, 19, 0, CAST(N'2025-06-01T15:14:23.757' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (13, 10, 15, 0, CAST(N'2025-06-01T15:15:32.797' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (14, 10, 11, 0, CAST(N'2025-06-01T15:15:33.850' AS DateTime), 0, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (15, 10, 2, 0, CAST(N'2025-06-01T15:17:07.493' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (16, 10, 22, 0, CAST(N'2025-06-01T15:17:11.520' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (17, 10, 10, 0, CAST(N'2025-06-01T15:17:14.160' AS DateTime), 6, 1)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (18, 10, 17, 0, CAST(N'2025-06-01T15:17:19.470' AS DateTime), 2, 1)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (21, 10, 7, 0, CAST(N'2025-06-08T12:52:55.263' AS DateTime), 4, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (22, 10, 4, 0, CAST(N'2025-06-01T15:17:33.840' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (24, 10, 1, 0, CAST(N'2025-06-01T15:17:42.977' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (25, 10, 12, 0, CAST(N'2025-06-01T15:18:38.893' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (26, 10, 20, 0, CAST(N'2025-06-08T12:52:48.420' AS DateTime), 3, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (27, 10, 14, 0, CAST(N'2025-06-01T15:18:45.497' AS DateTime), 3, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (28, 10, 8, 0, CAST(N'2025-06-01T15:18:49.617' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (30, 10, 24, 0, CAST(N'2025-06-03T14:11:34.930' AS DateTime), 0, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (31, 11, 17, 0, CAST(N'2025-06-03T14:39:01.623' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (32, 12, 3, 0, CAST(N'2025-06-09T20:40:02.777' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (33, 12, 21, 0, CAST(N'2025-06-09T20:40:11.510' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (34, 12, 13, 0, CAST(N'2025-07-02T20:40:14.530' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (36, 12, 12, 0, CAST(N'2025-06-09T20:40:19.867' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (38, 12, 7, 0, CAST(N'2025-07-02T20:40:24.307' AS DateTime), 2, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (39, 12, 15, 0, CAST(N'2025-06-09T20:40:26.947' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (40, 12, 20, 0, CAST(N'2025-07-02T20:40:30.240' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (41, 12, 1, 0, CAST(N'2025-06-09T20:40:55.127' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (42, 12, 24, 0, CAST(N'2025-06-03T20:46:32.077' AS DateTime), 0, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (43, 12, 4, 0, CAST(N'2025-06-09T20:47:09.433' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (44, 12, 23, 0, CAST(N'2025-06-03T20:47:11.833' AS DateTime), 6, 1)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (45, 12, 5, 0, CAST(N'2025-06-03T20:47:15.083' AS DateTime), 7, 1)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (46, 12, 14, 0, CAST(N'2025-06-09T20:47:17.307' AS DateTime), 7, 1)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (49, 13, 14, 0, CAST(N'2025-06-05T22:15:43.967' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (50, 14, 22, 0, CAST(N'2025-06-11T22:24:25.897' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (51, 14, 3, 0, CAST(N'2025-07-04T22:24:29.037' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (54, 14, 14, 0, CAST(N'2025-07-04T22:24:36.887' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (56, 14, 5, 0, CAST(N'2025-06-11T22:24:41.627' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (57, 14, 7, 0, CAST(N'2025-09-02T22:24:43.997' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (58, 14, 13, 0, CAST(N'2025-09-02T22:24:46.337' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (59, 14, 16, 0, CAST(N'2025-06-11T22:24:48.667' AS DateTime), 1, 0)
INSERT [dbo].[wordsStation] ([answerID], [userID], [wordsID], [isCorrect], [answerdTime], [correctCount], [islearned]) VALUES (60, 14, 17, 0, CAST(N'2025-06-11T22:25:04.610' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[wordsStation] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__users__AB6E6164DADEC218]    Script Date: 8.06.2025 18:45:13 ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[wordsStation] ADD  CONSTRAINT [df_isCorrect]  DEFAULT ((0)) FOR [isCorrect]
GO
ALTER TABLE [dbo].[wordsStation] ADD  CONSTRAINT [df_correctCount]  DEFAULT ((0)) FOR [correctCount]
GO
ALTER TABLE [dbo].[wordsStation] ADD  CONSTRAINT [df_islearned]  DEFAULT ((0)) FOR [islearned]
GO
ALTER TABLE [dbo].[settings]  WITH CHECK ADD  CONSTRAINT [fkc_sUserID] FOREIGN KEY([userID])
REFERENCES [dbo].[users] ([userID])
GO
ALTER TABLE [dbo].[settings] CHECK CONSTRAINT [fkc_sUserID]
GO
ALTER TABLE [dbo].[wordsSamples]  WITH CHECK ADD  CONSTRAINT [fkc_wordsID] FOREIGN KEY([wordsID])
REFERENCES [dbo].[words] ([wordsID])
GO
ALTER TABLE [dbo].[wordsSamples] CHECK CONSTRAINT [fkc_wordsID]
GO
ALTER TABLE [dbo].[wordsStation]  WITH CHECK ADD  CONSTRAINT [fkc_wsUserID] FOREIGN KEY([userID])
REFERENCES [dbo].[users] ([userID])
GO
ALTER TABLE [dbo].[wordsStation] CHECK CONSTRAINT [fkc_wsUserID]
GO
ALTER TABLE [dbo].[wordsStation]  WITH CHECK ADD  CONSTRAINT [fkc_wsWordID] FOREIGN KEY([wordsID])
REFERENCES [dbo].[words] ([wordsID])
GO
ALTER TABLE [dbo].[wordsStation] CHECK CONSTRAINT [fkc_wsWordID]
GO
