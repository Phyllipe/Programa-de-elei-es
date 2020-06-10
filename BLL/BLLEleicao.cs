using DAL;
using System;
using MODELO;
using MySql.Data.MySqlClient;
using System.Data;

namespace BLL
{
    public class BLLEleicao
    {
        private DALEleicao DALobj;

        public BLLEleicao(DALConexao cx)
        {
            DALobj = new DALEleicao(cx);
        }

        public void Incluir(MODELOEleicao modelo)
        {
            try
            {
                

                

                DALobj.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
               


                DALobj.Alterar(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(int codigo)
        {
            
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(string texto)
        {
            return DALobj.Localizar(texto);
        }
    }
}

