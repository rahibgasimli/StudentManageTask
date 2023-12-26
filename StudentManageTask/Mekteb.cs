using System.Security;
using System.Xml.Serialization;

namespace StudentManageTask
{
    public class Mekteb
    {
        public Mekteb()
        {
            if(File.Exists(muellimFaylYolu))
                _muellimler = MuellimleriOxu();

            _muellimler = new();

            if (File.Exists(telebeFaylYolu))
                _telebeler = TelebeleriOxu();

            _telebeler = new();

        }


        public string Mail { get; set; }
        public string Password { get; set; }

        private List<Muellim> _muellimler;

        private List<Telebe> _telebeler;

        public List<Telebe> Telebeler;
        private string muellimFaylYolu = "muellimler.xml";
        private string telebeFaylYolu = "telebeler.xml";

        public void MuellimElaveEt(Muellim muellimElave)
        {
            if (File.Exists(muellimFaylYolu))
                _muellimler = MuellimleriOxu();

            _muellimler.Add(muellimElave);
            MuellimleriYaddaSaxla();
        }


        private void MuellimleriYaddaSaxla()
        {
            var muellimFayl = File.Open(muellimFaylYolu, FileMode.Create);
            XmlSerializer xml = new(typeof(List<Muellim>));
            xml.Serialize(muellimFayl, _muellimler);
            muellimFayl.Close();
        }

        private List <Muellim> MuellimleriOxu() 
        {
            var muellimF = File.OpenRead(muellimFaylYolu);
            XmlSerializer xml = new(typeof(List<Muellim>));
            var muellimler = (List<Muellim>?)xml.Deserialize(muellimF);
            muellimF.Close();

            if (muellimler == null)
                return new List<Muellim>();

                return muellimler;
        }
        public void TelebeElaveEt(Telebe telebeElave)
        {
            if (File.Exists(telebeFaylYolu))
                _telebeler = TelebeleriOxu();

            _telebeler.Add(telebeElave);
            TelebeleriYaddaSaxla();
        }

        public void TelebeleriYaddaSaxla()
        {
            var telebeFayl = File.Open(telebeFaylYolu, FileMode.Create);
            XmlSerializer xml = new(typeof(List<Telebe>));
            xml.Serialize(telebeFayl, _telebeler);
            telebeFayl.Close();
        }

        private List<Telebe> TelebeleriOxu()
        {
            var telebeF = File.OpenRead(muellimFaylYolu);
            XmlSerializer xml = new(typeof(List<Telebe>));
            var telebeler = (List<Telebe>?)xml.Deserialize(telebeF);
            telebeF.Close();

            if (telebeler == null)
                return new List<Telebe>();

            return telebeler;

        }



    }
}
