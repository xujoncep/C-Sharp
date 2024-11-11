namespace Intermediate
{
    public class HttpCookie
    {
        // cookie with indexer
        private readonly Dictionary<string, string> _dictonary;
        public HttpCookie()
        {
            _dictonary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictonary[key]; }
            set { _dictonary[key] = value; }
        }
    }
    
}
