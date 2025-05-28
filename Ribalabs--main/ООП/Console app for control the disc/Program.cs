using System;
using System.IO;
using System.Linq;

class FileExplorer
{
    static void Main()
    {
        Console.WriteLine("Консольный проводник");
        Console.WriteLine("--------------------");

        while (true)
        {
            Console.WriteLine("\nГлавное меню:");
            Console.WriteLine("1. Просмотреть доступные диски");
            Console.WriteLine("2. Выход");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowDrives();
                    break;
                case "2":
                    Console.WriteLine("Выход из программы...");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void ShowDrives()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        Console.WriteLine("\nДоступные диски:");
        for (int i = 0; i < drives.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {drives[i].Name}");
        }

        Console.Write("\nВыберите диск (0 - вернуться): ");
        if (int.TryParse(Console.ReadLine(), out int driveChoice))
        {
            if (driveChoice == 0) return;
            if (driveChoice > 0 && driveChoice <= drives.Length)
            {
                ShowDriveInfo(drives[driveChoice - 1]);
            }
            else
            {
                Console.WriteLine("Неверный выбор диска.");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод.");
        }
    }

    static void ShowDriveInfo(DriveInfo drive)
    {
        while (true)
        {
            Console.WriteLine($"\nИнформация о диске {drive.Name}:");
            try
            {
                Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
                Console.WriteLine($"Тип диска: {drive.DriveType}");
                Console.WriteLine($"Файловая система: {drive.DriveFormat}");
                Console.WriteLine($"Общий размер: {drive.TotalSize / (1024 * 1024 * 1024)} GB");
                Console.WriteLine($"Свободное место: {drive.TotalFreeSpace / (1024 * 1024 * 1024)} GB");
                Console.WriteLine($"Доступное место: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении информации: {ex.Message}");
            }

            Console.WriteLine("\nДействия:");
            Console.WriteLine("1. Просмотреть содержимое");
            Console.WriteLine("2. Создать каталог");
            Console.WriteLine("3. Вернуться к выбору диска");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BrowseDirectory(drive.RootDirectory.FullName);
                    break;
                case "2":
                    CreateDirectory(drive.RootDirectory.FullName);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void BrowseDirectory(string path)
    {
        while (true)
        {
            Console.WriteLine($"\nСодержимое {path}:");

            try
            {
                // Показываем подкаталоги
                string[] directories = Directory.GetDirectories(path);
                Console.WriteLine("\nКаталоги:");
                for (int i = 0; i < directories.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. [DIR] {Path.GetFileName(directories[i])}");
                }

                // Показываем файлы
                string[] files = Directory.GetFiles(path);
                Console.WriteLine("\nФайлы:");
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine($"{i + directories.Length + 1}. {Path.GetFileName(files[i])}");
                }

                Console.WriteLine("\nДействия:");
                Console.WriteLine("0. Вернуться назад");
                Console.WriteLine($"{directories.Length + files.Length + 1}. Создать каталог");
                Console.WriteLine($"{directories.Length + files.Length + 2}. Создать файл");
                Console.WriteLine($"{directories.Length + files.Length + 3}. Удалить файл/каталог");
                Console.Write("Выберите элемент или действие: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        // Вернуться на уровень выше
                        if (Path.GetDirectoryName(path) != null)
                        {
                            path = Path.GetDirectoryName(path);
                        }
                        else
                        {
                            return; // Достигнут корень диска
                        }
                    }
                    else if (choice == directories.Length + files.Length + 1)
                    {
                        CreateDirectory(path);
                    }
                    else if (choice == directories.Length + files.Length + 2)
                    {
                        CreateFile(path);
                    }
                    else if (choice == directories.Length + files.Length + 3)
                    {
                        DeleteItem(path);
                    }
                    else if (choice > 0 && choice <= directories.Length)
                    {
                        // Выбран каталог
                        path = directories[choice - 1];
                    }
                    else if (choice > directories.Length && choice <= directories.Length + files.Length)
                    {
                        // Выбран файл
                        string selectedFile = files[choice - directories.Length - 1];
                        Console.WriteLine($"Выбран файл: {selectedFile}");
                        Console.WriteLine($"Размер: {new FileInfo(selectedFile).Length} байт");
                        Console.WriteLine($"Дата создания: {File.GetCreationTime(selectedFile)}");
                        Console.WriteLine($"Дата изменения: {File.GetLastWriteTime(selectedFile)}");
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор.");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Ошибка: Нет доступа к каталогу.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return;
            }
        }
    }

    static void CreateDirectory(string path)
    {
        Console.Write("Введите имя нового каталога: ");
        string dirName = Console.ReadLine();

        try
        {
            string newDir = Path.Combine(path, dirName);
            Directory.CreateDirectory(newDir);
            Console.WriteLine($"Каталог '{dirName}' успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании каталога: {ex.Message}");
        }
    }

    static void CreateFile(string path)
    {
        Console.Write("Введите имя нового файла (с расширением .txt): ");
        string fileName = Console.ReadLine();

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        Console.WriteLine("Введите содержимое файла (для завершения ввода введите пустую строку):");
        string content = "";
        string line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            content += line + Environment.NewLine;
        }

        try
        {
            string newFile = Path.Combine(path, fileName);
            File.WriteAllText(newFile, content);
            Console.WriteLine($"Файл '{fileName}' успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
        }
    }

    static void DeleteItem(string path)
    {
        Console.Write("Введите имя файла или каталога для удаления: ");
        string itemName = Console.ReadLine();
        string fullPath = Path.Combine(path, itemName);

        if (!File.Exists(fullPath) && !Directory.Exists(fullPath))
        {
            Console.WriteLine("Файл или каталог не найден.");
            return;
        }

        Console.Write($"Вы уверены, что хотите удалить '{itemName}'? (y/n): ");
        string confirmation = Console.ReadLine().ToLower();

        if (confirmation != "y")
        {
            Console.WriteLine("Удаление отменено.");
            return;
        }

        try
        {
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
                Console.WriteLine("Файл успешно удален.");
            }
            else if (Directory.Exists(fullPath))
            {
                Directory.Delete(fullPath, true);
                Console.WriteLine("Каталог успешно удален.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при удалении: {ex.Message}");
        }
    }
}