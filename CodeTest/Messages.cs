using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    sealed class Messages
    {

        private readonly eLanguage _language;
        public enum eLanguage { english, french, italian }
        public Messages(eLanguage language)
        {
            _language = language;

        }

        public Messages getMessages()
        {
            if (_language == eLanguage.english)
            {
                DoesNotExist = MessageConfigEnglish.DOES_NOT_EXIST_MESSAGE;
                UnexpectedException = MessageConfigEnglish.UNEXPECTED_EXCEPTION_MESSAGE;
                SelectFile = MessageConfigEnglish.SELECT_FILE_MESSAGE;
                LoadingExcelData = MessageConfigEnglish.LOADING_EXCEL_DATA_MESSAGE;
                LoadingCombo = MessageConfigEnglish.LOADING_COMBO_DATA_MESSAGE;
            }
            // would have all other potential launguages following...


            return this;
            
        }

        

        public string DoesNotExist { get; private set; }
        public string UnexpectedException { get; private set; }
        public string SelectFile { get; private set; }
        public string LoadingExcelData { get; private set; }
        public string LoadingCombo { get; private set; }


    }
}
