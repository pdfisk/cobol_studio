using CobolStudio.src.api;
using static MyChatDB.src.constants.SharedConstants;


namespace MyChatDB.src.services
{
    internal class ParserService
    {
        static ParserService _instance;
        ParserApi _parserApi;

        public static ParserService getInstance()
        {
            if (_instance == null)
            {
                _instance = new ParserService();
            }
            return _instance;
        }

        ParserService()
        {
            _parserApi = new ParserApi();
        }

        public static string Perform(string command, string jsonArg)
        {
            var value = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(jsonArg);
            switch (command.ToLower())
            {
                case PARSE_COBOL:
                    return getInstance().ParseCobol(value.ToString());
                default:
                    return @"UNKNOWN COMMAND ${command}";
            }
        }

        string ParseCobol(string fileName)
        {
            return _parserApi.ParseFile(fileName);
        }
    }
}
