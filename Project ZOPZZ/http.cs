using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Project_ZOPZZ
{
    class http
    {

        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            using (WebClient wc = new WebClient())
                return wc.UploadValues(uri, pairs);
        }

    }
}
