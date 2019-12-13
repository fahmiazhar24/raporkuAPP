using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raporkuAPP
{
    public class Data
    {
        public static String Uri = "https://raporservice.azurewebsites.net/Service1.svc/";
    }
    public class Rapot
    {
        public string nilai { get; set; }
        public string semester { get; set; }
        public string id_kelas { get; set; }
        public string id_mapel { get; set; }
        public string id_siswa { get; set; }
        public string id_rapot { get; set; }
    }
    public class Siswa
    {
        public string tempat_lahir { get; set; }

        public string tgl_lahir { get; set; }

        public string id_kelas { get; set; }

        public string nama_siswa { get; set; }

        public string id_siswa { get; set; }

        public string id_walikelas { get; set; }

        public string alamat { get; set; }

        public string nama_ibu { get; set; }

        public string nomor_ortu { get; set; }

        public string jenis_kelamin { get; set; }

        public string status_kawin { get; set; }

        public string nama_ayah { get; set; }

        public string nama_agama { get; set; }
    }

    public class WaliKelas
    {

        public string id_walikelas { get; set; }
        public string nama_walikelas { get; set; }
        public string uname_walikelas { get; set; }
        public string passw_walikelas { get; set; }
        public string id_kelas { get; set; }
    }

    public class Admin
    {
        public string id_admin { get; set; }
        public string uname_admin { get; set; }
        public string passw_admin { get; set; }
    }

    public class Kelas
    {
        public string id_kelas { get; set; }
        public string nama_kelas { get; set; }
    }

    public class Mapel
    {
        public string id_mapel { get; set; }
        public string nama_mapel { get; set; }
        public string nama_jurusan { get; set; }
    }

    public class ReportNilaiSiswa
    {
        public string nama_mapel { get; set; }
        public string nilai { get; set; }
        public string semester { get; set; }
    }
}
