using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake_TaskPerformance.Properties;

namespace Snake_TaskPerformance
{

    public enum Direction { Up, Down, Left, Right };

    class GameSettings
    {
        public static SolidBrush snakeHead { get; set; }
        public static SolidBrush snakeBody { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool Gameover { get; set; }
        public static Direction direction { get; set; }
        public static ArrayList ColorList { get; set; } = new ArrayList(){
                    "AliceBlue",
                    "AntiqueWhite",
                    "Aqua",
                    "Aquamarine",
                    "Azure",
                    "Beige",
                    "Bisque",
                    "Black",
                    "BlanchedAlmond",
                    "Blue",
                    "BlueViolet",
                    "Brown",
                    "BurlyWood",
                    "CadetBlue",
                    "Chartreuse",
                    "Chocolate",
                    "Coral",
                    "CornflowerBlue",
                    "Cornsilk",
                    "Crimson",
                    "Cyan",
                    "DarkBlue",
                    "DarkCyan",
                    "DarkGoldenRod",
                    "DarkGray",
                    "DarkGrey",
                    "DarkGreen",
                    "DarkKhaki",
                    "DarkMagenta",
                    "DarkOliveGreen",
                    "DarkOrange",
                    "DarkOrchid",
                    "DarkRed",
                    "DarkSeaGreen",
                    "DarkSlateBlue",
                    "DarkSlateGray",
                    "DarkSlateGrey",
                    "DarkTurquoise",
                    "DarkViolet",
                    "DeepPink",
                    "DeepSkyBlue",
                    "DimGray",
                    "DimGrey",
                    "DodgerBlue",
                    "FireBrick",
                    "FloralWhite",
                    "ForestGreen",
                    "Fuchsia",
                    "Gainsboro",
                    "GhostWhite",
                    "Gold",
                    "GoldenRod",
                    "Gray",
                    "Grey",
                    "Green",
                    "GreenYellow",
                    "HoneyDew",
                    "HotPink",
                    "IndianRed",
                    "Indigo",
                    "Ivory",
                    "Khaki",
                    "Lavender",
                    "LavenderBlush",
                    "LawnGreen",
                    "LemonChiffon",
                    "LightBlue",
                    "LightCoral",
                    "LightCyan",
                    "LightGoldenRodYellow",
                    "LightGray",
                    "LightGrey",
                    "LightGreen",
                    "LightPink",
                    "LightSalmon",
                    "LightSeaGreen",
                    "LightSkyBlue",
                    "LightSlateGray",
                    "LightSlateGrey",
                    "LightSteelBlue",
                    "LightYellow",
                    "Lime",
                    "LimeGreen",
                    "Linen",
                    "Magenta",
                    "Maroon",
                    "MediumAquaMarine",
                    "MediumBlue",
                    "MediumOrchid",
                    "MediumPurple",
                    "MediumSeaGreen",
                    "MediumSlateBlue",
                    "MediumSpringGreen",
                    "MediumTurquoise",
                    "MediumVioletRed",
                    "MidnightBlue",
                    "MintCream",
                    "MistyRose",
                    "Moccasin",
                    "NavajoWhite",
                    "Navy",
                    "OldLace",
                    "Olive",
                    "OliveDrab",
                    "Orange",
                    "OrangeRed",
                    "Orchid",
                    "PaleGoldenRod",
                    "PaleGreen",
                    "PaleTurquoise",
                    "PaleVioletRed",
                    "PapayaWhip",
                    "PeachPuff",
                    "Peru",
                    "Pink",
                    "Plum",
                    "PowderBlue",
                    "Purple",
                    "RebeccaPurple",
                    "Red",
                    "RosyBrown",
                    "RoyalBlue",
                    "SaddleBrown",
                    "Salmon",
                    "SandyBrown",
                    "SeaGreen",
                    "SeaShell",
                    "Sienna",
                    "Silver",
                    "SkyBlue",
                    "SlateBlue",
                    "SlateGray",
                    "SlateGrey",
                    "Snow",
                    "SpringGreen",
                    "SteelBlue",
                    "Tan",
                    "Teal",
                    "Thistle",
                    "Tomato",
                    "Turquoise",
                    "Violet",
                    "Wheat",
                    "White",
                    "WhiteSmoke",
                    "Yellow",
                    "YellowGreen"
                };

        public GameSettings()
        {
            Width = 16;
            Height = 16;
            Speed = 8;
            Score = 0;
            Points = Convert.ToInt32(Settings.Default["point_per_food"]);
            Gameover = false;
            direction = Direction.Down;
            snakeHead = new SolidBrush(Color.FromName(Settings.Default["snake_head"].ToString()));
            snakeBody = new SolidBrush(Color.FromName(Settings.Default["snake_body"].ToString()));
        }

    }
}

