CREATE TABLE `sys`.`Products` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `price` INT NULL,
  `quantity` INT NULL,
  PRIMARY KEY (`id`));
  
  INSERT INTO `sys`.`Products`
  VALUES (1,'Tomato',10,4),
  (2,'Cucumber',8,5),
  (3,'Red Pepper',20,2),
  (4,'Feta',40,1);
  
  SELECT name FROM sys.Products
WHERE (price * quantity) = (SELECT MAX(price * quantity) FROM sys.Products)
ORDER BY name ASC
LIMIT 1;