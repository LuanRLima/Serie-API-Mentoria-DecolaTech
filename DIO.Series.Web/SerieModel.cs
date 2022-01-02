using DIO.Series.Classes;
using DIO.Series.Enum;

namespace DIO.Series.Web
{
    public class SerieModel
    {
        public int Id { get; set; }
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descrição { get; set;}
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        public SerieModel(){ }
        public SerieModel(Serie serie)
        {
            Id = serie.retornaId();
            Genero = serie.retornaGenero();
            Titulo = serie.retornaTitulo();
            Ano = serie.retornaAno();
            Descrição = serie.retornaDescricao();

        }
        public Serie ToSerie()
        {
            return new Serie(Id, Genero, Titulo, Descrição, Ano);
        }

    }
}
