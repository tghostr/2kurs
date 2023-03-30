using kursproga;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kurs0
{
    class EditMaterial
    {
        public static void AddMaterial(Material mtr)
        {
            int Mcost = Convert.ToInt32(mtr.Price) * Convert.ToInt32(mtr.Number);
            DB db = new DB();
            MySqlCommand commandMA = new MySqlCommand("INSERT INTO `material`(`maname`, `maunit`, `maprice`, `manumber`, `macost`) VALUES(@Mname, @Munit, @Mprice, @Mnumber, @Mcost);", db.getConnection());
            commandMA.Parameters.Add("@Mname", MySqlDbType.VarChar).Value = mtr.Name;
            commandMA.Parameters.Add("@Munit", MySqlDbType.VarChar).Value = mtr.Unit;
            commandMA.Parameters.Add("@Mprice", MySqlDbType.VarChar).Value = mtr.Price;
            commandMA.Parameters.Add("@Mnumber", MySqlDbType.VarChar).Value = mtr.Number;
            commandMA.Parameters.Add("@Mcost", MySqlDbType.VarChar).Value = Mcost;
            db.openConnection();
            try
            {
                commandMA.ExecuteNonQuery();
                MessageBox.Show("Материал добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Материал не добавлен \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }

        public static void UpdateMaterial(Material mtr, string id)
        {
            int Mcost = Convert.ToInt32(mtr.Price) * Convert.ToInt32(mtr.Number);
            DB db = new DB();
            MySqlCommand commandMU = new MySqlCommand("UPDATE `material` SET `maname` = @Mname, `maunit` = @Munit, `maprice` = @Mprice, `manumber` = @Mnumber, `macost` = @Mcost WHERE `idmaterial` = @Mid;", db.getConnection());
            commandMU.Parameters.Add("@Mid", MySqlDbType.VarChar).Value = id;
            commandMU.Parameters.Add("@Mname", MySqlDbType.VarChar).Value = mtr.Name;
            commandMU.Parameters.Add("@Munit", MySqlDbType.VarChar).Value = mtr.Unit;
            commandMU.Parameters.Add("@Mprice", MySqlDbType.VarChar).Value = mtr.Price;
            commandMU.Parameters.Add("@Mnumber", MySqlDbType.VarChar).Value = mtr.Number;
            commandMU.Parameters.Add("@Mcost", MySqlDbType.VarChar).Value = Mcost;
            db.openConnection();
            try
            {
                commandMU.ExecuteNonQuery();
                MessageBox.Show("Материал обновлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Материал не обновлен \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }

        public static void DeleteMaterial(string id)
        {
            DB db = new DB();
            MySqlCommand commandMD = new MySqlCommand("DELETE FROM `material` WHERE `idmaterial` = @Mid", db.getConnection());
            commandMD.Parameters.Add("@Mid", MySqlDbType.VarChar).Value = id;
            db.openConnection();
            try
            {
                commandMD.ExecuteNonQuery();
                MessageBox.Show("Материал удален", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Материал не удален \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }
        
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            DB db = new DB();
            string sql = query;
            MySqlConnection con = db.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            db.closeConnection();
        }
    }
}
