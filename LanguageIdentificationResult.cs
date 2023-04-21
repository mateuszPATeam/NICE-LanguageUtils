using Direct.Shared;

namespace NICE_LanguageUtils
{
    [DirectDom("Language Identification Result", "General")]
    public class LanguageIdentificationResult : DirectComponentBase
    {
        protected PropertyHolder<string> _EnglishName = new PropertyHolder<string>("English Name");
        protected PropertyHolder<string> _NativeName = new PropertyHolder<string>("Native Name");
        protected PropertyHolder<string> _TwoLetterName = new PropertyHolder<string>("Two Letter Name");
        protected PropertyHolder<string> _ThreeLetterName = new PropertyHolder<string>("Three Letter Name");

        [DirectDom("English Name")]
        [DesignTimeInfo("English Name")]
        public string EnglishName
        {
            get { return _EnglishName.TypedValue; }
            set { _EnglishName.TypedValue = value; }
        }

        [DirectDom("Native Name")]
        [DesignTimeInfo("Native Name")]
        public string NativeName
        {
            get { return _NativeName.TypedValue; }
            set { _NativeName.TypedValue = value; }
        }
        [DirectDom("Two Letter Name")]
        [DesignTimeInfo("Two Letter Name")]

        public string TwoLetterName
        {
            get { return _TwoLetterName.TypedValue; }
            set { _TwoLetterName.TypedValue = value; }
        }

        [DirectDom("Three Letter Name")]
        [DesignTimeInfo("Three Letter Name")]
        public string ThreeLetterName
        {
            get { return _ThreeLetterName.TypedValue; }
            set { _ThreeLetterName.TypedValue = value; }
        }

        public LanguageIdentificationResult()
        {

        }

        public LanguageIdentificationResult(IProject project) : base(project)
        {
        }

    }
}
