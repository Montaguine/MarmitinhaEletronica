﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public abstract class JsonParser <T> where T : class
{
    public static List<T> ReceberJson()
    {
        string tipo = typeof(T).Name; // Recebe o nome da classe
        // Recebe os paths
        string absolutePath = @$"C:\Users\luanar\source\repos\MarmitaEletronica\Cardapio\{tipo}.json";
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string relativePath = Path.GetRelativePath(baseDirectory, absolutePath);

        try
        {
            string jsonString = File.ReadAllText(absolutePath);
            List<T> itemList = JsonSerializer.Deserialize<List<T>>(jsonString);
            return itemList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }
}