CREATE TABLE department (
  DepartmentId CHAR(36) NOT NULL DEFAULT '' COMMENT 'Id phòng ban',
  DepartmentName VARCHAR(255) NOT NULL DEFAULT '' COMMENT 'Tên phòng ban',
  CreatedDate DATE DEFAULT NULL COMMENT 'Ngày tạo',
  CreatedBy VARCHAR(255) DEFAULT NULL COMMENT 'Người tạo',
  ModifiedDate DATE DEFAULT NULL COMMENT 'Ngày chỉnh sửa',
  ModifiedBy VARCHAR(255) DEFAULT NULL COMMENT 'Người chỉnh sửa',
  PRIMARY KEY (DepartmentId)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
ROW_FORMAT = DYNAMIC;

ALTER TABLE department 
  ADD UNIQUE INDEX IX_Department_DepartmentName(DepartmentName);