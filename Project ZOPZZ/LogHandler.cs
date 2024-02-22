using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

public class LogHandler
{
    private const string FilePath = "logs.json";

    // Ensure the file exists
    public void EnsureLogFileExists()
    {
        if (!File.Exists(FilePath))
        {
            SaveLog(new List<Logs>());  // Initialize with an empty list
        }
    }

    // Overloaded Method to save a list of logs to the file
    public void SaveLog(List<Logs> logs)
    {
        List<Logs> currentLogs = GetLogs();

        currentLogs.AddRange(logs); // Adding all logs from the provided list

        string newJson = JsonConvert.SerializeObject(currentLogs, Formatting.Indented);
        File.WriteAllText(FilePath, newJson);
    }

    // Method to save a new single log to the file
    public void SaveLog(Logs log)
    {
        SaveLog(new List<Logs> { log });
    }

    // Method to get all logs from the file
    public List<Logs> GetLogs()
    {
        if (!File.Exists(FilePath))
        {
            return new List<Logs>();
        }

        string fileContent = File.ReadAllText(FilePath);
        List<Logs> logs = JsonConvert.DeserializeObject<List<Logs>>(fileContent);

        return logs ?? new List<Logs>();
    }

    // Method to load all logs into a DataGridView
    public void LoadLogsIntoDataGridView(DataGridView dgv)
    {
        dgv.DataSource = GetLogs();
    }
}

public class Logs
{
    public string Target { get; set; }
    public string Port { get; set; }
    public string Time { get; set; }
    public string Method { get; set; }
    public string DateSent { get; set; }
}
