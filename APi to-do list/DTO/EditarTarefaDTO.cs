namespace APi_to_do_list.DTO
{
    public class EditarTarefaDTO
    {
        public string NomeTarefa { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public string Descricao { get; set; }

        public bool EstaCompleta { get; set; }

    }
}
