DELIMITER $$

CREATE PROCEDURE Proc_Employee_GetById(IN id char(36))
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
       p.PositionName FROM employee e LEFT JOIN department d ON e.DepartmentId = d.DepartmentId LEFT JOIN positions p ON e.PositionId = p.PositionId
  WHERE e.EmployeeId = id COLLATE utf8_unicode_ci ;
END
$$

DELIMITER ;