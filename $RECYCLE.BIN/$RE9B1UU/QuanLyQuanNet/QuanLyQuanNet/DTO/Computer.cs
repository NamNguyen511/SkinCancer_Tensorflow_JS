using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.DTO
{
    public class Computer
    {
        public Computer(int id, string name,int id_type ,string status, int idPlayer)
        {
            this.ID = id;
            this.Name = name;
            this.ID_type = id_type;
            this.Status = status;
            this.IdPlayer = idPlayer;
        }

        public Computer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.ID_type = (int)row["id_type"];
            this.Status = row["status"].ToString();
            var idPLayer = row["id_Player"];
            if (idPLayer.ToString() != "")
                this.IdPlayer = (int)idPLayer;
        }
        private int idPlayer;

        private string status;

        private int iD_type;

        private string name;

        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int ID_type { get => iD_type; set => iD_type = value; }
        public int IdPlayer { get => idPlayer; set => idPlayer = value; }
    }
}
