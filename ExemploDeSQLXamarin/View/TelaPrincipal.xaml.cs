using System;
using System.Collections.Generic;
using ExemploDeSQLXamarin.ViewModel;
using ExemploDeSQLXamarin.Model;
using ExemploDeSQLXamarin.Database;

using Xamarin.Forms;

namespace ExemploDeSQLXamarin.View
{
    public partial class TelaPrincipal : ContentPage
    {
        Tarefa tarefaEdicao { get; set; }

        public TelaPrincipal()
        {
            InitializeComponent();
            BindingContext = new TelaPrincipalViewModel();

        }


        /*
        public void mudarStatus(Object sender, EventArgs e)
        {

            var tarefa = ((Button)sender).CommandParameter as Tarefa;

            tarefa.finalizado = !tarefa.finalizado;

   
            new TarefasDataAccess().editarTarefa(tarefa);

            BindingContext = new TelaPrincipalViewModel();//atualiza lista
        }*/


    }
}
