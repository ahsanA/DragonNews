USE [DragonNews]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 6/5/2015 9:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](250) NOT NULL,
	[Password] [nvarchar](250) NOT NULL,
	[Salt] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[News]    Script Date: 6/5/2015 9:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[ID] [uniqueidentifier] NOT NULL,
	[Category] [int] NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Member] ([ID], [Name], [Email], [Password], [Salt], [CreateDate]) VALUES (N'786e5579-9a0b-44f0-85e8-367d959cfd94', N'Ahsan', N'ahsan.therising@gmail.com', N'fNrvhEpaVpuXy0OpHZYt6A==', N'GNJVCOVN', CAST(N'2015-06-04 20:44:11.393' AS DateTime))
INSERT [dbo].[Member] ([ID], [Name], [Email], [Password], [Salt], [CreateDate]) VALUES (N'31b91279-9ec0-416d-b628-7f4dd8787806', N'ahsan', N'ahsan@ex.com', N'Vcfr1B9fmvkxA0MBdgGs8g==', N'NGPNYVGN', CAST(N'2015-06-05 15:12:57.180' AS DateTime))
INSERT [dbo].[Member] ([ID], [Name], [Email], [Password], [Salt], [CreateDate]) VALUES (N'ae4d5f15-6716-4f61-bb4e-968c58854f91', N'ahsan', N'mail@example.com', N'CE+NN4WWRYFKGagUsL7n6Q==', N'ZQRYDIGD', CAST(N'2015-06-05 14:12:25.677' AS DateTime))
INSERT [dbo].[Member] ([ID], [Name], [Email], [Password], [Salt], [CreateDate]) VALUES (N'b2de3e29-0207-4783-b8c1-99b892f7509f', N'Tanmoy', N'ahsan@proggasoft.com', N'Aq7m2WT0vO2ycLXwnSkdRA==', N'RZFFMSRF', CAST(N'2015-06-04 20:22:42.490' AS DateTime))
INSERT [dbo].[Member] ([ID], [Name], [Email], [Password], [Salt], [CreateDate]) VALUES (N'780521f3-94b7-4fb7-9160-9ca0307626ae', N'ahsan', N'ahsan@email@com', N'hiEKbxCN1hblPckonBn3UA==', N'GVORWVWA', CAST(N'2015-06-05 15:03:57.200' AS DateTime))
INSERT [dbo].[Member] ([ID], [Name], [Email], [Password], [Salt], [CreateDate]) VALUES (N'a62e58f8-f713-4bf7-96aa-a079b45bb7a9', N'Ahsan Ahmad', N'ahsan1037@gmail.com', N'S1/mk65OiTvfeS5cl5vtVQ==', N'OIOULXKJ', CAST(N'2015-06-04 20:19:28.933' AS DateTime))
INSERT [dbo].[Member] ([ID], [Name], [Email], [Password], [Salt], [CreateDate]) VALUES (N'0be03f69-65ca-4c28-8f35-c55e8aaf0fc5', N'Jhon Deo', N'jhon@mail.com', N'5BZFe8ai90uVsIxW3VQbnA==', N'ONFDEQLZ', CAST(N'2015-06-04 20:52:23.120' AS DateTime))
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'f4dd9d1e-47f6-45b5-b917-10b4a4c25ce6', 1, N'this new is edited', CAST(N'2015-06-04 20:45:50.000' AS DateTime), N'786e5579-9a0b-44f0-85e8-367d959cfd94', N'Diamond League: Justin Gatlin wins 100m in new Rome record')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'844a7618-ca90-413b-8eb3-1572fa9bf1ed', 1, N'American Justin Gatlin beat Usain Bolt''s Rome Diamond League record with a superb performance in the 100m.
The 33-year-old surged clear of the field to win in 9.75 seconds - the seventh-fastest time in history - eclipsing Bolt''s 9.76 set in 2012.
Gatlin, who has served two doping bans, ran a 9.74 in the opening Diamond League meeting of the year last month.
Olympic champion Sally Pearson suffered a wrist injury as a result of a fall in the women''s 100m hurdles.
The 28-year-old Australian was one of three fallers in the race, won by USA''s Sharika Nelvis in 12.52 seconds, with Briton Tiffany Porter was third in 12.69.
Britain''s Shara Proctor was second in the women''s long jump with a leap of 6.85 metres, narrowly behind Russian Darya Klishina''s 6.89m.
', CAST(N'2015-06-04 20:24:15.650' AS DateTime), N'b2de3e29-0207-4783-b8c1-99b892f7509f', N'Diamond League: Justin Gatlin wins 100m in new Rome record')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'589f1c26-da78-463f-93de-1715791c7a1d', 1, N'Lucie Safarova fought back to beat Serbia''s Ana Ivanovic and become the first Czech woman to reach the French Open final in 34 years.
The 13th seed trailed 5-2 in the first set but reeled off five straight games on her way to a 7-5 7-5 win.
She will face world number one Serena Williams, who later beat 23rd seed Timea Bacsinszky, in Saturday''s final.
"It is a dream come true. I cannot believe it," said Safarova after converting a third match point.
"I started slowly but tried to keep up the level and play really aggressively because that was the only way to win."
Safarova made the Wimbledon semi-finals last year, but is through to her first Grand Slam final.
The 28-year-old will try to match the achievement of her compatriot, Hana Mandlikova, who won the title in 1981.', CAST(N'2015-06-05 14:14:53.810' AS DateTime), N'ae4d5f15-6716-4f61-bb4e-968c58854f91', N'French Open 2015: Lucie Safarova beats Ana Ivanovic')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'e2c21014-72db-4172-a8db-1a6374867e33', 1, N'Ireland are just one wicket away from clinching a convincing win against the UAE after the third day of their ICC Intercontinental Cup match at Malahide.
The hosts claimed an extra half hour in an attempt to wrap up the game inside three days, but the UAE finished on 251-9 in their second innings.
They still need another 28 runs to make Ireland bat again.
Spinner George Dockrell has taken seven wickets in the match, including his 100th for Ireland.
Resuming the day on 207-8, the last two UAE first-innings wickets added just six runs, with Craig Young (4-51) and Dockrell (3-48) claiming the scalps.
Skipper William Porterfield enforced the follow-on with the visitors 279 runs adrift, and left-arm spinner Dockrell dismissed openers Amjad Ali (28) and Asif Iqbal (12) before the lunch break.
Khurram Khan (10) fell to a sharp slip catch by Ed Joyce off Paul Stirling just after the interval, to leave the UAE struggling on 65-3.
Swapnil Patil and Saqib Ali - who scored 195 against Ireland in this competition in 2008 - then frustrated the Ireland attack.
', CAST(N'2015-06-04 20:21:38.790' AS DateTime), N'a62e58f8-f713-4bf7-96aa-a079b45bb7a9', N'Intercontinental Cup: Ireland one wicket from victory over UAE')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'083c881c-68c2-4ccc-b0a1-44d87225fef7', 1, N'Ireland are just one wicket away from clinching a convincing win against the UAE after the third day of their ICC Intercontinental Cup match at Malahide.
The hosts claimed an extra half hour in an attempt to wrap up the game inside three days, but the UAE finished on 251-9 in their second innings.
They still need another 28 runs to make Ireland bat again.
Spinner George Dockrell has taken seven wickets in the match, including his 100th for Ireland.
Resuming the day on 207-8, the last two UAE first-innings wickets added just six runs, with Craig Young (4-51) and Dockrell (3-48) claiming the scalps.
Skipper William Porterfield enforced the follow-on with the visitors 279 runs adrift, and left-arm spinner Dockrell dismissed openers Amjad Ali (28) and Asif Iqbal (12) before the lunch break.
Khurram Khan (10) fell to a sharp slip catch by Ed Joyce off Paul Stirling just after the interval, to leave the UAE struggling on 65-3.
Swapnil Patil and Saqib Ali - who scored 195 against Ireland in this competition in 2008 - then frustrated the Ireland attack.', CAST(N'2015-06-04 20:55:30.897' AS DateTime), N'0be03f69-65ca-4c28-8f35-c55e8aaf0fc5', N'Intercontinental Cup: Ireland one wicket from victory over UAE')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'facfccd2-b585-45bd-8cd0-5c1ba3700ca1', 1, N'Britain''s Justin Rose and Masters champion Jordan Spieth were a shot off the clubhouse lead in round one of the Memorial Tournament in Ohio but Tiger Woods battled to a 73.
Rose, 34, the 2013 US Open champion and world number six, birdied four of his opening seven holes in a four-under 68.
Woods, now ranked 172, was four over after nine in his first event for a month, but rallied with three birdies.
Ken Duke, Ryan Moore, Brendon Todd and Harris English all reached five under.', CAST(N'2015-06-05 14:15:08.893' AS DateTime), N'ae4d5f15-6716-4f61-bb4e-968c58854f91', N'Memorial Tournament: Justin Rose in touch as Tiger Woods struggles')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'99a4d733-2dff-48a8-b0f1-7093106e64b2', 1, N'American Justin Gatlin beat Usain Bolt''s Rome Diamond League record with a superb performance in the 100m.
The 33-year-old surged clear of the field to win in 9.75 seconds - the seventh-fastest time in history - eclipsing Bolt''s 9.76 set in 2012.
Gatlin, who has served two doping bans, ran a 9.74 in the opening Diamond League meeting of the year last month.
Olympic champion Sally Pearson suffered a wrist injury as a result of a fall in the women''s 100m hurdles.
The 28-year-old Australian was one of three fallers in the race, won by USA''s Sharika Nelvis in 12.52 seconds, with Briton Tiffany Porter was third in 12.69.
Britain''s Shara Proctor was second in the women''s long jump with a leap of 6.85 metres, narrowly behind Russian Darya Klishina''s 6.89m.', CAST(N'2015-06-04 20:55:46.817' AS DateTime), N'0be03f69-65ca-4c28-8f35-c55e8aaf0fc5', N'Diamond League: Justin Gatlin wins 100m in new Rome record')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'e0f0000b-aabf-486d-b692-8f7f2fdda47c', 1, N'Britain''s Justin Rose and Masters champion Jordan Spieth were a shot off the clubhouse lead in round one of the Memorial Tournament in Ohio but Tiger Woods battled to a 73.
Rose, 34, the 2013 US Open champion and world number six, birdied four of his opening seven holes in a four-under 68.
Woods, now ranked 172, was four over after nine in his first event for a month, but rallied with three birdies.
Ken Duke, Ryan Moore, Brendon Todd and Harris English all reached five under.
Five times a winner of the tournament at the Jack Nicklaus-designed Muirfield Village Golf Club, Woods began his round from the 10th with a dropped shot after hooking his drive and also bogeyed the next when his approach to the par five finished in the stream guarding the green.
He drove out of the bounds to the right to double bogey the 18th but there was some impressive play too, a magnificent tee shot to three feet setting up a birdie at the par three 16th, one of five birdies in his eventful round.
', CAST(N'2015-06-04 20:20:49.670' AS DateTime), N'a62e58f8-f713-4bf7-96aa-a079b45bb7a9', N'Memorial Tournament: Justin Rose in touch as Tiger Woods struggles')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'b3968565-6261-46e0-978f-90ba58670724', 2, N'It is very rare that Ranbir Kapoor talks about his relationship and alleged lady love Katrina Kaif. However, in an interview with Absolute India, the actor has revealed how Katrina is teaching him to be a better person. The Bombay Velvet actor was quoted in the interview as saying that when you are in love with a person who thinks about you all the time and is a better person than you, you learn a lot from them. He further admitted that Kat is teaching him to be a better person. Ranbir added that Katrina has taken him on the right path and that she is better than him in every sense. 
While Ranbir is all praise for Katrina and can''t stop waxing eloquent about her presence in his life, read on to know why even after divorce, Kalki promises to be there for Anurag Kashyap... 
', CAST(N'2015-06-04 20:21:14.763' AS DateTime), N'a62e58f8-f713-4bf7-96aa-a079b45bb7a9', N'Ranbir Kapoor: Katrina has taken me on the right path')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'aeb67344-1fed-4920-8550-9aea0b165029', 1, N'Lucie Safarova fought back to beat Serbia''s Ana Ivanovic and become the first Czech woman to reach the French Open final in 34 years.
The 13th seed trailed 5-2 in the first set but reeled off five straight games on her way to a 7-5 7-5 win.
She will face world number one Serena Williams, who later beat 23rd seed Timea Bacsinszky, in Saturday''s final.
"It is a dream come true. I cannot believe it," said Safarova after converting a third match point.
"I started slowly but tried to keep up the level and play really aggressively because that was the only way to win."
Safarova made the Wimbledon semi-finals last year, but is through to her first Grand Slam final.
The 28-year-old will try to match the achievement of her compatriot, Hana Mandlikova, who won the title in 1981.', CAST(N'2015-06-05 15:15:00.047' AS DateTime), N'31b91279-9ec0-416d-b628-7f4dd8787806', N'French Open 2015: Lucie Safarova beats Ana Ivanovic')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'a7e935f6-10ec-48f4-9f72-a6a9e1501203', 1, N'Lucie Safarova fought back to beat Serbia''s Ana Ivanovic and become the first Czech woman to reach the French Open final in 34 years.
The 13th seed trailed 5-2 in the first set but reeled off five straight games on her way to a 7-5 7-5 win.
She will face world number one Serena Williams, who later beat 23rd seed Timea Bacsinszky, in Saturday''s final.
"It is a dream come true. I cannot believe it," said Safarova after converting a third match point.
"I started slowly but tried to keep up the level and play really aggressively because that was the only way to win."
Safarova made the Wimbledon semi-finals last year, but is through to her first Grand Slam final.
The 28-year-old will try to match the achievement of her compatriot, Hana Mandlikova, who won the title in 1981.', CAST(N'2015-06-04 20:20:18.043' AS DateTime), N'a62e58f8-f713-4bf7-96aa-a079b45bb7a9', N'French Open 2015: Lucie Safarova beats Ana Ivanovic')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'152bdc89-051c-417d-abc4-b0ceae1f7dc5', 2, N'Britain''s Justin Rose and Masters champion Jordan Spieth were a shot off the clubhouse lead in round one of the Memorial Tournament in Ohio but Tiger Woods battled to a 73.
Rose, 34, the 2013 US Open champion and world number six, birdied four of his opening seven holes in a four-under 68.
Woods, now ranked 172, was four over after nine in his first event for a month, but rallied with three birdies.
Ken Duke, Ryan Moore, Brendon Todd and Harris English all reached five under.
Five times a winner of the tournament at the Jack Nicklaus-designed Muirfield Village Golf Club, Woods began his round from the 10th with a dropped shot after hooking his drive and also bogeyed the next when his approach to the par five finished in the stream guarding the green.
He drove out of the bounds to the right to double bogey the 18th bu', CAST(N'2015-06-05 15:06:25.037' AS DateTime), N'780521f3-94b7-4fb7-9160-9ca0307626ae', N' Memorial Tournament: Justin Rose in touch as Tiger Woods struggles')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'71fc480b-a0ed-4add-9b8b-c537d24b720d', 2, N'Dil Dhadakne Do has been advertised and promoted as a ensemble about a dysfunctional family. But after walking out of the theatre I realised there was hardly anything odd about the Mehras. If anything you might often find the awkward dinner table sequences or those stoic pauses and silences between the parents (Anil and Shefali) and their kids (Ranveer and Priyanka) extremely relatable. This time Zoya ditches the road and takes the ocean route. Setting the film against the backdrop of a cruise ship was an ingenious idea as it doesn’t really allow the viewer to look beyond the characters trapped on the moving island. While there are more than half a dozen characters thrown into the plot, the most important one is a four legged creature named Pluto (voiced by Aamir Khan) who is the narrator of the film. The first half introduces us to the Mehras and their quirky personalities. We are serenaded into their glitzy living rooms where sundowners and brunches are planned over bottles of champagne. But all this is peripheral, deep down in the vortex the family shares a shallow void of not feeling loved. While the bankruptcy is just a catalyst to take the story forward, DDD is a story of how superficial even the closest of relationships can be. Anushka Sharma, Rahul Bose and Farhan Akhtar play important supporting roles giving this large ensemble a bit of colour.', CAST(N'2015-06-04 20:23:43.547' AS DateTime), N'b2de3e29-0207-4783-b8c1-99b892f7509f', N'Dil Dhadakne Do movie review: Priyanka Chopra and Anil Kapoor save this ship from sinking faster than the Titanic!')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'a187e1fe-04f9-414c-bde2-d324b82ed560', 1, N'
Britain''s Justin Rose and Masters champion Jordan Spieth were a shot off the clubhouse lead in round one of the Memorial Tournament in Ohio but Tiger Woods battled to a 73.
Rose, 34, the 2013 US Open champion and world number six, birdied four of his opening seven holes in a four-under 68.
Woods, now ranked 172, was four over after nine in his first event for a month, but rallied with three birdies.
Ken Duke, Ryan Moore, Brendon Todd and Harris English all reached five under.
Five times a winner of the tournament at the Jack Nicklaus-designed Muirfield Village Golf Club, Woods began his round from the 10th with a dropped shot after hooking his drive and also bogeyed the next when his approach to the par five finished in the stream guarding the green.
He drove out of the bounds to the right to double bogey the 18', CAST(N'2015-06-05 15:15:14.010' AS DateTime), N'31b91279-9ec0-416d-b628-7f4dd8787806', N' Memorial Tournament: Justin Rose in touch as Tiger Woods struggles')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'3c8b3f99-38bd-454f-be29-dabc941a3ad6', 1, N'More than 40% of elite sportswomen in Great Britain have experienced sexism but only 7% have reported it, according to a survey conducted by BBC Sport.
The anonymous questionnaire was sent to 568 women in almost 40 different sports, with 339 responding.
Asked why sexism was not reported, one respondent said she believed it could affect her selection chances.
Another was worried sexism could be perceived as "banter", while a third said "inequality is normal".
The survey was carried out as part of Women''s Sport Week  and other findings included:
A third of elite sportswomen do not believe they get enough coaching support compared to men
43% said they do not believe their governing body supports them and male colleagues equally
More than two-thirds said they could not make a living as a sportswomen
All but 11 of the respondents believe the media should promote women''s sport better
Nearly 50 elite sportswomen said they had been criticised on social media about their appearance, or even ''trolled''', CAST(N'2015-06-04 20:24:34.000' AS DateTime), N'b2de3e29-0207-4783-b8c1-99b892f7509f', N'Women''s Sport Week: Elite sportswomen suffer sexism')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'17a73a5a-f6a5-4d3d-b7a0-dd2d81a0b973', 3, N'Bollywood musician Himesh Reshamiya says the nine songs that he has composed for Salman Khan starrer family drama Prem Ratan Dhan Payo are romantic and at the same time bear superstar''s signature flair.
', CAST(N'2015-06-04 20:55:14.583' AS DateTime), N'0be03f69-65ca-4c28-8f35-c55e8aaf0fc5', N'''Prem Ratan Dhan Payo'' songs have Salman''s stamp: Himesh Reshamiya')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'd3a57ef7-859b-43bb-9d9a-ef7e78d60c5f', 1, N'Britain''s Justin Rose and Masters champion Jordan Spieth were a shot off the clubhouse lead in round one of the Memorial Tournament in Ohio but Tiger Woods battled to a 73.
Rose, 34, the 2013 US Open champion and world number six, birdied four of his opening seven holes in a four-under 68.
Woods, now ranked 172, was four over after nine in his first event for a month, but rallied with three birdies.
Ken Duke, Ryan Moore, Brendon Todd and Harris English all reached five under.', CAST(N'2015-06-05 15:06:42.720' AS DateTime), N'780521f3-94b7-4fb7-9160-9ca0307626ae', N'Memorial Tournament: Justin Rose in touch as Tiger Woods struggles')
INSERT [dbo].[News] ([ID], [Category], [Details], [CreateDate], [UserID], [Title]) VALUES (N'8605d062-a17f-4ec0-811c-f8d3c3c374c3', 1, N'Lucie Safarova fought back to beat Serbia''s Ana Ivanovic and become the first Czech woman to reach the French Open final in 34 years.
The 13th seed trailed 5-2 in the first set but reeled off five straight games on her way to a 7-5 7-5 win.
She will face world number one Serena Williams, who later beat 23rd seed Timea Bacsinszky, in Saturday''s final.
"It is a dream come true. I cannot believe it," said Safarova after converting a third match point.
"I started slowly but tried to keep up the level and play really aggressively because that was the only way to win."
Safarova made the Wimbledon semi-finals last year, but is through to her first Grand Slam final.
The 28-year-old will try to match the achievement of her compatriot, Hana Mandlikova, who won the title in 1981.', CAST(N'2015-06-04 20:56:08.143' AS DateTime), N'0be03f69-65ca-4c28-8f35-c55e8aaf0fc5', N'French Open 2015: Lucie Safarova beats Ana Ivanovic')
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_Member] FOREIGN KEY([UserID])
REFERENCES [dbo].[Member] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_Member]
GO
