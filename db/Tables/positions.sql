CREATE TABLE positions (
  PositionId CHAR(36) NOT NULL DEFAULT '' COMMENT 'Id vị trí',
  PositionName VARCHAR(255) NOT NULL DEFAULT '' COMMENT 'tên vị trí',
  CreatedDate DATE DEFAULT NULL COMMENT 'Ngày tạo',
  CreatedBy VARCHAR(255) DEFAULT NULL COMMENT 'Người tạo',
  ModifiedDate DATE DEFAULT NULL COMMENT 'Ngày chỉnh sửa gần nhất',
  ModifiedBy VARCHAR(255) DEFAULT NULL COMMENT 'Người chỉnh sửa gần nhất',
  PRIMARY KEY (PositionId)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'Bảng vị trí',
ROW_FORMAT = DYNAMIC;

ALTER TABLE positions 
  ADD UNIQUE INDEX IX_position_PositionName(PositionName);