DELIMITER $$

CREATE PROCEDURE Proc_Employee_DeleteById(IN id char(36))
  COMMENT 'Xóa nhân viên theo id'
BEGIN
  DELETE FROM Employee WHERE EmployeeId = id COLLATE utf8_unicode_ci;
END
$$

DELIMITER ;