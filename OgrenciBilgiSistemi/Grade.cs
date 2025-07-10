using OgrenciBilgiSistemi;

public class Grade
{
    public int Id { get; set; }
    public double Grades { get; set; }

    // Foreign keys
    public int OgrenciId { get; set; }
    public Ogrenci Ogrenci { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }

    public double WeightedGrade { get; set; }
}
