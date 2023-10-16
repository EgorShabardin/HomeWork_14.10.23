using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий медицинскую карту пациента. Наследуется от DataBook.
    /// </summary>
    class PatientHospitalCard : DataBook
    {
        protected static int numberOfCards = 0;
        protected int cardNumber;
        protected string patientName;
        protected string patientSurname;
        protected string hospitalName;

        /// <summary>
        /// Свойство, позволяющее читать поле patientName.
        /// </summary>
        public string PatientName
        {
            get
            {
                return patientName;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле patientSurname.
        /// </summary>
        public string PatientSurname
        {
            get
            {
                return patientSurname;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле hospitalName.
        /// </summary>
        public string HospitalName
        {
            get
            {
                return hospitalName;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле cardNumber.
        /// </summary>
        public int CardNumber
        {
            get
            {
                return cardNumber;
            }
        }

        /// <summary>
        /// Метод, изменяющий количество медицинских карточек (поле numberOfCards).
        /// </summary>
        protected void ChangeNumberOfCards()
        {
            numberOfCards++;
        }

        /// <summary>
        /// Метод, ставящий печать врача рядом с записью.
        /// </summary>
        protected virtual void PutDoctorStamp()
        {
            Console.WriteLine("Рядом с этой записью поставлена печать врача");
        }

        /// <summary>
        /// Метод, добавляющий новую запись в медицинскую карту пациента.
        /// </summary>
        /// <param name="recordingDate"> Дата записи. </param>
        /// <param name="record"> Запись. </param>
        public override void AddNewRecord(DateTime recordingDate, string record)
        {
            if (!records.ContainsKey(recordingDate))
            {
                Console.WriteLine("Вы сходили к врачу! Добавлена новая запись");
                records.Add(recordingDate, record);
                ChangeNumberOfRecords(true);
                PutDoctorStamp();
            }
            else
            {
                Console.WriteLine("Запись за это число уже существует!");
            }
        }
        
        /// <summary>
        /// Метод, позволяющий вклеить в медицинскую карту пациента выпавшие странички.
        /// </summary>
        public void PasteBackFallenPages()
        {
            Console.WriteLine("Выпавшие странички были вклеины!");
        }

        /// <summary>
        /// Метод, позволяющий вклеить результаты анализов.
        /// </summary>
        public void PasteTestResults()
        {
            Console.WriteLine("Результаты анализов были вклеины в карточку");
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса PatientHospitalCard и заполняет его данными.
        /// </summary>
        /// <param name="patientName"> Имя пациента. </param>
        /// <param name="patientSurname"> Фамилия пациента. </param>
        /// <param name="hospitalName"> Название больницы. </param>
        public PatientHospitalCard(string patientName, string patientSurname, string hospitalName)
        {
            this.patientName = patientName;
            this.patientSurname = patientSurname;
            this.hospitalName = hospitalName;
            cardNumber = numberOfCards;
            pageView = PageTypes.чистый_лист;
            numberOfPages = 100;
            pageHeight = 14.5;
            pageWidth = 20;
            ChangeNumberOfCards();
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса PatientHospitalCard и заполняет его данными.
        /// </summary>
        /// <param name="patientName"> Имя пациента. </param>
        /// <param name="patientSurname"> Фамилия пациента. </param>
        public PatientHospitalCard(string patientName, string patientSurname)
        {
            this.patientName = patientName;
            this.patientSurname = patientSurname;
            hospitalName = "Центральная";
            cardNumber = numberOfCards;
            pageView = PageTypes.чистый_лист;
            numberOfPages = 100;
            pageHeight = 14.5;
            pageWidth = 20;
            ChangeNumberOfCards();
        }

    }
}
