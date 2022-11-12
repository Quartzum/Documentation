void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[]catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

FileInfo[] files = catalog.GetFiles();

for (int i = 0; i < files.Length; i++)
{
    Console.WriteLine($"{indent}{files[i].Name}");
}
}

string path = "Geekbrains/Acquaintance_with_languages/Lecture_C#/Lecture_7/task_5";
CatalogInfo(path);