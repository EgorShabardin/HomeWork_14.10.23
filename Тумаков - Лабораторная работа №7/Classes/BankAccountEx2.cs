namespace Тумаков___Лабораторная_работа__7
{
    /// <summary>
    /// Класс счета в банке для Упражнения 7.2.
    /// </summary>
    class BankAccountEx2
    {
        /// <summary>
        /// Перечислимый тип, содержащий виды банковских счетов.
        /// </summary>
        public enum AccountType
        {
            Текущий_счет,
            Сберегательный_счет
        }

        private static int numberOfBankAccounts = 0;
        private int accountNumber;
        private int accountBalance;
        private AccountType bankAccountType;

        /// <summary>
        /// Свойство, позволяющее читать поле accountNumber.
        /// </summary>
        public int AccountNumber
        {
            get
            {
                return accountNumber;
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
        /// Метод, изменяющий количество банковских счетов (поле numberOfBankAccounts).
        /// </summary>
        private void ChangeNumberOfBankAccounts()
        {
            numberOfBankAccounts++;
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccountEx2 и заполняет его данными.
        /// </summary>
        /// <param name="accountBalance"> Баланс банковского счета. </param>
        /// <param name="bankAccountType"> Тип банковского счета. </param>
        public BankAccountEx2(int accountBalance, AccountType bankAccountType)
        {
            accountNumber = numberOfBankAccounts;
            this.accountBalance = accountBalance;
            this.bankAccountType = bankAccountType;
            ChangeNumberOfBankAccounts();
        }
    }
}
