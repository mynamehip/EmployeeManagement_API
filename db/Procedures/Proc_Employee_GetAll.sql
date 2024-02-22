DELIMITER $$

CREATE PROCEDURE Proc_Employee_GetAll()
BEGIN
  SELECT e.EmployeeId,
       e.EmployeeCode,
       e.FullName,
       e.DepartmentId,
       e.PositionId,
       e.DateOfBirth,
       e.Gender,
       e.IdentityNumber,
       e.IssueDate,
       e.IssuePlace,
       e.Address,
       e.PhoneNumber,
       e.Email,
       e.BankNumber,
       e.BankName,
       e.BankBranches,
       e.CreatedDate,
       e.CreatedBy,
       e.ModifiedDate,
       e.ModifiedBy,
       d.DepartmentName,
       p.PositionName FROM employee e INNER JOIN department d ON e.DepartmentId = d.DepartmentId INNER JOIN positions p ON e.PositionId = p.PositionId
       ORDER BY e.CreatedDate DESC;
END
$$

DELIMITER ;