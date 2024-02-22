DELIMITER $$

CREATE PROCEDURE Proc_Employee_Create(IN employeeId CHAR(36), IN employeeCode VARCHAR(20), IN fullName VARCHAR(100), IN departmentId CHAR(36), IN positionId CHAR(36), IN dateOfBirth DATE, IN gender INT, IN identityNumber VARCHAR(25), IN issueDate DATE, IN issuePlace VARCHAR(225), IN address VARCHAR(255), IN phoneNumber VARCHAR(50), IN email VARCHAR(100), IN bankNumber VARCHAR(25), IN bankName VARCHAR(225), IN BankBranches VARCHAR(225), IN createdDate datetime, IN createdBy varchar(255), IN modifiedDate datetime, IN modifiedBy varchar(255))
  COMMENT 'Thêm nhân viên vào bảng'
BEGIN
  INSERT INTO Employee (EmployeeId, EmployeeCode, FullName, DepartmentId, PositionId, DateOfBirth, Gender, IdentityNumber, IssueDate, IssuePlace, Address, PhoneNumber, Email, BankNumber, BankName, BankBranches, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
  VALUES (employeeId, employeeCode, fullName, departmentId, positionId, dateOfBirth, gender, identityNumber, issueDate, issuePlace, address, phoneNumber, email, bankNumber, bankName, BankBranches,createdDate, createdBy, modifiedDate, modifiedBy);
END
$$

DELIMITER ;