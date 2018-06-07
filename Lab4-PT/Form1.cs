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

        static List<string> professions = new List<string> { "Rycerz", "Mag", "Druid", "Złodziej", "Małpa z gwoździem" };

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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Hero> tempList = listOfHeroes.ToList<Hero>();

            tempList.Sort(new HeroComparer());

            this.listOfHeroes = new BindingList<Hero>(tempList);

            this.heroGrid.DataSource = this.listOfHeroes;
        }

        private class HeroComparer : IComparer<Hero>
        {

            public int Compare(Hero x, Hero y)
            {
                if (x.Profession.Equals(y.Profession))
                {
                    if (x.Intelligence == y.Intelligence)
                    {
                        if (x.Strength == y.Intelligence)
                        {
                            return 0;
                        }
                        else if (x.Strength > y.Intelligence)
                        {
                            return 1;
                        }
                        else return -1;
                    }
                    else if (x.Intelligence > y.Intelligence)
                    {
                        return 1;
                    }
                    else return -1;
                }
                else if (Form1.professions.IndexOf(x.Profession)<Form1.professions.IndexOf(y.Profession))
                {
                    return 1;
                }
                else return -1;
                
            }
        }
    }
}
