using System;
using System.IO;

class FileExplorer
{
    static string currentDirectory = Directory.GetCurrentDirectory();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            DisplayDirectoryContents(currentDirectory);

            Console.WriteLine("\nДоступные действия:");
            Console.WriteLine("1. Открыть файл");
            Console.WriteLine("2. Перейти в папку");
            Console.WriteLine("3. Вернуться в родительскую папку");
            Console.WriteLine("4. Создать папку");
            Console.WriteLine("5. Создать файл");
            Console.WriteLine("6. Удалить файл/папку");
            Console.WriteLine("7. Выход");

            Console.Write("\nВыберите действие (1-7): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    OpenFile();
                    break;
                case "2":
                    EnterDirectory();
                    break;
                case "3":
                    GoToParentDirectory();
                    break;
                case "4":
                    CreateDirectory();
                    break;
                case "5":
                    CreateFile();
                    break;
                case "6":
                    DeleteItem();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите действие от 1 до 7.");
                    WaitForInput();
                    break;
            }
        }
    }

    static void DisplayDirectoryContents(string path)
    {
        Console.WriteLine($"Текущий каталог: {path}\n");
        Console.WriteLine("Содержимое каталога:");
        Console.WriteLine(new string('-', 40));

        // Вывод родительского каталога (если не корневой)
        DirectoryInfo parentDir = Directory.GetParent(path);
        if (parentDir != null)
        {
            Console.WriteLine("[..] Родительский каталог");
        }

        try
        {
            // Вывод подкаталогов
            foreach (var dir in Directory.GetDirectories(path))
            {
                Console.WriteLine($"[DIR] {Path.GetFileName(dir)}");
            }

            // Вывод файлов
            foreach (var file in Directory.GetFiles(path))
            {
                Console.WriteLine($"[FILE] {Path.GetFileName(file)}");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Нет доступа к содержимому каталога");
        }

        Console.WriteLine(new string('-', 40));
    }

    static void OpenFile()
    {
        Console.Write("Введите имя файла для открытия: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(currentDirectory, fileName);

        if (File.Exists(filePath))
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.Clear();
                Console.WriteLine($"Содержимое файла {fileName}:\n");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при открытии файла: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Файл не найден или это не файл.");
        }

        WaitForInput();
    }

    static void EnterDirectory()
    {
        Console.Write("Введите имя папки для перехода: ");
        string dirName = Console.ReadLine();
        string newPath = Path.Combine(currentDirectory, dirName);

        if (Directory.Exists(newPath))
        {
            currentDirectory = newPath;
        }
        else
        {
            Console.WriteLine("Папка не найдена или это не папка.");
            WaitForInput();
        }
    }

    static void GoToParentDirectory()
    {
        DirectoryInfo parentDir = Directory.GetParent(currentDirectory);
        if (parentDir != null)
        {
            currentDirectory = parentDir.FullName;
        }
    }

    static void CreateDirectory()
    {
        Console.Write("Введите имя новой папки: ");
        string dirName = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(dirName))
        {
            try
            {
                string newDirPath = Path.Combine(currentDirectory, dirName);
                Directory.CreateDirectory(newDirPath);
                Console.WriteLine($"Папка '{dirName}' успешно создана.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании папки: {ex.Message}");
            }
            WaitForInput();
        }
    }

    static void CreateFile()
    {
        Console.Write("Введите имя нового файла (с расширением): ");
        string fileName = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(fileName))
        {
            try
            {
                Console.WriteLine("Введите содержимое файла (оставьте пустым, если не нужно):");
                string content = Console.ReadLine();

                string filePath = Path.Combine(currentDirectory, fileName);
                File.WriteAllText(filePath, content);
                Console.WriteLine($"Файл '{fileName}' успешно создан.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
            }
            WaitForInput();
        }
    }

    static void DeleteItem()
    {
        Console.Write("Введите имя файла или папки для удаления: ");
        string itemName = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(itemName))
        {
            string itemPath = Path.Combine(currentDirectory, itemName);

            if (File.Exists(itemPath))
            {
                Console.Write($"Вы уверены, что хотите удалить файл '{itemName}'? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    try
                    {
                        File.Delete(itemPath);
                        Console.WriteLine($"Файл '{itemName}' успешно удален.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при удалении файла: {ex.Message}");
                    }
                }
            }
            else if (Directory.Exists(itemPath))
            {
                Console.Write($"Вы уверены, что хотите удалить папку '{itemName}'? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    try
                    {
                        Directory.Delete(itemPath, true);
                        Console.WriteLine($"Папка '{itemName}' успешно удалена.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при удалении папки: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Указанный файл или папка не существует.");
            }

            WaitForInput();
        }
    }

    static void WaitForInput()
    {
        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }
}