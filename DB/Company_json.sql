
USE Company;
GO

DECLARE @jsonData NVARCHAR(MAX);

SET @jsonData='{"region_id":1}';

EXEC employee_json @jsonData;