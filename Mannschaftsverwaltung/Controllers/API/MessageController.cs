using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mannschaftsverwaltung.Controllers.API
{
    public class MessageController : ApiController
    {
        private Controller _verwalter;

        public Controller Verwalter { get => _verwalter; set => _verwalter = value; }
        public MessageController():base()
        {
            Verwalter = Global.Verwalter;
        }
        // GET: api/Message
        public List<Mannschaft> Get()
        {
            List<Mannschaft> Liste = new List<Mannschaft>();
            string connectionstring = "Server=localhost;Port=3307;Database=mannschaftsverwaltung; Uid =user;Password=user";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            try
            {
                string sqlstring = "SELECT `ID`,`Mannschaftsname`,`Sportart` FROM `mannschaft` ";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlstring, conn);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader.GetValue(0).ToString();
                        string name = reader.GetValue(1).ToString();
                        string sportart = reader.GetValue(2).ToString();
                        Mannschaft m1 = new Mannschaft();
                        m1.Mannschaftsname = name;
                        m1.ID = Convert.ToInt32(id);
                        m1.Sportart = sportart;
                        

                       Liste.Add(m1);

                        

                    }
                    conn.Close();
                    for (int index=0;index<Liste.Count;index++)
                    {
                        sqlstring = "SELECT `Person_id`,`person_name`,`person_Einsatzsbereich` FROM `mannschaftsverwaltung` where `Mannschaft_id`="+Liste[index].ID;
                        conn = new MySqlConnection(connectionstring);
                        conn.Open();
                        command = new MySqlCommand(sqlstring, conn);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string id = reader.GetValue(0).ToString();
                            string name = reader.GetValue(1).ToString();
                            string Einsatzbereich = reader.GetValue(2).ToString();
                            Person p1 = new Person();
                            p1.Name = name;
                            p1.Id = Convert.ToInt32(id);
                            p1.Einsatzbereich = Einsatzbereich;


                            Liste[index].ListePerson.Add(p1);
                        }
                    }
                }
                else
                { }
            }
            catch (MySqlException)
            {
                
            }
            conn.Close();
            return Liste;

           
        }

        // GET: api/Message/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Message
        public void Post([FromBody]string value)
        {
            Mannschaft M = (Mannschaft)JsonConvert.DeserializeObject(value, typeof(Mannschaft));

            string connectionstring = "Server=localhost;Port=3307;Database=personverwaltung; Uid =user;Password=user";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            try
            {


                string sqlstring = "";
                conn.Open();

                MySqlCommand command = new MySqlCommand(sqlstring, conn);
                int anz = command.ExecuteNonQuery();
                if (anz <= 0)
                {
                }
                else
                {
                }
            }
            catch (Exception)
            {

            }
        }

        // PUT: api/Message/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Message/5
        public void Delete(int id)
        {
        }
    }
}
