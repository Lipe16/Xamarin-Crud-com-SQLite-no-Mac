using System;
using ExemploDeSQLXamarin.iOS;
using SQLite;
using System.IO;

//injeção de dependencia
[assembly: Xamarin.Forms.Dependency(typeof(Database_IOS))]
namespace ExemploDeSQLXamarin.iOS
{
    public class Database_IOS : IDataBase
    {
        public Database_IOS()
        {
        }

        public SQLiteConnection GetConnection()
        {


            var nomeDB = "exemplo.db";//nome do bando de dados

            //getFolderPath pega um valor inteiro que é gerado por SpecialFolder relativo a pasta onde será salvo o banco e o combine junta caminho e nome do banco
            //var caminho = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), nomeDB);

            string PersonalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string LibraryFolder = Path.Combine(PersonalFolder, "..", "Library");

            string caminhoDB = Path.Combine(LibraryFolder, nomeDB);
            return new SQLiteConnection(caminhoDB);
        }
    }
}
