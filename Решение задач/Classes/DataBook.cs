using System;
using System.Collections.Generic;

namespace Решение_задач
{
    /// <summary>
    /// Абстрактный класс, описывающий книгу для записи данных.
    /// </summary>
    abstract class DataBook
    {
        /// <summary>
        /// Перечислимый тип, содержащий виды страниц в книге для записи данных.
        /// </summary>
        public enum PageTypes
        {
            в_линию,
            в_клетку,
            чистый_лист
        }

        protected int numberOfRecords = 0;
        protected int numberOfPages;
        protected double pageWidth;
        protected double pageHeight;
        protected PageTypes pageView;
        protected Dictionary<DateTime, string> records = new Dictionary<DateTime, string>();

        /// <summary>
        /// Свойство, позволяющее читать поле numberOfRecords.
        /// </summary>
        public int NumberOfRecords
        {
            get
            {
                return numberOfRecords;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле numberOfPages.
        /// </summary>
        public int NumberOfPages
        {
            get
            {
                return numberOfPages;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле pageWidth.
        /// </summary>
        public double PageWidth
        {
            get
            {
                return pageWidth;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле pageHeight.
        /// </summary>
        public double PageHeight
        {
            get
            {
                return pageHeight;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле pageView.
        /// </summary>
        public PageTypes PageView
        {
            get
            {
                return pageView;
            }
        }

        /// <summary>
        /// Метод, изменяющий количество записей (поле numberOfRecords).
        /// </summary>
        /// <param name="increaseNumber"> Принимает true, если количество записей нужно увеличить, false в обратном случае. </param>
        protected void ChangeNumberOfRecords(bool increaseNumber)
        {
            if (increaseNumber)
            {
                numberOfRecords++;
            }
            else
            {
                numberOfRecords--;
            }
        }

        /// <summary>
        /// Метод, добавляющий новую запись в книгу для записи данных.
        /// </summary>
        /// <param name="recordingDate"> Дата записи. </param>
        /// <param name="record"> Запись. </param>
        public virtual void AddNewRecord(DateTime recordingDate, string record)
        {
            if (!records.ContainsKey(recordingDate))
            {
                Console.WriteLine("Запись добавлена!");
                records.Add(recordingDate, record);
                ChangeNumberOfRecords(true);
            }
            else
            {
                Console.WriteLine("Запись за это число уже существует!");
            }
        }

        /// <summary>
        /// Метод, позволяющий читать запись по дате.
        /// </summary>
        /// <param name="recordingDate"> Дата записи. </param>
        public void ReadRecord(DateTime recordingDate)
        {
            if (records.ContainsKey(recordingDate))
            {
                Console.WriteLine($"Запись за {recordingDate.ToLongDateString()}: {records[recordingDate]}");
            }
            else
            {
                Console.WriteLine("Запись за это число не обнаружена!");
            }
        }

        /// <summary>
        /// Метод, позволяющий удалить запись по дате.
        /// </summary>
        /// <param name="recordingDate"> Дата записи. </param>
        public void DeleteRecord(DateTime recordingDate)
        {
            if (records.ContainsKey(recordingDate))
            {
                Console.WriteLine("Запись удалена!");
                records.Remove(recordingDate);
                ChangeNumberOfRecords(false);
            }
            else
            {
                Console.WriteLine("Запись за это число не обнаружена!");
            }
        }

        /// <summary>
        /// Метод, позволяющий читать все записи.
        /// </summary>
        public void ReadAllRecords()
        {
            if (records.Count != 0)
            {
                foreach (KeyValuePair<DateTime, string> record in records)
                {
                    Console.WriteLine($"Запись за {record.Key.ToLongDateString()}: {record.Value}");
                }
            }
            else
            {
                Console.WriteLine("Записей не обнаружено!");
            }
        }
    }
}
