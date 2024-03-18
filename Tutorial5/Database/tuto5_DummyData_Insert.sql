USE [staffData]
GO


INSERT INTO [dbo].[staffTable] ([staff_no], [staff_name], [join_from], [dob], [staff_type], [nrc_number], [gender], [phone_no_1], [phone_no_2], [photo], [address], [is_deleted])
VALUES
('S1001', 'John Doe', '2020-01-01', '1990-05-15', 1, '123456/78/90', 1, '1234567890', NULL, NULL, '123 Main St, City', 0),
('S1002', 'Jane Smith', '2019-03-15', '1988-08-20', 2, '987654/32/10', 2, '0987654321', '0123456789', NULL, '456 Elm St, Town', 0),
('S1003', 'Alice Johnson', '2021-07-10', '1995-11-30', 1, '456789/01/23', 2, '5556667777', NULL, NULL, '789 Oak St, Village', 0),
('S1004', 'Bob Brown', '2018-12-20', '1985-04-10', 3, '333444/56/78', 1, '7778889999', NULL, NULL, '321 Pine St, Hamlet', 0),
('S1005', 'Emily Davis', '2022-02-28', '1998-09-25', 2, '222333/44/55', 2, '4445556666', '3332221111', NULL, '567 Cedar St, County', 0),
('S1006', 'Michael Wilson', '2020-05-12', '1992-07-05', 1, '555666/77/88', 1, '9990001111', NULL, NULL, '234 Maple St, Borough', 0),
('S1007', 'Sarah Taylor', '2019-11-08', '1987-03-18', 2, '444555/66/77', 2, '1112223333', '9998887777', NULL, '890 Walnut St, State', 0),
('S1008', 'David Martinez', '2023-09-03', '1993-12-22', 3, '777888/99/00', 1, '2223334444', NULL, NULL, '876 Pineapple St, Country', 0),
('S1009', 'Olivia Anderson', '2017-06-25', '1980-10-05', 2, '888999/11/22', 2, '3334445555', '6667778888', NULL, '543 Peach St, Republic', 0),
('S1010', 'Daniel Garcia', '2024-01-15', '1996-06-15', 1, '111222/33/44', 1, '6667778888', NULL, NULL, '432 Orange St, Principality', 0);
