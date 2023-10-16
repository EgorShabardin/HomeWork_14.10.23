namespace Тумаков___Лабораторная_работа__7
{
    /// <summary>
    /// Класс счета в банке для Упражнения 7.1.
    /// </summary>
    class BankAccountEx1
    {
        /// <summary>
        /// Перечислимый тип, содержащий виды банковских счетов.
        /// </summary>
        public enum AccountType
        {
            Текущий_счет,
            Сберегательный_счет
        }

        private int accountNumber;
        private int accountBalance;
        private AccountType bankAccountType;

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле accountNumber.
        /// </summary>
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле accountBalance.
        /// </summary>
        public int AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = value;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать и заполнять поле bankAccountType.
        /// </summary>
        public AccountType BankAccountType
        {
            get
            {
                return bankAccountType;
            }
            set
            {
                bankAccountType = value;
            }
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccountEx1 и заполняет его данными.
        /// </summary>
        /// <param name="numberOfAccount"> Номер банковского счета. </param>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        /// <param name="bankAccountType"> Тип банковского счета. </param>
        public BankAccountEx1(int accountNumber, int accountBalance, AccountType bankAccountType)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.bankAccountType = bankAccountType;
        }

    }
}
