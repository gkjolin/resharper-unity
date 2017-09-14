﻿using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.Plugins.Unity.Cg.Psi.Parsing.TokenNodeTypes
{
    public partial class CgTokenNodeTypes
    {
        public const int IDENTIFIER_NODE_TYPE_INDEX = LAST_GENERATED_TOKEN_TYPE_INDEX + 4;
        
        public static readonly TokenNodeType BAD_CHARACTER = new CgGenericTokenNodeType("BAD_CHARACTER", LAST_GENERATED_TOKEN_TYPE_INDEX + 1, "�");
        
        public static readonly TokenNodeType WHITESPACE = new CgWhitespaceTokenNodeType(LAST_GENERATED_TOKEN_TYPE_INDEX + 2);
        
        public static readonly TokenNodeType NEW_LINE = new CgNewLineTokenNodeType(LAST_GENERATED_TOKEN_TYPE_INDEX + 3);
        
        public static readonly TokenNodeType IDENTIFIER = new CgIdentifierTokenNodeType(IDENTIFIER_NODE_TYPE_INDEX);
        
        public static readonly TokenNodeType SINGLE_LINE_COMMENT = new CgSingleLineCommentTokenNodeType(LAST_GENERATED_TOKEN_TYPE_INDEX + 5);
        
        public static readonly TokenNodeType EOF = new CgGenericTokenNodeType("EOF", LAST_GENERATED_TOKEN_TYPE_INDEX + 6, "EOF");
        
        public static readonly TokenNodeType NUMERIC_LITERAL = new CgNumericLiteralTokenNodeType(LAST_GENERATED_TOKEN_TYPE_INDEX + 7);
        
        public static readonly TokenNodeType DIRECTIVE_CONTENT = new CgFilteredGenericTokenNodeType("DIRECTIVE_CONTENT", LAST_GENERATED_TOKEN_TYPE_INDEX + 9, "directive");
        
        public static readonly TokenNodeType CODE_DIRECTIVE_CONTENT = new CgFilteredGenericTokenNodeType("CODE_DIRECTIVE_CONTENT", LAST_GENERATED_TOKEN_TYPE_INDEX + 10, "code");
        
        public static readonly TokenNodeType INCLUDE_DIRECTIVE_CONTENT = new CgFilteredGenericTokenNodeType("INCLUDE_DIRECTIVE_CONTENT", LAST_GENERATED_TOKEN_TYPE_INDEX + 11, "include");
    }
}