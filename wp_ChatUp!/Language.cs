using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace wp_ChatUp_
{
    public class Language
    {
        public string LanguageText { get; set; }

        public Language()
        {

        }

        public List<string> GetLanguages()
        {
            List<string> langsList = new List<string>();
            string languages = null;

            HttpWebRequest language = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/getlanguage.php"));
            language.BeginGetResponse(Message.ShowText, language);

            languages = language.ToString();

            string[] langArray = null;
            int count = 0;
            char[] splitchar = { ',' };
            langArray = languages.Split(splitchar);
            for (count = 0; count <= langArray.Length - 1; count++)
            {
                langsList.Add(langArray[count]);
                System.Diagnostics.Debug.WriteLine(langArray[count].ToString());
            }
            
            return langsList;
        }

    }
}
