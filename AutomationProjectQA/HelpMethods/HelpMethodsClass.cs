namespace AutomationProjectQA.HelpMethods
{
    public class HelpMethodsClass
    {
        private AppConfigParameters _appConfigParameters;
        private HtmlParser _htmlParser;
        private JavaScriptExecutorClass _javaScriptExecutorClass;
        private RegExp _regExp;
        private XmlParser _xmlParser;

        public AppConfigParameters appConfigParameters => _appConfigParameters ?? (_appConfigParameters = new AppConfigParameters());
        public HtmlParser htmlParser => _htmlParser ?? (_htmlParser = new HtmlParser());
        public JavaScriptExecutorClass javaScriptExecutorClass => _javaScriptExecutorClass ?? (_javaScriptExecutorClass = new JavaScriptExecutorClass());
        public RegExp regExp => _regExp ?? (_regExp = new RegExp());
        public XmlParser xmlParser => _xmlParser ?? (_xmlParser = new XmlParser());
    }
}