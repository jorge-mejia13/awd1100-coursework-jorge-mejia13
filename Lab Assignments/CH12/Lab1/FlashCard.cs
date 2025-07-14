using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class FlashCard
    {
        // variables
        private string _term;
        private string _definition;

        //public string Term
        //{
        //    get => _term;
        //    set => _term = value;
        //}

        //public string Definition
        //{
        //    get => _definition;
        //    set => _definition = value;
        //}


        public FlashCard(string term, string definition)
        {
            _term = term;
            _definition = definition;
        }

        public void SetTerm(string term)
        {
            _term = term;
        }

        public void SetDefinition(string definition)
        {
            _definition = definition;
        }

        public string GetTerm()
        {
            return _term;
        }

        public string GetDefinition()
        {
            return _definition;
        }

    } 
}
