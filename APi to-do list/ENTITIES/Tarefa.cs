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

        public string Status {  get; set; }


        public Tarefa(Guid id, string nomeTarefa, DateTime dataInicio, DateTime dataTermino, string descricao)
        {
            Id = id;
            NomeTarefa = nomeTarefa;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Descricao = descricao;
            EstaCompleta = false;
            Status = PegarStatus(dataInicio, dataTermino, false); 
        }

        public Tarefa(TarefaDTO tarefaModificada, Guid id)
        {
            Id = id;
            NomeTarefa = tarefaModificada.NomeTarefa;
            DataInicio = tarefaModificada.DataInicio;
            DataTermino = tarefaModificada.DataTermino;
            Descricao = tarefaModificada.Descricao;
            Status = PegarStatus(DataInicio, DataTermino, false);

        }


        public Tarefa(TarefaDTO novaTarefa)
        {
            Id = Guid.NewGuid();
            NomeTarefa = novaTarefa.NomeTarefa;
            DataInicio = novaTarefa.DataInicio;
            DataTermino = novaTarefa.DataTermino; 
            Descricao = novaTarefa.Descricao;
            Status = PegarStatus(DataInicio, DataTermino, false);
           

        }

      



        private string PegarStatus(DateTime dataInicio, DateTime dataTermino, bool estaCompleta)
        {

            DateTime dataAtual = DateTime.Now; 


            if(estaCompleta == true)
            {
                return "Completed";
            }
            if (dataAtual > dataTermino)
            {
                return "Delayed"; 
            }
            if(dataInicio > dataAtual)
            {
                return "Pending";
            }
            if(dataInicio <= dataAtual && dataAtual < dataTermino)
            {
                return "In progress";
                            
            }

            return "Nonexistent status"; 
        }   




    }
}
