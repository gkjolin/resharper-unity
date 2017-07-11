﻿using System.Collections.Generic;
using JetBrains.ReSharper.Plugins.Unity.Psi.ShaderLab.Parsing;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.ReSharper.Psi.Impl;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.Util;
using JetBrains.Text;
using JetBrains.Util;

namespace JetBrains.ReSharper.Plugins.Unity.Psi.ShaderLab
{
    [Language(typeof(ShaderLabLanguage))]
    public class ShaderLabLanguageService : LanguageService
    {
        private readonly CommonIdentifierIntern myCommonIdentifierIntern;

        public ShaderLabLanguageService(ShaderLabLanguage psiLanguageType, IConstantValueService constantValueService, CommonIdentifierIntern commonIdentifierIntern)
            : base(psiLanguageType, constantValueService)
        {
            myCommonIdentifierIntern = commonIdentifierIntern;
        }

        public override ILexerFactory GetPrimaryLexerFactory()
        {
            return new ShaderLabLexerFactory();
        }

        public override ILexer CreateFilteringLexer(ILexer lexer)
        {
            return new ShaderLabFilteringLexer(lexer);
        }

        public override IParser CreateParser(ILexer lexer, IPsiModule module, IPsiSourceFile sourceFile)
        {
            return new ShaderLabParser(lexer as ILexer<int> ?? lexer.ToCachingLexer(), myCommonIdentifierIntern);
        }

        public override IEnumerable<ITypeDeclaration> FindTypeDeclarations(IFile file)
        {
            return EmptyList<ITypeDeclaration>.Enumerable;
        }

        public override ILanguageCacheProvider CacheProvider => null;
        public override bool IsCaseSensitive => true;
        public override bool SupportTypeMemberCache => false;
        public override ITypePresenter TypePresenter => DefaultTypePresenter.Instance;

        private class ShaderLabLexerFactory : ILexerFactory
        {
            public ILexer CreateLexer(IBuffer buffer)
            {
                return new ShaderLabLexerGenerated(buffer);
            }
        }
    }
}