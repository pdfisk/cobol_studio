using CobolStudio.src.api;
using CobolStudio.src.compiler;
using static MyChatDB.src.constants.SharedConstants;


namespace MyChatDB.src.services
{
    internal class CompilerService
    {
        static CompilerService _instance;
        CompilerApi _compilerApi;

        public static CompilerService getInstance()
        {
            if (_instance == null)
            {
                _instance = new CompilerService();
            }
            return _instance;
        }

        CompilerService()
        {
            _compilerApi = new CompilerApi();
        }

        public static object Perform(string command, string jsonArg)
        {
            var value = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(jsonArg);
            switch (command.ToLower())
            {
                case COMPILE_COBOL:
                    return getInstance().CompileCobol(value.ToString());
                default:
                    return @"UNKNOWN COMMAND ${command}";
            }
        }

        object CompileCobol(string fileName)
        {
            return CobolCompiler.CompileFile(fileName);
        }
    }
}
