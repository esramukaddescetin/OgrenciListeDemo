// See https://aka.ms/new-console-template for more information
using ConsoleDers;
List<Student> studentList = new List<Student>();

while (true)
{
    Console.WriteLine("Hoşgeldiniz!");
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz!");
    Console.WriteLine("1- Öğrenci Ekle");
    Console.WriteLine("2- Öğrenci Sil");
    Console.WriteLine("3- Öğrenci Listesini Görüntüle");
    Console.WriteLine("4- Çıkış");
    Console.Write("Seçiniz ");

    string choose = Console.ReadLine();

    switch (choose)
    {
        // öğrenci ekle
        case "1":
            {
                Console.Write("Öğrenci Adı: ");
                string isim = Console.ReadLine();
                Console.Write("Öğrenci Soyadı: ");
                string soyad = Console.ReadLine();
                Console.Write("Öğrencinin Sınıfı: ");
                char sinif = Console.ReadLine()[0];
                Student student = new Student(isim, soyad, sinif);
                studentList.Add(student);
                Console.WriteLine("Öğrenci başarıyla eklendi!");
                break;
            }
        //öğrenci sil
        case "2":
            {
                PrintAllStudents();
                Console.Write("Silmek istediğiniz öğrencinin numarasını giriniz: ");
                int number = int.Parse(Console.ReadLine());
                var foundStudent = studentList.Find(s => s.Number == number);
                if (foundStudent != null)
                {
                    studentList.Remove(foundStudent);
                    Console.Write("Öğrenci sistemden silindi!");
                }
                else
                {
                    Console.Write("Öğrenci bulunamadı!");
                }
                break;
            }
        // liste görüntüle
        case "3":
            {


                if (studentList.Count == 0)
                    Console.WriteLine("Öğrenci Listesi Boş!");
                else
                    PrintAllStudents();

                break;
            }

        //çıkış
        case "4": return;
        default: choose = Console.ReadLine(); break;
    }
}

void PrintAllStudents()
{
    Console.WriteLine("Öğrenci Listesi Görüntüleniyor...");
    foreach (var student in studentList)
    {
        student.Print();
    }
    Console.WriteLine("Öğrenci Listesi Görüntülendi.");
}