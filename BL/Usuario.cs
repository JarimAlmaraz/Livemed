using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.PruebaLivemedEntities context = new DL.PruebaLivemedEntities())
                {
                    var usuario = context.UsuarioGetAll().ToList();
                    if (usuario != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var objUsuario in usuario)
                        {
                            ML.Usuario Usuario = new ML.Usuario();
                            Usuario.IdUsuario = objUsuario.IdUsuario;
                            Usuario.Nombre = objUsuario.Nombre;
                            Usuario.Apaterno = objUsuario.Apaterno;
                            Usuario.Amaterno = objUsuario.Amaterno;

                            Usuario.Especialidades = new ML.Especialidades();
                            Usuario.Especialidades.IdEspecialidad = objUsuario.IdEspecialidad.Value;

                            Usuario.Estados = new ML.Estados();
                            Usuario.Estados.IdEstados = objUsuario.IdPais.Value;

                            Usuario.Paises = new ML.Paises();
                            Usuario.Paises.IdPais = objUsuario.IdPais.Value;

                            result.Objects.Add(Usuario);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al obtener los datos de la Tabla Alumno";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
