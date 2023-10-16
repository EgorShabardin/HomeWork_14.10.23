namespace Тумаков___Лабораторная_работа__7
{
    /// <summary>
    /// Класс счета в банке для Упражнения 7.3.
    /// </summary>
    class BankAccountEx3
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
        /// Свойство, позволяющее читать поле accountBalance.
        /// </summary>
        public int AccountBalance
        {
            get
            {
                return accountBalance;
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
        /// Метод, снимающий некоторую денежную сумму с банковского счета.
        /// </summary>
        /// <param name="withdrawalAmount"> Денежная сумма, которую необходимо снять. </param>
        /// <returns> Возвращает true, если снятие денежной суммы возможно, иначе false. </returns>
        public bool WithdrawMoneyFromAccount(int withdrawalAmount)
        {
            if (accountBalance - withdrawalAmount > 0)
            {
                accountBalance -= withdrawalAmount;
                return true;
            }

            return false;          
        }

        /// <summary>
        /// Метод, пополняющий банковский счет на некоторую денежную сумму.
        /// </summary>
        /// <param name="depositedAmoun"> Денежная сумма, которую необходимо внести. </param>
        public void PutMoneyIntoAccount(int depositedAmoun)
        {
            accountBalance += depositedAmoun;
        }

        /// <summary>
        /// Конструктор, который создает экземпляр класса BankAccountEx3 и заполняет его данными.
        /// </summary>
        /// <param name="bankAccountType"> Тип банковского счета. </param>
        public BankAccountEx3(AccountType bankAccountType)
        {
            accountNumber = numberOfBankAccounts;
            accountBalance = 0;
            this.bankAccountType = bankAccountType;
            ChangeNumberOfBankAccounts();
        }
    }
}
