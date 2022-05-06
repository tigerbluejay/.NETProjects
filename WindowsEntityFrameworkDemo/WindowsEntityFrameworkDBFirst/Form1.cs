using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEntityFrameworkDBFirst.Data;

namespace WindowsEntityFrameworkDBFirst
{
    public partial class Form1 : Form
    {
        // Crear una instancia de Entity Framework
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarStore_Click(object sender, EventArgs e)
        {
            // Crear un store y setear las propiedades
            Store store = new Store()
            {
                stor_id = "8888",
                stor_name = "A",
                stor_address = "Alem 11",
                city = "Quilmes",
                state = "BS",
                zip = "12345"
            };

            // Agregar la instancia a la colleccion de stores en memoria
            context.Stores.Add(store);

            // Enviamos la modificacion a la base de datos
            // Se conecta a la base, ejecuta operacion DML y
            // retorna filas afectadas y se desconecta.
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert OK");
                MostrarTiendas();
            }


        }

        private void btnEliminarStore_Click(object sender, EventArgs e)
        {
            // Buscar el store que deseamos eliminar
            Store storetoDelete = new Store()
            {
                stor_id = "8888",
                stor_name = "A",
                stor_address = "Alem 11",
                city = "Quilmes",
                state = "BS",
                zip = "12345"
            };

            // Entity State
            context.Entry(storetoDelete).State = EntityState.Deleted;

            context.Stores.Remove(storetoDelete);
            
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete OK");
                MostrarTiendas();
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            // Buscar el Store id 8888
            string storeId = "8888";
            Store store = context.Stores.Find(storeId);
            context.Stores.Remove(store);
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete OK");
                MostrarTiendas();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string storeid = "6380";
            Store store = context.Stores.Find(storeid);

            store.stor_name = "Eric the Road";
            store.stor_address = "323 Oak St.";
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update OK");
                MostrarTiendas();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTiendas();
        }

        private void MostrarTiendas()
        {
            // conecta a la db, hace un select
            // retorna una lista de stores y se desconecta
            // a esto se le llama materializar datos, proyectar datos
            List<Store> stores = context.Stores.ToList();

            gridStore.DataSource = stores;
        }
    }
}
