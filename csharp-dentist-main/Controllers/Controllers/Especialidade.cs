using System;
using System.Collections.Generic;
using System.Linq;
using Models;
namespace Controllers
{
    public class EspecialidadeControllers
    {
        public static Especialidade IncluirEspecialidade(
            string Descricao,
            string Detalhamento
        )
        {
            if (String.IsNullOrEmpty(Descricao)) {
                throw new Exception("Descricao é obrigatório");
            }

            return new Especialidade(Descricao, Detalhamento);
        }

        public static Especialidade AlterarEspecialidade(
            int Id,
            string Descricao,
            string Detalhamento
        )
        {
            Especialidade especialidade = GetEspecialidade(Id);

            if (!String.IsNullOrEmpty(Descricao)) {
                especialidade.Descricao = Descricao;
            }
            especialidade.Descricao = Descricao;

            return especialidade;
        }

        public static Especialidade ExcluirEspecialidade(
            int Id
        )
        {
            Especialidade especialidade = GetEspecialidade(Id);
            Models.Especialidade.RemoverEspecialidade(especialidade);
            return especialidade;
        }

        public static List<Especialidade> VisualizarEspecialidades()
        {
            return Models.Especialidade.GetEspecialidades();  
        }

        public static Especialidade GetEspecialidade(
            int Id
        )
        {
            List<Especialidade> especialidades = Models.Especialidade.GetEspecialidades();
            IEnumerable<Especialidade> Especialidades = from Especialidade in especialidades
                            where Especialidade.Id == Id
                            select Especialidade;
            Especialidade especialidade = especialidades.First();
            
            if (especialidade == null)
            {
                throw new Exception("Especialidade não encontrada");
            }

            return especialidade;
        }
    }
}