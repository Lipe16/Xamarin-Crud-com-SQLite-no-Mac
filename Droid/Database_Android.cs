
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;
using ExemploDeSQLXamarin.Droid;

//injeção de dependencia
[assembly: Xamarin.Forms.Dependency(typeof(Database_Android))]
namespace ExemploDeSQLXamarin.Droid
{

   
    public class Database_Android : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "exemplo.db";//nome do bando de dados

            //getFolderPath pega um valor inteiro que é gerado por SpecialFolder relativo a pasta onde será salvo o banco e o combine junta caminho e nome do banco
            var caminho = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),nomeDB);

            return new SQLiteConnection(caminho);
        }
    }
}
