using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

public static class JsonStorage
{
    private static readonly string filePath = "contacts.json";

    // Сохранение списка контактов в JSON
    public static void Save(List<Contact> contacts)
    {
        try
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(filePath, json);
            MessageBox.Show("Контакты успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Загрузка из JSON
    public static List<Contact> Load()
    {
        try
        {
            if (!File.Exists(filePath))
                return new List<Contact>();

            string json = File.ReadAllText(filePath);
            var list = JsonConvert.DeserializeObject<List<Contact>>(json);
            return list ?? new List<Contact>();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при загрузке: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<Contact>();
        }
    }
}