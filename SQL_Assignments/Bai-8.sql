CREATE TABLE `sys`.`expressions` (
  `id` INT NOT NULL,
  `a` INT NULL,
  `b` INT NULL,
  `operation` VARCHAR(45) NULL,
  `c` INT NULL,
  PRIMARY KEY (`id`));
  
  INSERT INTO `sys`.`expressions`
  VALUE (1,2,3,'+',5),
  (2,2,3,'+',6),
  (3,3,2,'/',1),
  (4,4,7,'*',28),
  (5,54,2,'-',27),
  (6,3,0,'/',0);
  
  SELECT * FROM sys.expressions
WHERE operation = '+' AND a + b = c OR
operation = '-' AND a - b = c OR
operation = '*' AND a * b = c OR
operation = '/' AND a / b = c;