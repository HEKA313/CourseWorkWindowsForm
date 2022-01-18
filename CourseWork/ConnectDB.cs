using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace CourseWork
{
	// Класс соединения с базой данных
	internal class ConnectDB
	{
		// Метод для подключения к бд
		public static SqliteConnection ConnectToTheDB()
		{
			// Строка подключения к базе данных tableOfRecords.db
			string connectionString = "Data Source=tableOfRecords.db;Mode=ReadWriteCreate;";

			// Подключение к базе данных и создание таблицы в бд
			SqliteConnection connection = new SqliteConnection(connectionString);

			return connection;
		}

		// метод для создания таблицы в бд
		public static void CreateTable()
		{

			var connection = ConnectToTheDB();

			// Подключение
			connection.Open();

			// Создание таблицы
			SqliteCommand command = new SqliteCommand
			{
				Connection = connection,
				CommandText = "CREATE TABLE Recordsman(" +
				"_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
				"Name TEXT NOT NULL, " +
				"DifficultyGame TEXT NOT NULL, " +
				"Field TEXT NOT NULL, " +
				"Time TEXT NOT NULL, " +
				"MovesCount INTEGER NOT NULL, " +
				"HintsCount INTEGER NOT NULL)"
			};

			command.ExecuteNonQuery();

		}

		// метод для извлечения из бд
		public static SqliteDataReader SelectFromTheDB(SqliteConnection connection, string commandText)
		{
			connection.Open();
			SqliteCommand command = new SqliteCommand
			{
				Connection = connection,
				CommandText = commandText,
			};

			SqliteDataReader reader = command.ExecuteReader();
			return reader;
		}

		// метод для обновления в бд
		public static void UpdateAndInsertTheDB(SqliteConnection connection, string commandText)
		{
			connection.Open();

			SqliteCommand command = new SqliteCommand
			{
				Connection = connection,
				CommandText = commandText,
			};

			command.ExecuteNonQuery();
		}
	}
}