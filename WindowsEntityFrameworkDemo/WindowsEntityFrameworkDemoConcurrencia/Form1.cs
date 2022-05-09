using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; 
using WindowsEntityFrameworkDemoConcurrencia.Models;
using WindowsEntityFrameworkDemoConcurrencia.Data;
using System.Data.Entity.Infrastructure;
namespace WindowsEntityFrameworkDemoConcurrencia
{
    public partial class Form1 : Form
    {
        Game game1;
        Game game2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new GameDbContext())
            {
                game1 = new Game() { GameId = 1, Name = "Mario B" };
                game2 = new Game() { GameId = 2, Name = "Minecraft" };

                context.Games.Add(game1);
                context.Games.Add(game2);

                context.SaveChanges();
            }

            // user 1
            using (var context = new GameDbContext())
            {
                game1 = context.Games.Where(g => g.GameId == 1).Single();
            }

            // user 2
            using (var context = new GameDbContext())
            {
                game2 = context.Games.Where(g => g.GameId == 1).Single();
            }

            // modificacion del nombre del juego
            game1.Name = "Mario Bros Super";
            game2.Name = "Minecraft Super";

            
            // simulando que el user 1 se conecta desde un browser
            // lo marca en memoria como modificado
            using (var context = new GameDbContext())
            {
                try
                {
                    context.Entry(game1).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Game 1 OK");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    MessageBox.Show("Concurrencia optimista Game 1" + ex.Message);
                }
            }

            //user 2
            using (var context = new GameDbContext())
            {
                try
                {
                    context.Entry(game2).State = EntityState.Modified();
                    context.SaveChanges();
                    MessageBox.Show("Game 2 OK");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    MessageBox.Show("Concurrencia optimista Game 2" + ex.Message);
                    context.SaveChanges();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
