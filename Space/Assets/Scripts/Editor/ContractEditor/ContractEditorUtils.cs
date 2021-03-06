﻿using System.IO;
using UnityEngine;
using WyrmTale;

public class ContractEditorUtils
{
    public static string ContractElementFilePath = "Assets/Resources/Contracts/ContractElements.txt";
    public static string StoryContractFilePath = "Assets/Resources/Contracts/StoryContracts.txt";

    public static JSON LoadJSONFromFile(string filepath)
    {
        string contractsContent = "{}";

        try
        {
            contractsContent = File.ReadAllText(filepath);
        }
        catch (FileNotFoundException e) { Debug.Log("Exception: " + e.Message + " " + "Creating new JSON"); }

        JSON js = new JSON();
        js.serialized = contractsContent;

        return js;
    }

    public static void WriteJSONToFile(string filepath, JSON js)
    {
        File.WriteAllText(filepath, js.serialized);
    }
}