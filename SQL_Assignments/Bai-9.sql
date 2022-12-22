CREATE TABLE `sys`.`full_year` (
  `id` INT NOT NULL,
  `newspaper` VARCHAR(45) NULL,
  `subcriber` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));
  
  CREATE TABLE `sys`.`half_year` (
  `id` INT NOT NULL,
  `newspaper` VARCHAR(45) NULL,
  `subcriber` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));
  
  INSERT INTO `sys`.`full_year`
  VALUE (1,'The Paragon Herald','Crissy Sepe'),
  (2,'The Daily Reporter','Tonie Moreton'),
  (3,'Morningtide Daily','Erwin Chitty'),
  (4,'Daily Breakfast','Tonie Moreton'),
  (5,'Independent Weekly','Lavelle Phu');
  
  INSERT INTO `sys`.`half_year`
  VALUE (1,'The Daily Reporter','Lavelle Phu'),
  (2,'Daily Breakfast','Tonie Moreton'),
  (3,'The Paragon Herald','Lia Cover'),
  (4,'The Community Gazette','Lavelle Phu'),
  (5,'Nova Daily','Lia Cover'),
  (6,'Nova Daily','Joya Buss');
  
  SELECT full_year.subcriber FROM sys.full_year
WHERE newspaper LIKE '%Daily%'
UNION
SELECT half_year.subcriber FROM sys.half_year
WHERE newspaper LIKE '%Daily%'
ORDER BY subcriber ASC;