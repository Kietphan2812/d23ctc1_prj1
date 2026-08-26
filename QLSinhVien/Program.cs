namespace QLSinhVien;
public interface SinhVien
{
    void Them(QLSinhVien sv);

}
public class QLSinhVien:SinhVien
{
    public int MaSV {get;set;}
    public string TenSV {get;set;}
    public double Gpa {get;set;}
    List<QLSinhVien> qLSinhViens1=new List<QLSinhVien>();
    public QLSinhVien(int masv,string tensv,double gpa)
    {
        MaSV=masv;
        TenSV=tensv;
        Gpa= gpa;
  
    }
    public void Them(QLSinhVien sv)
    {
       qLSinhViens1.Add(sv);
    }
    public void InSinhVien()
    {
        foreach (var item in qLSinhViens1)
        {
            Console.WriteLine($"{item.MaSV},{item.TenSV},{item.Gpa}");
        }
    }

}
