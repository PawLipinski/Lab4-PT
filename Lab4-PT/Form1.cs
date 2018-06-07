using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_PT
{
    public partial class Form1 : Form
    {

        List<string> professions = new List<string> { "Rycerz", "Mag", "Druid", "Złodziej", "Małpa z gwoździem" };

        BindingList<Hero> listOfHeroes = new BindingList<Hero>();

        public Form1()
        {
            InitializeComponent();

            this.professionBox.DataSource = professions;
            this.professionBox.DropDownStyle = ComboBoxStyle.DropDownList;

            heroGrid.DataSource = listOfHeroes;
            heroGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hero myHero = new Hero(this.nameBox.Text, this.professionBox.Text, (int)this.strengthBox.Value, (int)this.intelligenceBox.Value);

            listOfHeroes.Add(myHero);
        }
    }
}
