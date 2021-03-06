USE [FinaceManager]
GO
/****** Object:  StoredProcedure [dbo].[Pagination]    Script Date: 2016/5/6 14:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE  PROCEDURE [dbo].[Pagination]
/**//**************************************************************
** 千万数量级分页存储过程 **
***************************************************************
参数说明:
1.Tables :表名称,视图，不带dbo.
2.PrimaryKey :主关键字
3.Sort :排序语句，不带Order By 比如：NewsID Desc,OrderRows Asc (Desc Asc前必须加空格)
4.CurrentPage :当前页码
5.PageSize :分页尺寸
6.Fields: 字段名
7.Filter :过滤语句，不带Where 
8.Group :Group语句,不带Group By
9.T:操作类型,1统计总数，0读取数据
***************************************************************/
(
@Tables varchar(1000),
@PrimaryKey varchar(100),
@Sort varchar(200) = NULL,
@CurrentPage int = 1,
@PageSize int = 20,
@Fields varchar(1000) = '*',
@Filter varchar(1000) = NULL,
@Group varchar(1000) = NULL,
@T bit = 0
)
AS
SET NOCOUNT ON
/**//*默认排序*/
SET @Sort = RTRIM( LTRIM(@Sort) )
SET @Sort = REPLACE( REPLACE(@Sort, '[', ''),']','')
IF @Sort IS NULL or @Sort = ''
SET @Sort = @PrimaryKey
DECLARE @SortTable varchar(100)
DECLARE @SortName varchar(100)
DECLARE @strSortColumn varchar(200)
DECLARE @operator char(2)
DECLARE @type varchar(100)
DECLARE @prec int
DECLARE @SQL1 varchar(4000),@SQL2 varchar(4000)
/**//*设定排序语句.*/
IF CHARINDEX('DESC',@Sort)>0
BEGIN
SET @strSortColumn = REPLACE(@Sort, ' DESC', '')
SET @operator = '<='
END
ELSE
BEGIN
IF CHARINDEX('ASC', @Sort) > 0
SET @strSortColumn = REPLACE(@Sort, ' ASC', '')
SET @operator = '>='
END
IF CHARINDEX('.', @strSortColumn) > 0
BEGIN
SET @SortTable = SUBSTRING(@strSortColumn, 0, CHARINDEX('.',@strSortColumn))
SET @SortName = SUBSTRING(@strSortColumn, CHARINDEX('.',@strSortColumn) + 1, LEN(@strSortColumn))
END
ELSE
BEGIN
SET @SortTable = @Tables
SET @SortName = @strSortColumn
END
Select @type=t.name, @prec=c.prec
FROM sysobjects o 
JOIN syscolumns c on o.id=c.id
JOIN systypes t on c.xusertype=t.xusertype
Where o.name = @SortTable AND c.name = @SortName
IF CHARINDEX('char', @type) > 0
SET @type = @type + '(' + CAST(@prec AS varchar) + ')'
DECLARE @strPageSize varchar(50)
DECLARE @strStartRow varchar(50)
DECLARE @strFilter varchar(1000)
DECLARE @strSimpleFilter varchar(1000)
DECLARE @strGroup varchar(1000)
/**//*默认当前页*/
IF @CurrentPage < 1
SET @CurrentPage = 1
/**//*设置分页参数.*/
SET @strPageSize = CAST(@PageSize AS varchar(50))
SET @strStartRow = CAST(((@CurrentPage - 1)*@PageSize + 1) AS varchar(50))
/**//*筛选以及分组语句.*/
IF @Filter IS NOT NULL AND @Filter != ''
BEGIN
SET @strFilter = dbo.Func_ParseCondition(@Filter)
	DECLARE @pos INT
	SET @pos = 0
	--获取 and在输入条件的位置
	SET @pos = CHARINDEX(' and',@Filter)
	--如果输入条件中存在 and, 并且 and出现在末尾
	IF @pos > 0 AND SUBSTRING(@Filter,LEN(@Filter)-3,LEN(@Filter)) = ' and'
		BEGIN
			--截断末尾的 and
			SET @strSimpleFilter ='AND ' + SUBSTRING(@Filter,1,LEN(@Filter)-4) + ' '
		END
	Else
		BEGIN
			SET @strSimpleFilter = 'AND ' + @Filter + ' '
		END
END
ELSE
BEGIN
SET @strSimpleFilter = ''
SET @strFilter = ''
END
IF @Group IS NOT NULL AND @Group != ''
BEGIN
SET @strGroup = ' GROUP BY ' + @Group + ' '
END
ELSE
BEGIN
SET @strGroup = ''
END

/**//*执行统计*/
IF @T = 1
BEGIN
	
	SET @SQL1=	'Select COUNT( ' + @PrimaryKey + ') AS COUNTS FROM ' + @Tables + @strFilter +@strGroup  
	PRINT (@SQL1)
	EXEC (@SQL1)	
END
ELSE
BEGIN
/**//*执行查询语句*/
IF @CurrentPage = 1
BEGIN
    SET @SQL1 ='Select top ' + @strPageSize +' '+ @Fields + ' FROM ' + @Tables + ' ' + @strFilter +@strGroup + ' orDER BY ' + @Sort
    SET @SQL2 = ''
END
ELSE
BEGIN
--分段
SET @SQL1 = 'DECLARE @S ' + @type + ' SET ROWCOUNT ' + @strStartRow + ' Select @S=' + @strSortColumn + ' FROM ' + @Tables + @strFilter + @strGroup + ' orDER BY ' + @Sort 
SET @SQL2 = ' SET ROWCOUNT ' + @strPageSize + ' Select ' + @Fields + ' FROM ' + @Tables + ' Where ' + @strSortColumn + @operator + ' @S ' + @strSimpleFilter + ' ' + @strGroup + 'ORDER BY ' + @Sort + ''
END
PRINT (@SQL1+@SQL2)
EXEC (@SQL1+@SQL2)
END


GO
/****** Object:  StoredProcedure [dbo].[proc_Init]    Script Date: 2016/5/6 14:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Init]
as 
begin
 begin transaction
 declare @error int
 set @error=0
     set @error=@error+@@error
     truncate table dbo.Stale_Employee
     set @error=@error+@@error
     truncate table dbo.Stale_Department
	 set @error=@error+@@error
		 truncate table dbo.Stale_Contract
	 set @error=@error+@@error
		 truncate table dbo.Stale_Income
	set @error=@error+@@error
		 truncate table dbo.Stale_Invoice
	set @error=@error+@@error
		 truncate table dbo.Stale_InvoiceMX
	set @error=@error+@@error
     truncate table dbo.Stale_Outlay
set @error=@error+@@error
     truncate table dbo.Stale_Left
set @error=@error+@@error
     truncate table dbo.Stale_Salary
set @error=@error+@@error
     truncate table dbo.Stale_Wage
     set @error=@error+@@error 
     truncate table dbo.Stale_Log
     set @error=@error+@@error
if(@error=0)
  commit transaction
if(@error>0)
  begin
  rollback transaction
  select 0;
  end
end




GO
