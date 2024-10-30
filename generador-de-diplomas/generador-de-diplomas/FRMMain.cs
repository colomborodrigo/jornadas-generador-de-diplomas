using System;
using System.Windows.Forms;
using Dapper;

namespace generador_de_diplomas
{
    public partial class FRMMain : Form
    {
        private readonly string _connectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["sqlServerJornadas"].ConnectionString;
        
        public FRMMain()
        {
            InitializeComponent();
        }

        
    }
}