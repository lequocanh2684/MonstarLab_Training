namespace OOP_Assignment.Models
{
    public class PhanSo
    {
        public long TuSo { get; set; }
        public long MauSo { get; set; }

        public PhanSo()
        {
        }

        public PhanSo(long tuSo, long mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
    }
}

