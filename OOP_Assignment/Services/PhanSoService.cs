using System;
using OOP_Assignment.Models;

namespace OOP_Assignment.Services
{
	public class PhanSoService:IPhanSoService
	{
		public PhanSoService()
		{
		}

		public PhanSo PhepCong(PhanSo phanSo1, PhanSo phanSo2)
		{
			PhanSo temp = new();
			if(phanSo1.MauSo == phanSo2.MauSo)
			{
				temp.TuSo = phanSo1.TuSo + phanSo2.TuSo;
				temp.MauSo = phanSo1.MauSo;
			}
			else
			{
				temp = ChuanHoa(QuyDong(phanSo1, phanSo2, "PhepCong"));
			}
			return temp;
		}

		public PhanSo PhepTru(PhanSo phanSo1, PhanSo phanSo2)
		{
            PhanSo temp = new();
            if (phanSo1.MauSo == phanSo2.MauSo)
            {
                temp.TuSo = phanSo1.TuSo - phanSo2.TuSo;
                temp.MauSo = phanSo1.MauSo;
            }
            else
            {
                temp = ChuanHoa(QuyDong(phanSo1, phanSo2, "PhepTru"));
            }
            return temp;
        }

		public PhanSo PhepNhan(PhanSo phanSo1, PhanSo phanSo2)
		{
			PhanSo temp = new();
            temp.TuSo = phanSo1.TuSo * phanSo2.TuSo;
			temp.MauSo = phanSo1.MauSo * phanSo2.MauSo;
			return ChuanHoa(temp);
        }

		public PhanSo PhepChia(PhanSo phanSo1, PhanSo phanSo2)
		{
            PhanSo temp = new();
            temp.TuSo = phanSo1.TuSo * phanSo2.MauSo;
            temp.MauSo = phanSo1.MauSo * phanSo2.TuSo;
            return ChuanHoa(temp);
        }

		public void Display()
		{
			Console.WriteLine("Hay nhap 2 phan so voi dinh dang x/y va y phai khac 0");

			//Nhap hai phan so
			Console.Write("Phan so thu 1: ");
			string?[] tempPS1 = Console.ReadLine().Split('/');
			PhanSo phanSo1 = new(Convert.ToInt32(tempPS1[0]), Convert.ToInt32(tempPS1[1]));
			Console.Write("Phan so thu 2: ");
			string?[] tempPS2 = Console.ReadLine().Split('/');
			PhanSo phanSo2 = new(Convert.ToInt32(tempPS2[0]), Convert.ToInt32(tempPS2[1]));

			//Tinh toan
			PhanSo phanSoCong = PhepCong(phanSo1, phanSo2);
			PhanSo phanSoTru = PhepTru(phanSo1, phanSo2);
			PhanSo phanSoNhan = PhepNhan(phanSo1, phanSo2);
			PhanSo phanSoChia = PhepChia(phanSo1, phanSo2);

			//Hien thi
			Console.WriteLine($"\nKet qua phep cong 2 phan so vua nhap: {phanSoCong.TuSo}/{phanSoCong.MauSo}");
			if (phanSoTru.TuSo == 0)
			{
                Console.WriteLine($"\nKet qua phep tru 2 phan so vua nhap: 0");
			}
			else
			{
                Console.WriteLine($"\nKet qua phep tru 2 phan so vua nhap: {phanSoTru.TuSo}/{phanSoTru.MauSo}");
            }
			if (phanSoNhan.TuSo == 0)
			{
				Console.WriteLine($"\nKet qua phep nhan 2 phan so vua nhap: 0");
			}
			else
			{
				Console.WriteLine($"\nKet qua phep nhan 2 phan so vua nhap: {phanSoNhan.TuSo}/{phanSoNhan.MauSo}");
			}
            Console.WriteLine($"\nKet qua phep chia 2 phan so vua nhap: {phanSoChia.TuSo}/{phanSoChia.MauSo}");

        }

		private PhanSo QuyDong(PhanSo phanSo1, PhanSo phanSo2, string phepTinh)
		{
			PhanSo temp1 = new();
			temp1.MauSo = phanSo1.MauSo * phanSo2.MauSo;
			switch (phepTinh)
			{
				case "PhepCong":
					temp1.TuSo = phanSo1.TuSo * phanSo2.MauSo + phanSo2.TuSo * phanSo1.MauSo;
					break;
				case "PhepTru":
                    temp1.TuSo = phanSo1.TuSo * phanSo2.MauSo - phanSo2.TuSo * phanSo1.MauSo;
					break;
            }
			return temp1;
		}

		private PhanSo ChuanHoa (PhanSo tempPhanSo)
		{
			long ucln = new();
			int check = new();
			if (tempPhanSo.TuSo == 0)
			{
				return new PhanSo(0, tempPhanSo.MauSo);
			}
			if (tempPhanSo.TuSo < 0)
			{
				tempPhanSo.TuSo *= (-1);
				ucln = tempPhanSo.TuSo;
				check = 1;
			} else
			{
				ucln = tempPhanSo.TuSo;
			}
			long x = tempPhanSo.MauSo;
			while (x != 0)
			{
				long y = x;
				x = ucln % x;
				ucln = y;
			}
			tempPhanSo.TuSo = tempPhanSo.TuSo / ucln;
			if (check == 1)
			{
				tempPhanSo.TuSo *= (-1);
			}
			tempPhanSo.MauSo = tempPhanSo.MauSo / ucln;
			return tempPhanSo;
		}
	}
}

