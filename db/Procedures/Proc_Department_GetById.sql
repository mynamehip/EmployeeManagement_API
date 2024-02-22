DELIMITER $$

CREATE PROCEDURE Proc_Department_GetById(IN id char(36))
BEGIN
  SELECT d.DepartmentId,
         d.DepartmentName FROM department d WHERE d.DepartmentId = id COLLATE utf8_unicode_ci ;
END
$$

DELIMITER ;