DELIMITER $$

CREATE PROCEDURE Proc_Department_GetAll()
BEGIN
  SELECT d.DepartmentId,
         d.DepartmentName FROM department d;
END
$$

DELIMITER ;