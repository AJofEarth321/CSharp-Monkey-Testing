using System;

namespace MonkeyTesting
{
    public class MonkeyTrouble
    {

        /// <summary>
        /// Takes boolean values representing two monkeys, A and B, and returns a boolean based on whether
        /// both monkeys are smiling or if neither is smiling. If both or neither are smiling, the boolean
        /// returns true and "we are in trouble". Otherwise, boolean returns false. Possible input values
        /// and the expected returns:
        /// MonkeyTrouble(true, true) --> true
        /// MonkeyTrouble(false, false) --> true
        /// MonkeyTrouble(true, false) --> false
        /// MonkeyTouble(false, true) --> false
        /// </summary>
        /// <param name="aSmile">monkey A</param>
        /// <param name="bSmile">monkey B</param>
        /// <returns>bool of true/false</retuns>
        public bool Trouble(bool aSmile, bool bSmile) => aSmile == bSmile;
        
    }
}
