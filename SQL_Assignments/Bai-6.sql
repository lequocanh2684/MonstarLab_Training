CREATE TABLE `sys`.`users6` (
  `first_name` VARCHAR(45) NULL,
  `second_name` VARCHAR(45) NULL,
  `attribute` VARCHAR(255) NULL);
  
  INSERT INTO `sys`.`users6`
  VALUE ('Mikel','Cover','%Mikel_Cover%'),
  ('Vicenta','Kravitz','0%Vicenta_Kravitz%'),
  ('Tosha','Cover','02VO1aJ767GF7L1ksdjfskdhfusd'),
  ('Shayne','Dahlquist','0R0V331K8Q7ypBiL33LFJID98%Shayne_Dahlquist%46E3O0u7t7'),
  ('Carrol','Llanes','2mDlb1Sdjne5wfH1AI32BE92r7j1d60PJqwdsadli123sklfna'),
  ('Lizabeth','Cover','d1gM87S0NEHp386jfwiqer1flniJKh21e543asl'),
  ('Mack','Chace','FAnU49nMrmGu30862J7ne3qqqSP549G7'),
  ('Vicenta','Marchese','kUJ3N67vLB07mQL9Ai7p18cXGzjdT32r8283ZQi'),
  ('Mikel','Kravitz','PBX86iw1led87Z9OarE6sdSLdt%Mikel_Kravitz%W73XOY9YaOgi060r2x12D2EmD7'),
  ('Deirdre','Chace','PBX86iw1led87Z9OarE6sdSLdtW73XOY9YaOgi060r2x12D2EmD7'),
  ('Josphine','Arzate','PwWD95BCKVYn5YD7iHLMa3HjP9tH%joshine_arzate%d2hNHNd3RpqfUREN47'),
  ('Deirdre','Chace','ryCE5FlyS8q54A5036luzVS91j6C7P76E9X0O58htzgthuX24LG%DEirdre_Chace%'),
  ('Julietta','Beer','Tn35g5h51u7ltW946J');
  
  SELECT * FROM sys.users6
WHERE LOCATE(CONCAT('%',first_name,'_',second_name, '%'), binary attribute, 2)
ORDER BY attribute ASC;