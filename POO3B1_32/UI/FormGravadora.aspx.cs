using POO3B1_32.BLL;
using POO3B1_32.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POO3B1_32.UI
{
    public partial class FormGravadora : System.Web.UI.Page
    {
        MusicaBLL bllmusica = new MusicaBLL();
        CDBLL bllcd = new CDBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            preencherdados();
        }

        public void preencherdados(DataTable dados=null)
        {
            if(dados == null)
            {
                GridView1.DataSource = bllmusica.pegardados();               
            }
            else
            {
                GridView1.DataSource = dados;
            }
        GridView1.DataBind();
        }

        protected void btnpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dados = bllmusica.pegardados(txtnomemusica.Text);
                preencherdados(dados);
            }
            catch (Exception error)
            {
                MensagemDeErro.Text = error.Message;
            }
        }

        protected void btncriar_Click(object sender, EventArgs e)
        {
            try
            {
                MusicaDTO musica = new MusicaDTO(txtnomemusica.Text,txtnomeautor.Text);
                CDDTO cd = new CDDTO(txtnomecd.Text,double.Parse(txtpreco.Text));
                bllcd.criarcd(cd);
                bllmusica.criarmusica(musica,cd);
                preencherdados();
            }
            catch (Exception error)
            {
                MensagemDeErro.Text = error.Message;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string musicaid = e.Values[0].ToString();
                bllmusica.deletarmusica(musicaid);
                string idCD = e.Values[2].ToString();
                bllcd.deletarcd(idCD);
                preencherdados();
            }
            catch (Exception error)
            {
                MensagemDeErro.Text = error.Message;
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string id = e.NewValues[0].ToString();
                string nome = e.NewValues[6].ToString();
                string nomeAutor = e.NewValues[7].ToString();
                string idcd = e.NewValues[2].ToString();
                string nomeCD = e.NewValues[3].ToString();
                string precoVenda = e.NewValues[4].ToString();
                MusicaDTO musica = new MusicaDTO(nome,nomeAutor);
                musica.IdMusica = id;
                bllmusica.editar(musica);
                CDDTO cd = new CDDTO(int.Parse(idcd), nomeCD,double.Parse(precoVenda));
                bllcd.editarcd(cd);
                GridView1.EditIndex = -1;
                preencherdados();
            }
            catch (Exception error)
            {
                MensagemDeErro.Text = error.Message;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            preencherdados();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            preencherdados();
        }

    }
}