// int sum = 0;       
// int count = 0;    

// for (int i = 1; i <= 100; i++){
//     if (i % 3 == 0){
//         sum += i;
//     }
//     if (i % 7 == 0){
//         count++;
//     }
// }

// Console.WriteLine($"Сумма чисел, кратных 3: {sum}");
// Console.WriteLine($"Чисел, кратных 7: {count}");


// int positiveCount = 0; 
// int negativeCount = 0; 
// Console.Write("Введите число (0 для выхода): ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number != 0){
//     if (number > 0){
//         positiveCount++;
//     }
//     else if (number < 0){
//         negativeCount++;
//     }

//     Console.Write("Введите число (0 для выхода): ");
//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"Положительных чисел введено: {positiveCount}");
// Console.WriteLine($"Отрицательных чисел введено: {negativeCount}");



// bool isAccessGranted = false;
// for (int attempt = 1; attempt <= 3; attempt++){
//     Console.Write("Введите пароль: ");
//     string password = Console.ReadLine();

//     if (password == "qwerty"){
//         isAccessGranted = true; 
//         break;                  
//     }
// }


// if (isAccessGranted){
//     Console.WriteLine("Доступ разрешён");
// }
// else{
//     Console.WriteLine("Доступ заблокирован");
// }

// int n =  Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++){
//     for (int j = 1; j <= 10; j++){
//         Console.WriteLine($"{i}*{j}={i * j}");
        
//     }
    
    
// }

// for (int i = 1; i <= 30; i++){
//     if (i % 10 == 0 && i > 20){
//         break; 
//     }

//     if (i % 3 == 0){
//         continue;
//     }

//     Console.WriteLine(i);
// }


// int secret = 42; 
// int maxAttempts = 5; 
// bool isWon = false;

// Console.WriteLine("Игра «Угадай число»");
// Console.WriteLine($"Я загадал число. У вас есть {maxAttempts} попыток, чтобы отгадать его.");

// for (int attempt = 1; attempt <= maxAttempts; attempt++){
//     Console.Write($"Попытка №{attempt}. Введите ваше число: ");
//     int guess = Convert.ToInt32(Console.ReadLine());

//     if (guess == secret){
//         Console.WriteLine($"Победа! Попыток: {attempt}");
//         isWon = true;
//         break; 
//     }
//     else if (guess < secret){
//         Console.WriteLine("Загаданное число Больше");
//     }
//     else{
//         Console.WriteLine("Загаданное число Меньше");
//     }
// }

// if (!isWon){
//     Console.WriteLine($"Вы проиграли, число было {secret}");
// }


Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int originalNumber = n; 
int sumOfDigits = 0;
int countOfDigits = 0;


if (n == 0){
    sumOfDigits = 0;
    countOfDigits = 1;
}
else{
    while (n > 0){
        int lastDigit = n % 10; 
        sumOfDigits += lastDigit; 
        countOfDigits++;          
        n = n / 10;              
    }
}

Console.WriteLine($"Число: {originalNumber}");
Console.WriteLine($"Сумма цифр: {sumOfDigits}");
Console.WriteLine($"Количество цифр: {countOfDigits}");