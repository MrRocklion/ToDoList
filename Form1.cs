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
using MaterialSkin.Controls;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace ToDoList
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private String idTarea;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            traerDatos();

        }
        private void traerDatos()
        {
            try { 
            DbConecction c = new DbConecction();    
            string consulta = "SELECT * FROM Tareas";
            SqlDataAdapter miAdaptadorsql = new SqlDataAdapter(consulta, c.cnx);
            using (c.cnx)
            {
                DataTable tareasTabla = new DataTable();
                miAdaptadorsql.Fill(tareasTabla);
                listBox1.DisplayMember = "Id";
                listBox1.DataSource = tareasTabla;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ventana1: " + ex, "Ventana De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void agregarTarea()
        {
            try
            {
                DbConecction c = new DbConecction();
                string consulta = "INSERT INTO Tareas(asunto,estado)VALUES (@Asunto,@Estado)";
                SqlDataAdapter miAdaptadorsql = new SqlDataAdapter(consulta, c.cnx);
                using (SqlCommand command = new SqlCommand(consulta, c.cnx))
                {
                    command.Parameters.AddWithValue("@Asunto", tareaTxt.Text);
                    command.Parameters.AddWithValue("@Estado", "Pendiente");
                    int result = command.ExecuteNonQuery();
                }
                MessageBox.Show("Tarea Agregada con éxito!", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tareaTxt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "Ventana De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void traerAsunto(string id)
        {
            try
            {
            DbConecction c = new DbConecction();
            string consulta = $"SELECT * FROM Tareas T WHERE T.Id = {id.ToString()}";
            SqlCommand sqlcomando = new SqlCommand(consulta, c.cnx);
            SqlDataReader reader = sqlcomando.ExecuteReader();
            if (reader.Read())
            {
                asuntoTxt.Text = reader[1].ToString();
                estadoBox.Text = reader[2].ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "Ventana De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void listBox1_SelectionChange(object sender, EventArgs e)
        {
            traerAsunto(listBox1.Text);
            idTarea = listBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listaTareasDataSet.Tareas' table. You can move, or remove it, as needed.
            this.tareasTableAdapter.Fill(this.listaTareasDataSet.Tareas);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarTarea();
            traerDatos();
        }
        private void tabControl_Changed(object sender, EventArgs e)
        {
            //MessageBox.Show("ERROR: cambia ");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DbConecction c = new DbConecction();
                string consulta = $"UPDATE Tareas SET asunto = @Asunto, estado= @Estado WHERE Id ={idTarea}";
                SqlDataAdapter miAdaptadorsql = new SqlDataAdapter(consulta, c.cnx);
                using (SqlCommand command = new SqlCommand(consulta, c.cnx))
                {
                    command.Parameters.AddWithValue("@Asunto", asuntoTxt.Text);
                    command.Parameters.AddWithValue("@Estado", estadoBox.Text);
     
                    int result = command.ExecuteNonQuery();
                }

                MessageBox.Show("Tarea Actualizada con éxito!", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "Ventana De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DbConecction c = new DbConecction();
                string consulta = $"DELETE FROM Tareas WHERE Id ={idTarea}";
                SqlDataAdapter miAdaptadorsql = new SqlDataAdapter(consulta, c.cnx);
                using (SqlCommand command = new SqlCommand(consulta, c.cnx))
                {
                    int result = command.ExecuteNonQuery();
                }

                MessageBox.Show("Tarea Eliminada con éxito!", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traerDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "Ventana De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    }
