namespace BigNumWizardShared
{
    public class BigFraction    // Класс рациональных дробей
    {
        public BigNum Nom { get; private set; }     // Числитель(только чтение)
        public BigNum Denom { get; private set; }   // Знаменатель(только чтение)
        public bool Positive { get; private set; }  // Знак( true - дробь положительна, false - отрицательна) - только чтение

        public BigFraction(BigNum _Nom, BigNum _Denom)  // Конструктор. Создать дробь с заданными числителем и знаменателем
        {
            Positive = _Nom.Positive == _Denom.Positive;
            Nom = _Nom.Absolute;
            Denom = _Denom.Absolute;        // Проверка на нуль в знаменателе не производится
        }

        public BigFraction(BigNum _Nom) : this(_Nom, new BigNum("1")) { }   // Конструктор. Преобразовать число в дробь(знаменатель будет равен 1)

        public BigFraction() : this(new BigNum("1"), new BigNum("1")) { }   // Конструктор. Создать единицу в виде дроби

        public BigFraction GetInversed()    // Получить обратную дробь
        { 
            var result = new BigFraction(this.Denom, this.Nom);
            result.Positive = this.Positive;
            return result;
        }

        public BigFraction GetOppositeSigned()  // Получить дробь с противоположным знаком
        {
            var result = new BigFraction(this.Nom, this.Denom);
            result.Positive = !this.Positive;
            return result;
        }

        public static BigFraction operator +(BigFraction fir, BigFraction sec)  // Оператор сложения (результат не сокращается после операции)
        {
            var result = new BigFraction();

            result.Denom = fir.Denom * sec.Denom;
            if (fir.Positive == sec.Positive)
            {
                result.Nom = fir.Nom * sec.Denom + fir.Denom * sec.Nom;
                result.Positive = fir.Positive;
                return result;
            }
            else
            {
                var NewFirNom = fir.Nom * sec.Denom;
                var NewSecNom = sec.Nom * fir.Denom;

                if(NewFirNom > NewSecNom)
                {
                    result.Nom = NewFirNom - NewSecNom;
                    result.Positive = fir.Positive;
                    return result;
                }
                else
                    if(NewFirNom < NewSecNom)
                    {
                        result.Nom = NewSecNom - NewFirNom;
                        result.Positive = sec.Positive;
                        return result;
                    }
                    else
                    {
                        result.Nom = new BigNum("0");
                        return result;
                    }

            }
        }

        public static BigFraction operator -(BigFraction fir, BigFraction sec) { return fir + sec.GetOppositeSigned(); } // Оператор вычитания (результат не сокращается после операции)

        public static BigFraction operator *(BigFraction fir, BigFraction sec) // Оператор умножения (результат не сокращается после операции)
        {
            var result = new BigFraction(fir.Nom * sec.Nom, fir.Denom * sec.Denom);
            result.Positive = fir.Positive == sec.Positive;
            return result;
        }

        public static BigFraction operator /(BigFraction fir, BigFraction sec) { return fir * sec.GetInversed(); } // Оператор деления (результат не сокращается после операции)

    }
}
