using APi_to_do_list.DTO;
using APi_to_do_list.ENTITIES;
using Microsoft.AspNetCore.Mvc;
using APi_to_do_list.DTO; 

namespace APi_to_do_list.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class TarefasUsuario : Controller
    {

        [HttpGet()]
        public List<Tarefa> PegarTarefas() 
        {
            Usuario tarefas = new Usuario();
            return tarefas.PegarTarefas();

            
        }


        [HttpPost()]

        public List <Tarefa> CadastrarNovaTarefa([FromBody] TarefaDTO novaTarefa)
        {

        Usuario tarefas = new Usuario();
        List<Tarefa> tarefasAtualizadas = tarefas.CadastrarTarefa(novaTarefa);


        return tarefasAtualizadas; 



        }


        [HttpPut("EditarTarefa/{id}")]

        public Tarefa EditarTarefa(Guid id, [FromBody] TarefaDTO tarefaPraEditar)
        {

            Usuario tarefa = new Usuario();

            Tarefa tarefaEditada = tarefa.EditarTarefa(id, tarefaPraEditar); 

            return tarefaEditada;
        }










    }
}
