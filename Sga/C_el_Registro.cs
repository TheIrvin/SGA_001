using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sga
{
    internal class C_el_Registro
    {
        private Conexión_BDD conexion = new Conexión_BDD();

        public bool RegistrarAlumno(string gmail, string contraseña, string nombreCompleto, string cedula, string nombrePadre, string nombreMadre, string teléfono)
        {
            try
            {
                using (SqlConnection con = conexion.AbrirConexion()) 
                {
                    string queryUsuarios = "INSERT INTO Usuarios (Gmail, Contraseña, TipoUsuario) OUTPUT INSERTED.ID VALUES (@Gmail, @Contraseña, 'Alumno')";
                    SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con);
                    cmdUsuarios.Parameters.AddWithValue("@Gmail", gmail);
                    cmdUsuarios.Parameters.AddWithValue("@Contraseña", contraseña);
                    int usuarioID = (int)cmdUsuarios.ExecuteScalar(); 

                    string queryAlumnos = "INSERT INTO Alumnos (UsuarioID, NombreCompleto, Cedula, NombrePadre, NombreMadre, Teléfono) VALUES (@UsuarioID, @NombreCompleto, @Cedula, @NombrePadre, @NombreMadre, @Teléfono)";
                    SqlCommand cmdAlumnos = new SqlCommand(queryAlumnos, con);
                    cmdAlumnos.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmdAlumnos.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    cmdAlumnos.Parameters.AddWithValue("@Cedula", cedula);
                    cmdAlumnos.Parameters.AddWithValue("@NombrePadre", nombrePadre);
                    cmdAlumnos.Parameters.AddWithValue("@NombreMadre", nombreMadre);
                    cmdAlumnos.Parameters.AddWithValue("@Teléfono", teléfono);

                    cmdAlumnos.ExecuteNonQuery();
                    return true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar alumno: " + ex.Message);
                return false;
            }
        }

        public bool RegistrarProfesor(string gmail, string contraseña, string nombres, string apellidos, string cedula, string teléfono)
        {
            try
            {
                

                using (SqlConnection con = conexion.AbrirConexion())
                {
                    string queryUsuarios = "INSERT INTO Usuarios (Gmail, Contraseña, TipoUsuario) OUTPUT INSERTED.ID VALUES (@Gmail, @Contraseña, 'Profesor')";
                    SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con);
                    cmdUsuarios.Parameters.AddWithValue("@Gmail", gmail);
                    cmdUsuarios.Parameters.AddWithValue("@Contraseña", contraseña);
                    int usuarioID = (int)cmdUsuarios.ExecuteScalar(); 

                    string queryProfesores = "INSERT INTO Profesores (UsuarioID, Nombres, Apellidos, Cedula, Teléfono) VALUES (@UsuarioID, @Nombres, @Apellidos, @Cedula, @Teléfono)";
                    SqlCommand cmdProfesores = new SqlCommand(queryProfesores, con);
                    cmdProfesores.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmdProfesores.Parameters.AddWithValue("@Nombres", nombres);
                    cmdProfesores.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmdProfesores.Parameters.AddWithValue("@Cedula", cedula);
                    cmdProfesores.Parameters.AddWithValue("@Teléfono", teléfono);

                    cmdProfesores.ExecuteNonQuery(); 
                    return true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar profesor: " + ex.Message);
                return false;
            }
        }

    }
}
