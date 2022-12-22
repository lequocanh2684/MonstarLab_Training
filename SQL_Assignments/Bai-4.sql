CREATE TABLE `sys`.`Grades` (
  `Name` VARCHAR(45) NULL,
  `ID` INT NOT NULL,
  `Midterm1` INT NULL,
  `Midterm2` INT NULL,
  `Final` INT NULL,
  PRIMARY KEY (`ID`));
  
 INSERT INTO `sys`.`Grades`
 VALUES ('David',42334,34,53,124),
  ('Anthony',54528,100,10,50),
  ('Jonathan',58754,49,58,121),
  ('Jonty',11000,25,30,180);
  
  SELECT Name, ID FROM sys.Grades
WHERE Final > (Midterm1 + Midterm2)
ORDER BY SUBSTRING(Name, 1,3);