DECLARE @FirstTable Table (Col1 int, Col2 int)
insert into @FirstTable 
values (1,2)
insert into @FirstTable 
values (3,4)
insert into @FirstTable
values (5,6) 
insert into @FirstTable 
values (7,8)


;WITH T1 AS (

SELECT A, B
FROM 
(
	VALUES
		(1, 21)
		,(3, 41)
		,(5, 61)
		,(7, 81)
) AS MyTable(A, B) )

UPDATE 
	T
SET	 
	T.Col2 = T1.B
FROM 
	@FirstTable as T
INNER JOIN T1
	ON T.Col1 = T1.A