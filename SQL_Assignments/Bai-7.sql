CREATE TABLE `sys`.`answers` (
  `id` INT NOT NULL,
  `correct_answer` VARCHAR(45) NULL,
  `given_answer` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));
  
  INSERT INTO `sys`.`answers`
  VALUE (1,'a','a'),
  (2,'b','NULL'),
  (3,'c','b');
  
  SELECT id,
CASE
	WHEN correct_answer = given_answer then 'correct'
    WHEN given_answer = 'NULL' then 'no answer'
ELSE 'incorrect'
END AS checks
FROM sys.answers;
  
  