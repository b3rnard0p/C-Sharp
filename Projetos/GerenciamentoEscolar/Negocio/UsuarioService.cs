using System;
using System.Data;
using Models;
using DataAccess;

namespace Business
{
    public class UsuarioService
    {
        private readonly UsuarioDAO objd = new UsuarioDAO();

        public DataTable N_Login(Usuario obje)
        {
            if (string.IsNullOrEmpty(obje.nome) || string.IsNullOrEmpty(obje.senha))
            {
                throw new ArgumentException("Nome de usuário e senha são obrigatórios");
            }
            return objd.DLogin(obje);
        }

        public DataTable N_BuscarUsuario(string nome)
        {
            var entidade = new Usuario { nome = nome };
            return objd.D_BuscarUsuario(entidade);
        }

        public DataTable N_ListarUsuario()
        {
            return objd.D_ListarUsuario(new Usuario());
        }

        public DataTable N_ListarTipo()
        {
            return objd.D_ListarTipo(new Usuario());
        }

        public string N_CrudUsuario(Usuario obje)
        {
            if (obje == null)
            {
                throw new ArgumentNullException(nameof(obje), "Objeto usuário não pode ser nulo");
            }

            switch (obje.acao)
            {
                case "1":
                    if (string.IsNullOrEmpty(obje.nome) || string.IsNullOrEmpty(obje.id_tipo))
                    {
                        throw new ArgumentException("Nome e tipo são obrigatórios para cadastro");
                    }
                    break;

                case "2":
                    if (obje.id <= 0)
                    {
                        throw new ArgumentException("ID inválido para atualização");
                    }
                    break;

                case "3":
                    if (obje.id <= 0)
                    {
                        throw new ArgumentException("ID inválido para exclusão");
                    }
                    break;

                default:
                    throw new ArgumentException("Ação inválida. Use: 1-Inserir, 2-Atualizar, 3-Excluir");
            }

            return objd.D_MCrudUsuario(obje);
        }
    }
}