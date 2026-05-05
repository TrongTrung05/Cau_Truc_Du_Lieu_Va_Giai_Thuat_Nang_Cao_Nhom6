using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSNew.DataStructures.AVL;
using QLNSNew.DataStructures.RB;
using QLNSNew.Models;

namespace QLNSNew
{
    internal  class AppData
    {
        public static AVLTree AVL = new AVLTree();
        public static List<Word> AVLData = new List<Word>();
        public static RBTree RB = new RBTree();
        public static List<Word> RBData = new List<Word>();

    }
}
