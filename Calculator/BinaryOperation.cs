using System;

namespace Calculator
{
    public class BinaryOperation
    {
        public uint And(uint arg1, uint arg2)
        {
            uint result;
            result =arg1 & arg2;
            return result;
        }
        
        public uint Or(uint arg1, uint arg2)
        {
           uint result;
            result =arg1 | arg2;
            return result;
        }
        
        public uint Xor(uint arg1, uint arg2)
        {
           
            uint result;
            result =arg1 ^ arg2;
            return result;
        }
        
        public uint Not(uint arg1)
        {
            uint result;
            result =~(arg1);
            return result;
        }
    }
}