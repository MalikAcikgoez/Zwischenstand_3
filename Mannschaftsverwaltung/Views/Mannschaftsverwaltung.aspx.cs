using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mannschaftsverwaltung.Views
{
    public partial class Mannschaftsverwaltung : System.Web.UI.Page
    {
        #region Eigenschaften
        private Controller _verwalter;

        #endregion

        #region Accessoren/Modifier
        public Controller Verwalter { get => _verwalter; set => _verwalter = value; }

        #endregion

        #region Konstruktoren
        public Mannschaftsverwaltung()
        {
            Verwalter = Global.Verwalter;
        }
        #endregion

        #region Worker
        protected void Page_Load(object sender, EventArgs e)
        {
            Verwalter.LoadMannschaft();
            Verwalter.LoadDateFromPerson();
           string name= Verwalter.Liste[0].Mannschaftsname;
            string na = Verwalter.Liste[0].ListePerson[0].Name;
            LoadPerson();
        }

        public void LoadPerson()
        {
           
            for(int index=0;index<Verwalter.Person.Count;index++)
            {
                DatenladenSQL.Items.Add(" "+Verwalter.Person[index].Id+", " + Verwalter.Person[index].Name +", " + Verwalter.Person[index].Geburtsdatum + ", " + Verwalter.Person[index].Einsatzbereich);
            }
        }
        #endregion

        protected void speicherbtn_Click(object sender, EventArgs e)
        {
            for(int index=0;index<DropDownList2.Items.Count;index++)
            {
                if(DropDownList2.Items[index].Selected)
                {
                    List<Person> person = new List<Person>();
                    for (int index1 = 0; index1 < DatenladenSQL.Items.Count; index1++)
                    {
                        if (DatenladenSQL.Items[index1].Selected)
                        {
                            Person p1 = new Person();
                            p1.Id = Verwalter.Person[index1].Id;
                            p1.Name = Verwalter.Person[index1].Name;
                            p1.Einsatzbereich = Verwalter.Person[index1].Einsatzbereich;
                            person.Add(p1);
                        }
                    }
                    Verwalter.NewMannschaft(Nametxt.Text,DropDownList2.Items[index].Text,person);
                }
            }
        }
    }
}