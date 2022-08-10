Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string? a1 = Console.ReadLine();
int b1;
if (!int.TryParse(a1, out b1)){
    Console.WriteLine("Ошибка ввода! Повторите ввод!");
    return;
}
if (b1 < 1 || b1 > 7){
    Console.WriteLine("Ошибка ввода! Повторите ввод!");
    return;
}
string[] answers = {
"Понедельник, нет, не выходной!",
"Вторник, нет, не выходной!",
"Среда, нет, не выходной!",
"Четверг, нет, не выходной!",
"Пятница, нет, не выходной!",
"Суббота, да, выходной!",
"Воскресенье, да, выходной!"
};
Console.WriteLine(answers[b1-1]);