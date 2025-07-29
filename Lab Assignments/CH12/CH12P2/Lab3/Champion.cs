﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Champion
    {
        // instances
        private string _name;
        private ChampionType _type;
        private Ability _leftMouse;
        private Ability _rightMouse;
        private Ability _q;
        private Ability _f;
        private Ability _e;

        // constructor
        public Champion(string name, ChampionType type, Ability leftMouse, Ability rightMouse, Ability q, Ability f, Ability e)
        {
            _name = name;
            _type = type;
            _leftMouse = leftMouse;
            _rightMouse = rightMouse;
            _q = q;
            _f = f;
            _e = e;
        }

        // getter properties
        public string Name { get { return _name; } }
        public ChampionType Type { get { return _type; } }
        public Ability LeftMouse { get { return _leftMouse; } }
        public Ability RightMouse { get { return _rightMouse; } }
        public Ability Q { get { return _q; } }
        public Ability E { get { return _e; } } 
        public Ability F { get { return _f; } }
    }
}
