
                                                        // ДЗ 21.1



//using System;

//Console.WriteLine("Введите путь к файлу");
//string path = Console.ReadLine();
//Console.WriteLine("Введите содержимое файла");
//string text = Console.ReadLine();
//try
//{
//    File.WriteAllText(path, text);
//    Console.WriteLine("Файл успешно создан");
//}
//catch
//{
//    Console.WriteLine("*****************************");
//    Console.WriteLine("Вы неверно ввели путь к файлу");
//    Console.WriteLine("*****************************");
//}
//Console.WriteLine("Введите путь к файлу для чтения");
//string newPath = Console.ReadLine();
//try
//{
//    string content=File.ReadAllText(newPath);
//    Console.WriteLine(content);
//}
//catch
//{
//    Console.WriteLine("*******************");
//    Console.WriteLine("Ошибка чтения файла");
//    Console.WriteLine("*******************");
//}


                                                      // ДЗ 21.2


//Console.WriteLine("Введите путь к файлу");
//string path = Console.ReadLine();
//if (File.Exists(path))
//{
//    FileInfo fileInfo = new FileInfo(path);
//    Console.WriteLine("Размер файла в байтах = " + fileInfo.Length);
//    Console.WriteLine("Дата последнего изменения = " + fileInfo.LastWriteTime);
//    Console.WriteLine("Расширение файла = " + fileInfo.Extension);
//}
//else 
//{
//    Console.WriteLine("Файла не существует");
//}


                                                      // ДЗ 21.3


//string path = Environment.CurrentDirectory;
//Console.WriteLine(path);
//Console.Write("Введите название папки для перехода: ");
//string directory = Console.ReadLine();
//path += $"\\{directory}";
//if (Directory.Exists(path))
//{
//    DirectoryInfo directoryInfo = new DirectoryInfo(path);
//    Console.WriteLine(directoryInfo.FullName);
//}
//else
//{
//    Console.WriteLine("Папки не существует");
//}
  

                                                     // ДЗ 21.4


Console.WriteLine("Что вы хотите удалить?");
Console.WriteLine("[1] - файл\n[2] - папка");
int choice=int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        {
            Console.WriteLine($"Введите путь к файлу");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                Console.WriteLine("Вы уверены?");
                Console.WriteLine("[1] - ДА\n[2] - НЕТ");
                int answer=int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    File.Delete(path);
                    Console.WriteLine("Файл успешно удален");
                }
                else 
                {
                    Console.WriteLine("Файл не удален");
                }
            }
            else
            {
                Console.WriteLine("Файла не существует");
            }
        }
        break;
    case 2:
        {
            Console.WriteLine($"Введите путь к файлу");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                {
                    Console.WriteLine("Вы уверены?");
                    Console.WriteLine("[1] - ДА\n[2] - НЕТ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        Directory.Delete(path);
                        Console.WriteLine("Папка успешно удалена");
                    }
                    else
                    {
                        Console.WriteLine("Папка не удалена");
                    }
                }
            }
            else
            {
                Console.WriteLine("Папки не существует");
            }
        }
        break;
}



