using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OCL1_Proyecto1_201800499
{
    class LexicalAnalyzer
    {
        public Queue<Token> tokens = new Queue<Token>();

        public LexicalAnalyzer(string texto)
        {
           
            string[] lineas = Regex.Split(texto, "\r\n|\r|\n");
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] palabras = Regex.Replace(lineas[i], @"\t|\n|\r", " ").Split(new[] { ' ' });
                for (int j = 0; j < palabras.Length; j++)
                {
                    analyzeLexeme(palabras[j], i + 1, j + 1);
                }
            }
        }

        private void analyzeLexeme(string lexeme, int row, int col)
        {
            if (lexeme == "}") tokens.Enqueue(new Token("}", row, col, TypeToken.CloseFile));
            else if (lexeme == "!>") tokens.Enqueue(new Token("!>", row, col, TypeToken.CommentaryClose));
            else if (lexeme == "//") tokens.Enqueue(new Token("//", row, col, TypeToken.CommentaryLine));
            else if (lexeme == "<!") tokens.Enqueue(new Token("<!", row, col, TypeToken.CommentaryOpen));
            else if (lexeme == "CONJ") tokens.Enqueue(new Token("CONJ", row, col, TypeToken.CONJ));
            else if (lexeme == ":") tokens.Enqueue(new Token(":", row, col, TypeToken.DoublyPoints));
            else if (lexeme == "%%") tokens.Enqueue(new Token("%%", row, col, TypeToken.EndOfER));
            
        }
    }
}
