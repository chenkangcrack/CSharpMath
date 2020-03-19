namespace CSharpMath {
  using System.Collections.Generic;
  public static class Settings {
    public static bool DisableEnhancedTextPainterColors {
      get => Rendering.Text.TextLaTeXBuilder.NoEnhancedColors;
      set => Rendering.Text.TextLaTeXBuilder.NoEnhancedColors = value;
    }
    public static Rendering.BackEnd.Typefaces GlobalTypefaces =>
      Rendering.BackEnd.Fonts.GlobalTypefaces;
    public static Structures.BiDictionary<string, Structures.Color> PredefinedColors =>
      Structures.Color.PredefinedColors;
    public static Structures.AliasDictionary<string, string> PredefinedBoundaryDelimiters =>
      Atom.LaTeXDefaults.BoundaryDelimiters;
    public static Structures.AliasDictionary<string, Atom.FontStyle> PredefinedFontStyles =>
      Atom.FontStyleExtensions.FontStyles;
    public static Structures.AliasDictionary<string, Atom.MathAtom> PredefinedLaTeXMathSymbols =>
      Atom.LaTeXDefaults.Commands;
    public static Structures.BiDictionary<string, string> PredefinedLaTeXTextAccents =>
      Rendering.Text.TextAtoms.PredefinedAccents;
    public static Structures.AliasDictionary<string, string> PredefinedLaTeXTextSymbols =>
      Rendering.Text.TextAtoms.PredefinedTextSymbols;
    public static Dictionary<string, Structures.Space> PredefinedLengthUnits =>
      Structures.Space.PredefinedLengthUnits;
  }
}
