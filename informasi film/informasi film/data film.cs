using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace informasi_film
{
    class datafilm
    {
        private string jenis;
        private float value;
        private string text;

        public void setgenre(string jenis)
        {
            this.jenis = jenis;
        }
        public void setrating(float value)
        {
            this.value = value;
        }
        public void setsynopsis(string text)
        {
            this.text = text;
        }
        public string getgenre()
        {
            return this.jenis;
        }
        public float getrating()
        {
            return this.value;
        }
        public string getsynopsis()
        {
            return this.text;
        }
    }
}
