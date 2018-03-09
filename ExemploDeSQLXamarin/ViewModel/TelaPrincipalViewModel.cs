using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using ExemploDeSQLXamarin.ViewModel;
using ExemploDeSQLXamarin.Model;
using ExemploDeSQLXamarin.Database;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExemploDeSQLXamarin.ViewModel
{
    public class TelaPrincipalViewModel :INotifyPropertyChanged

    {
        //Metodos e parametros da INotifyPropertyChanged, responsável por verificar se strings foram alteradas e atualizar as telas no seus respectivos objetos
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnpropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        // meus objetos declarados, dechei abaixo das configurações do INotify para simplificar
        public List<Tarefa> tarefas { get; set; }
        public Tarefa tarefaAtual { get; set; }
        public Command salvarTarefa { get; set; }
        public Command editarTarefa { get; set; }
        public Command excluirTarefa { get; set; }
        public Command mudarStatus { get; set; }




        public TelaPrincipalViewModel()
        {
            tarefas = new TarefasDataAccess().getTarefas();
            tarefaAtual = new Tarefa();
            salvarTarefa = new Command(salvar);
            editarTarefa = new Command<Tarefa>(editar);
            excluirTarefa = new Command<Tarefa>(excluir);
            mudarStatus = new Command<Tarefa>(atualizarStatus);
        }



        public void salvar(){
            if (tarefaAtual.id == 0)
            {
                tarefaAtual.finalizado = false;
                new TarefasDataAccess().salvarTarefa(tarefaAtual);
            }else{
                new TarefasDataAccess().editarTarefa(tarefaAtual);
            }
            tarefas = new TarefasDataAccess().getTarefas();
            OnpropertyChanged("tarefas");

            tarefaAtual = new Tarefa();
            OnpropertyChanged("tarefaAtual");
        }


        public void editar(Tarefa tarefaAux){
            tarefaAtual = tarefaAux;
            OnpropertyChanged("tarefaAtual");

            tarefas = new TarefasDataAccess().getTarefas();
            OnpropertyChanged("tarefas");
        }

        public void excluir(Tarefa tarefaAux){
            tarefaAtual = tarefaAux;

            new TarefasDataAccess().excluirTarefa(tarefaAtual);

            tarefas = new TarefasDataAccess().getTarefas();
            OnpropertyChanged("tarefas");

            tarefaAtual = new Tarefa();
            OnpropertyChanged("tarefaAtual");
        }

        public void atualizarStatus(Tarefa tarefaAux){
            tarefaAux.finalizado = !tarefaAux.finalizado;
            new TarefasDataAccess().editarTarefa(tarefaAux);

            tarefas = new TarefasDataAccess().getTarefas();
            OnpropertyChanged("tarefas");
        }


    }
}
