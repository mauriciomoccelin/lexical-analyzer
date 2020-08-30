using System.Linq;
using Analyser.Lexical;

namespace Analyzer.Syntactic
{
    public static class First
    {
        private static readonly TokenTypeEnum[] types = {
            TokenTypeEnum.TypeInt,
            TokenTypeEnum.TypeChar,
            TokenTypeEnum.TypeFloat,
        };

        private static readonly TokenTypeEnum[] command = {
            TokenTypeEnum.Identifier
        };
        
        public static bool IsVariableDeclaration(this Token token)
        {
            return types.Contains(token.Type);
        }
        
        public static bool IsIdentifier(this Token token)
        {
            return token.Type == TokenTypeEnum.Identifier;
        }

        public static bool IsComma(this Token token)
        {
            return token.Type == TokenTypeEnum.Comma;
        }
        
        public static bool IsCommand(this Token token)
        {
            return command.Contains(token.Type);
        }
    }
}