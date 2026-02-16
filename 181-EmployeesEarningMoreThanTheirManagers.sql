/* Write your T-SQL query statement below */
SELECT name as Employee FROM
(SELECT e.name, e.salary, e2.salary as managerSalary FROM Employee AS e
LEFT JOIN Employee as e2
ON e.managerId = e2.id) t
WHERE salary>managerSalary;
