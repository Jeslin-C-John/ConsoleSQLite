--CREATE DATABASE Company;
--USE Company;
--CREATE SCHEMA HR;

--CREATE TABLE Company.HR.regions(region_id INT IDENTITY Primary Key, region_name TEXT);
--CREATE TABLE Company.HR.countries(country_id INT IDENTITY Primary Key, country_name TEXT, region_id INT, FOREIGN KEY (region_id) REFERENCES Company.HR.regions(region_id));
--CREATE TABLE Company.HR.locations(location_id INT IDENTITY Primary Key, street_address TEXT, postal_code INT, city TEXT, state_province TEXT, country_id INT, FOREIGN KEY (country_id) REFERENCES Company.HR.countries(country_id));
--CREATE TABLE Company.HR.departments(department_id INT IDENTITY Primary Key, department_name TEXT, location_id INT, FOREIGN KEY (location_id) REFERENCES Company.HR.locations(location_id));
--CREATE TABLE Company.HR.jobs(job_id INT IDENTITY Primary Key, job_title TEXT, min_salary INT, max_salary INT);
--CREATE TABLE Company.HR.employees(employee_id INT IDENTITY Primary Key, first_name TEXT, last_name TEXT, email TEXT, phone_number VARCHAR(10), hire_date DATE, job_id INT, Salary INT, manager_id INT, department_id INT, FOREIGN KEY (job_id) REFERENCES Company.HR.jobs(job_id), FOREIGN KEY (manager_id) REFERENCES Company.HR.employees(employee_id), FOREIGN KEY (department_id) REFERENCES Company.HR.departments(department_id));
--CREATE TABLE Company.HR.dependents(dependent_id INT IDENTITY Primary Key, first_name TEXT, last_name TEXT, relationship TEXT, employee_id INT, FOREIGN KEY (employee_id) REFERENCES Company.HR.employees(employee_id));




GO
--INSERT INTO Company.HR.jobs (job_title, min_salary, max_salary) VALUES ('Manager', 80000, 350000);
SELECT * from Company.HR.jobs;

--INSERT INTO Company.HR.regions (region_name) VALUES ('North Pacific');
SELECT * from Company.HR.regions;


--INSERT INTO Company.HR.countries (country_name, region_id) VALUES ('China', 2);
SELECT * from Company.HR.countries;

--INSERT INTO Company.HR.locations (street_address, postal_code, city, state_province, country_id) VALUES ('Kakkanchery', 654583, 'Kozhikode', 'Kerala', 1);
SELECT * from Company.HR.locations;

--INSERT INTO Company.HR.departments (department_name, location_id) VALUES ('HR', 2);
SELECT * from Company.HR.departments;

--INSERT INTO Company.HR.employees (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) VALUES ('Jeff', 'Bezoz', 'jeffbezoz@aws.com', '1114564589', '2021/07/04', 3, 280000, 1, 1);
SELECT * from Company.HR.employees;

--INSERT INTO Company.HR.dependents (first_name, last_name, relationship, employee_id) VALUES ('Danerys', 'Targeriyan', 'Mother', 2);
SELECT * from Company.HR.dependents;