using System;

namespace SI_Cadastro{

// Herdando class base
  public class Serie: Entidadebase
  {
    // Instaciamento de var a ser ultilizadas
    private Genero Genero{get;set;}
    private string Titulo{get;set;}
    private string Descricao{get;set;}
    private int Ano{get;set;}

    private bool Excluido {get; set;}

    // Metodo para armazenar dados as variaveis.
    public Serie(int id,Genero Genero,string Titulo,string Descricao,int Ano)
    {
        this.id = id;
        this.Genero =  Genero;
        this.Titulo = Titulo;
        this.Descricao = Descricao;
        this.Ano = Ano;
        this.Excluido = false;
    }

    // Metodo para sobrescrever o metodo ToString para que seja retornado uma string completa dos dados
    public override string ToString()
    {
      // Environment.NewLine Ultilizado para pular de linha independente do SO
      string retorno = "";
      retorno += "Genêro: " + this.Genero + Environment.NewLine;
      retorno += "Titulo: " + this.Titulo + Environment.NewLine;
      retorno += "Descricao: " + this.Descricao + Environment.NewLine;
      retorno += "Ano: " + this.Ano + Environment.NewLine;
      retorno += "Excluido: " + this.Excluido;
      return retorno;
      
    }

    // Metodo para retornar o titulo da série
    public string retornaTitulo()
    {
      return this.Titulo;
    }

    // Metodo para retornar a exlusão da série
    public bool retornaExlcuido()
    {
      return this.Excluido;
    }

    // Metodo para retornar o ID série
    public int retornaId()
    {
      return this.id;
      
    }

    // Metodo para retornar a exclusão série
    public void Excluir()
    {
        this.Excluido = true;
    }

  }


}