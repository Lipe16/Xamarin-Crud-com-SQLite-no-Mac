using System;
using SQLite;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using ExemploDeSQLXamarin.Model;

namespace ExemploDeSQLXamarin.Database
{
    public class TarefasDataAccess
    {
        private SQLiteConnection _database;

        public TarefasDataAccess()
        {
            _database = DependencyService.Get<IDataBase>().GetConnection();
            _database.CreateTable<Tarefa>();
        }

        //retorna lista de tarefas
        public List<Tarefa> getTarefas(){
            return _database.Table<Tarefa>().ToList();
        }


        //salvar
        public int salvarTarefa(Tarefa tarefa){

            return _database.Insert(tarefa);
        }

        //excluir
        public int excluirTarefa(Tarefa tarefa)
        {

            return _database.Delete(tarefa);
        }

        //editar
        public int editarTarefa(Tarefa tarefa)
        {

            return _database.Update(tarefa);
        }
    }
}
