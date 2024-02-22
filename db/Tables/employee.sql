CREATE TABLE employee (
  EmployeeId CHAR(36) NOT NULL DEFAULT '' COMMENT 'Id',
  EmployeeCode VARCHAR(20) NOT NULL DEFAULT '' COMMENT 'Mã nhân viên',
  FullName VARCHAR(100) NOT NULL DEFAULT '' COMMENT 'Tên nhân viên',
  DepartmentId CHAR(36) DEFAULT '' COMMENT 'Id phòng ban',
  PositionId CHAR(36) DEFAULT '' COMMENT 'Id chức vụ',
  DateOfBirth DATE DEFAULT NULL COMMENT 'Ngày sinh',
  Gender SMALLINT(6) DEFAULT NULL COMMENT 'Giới tính',
  IdentityNumber VARCHAR(25) DEFAULT NULL COMMENT 'Số căn cước',
  IssueDate DATE DEFAULT NULL COMMENT 'Ngày cấp căn cước',
  IssuePlace VARCHAR(255) DEFAULT NULL COMMENT 'Nơi cấp căn cước',
  Address VARCHAR(255) DEFAULT NULL COMMENT 'Địa chỉ',
  PhoneNumber VARCHAR(50) DEFAULT NULL COMMENT 'Số điện thoại',
  Email VARCHAR(100) DEFAULT NULL COMMENT 'Email',
  BankNumber VARCHAR(25) DEFAULT NULL COMMENT 'Tài khoản ngân hàng',
  BankName VARCHAR(255) DEFAULT NULL COMMENT 'Ngân hàng',
  BankBranches VARCHAR(255) DEFAULT NULL COMMENT 'Chi nhánh ngân hàng',
  CreatedDate DATE DEFAULT NULL COMMENT 'Ngày tạo',
  CreatedBy VARCHAR(255) DEFAULT NULL COMMENT 'Tạo bởi',
  ModifiedDate DATE DEFAULT NULL COMMENT 'Ngày chỉnh sửa gần nhất',
  ModifiedBy VARCHAR(255) DEFAULT NULL COMMENT 'Người chỉnh sửa gần nhất',
  PRIMARY KEY (EmployeeId)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 595,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'Bảng nhân viên',
ROW_FORMAT = DYNAMIC;

ALTER TABLE employee 
  ADD INDEX IX_employee(EmployeeCode);

ALTER TABLE employee 
  ADD CONSTRAINT FK_employee_DepartmentId FOREIGN KEY (DepartmentId)
    REFERENCES department(DepartmentId) ON DELETE CASCADE ON UPDATE NO ACTION;

ALTER TABLE employee 
  ADD CONSTRAINT FK_employee_PositionId FOREIGN KEY (PositionId)
    REFERENCES positions(PositionId) ON DELETE CASCADE ON UPDATE NO ACTION;