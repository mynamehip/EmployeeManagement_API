DELIMITER $$

CREATE PROCEDURE Proc_Position_GetById(IN id char(36))
BEGIN
  SELECT
    p.PositionId,
    p.PositionName
  FROM positions p
  WHERE P.PositionId = id COLLATE utf8_unicode_ci;
END
$$

DELIMITER ;