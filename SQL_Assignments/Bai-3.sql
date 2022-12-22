CREATE TABLE `sys`.`users` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `score` INT NULL,
  PRIMARY KEY (`id`));
  
  INSERT INTO `sys`.`users`
  VALUES (1,'gongy',3001),
  (2,'urandom',2401),
  (3,'eduardische',2477),
  (4,'Gassa',2999),
  (5,'bcc32',2658),
  (6,'Alex_2oo8',6000),
  (7,'mirosuaf',2479),
  (8,'Sparik',2399),
  (9,'thomas_holmes',2478),
  (10,'cthaeghya',2400);
  
  WITH temp AS(SELECT name, ROW_NUMBER() OVER (ORDER BY score DESC) row_num FROM sys.users)
SELECT name FROM temp WHERE row_num BETWEEN 4 AND 8;