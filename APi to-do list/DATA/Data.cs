using APi_to_do_list.DTO;
using APi_to_do_list.ENTITIES;

namespace APi_to_do_list.DATA
{
    public class Data
    {
        public static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("Luiza", "luiza@gmail.com", "123456", Guid.NewGuid(), new List<Tarefa>
            {
                new Tarefa(new TarefaDTO("comer", DateTime.Now, DateTime.Now.AddHours(2), "Almoço")),
                new Tarefa(new TarefaDTO("dormir", DateTime.Now, DateTime.Now.AddHours(4), "Soneca"))
            }),

            new Usuario("Leo", "leo@gmail.com", "789", Guid.NewGuid()),

            new Usuario("Sofia", "sofia@gmail.com", "170516", Guid.NewGuid()),


        };


       

    }
}
