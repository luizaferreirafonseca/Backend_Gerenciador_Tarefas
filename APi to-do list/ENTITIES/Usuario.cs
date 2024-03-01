
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


        public Usuario(string nome, string login, string senha, Guid id, List<Tarefa> tarefas)
        {
            Nome = nome; 
            Login = login;
            Senha = senha;
            Id = id;
            Tarefas = tarefas;
           
        }




        public List<Tarefa> PegarTarefas()
        {
            var teste = Tarefas;
            return Tarefas;
        }


        public Tarefa PegarTarefaPeloId(Guid id)
        {
            var tarefa = Tarefas.Find(tarefa => tarefa.Id == id);

            if (tarefa == null)
            {
                throw new Exception($"O {id} não existe");
            }
            return tarefa;


        }


        public List<Tarefa> CadastrarTarefa(TarefaDTO tarefa)
        {
            Tarefa novatarefa = new Tarefa(tarefa);
            Tarefas.Add(novatarefa);
            return Tarefas;

        }





        public Tarefa EditarTarefa(Guid id, TarefaDTO tarefaPraEditar)
        {
            var index = Tarefas.FindIndex(tarefa => tarefa.Id == id);
            if (index < 0)
            {
                throw new Exception($"Esse {id} não é válido");
            }
            else
            {

                var tarefa = new Tarefa(tarefaPraEditar, id);
                Tarefas[index] = tarefa;
                return tarefa;

            }
        }




        public List<Tarefa> ExcluirTarefa(Guid id)
        {

            var tarefa = Tarefas.Find(t => t.Id == id);

            if (tarefa == null)
            {
                throw new Exception($"A tarefa com ID {id} não foi encontrada.");
            }

            Tarefas.Remove(tarefa);
            return Tarefas; 


        }




        public Tarefa MarcarTarefaRealizada(Tarefa tarefaRealizada)
        {
            var tarefa = Tarefas.Find(t => t.Id == tarefaRealizada.Id);


            if (tarefa == null)
            {
                throw new Exception($"A tarefa com esse ID {tarefaRealizada.Id} não foi encontrada");


            }

            tarefa.EstaCompleta = true;

            return tarefa;

        }















    }
}