using CobolStudio.src.api;
using CobolStudio.src.compiler;
using static MyChatDB.src.constants.SharedConstants;


namespace MyChatDB.src.services
{
    internal class ParserService
    {
        static ParserService _instance;
        CompilerApi _compilerApi;

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
            _compilerApi = new CompilerApi();
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
            return CobolCompiler.CompileFile(fileName);
        }
    }
}
