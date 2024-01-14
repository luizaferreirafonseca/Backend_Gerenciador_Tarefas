
using APi_to_do_list.DTO;
using APi_to_do_list.ENTITIES;
using System.Security.Cryptography.X509Certificates;

namespace APi_to_do_list.ENTITIES
{
    public class Usuario
    {

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public Guid Id { get; set; }

        public List<Tarefa> Tarefas { get; set; }



        public Usuario() {

        }

        public Usuario(string nome, string login, string senha, Guid id)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Id = id;
            Tarefas = new List<Tarefa>();
        }


        public List<Tarefa> PegarTarefas()
        {
            return Tarefas;
        }


        public List<Tarefa> CadastrarTarefa(TarefaDTO tarefa)
        {
            Tarefa novatarefa = new Tarefa(tarefa);
            Tarefas.Add(novatarefa);
            return Tarefas;

        }





        public Tarefa EditarTarefa(Guid id, TarefaDTO tarefaPraEditar)
        {
            var tarefa = Tarefas.Find(tarefa => tarefa.Id == id);
            if (tarefa == null)
            {
                throw new Exception($"Esse {id} não é válido");
            }
            else
            {

                tarefa = new Tarefa(tarefaPraEditar);
                return tarefa;

            }
        }




        public Tarefa ExcluirTarefa(Tarefa tarefaExcluida) {
            {
                var tarefa = Tarefas.FirstOrDefault(t => t.Id == tarefaExcluida.Id);
    
            if (tarefa == null)
                {
                    throw new Exception($"A tarefa com ID {tarefaExcluida.Id} não foi encontrada.");
                }

                Tarefas.Remove(tarefa);
                return tarefa;

            }



        }



        public Tarefa MarcarTarefaRealizada(Tarefa tarefaRealizada)
        {
            var tarefa = Tarefas.FirstOrDefault(t => t.Id == tarefaRealizada.Id);


            if (tarefa == null)
            {
                throw new Exception($"A tarefa com esse ID {tarefaRealizada.Id} não foi encontrada");


            }

            tarefa.EstaCompleta = true;

            return tarefa;

        }












    }
}