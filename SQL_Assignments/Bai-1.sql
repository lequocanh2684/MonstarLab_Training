CREATE TABLE `sys`.`user` (
  `id` INT NOT NULL,
  `username` VARCHAR(45) NULL,
  `role` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));
  
  INSERT INTO `sys`.`user`
  VALUES (6,'fasalytch','premium','much.premium@role.com'),
  (13,'luckygirl','regular','fun@meh.com'),
  (16,'todayhumor','guru','today@humor.com'),
  (23,'Felix','admin','felix@codefights.com'),
  (52,'admin666','AdmiN','iamtheadmin@admin.admin'),
  (87,'solver100500','regular','email@notbot.com');
  
  SELECT email FROM sys.user
WHERE role NOT LIKE 'admin' and role NOT LIKE 'premium'
ORDER BY email ASC;
