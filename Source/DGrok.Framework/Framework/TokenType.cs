// DGrok Delphi parser
// Copyright (C) 2007 Joe White
// http://www.excastle.com/dgrok
//
// Licensed under the Open Software License version 3.0
// http://www.opensource.org/licenses/osl-3.0.php
using System;
using System.Collections.Generic;
using System.Text;

namespace DGrok.Framework
{
    public enum TokenType
    {
        // Sentinel
        EndOfFile,
        // Comments
        SingleLineComment,
        CurlyBraceComment,
        ParenStarComment,
        CompilerDirective,
        // Values
        Identifier,
        Number,
        StringLiteral,
        #region Semikeywords (context keywords, can be used as identifiers)
        AbsoluteSemikeyword,
        AbstractSemikeyword,
        AssemblerSemikeyword,
        AtSemikeyword,
        AutomatedSemikeyword,
        CdeclSemikeyword,
        ContainsSemikeyword,
        DefaultSemikeyword,
        DeprecatedSemikeyword,
        DispIdSemikeyword,
        DynamicSemikeyword,
        ExperimentalSemikeyword,
        ExportSemikeyword,
        ExternalSemikeyword,
        FarSemikeyword,
        FinalSemikeyword,
        ForwardSemikeyword,
        HelperSemikeyword,
        ImplementsSemikeyword,
        IndexSemikeyword,
        LocalSemikeyword,
        MessageSemikeyword,
        NameSemikeyword,
        NearSemikeyword,
        NoDefaultSemikeyword,
        OnSemikeyword,
        OperatorSemikeyword,
        OutSemikeyword,
        OverloadSemikeyword,
        OverrideSemikeyword,
        PackageSemikeyword,
        PascalSemikeyword,
        PlatformSemikeyword,
        PrivateSemikeyword,
        ProtectedSemikeyword,
        PublicSemikeyword,
        PublishedSemikeyword,
        ReadSemikeyword,
        ReadOnlySemikeyword,
        RegisterSemikeyword,
        ReintroduceSemikeyword,
        RequiresSemikeyword,
        ResidentSemikeyword,
        SafecallSemikeyword,
        SealedSemikeyword,
        StaticSemikeyword,
        StdcallSemikeyword,
        StoredSemikeyword,
        StrictSemikeyword,
        UnsafeSemikeyword,
        VarArgsSemikeyword,
        VirtualSemikeyword,
        WriteSemikeyword,
        WriteOnlySemikeyword,
        #endregion
        #region Real keywords (can't be used as identifiers, except after '.')
        AndKeyword,
        ArrayKeyword,
        AsKeyword,
        AsmKeyword,
        BeginKeyword,
        CaseKeyword,
        ClassKeyword,
        ConstKeyword,
        ConstructorKeyword,
        DestructorKeyword,
        DispInterfaceKeyword,
        DivKeyword,
        DoKeyword,
        DownToKeyword,
        ElseKeyword,
        EndKeyword,
        ExceptKeyword,
        ExportsKeyword,
        FileKeyword,
        FinalizationKeyword,
        FinallyKeyword,
        ForKeyword,
        FunctionKeyword,
        GotoKeyword,
        IfKeyword,
        ImplementationKeyword,
        InKeyword,
        InheritedKeyword,
        InitializationKeyword,
        InlineKeyword,
        InterfaceKeyword,
        IsKeyword,
        LabelKeyword,
        LibraryKeyword,
        ModKeyword,
        NilKeyword,
        NotKeyword,
        ObjectKeyword,
        OfKeyword,
        OrKeyword,
        PackedKeyword,
        ProcedureKeyword,
        ProgramKeyword,
        PropertyKeyword,
        RaiseKeyword,
        RecordKeyword,
        RepeatKeyword,
        ResourceStringKeyword,
        SetKeyword,
        ShlKeyword,
        ShrKeyword,
        StringKeyword,
        ThenKeyword,
        ThreadVarKeyword,
        ToKeyword,
        TryKeyword,
        TypeKeyword,
        UnitKeyword,
        UntilKeyword,
        UsesKeyword,
        VarKeyword,
        WhileKeyword,
        WithKeyword,
        XorKeyword,
        #endregion
        // Equality / inequality / assignment
        ColonEquals,
        EqualSign,
        GreaterOrEqual,
        GreaterThan,
        LessOrEqual,
        LessThan,
        NotEqual,
        // Punctuation
        AtSign,
        Caret,
        CloseBracket,
        CloseParenthesis,
        Colon,
        Comma,
        DivideBySign,
        Dot,
        DotDot,
        MinusSign,
        OpenBracket,
        OpenParenthesis,
        PlusSign,
        Semicolon,
        TimesSign,
    }
}
