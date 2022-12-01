using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region connexion 
        static string Chaine = @"Data Source=DESKTOP-H5O83VN\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
        static SqlConnection cnx = new SqlConnection(Chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        #endregion

        #region flags
       
        private bool modWasClicked = false;
        private bool ajoutWasClicked = false;
        #endregion

        #region unused methods
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void nom_input_TextChanged(object sender, EventArgs e)
        {

        }
       
        #endregion

        private void ajout_btn_Click(object sender, EventArgs e)
        {
            

            id_input.Clear(); 
            nom_input.Clear();
            affichage();

            #region insertion 
            anu_btn.Enabled = true;
            enr_btn.Enabled = true;
            mod_btn.Enabled = false;
            ajout_btn.Enabled = false;
            sup_btn.Enabled = false;
            comboBox1.Enabled = false;
            id_input.Enabled = true;
            nom_input.Enabled = true;
            #endregion

             ajoutWasClicked = true;

        }


        private void sup_btn_Click(object sender, EventArgs e)
        {

            string box_msg = "confirmer la suppression";

            string box_title = "confiramtion";

            

            if (MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo)==DialogResult.Yes)

            {

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from name_id where id='" + id_input.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                id_input.Clear();
                nom_input.Clear();

                #region initialisation 
                anu_btn.Enabled = false;
                enr_btn.Enabled = false;
                mod_btn.Enabled = false;
                ajout_btn.Enabled = true;
                sup_btn.Enabled = false;
                comboBox1.Enabled = true;
                id_input.Enabled = false;
                nom_input.Enabled = false;
                #endregion
            }
            else
            {
                #region selection
               
                anu_btn.Enabled = false;
                enr_btn.Enabled = false;
                mod_btn.Enabled = true;
                ajout_btn.Enabled = true;
                sup_btn.Enabled = true;
                comboBox1.Enabled = true;
                id_input.Enabled = false;
                nom_input.Enabled = false;
                #endregion
            }



            affichage();
          


        }

        private void mod_btn_Click(object sender, EventArgs e)
        {
           
            #region modification 
            
            anu_btn.Enabled = true;
            enr_btn.Enabled = true;
            mod_btn.Enabled = false;
            ajout_btn.Enabled = false;
            sup_btn.Enabled = false;
            comboBox1.Enabled = true;
            id_input.Enabled = true;
            nom_input.Enabled = true;
            #endregion
            affichage();
            modWasClicked = true;

        }


        private void enr_btn_Click(object sender, EventArgs e)
        {

            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection = cnx;
            cnx.Open();

          
            if (ajoutWasClicked)
            {
                cmd.CommandText = "INSERT INTO name_id (id ,name ) " +
            "values('" + id_input.Text + "','" + nom_input.Text + "')";
                cmd.ExecuteNonQuery();
                ajoutWasClicked = false;
            }

            if (modWasClicked)
            {
                cmd.CommandText = "update name_id set name ='" + nom_input.Text + "' where id='" + id_input.Text + "' ";
                cmd.ExecuteNonQuery();
                modWasClicked = false;

            }

            cnx.Close();
            #region selection
            //Selection
            anu_btn.Enabled = false;
            enr_btn.Enabled = false;
            mod_btn.Enabled = true;
            ajout_btn.Enabled = true;
            sup_btn.Enabled = true;
            comboBox1.Enabled = true;
            id_input.Enabled = false;
            nom_input.Enabled = false;
            #endregion
            affichage();
        }

        private void anu_btn_Click(object sender, EventArgs e)
        {

            if (modWasClicked) {

                #region selection
             
                anu_btn.Enabled = false;
                enr_btn.Enabled = false;
                mod_btn.Enabled = true;
                ajout_btn.Enabled = true;
                sup_btn.Enabled = true;
                comboBox1.Enabled = true;
                id_input.Enabled = false;
                nom_input.Enabled = false;
                #endregion
            
           }
            else
            {

                #region initialisation 

                anu_btn.Enabled = false;
                enr_btn.Enabled = false;
                mod_btn.Enabled = false;
                ajout_btn.Enabled = true;
                sup_btn.Enabled = false;
                comboBox1.Enabled = true;
                id_input.Enabled = false;
                id_input.Clear();
                nom_input.Enabled = false;
                nom_input.Clear();
                #endregion
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {


            #region initialisation 
            anu_btn.Enabled = false;
            enr_btn.Enabled=false;
            mod_btn.Enabled = false;
            ajout_btn.Enabled = true;
            sup_btn.Enabled = false;
            comboBox1.Enabled = true;
            id_input.Enabled = false;
            nom_input.Enabled = false;
            #endregion
            affichage();
        }


        #region functions 
        public void affichage()
        {
            comboBox1.Items.Clear();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from dbo.name_id";
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cnx.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
         
            foreach (DataRow dr in dt.Rows)
            {
              
                comboBox1.Items.Add("Name : " + dr["name"]);
                comboBox1.Items.Add("Id   : " + dr["id"].ToString());
                comboBox1.Items.Add("----------------------------------------------------------------------------------------------------");

            }
          

            #endregion
        }

        private void green(object sender, EventArgs e)
        {

        }
    }
}
