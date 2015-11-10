//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Expr.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class ExprParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, ID=8, INT=9, NEWLINE=10, 
		WS=11;
	public const int
		RULE_prog = 0, RULE_stat = 1, RULE_expr = 2;
	public static readonly string[] ruleNames = {
		"prog", "stat", "expr"
	};

	private static readonly string[] _LiteralNames = {
		null, "'='", "'*'", "'/'", "'+'", "'-'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "ID", "INT", "NEWLINE", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Expr.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public ExprParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgContext : ParserRuleContext {
		public StatContext[] stat() {
			return GetRuleContexts<StatContext>();
		}
		public StatContext stat(int i) {
			return GetRuleContext<StatContext>(i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(Context, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 7;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			do {
				{
				{
				State = 6; stat();
				}
				}
				State = 9;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__5) | (1L << ID) | (1L << INT) | (1L << NEWLINE))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatContext : ParserRuleContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode NEWLINE() { return GetToken(ExprParser.NEWLINE, 0); }
		public ITerminalNode ID() { return GetToken(ExprParser.ID, 0); }
		public StatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stat; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterStat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitStat(this);
		}
	}

	[RuleVersion(0)]
	public StatContext stat() {
		StatContext _localctx = new StatContext(Context, State);
		EnterRule(_localctx, 2, RULE_stat);
		try {
			State = 20;
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 11; expr(0);
				State = 12; Match(NEWLINE);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 14; Match(ID);
				State = 15; Match(T__0);
				State = 16; expr(0);
				State = 17; Match(NEWLINE);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 19; Match(NEWLINE);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ITerminalNode INT() { return GetToken(ExprParser.INT, 0); }
		public ITerminalNode ID() { return GetToken(ExprParser.ID, 0); }
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 29;
			switch (TokenStream.La(1)) {
			case INT:
				{
				State = 23; Match(INT);
				}
				break;
			case ID:
				{
				State = 24; Match(ID);
				}
				break;
			case T__5:
				{
				State = 25; Match(T__5);
				State = 26; expr(0);
				State = 27; Match(T__6);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.Lt(-1);
			State = 39;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 37;
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 31;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 32;
						_la = TokenStream.La(1);
						if ( !(_la==T__1 || _la==T__2) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
						    Consume();
						}
						State = 33; expr(6);
						}
						break;
					case 2:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 34;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 35;
						_la = TokenStream.La(1);
						if ( !(_la==T__3 || _la==T__4) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
						    Consume();
						}
						State = 36; expr(5);
						}
						break;
					}
					} 
				}
				State = 41;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 5);
		case 1: return Precpred(Context, 4);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\r-\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x3\x2\x6\x2\n\n\x2\r\x2\xE\x2\v\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3\x17\n\x3\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4 \n\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3"+
		"\x4\a\x4(\n\x4\f\x4\xE\x4+\v\x4\x3\x4\x2\x3\x6\x5\x2\x4\x6\x2\x4\x3\x2"+
		"\x4\x5\x3\x2\x6\a\x30\x2\t\x3\x2\x2\x2\x4\x16\x3\x2\x2\x2\x6\x1F\x3\x2"+
		"\x2\x2\b\n\x5\x4\x3\x2\t\b\x3\x2\x2\x2\n\v\x3\x2\x2\x2\v\t\x3\x2\x2\x2"+
		"\v\f\x3\x2\x2\x2\f\x3\x3\x2\x2\x2\r\xE\x5\x6\x4\x2\xE\xF\a\f\x2\x2\xF"+
		"\x17\x3\x2\x2\x2\x10\x11\a\n\x2\x2\x11\x12\a\x3\x2\x2\x12\x13\x5\x6\x4"+
		"\x2\x13\x14\a\f\x2\x2\x14\x17\x3\x2\x2\x2\x15\x17\a\f\x2\x2\x16\r\x3\x2"+
		"\x2\x2\x16\x10\x3\x2\x2\x2\x16\x15\x3\x2\x2\x2\x17\x5\x3\x2\x2\x2\x18"+
		"\x19\b\x4\x1\x2\x19 \a\v\x2\x2\x1A \a\n\x2\x2\x1B\x1C\a\b\x2\x2\x1C\x1D"+
		"\x5\x6\x4\x2\x1D\x1E\a\t\x2\x2\x1E \x3\x2\x2\x2\x1F\x18\x3\x2\x2\x2\x1F"+
		"\x1A\x3\x2\x2\x2\x1F\x1B\x3\x2\x2\x2 )\x3\x2\x2\x2!\"\f\a\x2\x2\"#\t\x2"+
		"\x2\x2#(\x5\x6\x4\b$%\f\x6\x2\x2%&\t\x3\x2\x2&(\x5\x6\x4\a\'!\x3\x2\x2"+
		"\x2\'$\x3\x2\x2\x2(+\x3\x2\x2\x2)\'\x3\x2\x2\x2)*\x3\x2\x2\x2*\a\x3\x2"+
		"\x2\x2+)\x3\x2\x2\x2\a\v\x16\x1F\')";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}