using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий медицинскую карту взрослого. Наследуется от PatientHospitalCard.
    /// </summary>
    class AdultHospitalCard : PatientHospitalCard
    {
        protected int birthdayYear;
        protected string workPlace;
        protected string residencePlace;
        protected int yearOfLastHealthCheck;

        /// <summary>
        /// Свойство, позволяющее читать возраст пациента.
        /// </summary>
        public int Age
        {
            get
            {
                return DateTime.Today.Year - birthdayYear;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле workPlace.
        /// </summary>
        public string WorkPlace
        {
            get
            {
                return workPlace;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле residencePlace.
        /// </summary>
        public string ResidencePlace
        {
            get
            {
                return residencePlace;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле yearOfLastHealthCheck.
        /// </summary>
        public int YearOfLastHealthCheck
        {
            get
            {
                return yearOfLastHealthCheck;
            }
        }

        /// <summary>
        /// Метод, позволяющий поменять больницу в карточке.
        /// </summary>
        /// <param name="hospitalName"> Название новой больницы. </param>
        public void RegistrationAtNewHospital(string hospitalName)
        {
            Console.WriteLine($"Карточка была перенаправлена из больницы {this.hospitalName} в {hospitalName}");
            this.hospitalName = hospitalName;
        }

        /// <summary>
        /// Метод, позволяющий поменять место работы в карточке.
        /// </summary>
        /// <param name="workPlace"> Новое место работы. </param>
        public void ChangeWorkPlace(string workPlace)
        {
            Console.WriteLine($"Место работы в карточке было сменено с {this.workPlace} на {workPlace}");
            this.workPlace = workPlace;
        }

        /// <summary>
        /// Метод, позволяющий поменять место жительства в карточке.
        /// </summary>
        /// <param name="residencePlace"> Новое место жительства. </param>
        public void ChangeResidencePlace(string residencePlace)
        {
            Console.WriteLine($"Место жительства в карточке было сменено с {this.residencePlace} на {residencePlace}");
            this.residencePlace = residencePlace;
        }

        /// <summary>
        /// Метод, ставящий печать взрослой больницы и подпись врача.
        /// </summary>
        protected override void PutDoctorStamp()
        {
            Console.WriteLine("Рядом с этой записью поставлена печать взрослой больницы и подпись врача");
        }

        /// <summary>
        /// Метод, позволяющий пройти медосмотр и ставящий отметку об этом в медицинскую карту пациента.
        /// </summary>
        public void UndergoHealthCheck()
        {
            if ((DateTime.Today.Year - yearOfLastHealthCheck) > 5)
            {
                Console.WriteLine("Вы прошли ежегодный медицинский осмотр!");
                yearOfLastHealthCheck = DateTime.Today.Year;
            }
            else
            {
                Console.WriteLine("Медицинский осмотр нужно проходить раз в пять лет");
            }
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса AdultHospitalCard и заполняет его данными.
        /// </summary>
        /// <param name="patientName"> Имя пациента. </param>
        /// <param name="patientSurname"> Фамилия пациента. </param>
        /// <param name="hospitalName"> Название больницы. </param>
        /// <param name="workPlace"> Место работы пациента. </param>
        /// <param name="residencePlace"> Место прописки пациента. </param>
        /// <param name="birthdayYear"> Год рождения пациента. </param>
        /// <param name="yearOfLastHealthCheck"> Год последнего прохождения медосмотра. </param>
        public AdultHospitalCard(string patientName, string patientSurname, string hospitalName, string workPlace, string residencePlace, int birthdayYear, int yearOfLastHealthCheck) : base(patientName, patientSurname, hospitalName)
        {
            this.birthdayYear = birthdayYear;
            this.workPlace = workPlace;
            this.residencePlace = residencePlace;
            this.yearOfLastHealthCheck = yearOfLastHealthCheck;
        }
    }
}
