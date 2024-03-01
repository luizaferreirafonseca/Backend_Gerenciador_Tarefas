using APi_to_do_list.DTO;
using APi_to_do_list.ENTITIES;
using Microsoft.AspNetCore.Mvc;
using APi_to_do_list.DTO;
using APi_to_do_list.DATA; 

namespace APi_to_do_list.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class TarefasUsuario : Controller
    {

        [HttpGet()]
        public List<Tarefa> PegarTarefas() 
        {
            Usuario user = Data.usuarios[0];
            return user.PegarTarefas();

            
        }



        [HttpGet("{id}")]

       public Tarefa PegarTarefaPeloId(Guid id)
        {
            try
            {
                Usuario user = Data.usuarios[0];
                Tarefa tarefaEncontrada = user.PegarTarefaPeloId(id);
                return tarefaEncontrada; 

            } catch (Exception error)
            {
                throw new Exception(error.Message); 
            }
        }


        [HttpPost()]

        public List <Tarefa> CadastrarNovaTarefa([FromBody] TarefaDTO novaTarefa)
        {

            Usuario user = Data.usuarios[0];
        List<Tarefa> tarefasAtualizadas = user.CadastrarTarefa(novaTarefa);


        return tarefasAtualizadas; 



        }


        [HttpPut("EditarTarefa/{id}")]

        public Tarefa EditarTarefa(Guid id, [FromBody] TarefaDTO tarefaPraEditar)
        {

            Usuario user = Data.usuarios[0];

            Tarefa tarefaEditada = user.EditarTarefa(id, tarefaPraEditar); 

            return tarefaEditada;
        }



        [HttpDelete("DeletarTarefa/{id}")]

        public List<Tarefa> DeletarTarefa(Guid id)
        {
            Usuario user = Data.usuarios[0];

            List<Tarefa> tarefasDepoisDoDelete = user.ExcluirTarefa(id);

            return tarefasDepoisDoDelete; 

        }



        


    }
}
