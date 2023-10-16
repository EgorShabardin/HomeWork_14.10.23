namespace Тумаков___Лабораторная_работа__7
{
    /// <summary>
    /// Класс описания здания для Домашнего задания 7.1.
    /// </summary>
    class Building
    {
        private static int numberOfBuildings = 0;
        private int buildingNumber;
        private int buildingHeight;
        private int numberOfFloors;
        private int numberOfApartments;
        private int numberOfEntrances;

        /// <summary>
        /// Свойство, позволяющее читать поле buildingNumber.
        /// </summary>
        public int BuildingNumber
        {
            get
            {
                return buildingNumber;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле buildingHeight.
        /// </summary>
        public int BuildingHeight
        {
            get
            {
                return buildingHeight;
            }
            set
            {
                buildingHeight = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле numberOfFloors.
        /// </summary>
        public int NumberOfFloors
        {
            get
            {
                return numberOfFloors;
            }
            set
            {
                numberOfFloors = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле numberOfApartments.
        /// </summary>
        public int NumberOfApartments
        {
            get
            {
                return numberOfApartments;

            }
            set
            {
                numberOfApartments = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле numberOfEntrances.
        /// </summary>
        public int NumberOfEntrances
        {
            get
            {
                return numberOfEntrances;
            }
            set
            {
                numberOfEntrances = value;
            }
        }

        /// <summary>
        /// Метод, вычисляющий высоту этажей.
        /// </summary>
        /// <returns> Высота этажей в доме. </returns>
        public double CalculationFloorHeight()
        {
            return (double)buildingHeight / numberOfFloors;
        }

        /// <summary>
        /// Метод, вычисляющий количество квартир в подъезде.
        /// </summary>
        /// <returns> Количество квартир в подъезде. </returns>
        public int CalculationNumberOfApartmentsInEntrance()
        {
            return NumberOfApartments / NumberOfEntrances;
        }

        /// <summary>
        /// Метод, вычисляющий количество квартир на одном этаже.
        /// </summary>
        /// <returns> Количество квартир на одном этаже. <returns>
        public int CalculationNumberOfApartmentsOnFloor()
        {
            return (NumberOfApartments / NumberOfEntrances) / numberOfFloors;
        }

        /// <summary>
        /// Метод, изменяющий количество зданий (поле numberOfBuildings).
        /// </summary>
        private void ChangeNumberOfBuilding()
        {
            numberOfBuildings++;
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса Building и заполняет его данными.
        /// </summary>
        /// <param name="buildingHeight"> Высота здания </param>
        /// <param name="numberOfFloors"> Количество этажей в здании. </param>
        /// <param name="numberOfApartments"> Количество квартир в здании. </param>
        /// <param name="numberOfEntrances"> Количество подъездов в здании. </param>
        public Building(int buildingHeight, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
        {
            this.buildingHeight = buildingHeight;
            this.numberOfFloors = numberOfFloors;
            this.numberOfApartments = numberOfApartments;
            this.numberOfEntrances = numberOfEntrances;
            buildingNumber = numberOfBuildings;
            ChangeNumberOfBuilding();
        }
    }
}
