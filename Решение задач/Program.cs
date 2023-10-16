using System;

namespace Решение_задач
{
    class Program
    {
        static void Main(string[] args)
        {
            // Решение задач. Программа, состоящая из четырех классов, которая реализует все принципы ООП.
            Console.WriteLine("{0, 104}", "РЕШЕНИЕ ЗАДАЧ. ПРОГРАММА, СОСТОЯЩАЯ ИЗ ЧЕТЫРЕХ КЛАССОВ, КОТОРАЯ РЕАЛИЗУЕТ ВСЕ ПРИНЦИПЫ ООП");

            PatientHospitalCard firstPatient = new PatientHospitalCard("Василий", "Петров");
            PatientHospitalCard secondPatient = new PatientHospitalCard("Кирилл", "Васильев", "Южная");
            AdultHospitalCard thirdPatient = new AdultHospitalCard("Владимир", "Романов", "Северная", "Школа", "г.Казань", 1995, 2017);
            ChildHospitalCard fourthPatient = new ChildHospitalCard("Петр", "Иванов", 2015, "Гимназия №145");
            ChildHospitalCard fifthPatient = new ChildHospitalCard("Иван", "Булатов", 2007, "Лицей № 12", true, false);

            DateTime firstDate = new DateTime(2015, 05, 25);
            DateTime secondDate = new DateTime(2019, 01, 18);


            Console.WriteLine("{0, 75}", "ОБЪЕКТЫ КЛАССА PatientHospitalCard");

            Console.WriteLine("\nДОБАВЛЕНИЕ ЗАПИСЕЙ:");
            firstPatient.AddNewRecord(firstDate, "Заболел простудой");
            firstPatient.AddNewRecord(secondDate, "Заболел гриппом");
            secondPatient.AddNewRecord(firstDate, "Проблемы с животом");
            secondPatient.AddNewRecord(firstDate, "Проблемы с ногами");

            Console.WriteLine("\nВНЕШНИЙ ВИД МЕДИЦИНСКОЙ КАРТОЧКИ:\n" +
                             $"Первый пациент:\t{firstPatient.NumberOfRecords} записей, {firstPatient.NumberOfPages} страниц, " +
                             $"ширина карточки - {firstPatient.PageWidth}, высота карточки - {firstPatient.PageHeight}, вид листов - {firstPatient.PageView}\n" +
                             $"Второй пациент:\t{secondPatient.NumberOfRecords} записей, {secondPatient.NumberOfPages} страниц, " +
                             $"ширина карточки {secondPatient.PageWidth}, высота карточки - {secondPatient.PageHeight}, вид листов - {secondPatient.PageView}");

            Console.WriteLine("\nЧТЕНИЕ ОДНОЙ ЗАПИСИ ПО ДАТЕ:");
            firstPatient.ReadRecord(secondDate);
            secondPatient.ReadRecord(secondDate);

            Console.WriteLine("\nУДАЛЕНИЕ ЗАПИСИ ПО ДАТЕ:");
            firstPatient.DeleteRecord(secondDate);
            secondPatient.DeleteRecord(firstDate);
            secondPatient.DeleteRecord(secondDate);

            Console.WriteLine("\nЧТЕНИЕ ВСЕХ ЗАПИСЕЙ:");
            firstPatient.ReadAllRecords();
            secondPatient.ReadAllRecords();

            Console.WriteLine("\nДАННЫЕ ПАЦИЕНТОВ:\n" +
                             $"Первый пациент:\tИмя - {firstPatient.PatientName}, фамилия - {firstPatient.PatientSurname}, " +
                             $"название больницы - {firstPatient.HospitalName}, номер карточки - {firstPatient.CardNumber:D4}\n" +
                             $"Второй пациент:\tИмя - {secondPatient.PatientName}, фамилия - {secondPatient.PatientSurname}, " +
                             $"название больницы - {secondPatient.HospitalName}, номер карточки - {secondPatient.CardNumber:D4}");

            Console.WriteLine("\nОСТАЛЬНЫЕ МЕТОДЫ КЛАССА PatientHospitalCard:");
            firstPatient.PasteBackFallenPages();
            firstPatient.PasteTestResults();



            Console.WriteLine();
            Console.WriteLine("{0, 73}", "ОБЪЕКТЫ КЛАССА ChildHospitalCard");

            Console.WriteLine("\nДАННЫЕ ПАЦЕНТОВ-ДЕТЕЙ:\n" +
                             $"Первый ребенок:\t{fourthPatient.PatientName} {fourthPatient.PatientSurname} {fourthPatient.Age}, название больницы - {fourthPatient.HospitalName}, номер карточки - {fourthPatient.CardNumber:D4},\n" +
                             $"название школы - {fourthPatient.SchoolName}, прохождение ежегодного медосмотра - {fourthPatient.AnnualHealthCheck}, сделал ежегодную прививку от гриппа - {fourthPatient.AnnualFluVaccination}\n\n" +
                             $"Второй ребенок:\t{fifthPatient.PatientName} {fifthPatient.PatientSurname} {fifthPatient.Age}, название больницы - {fifthPatient.HospitalName}, номер карточки - {fifthPatient.CardNumber:D4},\n" +
                             $"название школы - {fifthPatient.SchoolName}, прохождение ежегодного медосмотра - {fifthPatient.AnnualHealthCheck}, сделал ежегодную прививку от гриппа - {fifthPatient.AnnualFluVaccination}");

            Console.WriteLine("\nПРОХОЖДЕНИЕ ЕЖЕГОДНОГО МЕДОСМОТРА:");
            fourthPatient.UndergoAnnualHealthCheck();
            fifthPatient.UndergoAnnualHealthCheck();
            Console.WriteLine($"Прохождение ежегодного медосмотра: первый ребенок - {fourthPatient.AnnualHealthCheck}, второй ребенок - {fifthPatient.AnnualHealthCheck}");

            Console.WriteLine("\nЕЖЕГОДНАЯ ПРИВИВКА ОТ ГРИППА:");
            fourthPatient.GetAnnualFluVaccine();
            fifthPatient.GetAnnualFluVaccine();
            Console.WriteLine($"Ежегодная прививка от гриппа: первый ребенок - {fourthPatient.AnnualFluVaccination}, второй ребенок - {fifthPatient.AnnualFluVaccination}");

            Console.WriteLine("\nДОБАВЛЕНИЕ ЗАПИСЕЙ:");
            fourthPatient.AddNewRecord(firstDate, "Простудился");
            fourthPatient.ReadAllRecords();

            Console.WriteLine("\nОСТАЛЬНЫЕ МЕТОДЫ КЛАССА ChildHospitalCard:");
            fifthPatient.GetFluorography();
            fifthPatient.DonateBloodForAnalysis();



            Console.WriteLine();
            Console.WriteLine("{0, 73}", "ОБЪЕКТЫ КЛАССА AdultHospitalCard");

            Console.WriteLine("\nДАННЫЕ ПАЦИЕНТА-ВЗРОСЛОГО:" +
                             $"\n{thirdPatient.PatientName} {thirdPatient.PatientSurname} {thirdPatient.Age}, название больницы - {thirdPatient.HospitalName}, номер карточки - {thirdPatient.CardNumber:D4},\n" +
                             $"место работы - {thirdPatient.WorkPlace}, место жительства - {thirdPatient.ResidencePlace}, год полследнего прохождения медосмотра - {thirdPatient.YearOfLastHealthCheck}");

            Console.WriteLine("\nСМЕНА БОЛЬНИЦЫ:");
            thirdPatient.RegistrationAtNewHospital("Центральная");
            Console.WriteLine($"Новая больница - {thirdPatient.HospitalName}");

            Console.WriteLine("\nСМЕНА МЕСТА РАБОТЫ:");
            thirdPatient.ChangeWorkPlace("ВУЗ");
            Console.WriteLine($"Новое место работы - {thirdPatient.WorkPlace}");

            Console.WriteLine("\nСМЕНА МЕСТА ЖИТЕЛЬСТВА:");
            thirdPatient.ChangeResidencePlace("г.Москва");
            Console.WriteLine($"Новое место жительства - {thirdPatient.ResidencePlace}");

            Console.WriteLine("\nПРОХОЖДЕНИЕ МЕДОСМОТРА:");
            thirdPatient.UndergoHealthCheck();
            Console.WriteLine($"Год последнего прохождения медосмотра - {thirdPatient.YearOfLastHealthCheck}");

            Console.WriteLine("\nДОБАВЛЕНИЕ ЗАПИСЕЙ:");
            thirdPatient.AddNewRecord(firstDate, "Заболел");
            thirdPatient.ReadAllRecords();
        }
    }
}
