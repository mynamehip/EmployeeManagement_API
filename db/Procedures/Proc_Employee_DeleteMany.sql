DELIMITER $$

CREATE PROCEDURE Proc_Employee_DeleteMany(IN listIds varchar(255))
  COMMENT 'Xóa nhiều'
BEGIN
    SET @sql = CONCAT('DELETE FROM employee WHERE EmployeeId IN (', @listIds, ')');
    PREPARE stmt FROM @sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END
$$

DELIMITER ;