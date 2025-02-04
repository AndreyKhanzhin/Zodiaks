Console.WriteLine("Введите ваши имя, фамилию, дату и номер месяца рождения по очереди в Указаном порядке порядке вводя каждую переменную в новой строке.");
string name = Console.ReadLine();
string surname = Console.ReadLine();
string day = Console.ReadLine();
string month = Console.ReadLine();
string result = "";
if (int.TryParse(month, out int monthint) == false || int.TryParse(day, out int dayint) == false)
{
    Console.WriteLine("Пожалуйста, для месяца и дня введите ЧИСЛО.");
}
else
{ if (((monthint == 1 || monthint == 3 || monthint == 5 || monthint == 7 || monthint == 8 || monthint == 10 || monthint == 12) && (dayint < 1 || dayint > 31)) || ((monthint == 4 || monthint == 6 || monthint == 9 || monthint == 11) && (dayint < 1 || dayint > 30)) || (monthint == 2 && (dayint < 1 || dayint > 29)) || monthint < 1 || monthint > 12 || name == null || surname == null)
    {
        Console.WriteLine("Achtung! Это не человек, а тестировщик!");
    }
    else switch (monthint) {
            case 1: switch (dayint <= 20)
                {
                    case true: result = "Козерог";
                        break;
                    case false: result = "Водолей";
                        break;
                }
                break;
            case 2: switch (dayint <= 19)
                {
                    case true: result = "Водолей";
                        break;
                    case false: result = "Рыбы";
                        break;
                }
                break;
            case 3: switch (dayint <= 20)
                {
                    case true: result = "Рыбы";
                        break;
                    case false: result = "Овен";
                        break;
                }
                break;
            case 4: switch (dayint <= 20)
                {
                    case true: result = "Овен";
                        break;
                    case false: result = "Телец";
                        break;
                }
                break;
            case 5:
                switch (dayint <= 20)
                {
                    case true:
                        result = "Телец";
                        break;
                    case false:
                        result = "Близнецы";
                        break;
                }
                break;
            case 6:
                switch (dayint <= 21)
                {
                    case true:
                        result = "Близнецы";
                        break;
                    case false:
                        result = "Рак";
                        break;
                }
                break;
            case 7:
                switch (dayint <= 22)
                {
                    case true:
                        result = "Рак";
                        break;
                    case false:
                        result = "Лев";
                        break;
                }
                break;
            case 8:
                switch (dayint <= 23)
                {
                    case true:
                        result = "Лев";
                        break;
                    case false:
                        result = "Дева";
                        break;
                }
                break;
            case 9:
                switch (dayint <= 23)
                {
                    case true:
                        result = "Дева";
                        break;
                    case false:
                        result = "Весы";
                        break;
                }
                break;
            case 10:
                switch (dayint <= 23)
                {
                    case true:
                        result = "Весы";
                        break;
                    case false:
                        result = "Скорпион";
                        break;
                }
                break;
            case 11:
                switch (dayint <= 22)
                {
                    case true:
                        result = "Скорпион";
                        break;
                    case false:
                        result = "Стрелец";
                        break;
                }
                break;
            case 12:
                switch (dayint <= 21)
                {
                    case true:
                        result = "Стрелец";
                        break;
                    case false:
                        result = "Козерог";
                        break;
                }
                break;
        }
    Console.WriteLine($"Вы {name} {surname}, ваш знак зодиака — {result}.");
}
