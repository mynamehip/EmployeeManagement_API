DELIMITER $$

CREATE PROCEDURE Proc_Position_GetAll()
BEGIN
  SELECT
    p.PositionId,
    p.PositionName
  FROM positions p;
END
$$

DELIMITER ;