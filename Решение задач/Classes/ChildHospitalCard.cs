using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий медицинскую карту ребенка. Наследуется от PatientHospitalCard.
    /// </summary>
    class ChildHospitalCard : PatientHospitalCard
    {
        protected int birthdayYear;
        protected string schoolName;
        protected bool annualFluVaccination;
        protected bool annualHealthCheck;

        /// <summary>
        /// Свойство, позволяющее читать возраст пациента-ребенка.
        /// </summary>
        public string Age
        {
            get
            {
                int age = DateTime.Today.Year - birthdayYear;

                if (age < 12)
                {
                    return String.Format($"{age} лет, ребенок");
                }
                else
                {
                    return String.Format($"{age} лет, подросток");      
                }
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле schoolName.
        /// </summary>
        public string SchoolName
        {
            get
            {
                return schoolName;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле annualFluVaccination.
        /// </summary>
        public string AnnualFluVaccination
        {
            get
            {
                if (annualFluVaccination)
                {
                    return "ДА";
                }
                else
                {
                    return "НЕТ";
                }
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле annualHealthCheck.
        /// </summary>
        public string AnnualHealthCheck
        {
            get
            {
                if (annualHealthCheck)
                {
                    return "ДА";
                }
                else
                {
                    return "НЕТ";
                }
            }
        }

        /// <summary>
        /// Метод, позволяющий пройти медосмотр и ставящий отметку об этом в медицинскую карту пациента.
        /// </summary>
        public void UndergoAnnualHealthCheck()
        {
            if (!annualHealthCheck)
            {
                Console.WriteLine("Вы прошли ежегодный медицинский осмотр!");
                annualHealthCheck = true;
            }
            else
            {
                Console.WriteLine("Вы уже проходили медицинский осмотр в этом году!");
            }
        }

        /// <summary>
        /// Метод, позволяющий сделать прививку от гриппа и ставящий отметку об этом в медицинскую карту пациента.
        /// </summary>
        public void GetAnnualFluVaccine()
        {
            if (!annualFluVaccination)
            {
                Console.WriteLine("Вы сделали прививку от гриппа!");
                annualFluVaccination = true;
            }
            else
            {
                Console.WriteLine("Вы уже делали прививку от гриппа в этом году!");
            }
        }

        /// <summary>
        /// Метод, ставящий печать детской больницы и подпись врача педиатора.
        /// </summary>
        protected override void PutDoctorStamp()
        {
            Console.WriteLine("Рядом с этой записью поставлена печать детской больницы и подпись врача педиатра");          
        }

        /// <summary>
        /// Метод, позволяющий сделать флюорографию и ставящий отметку об этом в медицинскую карту пациента.
        /// </summary>
        public void GetFluorography()
        {
            Console.WriteLine("В медицинской карточке появилась запись о прохождении флюорографии");
        }

        /// <summary>
        /// Метод, позволяющий сдать кровь на анализ и ставящий отметку об этом в медицинскую карту пациента.
        /// </summary>
        public void DonateBloodForAnalysis()
        {
            Console.WriteLine("В медицинской карточке появилась запись о сдаче крови на анализ");
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса ChildHospitalCard и заполняет его данными.
        /// </summary>
        /// <param name="patientName"> Имя пациента. </param>
        /// <param name="patientSurname"> Фамилия пациента. </param>
        /// <param name="birthdayYear"> Год рождения пациента. </param>
        /// <param name="schoolName"> Название школы пациента. </param>
        /// <param name="annualFluVaccination"> Принимает true, если ежегодный медосмотр пройден, иначе false. </param>
        /// <param name="annualHealthCheck"> Принимает true, если сделана ежегодная прививка от гриппа, иначе false. </param>
        public ChildHospitalCard(string patientName, string patientSurname, int birthdayYear, string schoolName, bool annualFluVaccination, bool annualHealthCheck) : base(patientName, patientSurname, "Детская")
        {
            this.schoolName = schoolName;
            this.annualFluVaccination = annualFluVaccination;
            this.annualHealthCheck = annualHealthCheck;
            this.birthdayYear = birthdayYear;
        }

        /// <summary>
        ///  Конструктор, который создает экземпляр класса ChildHospitalCard и заполняет его данными.
        /// </summary>
        /// <param name="patientName"> Имя пациента. </param>
        /// <param name="patientSurname"> Фамилия пациента. </param>
        /// <param name="birthdayYear"> Год рождения пациента. </param>
        /// <param name="schoolName"> Название школы пациента. </param>
        public ChildHospitalCard(string patientName, string patientSurname, int birthdayYear, string schoolName) : base(patientName, patientSurname, "Детская")
        {
            this.schoolName = schoolName;
            annualFluVaccination = false;
            annualHealthCheck = false;
            this.birthdayYear = birthdayYear;
        }
    }
}
