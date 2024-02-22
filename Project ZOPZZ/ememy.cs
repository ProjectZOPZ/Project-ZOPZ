using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

public class Enemy
{
    private const string FilePath = "enemy_logs.json";

    // Ensure the file exists

    // Overloaded Method to save a list of logs to the file
    public void SaveLogs(List<EnemyLog> logs)
    {
        List<EnemyLog> currentLogs = GetLogs();

        currentLogs.AddRange(logs); // Adding all logs from the provided list

        string newJson = JsonConvert.SerializeObject(currentLogs, Formatting.Indented);
        File.WriteAllText(FilePath, newJson);
    }

    // Method to save a new single log to the file
    public void SaveLog(EnemyLog log)
    {
        SaveLogs(new List<EnemyLog> { log });
    }

    // Method to get all logs from the file
    public List<EnemyLog> GetLogs()
    {
        if (!File.Exists(FilePath))
        {
            return new List<EnemyLog>();
        }

        string fileContent = File.ReadAllText(FilePath);
        List<EnemyLog> logs = JsonConvert.DeserializeObject<List<EnemyLog>>(fileContent);

        return logs ?? new List<EnemyLog>();
    }

    // Method to load all logs into a DataGridView
    public void LoadLogsIntoDataGridView(DataGridView dgv)
    {
        dgv.DataSource = GetLogs();
    }
}

public class EnemyLog
{
    public string IP { get; set; }
    public string Label { get; set; }
    public string DateSent { get; set; }
}
