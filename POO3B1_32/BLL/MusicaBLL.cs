using POO3B1_32.DAL;
using POO3B1_32.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO3B1_32.BLL
{
    public class MusicaBLL
    {
        GravadoraDal bancodedados = new GravadoraDal();
        public DataTable pegardados(string nome = null)
        {
            try
            {
                string consulta = "";
                if(string.IsNullOrEmpty(nome)){
                    consulta = "select TBL_Musica.idMusica, TBL_Gravadora.nome,TBL_CD.idCD,TBL_CD.nomeCD,TBL_CD.precoVenda,TBL_CD.dtLancamento,TBL_Musica.nome,TBL_Musica.nomeAutor from (TBL_Musica inner join TBL_CD on TBL_Musica.idCD = TBL_CD.idCD inner join TBL_Gravadora on TBL_Musica.idGravadora = TBL_Gravadora.idGravadora)";
                }
                else 
                {
                    consulta = string.Format($@"select TBL_Musica.idMusica, TBL_Gravadora.nome,TBL_CD.idCD,TBL_CD.nomeCD,TBL_CD.precoVenda,TBL_CD.dtLancamento,TBL_Musica.nome,TBL_Musica.nomeAutor from (TBL_Musica inner join TBL_CD on TBL_Musica.idCD = TBL_CD.idCD inner join TBL_Gravadora on TBL_Musica.idGravadora = TBL_Gravadora.idGravadora)where TBL_Musica.nome = '{nome}'");
                }
                DataTable dadosMusica = bancodedados.pegardados(consulta);
                return dadosMusica;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void criarmusica(MusicaDTO musica , CDDTO cd)
        {
            try
            {
                string consulta = string.Format($@"insert into TBL_Musica(idMusica,nome,nomeAutor,idGravadora,idCD) values(null,'{musica.Nome}','{musica.NomeAutor}','1','{cd.IdCD}')");
                bancodedados.executarcomando(consulta); 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void deletarmusica(string idMusica)
        {
            try
            {
                string consulta = string.Format($@"delete from TBL_Musica where idMusica = '{idMusica}'");
                bancodedados.executarcomando(consulta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void editar(MusicaDTO musica)
        {
            try
            {
                string consulta = string.Format($@"update TBL_Musica set nome='{musica.Nome}',nomeAutor ='{musica.NomeAutor}' where idMusica = '{musica.IdMusica}'");
                bancodedados.executarcomando(consulta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
}
}