namespace APi_to_do_list.DTO
{
    public class TarefaDTO
    {

        public string NomeTarefa { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public string Descricao { get; set; }

        public TarefaDTO(string nomeTarefa, DateTime dataInicio, DateTime dataTermino, string descricao)
        {
            NomeTarefa = nomeTarefa;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Descricao = descricao;
        }
    }
}
