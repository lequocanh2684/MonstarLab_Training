using System;
using OOP_Assignment.Models;

namespace OOP_Assignment.Services
{
	public interface IPhanSoService
	{
		PhanSo PhepCong(PhanSo phanSo1, PhanSo phanSo2);
        PhanSo PhepTru(PhanSo phanSo1, PhanSo phanSo2);
        PhanSo PhepNhan(PhanSo phanSo1, PhanSo phanSo2);
        PhanSo PhepChia(PhanSo phanSo1, PhanSo phanSo2);
        void Display();
    }
}

