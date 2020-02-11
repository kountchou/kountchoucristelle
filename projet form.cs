using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace mediatheque
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        public static string chaineconnection = "Database=mediatheque ; Data Source=localhost  ; User Id=root ; Password='';";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaineconnection);
            con.Open();
            string requete = "INSERT INTO video(idvideo,nomv,format,taille) values (" + idv.Text + ",'" + nv.Text + "'," + fvideo.Text + "," + tv.Text + ");";
            MessageBox.Show(requete);
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = requete;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(chaineconnection);
            con.Open();
            string requete = "INSERT INTO audio (idaudio,nomau,formatau,tailleau) values (" + ida.Text + ",'" + nau.Text + "'," + fau.Text + "," + tau.Text + ");";
            MessageBox.Show(requete);
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = requete;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        MySqlConnection con = new MySqlConnection(chaineconnection);
            con.Open();
            string requete = "INSERT INTO texte values (" + idt.Text + ",'" + nt.Text + "'," + ft.Text + "," + tt.Text + ");";
            MessageBox.Show(requete);
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = requete;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chemin.Text = OpenFileDialog.FileName;
            OpenFileDialog.ShowDialog();
        }
        }
    }

