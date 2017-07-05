using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ESCUELAS
{
    public partial class GuardarAlumno : Form
    {
        private string stringConnection;

        public GuardarAlumno()
        //carga la conexion a la base de datos sql
        {
            stringConnection = ConfigurationManager
                .ConnectionStrings["cnxEscuela"]
                .ConnectionString;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargarControlesIniciales(object sender, EventArgs e)
        {
            cargarCursos();
            cargarApoderados();
            limpiarFormulario();

            cargarAlumnos();
        }

        private void limpiarFormulario() {
            txtRut.Text = "";
            txtRut.Enabled = true;
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            cbxCurso.SelectedIndex = 0;
            cbxApoderados.SelectedIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.Image = Properties.Resources.save_16;
        }

        private void cargarCursos()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //podemos hacer uiso de la conecion en la variable con

                try
                {
                    con.Open();
                    string query = "SELECT CurCodigo, CurNombre FROM TB_CURSO";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Cursos");

                    cbxCurso.DisplayMember = "CurNombre";
                    cbxCurso.ValueMember = "CurCodigo";

                    cbxCurso.DataSource = dataSet.Tables["Cursos"];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                                            "Error al conectarse a la base de Datos : Al cargar Cursos" + ex,
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
        private void cargarApoderados() {

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
                    cbxApoderados.DisplayMember = "ApoAlias";
                    cbxApoderados.ValueMember = "ApoRut";
                    cbxApoderados.DataSource = dataSet.Tables["APODERADO"];
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
                try
                {
                    string query = "select TB_ALUMNO.AluRut as Rut, Concat (TB_ALUMNO.AluNombre, ' ', TB_ALUMNO.AluApellidoPaterno, ' ', TB_ALUMNO.AluApellidoMaterno) as Alias_Alumno, concat (TB_APODERADO.ApoNombre, ' ', TB_APODERADO.ApoApellidoPaterno, ' ',TB_APODERADO.ApoApellidoMaterno) AS Alias_Apoderado, TB_CURSO.CurNombre AS Curso From TB_APODERADO inner join TB_ALUMNO ON TB_ALUMNO.ApoRut = TB_APODERADO.ApoRut inner join TB_CURSO ON TB_ALUMNO.CurCodigo = TB_CURSO.CurCodigo";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();

                    DataSet ds = new DataSet();
                    da.Fill(ds, "Alumno");
                    //   dgwTabla.DataSource = ds.Tables["Alumno"];
                    dgvAlumnos.Rows.Clear();//LIMPIA GRILLA, PARA QUE NO ACOPLE REGISTROS
                    foreach (DataRow row in ds.Tables["Alumno"].Rows)
                    {
                        DataGridViewButtonCell btnEdit = new DataGridViewButtonCell();
                        DataGridViewButtonCell btnCancel = new DataGridViewButtonCell();


                        btnEdit.Value = " ";
                        btnEdit.UseColumnTextForButtonValue = true;
                      int fila =   dgvAlumnos.Rows.Add(
                                        row[0],
                                        row[1],
                                        row[2],
                                        row[3],
                                        btnEdit,
                                        btnCancel
                                        );
                        dgvAlumnos.Rows[fila].Cells[5].Value = " ";
                        dgvAlumnos.Rows[fila].Cells[4].Value = " ";


                    }
                }
                catch (SqlException es)
                {
                    MessageBox.Show(
          "Error al conectarse a la base de Datos : Al listar Alumno en Grilla" + es,
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







        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRut.Equals("") || txtNombre.Equals("") || txtApellidoM.Equals("") || txtApellidoP.Equals(""))
            {
                MessageBox.Show(
                                "Faltan registros por ingresar en su formulario",
                                ".: Sistema Anotaciones :.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
            }
            else
            {

                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    try
                    {
                        SqlCommand cmd;

                        if (btnGuardar.Text == "Guardar")
                        {
                            cmd = new SqlCommand("INSERT INTO TB_ALUMNO (AluRut, AluNombre, AluApellidoPaterno, AluApellidoMaterno, ApoRut, CurCodigo)  VALUES ( @rut, @nombre, @paterno, @materno, @apoderado, @curso)", conn);

                        }
                        else
                        {
                            cmd = new SqlCommand("UPDATE TB_ALUMNO SET AluNombre=@nombre, AluApellidoPaterno=@paterno, AluApellidoMaterno=@materno, ApoRut=@apoderado, CurCodigo=@curso WHERE  AluRut=@rut", conn);

                        }
                        cmd.Parameters.AddWithValue("@rut", txtRut.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@paterno", txtApellidoP.Text);
                        cmd.Parameters.AddWithValue("@materno", txtApellidoM.Text);
                        cmd.Parameters.AddWithValue("@apoderado", cbxApoderados.SelectedValue);
                        cmd.Parameters.AddWithValue("@curso", cbxCurso.SelectedValue);
                        cmd.ExecuteNonQuery();
                        limpiarFormulario();

                    }
                    catch (SqlException eSql)
                    {
                        MessageBox.Show(
                         "Error al conectarse a la base de Datos : Al guardar Alumno " + eSql,
                         ".: Sistema Ventas :.",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                         "Error al conectarse a la base de Datos : Al guardar Alumno " + ex,
                         ".: Sistema Ventas :.",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                    }
                    finally
                    {
                        conn.Close();
                        cargarAlumnos();
                    }
                }

            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) {

                int rut = Convert.ToInt32( dgvAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString());

                #region esto es un ejemplo de dialogo
      /*          DialogResult respuesta =     MessageBox.Show(rut.ToString(), "Arriba del mensaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (respuesta == DialogResult.Yes)
                {
                    MessageBox.Show("click en si");

                }
                else if (respuesta == DialogResult.No)
                {

                    MessageBox.Show("click en no");
                }
                else {

                    MessageBox.Show("En hora buena,el control no es un si no");
                }*/
                #endregion

                if (dgvAlumnos.CurrentCell.ColumnIndex == 4)
                {

                    editar(rut);

                }
                else if(dgvAlumnos.CurrentCell.ColumnIndex == 5) {

                    eliminar(rut);
                }
            }
        }

        private void eliminar(int rut) {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();
                try
                {
                    DialogResult resultadoDialogo = MessageBox.Show("Esta seguro que quiere eliminar al alumno Rut : " + rut, ".: Sistema Matricula :.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultadoDialogo == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM TB_ALUMNO WHERE AluRut=@rut", conn);
                        cmd.Parameters.AddWithValue("@rut", rut);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Alumno eliminado exitosamente", ".. Sistema Matricula:.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Usuario cancelo acción de eliminación", ".. Sistema Matricula:.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                }
                catch (SqlException eSql)
                {
                    MessageBox.Show(
                     "Error al conectarse a la base de Datos : Al guardar Alumno " + eSql,
                     ".: Sistema Ventas :.",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                     "Error al conectarse a la base de Datos : Al guardar Alumno " + ex,
                     ".: Sistema Ventas :.",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                }
                finally
                {
                    conn.Close();
                    cargarAlumnos();
                }
            }
        }
    private void editar(int rut)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                try
                {
                    string query = "select * FROM TB_ALUMNO WHERE AluRut ='" + rut + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AlumnoDatos");
                    foreach (DataRow fila in ds.Tables["AlumnoDatos"].Rows)
                    {
                        txtRut.Text = fila[0].ToString();
                        txtNombre.Text = fila[1].ToString();
                        txtApellidoP.Text = fila[2].ToString();
                        txtApellidoM.Text = fila[3].ToString();
                        cbxCurso.SelectedValue = fila[4].ToString();
                        cbxApoderados.SelectedValue = fila[5].ToString();
                        btnGuardar.Text = "Editar";
                        btnGuardar.Image = Properties.Resources.pencil_16; 
                        txtRut.Enabled = false;
                    }

                }
                catch (SqlException x)
                {
                    MessageBox.Show(
                                   "Error al conectarse a la base de Datos : Al listar datos de alumno" + x.Message,
                                   ".: Sistema Alumno :.",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error
                                   );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                                   "Error al conectarse a la base de Datos : Al listar datos de alumno" + ex.Message,
                                   ".: Sistema Alumno :.",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error
                                   );
                }
            }
        }

        private void dgvAlumnos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
             
            if (e.ColumnIndex == 4)
            {
            
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.pencil_16.Width;
                var h = Properties.Resources.pencil_16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pencil_16, new Rectangle(x, y, w, h));
                 
                e.Handled = true;
            }else if (e.ColumnIndex == 5)
                {

                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = Properties.Resources.trash_16.Width;
                    var h = Properties.Resources.trash_16.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
 
                    e.Graphics.DrawImage(Properties.Resources.trash_16, new Rectangle(x, y, w, h));

                    e.Handled = true;
                }
        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void siguiente(object sender, KeyEventArgs e) {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Tab))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtRut_KeyUp(object sender, KeyEventArgs e)
        {
            siguiente(sender, e);

        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            siguiente(sender, e);
        }

        private void txtApellidoP_KeyUp(object sender, KeyEventArgs e)
        {
            siguiente(sender, e);

        }

        private void txtApellidoM_KeyUp(object sender, KeyEventArgs e)
        {
            siguiente(sender, e);

        }

        private void cbxCurso_KeyUp(object sender, KeyEventArgs e)
        {
            siguiente(sender, e);

        }

        private void cbxApoderados_KeyUp(object sender, KeyEventArgs e)
        {
            siguiente(sender, e);

        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                TextBox caja = (TextBox)sender;
                errorMensaje.SetError(caja, ".: Solo Letras:.");
                
                e.Handled = true;
                return;
            }
        }
    }
    }
    


