USE SoftUni

INSERT INTO Towns ([Name]) VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

INSERT INTO Departments ([Name]) VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary)
VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '20130201', 3500.00),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '20040302', 4000.00),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '20160828', 525.25),
('Georgi', 'Terziev', 'Ivanov', 'CEO', 2, '20071209', 3000.00),
('Peter', 'Pan', 'Pan', 'Intern', 3, '20160828', 599.88)

TRUNCATE TABLE Employees