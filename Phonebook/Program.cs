using System;
using Microsoft.Data.Sqlite;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            var connection = "Data Source = Phonebook.sqlite; Mode = ReadWrite;";
            var db = new SqliteConnection(connection);
            db.Open();
            
            string sql, first_name, last_name;
            int phone_number;
            
            Console.Write("Введите имя - ");
            first_name = Console.ReadLine();
            Console.Write("Введите фамилию - ");
            last_name = Console.ReadLine();
            Console.Write("Введите телефон - ");
            phone_number = Convert.ToInt32(Console.ReadLine());
            
            sql = $"insert into table_phonebook (first_name, last_name, phone_number) values ('{first_name}', '{last_name}', {phone_number})";
            var command = new SqliteCommand {Connection = db, CommandText = sql};
            command.ExecuteNonQuery();
            
            db.Close();
        }
    }
}