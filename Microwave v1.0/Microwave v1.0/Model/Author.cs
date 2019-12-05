﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Forms;
using System.Data;

namespace Microwave_v1._0.Classes
{
    public class Author
    {
        public static int author_point_y = 5; // Author infoları ekrana çizdirirken kullanılan offset.
        public static int author_point_x = 35;

        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int author_id;
        private int popularity_id;
        private int popularity_score;
        private string author_name;
        private string author_country;
        private string author_gender;
        private string author_birthday;
        private string author_biography;
        private string author_cover_path_file;
        private string author_popularity_name;
        private Author_Info author_info;
        
        
        public Author(int author_id, int popularity_id, string author_name, string author_country, string author_gender, string author_birthday, string author_biography, string author_cover_path_file)
        {

            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.author_id = author_id;
            this.popularity_id = popularity_id;
            this.author_name = author_name;
            this.author_country = author_country;
            this.author_gender = author_gender;
            this.author_birthday = author_birthday;
            this.author_biography = author_biography;
            this.author_cover_path_file = author_cover_path_file;
        }

        public Author()
        {

        }

        public int Author_id { get => author_id; set => author_id = value; }
        public string Author_name { get => author_name; set => author_name = value; }
        public string Author_country { get => author_country; set => author_country = value; }
        public string Author_gender { get => author_gender; set => author_gender = value; }
        public string Author_birthday { get => author_birthday; set => author_birthday = value; }
        public string Author_biography { get => author_biography; set => author_biography = value; }
        public string Author_cover_path_file { get => author_cover_path_file; set => author_cover_path_file = value; }
        public Author_Info Author_info { get => author_info; set => author_info = value; }
        public int Popularity_score { get => popularity_score; set => popularity_score = value; }
        public int Popularity_id { get => popularity_id; set => popularity_id = value; }
        public string Author_popularity_name { get => author_popularity_name; set => author_popularity_name = value; }

        public void Add()
        {
            string title;
            string values;

            title = "INSERT INTO Authors ( POPULARITY_ID, NAME, COUNTRY, GENDER, BIRTHDAY, BIOGRAPHY, PICTURE_PATH, POPULARITY_SCORE) ";
            values = string.Format("VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                         popularity_id, author_name, author_country, author_gender, author_birthday, author_biography,
                         author_cover_path_file, popularity_score);
            

            string query = title + values;
            DataBaseEvents.ExecuteNonQuery(query, datasource);
            author_info = new Author_Info();
            Take_ID_From_Database();
            author_info.Initialize_Author_Info(author_id,author_name, author_cover_path_file);
            Join_Tables();
            //Cover_Pic_to_Image_List();
            main_page.Main_author_list.Add_Author_to_List(this);
            main_page.Pnl_author_list.VerticalScroll.Value = 0;
            author_info.Draw_Author_Obj(ref Author.author_point_x, ref Author.author_point_y);
            
            author_info.Select_Author_Info();
        }

        public void Edit()
        {
            string title = "UPDATE Authors ";
            string query = title + string.Format("SET POPULARITY_ID = '{0}', NAME = '{1}', COUNTRY = '{2}', GENDER = '{3}', BIRTHDAY = '{4}', " +
                " BIOGRAPHY = '{5}', PICTURE_PATH = '{6}' Where Authors.AUTHOR_ID = '{7}'", popularity_id, author_name, author_country, author_gender, author_birthday, author_biography, author_cover_path_file, author_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if (result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }


            author_info.Initialize_Author_Info(author_id, author_name, author_cover_path_file);
            author_info.Select_Author_Info();

        }

        public void Delete()
        {
            string title = "DELETE FROM Authors ";
            string query = title + string.Format("Where AUTHOR_ID = '{0}' ;", author_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if (result <= 0)
            {
                MessageBox.Show("Delete is not valid");
                return;
            }
        }

        static public void Show_All_Authors(Microwave main_page)
        {
            string query = "SELECT * FROM Authors";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);


            main_page.Main_author_list.Fill_Author_List(dt);
            main_page.Main_author_list.Draw_All_Authors();

        }

        public void Set_Author()
        {
            author_info = new Author_Info();
            author_info.Initialize_Author_Info(author_id, author_name, author_cover_path_file);

        }

        //Search Methods 

        static public DataTable Search_Author_By_Name(string name)
        {
            string query = string.Format("Select * From Authors Where Authors.NAME Like '{0}%'", name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        static public DataTable Search_Author_By_Country(string country)
        {
            string query = string.Format("Select * From Authors Where Authors.COUNTRY Like '{0}%'", country);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        static public DataTable Search_Author_By_ID(string id)
        {
            string query = string.Format("Select * From Authors Where Authors.AUTHOR_ID Like '{0}%'", id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        static public DataTable Search_Author_By_Gender(string gender)
        {
            string query = string.Format("Select * From Authors Where Authors.GENDER Like '{0}%'", gender);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }

        private void Take_ID_From_Database()
        {
            string title = "SELECT AUTHORS.AUTHOR_ID FROM AUTHORS ";
            string query = title + string.Format(" WHERE Authors.NAME = '{0}' and Authors.COUNTRY = '{1}'", author_name, author_country);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.author_id = this.author_info.Author_id = id;
            
        }

        private void Join_Tables()
        {
            string query = "SELECT Popularity.name FROM Authors JOIN POPULARITY ON AUTHORS.POPULARITY_ID = POPULARITY.POPULARITY_ID WHERE AUTHORS.AUTHOR_ID = " + author_id;
            DataTable db = DataBaseEvents.ExecuteQuery(query, datasource);
            author_popularity_name = db.Rows[0][0].ToString();
        }

    }
}
