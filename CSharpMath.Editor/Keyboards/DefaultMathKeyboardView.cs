using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSharpMath.Editor {
  using Color = Structures.Color;
  partial class MathKeyboardView<TButton, TLayout> {
    public delegate TButton ButtonCtor(RectangleF frame, string text, float textPtSize, Color title, Color titleShadow, Color highlightedTitle, Color? disabled);
    public static readonly Color DefaultTitle = new Color(0f, 0f, 0f);
    public static readonly Color DefaultShadow = new Color(0.5f, 0.5f, 0.5f);
    public static readonly Color ToBeReplacedWithImage = new Color(0.2f, 0.2f, 0.2f);
    public static readonly Color DefaultHighlight = new Color(1f, 1f, 1f);
    public static readonly Color DefaultDisabled = new Color(2f / 3f, 2f / 3f, 2f / 3f);
    public static readonly Color DefaultTitleBar = new Color(0.76862745099999996f, 0.76862745099999996f, 0.76862745099999996f);
    public const float DefaultFontSize = 20;

    public static MathKeyboardView<TButton, TLayout> Default(ButtonCtor ctor, Func<TLayout> layoutCtor, Action<TButton, EventHandler> registerPressed) {
      return new MathKeyboardView<TButton, TLayout>(
        layoutCtor,
        registerPressed,
        new RectangleF(0, 0, 320, 225),
        ctor(new RectangleF(0, 0, 40, 45), Constants.KeyboardSymbols.Left, DefaultFontSize, DefaultTitleBar, DefaultShadow, DefaultHighlight, null),
        new MathKeyboard<TButton, TLayout>(layoutCtor,
          registerPressed,
          new RectangleF(0, 45, 320, 180),
#warning Replace Constants.KeyboardSymbols.Fraction with image
          ctor(new RectangleF(0, 90, 49.5f, 45), Constants.KeyboardSymbols.Fraction, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          ctor(new RectangleF(199, 45, 49, 45), Constants.Symbols.Multiplication, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(149, 135, 50, 45), "=", 25, DefaultTitle, DefaultShadow, DefaultHighlight, DefaultDisabled),
          ctor(new RectangleF(199, 0, 49, 45), Constants.Symbols.Division, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
#warning Replace Constants.KeyboardSymbols.Exponent with image
          ctor(new RectangleF(0, 135, 50, 45), Constants.KeyboardSymbols.Exponent, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          null,
          null,
          null,
          null,
          null,
          null,
          new[] {
            ctor(new RectangleF(50, 135, 49, 45), "0", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50, 90, 49, 45), "1", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(99.5f, 90, 49.5f, 45), "2", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(149, 90, 50, 45), "3", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50, 45, 49, 45), "4", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(99.5f, 45, 49.5f, 45), "5", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(149, 45, 50, 45), "6", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50, 0, 49, 45), "7", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(99.5f, 0, 49.5f, 45), "8", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(149, 0, 50, 45), "9", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(99.5f, 135, 49.5f, 45), ".", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 135, 49.5f, 45), "+", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 90, 49.5f, 45), "-", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          },
          new[] {
            ctor(new RectangleF(0, 0, 49.5f, 45), "x", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(0, 45, 49.5f, 45), "y", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          },
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          ctor(new RectangleF(248.5f, 0, 71.5f, 45), Constants.KeyboardSymbols.Back, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(248.5f, 135, 71.5f, 45), Constants.KeyboardSymbols.Dismiss, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(248.5f, 45, 71.5f, 90), Constants.KeyboardSymbols.Enter, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null)
        ),
        ctor(new RectangleF(40, 0, 60, 45), "123", DefaultFontSize, DefaultTitleBar, DefaultShadow, DefaultHighlight, null),
        new MathKeyboard<TButton, TLayout>(layoutCtor,
          registerPressed,
          new RectangleF(0, 45, 320, 180),
          ctor(new RectangleF(0, 90, 50, 45), Constants.KeyboardSymbols.Fraction, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          null,
          null,
          null,
#warning Replace Constants.KeyboardSymbols.Exponent with image
          ctor(new RectangleF(0, 135, 50, 45), Constants.KeyboardSymbols.Exponent, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          null,
          null,
          null,
          null,
          null,
            ctor(new RectangleF(150, 90, 49, 45), Constants.KeyboardSymbols.Absolute, 24, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          null,
          new[] {
            ctor(new RectangleF(0, 0, 50, 45), "x", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(0, 45, 50, 45), "y", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          },
          null,
          new[] {
            ctor(new RectangleF(50, 90, 50, 45), "{", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(100, 45, 50, 45), "]", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(150, 45, 49, 45), Constants.Symbols.LessEqual, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50, 0, 50, 45), "(", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(100, 0, 50, 45), ")", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(150, 0, 49, 45), "<", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(100, 135, 50, 45), Constants.Symbols.Infinity, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50, 135, 50, 45), "!", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 90, 50, 45), "%", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 45, 50, 45), Constants.Symbols.GreaterEqual, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 0, 50, 45), ">", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(150, 135, 49, 45), ":", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 135, 50, 45), ",", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50, 45, 50, 45), "[", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(100, 90, 50, 45), "}", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null)
          },
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          ctor(new RectangleF(249, 0, 71, 45), Constants.KeyboardSymbols.Back, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          ctor(new RectangleF(249, 135, 71, 45), Constants.KeyboardSymbols.Dismiss, DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(249, 45, 71, 90), Constants.KeyboardSymbols.Enter, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null)
        ),
        ctor(new RectangleF(100, 0, 60, 45), "()<>", DefaultFontSize, DefaultTitleBar, DefaultShadow, DefaultHighlight, null),
        new MathKeyboard<TButton, TLayout>(layoutCtor,
          registerPressed,
          new RectangleF(0, 45, 320, 180),
          ctor(new RectangleF(0, 90, 49.5f, 45), Constants.KeyboardSymbols.Fraction, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          null,
          null,
          null,
          ctor(new RectangleF(0, 135, 50, 45), Constants.KeyboardSymbols.Exponent, 18, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          ctor(new RectangleF(50, 135, 50, 45), Constants.KeyboardSymbols.Subscript, DefaultFontSize, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          null,
          ctor(new RectangleF(100, 135, 50, 45), Constants.KeyboardSymbols.SquareRoot, DefaultFontSize, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          ctor(new RectangleF(150, 135, 49, 45), Constants.KeyboardSymbols.NthRoot, DefaultFontSize, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, DefaultDisabled),
          ctor(new RectangleF(150, 90, 49, 45), Constants.KeyboardSymbols.LogBase, DefaultFontSize, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          null,
          null,
          new[] {
              ctor(new RectangleF(0, 0, 50, 45), "x", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
              ctor(new RectangleF(0, 45, 50, 45), "y", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            },
          new[] {
            ctor(new RectangleF(50,90,50,45), "log", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(100, 90, 50, 45), "ln", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50,45,50,45), "sec", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(100,45,50,45), "csc", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(150,45,49,45), "cot", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(50, 0, 50, 45), "sin", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(100, 0, 50, 45), "cos", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(150, 0, 49, 45), "tan", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            #warning Replace "sqrt", "root" and "sub" with image
            #warning subscript button should get its own argument
            ctor(new RectangleF(199, 45, 50, 45), "π", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 0, 50, 45), "θ", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(199, 135, 50, 45), "°", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null), //Should be "˚"?
            ctor(new RectangleF(199, 90, 50, 45), "∠", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            #warning log with base should get its own argument
          },
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          ctor(new RectangleF(249, 0, 71, 45), Constants.KeyboardSymbols.Back, DefaultFontSize, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          ctor(new RectangleF(249, 135, 71, 45), Constants.KeyboardSymbols.Dismiss, DefaultFontSize, ToBeReplacedWithImage, DefaultTitle, ToBeReplacedWithImage, null),
          ctor(new RectangleF(249, 45, 71, 90), Constants.KeyboardSymbols.Enter, DefaultFontSize, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null)
        ),
        ctor(new RectangleF(160, 0, 60, 45), "f(x)", DefaultFontSize, DefaultTitleBar, DefaultShadow, DefaultHighlight, null),
        new MathKeyboard<TButton, TLayout>(layoutCtor,
          registerPressed,
          new RectangleF(0, 45, 320, 180),
          null,
          null,
          null,
          null,
          null,
          null,
          ctor(new RectangleF(0, 90, 48, 45), "⇧", 27, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          null,
          new[]{
            ctor(new RectangleF(0, 0, 32, 45), "q", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(32, 0, 32, 45), "w", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(64, 0, 32, 45), "e", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(96, 0, 32, 45), "r", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(128, 0, 32, 45), "t", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(160, 0, 32, 45), "y", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(192, 0, 32, 45), "u", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(224, 0, 32, 45), "i", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(256, 0, 32, 45), "o", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(288, 0, 32, 45), "p", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(16, 45, 32, 45), "a", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(48, 45, 32, 45), "s", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(80, 45, 32, 45), "d", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(112, 45, 32, 45), "f", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(144, 45, 32, 45), "g", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(176, 45, 32, 45), "h", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(208, 45, 32, 45), "j", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(240, 45, 32, 45), "k", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(272, 45, 32, 45), "l", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(48, 90, 32, 45), "z", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(80, 90, 32, 45), "x", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(112, 90, 32, 45), "c", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(144, 90, 32, 45), "v", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(176, 90, 32, 45), "b", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(208, 90, 32, 45), "n", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
            ctor(new RectangleF(240, 90, 32, 45), "m", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null)
          },
          null,
          ctor(new RectangleF(80, 135, 32, 45), "α", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(112, 135, 32, 45), "Δ", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(144, 135, 32, 45), "σ", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(176, 135, 32, 45), "μ", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(208, 135, 32, 45), "λ", DefaultFontSize, DefaultTitle, DefaultShadow, DefaultHighlight, null),
          ctor(new RectangleF(272, 90, 48, 45), Constants.KeyboardSymbols.Back, 27, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          ctor(new RectangleF(0, 135, 80, 45), Constants.KeyboardSymbols.Dismiss, 27, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null),
          ctor(new RectangleF(239, 135, 81, 45), Constants.KeyboardSymbols.Enter, 27, ToBeReplacedWithImage, DefaultShadow, ToBeReplacedWithImage, null)
        ),
        ctor(new RectangleF(220, 0, 60, 45), "abc", DefaultFontSize, DefaultTitleBar, DefaultShadow, DefaultHighlight, null),
        ctor(new RectangleF(280, 0, 40, 45), Constants.KeyboardSymbols.Right, DefaultFontSize, DefaultTitleBar, DefaultShadow, DefaultHighlight, null)
      );
    }
  }
}