using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCL1_Proyecto1_201800499
{
    public enum TypeToken
    {
       CommentaryLine, CommentaryOpen, CommentaryClose, OpenFile, CloseFile, Init, Id, EndOfER, CONJ, Conjunto, Macro, DoublyPoints, Point, Kleene, Positive, Quest, Or, Semicolon
    };

    class Token
    {
        private TypeToken type;
        private string value;
        private int row, col;

        public TypeToken Type { get => type; set => type = value; }
        public string Value { get => value; set => this.value = value; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }

        public Token(string value, int row, int col, TypeToken type)
        {
            this.value = value;
            this.row = row;
            this.col = col;
            this.type = type;
        }

        public string getTipoString()
        {
            switch (this.type)
            {
                case TypeToken.CloseFile:
                    return "Cerrar Archivo";
                case TypeToken.CommentaryClose:
                    return "Cerrar comentario";
                case TypeToken.CommentaryLine:
                    return "Comentario de linea";
                case TypeToken.CommentaryOpen:
                    return "Abrir comentario";
                case TypeToken.CONJ:
                    return "Reservada CONJ";
                case TypeToken.Conjunto:
                    return "Conjunto en ER";
                case TypeToken.DoublyPoints:
                    return "Puntos dobles";
                case TypeToken.EndOfER:
                    return "Fin de las ER";
                case TypeToken.Id:
                    return "Identificador";
                case TypeToken.Init:
                    return "Inicio de declaracion";
                case TypeToken.Kleene:
                    return "Cerradura de Kleene";
                case TypeToken.Macro:
                    return "Declaración conjunto";           
                case TypeToken.OpenFile:
                    return "Abrir documento";
                case TypeToken.Or:
                    return "Disyunción";
                case TypeToken.Point:
                    return "Concatenación";
                case TypeToken.Positive:
                    return "Cerradura positiva";
                case TypeToken.Quest:
                    return "Cerradura interrogacion";
                case TypeToken.Semicolon:
                    return "Punto y coma";
                default:
                    return "Error no programado";

            }
        }

    }
}
