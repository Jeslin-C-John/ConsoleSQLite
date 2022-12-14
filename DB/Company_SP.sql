
USE Company;
GO

ALTER PROCEDURE employee_json
@jsonData NVARCHAR(max) 
AS
BEGIN
	
	SELECT employees.first_name, jobs.job_title, dependents.first_name, departments.department_name, locations.city, countries.country_name, regions.region_name
	FROM Company.HR.employees
	INNER JOIN Company.HR.jobs 
	ON employees.job_id = jobs.job_id
	INNER JOIN Company.HR.departments 
	ON employees.department_id = departments.department_id
	INNER JOIN Company.HR.dependents 
	ON employees.employee_id = dependents.employee_id
	INNER JOIN Company.HR.locations 
	ON departments.location_id = locations.location_id
	INNER JOIN Company.HR.countries 
	ON locations.country_id = countries.country_id
	INNER JOIN Company.HR.regions 
	ON regions.region_id = countries.region_id  
	INNER JOIN OPENJSON (@jsonData)
	WITH (region_no INT '$.region_id')
	AS input 
	ON input.region_no = regions.region_id
	FOR JSON AUTO;

END;