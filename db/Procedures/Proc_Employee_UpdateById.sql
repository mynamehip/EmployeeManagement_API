DELIMITER $$

CREATE PROCEDURE Proc_Employee_UpdateById(IN employeeId CHAR(36), IN employeeCode VARCHAR(20), IN fullName VARCHAR(100), IN departmentId CHAR(36), IN positionId CHAR(36), IN dateOfBirth DATE, IN gender INT, IN identityNumber VARCHAR(25), IN issueDate DATE, IN issuePlace VARCHAR(225), IN address VARCHAR(255), IN phoneNumber VARCHAR(50), IN email VARCHAR(100), IN bankNumber VARCHAR(25), IN bankName VARCHAR(225), IN BankBranches VARCHAR(225))
  COMMENT 'Sửa thông tin nhân viên theo id'
BEGIN
  UPDATE employee e SET 
    e.EmployeeCode = employeeCode,
    e.FullName = fullName,
    e.DepartmentId = departmentId,
    e.PositionId = positionId,
    e.DateOfBirth = dateOfBirth,
    e.Gender = gender,
    e.IdentityNumber = identityNumber,
    e.IssueDate = issueDate,
    e.IssuePlace = issuePlace,
    e.Address= address,
    e.PhoneNumber = phoneNumber,
    e.Email = email,
    e.BankNumber = bankNumber,
    e.BankName = bankName,
    e.BankBranches = BankBranches
  WHERE e.EmployeeId = employeeId COLLATE utf8_unicode_ci;
END
$$

DELIMITER ;