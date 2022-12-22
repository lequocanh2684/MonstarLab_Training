CREATE TABLE `sys`.`Suspect` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `surname` VARCHAR(45) NULL,
  `height` INT NULL,
  `weight` INT NULL,
  PRIMARY KEY (`id`));
  
  INSERT INTO `sys`.`Suspect`
  VALUE (1,'John','Doe',165,60),
  (2,'Bill','Green',170,67),
  (3,'Baelfire','Grehn',172,70),
  (4,'Bill','Gretan',165,55),
  (5,'Brendon','Grewn',150,50),
  (6,'bill','Green',169,50);
  
  SELECT id, name, surname FROM sys.Suspect
WHERE height < 170
AND name LIKE 'B%'
AND surname LIKE 'Gre%_%n';