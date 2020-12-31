using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceRest_027_AuliyaUswatunKhasanah
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITI_UMY
    {
        [OperationContract]
        [WebGet(UriTemplate = "Mahasiswa", ResponseFormat = WebMessageFormat.Json)] // untuk membuat salah, selalu relative
        List<Mahasiswa> GetAllMahasiswa(); //mendapatkan kumpulan mahasiswa atau seluruh data mahasiswa

        [OperationContract]         /*nama method*/
        [WebGet(UriTemplate = "Mahasiswa/nim = {nim}", ResponseFormat = WebMessageFormat.Json)] //untuk get
        Mahasiswa GetMahasiswaByNIM(string nim); // mengambil data berdasarkan nim

        //void CreateMahasiswa(Mahasiswa mhs); tidak ada pengembalian atau respond balik

        [OperationContract]         /*nama method*/
        [WebInvoke(Method = "POST", UriTemplate = "Mahasiswa", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string CreateMahasiswa(Mahasiswa mhs);
    }

    [DataContract]
    public class Mahasiswa
    {
        private string _nim, _nama, _prodi, _angkatan; // _ adalah konvensi atau kesepakatan //variabel lokal
        [DataMember(Order = 1)] //mengirim data untuk mengurutkan
        public string nim
        {
            get { return _nim; }
            set { _nim = value; }
        }

        [DataMember(Order = 2)]
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        [DataMember(Order = 3)]
        public string prodi
        {
            get { return _prodi; }
            set { _prodi = value; }
        }

        [DataMember(Order = 4)]
        public string angkatan
        {
            get { return _angkatan; }
            set { _angkatan = value; }
        }
    }

}
