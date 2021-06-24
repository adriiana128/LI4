using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;



namespace photravel
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public object MessageBox { get; private set; }



        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "li4.mysql.database.azure.com";
            database = "photravel";
            uid = "li4@li4";
            password = "Asdfghj1";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        System.Diagnostics.Debug.WriteLine("Sem ligação ao server");
                        break;

                    case 1045:
                        System.Diagnostics.Debug.WriteLine("User/pass invalidos");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Insert User statement
        public void InsertUser(string username, string password, int isAdmin, string name, int score, string bio, string email, string telemovel)
        {
            string query = "INSERT INTO UTILIZADOR (username, password, isAdmin, nome, scoreTotal, biografia, email, telemovel) VALUES ('"
                + username + "', '"
                + password + "', "
                + isAdmin + ", '"
                + name + "', "
                + score + ", '"
                + bio + "', '"
                + email + "', '"
                + telemovel + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Insert Foto statement TODO MUDAR DATETIME PARA O FORMATO QUE FOR ACEITE PELO SQL
        public void InsertFoto(int id , int score, string username, int localId, string datetime, string descricao)
        {
            string query = "INSERT INTO FOTO (id, score, Utilizador_username, Local_id, data, descricao) VALUES ("
                + id + ", "
                + score + ", '"
                + username + "', "
                + localId + ", '"
                + datetime + "', '"
                + descricao + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Insert Comentario statement
        public void InsertComentario(int id , string texto, int score, int fotoId)
        {
            string query = "INSERT INTO COMENTARIO (id, texto, score, Foto_id) VALUES ("
                + id + ", '"
                + texto + "', "
                + score + ", "
                + fotoId + ")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Insert Local statement
        public void InsertLocal(int id , string nome)
        {
            string query = "INSERT INTO Local (id, nome) VALUES ("
                + id + ", '"
                + nome + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update Utilizador statement
        public void UpdateUser(string username, string password, int isAdmin, string name, int score, string bio, string email, string telemovel)
        {
            string query = "UPDATE UTILIZADOR SET "
                + "password='" + password + "', "
                + "isAdmin=" + isAdmin + ", "
                + "nome='" + name + "', "
                + "scoreTotal=" + score + ", "
                + "biografia='" + bio + "', "
                + "email='" + email + "', "
                + "telemovel='" + telemovel + "' "
                + "WHERE username='" + username + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update Foto statement
        public void UpdateFoto(int id, int score, string username, int localId, string datetime, string descricao)
        {
            string query = "UPDATE FOTO SET "
                + "score=" + score + ", "
                + "username='" + username + "', "
                + "Local_id=" + localId + ", "
                + "data='" + datetime + "', "
                + "descricao='" + descricao + "' "
                + "WHERE id=" + id + "";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete User statement
        public void DeleteUser(string username)
        {
            string query = "DELETE FROM UTILIZADOR WHERE username='" + username +"'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Delete Foto statement
        public void DeleteFoto(int id)
        {
            string query = "DELETE FROM FOTO WHERE id=" + id;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Delete Comentario statement
        public void DeleteComentario(int id)
        {
            string query = "DELETE FROM COMENTARIO WHERE id=" + id;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Delete Local statement
        public void DeleteLocal(int id)
        {
            string query = "DELETE FROM LOCAL WHERE id=" + id;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select_User(string email)
        {
            string query = "SELECT * FROM UTILIZADOR WHERE email = '"+ email +"'";

            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["username"] + "");
                    list[1].Add(dataReader["password"] + "");
                    list[2].Add(dataReader["isAdmin"] + "");
                    list[3].Add(dataReader["nome"] + "");
                    list[4].Add(dataReader["scoreTotal"] + "");
                    list[5].Add(dataReader["biografia"] + "");
                    list[6].Add(dataReader["email"] + "");
                    list[7].Add(dataReader["telemovel"] + "");
                }
                //username, password, isAdmin, nome, scoreTotal, biografia, email, telemovel

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] Select_Local(int id)
        {
            string query = "SELECT * FROM LOCAL WHERE id="+id;

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["nome"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] Select_Foto(int id)
        {
            string query = "SELECT * FROM Foto WHERE id="+id;

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            //id, score, Utilizador_username, Local_id, data, descricao

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["score"] + "");
                    list[2].Add(dataReader["Utilizador_username"] + "");
                    list[3].Add(dataReader["Local_id"] + "");
                    list[4].Add(dataReader["data"] + "");
                    list[5].Add(dataReader["descricao"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] Select_Comentario(int id)
        {
            string query = "SELECT * FROM Comentario WHERE id="+id;

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            //id, texto, score, Foto_id

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["texto"] + "");
                    list[2].Add(dataReader["score"] + "");
                    list[3].Add(dataReader["Foto_id"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] Select_Comentario_Foto(int id)
        {
            string query = "SELECT * FROM COMENTARIO WHERE Foto_id=" + id;

            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            //id, texto, score, Foto_id

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["texto"] + "");
                    list[2].Add(dataReader["score"] + "");
                    list[3].Add(dataReader["Foto_id"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count(string query)
        {
            //string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        /*Isto provavelmente vai estar noutro ficheiro que utiliza as funcoes definidas aqui
        public void Comentar(string texto, string Foto_id)
        {
            string contaid = "SELECT Count(*) FROM Comentario";
            int nextid = Count(contaid);
            string query = "INSERT INTO Comentario (id, texto, score, Foto_id) VALUES('"+nextid+"', '"+texto+ "', '0', '" + Foto_id + "')";
            Insert(query);
        }
        */
    }

}
