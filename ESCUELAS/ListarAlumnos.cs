using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCUELAS
{
    public partial class ListarAlumnos : Form
    {
        string stringConnection;

        public ListarAlumnos()
        {
            stringConnection = ConfigurationManager
         .ConnectionStrings["cnxEscuela"]
         .ConnectionString;
            InitializeComponent();
        }

        private void ListarMisAlumnos_Load(object sender, EventArgs e)
        {
            cargarApoderados();
        }
        private void cargarApoderados()
        {

            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //podemos hacer uiso de la conecion en la variable con
                try
                {
                    con.Open();
                    string query = "SELECT ApoRut, CONCAT(ApoNombre, ' ' , ApoApellidoPaterno, ' ' , ApoApellidoMaterno) AS ApoAlias FROM    TB_APODERADO";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "APODERADO");

                    cbxApoderado.DisplayMember = "ApoAlias";
                    cbxApoderado.ValueMember = "ApoRut";

                    cbxApoderado.DataSource = dataSet.Tables["APODERADO"];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                                            "Error al conectarse a la base de Datos : Al cargar Apoderado " + ex,
                                            ".: Sistema Alumno :.",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                }
                finally
                {
                    con.Close();
                }
            }
        }


        private void cargarAlumnos()
        {

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                int rutApo = Convert.ToInt32( cbxApoderado.SelectedValue.ToString());

                //selectedValue tiene el valor del item seleccionado
                //este valor se asigna en la propiedad ValueMember  
                try
                {
                    conn.Open();
                    string query = "SELECT AluRut, CONCAT(AluNombre, ' ' , AluApellidoPaterno, ' ' , AluApellidoMaterno) AS AluAlias FROM    TB_ALUMNO WHERE ApoRut ='"+rutApo+"'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Alumno");

                    cbxAlumno.DisplayMember = "AluAlias";
                    cbxAlumno.ValueMember = "AluRut";
                    cbxAlumno.DataSource = dataSet.Tables["Alumno"];
                }
                catch (SqlException es)
                {
                    MessageBox.Show(
                                      "Error al conectarse a la base de Datos : Cuando intento cargar Combobox Alumnos" + es,
                                      ".: Sistema Alumnos :.",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error
                                      );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                           "Error al conectarse a la base de Datos : Al listar Alumno en Grilla" + ex,
                           ".: Sistema Alumnos :.",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                           );
                }
            }

        }

        private void cargarAlumnos(object sender, EventArgs e)
        {
       //  ComboBox miCombobox =    (ComboBox) sender;

         
            cargarAlumnos();
        }
    }
}
