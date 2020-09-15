using POO3B1_32.DAL;
using POO3B1_32.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO3B1_32.BLL
{
    public class CDBLL
    {
        GravadoraDal bancodedados = new GravadoraDal();

        public void criarcd(CDDTO cd)
        {
            try
            {
                string consulta = string.Format($@"insert into TBL_CD(idCD,nomeCD,precoVenda,dtLancamento) values('{cd.IdCD}','{cd.NomeCD}','{cd.PrecoVenda}','{DateTime.Now.ToString("yyyy-MM-dd")}')");
                bancodedados.executarcomando(consulta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void deletarcd(string IdCD)
        {
            try
            {
                string consulta = string.Format($@"delete from TBL_CD where IdCD = '{IdCD}'");
                bancodedados.executarcomando(consulta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void editarcd(CDDTO cd)
        {
            try
            {
                string consulta = string.Format($@"update TBL_CD set nomeCD='{cd.NomeCD}',precoVenda ='{cd.PrecoVenda}',dtLancamento ='{DateTime.Now.ToString("yyyy-MM-dd")}' where IdCD = '{cd.IdCD}'");
                bancodedados.executarcomando(consulta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}