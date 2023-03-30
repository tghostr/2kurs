using kursproga;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kurs0
{
    class EditEquipment
    {
        public static void AddEquipment(Equipment eqm)
        {
            int Ecost = Convert.ToInt32(eqm.Price) * Convert.ToInt32(eqm.Number);
            DB db = new DB();
            MySqlCommand commandEA = new MySqlCommand("INSERT INTO `equipment`(`emname`, `emunit`, `emprice`, `emnumber`, `emcost`) VALUES(@Ename, @Eunit, @Eprice, @Enumber, @Ecost);", db.getConnection());
            commandEA.Parameters.Add("@Ename", MySqlDbType.VarChar).Value = eqm.Name;
            commandEA.Parameters.Add("@Eunit", MySqlDbType.VarChar).Value = eqm.Unit;
            commandEA.Parameters.Add("@Eprice", MySqlDbType.VarChar).Value = eqm.Price;
            commandEA.Parameters.Add("@Enumber", MySqlDbType.VarChar).Value = eqm.Number;
            commandEA.Parameters.Add("@Ecost", MySqlDbType.VarChar).Value = Ecost;
            db.openConnection();
            try
            {
                commandEA.ExecuteNonQuery();
                MessageBox.Show("Оборудование добавлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Оборудование не добавлено \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }

        public static void UpdateEquipment(Equipment eqm, string id)
        {
            int Ecost = Convert.ToInt32(eqm.Price) * Convert.ToInt32(eqm.Number);
            DB db = new DB();
            MySqlCommand commandEA = new MySqlCommand("UPDATE `equipment` SET `emname` = @Ename, `emunit` = @Eunit, `emprice` = @Eprice, `emnumber` = @Enumber, `emcost` = @Ecost WHERE `idequipment` = @Eid;", db.getConnection());
            commandEA.Parameters.Add("@Eid", MySqlDbType.VarChar).Value = id;
            commandEA.Parameters.Add("@Ename", MySqlDbType.VarChar).Value = eqm.Name;
            commandEA.Parameters.Add("@Eunit", MySqlDbType.VarChar).Value = eqm.Unit;
            commandEA.Parameters.Add("@Eprice", MySqlDbType.VarChar).Value = eqm.Price;
            commandEA.Parameters.Add("@Enumber", MySqlDbType.VarChar).Value = eqm.Number;
            commandEA.Parameters.Add("@Ecost", MySqlDbType.VarChar).Value = Ecost;
            db.openConnection();
            try
            {
                commandEA.ExecuteNonQuery();
                MessageBox.Show("Оборудование обновлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Оборудование не обновлено \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }

        public static void DeleteEquipment(string id)
        {
            DB db = new DB();
            MySqlCommand commandEA = new MySqlCommand("DELETE FROM `equipment` WHERE `idequipment` = @Eid", db.getConnection());
            commandEA.Parameters.Add("@Eid", MySqlDbType.VarChar).Value = id;
            db.openConnection();
            try
            {
                commandEA.ExecuteNonQuery();
                MessageBox.Show("Оборудование удалено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Оборудование не удалено \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
