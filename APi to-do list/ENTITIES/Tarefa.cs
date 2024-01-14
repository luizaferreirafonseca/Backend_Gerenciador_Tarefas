using APi_to_do_list.DTO;


namespace APi_to_do_list.ENTITIES
{
    public class Tarefa
    {

        public Guid Id { get; set; }
        public string NomeTarefa { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public string Descricao { get; set; }

        public bool EstaCompleta { get; set; }

        public Tarefa(Guid id, string nomeTarefa, DateTime dataInicio, DateTime dataTermino, string descricao)
        {
            Id = id;
            NomeTarefa = nomeTarefa;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Descricao = descricao;
            EstaCompleta = false;
        }


        public Tarefa(TarefaDTO novaTarefa)
        {
            Id = Guid.NewGuid();
            NomeTarefa = novaTarefa.NomeTarefa;
            DataInicio = novaTarefa.DataInicio;
            DataTermino = novaTarefa.DataTermino; 
            Descricao = novaTarefa.Descricao;
    
        }

        public Tarefa(EditarTarefaDTO tarefaModificada, Guid id)
        {
            Id = id; 
            NomeTarefa = tarefaModificada.NomeTarefa;
            DataInicio = tarefaModificada.DataInicio;
            Descricao = tarefaModificada.Descricao;
            EstaCompleta = tarefaModificada.EstaCompleta; 

        }





    }
}
